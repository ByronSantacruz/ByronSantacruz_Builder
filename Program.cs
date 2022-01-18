using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3B_Builder
{
    static void Main(string[] args)
    {
        var cocinar = new Cocinar();
        cocinar.RecepcionarProximaHamburguesa(new BigBurger("Haburguesa super grande para dos personas"));
        cocinar.CocinarHamburguesaP();
        var pizzaCuatroQuesos = cocinar.HamburguesaPreparada;
        cocinar.RecepcionarProximaHamburguesa(new ClassicBurger("Haburguesa clasica para una persona"));
        cocinar.CocinarHamburguesaP();
        var classicBurger = cocinar.HamburguesaPreparada;
        var classicBurgerRapida = cocinar.CocinarHambuerguesa(new ClassicBurger("Haburguesa clasica para una persona"));
        Console.ReadLine();
    }
}