namespace demo01;

using System.IO;

class Program
{
    static void Main(string[] args)
    {
        using(FileStream fs = File.Open("somedata.dat", FileMode.Open))
        {
            using(BinaryReader br = new BinaryReader(fs))
            {
                // Where we do the work
                byte[] data = new byte[4];
                for(int i = 0; i < data.Length; i++) {
                    data[i] = br.ReadByte();
                }

                // 1st Byte
                // 3 * 16 = 48
                // 48 + 11 = 59
                //
                // 2nd Byte
                // 1
                //

                Console.WriteLine(data[0]); // 59
                Console.WriteLine(data[1]); // 1
                Console.WriteLine(data[2]); // 215
                Console.WriteLine(data[3]); // 238
                
            }
        }
    }
}
