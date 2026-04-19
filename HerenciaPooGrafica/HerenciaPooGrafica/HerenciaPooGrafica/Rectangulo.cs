using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HerenciaPooGrafica
{
    public class Rectangulo : Figura
    {
        public double baseRectangulo { get; set; }
        public double alturaRectangulo { get; set; }
        public override double calcularArea()
        {
            return baseRectangulo * alturaRectangulo;
        }
        public override double calcularPerimetro()
        {
            return (baseRectangulo + alturaRectangulo) * 2;
        }
        public override void Dibujar(Graphics g)
        {
            g.DrawRectangle(Pens.Black, posicionX, posicionY, (int)baseRectangulo, (int)alturaRectangulo);
        }
    }
}
