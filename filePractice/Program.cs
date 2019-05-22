using System;
using System.IO;

namespace filePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] lines = System.IO.File.ReadAllLines("/Users/lauracolten/github/example.rtf");
            // foreach(string words in lines)
            // {
            //     Console.WriteLine(words);
            // }

            // string text = "I love cats!";
            // System.IO.File.WriteAllText("/Users/lauracolten/github/example2.rtf", text);

            StreamReader stream = File.OpenText("/Users/lauracolten/github/Example.txt");
            FileStream outStream = File.OpenWrite("/Users/lauracolten/github/Example2.txt");
            StreamWriter s = new StreamWriter(outStream);

            string line = stream.ReadLine();

            while (line != null)
            {
                // Console.WriteLine(line);
                s.WriteLine(line);
                line = stream.ReadLine();
            }

            FileStream picReader = File.OpenRead("/Users/lauracolten/github/Sphynx.jpg");
            FileStream picWriter = File.OpenWrite("/Users/lauracolten/github/Sphynx2.jpg");

            // StreamWriter p = new StreamWriter(picWriter);
            int b = picReader.ReadByte();


            while (b != -1)
            {
                picWriter.WriteByte((byte) b);
                b = picReader.ReadByte();
            }

            picReader.Close();
            picWriter.Close();

            stream.Close();
            // outStream.Close();
            s.Close();



        }
    }
}
