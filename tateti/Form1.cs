using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tateti
{
    public partial class Form1 : Form
    {
        bool jugadaGanadora(int idBoton, int[] tablero)
        {

            switch (idBoton)
            {
                case 0:
                    return (((tablero[1] == tablero[idBoton]) && (tablero[1] == tablero[2])) || ((tablero[3] == tablero[6]) && (tablero[6] == tablero[idBoton])) || ((tablero[4] == tablero[8]) && (tablero[4] == tablero[idBoton])));
                  
                case 1:
                    return (((tablero[0] == tablero[idBoton]) && (tablero[0] == tablero[2])) || ((tablero[4] == tablero[idBoton]) && (tablero[4] == tablero[7])));
                    
                case 2:
                    return (((tablero[1] == tablero[idBoton]) && (tablero[1] == tablero[0])) || ((tablero[5] == tablero[idBoton]) && (tablero[5] == tablero[8])) || ((tablero[4] == tablero[idBoton]) && (tablero[4] == tablero[6])));
                    
                case 3:
                    return (((tablero[0] == tablero[idBoton]) && (tablero[0] == tablero[6])) || ((tablero[4] == tablero[idBoton]) && (tablero[5] == tablero[4])));
                    
                case 4:
                    return (((tablero[0] == tablero[idBoton]) && (tablero[0] == tablero[8])) || ((tablero[2] == tablero[idBoton]) && (tablero[2] == tablero[6])) || ((tablero[1] == tablero[idBoton]) && (tablero[1] == tablero[7])) || ((tablero[3] == tablero[idBoton]) && (tablero[3] == tablero[5])));
                    
                case 5:
                    return (((tablero[2] == tablero[idBoton]) && (tablero[8] == tablero[2])) || ((tablero[4] == tablero[idBoton]) && (tablero[4] == tablero[3])));
                    
                case 6:
                    return (((tablero[0] == tablero[idBoton]) && (tablero[0] == tablero[3])) || ((tablero[7] == tablero[idBoton]) && (tablero[7] == tablero[8])));
                    
                case 7:
                    return (((tablero[1] == tablero[idBoton]) && (tablero[1] == tablero[4])) || ((tablero[6] == tablero[idBoton]) && (tablero[6] == tablero[8])));
                    
                case 8:
                    return (((tablero[2] == tablero[idBoton]) && (tablero[5] == tablero[2])) || ((tablero[6] == tablero[idBoton]) && (tablero[6] == tablero[7])));
                    
                default: return false;
            }
        }

        void jugadorGanador(int idBoton, int[] tablero)
        {
            if (jugadaGanadora(idBoton, tablero))
            {
                if(tablero[idBoton] == 1)
                {
                MessageBox.Show("TE GANÓ LA MÁQUINA, SORRY");
                }
                else if(tablero[idBoton] == 2)
                {
                    MessageBox.Show("GANASTE!");
                }
            }
        }

        void jugadaDeMaquina(Button botonGenerico, int[] unTablero, bool flag)
        {
            if (flag)
            {
                botonGenerico.BackColor = Color.Pink;
                botonGenerico.Text = "x";
                incrementarTurno();
            }

            unTablero[botonGenerico.TabIndex] = 1;
            
        }

        void jugadaDePersona(Button botonGenerico, int[] unTablero, bool flag)
        {
            if (flag) {
                botonGenerico.BackColor = Color.Blue;
                botonGenerico.Text = "O";
                incrementarTurno();
            }
            
            unTablero[botonGenerico.TabIndex] = 2;
            
        }

        Button evaluarJugada(Button botonGenerico, int[] tablero) //devuelve el numero de posición que debería ocuparse por la máquina
        {
            Button[] botones = new Button[] { sup1, sup2, sup3, medio1, medio2, medio3, inf1, inf2, inf3 };

            for (int u = 0; u < 8; u++)
            {
                //primero me fijo si la máquina puede ganar con la próxima jugada
                int[] copia = duplicadoDeTablero(tablero);
                if (estaLibre(u, copia))
                {
                    jugadaDeMaquina(botones[u],copia, false);
                    if (jugadaGanadora(u, copia))
                    {
                        return botones[u]; //retorno la posición libre con la que puedo ganar
                    }
                }
            }

            //me fijo si la persona puede ganar para bloquearla            
            for (int h = 0; h < 8; h++)
            {
                int[] copia = duplicadoDeTablero(tablero);
                if (estaLibre(h, copia))
                {
                    jugadaDePersona(botones[h], copia, false);
                    if (jugadaGanadora(h, copia))
                    {
                        return botones[h]; //retorna la posición que hay que bloquear
                    }
                }
            }

            //coloca en cualquier esquina
            int jugada = elegirAlAzarDe(tablero, esquinas);
            if (jugada != 1000)
            {
                return botones[jugada];
            }

            //coloca en el medio
            if (estaLibre(4, tablero))
            {
                return botones[4];
            }
            
            //coloca en algun lado
            int posicion = elegirAlAzarDe(tablero, medio);
            return botones[posicion];
        }


        Button primeraJugadaDeMaquina() //si el primer turno es de la máquina pone al azar
        {
            Button[] botones = new Button[] { sup1, sup2, sup3, medio1, medio2, medio3, inf1, inf2, inf3 };
            int primerJugada = elegirAlAzarDe(tablero, posicionesTablero);
            return botones[primerJugada];
        }
        Boolean estaLibre(int posicion, int[] unTablero) //dice si la celda todavía no fue usada
        {
            return unTablero[posicion] == 0; 
        }

        int elegirAlAzarDe(int[] tablero, int[] posiciones)
        {
            Random rand = new Random();
            

            int[] jugadasPosibles = new int[]{-1, -1, -1, -1, -1, -1, -1, -1, -1};
            int i = 0;
                  

            for (int j = 0; j < posiciones.Length; j++)
            {
                if (estaLibre(posiciones[j], tablero))
                {
                    jugadasPosibles[i] = posiciones[j];
                    i++;
                }
            }
            int y = 0;
            while (jugadasPosibles[y] != -1 && y<8){
                y++;
            }
           
            if (y > 0)
            {
                int index = rand.Next(y-1);
                return jugadasPosibles[index];
            }
            else
            {
                return 1000; //retorna error - que no hay jugadas posibles 
            }
        }

        int[] duplicadoDeTablero(int[] tablero)
        {
            int[] copia = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < tablero.Length; i++)
            {
                copia[i] = tablero[i];
            }
            return copia;
        }

        void incrementarTurno(){
            turno++;
        }

        void empate(int unTurno)
        {
            if (unTurno == 9)
            {
                MessageBox.Show("Empate");
            }
        }

        void respuestaDeLaMaquina(Button boton, int unTurno)
        {
            proximaJugada = evaluarJugada(boton, tablero);
            jugadaDeMaquina(proximaJugada, tablero, true);
            jugadorGanador(proximaJugada.TabIndex, tablero);
            empate(unTurno);
        }
        
        int[] tablero = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int turno = 0;
        int[] esquinas = new int[] { 0, 2, 6, 8 };
        int[] posicionesTablero = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] medio = new int[] { 1, 3, 5, 7 };
        Button proximaJugada;

        public Form1()
        {
            InitializeComponent();
        }

        private void Sup1_Click(object sender, EventArgs e) //este es el primero que pone la máquina siempre
        {
            jugadaDePersona(sup1, tablero, true);
            jugadorGanador(sup1.TabIndex, tablero);

            empate(turno);

            if (!jugadaGanadora(sup1.TabIndex, tablero) && turno <9)
            {
                respuestaDeLaMaquina(sup1, turno);
            }
        }

        private void Sup2_Click(object sender, EventArgs e)
        {
            jugadaDePersona(sup2, tablero, true);
            jugadorGanador(sup2.TabIndex, tablero);

            empate(turno);

            if (!jugadaGanadora(sup2.TabIndex, tablero) && turno < 9)
            {
                respuestaDeLaMaquina(sup2, turno);
            }
        }

        private void Sup3_Click(object sender, EventArgs e)
        {
            jugadaDePersona(sup3, tablero, true);
            jugadorGanador(sup3.TabIndex, tablero);

            empate(turno);

            if (!jugadaGanadora(sup3.TabIndex, tablero) && turno < 9)
            {
                respuestaDeLaMaquina(sup3, turno);
            }
        }

        private void Medio1_Click(object sender, EventArgs e)
        {
            jugadaDePersona(medio1, tablero, true);
            jugadorGanador(medio1.TabIndex, tablero);

            empate(turno);

            if (!jugadaGanadora(medio1.TabIndex, tablero) && turno < 9)
            {
                respuestaDeLaMaquina(medio1, turno);
            }
        }

        private void Medio2_Click(object sender, EventArgs e)
        {
            jugadaDePersona(medio2, tablero, true);
            jugadorGanador(medio2.TabIndex, tablero);

            empate(turno);

            if (!jugadaGanadora(medio2.TabIndex, tablero) && turno < 9)
            {
                respuestaDeLaMaquina(medio2, turno);
            }
        }

        private void Medio3_Click(object sender, EventArgs e)
        {
            jugadaDePersona(medio3, tablero, true);
            jugadorGanador(medio3.TabIndex, tablero);

            empate(turno);

            if (!jugadaGanadora(medio3.TabIndex, tablero) && turno < 9)
            {
                respuestaDeLaMaquina(medio3, turno);
            }
        }

        private void Inf1_Click(object sender, EventArgs e)
        {
            jugadaDePersona(inf1, tablero, true);
            jugadorGanador(inf1.TabIndex, tablero);

            empate(turno);

            if (!jugadaGanadora(inf1.TabIndex, tablero) && turno < 9)
            {
                respuestaDeLaMaquina(inf1, turno);
            }
        }

        private void Inf2_Click(object sender, EventArgs e)
        {
            jugadaDePersona(inf2, tablero, true);
            jugadorGanador(inf2.TabIndex, tablero);

            empate(turno);

            if (!jugadaGanadora(inf2.TabIndex, tablero) && turno < 9)
            {
                respuestaDeLaMaquina(inf2, turno);
            }
        }

        private void Inf3_Click(object sender, EventArgs e)
        {
            jugadaDePersona(inf3, tablero, true);
            jugadorGanador(inf3.TabIndex, tablero);

            empate(turno);

            if (!jugadaGanadora(inf3.TabIndex, tablero) && turno < 9)
            {
                respuestaDeLaMaquina(inf3, turno);
            }
        }

        private void Resultado_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reset.BackColor = Color.Aquamarine;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void JuegaUsuario_Click(object sender, EventArgs e)
        {
        }

        private void JuegaPc_Click(object sender, EventArgs e)
        {
            Button primerJugada = primeraJugadaDeMaquina();
            jugadaDeMaquina(primerJugada, tablero, true);
            
        }
    }
    
}
 
 
 