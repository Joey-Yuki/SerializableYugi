using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializableYugi
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string[] tipomons = { "Guerrero", "Demonio", "Lanzador de Conjuros", "Máquina", "Bestia", "Bestia Alada", "Guerrero-Bestia", "Pez", "Serpiente Marina", "Aqua", "Reptil", "Dinosaurio", "Dragón", "Hada", "Zombi", "Roca", "Psíquico", "Piro", "Trueno", "Planta", "Insecto", "Wyrm", "Bestia Divina", "Ciberso" };
        string[] tipomags = { "Normal", "Juego Rápido", "Continua", "Equipo", "Campo", "Ritual" };
        string[] tipotraps = { "Normal", "Continua", "Contraefecto" };
        string archivo = null;
        private void RellenarTipos(object sender)
        {
            tipo.Items.Clear();
            switch (int.Parse((string)(sender as Control).Tag))
            {
                case 1: tipo.Items.AddRange(tipomons); archivo = "Monstruo"; break;
                case 2: tipo.Items.AddRange(tipomags); archivo = "Magicas"; break;
                case 3: tipo.Items.AddRange(tipotraps); archivo = "Trampas"; break;
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool almostdone = false;
            RellenarTipos(sender);
            foreach (CheckBox ch in panelCHK.Controls)
            {
                if (!ch.Checked) ch.Enabled = false;
                else almostdone = true;
            }
            if (almostdone == false)
            {
                foreach (CheckBox ch in panelCHK.Controls)
                {
                    ch.Enabled = true;
                }
            }
        }
    }
}
