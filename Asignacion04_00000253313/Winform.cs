using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RaicesLogica.Servicio;

namespace Asignacion04_00000253313
{
    public partial class Winform: Form
    {
        // Creamos el servicio solo una vez y lo usamos en todo el formulario
        private readonly Resultado _servicio = new Resultado();

        public Winform()
        {
            InitializeComponent();
            // Configurar DataGridView
            dgvResultado.ColumnCount = 6;
            dgvResultado.Columns[0].Name = "Iteración";
            dgvResultado.Columns[1].Name = "Xi";
            dgvResultado.Columns[2].Name = "Xf";
            dgvResultado.Columns[3].Name = "Xr";
            dgvResultado.Columns[4].Name = "F(Xr)";
            dgvResultado.Columns[5].Name = "Error";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
             // Limpiar tabla
            dgvResultado.Rows.Clear();

            // Leer valores de los TextBox
            double xi = double.Parse(txtXi.Text);
            double xf = double.Parse(txtXf.Text);
            double eamax = 0.0001; // error máximo

            MessageBox.Show($"F({xi}) = {RaicesLogica.Funciones.FuncionesMatematicas.F(xi)}\nF({xf}) = {RaicesLogica.Funciones.FuncionesMatematicas.F(xf)}",
                "Valores de la función", MessageBoxButtons.OK, MessageBoxIcon.Information);


            if (radbtnBiseccion.Checked)
            {
                var iteraciones = _servicio.Biseccion(xi, xf, eamax);

                foreach (var item in iteraciones)
                {
                    dgvResultado.Rows.Add(
                        item.Numero,
                        item.Xi.ToString("F6"),
                        item.Xf.ToString("F6"),
                        item.Xr.ToString("F6"),
                        item.FxR.ToString("F6"),
                        item.Error.ToString("F6")
                    );
                }
            }
            else if (radbtnReglaFalsa.Checked)
            {
                var iteraciones = _servicio.ReglaFalsa(xi, xf, eamax);

                foreach (var item in iteraciones)
                {
                    dgvResultado.Rows.Add(
                        item.Numero,
                        item.Xi.ToString("F6"),
                        item.Xf.ToString("F6"),
                        item.Xr.ToString("F6"),
                        item.FxR.ToString("F6"),
                        item.Error.ToString("F6")
                    );
                }
            }
            else
            {
                MessageBox.Show("Selecciona un método primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
        }
    }
}
