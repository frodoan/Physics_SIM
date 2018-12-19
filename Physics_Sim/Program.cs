using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics_Sim
{
    class Program
    {
        static void Main(string[] args)
        {
            string version1 = "1";
            string name = "Gideon Physics Sim";

            Console.WriteLine("version " + version1);
            Console.WriteLine(name);


            //isrunning tells us that the program is running.
            while (isrunning)
            {
                Console.WriteLine("please enter a command");
                string CMD = Console.ReadLine();
                Command_Process(CMD);
            }
        }

        static bool isrunning = true;

        static void Command_Process(string CMD)
        {
            if (CMD == "Hello World")
            {
                isrunning = false;



            }


        }
    }
}
