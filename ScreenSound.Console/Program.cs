

using (var client = new HttpClient())
{
    try
    {
        string baseURL = "https://guilhermeonrails.github.io/api-csharp-songs/songs.json";
        string resp =  await client.GetStringAsync(baseURL);
        Console.WriteLine(resp);
    }
    catch (Exception error)
    {
        Console.WriteLine($"Have a problem {error.Message.ToLower()}");
    }

}