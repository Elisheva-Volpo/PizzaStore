using bigPizzaServer.models.models;

namespace bigPizzaServer.Interface
{
    public interface IFile
    {
        string StringPath { get; set; }

        public void Write(string data);

        public void Read(string data);
    }
}
