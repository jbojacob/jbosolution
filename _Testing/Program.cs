using System;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;

namespace _Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryEntry directoryEntry = new DirectoryEntry("WinNT://" + Environment.MachineName);
            string userNames = "Users: ";

            foreach (DirectoryEntry child in directoryEntry.Children)
            {
                if (child.SchemaClassName == "User")
                {
                    userNames += child.Name + Environment.NewLine;
                }

            }
            MessageBox.Show(userNames);
        }

        //private static SearchResultCollection GetAllUsers()
        //{
        //    Console.WriteLine();
        //}
    }
}
