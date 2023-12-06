using System;
using System.Linq;

namespace ProjectAndDevelopers1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProjectDbContext db = new ProjectDbContext();
            var devs = db.Developers.ToArray();
            var proj = db.Projects.ToArray();

            ;
        }
    }
}
