using System;
using System.Runtime.CompilerServices; 
using System.Threading.Tasks;
class Statemachineskeleton
{
    static void Main()
    {
        var machine = new MyStateMachine();
        machine.State = -1; 
        machine.MoveNext();

        Console.WriteLine("Main thread is free! Press Enter to exit after the result appears.");
        Console.ReadLine();
    }
}
struct MyStateMachine : IAsyncStateMachine
{
    public int State; 
    private TaskAwaiter _awaiter; // This starts as null!

    public void MoveNext()
    {
        // STATE -1: The "Beginning" of the method
        if (State == -1)
        {
            Console.WriteLine("   [Machine] Starting Work...");
            
            // We assign the awaiter here so it is no longer null
            _awaiter = Task.Delay(1000).GetAwaiter();

            if (!_awaiter.IsCompleted)
            {
                State = 0; // Set bookmark to "waiting"
                Console.WriteLine("   [Machine] Pausing... releasing thread.");
                
                // Tell the task to call this MoveNext method again when done
                _awaiter.OnCompleted(MoveNext); 
                return;
            }
        }

        // STATE 0: The "Resume" point after the await
        if (State == 0)
        {
            // Now we can safely call GetResult because _awaiter was assigned in State -1
            _awaiter.GetResult(); 
            Console.WriteLine("   [Machine] Resumed! Result: 42");
            State = -2; // Mark as finished
        }
    }

    // Required by the interface but not used in this simple skeleton
    public void SetStateMachine(IAsyncStateMachine stateMachine) { }
}