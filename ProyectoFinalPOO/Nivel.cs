using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinalPOO
{
    public partial class Nivel_1 : Form
    {
        string nivel;
        int numTurnos;
        List<laberintoHorizontal> laberinto = new List<laberintoHorizontal>();
        List<elementoVideojuego> listElementos = new List<elementoVideojuego>();
        elementoVideojuego jugador = new elementoVideojuego('j', 0);
        bool banderaMov = false;
        int contadorMovimientos = 0;
        public Nivel_1(string nivel, int numTurnos)
        {
            InitializeComponent();
            this.nivel = nivel;
            this.numTurnos = numTurnos;
        }

        private void Nivel_1_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBoxBackgroundLevel.Image = Image.FromFile("lavaNivel.gif");
                pictureBoxEquis.Image = Image.FromFile("equis.png");
                pictureBoxPortal.Image = Image.FromFile("portal.png");
                pictureBoxTile.Image = Image.FromFile("tile2.png");
                pictureBoxFinNivel.Image = Image.FromFile("finNivel.png");
                pictureBoxPlayer.Image = Image.FromFile("amogus1.png");
                Maximo.Text = "Maximo: " + (numTurnos+1);
                leerNivel(nivel);
                generarNivel();
                elementosJuego();
                juego();
                jugador.calcularPos();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("El archivo: '" + ex.Message + "' no se encuentra en el directorio.");
            }
           
        }

        private void leerNivel(string nivel)
        {

            try
            {
                StreamReader reader = new StreamReader(nivel);
                while (!reader.EndOfStream)
                {
                    laberintoHorizontal laberintoHorizontal = new laberintoHorizontal(reader.ReadLine());
                    laberinto.Add(laberintoHorizontal);
                }
                reader.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void generarNivel()
        {

            int generacionHorizontal = 0;
            foreach (var item in laberinto)
            {
                generacionHorizontal++;
                switch (generacionHorizontal)
                {
                    case 1:
                        for (int i = 0; i < item.elementos.Length && i < 10; i++)
                        {
                            switch (i)
                            {
                                case 9:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox1.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox1.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox1.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox1.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox1.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 8:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox2.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox2.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox2.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox2.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox2.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 7:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox3.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox3.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox3.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox3.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox3.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 6:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox4.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox4.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox4.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox4.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox4.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 5:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox5.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox5.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox5.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox5.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox5.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox6.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox6.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox6.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox6.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox6.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox7.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox7.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox7.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox7.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox7.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox8.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox8.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox8.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox8.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox8.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 1:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox9.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox9.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox9.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox9.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox9.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 0:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox10.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox10.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox10.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox10.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox10.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                            }

                        }
                        break;
                    case 2:
                        for (int i = 0; i < item.elementos.Length && i < 10; i++)
                        {
                            switch (i)
                            {
                                case 9:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox11.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox11.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox11.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox11.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox11.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 8:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox12.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox12.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox12.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox12.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox12.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 7:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox13.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox13.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox13.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox13.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox13.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 6:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox14.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox14.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox14.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox14.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox14.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 5:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox15.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox15.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox15.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox15.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox15.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox16.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox16.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox16.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox16.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox16.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox17.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox17.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox17.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox17.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox17.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox18.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox18.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox18.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox18.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox18.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 1:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox19.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox19.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox19.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox19.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox19.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 0:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox20.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox20.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox20.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox20.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox20.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                            }

                        }
                        break;
                    case 3:
                        for (int i = 0; i < item.elementos.Length && i < 10; i++)
                        {
                            switch (i)
                            {
                                case 9:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox21.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox21.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox21.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox21.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox21.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 8:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox22.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox22.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox22.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox22.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox22.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 7:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox23.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox23.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox23.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox23.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox23.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 6:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox24.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox24.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox24.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox24.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox24.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 5:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox25.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox25.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox25.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox25.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox25.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox26.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox26.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox26.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox26.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox26.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox27.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox27.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox27.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox27.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox27.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox28.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox28.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox28.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox28.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox28.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 1:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox29.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox29.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox29.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox29.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox29.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 0:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox30.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox30.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox30.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox30.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox30.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                            }

                        }
                        break;
                    case 4:
                        for (int i = 0; i < item.elementos.Length && i < 10; i++)
                        {
                            switch (i)
                            {
                                case 9:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox31.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox31.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox31.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox31.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox31.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 8:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox32.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox32.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox32.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox32.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox32.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 7:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox33.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox33.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox33.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox33.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox33.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 6:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox34.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox34.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox34.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox34.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox34.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 5:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox35.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox35.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox35.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox35.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox35.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox36.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox36.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox36.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox36.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox36.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox37.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox37.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox37.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox37.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox37.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox38.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox38.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox38.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox38.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox38.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 1:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox39.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox39.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox39.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox39.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox39.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 0:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox40.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox40.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox40.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox40.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox40.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                            }

                        }
                        break;
                    case 5:
                        for (int i = 0; i < item.elementos.Length && i < 10; i++)
                        {
                            switch (i)
                            {
                                case 9:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox41.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox41.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox41.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox41.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox41.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 8:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox42.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox42.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox42.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox42.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox42.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 7:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox43.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox43.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox43.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox43.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox43.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 6:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox44.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox44.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox44.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox44.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox44.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 5:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox45.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox45.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox45.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox45.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox45.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox46.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox46.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox46.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox46.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox46.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox47.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox47.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox47.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox47.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox47.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox48.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox48.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox48.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox48.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox48.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 1:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox49.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox49.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox49.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox49.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox49.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 0:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox50.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox50.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox50.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox50.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox50.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                            }

                        }
                        break;
                    case 6:
                        for (int i = 0; i < item.elementos.Length && i < 10; i++)
                        {
                            switch (i)
                            {
                                case 9:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox51.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox51.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox51.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox51.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox51.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 8:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox52.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox52.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox52.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox52.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox52.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 7:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox53.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox53.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox53.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox53.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox53.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 6:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox54.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox54.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox54.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox54.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox54.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 5:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox55.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox55.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox55.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox55.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox55.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox56.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox56.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox56.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox56.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox56.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox57.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox57.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox57.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox57.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox57.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox58.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox58.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox58.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox58.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox58.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 1:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox59.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox59.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox59.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox59.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox59.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 0:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox60.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox60.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox60.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox60.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox60.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                            }

                        }
                        break;
                    case 7:
                        for (int i = 0; i < item.elementos.Length && i < 10; i++)
                        {
                            switch (i)
                            {
                                case 9:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox61.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox61.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox61.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox61.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox61.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 8:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox62.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox62.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox62.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox62.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox62.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 7:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox63.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox63.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox63.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox63.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox63.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 6:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox64.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox64.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox64.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox64.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox64.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 5:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox65.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox65.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox65.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox65.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox65.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox66.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox66.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox66.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox66.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox66.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox67.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox67.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox67.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox67.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox67.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox68.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox68.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox68.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox68.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox68.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 1:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox69.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox69.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox69.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox69.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox69.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 0:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox70.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox70.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox70.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox70.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox70.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                            }

                        }
                        break;
                    case 8:
                        for (int i = 0; i < item.elementos.Length && i < 10; i++)
                        {
                            switch (i)
                            {
                                case 9:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox71.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox71.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox71.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox71.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox71.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 8:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox72.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox72.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox72.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox72.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox72.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 7:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox73.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox73.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox73.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox73.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox73.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 6:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox74.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox74.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox74.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox74.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox74.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 5:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox75.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox75.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox75.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox75.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox75.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox76.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox76.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox76.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox76.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox76.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox77.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox77.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox77.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox77.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox77.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox78.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox78.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox78.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox78.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox78.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 1:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox79.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox79.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox79.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox79.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox79.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 0:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox80.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox80.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox80.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox80.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox80.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                            }

                        }
                        break;
                    case 9:
                        for (int i = 0; i < item.elementos.Length && i < 10; i++)
                        {
                            switch (i)
                            {
                                case 9:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox81.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox81.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox81.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox81.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox81.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 8:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox82.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox82.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox82.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox82.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox82.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 7:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox83.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox83.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox83.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox83.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox83.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 6:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox84.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox84.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox84.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox84.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox84.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 5:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox85.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox85.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox85.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox85.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox85.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox86.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox86.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox86.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox86.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox86.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox87.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox87.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox87.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox87.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox87.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox88.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox88.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox88.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox88.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox88.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 1:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox89.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox89.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox89.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox89.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox89.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 0:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox90.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox90.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox90.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox90.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox90.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                            }

                        }
                        break;
                    case 10:
                        for (int i = 0; i < item.elementos.Length && i < 10; i++)
                        {
                            switch (i)
                            {
                                case 9:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox91.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox91.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox91.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox91.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox91.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 8:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox92.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox92.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox92.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox92.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox92.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 7:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox93.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox93.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox93.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox93.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox93.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 6:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox94.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox94.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox94.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox94.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox94.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 5:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox95.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox95.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox95.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox95.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox95.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox96.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox96.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox96.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox96.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox96.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox97.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox97.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox97.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox97.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox97.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox98.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox98.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox98.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox98.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox98.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 1:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox99.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox99.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox99.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox99.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox99.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 0:
                                    switch (item.elementos[i])
                                    {
                                        case 'x':
                                            pictureBox100.Image = pictureBoxEquis.Image;
                                            break;
                                        case ' ':
                                            pictureBox100.Image = pictureBoxTile.Image;
                                            break;
                                        case 'r':
                                            pictureBox100.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'i':
                                            pictureBox100.Image = pictureBoxPortal.Image;
                                            break;
                                        case 'f':
                                            pictureBox100.Image = pictureBoxFinNivel.Image;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                            }

                        }
                        break;

                    default:
                        break;

                }
            }
        }

        public void elementosJuego()
        {
            int j = 0, k = 0;
            foreach (var item in laberinto)
            {
                for (int i = 0; i < item.elementos.Length && i < 10; i++)
                {
                    k = j + i;
                    elementoVideojuego elementoVideo = new elementoVideojuego(item.elementos[i], k);
                    listElementos.Add(elementoVideo);
                }
                j += 10;
            }
        }

        public void juego()
        {
            foreach (var item in listElementos)
            {
                item.calcularPos();
                if (item.tipo == 'i')
                {
                    pictureBoxPlayer.Top = item.posY;
                    pictureBoxPlayer.Left = item.posX;
                    jugador.numElemento = item.numElemento;
                }
            }

        }


        private void Nivel_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Nivel_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                do
                {
                    moverX(-56);
                } while (!banderaMov);
                banderaMov = false;


            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                do
                {
                    moverX(+56);

                } while (!banderaMov);
                banderaMov = false;
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                do
                {
                    moverY(-56);
                } while (!banderaMov);
                banderaMov = false;
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                do
                {
                    moverY(+56);
                } while (!banderaMov);
                banderaMov = false;
            }
            Contador.Text = "Movimientos: " + contadorMovimientos;
            if (contadorMovimientos > numTurnos)
            {
                MessageBox.Show(" Has alcanzado el maximo de turnos permitido. Reiniciar nivel?");
                foreach (var item1 in listElementos)
                {
                    if (item1.tipo == 'i')
                    {
                        jugador.posX = item1.posX;
                        jugador.posY = item1.posY;
                        pictureBoxPlayer.Left = jugador.posX;
                        pictureBoxPlayer.Top = jugador.posY;
                        contadorMovimientos = 0;
                        Contador.Text = "Movimientos: " + contadorMovimientos;
                    }
                }
            }

        }

        public void moverX(int a)
        {
            int x = jugador.posX;

            bool banderaBorder = false;
                x += a;
                if (x < 43)
                {
                    jugador.posX = 547;
                    banderaBorder = true;
                    pictureBoxPlayer.Left = jugador.posX;
                }

                if (x > 549)
                {
                    jugador.posX = 43;
                    banderaBorder = true;
                    pictureBoxPlayer.Left = jugador.posX;
                }

                while (!banderaBorder)
                {
                    foreach (var item in listElementos)
                    {
                        if (item.posX == x && item.posY == jugador.posY)
                        {
                            switch (item.tipo)
                            {
                                case 'x':
                                    banderaMov = true;
                                    break;
                                case ' ':
                                    jugador.posX = item.posX;
                                    pictureBoxPlayer.Left = jugador.posX;
                                    break;
                                case 'i':
                                    jugador.posX = item.posX;
                                    pictureBoxPlayer.Left = jugador.posX;
                                    break;
                                case 'r':
                                    foreach (var item1 in listElementos)
                                    {
                                        if (item1.tipo == 'i')
                                        {
                                            jugador.posX = item1.posX;
                                            jugador.posY = item1.posY;
                                            pictureBoxPlayer.Left = jugador.posX;
                                            pictureBoxPlayer.Top = jugador.posY;
                                            contadorMovimientos = -1;
                                        }
                                    }
                                    break;
                                case 'f':
                                jugador.posX = item.posX;
                                jugador.posY = item.posY;
                                pictureBoxPlayer.Left = jugador.posX;
                                pictureBoxPlayer.Top = jugador.posY;
                                banderaMov = true;
                                MessageBox.Show(" Has ganado!! Movimientos totales: " + (contadorMovimientos + 1));
                                foreach (var item1 in listElementos)
                                {
                                    if (item1.tipo == 'i')
                                    {
                                        jugador.posX = item1.posX;
                                        jugador.posY = item1.posY;
                                        pictureBoxPlayer.Left = jugador.posX;
                                        pictureBoxPlayer.Top = jugador.posY;
                                        contadorMovimientos = -1;
                                    }
                                }
                                break;
                            }
                        }
                    }
                    banderaBorder = true;
                }
            

            if (banderaMov)
            {
                contadorMovimientos++;
            }
        }

        public void moverY(int a)
        {
            int y = jugador.posY;
            bool banderaBorder;
            
                banderaBorder = false;
                y += a;
                if (y < 74)
                {
                    jugador.posY = 578;
                    banderaBorder = true;
                    pictureBoxPlayer.Top = jugador.posY;
                }

                if (y > 578)
                {
                    jugador.posY = 74;
                    banderaBorder = true;
                    pictureBoxPlayer.Top = jugador.posY;
                }

                while (!banderaBorder)
                {
                    foreach (var item in listElementos)
                    {
                        if (item.posY == y && item.posX == jugador.posX)
                        {
                            switch (item.tipo)
                            {
                                case 'x':
                                    banderaMov = true;
                                    break;
                                case ' ':
                                    jugador.posY = item.posY;
                                    pictureBoxPlayer.Top = jugador.posY;
                                    break;
                                case 'i':
                                    jugador.posY = item.posY;
                                    pictureBoxPlayer.Top = jugador.posY;
                                    break;
                                case 'r':
                                    foreach (var item1 in listElementos)
                                    {
                                        if (item1.tipo == 'i')
                                        {
                                            jugador.posX = item1.posX;
                                            jugador.posY = item1.posY;
                                            pictureBoxPlayer.Left = jugador.posX;
                                            pictureBoxPlayer.Top = jugador.posY;
                                            contadorMovimientos = -1;
                                        }
                                    }
                                    break;
                                case 'f':
                                jugador.posX = item.posX;
                                jugador.posY = item.posY;
                                pictureBoxPlayer.Left = jugador.posX;
                                pictureBoxPlayer.Top = jugador.posY;
                                banderaMov = true;
                                MessageBox.Show(" Has ganado!! Movimientos totales: " + (contadorMovimientos + 1));
                                foreach (var item1 in listElementos)
                                {
                                    if (item1.tipo == 'i')
                                    {
                                        jugador.posX = item1.posX;
                                        jugador.posY = item1.posY;
                                        pictureBoxPlayer.Left = jugador.posX;
                                        pictureBoxPlayer.Top = jugador.posY;
                                        contadorMovimientos = -1;
                                    }
                                }
                                break;
                            }
                        }
                    }
                    banderaBorder = true;
                }

            if (banderaMov)
            {
                contadorMovimientos++;
            }
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
