using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3B_Builder
{
    public class BigBurger : Constructor_hamburguesas
    {
        public BigBurger(string tamaño)
        {
            hamburguesa = new Hamburguesaa
            {
                Tamaño = tamaño
            };
        }
        public override void PasoPrepararMasa()
        {
            hamburguesa.Masa = "Cocida";
        }

        public override void PasoAñadirSalsa()
        {
            hamburguesa.Salsa = "Salsa de tomate y mayonesa ";
        }

        public override void PasoPrepararRelleno()
        {
            hamburguesa.Relleno = "Carne+huevo+Pepino+Tomate+Cebolla+Queso";
        }
    }
}