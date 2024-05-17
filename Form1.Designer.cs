namespace ProjectWork_CasaDomotica
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.data = new System.Windows.Forms.Label();
            this.ora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Weather = new System.Windows.Forms.Label();
            this.btnCucina = new System.Windows.Forms.Button();
            this.salotto = new System.Windows.Forms.Label();
            this.cucina = new System.Windows.Forms.Label();
            this.btnSalotto = new System.Windows.Forms.Button();
            this.camera1 = new System.Windows.Forms.Label();
            this.btnCamera1 = new System.Windows.Forms.Button();
            this.camera2 = new System.Windows.Forms.Label();
            this.btnCamera2 = new System.Windows.Forms.Button();
            this.bagno = new System.Windows.Forms.Label();
            this.btnBagno = new System.Windows.Forms.Button();
            this.wc = new System.Windows.Forms.Label();
            this.btnWc = new System.Windows.Forms.Button();
            this.lavanderia = new System.Windows.Forms.Label();
            this.btnLavanderia = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCampanello = new System.Windows.Forms.Button();
            this.btnPorta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAllarme = new System.Windows.Forms.Label();
            this.btnAllarme = new System.Windows.Forms.Button();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblUmidita = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSeriale = new System.Windows.Forms.TextBox();
            this.btnSeriale = new System.Windows.Forms.Button();
            this.btnFoto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.Location = new System.Drawing.Point(32, 71);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(70, 32);
            this.data.TabIndex = 0;
            this.data.Text = "data";
            // 
            // ora
            // 
            this.ora.AutoSize = true;
            this.ora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ora.Location = new System.Drawing.Point(32, 106);
            this.ora.Name = "ora";
            this.ora.Size = new System.Drawing.Size(55, 32);
            this.ora.TabIndex = 1;
            this.ora.Text = "ora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Weather
            // 
            this.Weather.AutoSize = true;
            this.Weather.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weather.Location = new System.Drawing.Point(32, 140);
            this.Weather.Name = "Weather";
            this.Weather.Size = new System.Drawing.Size(121, 32);
            this.Weather.TabIndex = 2;
            this.Weather.Text = "Weather";
            // 
            // btnCucina
            // 
            this.btnCucina.BackColor = System.Drawing.Color.IndianRed;
            this.btnCucina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCucina.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCucina.Location = new System.Drawing.Point(276, 296);
            this.btnCucina.Margin = new System.Windows.Forms.Padding(4);
            this.btnCucina.Name = "btnCucina";
            this.btnCucina.Size = new System.Drawing.Size(100, 38);
            this.btnCucina.TabIndex = 6;
            this.btnCucina.Text = "OFF";
            this.btnCucina.UseVisualStyleBackColor = false;
            this.btnCucina.Click += new System.EventHandler(this.btnCucina_Click_1);
            // 
            // salotto
            // 
            this.salotto.AutoSize = true;
            this.salotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salotto.Location = new System.Drawing.Point(32, 350);
            this.salotto.Name = "salotto";
            this.salotto.Size = new System.Drawing.Size(129, 29);
            this.salotto.TabIndex = 13;
            this.salotto.Text = "SALOTTO";
            // 
            // cucina
            // 
            this.cucina.AutoSize = true;
            this.cucina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cucina.Location = new System.Drawing.Point(32, 305);
            this.cucina.Name = "cucina";
            this.cucina.Size = new System.Drawing.Size(108, 29);
            this.cucina.TabIndex = 15;
            this.cucina.Text = "CUCINA";
            // 
            // btnSalotto
            // 
            this.btnSalotto.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalotto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalotto.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalotto.Location = new System.Drawing.Point(276, 341);
            this.btnSalotto.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalotto.Name = "btnSalotto";
            this.btnSalotto.Size = new System.Drawing.Size(100, 38);
            this.btnSalotto.TabIndex = 14;
            this.btnSalotto.Text = "OFF";
            this.btnSalotto.UseVisualStyleBackColor = false;
            this.btnSalotto.Click += new System.EventHandler(this.btnSalotto_Click_1);
            // 
            // camera1
            // 
            this.camera1.AutoSize = true;
            this.camera1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camera1.Location = new System.Drawing.Point(32, 395);
            this.camera1.Name = "camera1";
            this.camera1.Size = new System.Drawing.Size(142, 29);
            this.camera1.TabIndex = 17;
            this.camera1.Text = "CAMERA 1";
            // 
            // btnCamera1
            // 
            this.btnCamera1.BackColor = System.Drawing.Color.IndianRed;
            this.btnCamera1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCamera1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamera1.Location = new System.Drawing.Point(276, 386);
            this.btnCamera1.Margin = new System.Windows.Forms.Padding(4);
            this.btnCamera1.Name = "btnCamera1";
            this.btnCamera1.Size = new System.Drawing.Size(100, 38);
            this.btnCamera1.TabIndex = 16;
            this.btnCamera1.Text = "OFF";
            this.btnCamera1.UseVisualStyleBackColor = false;
            this.btnCamera1.Click += new System.EventHandler(this.btnCamera1_Click_1);
            // 
            // camera2
            // 
            this.camera2.AutoSize = true;
            this.camera2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camera2.Location = new System.Drawing.Point(33, 441);
            this.camera2.Name = "camera2";
            this.camera2.Size = new System.Drawing.Size(142, 29);
            this.camera2.TabIndex = 19;
            this.camera2.Text = "CAMERA 2";
            // 
            // btnCamera2
            // 
            this.btnCamera2.BackColor = System.Drawing.Color.IndianRed;
            this.btnCamera2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCamera2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamera2.Location = new System.Drawing.Point(276, 432);
            this.btnCamera2.Margin = new System.Windows.Forms.Padding(4);
            this.btnCamera2.Name = "btnCamera2";
            this.btnCamera2.Size = new System.Drawing.Size(100, 38);
            this.btnCamera2.TabIndex = 18;
            this.btnCamera2.Text = "OFF";
            this.btnCamera2.UseVisualStyleBackColor = false;
            this.btnCamera2.Click += new System.EventHandler(this.btnCamera2_Click_1);
            // 
            // bagno
            // 
            this.bagno.AutoSize = true;
            this.bagno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagno.Location = new System.Drawing.Point(32, 482);
            this.bagno.Name = "bagno";
            this.bagno.Size = new System.Drawing.Size(103, 29);
            this.bagno.TabIndex = 21;
            this.bagno.Text = "BAGNO";
            // 
            // btnBagno
            // 
            this.btnBagno.BackColor = System.Drawing.Color.IndianRed;
            this.btnBagno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBagno.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBagno.Location = new System.Drawing.Point(276, 478);
            this.btnBagno.Margin = new System.Windows.Forms.Padding(4);
            this.btnBagno.Name = "btnBagno";
            this.btnBagno.Size = new System.Drawing.Size(100, 38);
            this.btnBagno.TabIndex = 20;
            this.btnBagno.Text = "OFF";
            this.btnBagno.UseVisualStyleBackColor = false;
            this.btnBagno.Click += new System.EventHandler(this.btnBagno_Click);
            // 
            // wc
            // 
            this.wc.AutoSize = true;
            this.wc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wc.Location = new System.Drawing.Point(32, 526);
            this.wc.Name = "wc";
            this.wc.Size = new System.Drawing.Size(55, 29);
            this.wc.TabIndex = 23;
            this.wc.Text = "WC";
            // 
            // btnWc
            // 
            this.btnWc.BackColor = System.Drawing.Color.IndianRed;
            this.btnWc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWc.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWc.Location = new System.Drawing.Point(276, 524);
            this.btnWc.Margin = new System.Windows.Forms.Padding(4);
            this.btnWc.Name = "btnWc";
            this.btnWc.Size = new System.Drawing.Size(100, 38);
            this.btnWc.TabIndex = 22;
            this.btnWc.Text = "OFF";
            this.btnWc.UseVisualStyleBackColor = false;
            this.btnWc.Click += new System.EventHandler(this.btnWc_Click);
            // 
            // lavanderia
            // 
            this.lavanderia.AutoSize = true;
            this.lavanderia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lavanderia.Location = new System.Drawing.Point(32, 572);
            this.lavanderia.Name = "lavanderia";
            this.lavanderia.Size = new System.Drawing.Size(172, 29);
            this.lavanderia.TabIndex = 25;
            this.lavanderia.Text = "LAVANDERIA";
            // 
            // btnLavanderia
            // 
            this.btnLavanderia.BackColor = System.Drawing.Color.IndianRed;
            this.btnLavanderia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLavanderia.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLavanderia.Location = new System.Drawing.Point(276, 570);
            this.btnLavanderia.Margin = new System.Windows.Forms.Padding(4);
            this.btnLavanderia.Name = "btnLavanderia";
            this.btnLavanderia.Size = new System.Drawing.Size(100, 38);
            this.btnLavanderia.TabIndex = 24;
            this.btnLavanderia.Text = "OFF";
            this.btnLavanderia.UseVisualStyleBackColor = false;
            this.btnLavanderia.Click += new System.EventHandler(this.btnLavanderia_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(513, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 480);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(853, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 368);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(1416, 78);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(389, 370);
            this.panel3.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(1545, 465);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(261, 382);
            this.panel4.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel5.Location = new System.Drawing.Point(1067, 578);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(456, 267);
            this.panel5.TabIndex = 30;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Location = new System.Drawing.Point(685, 730);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(149, 116);
            this.panel6.TabIndex = 31;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Location = new System.Drawing.Point(507, 730);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(163, 116);
            this.panel7.TabIndex = 32;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Location = new System.Drawing.Point(513, 572);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(321, 146);
            this.panel8.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(276, 705);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 34;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCampanello
            // 
            this.btnCampanello.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCampanello.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCampanello.Location = new System.Drawing.Point(276, 650);
            this.btnCampanello.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCampanello.Name = "btnCampanello";
            this.btnCampanello.Size = new System.Drawing.Size(100, 39);
            this.btnCampanello.TabIndex = 35;
            this.btnCampanello.Text = "SUONA";
            this.btnCampanello.UseVisualStyleBackColor = true;
            this.btnCampanello.Click += new System.EventHandler(this.btnCampanello_Click);
            // 
            // btnPorta
            // 
            this.btnPorta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPorta.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorta.Location = new System.Drawing.Point(276, 713);
            this.btnPorta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPorta.Name = "btnPorta";
            this.btnPorta.Size = new System.Drawing.Size(100, 39);
            this.btnPorta.TabIndex = 36;
            this.btnPorta.Text = "APRI";
            this.btnPorta.UseVisualStyleBackColor = true;
            this.btnPorta.Click += new System.EventHandler(this.btnPorta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 660);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "CAMPANELLO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 722);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 38;
            this.label2.Text = "PORTA";
            // 
            // lblAllarme
            // 
            this.lblAllarme.AutoSize = true;
            this.lblAllarme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllarme.Location = new System.Drawing.Point(32, 785);
            this.lblAllarme.Name = "lblAllarme";
            this.lblAllarme.Size = new System.Drawing.Size(131, 29);
            this.lblAllarme.TabIndex = 39;
            this.lblAllarme.Text = "ALLARME";
            // 
            // btnAllarme
            // 
            this.btnAllarme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllarme.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllarme.Location = new System.Drawing.Point(276, 775);
            this.btnAllarme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAllarme.Name = "btnAllarme";
            this.btnAllarme.Size = new System.Drawing.Size(100, 39);
            this.btnAllarme.TabIndex = 40;
            this.btnAllarme.Text = "ATTIVA";
            this.btnAllarme.UseVisualStyleBackColor = true;
            this.btnAllarme.Click += new System.EventHandler(this.btnAllarme_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(32, 174);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(73, 32);
            this.lblTemp.TabIndex = 41;
            this.lblTemp.Text = "TMP";
            // 
            // lblUmidita
            // 
            this.lblUmidita.AutoSize = true;
            this.lblUmidita.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUmidita.Location = new System.Drawing.Point(32, 208);
            this.lblUmidita.Name = "lblUmidita";
            this.lblUmidita.Size = new System.Drawing.Size(57, 32);
            this.lblUmidita.TabIndex = 42;
            this.lblUmidita.Text = "UM";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Location = new System.Drawing.Point(536, 718);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(99, 15);
            this.panel10.TabIndex = 43;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel11.Location = new System.Drawing.Point(827, 78);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(35, 290);
            this.panel11.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 902);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 45;
            this.label3.Text = "SERIALE";
            // 
            // textBoxSeriale
            // 
            this.textBoxSeriale.Location = new System.Drawing.Point(293, 902);
            this.textBoxSeriale.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSeriale.Name = "textBoxSeriale";
            this.textBoxSeriale.Size = new System.Drawing.Size(99, 22);
            this.textBoxSeriale.TabIndex = 46;
            // 
            // btnSeriale
            // 
            this.btnSeriale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeriale.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeriale.Location = new System.Drawing.Point(293, 933);
            this.btnSeriale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeriale.Name = "btnSeriale";
            this.btnSeriale.Size = new System.Drawing.Size(100, 39);
            this.btnSeriale.TabIndex = 47;
            this.btnSeriale.Text = "INVIA";
            this.btnSeriale.UseVisualStyleBackColor = true;
            this.btnSeriale.Click += new System.EventHandler(this.btnSeriale_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFoto.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoto.Location = new System.Drawing.Point(276, 841);
            this.btnFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(100, 39);
            this.btnFoto.TabIndex = 49;
            this.btnFoto.Text = "ATTIVA";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 850);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 29);
            this.label4.TabIndex = 48;
            this.label4.Text = "FOTODIODO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 974);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSeriale);
            this.Controls.Add(this.textBoxSeriale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.lblUmidita);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.btnAllarme);
            this.Controls.Add(this.lblAllarme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPorta);
            this.Controls.Add(this.btnCampanello);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lavanderia);
            this.Controls.Add(this.btnLavanderia);
            this.Controls.Add(this.wc);
            this.Controls.Add(this.btnWc);
            this.Controls.Add(this.bagno);
            this.Controls.Add(this.btnBagno);
            this.Controls.Add(this.camera2);
            this.Controls.Add(this.btnCamera2);
            this.Controls.Add(this.camera1);
            this.Controls.Add(this.btnCamera1);
            this.Controls.Add(this.cucina);
            this.Controls.Add(this.btnSalotto);
            this.Controls.Add(this.salotto);
            this.Controls.Add(this.btnCucina);
            this.Controls.Add(this.Weather);
            this.Controls.Add(this.ora);
            this.Controls.Add(this.data);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "CASA DOMOTICA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label ora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Weather;
        private System.Windows.Forms.Button btnCucina;
        private System.Windows.Forms.Label salotto;
        private System.Windows.Forms.Label cucina;
        private System.Windows.Forms.Button btnSalotto;
        private System.Windows.Forms.Label camera1;
        private System.Windows.Forms.Button btnCamera1;
        private System.Windows.Forms.Label camera2;
        private System.Windows.Forms.Button btnCamera2;
        private System.Windows.Forms.Label bagno;
        private System.Windows.Forms.Button btnBagno;
        private System.Windows.Forms.Label wc;
        private System.Windows.Forms.Button btnWc;
        private System.Windows.Forms.Label lavanderia;
        private System.Windows.Forms.Button btnLavanderia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPorta;
        private System.Windows.Forms.Button btnCampanello;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAllarme;
        private System.Windows.Forms.Button btnAllarme;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblUmidita;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSeriale;
        private System.Windows.Forms.Button btnSeriale;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Label label4;
        private object button8;
    }
}

