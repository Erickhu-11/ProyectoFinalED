using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_estructura_de_datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMostrarIngredientes frm = new FrmMostrarIngredientes();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmAgregarPostre frm = new FrmAgregarPostre();  
            frm.ShowDialog();
            frm.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmEliminarPostrecs frm = new FrmEliminarPostrecs();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAgregarIngredientes Frm = new FrmAgregarIngredientes();
            Frm.ShowDialog();   
            Frm.Dispose();
        }
    }
}
