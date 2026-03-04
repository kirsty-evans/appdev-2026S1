namespace FileCopyLib;

using System.IO;

public class FileCopyOperation
{

	public static void Copy(string source, string destination,
		byte[] buffer)
	{

		using(FileStream sourceFS = File.Open(source, FileMode.Open))
		{

			using(FileStream destFS = File.Open(destination,
				FileMode.Create))
			{
				BinaryReader br = new BinaryReader(sourceFS);
				BinaryWriter bw = new BinaryWriter(destFS);

				int bytesRead = br.Read(buffer, 0, buffer.Length);

				while(bytesRead >= buffer.Length)
				{
					Console.WriteLine("Looping?");
					bw.Write(buffer, 0, bytesRead);	
					bytesRead = br.Read(buffer, 0, buffer.Length);
				}
				
				bw.Write(buffer, 0, bytesRead);

				br.Close();
				bw.Close();
				
			}

			
		}
		
	}


}
