using System.Drawing;
using System.Windows.Forms;

namespace SoundAnimationMaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.combox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonParametre = new System.Windows.Forms.PictureBox();
            this.buttonParcourir = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.nom = new System.Windows.Forms.PictureBox();
            this.buttonLancer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonParametre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonParcourir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLancer)).BeginInit();
            this.SuspendLayout();
            // 
            // combox
            // 
            this.combox.FormattingEnabled = true;
            this.combox.Location = new System.Drawing.Point(472, 395);
            this.combox.Name = "combox";
            this.combox.Size = new System.Drawing.Size(196, 21);
            this.combox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(463, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(456, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonParametre
            // 
            this.buttonParametre.BackColor = System.Drawing.Color.Transparent;
            this.buttonParametre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonParametre.Image = ((System.Drawing.Image)(resources.GetObject("buttonParametre.Image")));
            this.buttonParametre.Location = new System.Drawing.Point(674, 395);
            this.buttonParametre.Name = "buttonParametre";
            this.buttonParametre.Size = new System.Drawing.Size(125, 25);
            this.buttonParametre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonParametre.TabIndex = 3;
            this.buttonParametre.TabStop = false;
            this.buttonParametre.Click += new System.EventHandler(this.buttonParametre_Click);
            this.buttonParametre.MouseLeave += new System.EventHandler(this.buttonParametre_MouseLeave);
            this.buttonParametre.MouseHover += new System.EventHandler(this.buttonParametre_MouseHover);
            // 
            // buttonParcourir
            // 
            this.buttonParcourir.BackColor = System.Drawing.Color.Transparent;
            this.buttonParcourir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonParcourir.Image = ((System.Drawing.Image)(resources.GetObject("buttonParcourir.Image")));
            this.buttonParcourir.Location = new System.Drawing.Point(803, 329);
            this.buttonParcourir.Name = "buttonParcourir";
            this.buttonParcourir.Size = new System.Drawing.Size(125, 25);
            this.buttonParcourir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonParcourir.TabIndex = 4;
            this.buttonParcourir.TabStop = false;
            this.buttonParcourir.Click += new System.EventHandler(this.buttonParcourir_Click);
            this.buttonParcourir.MouseLeave += new System.EventHandler(this.buttonParcourir_MouseLeave);
            this.buttonParcourir.MouseHover += new System.EventHandler(this.buttonParcourir_MouseHover);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(803, 460);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(125, 25);
            this.buttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonClose.TabIndex = 5;
            this.buttonClose.TabStop = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            this.buttonClose.MouseHover += new System.EventHandler(this.buttonClose_MouseHover);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(174, 159);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            // 
            // nom
            // 
            this.nom.BackColor = System.Drawing.Color.Transparent;
            this.nom.Image = ((System.Drawing.Image)(resources.GetObject("nom.Image")));
            this.nom.Location = new System.Drawing.Point(60, 192);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(328, 254);
            this.nom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nom.TabIndex = 7;
            this.nom.TabStop = false;
            // 
            // buttonLancer
            // 
            this.buttonLancer.BackColor = System.Drawing.Color.Transparent;
            this.buttonLancer.Image = ((System.Drawing.Image)(resources.GetObject("buttonLancer.Image")));
            this.buttonLancer.Location = new System.Drawing.Point(472, 435);
            this.buttonLancer.Name = "buttonLancer";
            this.buttonLancer.Size = new System.Drawing.Size(250, 50);
            this.buttonLancer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonLancer.TabIndex = 8;
            this.buttonLancer.TabStop = false;
            this.buttonLancer.Click += new System.EventHandler(this.buttonLancer_Click);
            this.buttonLancer.MouseLeave += new System.EventHandler(this.buttonLancer_MouseLeave);
            this.buttonLancer.MouseHover += new System.EventHandler(this.buttonLancer_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(469, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Périphérique d\'entré";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLancer);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonParcourir);
            this.Controls.Add(this.buttonParametre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.combox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoundAnimationMaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonParametre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonParcourir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLancer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public ComboBox combox;
        public PictureBox pictureBox1;
        private PictureBox buttonParametre;
        private PictureBox buttonParcourir;
        private PictureBox buttonClose;
        private PictureBox logo;
        private PictureBox nom;
        private PictureBox buttonLancer;
        private Label label1;
    }
}

