using System.IO;
using System.Text.Json;
using bigPizzaServer.Interface;

namespace FileService;


public class ReadWrite<T> :IFile<T>
{
    //public string StringPath { get; set; }
    public string StringPath { get; set; }

    public ReadWrite()
    {
        this.StringPath = Path.Combine(Environment.CurrentDirectory, "", "log.txt");
    }

    //public void Write(T data, string path)        
    public void Write(T data, string path)
    {
        string str_data = JsonSerializer.Serialize(data);

        if (File.Exists(StringPath))
        {
            File.AppendAllText(StringPath, $"{DateTime.Now} {data}");
        }
    }



    //public List<T> Read(T data,string path)
    public List<T> Read(string path)
    {
        string[] str_data;
        List<T> pi = new List<T>();
        if (File.Exists(path))
        {
            str_data = File.ReadAllLines(path);
            for (int i = 1; i < str_data.Length; i++)
            {
                
                var data = JsonSerializer.Deserialize<T>(str_data[i]);
                pi.Add(data);
            }
        }
        return pi;
    }

    //public void DeleteAllLines(string path)
    public void DeleteAllLines(string path)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
            File.AppendAllText(path, "\n");
        }
    }

}
