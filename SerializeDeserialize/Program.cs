using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializeDeserialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Serialization of object to stream
            string path = @"C:\Users\v-mholen\source\repos\SerializeDeserialize\Output.txt";

            Library library = new Library(5437821, "The God Father", "Mario Puzo");

            FileStream filestream = new FileStream(path, FileMode.OpenOrCreate);

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(filestream, library);

            filestream.Close();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("File saved in the path" + path);

            Console.ReadKey();

            //Desrialization of stream  to object

            FileStream filestream1 = new FileStream(path, FileMode.OpenOrCreate);

            BinaryFormatter formatter1 = new BinaryFormatter();

            Library library1 = (Library)formatter1.Deserialize(filestream1);

            Console.WriteLine("Book ISBN : " + library1._isbn);

            Console.WriteLine("Book Title : " + library1._bookTitle);

            Console.WriteLine("Book Author : " + library1._author);

            Console.ReadKey();
        }
    }
}
