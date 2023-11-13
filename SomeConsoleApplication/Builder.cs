using System;

class Program
{
    static void Main()
    {
        // Create an instance of the Builder class
        Builder builderInstance = new Builder();

        // Call the MethodWillFail method
        builderInstance.MethodWillFail();

        // The rest of your program logic...

        Console.WriteLine("Program completed."); // This line is just to indicate the end of the program
    }
}

public class Builder
{
    public void MethodWillFail() {
        Builder nullBuilder = null;
        nullBuilder.Build();
    }

    public void Build()
    {
        Console.WriteLine("Building something..."); // Actual implementation of the Build method
    }
}
