using System;
using System.Linq;
using System.IO;

namespace Darr
{ 
    internal class Mind
    {
        public static void AMain()
        {
            //Console.WriteLine("Cantidad de items");

            FileStream ost;
            StreamWriter sw;
            TextWriter Oo = Console.Out;

            try
            {
                ost = new FileStream ("./Arrayed.txt", FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter (ost);
            }
            catch (Exception e)
            {
                Console.WriteLine ("Cannot open Arrayed.txt for writing");
                Console.WriteLine (e.Message);
                return;
            }
             Console.SetOut(sw);     
             Console.Write(Program.Arrayer() + ";");
             Console.SetOut(Oo);
             sw.Close();
             ost.Close();
             Console.WriteLine("Done");
            

            Console.ReadKey();
        }

    }
}
