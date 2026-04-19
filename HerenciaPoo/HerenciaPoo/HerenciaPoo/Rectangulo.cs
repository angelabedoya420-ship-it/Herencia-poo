
namespace HerenciaPoo
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
    }
}
