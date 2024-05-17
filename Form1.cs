using RestSharp;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProjectWork_CasaDomotica
{
    public partial class Form1 : Form

    {
        string porta;

        private Thread receiveThread;

        SerialPort portaSeriale;
        private void btnSeriale_Click(object sender, EventArgs e)
        {
            porta = textBoxSeriale.Text;

            portaSeriale = new SerialPort(porta, 9600);

            portaSeriale.Open();

            receiveThread = new Thread(ReceiveDataFromArduino);
            receiveThread.Start();

            if (porta != "")
            {
                this.Controls.Remove(btnSeriale);
                this.Controls.Remove(label3);
                this.Controls.Remove(textBoxSeriale);
            }
        }

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
        }

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
        
        private async void btnPorta_Click(object sender, EventArgs e)
        {
            if (btnPorta.Text == "APRI")
            {
                btnPorta.Text = "CHIUDI";
                portaSeriale.Write("apri_porta");
                btnPorta.Enabled = false;
                await Task.Delay(2000);
                btnPorta.Enabled = true;
            }
            else
            {
                btnPorta.Text = "APRI";
                portaSeriale.Write("chiudi_porta");

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
                portaSeriale.Write("attiva_allarme");
            }
            else
            {
                btnAllarme.Text = "ATTIVA";
                portaSeriale.Write("disattiva_allarme");
            }
        }

        private async void btnCampanello_Click(object sender, EventArgs e)
        {  
                portaSeriale.Write("suona_campanello");
                btnCampanello.Enabled = false;
                await Task.Delay(2000);
                btnCampanello.Enabled = true;       
        }

        private void btnSalotto_Click_1(object sender, EventArgs e)
        {
            if (btnSalotto.Text == "OFF")
            {
                btnSalotto.Text = "ON";
                btnSalotto.BackColor = Color.LightGreen;
                panel2.BackColor = Color.FromArgb(128, 255, 255, 170);
                portaSeriale.Write("accendi_salotto");
            }
            else
            {
                btnSalotto.Text = "OFF";
                btnSalotto.BackColor = Color.IndianRed;
                panel2.BackColor = Color.Transparent;
                portaSeriale.Write("spegni_salotto");
            }
        }

        private void btnCamera1_Click_1(object sender, EventArgs e)
        {
                if (btnCamera1.Text == "OFF")
                {
                    btnCamera1.Text = "ON";
                    btnCamera1.BackColor = Color.LightGreen;
                    panel3.BackColor = Color.FromArgb(128, 255, 255, 170);
                    portaSeriale.Write("accendi_camera1");
                }
                else
                {
                    btnCamera1.Text = "OFF";
                    btnCamera1.BackColor = Color.IndianRed;
                    panel3.BackColor = Color.Transparent;
                    portaSeriale.Write("spegni_camera1");
                }
        }

        private void btnCamera2_Click_1(object sender, EventArgs e)
        {
            if (btnCamera2.Text == "OFF")
            {
                btnCamera2.BackColor = Color.LightGreen;
                btnCamera2.Text = "ON";
                panel4.BackColor = Color.FromArgb(128, 255, 255, 170);
                portaSeriale.Write("accendi_camera2");
            }
            else
            {
                btnCamera2.Text = "OFF";
                btnCamera2.BackColor = Color.IndianRed;
                panel3.BackColor = Color.Transparent;
                portaSeriale.Write("spegni_camera2");
            }
        }

        private void btnCucina_Click_1(object sender, EventArgs e)
        {
            if (btnCucina.Text == "OFF")
            {
                btnCucina.Text = "ON";
                btnCucina.BackColor = Color.LightGreen;
                panel1.BackColor = Color.FromArgb(128, 255, 255, 170);
                panel11.BackColor = Color.FromArgb(128, 255, 255, 170);

                portaSeriale.Write("accendi_cucina");
            }
            else
            {
                btnCucina.Text = "OFF";
                btnCucina.BackColor = Color.IndianRed;
                panel1.BackColor = Color.Transparent;
                panel11.BackColor = Color.Transparent;

                portaSeriale.Write("spegni_cucina");
            }
        }

        private void btnBagno_Click(object sender, EventArgs e)
        {
            if (btnBagno.Text == "OFF")
            {
                btnBagno.Text = "ON";
                btnBagno.BackColor = Color.LightGreen;
                panel5.BackColor = Color.FromArgb(128, 255, 255, 170);
                portaSeriale.Write("accendi_bagno1");
            }
            else
            {
                btnBagno.Text = "OFF";
                btnBagno.BackColor = Color.IndianRed;
                panel5.BackColor = Color.Transparent;
                portaSeriale.Write("spegni_bagno1");
            }
        }

        private void btnWc_Click(object sender, EventArgs e)
        {
            if (btnWc.Text == "OFF")
            {
                btnWc.Text = "ON";
                btnWc.BackColor = Color.LightGreen;
                panel6.BackColor = Color.FromArgb(128, 255, 255, 170);
                portaSeriale.Write("accendi_bagno2");
            }
            else
            {
                btnWc.Text = "OFF";
                btnWc.BackColor = Color.IndianRed;
                panel6.BackColor = Color.Transparent;
                portaSeriale.Write("spegni_bagno2");
            }
        }

        private void btnLavanderia_Click_1(object sender, EventArgs e)
        {
            if (btnLavanderia.Text == "OFF")
            {
                btnLavanderia.Text = "ON";
                btnLavanderia.BackColor = Color.LightGreen;
                panel7.BackColor = Color.FromArgb(128, 255, 255, 170);
                panel8.BackColor = Color.FromArgb(128, 255, 255, 170);
                panel10.BackColor = Color.FromArgb(128, 255, 255, 170);
                portaSeriale.Write("accendi_lavanderia");
            }
            else
            {
                btnLavanderia.Text = "OFF";
                btnLavanderia.BackColor = Color.IndianRed;
                panel7.BackColor = Color.Transparent;
                panel8.BackColor = Color.Transparent;
                panel10.BackColor = Color.Transparent;
                portaSeriale.Write("spegni_lavanderia");
            }
        }

        private void ReceiveDataFromArduino()
        {
            while (true)
            {
                try
                {
                    string dataRead = portaSeriale.ReadLine();
                    Console.WriteLine(dataRead);
                    this.Invoke((MethodInvoker)delegate {
                        if (dataRead == "disattiva_allarme")
                        {
                            btnAllarme.Text = "ATTIVA";
                        }
                        else
                        {
                            string[] div = dataRead.Split();

                            if (div[0] == "H")
                            {
                                lblUmidita.Text = "UM: " + div[1] + "%";
                            }
                            if (div[0] == "T")
                            {
                                lblTemp.Text = "TEMP: " + div[1] + "°C";
                            }
                        }

                        if (dataRead == "porta_aperta")
                        {
                            btnPorta.Text = "CHIUDI";
                            portaSeriale.Write("apri_porta");
                            btnCampanello.Enabled = false;
                            Thread.Sleep(3000);
                            btnCampanello.Enabled = true;
                        }
                    });
                }
                catch (TimeoutException) { }
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            if (btnFoto.Text == "ATTIVA")
            {
                btnFoto.Text = "DISATTIVA";
                portaSeriale.Write("attiva_foto");
            }
            else
            {
                btnFoto.Text = "ATTIVA";
                portaSeriale.Write("disattiva_foto");
            }
        }
    }
}