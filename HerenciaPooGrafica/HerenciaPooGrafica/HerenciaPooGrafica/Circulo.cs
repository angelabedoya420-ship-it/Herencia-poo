using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HerenciaPooGrafica
{
    /*Define la clase Circulo que hereda de Figura, 
     implementando los métodos para calcular el área, el perímetro y dibujar el círculo.*/
    public class Circulo : Figura
    {
        public double radio { get; set; } 
        public override double calcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
        public override double calcularPerimetro()
        {
            return 2 * Math.PI * radio;// El perímetro de un círculo se calcula multiplicando el radio por 2 y por π (pi).
        }
        public override void Dibujar(Graphics g) 
        {
            g.DrawEllipse(Pens.Black, posicionX, posicionY, (int)(radio * 2), (int)(radio * 2));
        }
    }
}
