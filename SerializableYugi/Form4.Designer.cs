namespace SerializableYugi
{
    partial class Form4
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
            this.panelCHK = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panelgen = new System.Windows.Forms.Panel();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.set = new System.Windows.Forms.TextBox();
            this.soporte = new System.Windows.Forms.TextBox();
            this.rareza = new System.Windows.Forms.ComboBox();
            this.copias = new System.Windows.Forms.TextBox();
            this.panelmonst = new System.Windows.Forms.Panel();
            this.subtipo = new System.Windows.Forms.ComboBox();
            this.ExtraDeck = new System.Windows.Forms.ComboBox();
            this.atributo = new System.Windows.Forms.ComboBox();
            this.def = new System.Windows.Forms.TextBox();
            this.attk = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.niivel = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelCHK.SuspendLayout();
            this.panelgen.SuspendLayout();
            this.panelmonst.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCHK
            // 
            this.panelCHK.Controls.Add(this.checkBox3);
            this.panelCHK.Controls.Add(this.checkBox2);
            this.panelCHK.Controls.Add(this.checkBox1);
            this.panelCHK.Location = new System.Drawing.Point(241, 12);
            this.panelCHK.Name = "panelCHK";
            this.panelCHK.Size = new System.Drawing.Size(321, 18);
            this.panelCHK.TabIndex = 38;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(232, 0);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(67, 17);
            this.checkBox3.TabIndex = 32;
            this.checkBox3.Tag = "3";
            this.checkBox3.Text = "Trampas";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(115, 0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(66, 17);
            this.checkBox2.TabIndex = 31;
            this.checkBox2.Tag = "2";
            this.checkBox2.Text = "Magicas";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 17);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Tag = "1";
            this.checkBox1.Text = "Monstruos";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panelgen
            // 
            this.panelgen.Controls.Add(this.Nombre);
            this.panelgen.Controls.Add(this.Descripcion);
            this.panelgen.Controls.Add(this.tipo);
            this.panelgen.Controls.Add(this.set);
            this.panelgen.Controls.Add(this.soporte);
            this.panelgen.Controls.Add(this.rareza);
            this.panelgen.Controls.Add(this.copias);
            this.panelgen.Location = new System.Drawing.Point(3, 35);
            this.panelgen.Name = "panelgen";
            this.panelgen.Size = new System.Drawing.Size(314, 395);
            this.panelgen.TabIndex = 39;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(6, 4);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(299, 20);
            this.Nombre.TabIndex = 0;
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(6, 45);
            this.Descripcion.Multiline = true;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(299, 107);
            this.Descripcion.TabIndex = 1;
            // 
            // tipo
            // 
            this.tipo.FormattingEnabled = true;
            this.tipo.Location = new System.Drawing.Point(6, 170);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(299, 21);
            this.tipo.TabIndex = 18;
            // 
            // set
            // 
            this.set.Location = new System.Drawing.Point(6, 216);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(299, 20);
            this.set.TabIndex = 3;
            // 
            // soporte
            // 
            this.soporte.Location = new System.Drawing.Point(6, 263);
            this.soporte.Name = "soporte";
            this.soporte.Size = new System.Drawing.Size(299, 20);
            this.soporte.TabIndex = 4;
            // 
            // rareza
            // 
            this.rareza.FormattingEnabled = true;
            this.rareza.Items.AddRange(new object[] {
            "C",
            "R",
            "SR",
            "UR"});
            this.rareza.Location = new System.Drawing.Point(6, 308);
            this.rareza.Name = "rareza";
            this.rareza.Size = new System.Drawing.Size(299, 21);
            this.rareza.TabIndex = 19;
            // 
            // copias
            // 
            this.copias.Location = new System.Drawing.Point(6, 360);
            this.copias.Name = "copias";
            this.copias.Size = new System.Drawing.Size(299, 20);
            this.copias.TabIndex = 6;
            // 
            // panelmonst
            // 
            this.panelmonst.Controls.Add(this.subtipo);
            this.panelmonst.Controls.Add(this.ExtraDeck);
            this.panelmonst.Controls.Add(this.atributo);
            this.panelmonst.Controls.Add(this.def);
            this.panelmonst.Controls.Add(this.attk);
            this.panelmonst.Controls.Add(this.textBox10);
            this.panelmonst.Controls.Add(this.niivel);
            this.panelmonst.Location = new System.Drawing.Point(442, 149);
            this.panelmonst.Name = "panelmonst";
            this.panelmonst.Size = new System.Drawing.Size(277, 281);
            this.panelmonst.TabIndex = 40;
            // 
            // subtipo
            // 
            this.subtipo.FormattingEnabled = true;
            this.subtipo.Items.AddRange(new object[] {
            "Union",
            "Toon",
            "Gemini",
            "Espiritu",
            "Pendulo",
            "Cantante",
            "No"});
            this.subtipo.Location = new System.Drawing.Point(10, 244);
            this.subtipo.Name = "subtipo";
            this.subtipo.Size = new System.Drawing.Size(256, 21);
            this.subtipo.TabIndex = 33;
            // 
            // ExtraDeck
            // 
            this.ExtraDeck.FormattingEnabled = true;
            this.ExtraDeck.Items.AddRange(new object[] {
            "Fusion",
            "Sincronia",
            "Xyz",
            "Link",
            "No"});
            this.ExtraDeck.Location = new System.Drawing.Point(10, 61);
            this.ExtraDeck.Name = "ExtraDeck";
            this.ExtraDeck.Size = new System.Drawing.Size(256, 21);
            this.ExtraDeck.TabIndex = 27;
            // 
            // atributo
            // 
            this.atributo.FormattingEnabled = true;
            this.atributo.Items.AddRange(new object[] {
            "Luz",
            "Oscuridad",
            "Tierra",
            "Viento",
            "Agua",
            "Fuego",
            "Divinidad"});
            this.atributo.Location = new System.Drawing.Point(10, 19);
            this.atributo.Name = "atributo";
            this.atributo.Size = new System.Drawing.Size(256, 21);
            this.atributo.TabIndex = 26;
            // 
            // def
            // 
            this.def.Location = new System.Drawing.Point(10, 207);
            this.def.Name = "def";
            this.def.Size = new System.Drawing.Size(256, 20);
            this.def.TabIndex = 11;
            // 
            // attk
            // 
            this.attk.Location = new System.Drawing.Point(10, 168);
            this.attk.Name = "attk";
            this.attk.Size = new System.Drawing.Size(256, 20);
            this.attk.TabIndex = 10;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(10, 131);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(256, 20);
            this.textBox10.TabIndex = 9;
            // 
            // niivel
            // 
            this.niivel.Location = new System.Drawing.Point(10, 99);
            this.niivel.Name = "niivel";
            this.niivel.Size = new System.Drawing.Size(256, 20);
            this.niivel.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(442, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(326, 108);
            this.listBox1.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "Listo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panelmonst);
            this.Controls.Add(this.panelgen);
            this.Controls.Add(this.panelCHK);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panelCHK.ResumeLayout(false);
            this.panelCHK.PerformLayout();
            this.panelgen.ResumeLayout(false);
            this.panelgen.PerformLayout();
            this.panelmonst.ResumeLayout(false);
            this.panelmonst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCHK;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panelgen;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.TextBox set;
        private System.Windows.Forms.TextBox soporte;
        private System.Windows.Forms.ComboBox rareza;
        private System.Windows.Forms.TextBox copias;
        private System.Windows.Forms.Panel panelmonst;
        private System.Windows.Forms.ComboBox subtipo;
        private System.Windows.Forms.ComboBox ExtraDeck;
        private System.Windows.Forms.ComboBox atributo;
        private System.Windows.Forms.TextBox def;
        private System.Windows.Forms.TextBox attk;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox niivel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}