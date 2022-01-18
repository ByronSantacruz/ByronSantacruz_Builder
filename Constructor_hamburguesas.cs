using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3B_Builder
{
    public abstract class Constructor_hamburguesas
    {
        protected Hamburguesaa hamburguesa;
        public string Tamaño { get; set; }

        public Hamburguesaa ObtenerHamburguesaa() { return hamburguesa; }

        public virtual void PasoPrepararMasa()
        {

        }

        public virtual void PasoAñadirSalsa()
        {

        }

        public virtual void PasoPrepararRelleno()
        {

        }

        public virtual void PasoDoblarPoizza()
        {

        }
    }
}
