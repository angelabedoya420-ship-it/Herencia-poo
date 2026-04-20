using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HerenciaPooGrafica
{
    /*Define la clase TrianguloRectangulo que hereda de Figura,
    implementando los métodos para calcular el área, el perímetro y dibujar el triángulo rectángulo.*/
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
            // Para dibujar un triángulo rectángulo, se necesitan tres puntos: el vértice del ángulo recto y los dos extremos de la base y la altura.
            Point[] puntos = new Point[]
            {
                new Point(posicionX, posicionY),
                new Point(posicionX + (int)baseTriangulo, posicionY),
                new Point(posicionX, posicionY - (int)alturaTriangulo)
            };
            g.DrawPolygon(Pens.Black, puntos); // Dibuja el triángulo utilizando los puntos definidos.
        }
    }
}
