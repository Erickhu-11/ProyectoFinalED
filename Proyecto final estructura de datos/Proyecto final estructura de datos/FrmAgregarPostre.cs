using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using static System.Net.Mime.MediaTypeNames;
using static Proyecto_final_estructura_de_datos.FrmAgregarPostre;

namespace Proyecto_final_estructura_de_datos
{
    public partial class FrmAgregarPostre : Form
    {
        static Postre[] postres = new Postre[10];
        static int cantidadPostres = 0;
        public class Postre
        {
            public string Nombre { get; }
            public List<string> Ingredientes { get; } = new List<string>();

            public Postre(string nombre, List<string> ingredientes)
            {
                Nombre = nombre;
                Ingredientes = ingredientes;
            }
        }

        public FrmAgregarPostre()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.AgregarPostre();
        }
        public Postre BuscarPostre(string nombrePostre)
        {
            for (int i = 0; i < cantidadPostres; i++)
            {
                if (postres[i].Nombre.Equals(nombrePostre, StringComparison.OrdinalIgnoreCase))
                {
                    return postres[i];
                }
            }
            return null;
        }
        public void AgregarPostre()
        {
            if (cantidadPostres >= 10)

            {
                

                    MessageBox.Show("Capacidad máxima de postres alcanzada. No se pueden agregar más postres");
                    return;

                
               
            }

            string nombreNuevoPostre;

            nombreNuevoPostre = txtNombrePostre.Text;

            Postre postreExistente = BuscarPostre(nombreNuevoPostre);
            if (postreExistente == null)
            {
              //  Console.WriteLine($"Ingrese los ingredientes separados por comas para {nombreNuevoPostre} (ejemplo: ingrediente1, ingrediente2, ingrediente3): ");
                string[] nuevosIngredientes = txtIngredientes.Text.Split(',');

                List<string> ingredientes = new List<string>();
                foreach (string nuevoIngrediente in nuevosIngredientes)
                {
                    string ingrediente = nuevoIngrediente.Trim();
                    if (!string.IsNullOrEmpty(ingrediente))
                    {
                        ingredientes.Add(ingrediente);
                    }
                }



                Postre nuevoPostre = new Postre(nombreNuevoPostre, ingredientes);
                postres[cantidadPostres] = nuevoPostre;
                cantidadPostres++;



                MessageBox.Show("Postre agregado exitosamente.");
            }
            else
            {
                MessageBox.Show("El postre ya existe.");
            }

            DgvAgregarPostres.DataSource = postres;


        }
        public void AgregarIngredientes()
        {
            
            string nombrePostre = txtNombrePostre.Text;

            Postre postre = BuscarPostre(nombrePostre);
            if (postre != null)
            {
                Console.WriteLine($"Ingrese los ingredientes separados por comas para {postre.Nombre} (ejemplo: ingrediente1, ingrediente2, ingrediente3): ");
                string[] nuevosIngredientes = Console.ReadLine().Split(',');

                foreach (string nuevoIngrediente in nuevosIngredientes)
                {
                    string ingrediente = nuevoIngrediente.Trim();
                    if (!string.IsNullOrEmpty(ingrediente))
                    {
                        postre.Ingredientes.Add(ingrediente);
                    }
                }

                Console.WriteLine("Ingredientes agregados exitosamente.");
            }
            else
            {
                Console.WriteLine("El postre no existe.");
            }
        }


    }// CIERRE DE CLASE
    }//CIERRE NAMESPACE
       
