using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPoo
{
    public abstract class Figura
    {
        public int posicionX { get; set; }
        public int posicionY { get; set; }

        public abstract double calcularArea();
        public abstract double calcularPerimetro();
    }
}


