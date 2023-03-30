using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netProject
{
    internal class person
    {
        public person(int NoofEyes, int Height, string FaceColor, string Name)
        {
            noofEyes = NoofEyes;
            height = Height;
            faceColor = FaceColor;
            name = Name;
        }
         ~person() {
            Console.WriteLine("writing from destructor");
            Console.Read();

        }
        public int noofEyes { get; set; }
       public int height { get; set; }
        public string faceColor { get; set; }
        public string name { get; set; }
       public void Lunch()
        {
            Console.WriteLine("I usually have momo in lunch");
           
        }
        public void MyColor()
        {
            Console.WriteLine("My face color is" + faceColor);
        }


    

        
    }
}
