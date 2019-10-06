using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;  // necessário para ter acesso as portas

namespace interfaceArduinoVS2013
{
    public partial class Form1 : Form
    {

        string RxString;
  

        public Form1()
        {
            InitializeComponent();
            timerCOM.Enabled = true;
        }

        /* CRONOMETRO PARA CONTAGEM DO TEMPO 
           GASTO NA FISIOTERAPIA 
        */

        int minutos = 0;
        int segundos = 0;
        double milisegundos = 0;



       
        private void AtualizaCronometro()
        {
            label4.Text = minutos.ToString("00") + ":" + segundos.ToString("00") + "." + milisegundos.ToString("00").Substring(0, 2);
        }

  

        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente;    //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            comboBox1.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            comboBox1.SelectedIndex = 0;
        }

        private void timerCOM_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    serialPort1.Open();
                    timer1.Start();

                }
                catch
                {
                    return;

                }
                if (serialPort1.IsOpen)
                {
                    btConectar.Text = "Desconectar";
                    comboBox1.Enabled = false;

                }
            }
            else
            {

                try
                {
                    serialPort1.Close();
                    comboBox1.Enabled = true;
                    btConectar.Text = "Conectar";
                }
                catch
                {
                    return;
                }

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(serialPort1.IsOpen == true)  // se porta aberta 
             serialPort1.Close();            //fecha a porta
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen == true)          //porta está aberta
            serialPort1.Write(textBoxEnviar.Text);  //envia o texto presente no textbox Enviar
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadLine();              //le o dado disponível na serial
            this.Invoke(new EventHandler(trataDadoRecebido));   //chama outra thread para escrever o dado no text box
        }

        int contador = 0;

        private void trataDadoRecebido(object sender, EventArgs e)
        {
            textBoxReceber.AppendText(RxString);
            textBoxReceber.AppendText("\n");

            int valor = Int32.Parse(RxString);

            if (valor > 100)
            {

                contador++;


            }

            if (contador == 20)
            {
                balao1.Visible = true;
                progressBar1.Value = 10;

            }

            if (contador == 40)
            {
                balao2.Visible = true;
                progressBar1.Value = 20;

            }

            if (contador ==60)
            {
                balao3.Visible = true;
                progressBar1.Value = 30;

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

       


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            ///<summary> 
            ///O valor de 15.650 para sincronizar com o timer!
            ///O timer n sincroniza sozinho e o tempo estavam correndo mais devagar
            ///Caso estivesse sincronizado o valor a ser recebido seria de 10
            ///Foi constadada a diferença de 1 segundo para cima após 10 minutos de contagem!
            ///</summary>

            milisegundos += 15.650;

            if (milisegundos >= 1000)
            {
                milisegundos = 0;

                segundos++;

                if (segundos >= 60)
                {
                    segundos = 0;

                    minutos++;
                }
            }

            AtualizaCronometro();

            Application.DoEvents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            balao1.Visible = false;
            balao2.Visible = false;
            balao3.Visible = false;
            balao4.Visible = false;
            balao5.Visible = false;
            balao6.Visible = false;
            balao7.Visible = false;
            balao8.Visible = false;

        }

    }
}
