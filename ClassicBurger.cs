using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3B_Builder
{
    public class ClassicBurger : Constructor_hamburguesas
    {
        public ClassicBurger(string tamaño)
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
            hamburguesa.Salsa = "Salsa de tomate y mayonesa";
        }

        public override void PasoPrepararRelleno()
        {
            hamburguesa.Relleno = "Carne+Pepino+Tomate+Cebolla";
        }
    }
}