using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        WebRequest request = WebRequest.Create("http://www.contoso.com/default.html");
        request.Credentials = CredentialCache.DefaultCredentials;
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Console.WriteLine("Status: 11 + response. Status Description");
        Console.WriteLine(new string('*', 50));
        // Get the stream containing content returned by the server.
        Stream dataStream = response.GetResponseStream();
        // Open the stream using a StreamReader for easy access.
        StreamReader reader = new StreamReader(dataStream);
        string responseFromServer = reader.ReadToEnd();
        Console.WriteLine(responseFromServer);
        Console.WriteLine(new string('*', 50));
        reader.Close();
        dataStream.Close();
        response.Close();
    }
}