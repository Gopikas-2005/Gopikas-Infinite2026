using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Assesment3
{
    internal class FileReadandWrite
    {
        
        public static void FileHandling()
        {
                
                string FileCreate = "MyFile.txt";
                using (StreamWriter writer = new StreamWriter(FileCreate,true))
                {
                    writer.WriteLine("I have Created a File using an StreamWriter");
                }
                Console.WriteLine("File Created Successfully");
                
        }
        public static void Main()
        {
            FileHandling();
        }
    }
    
}

