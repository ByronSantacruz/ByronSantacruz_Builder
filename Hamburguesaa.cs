using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3B_Builder
{
    public class Hamburguesaa
    { 
        public string Masa { get; set; }
        public string Salsa { get; set; }
        public string Relleno { get; set; }
        public string Tamaño { get; set; }
        public bool EstaDoblada { get; set; }

        public Hamburguesaa()
        {

        }

        public Hamburguesaa(string tamaño, string masa, string salsa, string relleno, bool doblar) : this()
        {
            Tamaño = tamaño;
            Masa = masa;
            Salsa = salsa;
            Relleno = relleno;
            EstaDoblada = doblar;
        }
    }

}
