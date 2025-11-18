
using LogonSession.LogonSession;
using System.Text.Json;

var sessions = UserLogonSession.GetLoggedOnSession();

string json = JsonSerializer.Serialize(sessions, new JsonSerializerOptions()
{
    WriteIndented = true
});
Console.WriteLine(json);

Console.ReadLine();
