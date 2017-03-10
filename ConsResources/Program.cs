using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsResources
{
    class Program
    {
        static void Main(string[] args)
        {
            var cul = Thread.CurrentThread.CurrentCulture;
            //var img = Immagini.cat02;
            //Console.WriteLine(img.Width);
            //Console.WriteLine(img.Height);
            Debug.WriteLine(cul);

            var res = new ResourceManager("ConsResources.Testi", Assembly.GetExecutingAssembly());
            var s = res.GetString("text1");
            
            // così funziona
            Console.WriteLine(s);
            Console.WriteLine(Testi.text1);

            var rm = new ResourceManager("ConsResources.Traduzioni", Assembly.GetExecutingAssembly());
            
            // cambio il cultureInfo
            CultureInfo itCulture = new CultureInfo("it-IT");
            Thread.CurrentThread.CurrentCulture = itCulture;
            Console.WriteLine(rm.GetString("text1", itCulture));

            // cambio il cultureInfo
            CultureInfo newCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = newCulture;
            Console.WriteLine(rm.GetString("text1", newCulture));

            Console.ReadLine();
        }
    }
}
