using System;

namespace events_filewatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w =
                new System.IO.FileSystemWatcher(@"c:\temp", "*.*");
            w.EnableRaisingEvents = true;
            w.Changed += W_Changed;
            w.Created += (s, e) => Console.WriteLine("Oprettet " + e.FullPath);
            w.Deleted += (s, e) => Console.WriteLine("Slettet " + e.FullPath);

            do { } while (true);

            //System.IO.FileSystemWatcher d = new System.IO.FileSystemWatcher(@"c:\temp", "*.*");
            //d.EnableRaisingEvents = true;
            //d.Deleted += D_Deleted;
            //d.Deleted += (s, e) => Console.WriteLine("Slettet " + e.FullPath);
            //do { } while (true);

           
        }

        //private static void D_Deleted(object sender, System.IO.FileSystemEventArgs e)
        //{
        //    Console.WriteLine(e.Name);
        //}

        private static void W_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine(e.Name);
        }


    }
}