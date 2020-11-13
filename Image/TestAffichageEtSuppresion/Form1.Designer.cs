namespace TestAffichageEtSuppresion
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.ChoisirCouleur1 = new System.Windows.Forms.Button();
            this.ChoisirCouleur2 = new System.Windows.Forms.Button();
            this.Couleur1 = new System.Windows.Forms.PictureBox();
            this.Couleur2 = new System.Windows.Forms.PictureBox();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ResetImage = new System.Windows.Forms.Button();
            this.rotate = new System.Windows.Forms.Button();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.ModifieCouleurEnFonctionDuCHoix = new System.Windows.Forms.Button();
            this.ModifieCouleurEnFonctionFauge = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listeFichier = new System.Windows.Forms.Label();
            this.MettreEnGris = new System.Windows.Forms.Button();
            this.ImageActuelle = new System.Windows.Forms.CheckBox();
            this.Boucle = new System.Windows.Forms.CheckBox();
            this.rotate90 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.START = new System.Windows.Forms.Button();
            this.STOP = new System.Windows.Forms.Button();
            this.degreeRotate = new System.Windows.Forms.TextBox();
            this.Modulate = new System.Windows.Forms.Button();
            this.flipButton = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.button60 = new System.Windows.Forms.Button();
            this.button70 = new System.Windows.Forms.Button();
            this.button80 = new System.Windows.Forms.Button();
            this.transparance = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Couleur1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Couleur2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(89, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(612, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(89, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "FliperLeDofin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Location = new System.Drawing.Point(152, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Fermer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "i = 0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(728, 92);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(161, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 1;
            this.trackBar2.Location = new System.Drawing.Point(728, 143);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(161, 45);
            this.trackBar2.TabIndex = 5;
            // 
            // trackBar3
            // 
            this.trackBar3.LargeChange = 1;
            this.trackBar3.Location = new System.Drawing.Point(728, 41);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(161, 45);
            this.trackBar3.TabIndex = 6;
            // 
            // trackBar4
            // 
            this.trackBar4.LargeChange = 1;
            this.trackBar4.Location = new System.Drawing.Point(728, 209);
            this.trackBar4.Maximum = 255;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(161, 45);
            this.trackBar4.TabIndex = 7;
            // 
            // trackBar5
            // 
            this.trackBar5.LargeChange = 1;
            this.trackBar5.Location = new System.Drawing.Point(728, 260);
            this.trackBar5.Maximum = 255;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(161, 45);
            this.trackBar5.TabIndex = 8;
            // 
            // trackBar6
            // 
            this.trackBar6.LargeChange = 1;
            this.trackBar6.Location = new System.Drawing.Point(728, 311);
            this.trackBar6.Maximum = 255;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(161, 45);
            this.trackBar6.TabIndex = 9;
            // 
            // ChoisirCouleur1
            // 
            this.ChoisirCouleur1.Location = new System.Drawing.Point(773, 378);
            this.ChoisirCouleur1.Name = "ChoisirCouleur1";
            this.ChoisirCouleur1.Size = new System.Drawing.Size(91, 34);
            this.ChoisirCouleur1.TabIndex = 10;
            this.ChoisirCouleur1.Text = "ChoisirCouleur1";
            this.ChoisirCouleur1.UseVisualStyleBackColor = true;
            this.ChoisirCouleur1.Click += new System.EventHandler(this.ChoisirCouleur1_Click);
            // 
            // ChoisirCouleur2
            // 
            this.ChoisirCouleur2.Location = new System.Drawing.Point(773, 428);
            this.ChoisirCouleur2.Name = "ChoisirCouleur2";
            this.ChoisirCouleur2.Size = new System.Drawing.Size(91, 39);
            this.ChoisirCouleur2.TabIndex = 11;
            this.ChoisirCouleur2.Text = "ChoisirCouleur2";
            this.ChoisirCouleur2.UseVisualStyleBackColor = true;
            this.ChoisirCouleur2.Click += new System.EventHandler(this.ChoisirCouleur2_Click);
            // 
            // Couleur1
            // 
            this.Couleur1.Location = new System.Drawing.Point(735, 382);
            this.Couleur1.Name = "Couleur1";
            this.Couleur1.Size = new System.Drawing.Size(29, 29);
            this.Couleur1.TabIndex = 12;
            this.Couleur1.TabStop = false;
            // 
            // Couleur2
            // 
            this.Couleur2.Location = new System.Drawing.Point(735, 428);
            this.Couleur2.Name = "Couleur2";
            this.Couleur2.Size = new System.Drawing.Size(29, 29);
            this.Couleur2.TabIndex = 13;
            this.Couleur2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(870, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(870, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(870, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 16;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ResetImage
            // 
            this.ResetImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResetImage.BackgroundImage")));
            this.ResetImage.Location = new System.Drawing.Point(90, 425);
            this.ResetImage.Name = "ResetImage";
            this.ResetImage.Size = new System.Drawing.Size(204, 41);
            this.ResetImage.TabIndex = 17;
            this.ResetImage.Text = "ResetImage";
            this.ResetImage.UseVisualStyleBackColor = true;
            this.ResetImage.Click += new System.EventHandler(this.ResetImage_Click);
            // 
            // rotate
            // 
            this.rotate.Location = new System.Drawing.Point(467, 363);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(75, 23);
            this.rotate.TabIndex = 19;
            this.rotate.Text = "rotate";
            this.rotate.UseVisualStyleBackColor = true;
            this.rotate.Click += new System.EventHandler(this.rotate_Click);
            // 
            // trackBar7
            // 
            this.trackBar7.LargeChange = 1;
            this.trackBar7.Location = new System.Drawing.Point(435, 326);
            this.trackBar7.Maximum = 360;
            this.trackBar7.Minimum = -360;
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Size = new System.Drawing.Size(141, 45);
            this.trackBar7.TabIndex = 20;
            // 
            // ModifieCouleurEnFonctionDuCHoix
            // 
            this.ModifieCouleurEnFonctionDuCHoix.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ModifieCouleurEnFonctionDuCHoix.Location = new System.Drawing.Point(642, 389);
            this.ModifieCouleurEnFonctionDuCHoix.Name = "ModifieCouleurEnFonctionDuCHoix";
            this.ModifieCouleurEnFonctionDuCHoix.Size = new System.Drawing.Size(75, 52);
            this.ModifieCouleurEnFonctionDuCHoix.TabIndex = 21;
            this.ModifieCouleurEnFonctionDuCHoix.Text = "ModifieCouleurEnFonctionDuCHoix";
            this.ModifieCouleurEnFonctionDuCHoix.UseVisualStyleBackColor = false;
            this.ModifieCouleurEnFonctionDuCHoix.Click += new System.EventHandler(this.ModifieCouleurEnFonctionDuCHoix_Click);
            // 
            // ModifieCouleurEnFonctionFauge
            // 
            this.ModifieCouleurEnFonctionFauge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ModifieCouleurEnFonctionFauge.Location = new System.Drawing.Point(917, 41);
            this.ModifieCouleurEnFonctionFauge.Name = "ModifieCouleurEnFonctionFauge";
            this.ModifieCouleurEnFonctionFauge.Size = new System.Drawing.Size(48, 305);
            this.ModifieCouleurEnFonctionFauge.TabIndex = 22;
            this.ModifieCouleurEnFonctionFauge.Text = "ModifieCouleurEnFonctionFauge";
            this.ModifieCouleurEnFonctionFauge.UseVisualStyleBackColor = false;
            this.ModifieCouleurEnFonctionFauge.Click += new System.EventHandler(this.ModifieCouleurEnFonctionFauge_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(870, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 23;
            // 
            // listeFichier
            // 
            this.listeFichier.AutoSize = true;
            this.listeFichier.Location = new System.Drawing.Point(28, 441);
            this.listeFichier.Name = "listeFichier";
            this.listeFichier.Size = new System.Drawing.Size(56, 13);
            this.listeFichier.TabIndex = 24;
            this.listeFichier.Text = "listeFichier";
            // 
            // MettreEnGris
            // 
            this.MettreEnGris.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MettreEnGris.Location = new System.Drawing.Point(332, 363);
            this.MettreEnGris.Name = "MettreEnGris";
            this.MettreEnGris.Size = new System.Drawing.Size(87, 23);
            this.MettreEnGris.TabIndex = 25;
            this.MettreEnGris.Text = "MettreEnGris";
            this.MettreEnGris.UseVisualStyleBackColor = false;
            this.MettreEnGris.Click += new System.EventHandler(this.MettreEnGris_Click);
            // 
            // ImageActuelle
            // 
            this.ImageActuelle.AutoSize = true;
            this.ImageActuelle.Location = new System.Drawing.Point(12, 315);
            this.ImageActuelle.Name = "ImageActuelle";
            this.ImageActuelle.Size = new System.Drawing.Size(93, 17);
            this.ImageActuelle.TabIndex = 26;
            this.ImageActuelle.Text = "ImageActuelle";
            this.ImageActuelle.UseVisualStyleBackColor = true;
            // 
            // Boucle
            // 
            this.Boucle.Appearance = System.Windows.Forms.Appearance.Button;
            this.Boucle.AutoSize = true;
            this.Boucle.BackColor = System.Drawing.Color.Gold;
            this.Boucle.Location = new System.Drawing.Point(381, 474);
            this.Boucle.Name = "Boucle";
            this.Boucle.Size = new System.Drawing.Size(50, 23);
            this.Boucle.TabIndex = 27;
            this.Boucle.Text = "Boucle";
            this.Boucle.UseVisualStyleBackColor = false;
            this.Boucle.CheckedChanged += new System.EventHandler(this.Boucle_CheckedChanged);
            // 
            // rotate90
            // 
            this.rotate90.Location = new System.Drawing.Point(467, 404);
            this.rotate90.Name = "rotate90";
            this.rotate90.Size = new System.Drawing.Size(75, 23);
            this.rotate90.TabIndex = 28;
            this.rotate90.Text = "rotate90";
            this.rotate90.UseVisualStyleBackColor = true;
            this.rotate90.Click += new System.EventHandler(this.rotate90_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(467, 486);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 30;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // START
            // 
            this.START.BackColor = System.Drawing.Color.Lime;
            this.START.Location = new System.Drawing.Point(444, 531);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(75, 23);
            this.START.TabIndex = 31;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = false;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // STOP
            // 
            this.STOP.BackColor = System.Drawing.Color.Red;
            this.STOP.Location = new System.Drawing.Point(525, 531);
            this.STOP.Name = "STOP";
            this.STOP.Size = new System.Drawing.Size(75, 23);
            this.STOP.TabIndex = 32;
            this.STOP.Text = "STOP";
            this.STOP.UseVisualStyleBackColor = false;
            this.STOP.Click += new System.EventHandler(this.STOP_Click);
            // 
            // degreeRotate
            // 
            this.degreeRotate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.degreeRotate.Cursor = System.Windows.Forms.Cursors.Cross;
            this.degreeRotate.Location = new System.Drawing.Point(331, 531);
            this.degreeRotate.Name = "degreeRotate";
            this.degreeRotate.Size = new System.Drawing.Size(100, 20);
            this.degreeRotate.TabIndex = 33;
            // 
            // Modulate
            // 
            this.Modulate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Modulate.Location = new System.Drawing.Point(339, 412);
            this.Modulate.Name = "Modulate";
            this.Modulate.Size = new System.Drawing.Size(75, 23);
            this.Modulate.TabIndex = 34;
            this.Modulate.Text = "Modulate";
            this.Modulate.UseVisualStyleBackColor = false;
            this.Modulate.Click += new System.EventHandler(this.Modulate_Click);
            // 
            // flipButton
            // 
            this.flipButton.Location = new System.Drawing.Point(1000, 11);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(94, 33);
            this.flipButton.TabIndex = 1;
            this.flipButton.Text = "Flip";
            this.flipButton.UseVisualStyleBackColor = true;
            this.flipButton.Click += new System.EventHandler(this.flip_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1000, 123);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(94, 33);
            this.button10.TabIndex = 2;
            this.button10.Text = "ChopH";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.chopH_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(1000, 178);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(94, 33);
            this.button20.TabIndex = 3;
            this.button20.Text = "Edge";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.edge_Click);
            // 
            // button40
            // 
            this.button40.Location = new System.Drawing.Point(1000, 233);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(94, 33);
            this.button40.TabIndex = 5;
            this.button40.Text = "Extent";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.extent_Click);
            // 
            // button50
            // 
            this.button50.Location = new System.Drawing.Point(1000, 67);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(94, 33);
            this.button50.TabIndex = 6;
            this.button50.Text = "Flop";
            this.button50.UseVisualStyleBackColor = true;
            this.button50.Click += new System.EventHandler(this.flop_Click);
            // 
            // button60
            // 
            this.button60.Location = new System.Drawing.Point(1000, 287);
            this.button60.Name = "button60";
            this.button60.Size = new System.Drawing.Size(94, 33);
            this.button60.TabIndex = 7;
            this.button60.Text = "HoughLine";
            this.button60.UseVisualStyleBackColor = true;
            this.button60.Click += new System.EventHandler(this.houghLine_Click);
            // 
            // button70
            // 
            this.button70.Location = new System.Drawing.Point(1000, 341);
            this.button70.Name = "button70";
            this.button70.Size = new System.Drawing.Size(94, 33);
            this.button70.TabIndex = 8;
            this.button70.Text = "Negate";
            this.button70.UseVisualStyleBackColor = true;
            this.button70.Click += new System.EventHandler(this.negate_Click);
            // 
            // button80
            // 
            this.button80.Location = new System.Drawing.Point(1000, 395);
            this.button80.Name = "button80";
            this.button80.Size = new System.Drawing.Size(94, 33);
            this.button80.TabIndex = 9;
            this.button80.Text = "Opaque";
            this.button80.UseVisualStyleBackColor = true;
            this.button80.Click += new System.EventHandler(this.opaque_Click);
            // 
            // transparance
            // 
            this.transparance.Location = new System.Drawing.Point(1000, 453);
            this.transparance.Name = "transparance";
            this.transparance.Size = new System.Drawing.Size(94, 30);
            this.transparance.TabIndex = 35;
            this.transparance.Text = "transparance";
            this.transparance.UseVisualStyleBackColor = true;
            this.transparance.Click += new System.EventHandler(this.transparance_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(894, 459);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 36;
            this.textBox2.Text = "-";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(886, 497);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 21);
            this.comboBox1.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(964, 531);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 566);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.transparance);
            this.Controls.Add(this.Modulate);
            this.Controls.Add(this.degreeRotate);
            this.Controls.Add(this.STOP);
            this.Controls.Add(this.START);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rotate90);
            this.Controls.Add(this.Boucle);
            this.Controls.Add(this.ImageActuelle);
            this.Controls.Add(this.MettreEnGris);
            this.Controls.Add(this.listeFichier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ModifieCouleurEnFonctionFauge);
            this.Controls.Add(this.ModifieCouleurEnFonctionDuCHoix);
            this.Controls.Add(this.rotate);
            this.Controls.Add(this.trackBar7);
            this.Controls.Add(this.ResetImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Couleur2);
            this.Controls.Add(this.Couleur1);
            this.Controls.Add(this.ChoisirCouleur2);
            this.Controls.Add(this.ChoisirCouleur1);
            this.Controls.Add(this.trackBar6);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button80);
            this.Controls.Add(this.button70);
            this.Controls.Add(this.button60);
            this.Controls.Add(this.button50);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.flipButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Couleur1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Couleur2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.Button ChoisirCouleur1;
        private System.Windows.Forms.Button ChoisirCouleur2;
        private System.Windows.Forms.PictureBox Couleur1;
        private System.Windows.Forms.PictureBox Couleur2;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ResetImage;
        private System.Windows.Forms.Button rotate;
        private System.Windows.Forms.TrackBar trackBar7;
        private System.Windows.Forms.Button ModifieCouleurEnFonctionDuCHoix;
        private System.Windows.Forms.Button ModifieCouleurEnFonctionFauge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label listeFichier;
        private System.Windows.Forms.Button MettreEnGris;
        private System.Windows.Forms.CheckBox ImageActuelle;
        private System.Windows.Forms.CheckBox Boucle;
        private System.Windows.Forms.Button rotate90;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Button STOP;
        private System.Windows.Forms.TextBox degreeRotate;
        private System.Windows.Forms.Button Modulate;

        //partie Enzo
        private System.Windows.Forms.Button flipButton;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button50;
        private System.Windows.Forms.Button button60;
        private System.Windows.Forms.Button button70;
        private System.Windows.Forms.Button button80;
        private System.Windows.Forms.Button transparance;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
    }
}

