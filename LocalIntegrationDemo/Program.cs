using System.IO.Pipelines;
using System.Security.Authentication.ExtendedProtection;
using Polly;
using Polly.Extensions.Http;
using Polly.Timeout;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient("RetryClient")

.AddPolicyHandler(   // Circuit FIRST
    HttpPolicyExtensions
        .HandleTransientHttpError()
        .Or<TaskCanceledException>()
        .Or<TimeoutRejectedException>()
        .CircuitBreakerAsync(
            1,
            TimeSpan.FromSeconds(30),
            onBreak: (result, breakDelay) =>
            {
                Console.WriteLine("Circuit broken!");
            },
            onReset: () =>
            {
                Console.WriteLine("Circuit reset!");
            })
)

.AddPolicyHandler(   // Then Retry
    HttpPolicyExtensions
        .HandleTransientHttpError()
        .Or<TaskCanceledException>()
        .Or<TimeoutRejectedException>()
        .WaitAndRetryAsync(
            3,
            retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)),
            onRetry: (outcome, timespan, retryAttempt, context) =>
            {
                Console.WriteLine($"Retry {retryAttempt} after {timespan.TotalSeconds} seconds");
            }
        )
)
.AddPolicyHandler( // Timeout LAST (innermost)
    Policy.TimeoutAsync<HttpResponseMessage>(5)
);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthorization();
app.MapControllers();
app.Run();