using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_final_estructura_de_datos.FrmAgregarPostre;

namespace Proyecto_final_estructura_de_datos
{
    public partial class FrmAgregarIngredientes : Form
    {
        public FrmAgregarIngredientes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.AgregarIngredientes();

        }

        public void AgregarIngredientes()
        {
            FrmAgregarPostre frm = new FrmAgregarPostre();
            
            
            string nombrePostre = txtNombrePostre.Text;



            Postre postre = frm.BuscarPostre(nombrePostre);
            if (postre != null)
            {
               
                string[] nuevosIngredientes = txtIngredientes.Text.Split(',');



                foreach (string nuevoIngrediente in nuevosIngredientes)
                {
                    string ingrediente = nuevoIngrediente.Trim();
                    if (!string.IsNullOrEmpty(ingrediente))
                    {
                        postre.Ingredientes.Add(ingrediente);
                    }
                }



                MessageBox.Show("Ingredientes agregados exitosamente.");
            }
            else
            {
                MessageBox.Show("El postre no existe.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAgregarPostre frm = new FrmAgregarPostre();
            string nombrePostre = txtNombrePostre.Text;



            Postre postre = frm.BuscarPostre(nombrePostre);
        }

        private void FrmAgregarIngredientes_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrese los ingredientes separados por comas para el postre");
        }
    }
}
