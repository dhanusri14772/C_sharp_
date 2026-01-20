using System;
class Button
{
    public event Action clicked; //declaring event "clicked"
    public void click()
    {
        clicked?.Invoke();
    }
}
class Event
{
    static void Main()
    {
        Button b = new Button();
        b.clicked += () => Console.WriteLine("button clicked"); //clicked method is subcribed "+="
        b.click(); 
    }
}