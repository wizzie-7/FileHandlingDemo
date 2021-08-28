using System;
using System.IO;

namespace FileHandlingDemo
{
    
    class IOdemo
    {
        static void Main(string[] args)
        {
            using (FileStream FS = new FileStream(@"D:/wizzie/simpletext.txt",FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                StreamWriter SM = new StreamWriter(FS);
                SM.BaseStream.Seek(0, SeekOrigin.End);

                SM.WriteLine("Hi Welcome to SvagTech");
                SM.WriteLine("How can we help you?");
                SM.WriteLine("Thanks for VISITING");

               SM.Flush();
            }

            StreamReader SR = new StreamReader(@"D:/wizzie/simpletext.txt");
            string str;
            while((str = SR.ReadLine()) != null)
            {
                Console.WriteLine(str);
            }

        }
    }
}
