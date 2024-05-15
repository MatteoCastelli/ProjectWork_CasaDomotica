using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RestSharp;
using System.IO.Ports;
using System.Reflection;


namespace ProjectWork_CasaDomotica
{
    public partial class Form1 : Form
       
    {

        static string porta;
        private BackgroundWorker dataReaderWorker;
        string receivedData;

        public Form1()
        {
            InitializeComponent();
           
            this.WindowState = FormWindowState.Maximized;  // Imposta la finestra di grandezza massima
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Imposta il form come non ridimensionabile

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            data.Text = DateTime.Now.ToLongDateString();
            ora.Text = DateTime.Now.ToLongTimeString();

            Getweatherdata("Vicenza");

            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                try
                {
                    using (SerialPort serialPort = new SerialPort(port, 9600))
                    {
                        serialPort.Open();
                        serialPort.WriteLine("Hello Arduino!"); // Invia un messaggio all'Arduino
                        System.Threading.Thread.Sleep(1000); // Aspetta un secondo per una risposta

                        string response = serialPort.ReadExisting();
                        if (!string.IsNullOrEmpty(response))
                        {
                            Console.WriteLine($"Arduino collegato alla porta: {port}");
                            break; // Esci dal ciclo quando trovi la porta corretta
                        }

                        porta = port;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore durante il tentativo di connessione alla porta {port}: {ex.Message}");
                }

                dataReaderWorker = new BackgroundWorker();
                //dataReaderWorker.DoWork += DataReaderWorker_DoWork;
                dataReaderWorker.RunWorkerAsync();
            }
        }

        //SerialPort portaSeriale = new SerialPort(porta, 9600);

        private void timer1_Tick(object sender, EventArgs e)
        {

            ora.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

        }

        private void Getweatherdata(string location)
        {
            var client = new RestClient($"https://wttr.in/{WebUtility.UrlEncode(location)}?format=%C");

            var request = new RestRequest();
            request.AddParameter("method", "GET");

            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                string[] weatherParameters = Regex.Split(response.Content, " ");

                if (weatherParameters.Length == 1)
                {   
                    Weather.Text = weatherParameters[0];
                }
                else if (weatherParameters.Length == 2)
                {
                    Weather.Text = weatherParameters[0] + " " + weatherParameters[1];
                }
                else if (weatherParameters.Length == 3)
                {
                    Weather.Text = weatherParameters[0] + " " + weatherParameters[1] + " " + weatherParameters[2];
                }

            }
            else
            {
                MessageBox.Show("Errore: " + response.StatusCode);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text == "OFF")
            {
                button2.Text = "ON";
                button2.BackColor = Color.LightGreen;
                panel1.BackColor = Color.FromArgb(128, 255, 255, 170);
                panel11.BackColor = Color.FromArgb(128, 255, 255, 170);

                //portaSeriale.Write("accendi_cucina");
            }
            else
            {
                button2.Text = "OFF";
                button2.BackColor = Color.IndianRed;
                panel1.BackColor = Color.Transparent;
                panel11.BackColor = Color.Transparent;

                //portaSeriale.Write("spegni_cucina");
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.Text == "OFF")
            {
                button12.Text = "ON";
                button12.BackColor = Color.LightGreen;
                panel6.BackColor = Color.FromArgb(128, 255, 255, 170);
                //portaSeriale.Write("accendi_bagno2");

            }
            else
            {
                button12.Text = "OFF";
                button12.BackColor = Color.IndianRed;
                panel6.BackColor = Color.Transparent;
                //portaSeriale.Write("spegni_bagno2");

            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.Text == "OFF")
            {
                button11.Text = "ON";
                button11.BackColor = Color.LightGreen;
                panel5.BackColor = Color.FromArgb(128, 255, 255, 170);
                //portaSeriale.Write("accendi_bagno1");


            }
            else
            {
                button11.Text = "OFF";
                button11.BackColor = Color.IndianRed;
                panel5.BackColor = Color.Transparent;
                //portaSeriale.Write("spegni_bagno1");
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text == "OFF")
            {
                button10.BackColor = Color.LightGreen;
                button10.Text = "ON";
                panel4.BackColor = Color.FromArgb(128, 255, 255, 170);
                //portaSeriale.Write("accendi_camera2");
            }
            else
            {
                button10.Text = "OFF";
                button10.BackColor = Color.IndianRed;
                panel3.BackColor = Color.Transparent;
                //portaSeriale.Write("spegni_camera2");

            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "OFF")
            {
                button9.Text = "ON";
                button9.BackColor = Color.LightGreen;
                panel3.BackColor = Color.FromArgb(128, 255, 255, 170);
                //portaSeriale.Write("accendi_camera1");
            }
            else
            {
                button9.Text = "OFF";
                button9.BackColor = Color.IndianRed;
                panel3.BackColor = Color.Transparent;
                //portaSeriale.Write("spegni_camera1");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "OFF")
            {
                button8.Text = "ON";
                button8.BackColor = Color.LightGreen;
                panel2.BackColor = Color.FromArgb(128, 255, 255, 170);
                //portaSeriale.Write("accendi_salotto");
            }
            else
            {
                button8.Text = "OFF";
                button8.BackColor = Color.IndianRed;
                panel2.BackColor = Color.Transparent;
                //portaSeriale.Write("spegni_salotto");
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.Text == "OFF")
            {
                button13.Text = "ON";
                button13.BackColor = Color.LightGreen;
                panel7.BackColor = Color.FromArgb(128, 255, 255, 170);
                panel8.BackColor = Color.FromArgb(128, 255, 255, 170);
                panel10.BackColor = Color.FromArgb(128, 255, 255, 170);

                //portaSeriale.Write("accendi_lavanderia");

            }
            else
            {
                button13.Text = "OFF";
                button13.BackColor = Color.IndianRed;
                panel7.BackColor = Color.Transparent;
                panel8.BackColor = Color.Transparent;
                panel10.BackColor = Color.Transparent;

                //portaSeriale.Write("spegni_lavanderia");

            }
        }

        private async void btnPorta_Click(object sender, EventArgs e)
        {
            if (btnPorta.Text == "APRI")
            {
                btnPorta.Text = "CHIUDI";
                //portaSeriale.Write("apri_porta");
                
                btnPorta.Enabled = false;
                await Task.Delay(2000);
                btnPorta.Enabled = true;

            }
            else
            {
                btnPorta.Text = "APRI";
                //portaSeriale.Write("chiudi_porta");

                btnPorta.Enabled = false;
                await Task.Delay(2000);
                btnPorta.Enabled = true;

            }

        }

        private void btnAllarme_Click(object sender, EventArgs e)
        {
            if (btnAllarme.Text == "ATTIVA")
            {
                btnAllarme.Text = "DISATTIVA";
                //portaSeriale.Write("attiva_allarme");

            }
            else
            {
                btnAllarme.Text = "ATTIVA";

                //portaSeriale.Write("disattiva_allarme");

            }

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnCampanello_Click(object sender, EventArgs e)
        {
            
                //portaSeriale.Write("suona_campanello");

                btnCampanello.Enabled = false;
                await Task.Delay(2000);
                btnCampanello.Enabled = true;

            

        }


        /*private void DataReaderWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                    // Apri la porta seriale
                    portaSeriale.Open();

                    // Continua a leggere i dati in un ciclo infinito
                    while (true)
                    {
                        receivedData = portaSeriale.ReadLine(); // Legge una riga di dati dalla porta seriale
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante la lettura dei dati dalla porta seriale: {ex.Message}", "Errore");
            }
        }*/

    }
}
