using SerializableYugi.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SerializableYugi
{
    public partial class Carta : Form
    {

        int tipocarta = 0;
        string extradeck;
        public Carta(string iinombre, string iidescripcion, string iiatk, string iidef, string iitipomons, string iiatributo, string iiset, string iiruta, int iitipocarta, string iirareza, int iicopias, string iiextradeck, int iinivel)
        {
            InitializeComponent();
            tipocarta = iitipocarta;
            nombre.Text = iinombre.ToUpper();
            tipomons.Text = "[" + iitipomons + "]";
            descripcion.Text = iidescripcion;
            atk.Text += iiatk;
            def.Text += iidef;
            set.Text = iiset;
            extradeck = iiextradeck;
            tipomons.Visible = true;
            panel2.Visible = true;
            ilustracion.ImageLocation = iiruta;
            this.Text = "Nº de copias: " + iicopias + " - " + iirareza;
            switch (iiatributo)
            {
                case "Luz": atributo.Image = Properties.Resources.LIGHT; break;
                case "Oscuridad": atributo.Image = Properties.Resources.DARK; break;
                case "Viento": atributo.Image = Properties.Resources.WIND; break;
                case "Tierra": atributo.Image = Properties.Resources.EARTH; break;
                case "Fuego": atributo.Image = Properties.Resources.FIRE; break;
                case "Agua": atributo.Image = Properties.Resources.WATER; break;

            }

            switch (iiextradeck)
            {
                case "Fusion": this.BackgroundImage = Resources.fusion; break;
                case "Sincronia": this.BackgroundImage = Resources.SYNCHRONY; break;
                case "Xyz": this.BackgroundImage = Resources.XYZ; break;
                case "Link": this.BackgroundImage = Resources.LINK; break;
            }
            RellenarNiveles(iinivel);
        }//CONSTRUCTOR

        public Carta(string iinombre, string iitipo, string iidescripcion, string iiset, string iiruta, int iitipocarta, string iirareza, int iicopias)
        {
            InitializeComponent();
            tipocarta = iitipocarta;
            nombre.Text = iinombre.ToUpper();
            tipo.Text = iitipo;
            descripcion.Text = iidescripcion;
            set.Text = iiset;
            tipo.Visible = true;
            ilustracion.ImageLocation = iiruta;
            this.Controls.Remove(panelnivel);
            tipo.Location = new System.Drawing.Point(158, 54);
            this.Text = "Nº de copias: " + iicopias + " - " + iirareza;
            switch (iitipocarta)
            {
                case 2: atributo.Image = Properties.Resources.SPELL; this.BackgroundImage = Resources.SPELL_CARD; descripcion.BackColor = Color.Gainsboro; nombre.BackColor = Color.MediumSeaGreen; break;
                case 3: atributo.Image = Properties.Resources.TRAP; this.BackgroundImage = Resources.TRAP_CARD; break;
            }
        }//CONSTRUCTOR2

        private void Carta_Load(object sender, EventArgs e)
        {
            Fuente.CargarFuente();
            Fuente.LocalizarFuente(this.nombre, 9);
            Fuente.LocalizarFuente(this.descripcion, 8);
            Fuente.LocalizarFuente(atk, 8);
            Fuente.LocalizarFuente(def, 8);
            Fuente.LocalizarFuente(set, 8);
            Fuente.LocalizarFuente(tipomons, 7);
            Fuente.LocalizarFuente(tipo, 8);
            Fuente.LocalizarFuente(editar, 8);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 fr4 = null;
            switch (tipocarta)
            {
                case 1:
                    fr4 = new Form4(set.Text, 1);
                    break;
                case 2:
                    fr4 = new Form4(set.Text, 2);
                    break;
                case 3:
                    fr4 = new Form4(set.Text, 3);
                    break;
            }
            fr4.Show();
        }//BUTTON1

        public void RellenarNiveles(int iinivel)
        {
            foreach (PictureBox pb in panelnivel.Controls)
            {
                if (int.Parse(pb.Tag + "") < iinivel) pb.BackgroundImage = Resources.nivestrella;
            }//FOREACH
        }//RELLENAR NIVELES
    }//CLASS

}//NAMESPACE