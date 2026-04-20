using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HerenciaPooGrafica
{
    //Define la clase Rectangulo que hereda de Figura, calculando el área, el perímetro y dibujando el rectángulo.
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
            return (baseRectangulo + alturaRectangulo) * 2; // El perímetro de un rectángulo se calcula sumando el doble de la base y el doble de la altura.
        }
        public override void Dibujar(Graphics g)
        {
            g.DrawRectangle(Pens.Black, posicionX, posicionY, (int)baseRectangulo, (int)alturaRectangulo);// Dibuja el rectángulo utilizando la posición y las dimensiones especificadas.
        }
    }
}
