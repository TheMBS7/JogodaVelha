namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int ContVitoriasO = 0;
        int ContVitoriasX = 0;
        bool Turno = true;
        ResultClic[,] Resultado = new ResultClic[3, 3];
        public enum ResultClic
        {
            X = 1,
            O = 2
        }

        int ContadorTurno = 0;

        public void Reset()
        {
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
            Resultado = new ResultClic[3, 3];
            ContadorTurno = 0;
        }

        public void MensagemVitoria(string quemGanhou)
        {
            
            DialogResult ResultadoDialogo = MessageBox.Show($"O jogador com o '{quemGanhou}' venceu a partida!");

            if(quemGanhou == "X")
            {
                ContVitoriasX++;
                lblP1.Text = ContVitoriasX.ToString();
            }
            else
            {
                ContVitoriasO++;
                lblP2.Text = ContVitoriasO.ToString();
            }
            if (ResultadoDialogo == DialogResult.OK)
            {
                Reset();
            }
        }
    
        public void Vitoria()
        {
            //Linhas
            for (int b = 0; b < 3; b++)
            {
                if (Resultado[b, 0] == ResultClic.X && Resultado[b, 1] == ResultClic.X && Resultado[b, 2] == ResultClic.X)
                {
                    MensagemVitoria("X");
                    
                }

                else if (Resultado[b, 0] == ResultClic.O && Resultado[b, 1] == ResultClic.O && Resultado[b, 2] == ResultClic.O)
                {
                    MensagemVitoria("O");
                    
                }
            }

            //Colunas
            for (int b = 0; b < 3; b++)
            {
                if (Resultado[0, b] == ResultClic.X && Resultado[1, b] == ResultClic.X && Resultado[2, b] == ResultClic.X)
                {
                    MensagemVitoria("X");
                    
                }

                else if (Resultado[0, b] == ResultClic.O && Resultado[1, b] == ResultClic.O && Resultado[2, b] == ResultClic.O)
                {
                    MensagemVitoria("O");
                    
                }
            }

            //Diagonal \
            if (Resultado[0, 0] == ResultClic.X && Resultado[1, 1] == ResultClic.X && Resultado[2, 2] == ResultClic.X)
            {
                MensagemVitoria("X");
                
            }
            else if (Resultado[0, 0] == ResultClic.O && Resultado[1, 1] == ResultClic.O && Resultado[2, 2] == ResultClic.O)
            {
                MensagemVitoria("O");
                
            }

            //Diagonal /
            else if (Resultado[0, 2] == ResultClic.X && Resultado[1, 1] == ResultClic.X && Resultado[2, 0] == ResultClic.X)
            {
                MensagemVitoria("X");
                
            }
            else if (Resultado[0, 2] == ResultClic.O && Resultado[1, 1] == ResultClic.O && Resultado[2, 0] == ResultClic.O)
            {
                MensagemVitoria("O");
                
            }
        }

        public void Empate()
        {
            if (ContadorTurno == 9)
            {
                DialogResult ResultadoDialogo = MessageBox.Show("O jogo deu velha!");
                if (ResultadoDialogo == DialogResult.OK)
                {
                    Reset();
                }
            }
        }
        

        public void BotaoPadrao(Button BotaoJunto, int X, int Y)
        {
            if (Resultado[X, Y] != ResultClic.O && Resultado[X, Y] != ResultClic.X)
            {

                if (Turno == true)
                {
                    BotaoJunto.Text = "X";
                    Turno = false;
                    Resultado[X, Y] = ResultClic.X;
                }
                else
                {
                    BotaoJunto.Text = "O";
                    Turno = true;
                    Resultado[X, Y] = ResultClic.O;
                    
                }
                ContadorTurno++;
                Vitoria();
                Empate();
            }
            
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            BotaoPadrao(button1, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BotaoPadrao(button2, 0, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BotaoPadrao(button3, 0, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BotaoPadrao(button4, 1, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BotaoPadrao(button5, 1, 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BotaoPadrao(button6, 1, 2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BotaoPadrao(button7, 2, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BotaoPadrao(button8, 2, 1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BotaoPadrao(button9, 2, 2);
        }
    }
}