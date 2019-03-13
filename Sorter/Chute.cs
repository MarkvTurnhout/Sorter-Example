using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    public class Chute
    {
        public string Destination { get; set; }
        public List<Box> Boxes { get; set; }

        public Chute(string destination)
        {
            this.Destination = destination;
        }

        public Chute(string destination, List<Box> boxes)
        {
            this.Destination = destination;
            this.Boxes = boxes;
        }

        override
        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Chute for Destination: {0} has {1} boxes: ", this.Destination, this.Boxes.Count);
            sb.AppendLine();

            foreach (Box box in this.Boxes)
            {
                sb.AppendFormat("\t Box Number: {0}", box.BoxNumber);
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
