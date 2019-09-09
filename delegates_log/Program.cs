using System;

namespace delegates_log
{
    class Program
    {
        static void Main(string[] args)
        {
            Maskine m = new Maskine();
            m.Log = Console.WriteLine;
            m.Log += AppendLog;
            m.Start();
            m.Stop();

            Maskine2 b = new Maskine2();
            b.Log = Console.WriteLine;
            b.Log += AppendLog;
            b.Start();
            b.Stop();


        }

        static void AppendLog(string txt)
        {
            System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");
        }
    }

    public delegate void LogDelegate(string txt);
    public class Maskine
    {

        public LogDelegate Log { get; set; }

        public void Start()
        {
            Log?.Invoke(DateTime.Now.ToLongTimeString() + " Starter");
        }
        public void Stop()
        {
            Log?.Invoke(DateTime.Now.ToLongTimeString() + " Stopper");
        }
    }

    public class Maskine2
    {

        public Action<string> Log { get; set; }

        public void Start()
        {
            Log?.Invoke(DateTime.Now.ToLongTimeString() + " Starter-2");
        }
        public void Stop()
        {
            Log?.Invoke(DateTime.Now.ToLongTimeString() + " Stopper-2");
        }
    }
}