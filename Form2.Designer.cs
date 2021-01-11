namespace SoundAnimationMaker
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonClose = new System.Windows.Forms.PictureBox();
            this.timer_Son = new System.Windows.Forms.Timer(this.components);
            this.timer_Basse = new System.Windows.Forms.Timer(this.components);
            timer_affichage = new System.Windows.Forms.Timer(this.components);
            timer_gif_explosion = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.Location = new System.Drawing.Point(663, 413);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(125, 25);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.TabStop = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click_1);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            this.buttonClose.MouseHover += new System.EventHandler(this.buttonClose_MouseHover);
            // 
            // timer_Son
            // 
            this.timer_Son.Interval = 500;
            this.timer_Son.Tick += new System.EventHandler(this.timer_Son_Tick);
            // 
            // timer_Basse
            // 
            this.timer_Basse.Enabled = true;
            this.timer_Basse.Interval = 10;
            this.timer_Basse.Tick += new System.EventHandler(this.timer_Basse_Tick);
            // 
            // timer_affichage
            // 
            timer_affichage.Tick += new System.EventHandler(this.timer_affichage_Tick);
            // 
            // timer_gif_explosion
            // 
            timer_gif_explosion.Interval = 2100;
            timer_gif_explosion.Tick += new System.EventHandler(this.timer_gif_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox buttonClose;
        private System.Windows.Forms.Timer timer_Basse;
        public System.Windows.Forms.Timer timer_Son;
        public static System.Windows.Forms.Timer timer_gif_explosion;
        public static System.Windows.Forms.Timer timer_affichage;
    }
}