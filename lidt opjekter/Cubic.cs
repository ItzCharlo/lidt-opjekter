using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lidt_opjekter
{
    internal class Cubic : Area
    {
        public int Height;

        public int height
        {
            get{ return this.height; }
            set { this.height = value; }
        }

        public Cubic() { }

        public Cubic(MyColorEnum col, string name, int length, int width, int height)
           : base(col, name, length, width) // Areas constructor
        {
            //this.Color = col;
            //this.setname(name);
            //this.Length = length;
            //this.Width = width;
            this.Height = height;
        }

        public override string ToString()
        {
            return String.Format (base.ToString()) + "Height: " + this.Height;
        }
        public int GetSize()
        {
            return base.GetSize() * height;
        }
    }
}
