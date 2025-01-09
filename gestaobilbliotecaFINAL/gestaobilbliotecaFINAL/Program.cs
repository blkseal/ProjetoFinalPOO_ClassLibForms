using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestaobiblioteca;
using gestaobilbliotecaFINAL;

namespace gestaobiblioteca
{
    public class Program
    {
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}