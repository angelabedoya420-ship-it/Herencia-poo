
using HerenciaPoo;

Figura figura = null;

while (true)
{
    Console.WriteLine($"Elija una figura de las opciones:");
    Console.WriteLine($"1. Circulo");
    Console.WriteLine($"2. Triangulo Rectangulo");
    Console.WriteLine($"3. Rectangulo");

    // Convertir la opcion a un numero entero
    int opcion = Convert.ToInt32(Console.ReadLine());

    bool imprimirrespuesta = false;

    switch (opcion)
    {
        case 1:
            Console.WriteLine($"Ingrese el radio del circulo:");
            double radio = Convert.ToDouble(Console.ReadLine());
            Circulo circulo = new Circulo();
            circulo.radio = radio;
            figura = circulo;
            imprimirrespuesta = true;
            break;
        case 2:
            Console.WriteLine($"Ingrese la base del triangulo:");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Ingrese la altura del triangulo:");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
            TrianguloRectangulo triangulo = new TrianguloRectangulo();
            triangulo.baseTriangulo = baseTriangulo;
            triangulo.alturaTriangulo = alturaTriangulo;
            figura = triangulo;
            imprimirrespuesta = true;
            break;
        case 3:
            Console.WriteLine($"Ingrese la base del rectangulo:");
            double baseRectangulo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Ingrese la altura del rectangulo:");
            double alturaRectangulo = Convert.ToDouble(Console.ReadLine());
            Rectangulo rectangulo = new Rectangulo();
            rectangulo.baseRectangulo = baseRectangulo;
            rectangulo.alturaRectangulo = alturaRectangulo;
            figura = rectangulo;
            imprimirrespuesta = true;
            break;
        default:
            Console.WriteLine($"Opcion no valida.");
            imprimirrespuesta = false;
            break;
    }

    if(imprimirrespuesta == true)
    {
        Console.WriteLine($"El area es: {figura.calcularArea()}");
        Console.WriteLine($"El perimetro es: {figura.calcularPerimetro()}");
    }
}

