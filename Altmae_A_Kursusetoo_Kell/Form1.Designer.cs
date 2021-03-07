namespace Altmae_A_Kursusetoo_Kell
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.backBox = new System.Windows.Forms.PictureBox();
            this.hourBox = new System.Windows.Forms.PictureBox();
            this.minuteBox = new System.Windows.Forms.PictureBox();
            this.dotBox = new System.Windows.Forms.PictureBox();
            this.secondBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondBox)).BeginInit();
            this.SuspendLayout();
            
            // backBox
            this.backBox.BackColor = System.Drawing.Color.Transparent;
            this.backBox.Location = new System.Drawing.Point(0, 0);
            this.backBox.Name = "backBox";
            this.backBox.Size = new System.Drawing.Size(300, 300);
            this.backBox.TabIndex = 0;
            this.backBox.TabStop = false;
            
            // hourBox
            this.hourBox.BackColor = System.Drawing.Color.Transparent;
            this.hourBox.Location = new System.Drawing.Point(12, 12);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(300, 300);
            this.hourBox.TabIndex = 1;
            this.hourBox.TabStop = false;
            
            // minuteBox
            this.minuteBox.BackColor = System.Drawing.Color.Transparent;
            this.minuteBox.Location = new System.Drawing.Point(27, 25);
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.Size = new System.Drawing.Size(300, 300);
            this.minuteBox.TabIndex = 2;
            this.minuteBox.TabStop = false;
            
            // dotBox
            this.dotBox.BackColor = System.Drawing.Color.Transparent;
            this.dotBox.Location = new System.Drawing.Point(42, 39);
            this.dotBox.Name = "dotBox";
            this.dotBox.Size = new System.Drawing.Size(300, 300);
            this.dotBox.TabIndex = 3;
            this.dotBox.TabStop = false;
            
            // secondBox
            this.secondBox.BackColor = System.Drawing.Color.Transparent;
            this.secondBox.Location = new System.Drawing.Point(58, 54);
            this.secondBox.Name = "secondBox";
            this.secondBox.Size = new System.Drawing.Size(300, 300);
            this.secondBox.TabIndex = 4;
            this.secondBox.TabStop = false;
            
            // timer1
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.secondBox);
            this.Controls.Add(this.dotBox);
            this.Controls.Add(this.minuteBox);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.backBox);
            this.Name = "Form1";
            this.Text = "Kell";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backBox;
        private System.Windows.Forms.PictureBox hourBox;
        private System.Windows.Forms.PictureBox minuteBox;
        private System.Windows.Forms.PictureBox dotBox;
        private System.Windows.Forms.PictureBox secondBox;
        private System.Windows.Forms.Timer timer1;
    }
}

