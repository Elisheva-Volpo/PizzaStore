using bigPizzaServer.models.models;

namespace bigPizzaServer.Interface
{
    public interface IFile<T>
    {
        string StringPath { get; set; }

        public void Write(T data,string path);
        public List<T> Read(string path);
        public void DeleteAllLines(string path);
    }
}
