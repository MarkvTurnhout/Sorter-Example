using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    public static class Sorter
    {
        public static List<Chute> Sort(List<Box> boxes)
        {
            List<Chute> chutes = new List<Chute>();
            foreach (string destination in boxes.Select(box => box.Destination).Distinct().ToList())
            {
                chutes.Add(new Chute(destination, boxes.FindAll(number => number.Destination.Equals(destination))));
            }

            return chutes;
        }
    }
}
