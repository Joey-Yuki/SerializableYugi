using System.Drawing;
using System.Windows.Forms;

namespace SerializableYugi
{
    partial class Carta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carta));
            this.tipo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.atk = new System.Windows.Forms.TextBox();
            this.def = new System.Windows.Forms.TextBox();
            this.set = new System.Windows.Forms.TextBox();
            this.ilustracion = new System.Windows.Forms.PictureBox();
            this.atributo = new System.Windows.Forms.PictureBox();
            this.editar = new System.Windows.Forms.Button();
            this.tipomons = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ilustracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atributo)).BeginInit();
            this.SuspendLayout();
            // 
            // tipo
            // 
            this.tipo.Location = new System.Drawing.Point(158, 54);
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Size = new System.Drawing.Size(105, 20);
            this.tipo.TabIndex = 8;
            this.tipo.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.atk);
            this.panel2.Controls.Add(this.def);
            this.panel2.Location = new System.Drawing.Point(119, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 29);
            this.panel2.TabIndex = 8;
            this.panel2.Visible = false;
            // 
            // atk
            // 
            this.atk.BackColor = System.Drawing.Color.MistyRose;
            this.atk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.atk.Location = new System.Drawing.Point(3, 0);
            this.atk.Name = "atk";
            this.atk.ReadOnly = true;
            this.atk.Size = new System.Drawing.Size(68, 13);
            this.atk.TabIndex = 4;
            this.atk.Text = "ATK";
            // 
            // def
            // 
            this.def.BackColor = System.Drawing.Color.MistyRose;
            this.def.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.def.Location = new System.Drawing.Point(77, 0);
            this.def.Name = "def";
            this.def.ReadOnly = true;
            this.def.Size = new System.Drawing.Size(68, 13);
            this.def.TabIndex = 5;
            this.def.Text = "DEF";
            // 
            // set
            // 
            this.set.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.set.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.set.Location = new System.Drawing.Point(196, 322);
            this.set.Name = "set";
            this.set.ReadOnly = true;
            this.set.Size = new System.Drawing.Size(67, 13);
            this.set.TabIndex = 11;
            // 
            // ilustracion
            // 
            this.ilustracion.ErrorImage = global::SerializableYugi.Properties.Resources.DEFAULTerror;
            this.ilustracion.Image = global::SerializableYugi.Properties.Resources.DEFAULTerror;
            this.ilustracion.InitialImage = global::SerializableYugi.Properties.Resources.DEFAULTerror;
            this.ilustracion.Location = new System.Drawing.Point(36, 80);
            this.ilustracion.Name = "ilustracion";
            this.ilustracion.Size = new System.Drawing.Size(218, 236);
            this.ilustracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ilustracion.TabIndex = 10;
            this.ilustracion.TabStop = false;
            // 
            // atributo
            // 
            this.atributo.BackColor = System.Drawing.Color.Transparent;
            this.atributo.Location = new System.Drawing.Point(239, 21);
            this.atributo.Name = "atributo";
            this.atributo.Size = new System.Drawing.Size(30, 27);
            this.atributo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atributo.TabIndex = 2;
            this.atributo.TabStop = false;
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(12, 425);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(66, 20);
            this.editar.TabIndex = 12;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tipomons
            // 
            this.tipomons.BackColor = System.Drawing.Color.MistyRose;
            this.tipomons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tipomons.Location = new System.Drawing.Point(23, 334);
            this.tipomons.Name = "tipomons";
            this.tipomons.ReadOnly = true;
            this.tipomons.Size = new System.Drawing.Size(100, 13);
            this.tipomons.TabIndex = 6;
            this.tipomons.Visible = false;
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.Color.MistyRose;
            this.descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descripcion.Location = new System.Drawing.Point(23, 348);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descripcion.Size = new System.Drawing.Size(257, 56);
            this.descripcion.TabIndex = 1;
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(95)))));
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombre.Location = new System.Drawing.Point(23, 28);
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Size = new System.Drawing.Size(210, 13);
            this.nombre.TabIndex = 13;
            // 
            // Carta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(294, 450);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.set);
            this.Controls.Add(this.tipomons);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.ilustracion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.atributo);
            this.Controls.Add(this.descripcion);
            this.DoubleBuffered = true;
            this.Name = "Carta";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Carta_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ilustracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atributo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox atributo;
        private System.Windows.Forms.TextBox tipo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ilustracion;
        private System.Windows.Forms.TextBox set;
        private System.Windows.Forms.Button editar;
        private TextBox atk;
        private TextBox def;
        private TextBox tipomons;
        private TextBox descripcion;
        private TextBox nombre;
    }
}