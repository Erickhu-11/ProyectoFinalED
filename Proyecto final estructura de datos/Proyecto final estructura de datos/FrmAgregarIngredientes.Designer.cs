namespace Proyecto_final_estructura_de_datos
{
    partial class FrmAgregarIngredientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombrePostre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(299, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 38);
            this.button3.TabIndex = 19;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.AccessibleDescription = "";
            this.txtIngredientes.BackColor = System.Drawing.Color.Black;
            this.txtIngredientes.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredientes.ForeColor = System.Drawing.Color.White;
            this.txtIngredientes.Location = new System.Drawing.Point(9, 173);
            this.txtIngredientes.Multiline = true;
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(269, 38);
            this.txtIngredientes.TabIndex = 18;
            this.txtIngredientes.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(681, 34);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ingrese los ingredientes del postre que desea agregar:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_final_estructura_de_datos.Properties.Resources.j0432533;
            this.pictureBox1.Location = new System.Drawing.Point(642, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ingrese el nombre del postre";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(299, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombrePostre
            // 
            this.txtNombrePostre.BackColor = System.Drawing.Color.Black;
            this.txtNombrePostre.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePostre.ForeColor = System.Drawing.Color.White;
            this.txtNombrePostre.Location = new System.Drawing.Point(8, 70);
            this.txtNombrePostre.Multiline = true;
            this.txtNombrePostre.Name = "txtNombrePostre";
            this.txtNombrePostre.Size = new System.Drawing.Size(269, 38);
            this.txtNombrePostre.TabIndex = 13;
            this.txtNombrePostre.Tag = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.txtNombrePostre);
            this.panel1.Controls.Add(this.txtIngredientes);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 253);
            this.panel1.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(12, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(777, 480);
            this.dataGridView1.TabIndex = 21;
            // 
            // FrmAgregarIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(795, 763);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarIngredientes";
            this.Text = "FrmAgregarIngredientes";
            this.Load += new System.EventHandler(this.FrmAgregarIngredientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtIngredientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombrePostre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}