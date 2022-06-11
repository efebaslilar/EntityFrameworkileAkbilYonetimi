
namespace EntityFrameworkileAkbilYönetimiWinFormUI
{
    partial class FrmGiris
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
            this.btnAkbilIslemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAkbilIslemleri
            // 
            this.btnAkbilIslemleri.Location = new System.Drawing.Point(188, 85);
            this.btnAkbilIslemleri.Name = "btnAkbilIslemleri";
            this.btnAkbilIslemleri.Size = new System.Drawing.Size(229, 86);
            this.btnAkbilIslemleri.TabIndex = 0;
            this.btnAkbilIslemleri.Text = "Akbil İşlemleri";
            this.btnAkbilIslemleri.UseVisualStyleBackColor = true;
            this.btnAkbilIslemleri.Click += new System.EventHandler(this.btnAkbilIslemleri_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 382);
            this.Controls.Add(this.btnAkbilIslemleri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmGiris";
            this.Text = "Hoşgeldiniz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAkbilIslemleri;
    }
}

