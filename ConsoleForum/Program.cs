using LibraryForum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum
{
    class Program
    {
        static void Main(string[] args)
        {

            Topic t = new Topic();

            t.Auteur = "1 ";
            t.DateCreation = DateTime.Now;
            t.Description = "test ";
            t.Title = "je teste ";
            Console.WriteLine(t);
            Console.ReadKey();


        }
    }
}
