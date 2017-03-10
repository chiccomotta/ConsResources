using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOne
{
    public class MyUtils
    {
        public void foo()
        {
            List<FooClass> lista = new List<FooClass>();

            // stessa data creazione
            DateTime today = DateTime.Now;
            var query = lista.Select(q => q);

            foreach (var row in lista)
            {
                row.CreationDate = today;
            }
        }
    }



    public class FooClass
    {
        public int id { get; set; }
        public string Name { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
