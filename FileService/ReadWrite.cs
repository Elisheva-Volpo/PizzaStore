using System.IO;
using System.Text.Json;
using bigPizzaServer.Interface;

namespace FileService;
public class ReadWrite:IFile
{
    public string StringPath { get; set; }

    public ReadWrite()
    {
        this.StringPath = Path.Combine(Environment.CurrentDirectory, "", "log.txt");
    }

    public void Write(string data)
    {
        if (File.Exists(StringPath))
        {
            File.AppendAllText(StringPath, $"{DateTime.Now} {data}");
        }
    }

    public void Read(string data)
    {
        if (File.Exists(StringPath))
        {
            File.AppendAllText(StringPath, $"{DateTime.Now} {data}");
        }
        
    }

}
