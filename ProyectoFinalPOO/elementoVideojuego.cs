using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPOO
{
    public class elementoVideojuego
    {
        public char tipo;
        public int numElemento, posX = 43, posY = 74;

        public elementoVideojuego(char tipo, int numElemento)
        {
            this.tipo = tipo;
            this.numElemento = numElemento;
        }

        public void calcularPos()
        {
            if (numElemento > 0 && numElemento < 10)
            {
                this.posX += ((numElemento + 1) * 56);
            }
            else if (numElemento >= 10 && numElemento < 20)
            {
                this.posY += (1 * 56);
                this.posX += ((numElemento - 10) * 56);
            }
            else if (numElemento >= 20 && numElemento < 30)
            {
                this.posY += (2 * 56);
                this.posX += ((numElemento - 20) * 56);
            }
            else if (numElemento >= 30 && numElemento < 40)
            {
                this.posY += (3 * 56);
                this.posX += ((numElemento - 30) * 56);
            }
            else if (numElemento >= 40 && numElemento < 50)
            {
                this.posY += (4 * 56);
                this.posX += ((numElemento - 40) * 56);
            }
            else if (numElemento >= 50 && numElemento < 60)
            {
                this.posY += (5 * 56);
                this.posX += ((numElemento - 50) * 56);
            }
            else if (numElemento >= 60 && numElemento < 70)
            {
                this.posY += (6 * 56);
                this.posX += ((numElemento - 60) * 56);
            }
            else if (numElemento >= 70 && numElemento < 80)
            {
                this.posY += (7 * 56);
                this.posX += ((numElemento - 70) * 56);
            }
            else if (numElemento >= 80 && numElemento < 90)
            {
                this.posY += (8 * 56);
                this.posX += ((numElemento - 80) * 56);
            }
            else if (numElemento >= 90 && numElemento < 100)
            {
                this.posY += (9 * 56);
                this.posX += ((numElemento - 90) * 56);
            }
        }


    }
}
