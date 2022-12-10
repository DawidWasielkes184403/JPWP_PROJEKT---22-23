using System.Windows.Forms;

namespace PrawoJazdy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LicznikRuchu = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Ile = new System.Windows.Forms.Label();
            this.Stoperek = new System.Windows.Forms.Label();
            this.Sam1Ruch = new System.Windows.Forms.Timer(this.components);
            this.Czas = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.meta = new System.Windows.Forms.PictureBox();
            this.Kierowca = new System.Windows.Forms.PictureBox();
            this.Sam1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kierowca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // LicznikRuchu
            // 
            this.LicznikRuchu.Enabled = true;
            this.LicznikRuchu.Interval = 20;
            this.LicznikRuchu.Tick += new System.EventHandler(this.ruszanie);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.meta);
            this.panel1.Controls.Add(this.Kierowca);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.Sam1);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 552);
            this.panel1.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Green;
            this.panel5.Location = new System.Drawing.Point(581, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(378, 204);
            this.panel5.TabIndex = 16;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(581, 272);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(376, 17);
            this.panel10.TabIndex = 14;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(0, 272);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(383, 17);
            this.panel9.TabIndex = 13;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(471, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(14, 200);
            this.panel8.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(471, 359);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(14, 193);
            this.panel7.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Location = new System.Drawing.Point(581, 359);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(376, 192);
            this.panel6.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 201);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Location = new System.Drawing.Point(3, 359);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 193);
            this.panel4.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.Ile);
            this.panel2.Controls.Add(this.Stoperek);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(957, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 551);
            this.panel2.TabIndex = 6;
            // 
            // Ile
            // 
            this.Ile.AutoSize = true;
            this.Ile.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ile.Location = new System.Drawing.Point(11, 241);
            this.Ile.Name = "Ile";
            this.Ile.Size = new System.Drawing.Size(175, 48);
            this.Ile.TabIndex = 4;
            this.Ile.Text = "Próby: 0";
            // 
            // Stoperek
            // 
            this.Stoperek.AutoSize = true;
            this.Stoperek.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Stoperek.Location = new System.Drawing.Point(11, 319);
            this.Stoperek.Name = "Stoperek";
            this.Stoperek.Size = new System.Drawing.Size(171, 48);
            this.Stoperek.TabIndex = 3;
            this.Stoperek.Text = "Czas:    ";
            // 
            // Sam1Ruch
            // 
            this.Sam1Ruch.Enabled = true;
            this.Sam1Ruch.Interval = 20;
            this.Sam1Ruch.Tick += new System.EventHandler(this.Sam1_ster);
            // 
            // Czas
            // 
            this.Czas.Enabled = true;
            this.Czas.Interval = 10;
            this.Czas.Tick += new System.EventHandler(this.CzasMierz);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PrawoJazdy.Properties.Resources.p3;
            this.pictureBox3.Location = new System.Drawing.Point(52, 152);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(119, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PrawoJazdy.Properties.Resources.p2;
            this.pictureBox2.Location = new System.Drawing.Point(52, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrawoJazdy.Properties.Resources.p1;
            this.pictureBox1.Location = new System.Drawing.Point(52, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // meta
            // 
            this.meta.BackColor = System.Drawing.Color.Gold;
            this.meta.Location = new System.Drawing.Point(522, 11);
            this.meta.Name = "meta";
            this.meta.Size = new System.Drawing.Size(24, 21);
            this.meta.TabIndex = 18;
            this.meta.TabStop = false;
            // 
            // Kierowca
            // 
            this.Kierowca.BackColor = System.Drawing.Color.Red;
            this.Kierowca.Location = new System.Drawing.Point(510, 480);
            this.Kierowca.Name = "Kierowca";
            this.Kierowca.Size = new System.Drawing.Size(50, 50);
            this.Kierowca.TabIndex = 17;
            this.Kierowca.TabStop = false;
            this.Kierowca.Click += new System.EventHandler(this.Kierowca_Click);
            // 
            // Sam1
            // 
            this.Sam1.BackColor = System.Drawing.Color.Blue;
            this.Sam1.Location = new System.Drawing.Point(778, 210);
            this.Sam1.Name = "Sam1";
            this.Sam1.Size = new System.Drawing.Size(50, 50);
            this.Sam1.TabIndex = 15;
            this.Sam1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PrawoJazdy.Properties.Resources.menu;
            this.pictureBox4.Location = new System.Drawing.Point(36, 414);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 68);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kierowca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer LicznikRuchu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Sam1;
        private Panel panel5;
        private PictureBox Kierowca;
        private Timer Sam1Ruch;
        private Timer Czas;
        private Label Stoperek;
        private Label Ile;
        private PictureBox meta;
        private PictureBox pictureBox4;
    }
}

