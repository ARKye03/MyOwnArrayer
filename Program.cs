using System;
using System.Collections.Generic;

namespace Darr;

internal class Program
{
    static string[] farray;
    static void Main()
    {
        int d = 0;
        bool sigue = true;
        Console.WriteLine("Introduce elementos------------------Type " + '"' + "stop" + '"' + "to parar obviamente");
        List<string> Dyn = new List<string>();
        do
        {
            Dyn.Add(Console.ReadLine());
            int y = Dyn.Count;
            if (Dyn[d] == "stop")
            sigue = false;

            d++;
            
        } while (sigue);

        Dyn.Remove("stop");

        //for (int i = 0; i < Dyn.Count; i++){ Console.WriteLine(Dyn[i]);}

        farray = Dyn.ToArray();
        Console.Clear();

        for (int k = 0; k < farray.Length; k++)
        {
            Console.WriteLine(farray[k]);
        } 
        Mind.AMain();
        Console.ReadKey();
    }
    public static string[] Arrayer(){
            Console.Clear();

            for (int d = 0; d < farray.Length; d++){ Console.Write('"' + farray[d] + '"' + ',');}

            return farray;
        }
}
