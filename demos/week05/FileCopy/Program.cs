namespace FileCopy;

using FileCopyLib;

class Program
{
    static void Main(string[] args)
    {
        string source = args[0];
        string destination = args[1];
        byte[] buffer = new byte[100];
        FileCopyOperation.Copy(source, destination, buffer);
    
    }
}
