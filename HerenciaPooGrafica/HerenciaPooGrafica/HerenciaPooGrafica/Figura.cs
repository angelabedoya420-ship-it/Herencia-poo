using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPooGrafica
{
    /*Define la funcionalidad base para una figura geométrica,incluyendo la posición y 
     los métodos para calcular el área, el perímetro y dibujar la figura.*/
    public abstract class Figura
    {
        //
        public int posicionX { get; set; }
        public int posicionY { get; set; }

        public abstract double calcularArea();
        public abstract double calcularPerimetro();
        public abstract void Dibujar(Graphics g);
    }
}
