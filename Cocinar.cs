using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3B_Builder
{
    public class Cocinar
    {
        private Constructor_hamburguesas constructor_Hamburguesas;

        public void RecepcionarProximaHamburguesa(Constructor_hamburguesas Rconstructor_Hamburguesas)
        {
            constructor_Hamburguesas = Rconstructor_Hamburguesas;
        }

        public void CocinarHamburguesaP()
        {
            constructor_Hamburguesas.PasoPrepararMasa();
            constructor_Hamburguesas.PasoAñadirSalsa();
            constructor_Hamburguesas.PasoPrepararRelleno();
        }

        public Hamburguesaa HamburguesaPreparada
        {
            get { return constructor_Hamburguesas.ObtenerHamburguesaa(); }

        }
    }
}
