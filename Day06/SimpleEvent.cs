namespace Day06;

public class SimpleEvent
{
    static void OnClicked()                           // the listener: shape must match Action (no input, no return)
    {
        Console.WriteLine("Button was clicked");
    }

    public void Run()
    {
        Button button = new Button();
        button.clicked += OnClicked;
        button.Click();
    }
    
}

public class Button
{
    public event Action clicked; // the doorbell. Action = listener takes nothing, returns nothing

    public void Click()
    {
        Console.WriteLine("Button pressed");
        clicked?.Invoke();    // ring the bell. ?. = only if someone is listening
    }
}