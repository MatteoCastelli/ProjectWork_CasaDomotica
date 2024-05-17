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
            this.button2 = new System.Windows.Forms.Button();
            this.salotto = new System.Windows.Forms.Label();
            this.cucina = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.camera1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.camera2 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.bagno = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.wc = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.lavanderia = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
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
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.Location = new System.Drawing.Point(24, 58);
            this.data.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(54, 26);
            this.data.TabIndex = 0;
            this.data.Text = "data";
            // 
            // ora
            // 
            this.ora.AutoSize = true;
            this.ora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ora.Location = new System.Drawing.Point(24, 86);
            this.ora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ora.Name = "ora";
            this.ora.Size = new System.Drawing.Size(43, 26);
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
            this.Weather.Location = new System.Drawing.Point(24, 114);
            this.Weather.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Weather.Name = "Weather";
            this.Weather.Size = new System.Drawing.Size(94, 26);
            this.Weather.TabIndex = 2;
            this.Weather.Text = "Weather";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(220, 244);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "OFF";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // salotto
            // 
            this.salotto.AutoSize = true;
            this.salotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salotto.Location = new System.Drawing.Point(24, 284);
            this.salotto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.salotto.Name = "salotto";
            this.salotto.Size = new System.Drawing.Size(109, 25);
            this.salotto.TabIndex = 13;
            this.salotto.Text = "SALOTTO";
            // 
            // cucina
            // 
            this.cucina.AutoSize = true;
            this.cucina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cucina.Location = new System.Drawing.Point(24, 248);
            this.cucina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cucina.Name = "cucina";
            this.cucina.Size = new System.Drawing.Size(89, 25);
            this.cucina.TabIndex = 15;
            this.cucina.Text = "CUCINA";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.IndianRed;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(220, 280);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 32);
            this.button8.TabIndex = 14;
            this.button8.Text = "OFF";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // camera1
            // 
            this.camera1.AutoSize = true;
            this.camera1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camera1.Location = new System.Drawing.Point(24, 321);
            this.camera1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.camera1.Name = "camera1";
            this.camera1.Size = new System.Drawing.Size(114, 25);
            this.camera1.TabIndex = 17;
            this.camera1.Text = "CAMERA 1";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.IndianRed;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(220, 317);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 32);
            this.button9.TabIndex = 16;
            this.button9.Text = "OFF";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // camera2
            // 
            this.camera2.AutoSize = true;
            this.camera2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camera2.Location = new System.Drawing.Point(24, 358);
            this.camera2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.camera2.Name = "camera2";
            this.camera2.Size = new System.Drawing.Size(114, 25);
            this.camera2.TabIndex = 19;
            this.camera2.Text = "CAMERA 2";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.IndianRed;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(220, 353);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 32);
            this.button10.TabIndex = 18;
            this.button10.Text = "OFF";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // bagno
            // 
            this.bagno.AutoSize = true;
            this.bagno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagno.Location = new System.Drawing.Point(24, 392);
            this.bagno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bagno.Name = "bagno";
            this.bagno.Size = new System.Drawing.Size(84, 25);
            this.bagno.TabIndex = 21;
            this.bagno.Text = "BAGNO";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.IndianRed;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(220, 388);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 32);
            this.button11.TabIndex = 20;
            this.button11.Text = "OFF";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // wc
            // 
            this.wc.AutoSize = true;
            this.wc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wc.Location = new System.Drawing.Point(24, 428);
            this.wc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wc.Name = "wc";
            this.wc.Size = new System.Drawing.Size(47, 25);
            this.wc.TabIndex = 23;
            this.wc.Text = "WC";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.IndianRed;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(220, 424);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 32);
            this.button12.TabIndex = 22;
            this.button12.Text = "OFF";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // lavanderia
            // 
            this.lavanderia.AutoSize = true;
            this.lavanderia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lavanderia.Location = new System.Drawing.Point(24, 465);
            this.lavanderia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lavanderia.Name = "lavanderia";
            this.lavanderia.Size = new System.Drawing.Size(138, 25);
            this.lavanderia.TabIndex = 25;
            this.lavanderia.Text = "LAVANDERIA";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.IndianRed;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(220, 461);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 32);
            this.button13.TabIndex = 24;
            this.button13.Text = "OFF";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(385, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 390);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(640, 63);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 299);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(1062, 63);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 301);
            this.panel3.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(1159, 378);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(196, 310);
            this.panel4.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel5.Location = new System.Drawing.Point(800, 470);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(342, 217);
            this.panel5.TabIndex = 30;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Location = new System.Drawing.Point(514, 593);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(112, 94);
            this.panel6.TabIndex = 31;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Location = new System.Drawing.Point(380, 593);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(122, 94);
            this.panel7.TabIndex = 32;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(385, 465);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(241, 119);
            this.panel8.TabIndex = 33;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Location = new System.Drawing.Point(15, 122);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(70, 8);
            this.panel9.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(220, 577);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnCampanello.Location = new System.Drawing.Point(220, 532);
            this.btnCampanello.Margin = new System.Windows.Forms.Padding(2);
            this.btnCampanello.Name = "btnCampanello";
            this.btnCampanello.Size = new System.Drawing.Size(75, 32);
            this.btnCampanello.TabIndex = 35;
            this.btnCampanello.Text = "SUONA";
            this.btnCampanello.UseVisualStyleBackColor = true;
            this.btnCampanello.Click += new System.EventHandler(this.btnCampanello_Click);
            // 
            // btnPorta
            // 
            this.btnPorta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPorta.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorta.Location = new System.Drawing.Point(220, 583);
            this.btnPorta.Margin = new System.Windows.Forms.Padding(2);
            this.btnPorta.Name = "btnPorta";
            this.btnPorta.Size = new System.Drawing.Size(75, 32);
            this.btnPorta.TabIndex = 36;
            this.btnPorta.Text = "APRI";
            this.btnPorta.UseVisualStyleBackColor = true;
            this.btnPorta.Click += new System.EventHandler(this.btnPorta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 536);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "CAMPANELLO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 587);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "PORTA";
            // 
            // lblAllarme
            // 
            this.lblAllarme.AutoSize = true;
            this.lblAllarme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllarme.Location = new System.Drawing.Point(24, 638);
            this.lblAllarme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllarme.Name = "lblAllarme";
            this.lblAllarme.Size = new System.Drawing.Size(105, 25);
            this.lblAllarme.TabIndex = 39;
            this.lblAllarme.Text = "ALLARME";
            // 
            // btnAllarme
            // 
            this.btnAllarme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllarme.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllarme.Location = new System.Drawing.Point(220, 634);
            this.btnAllarme.Margin = new System.Windows.Forms.Padding(2);
            this.btnAllarme.Name = "btnAllarme";
            this.btnAllarme.Size = new System.Drawing.Size(75, 32);
            this.btnAllarme.TabIndex = 40;
            this.btnAllarme.Text = "ATTIVA";
            this.btnAllarme.UseVisualStyleBackColor = true;
            this.btnAllarme.Click += new System.EventHandler(this.btnAllarme_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(24, 141);
            this.lblTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(57, 26);
            this.lblTemp.TabIndex = 41;
            this.lblTemp.Text = "TMP";
            // 
            // lblUmidita
            // 
            this.lblUmidita.AutoSize = true;
            this.lblUmidita.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUmidita.Location = new System.Drawing.Point(24, 169);
            this.lblUmidita.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUmidita.Name = "lblUmidita";
            this.lblUmidita.Size = new System.Drawing.Size(46, 26);
            this.lblUmidita.TabIndex = 42;
            this.lblUmidita.Text = "UM";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Location = new System.Drawing.Point(402, 583);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(74, 12);
            this.panel10.TabIndex = 43;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel11.Location = new System.Drawing.Point(620, 63);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(26, 236);
            this.panel11.TabIndex = 44;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 733);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "SERIALE";
            // 
            // textBoxSeriale
            // 
            this.textBoxSeriale.Location = new System.Drawing.Point(220, 733);
            this.textBoxSeriale.Name = "textBoxSeriale";
            this.textBoxSeriale.Size = new System.Drawing.Size(75, 20);
            this.textBoxSeriale.TabIndex = 46;
            // 
            // btnSeriale
            // 
            this.btnSeriale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeriale.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeriale.Location = new System.Drawing.Point(220, 758);
            this.btnSeriale.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeriale.Name = "btnSeriale";
            this.btnSeriale.Size = new System.Drawing.Size(75, 32);
            this.btnSeriale.TabIndex = 47;
            this.btnSeriale.Text = "INVIA";
            this.btnSeriale.UseVisualStyleBackColor = true;
            this.btnSeriale.Click += new System.EventHandler(this.btnSeriale_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFoto.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoto.Location = new System.Drawing.Point(220, 687);
            this.btnFoto.Margin = new System.Windows.Forms.Padding(2);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(75, 32);
            this.btnFoto.TabIndex = 49;
            this.btnFoto.Text = "ATTIVA";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 691);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "FOTODIODO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1533, 791);
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
            this.Controls.Add(this.button13);
            this.Controls.Add(this.wc);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.bagno);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.camera2);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.camera1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.cucina);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.salotto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Weather);
            this.Controls.Add(this.ora);
            this.Controls.Add(this.data);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "CASA DOMOTICA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label ora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Weather;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label salotto;
        private System.Windows.Forms.Label cucina;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label camera1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label camera2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label bagno;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label wc;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label lavanderia;
        private System.Windows.Forms.Button button13;
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
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblUmidita;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSeriale;
        private System.Windows.Forms.Button btnSeriale;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Label label4;
    }
}

