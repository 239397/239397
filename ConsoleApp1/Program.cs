using System;

class Program
{
    static void Main()
    {
        // Replace "API_KEY" with the name of your secret
        string apiKey = Environment.GetEnvironmentVariable("API_KEY");

        if (string.IsNullOrEmpty(apiKey))
        {
            Console.WriteLine("API key not found. Make sure the environment variable is set.");
        }
        else
        {
            Console.WriteLine($"API Key: {apiKey}");
            // Use the apiKey in your application logic.
        }
    }
}
