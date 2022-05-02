using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lidt_opjekter
{
    public class Area : IComparable
    {
        //fields
       private string name;
       private int length;
       private int width;
       private MyColorEnum color;


        //constructors
       public Area() { }
       
       public Area (MyColorEnum col, string name, int len, int wid)
        {
            this.color = col;
            this.setname(name);
            this.length = len;
            this.width = wid;
        }

        //properties
        public int Length 
        {
            get {return this.length;}
            set {this.length = value;}
        }

        public int Width
        {
            get {return this.width;}
            set {this.width = value;}
        }
        public MyColorEnum Color
        {
            get { return color; }
            set { color = value; }
        }
  
       public void SetLength(int tal) { }

        //Metoder
       public int GetLength()
        {
            return Length;
        }
       public void setname(string n)
        {
            if (n.Length > 2 && n.Length < 50)
            {
                this.name = n;
            }
            else
            {
                this.name = "N/A";
            }
        }
        public string getname()
        {
            return this.name;
        }

        public int GetSize()
        {
            return width * length;
        }

        //override
        public override string ToString()
        {
            //return $"{getname()} Size: {GetSize()} L: {Length} W: {Width}";
            return string.Format("color {0,-8} {1,-10} Size: {2,6} L: {3,6} W: {4,6} ",Color, getname(), GetSize(), Length, Width);

        }

        public int CompareTo(object obj)
        {
            //Area area = obj as Area;
            Area area = (Area)obj;
            return this.GetSize() - ((Area)obj).GetSize();
        }
    }
}
