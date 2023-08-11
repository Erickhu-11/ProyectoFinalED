namespace Proyecto_final_estructura_de_datos
{
    partial class FrmMostrarIngredientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrarIngredientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombrePostre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvPostres = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPostres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtNombrePostre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 150);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(384, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(613, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombrePostre
            // 
            this.txtNombrePostre.BackColor = System.Drawing.Color.Black;
            this.txtNombrePostre.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePostre.ForeColor = System.Drawing.Color.White;
            this.txtNombrePostre.Location = new System.Drawing.Point(43, 80);
            this.txtNombrePostre.Multiline = true;
            this.txtNombrePostre.Name = "txtNombrePostre";
            this.txtNombrePostre.Size = new System.Drawing.Size(308, 38);
            this.txtNombrePostre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(157, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el nombre del postre:";
            // 
            // DgvPostres
            // 
            this.DgvPostres.BackgroundColor = System.Drawing.Color.Lime;
            this.DgvPostres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPostres.Location = new System.Drawing.Point(12, 168);
            this.DgvPostres.Name = "DgvPostres";
            this.DgvPostres.RowHeadersWidth = 51;
            this.DgvPostres.RowTemplate.Height = 24;
            this.DgvPostres.Size = new System.Drawing.Size(824, 456);
            this.DgvPostres.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_final_estructura_de_datos.Properties.Resources.j0432533;
            this.pictureBox1.Location = new System.Drawing.Point(721, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmMostrarIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(848, 636);
            this.Controls.Add(this.DgvPostres);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMostrarIngredientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMostrarIngredientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPostres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombrePostre;
        private System.Windows.Forms.DataGridView DgvPostres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}