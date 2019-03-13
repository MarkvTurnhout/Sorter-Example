using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    class Program
    {
        public static void Main()
        {
            using (var db = new DbModel())
            {
                foreach (Chute chute in Sorter.Sort(db.Boxes.ToList()))
                {
                    Console.WriteLine(chute.ToString());
                }
            }

            Console.ReadKey();
        }
    }
}

