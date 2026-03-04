namespace FileCopy.Test;

using FileCopyLib;
using System.IO;

public class FileCopyTest
{
    [Fact]
    public void Test_CopySingleFile()
    {
        string source = "File1.txt";
        string destination = "File2.txt";
        byte[] buffer = new byte[50];

        FileCopyOperation.Copy(source, destination, buffer);

        StreamReader sourceReader = new StreamReader(source);
        StreamReader reader = new StreamReader(destination);

        string sourceContents = sourceReader.ReadToEnd();
        string destinationContents = reader.ReadToEnd();

        Assert.Equal(sourceContents, destinationContents);
        
    }
}
