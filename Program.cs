using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace netProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("hello Nist");
             string welcome = Console.ReadLine();
             Console.WriteLine(welcome);
             Console.Clear();
             Console.WriteLine("Enter first number");
             int firstNumber = Convert.ToInt32(Console.ReadLine()); 
             Console.WriteLine("Enter second number");
             int secondNumber = Convert.ToInt32(Console.ReadLine());
             int sum = firstNumber + secondNumber;
             Console.WriteLine("sum of two number" + sum);

             Console.WriteLine("Do you want to quit,if Yes pass A");
             char a = Console.ReadLine()[0];
             bool quit = false;
             if(a == "A"[0])
             {
                 quit = true;
             }
             if (quit == false) 
             {
                 Console.ReadKey();
             } */
            /*string myName = "Azay";
                Console.Write(myName.ToUpper());
                Console.Write(myName.ToLower());
            Console.Read();*/


            /* 
             // {
                 Console.WriteLine("Enter your favourite color");
                 string favColor = Console.ReadLine();
                 switch (favColor)
                 {
                 case "red":
                 Console.WriteLine("You are lovely");
                     break;

                 case "blue":
                 Console.WriteLine("You are peaceful");
                         break;

                 case "green":
                     Console.WriteLine("You are good");
                         break;
             }
             Console.Read()
            }*/

            //for loop

            /*for (int counter = 0; counter <= 10; counter++)
            {
                Console.WriteLine("your loop is is" + counter + "state");
            }
            */

            // while loop
            /*int counter = 1;
            while(counter <= 10) { 
                Console.WriteLine("your loop is in" + counter + "state");
                counter += 2;
            
            }
            Console.Read();*/

            //class and object;
            
            
                person shristi = new person(2,5,"black","shristi");
            
                shristi.Lunch();
            shristi.MyColor();
            

            person amy = new person(3,4,"white","amy");
            amy.name = "amy ";
           
            amy.Lunch();
            amy.MyColor();
            

            Console.Read();




            



        }
    }
}