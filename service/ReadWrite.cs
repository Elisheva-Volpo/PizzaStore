using System;
using System.IO;


namespace bigPizzaServer.service;

public class ReadWrite
{
    public void Write()
    {

        FileStream fs=new FileStream("myFile.txt",FileMode.Create,FileAccess.Write);
        StreamWriter write= new StreamWriter(fs);
        write.WriteLine("Thank you hashem!!!!");
        write.Close();
        fs.Close();

    }

    public void Read(){
        FileStream fs=new FileStream("myFile.txt",FileMode.Open,FileAccess.Read);
        StreamReader read=new StreamReader(fs);
        char[] s=new char[100];
        int i = read.ReadBlock(s, 0, 100);
        Console.WriteLine(s);
        read.Close();
        fs.Close();


    }

}