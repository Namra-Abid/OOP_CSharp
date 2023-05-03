using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticandInstanceVariable
{
    class Program
    {
        public static int i;
        /***
            * if I use this i and dont declare its value in static  then I can  change i value using Program class keyword or even using functions 
            *even if had written this way " public static int i=10;"  Also I can change its value using Program class keyword or even using functions

         * **/
        public static void display()
        {
            i = 13;
            /***
             * if I use this i means if I comment this i then I can  change i value 
             * but if because it is declared inside static function  the no matter i can not change its value because it it declared inside static function
             * **/
            Console.WriteLine(i);
        }
        public void demo()
        {
            int j = 20;
            Console.WriteLine("value of i :{0}", i);
            i = i + 1;//value will change until execution of this once it executed it will get back to 13 beacuse it is constant
            Console.WriteLine("value of i after :{0}", i);
            Console.WriteLine("value of j ;{0}",j);
            Console.WriteLine("Demo Executed");

        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Program.display();
            obj.demo();
            
            Program.display();

            Program.i = 50;// value can not change because currenlty declared inside static function
            Program.display();

            Program.i = 51; // value can not change because currenlty declared inside static function
            Program.display();

            Console.Read();


        }
    }
}
