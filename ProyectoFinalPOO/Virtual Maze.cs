using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalPOO
{
    public partial class Form1 : Form
    {

        public ClaseNivel ClaseNivel = new ClaseNivel("", "");
        int numTurnos;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("VirtualMazeLogo.jpeg");
            comboBoxNiveles.Items.Add("Nivel 1");
            comboBoxNiveles.Items.Add("Nivel 2");
            comboBoxNiveles.Items.Add("Nivel 3");
            comboBoxNiveles.Items.Add("Nivel 4");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxBackground.Image = Image.FromFile("lava.gif");
        }

        private void eleccionNivel(string opcionNivel)
        {
            switch (opcionNivel)
            {
                case "Nivel 1":
                    ClaseNivel.nombreNivel = opcionNivel;
                    ClaseNivel.direccionNivel = "Nivel1.txt";
                    numTurnos = 7;
                    
                    break;
                case "Nivel 2":
                    ClaseNivel.nombreNivel = opcionNivel;
                    ClaseNivel.direccionNivel = "Nivel2.txt";
                    numTurnos = 8;
                    break;
                case "Nivel 3":
                    ClaseNivel.nombreNivel = opcionNivel;
                    ClaseNivel.direccionNivel = "Nivel3.txt";
                    numTurnos = 8;
                    break;
                case "Nivel 4":
                    ClaseNivel.nombreNivel = opcionNivel;
                    ClaseNivel.direccionNivel = "Nivel4.txt";
                    numTurnos = 8;
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            eleccionNivel(comboBoxNiveles.Text);
            Nivel_1 nivel = new Nivel_1(ClaseNivel.direccionNivel,numTurnos);
            this.Hide();
            nivel.Show();
        }

        private void comboBoxNiveles_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
