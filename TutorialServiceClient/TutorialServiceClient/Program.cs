using Newtonsoft.Json;
using System;

namespace TutorialServiceClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new TutorialServicePortClient();

            var request = new getTutorialsRequest();

            var response = client.getTutorials(request);

            var json = JsonConvert.SerializeObject(response, Formatting.Indented);

            Console.WriteLine(json);
        }
    }
}
