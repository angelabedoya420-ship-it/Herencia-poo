using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciaPooGrafica
{
    /*En el menu prncipal se le permite al usuario seleccionar la figura que desea dibujar, 
     ingresar las dimensiones necesarias para cada figura, y luego se muestra el área, el perímetro y se dibuja la figura.*/
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }

        private void boton_dibujar_click(object sender, EventArgs e)
        {
            /* Dependiendo de la figura seleccionada por el usuario, 
             se crean instancias de las clases correspondientes (Circulo, TrianguloRectangulo, Rectangulo),*/  

            Figura figura = null;
            bool imprimirrespuesta = false;
            double radio1 = 0;
            double base1 = 0;
            double altura1 = 0;
            int posX = 0;
            int posY = 0;

            if (!string.IsNullOrEmpty(Radio.Text))
            {
                radio1 = double.Parse(Radio.Text);
            }
            if (!string.IsNullOrEmpty(Base.Text))
            {
                base1 = double.Parse(Base.Text);
            }
            if (!string.IsNullOrEmpty(Altura.Text))
            {
                altura1 = double.Parse(Altura.Text);
            }
            if (!string.IsNullOrEmpty(posicionX.Text))
            {
                posX = int.Parse(posicionX.Text);
            }
            if (!string.IsNullOrEmpty(posicionY.Text))
            {
                posY = int.Parse(posicionY.Text);
            }

            switch (selectorFigura.SelectedIndex + 1) //Se uzsa el switch para determinar que figura se selecciono y crear la instancia de la clase correspondiente.*/  

            {
                case 1:
                    Circulo circulo = new Circulo();
                    circulo.radio = radio1;
                    figura = circulo;
                    imprimirrespuesta = true;
                    break;
                case 2:
                    TrianguloRectangulo triangulo = new TrianguloRectangulo();
                    triangulo.baseTriangulo = base1;
                    triangulo.alturaTriangulo = altura1;
                    figura = triangulo;
                    imprimirrespuesta = true;
                    break;
                case 3:
                    Rectangulo rectangulo = new Rectangulo();
                    rectangulo.baseRectangulo = base1;
                    rectangulo.alturaRectangulo = altura1;
                    figura = rectangulo;
                    imprimirrespuesta = true;
                    break;
                default:
                    MessageBox.Show("Opcion no valida");
                    imprimirrespuesta = false;
                    break;
            }
            /*Una vez creada la instancia de la figura, se calculan el área y el perímetro utilizando los métodos correspondientes,
            y se muestra la información al usuario. Además, se dibuja la figura en el panely seleccionando el boton Dibujar */

            if (imprimirrespuesta == true) 
            {
                areaTotal.Text = $"{figura.calcularArea()}";
                perimetro.Text = $"{figura.calcularPerimetro()}";
                figura.posicionX = posX;
                figura.posicionY = posY;
                figura.Dibujar(this.CreateGraphics());
            }
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void areaTotal_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void perimetro_Click(object sender, EventArgs e)
        {

        }
    }
}
