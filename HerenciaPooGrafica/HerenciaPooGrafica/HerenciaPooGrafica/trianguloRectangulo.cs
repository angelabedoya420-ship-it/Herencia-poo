using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HerenciaPooGrafica
{
    public class TrianguloRectangulo : Figura
    {
        public double baseTriangulo { get; set; }
        public double alturaTriangulo { get; set; }
        public override double calcularArea()
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }
        public override double calcularPerimetro()
        {
            double hipotenusa = Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));
            return baseTriangulo + alturaTriangulo + hipotenusa;
        }
        public override void Dibujar(Graphics g)
        {
            Point[] puntos = new Point[]
            {
                new Point(posicionX, posicionY),
                new Point(posicionX + (int)baseTriangulo, posicionY),
                new Point(posicionX, posicionY - (int)alturaTriangulo)
            };
            g.DrawPolygon(Pens.Black, puntos);
        }
    }
}
