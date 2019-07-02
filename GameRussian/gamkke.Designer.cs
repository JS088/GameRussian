namespace GameRussian
{
    partial class gamkke
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnload = new System.Windows.Forms.Button();
            this.btnRetry = new System.Windows.Forms.Button();
            this.btnshoot = new System.Windows.Forms.Button();
            this.btnspin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonsa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(275, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Russian Roullete";
            // 
            // btnload
            // 
            this.btnload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnload.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnload.Location = new System.Drawing.Point(32, 92);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(105, 39);
            this.btnload.TabIndex = 1;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnRetry
            // 
            this.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetry.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRetry.Location = new System.Drawing.Point(32, 360);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(105, 65);
            this.btnRetry.TabIndex = 2;
            this.btnRetry.Text = "Play Again";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnshoot
            // 
            this.btnshoot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnshoot.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshoot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnshoot.Location = new System.Drawing.Point(32, 216);
            this.btnshoot.Name = "btnshoot";
            this.btnshoot.Size = new System.Drawing.Size(105, 39);
            this.btnshoot.TabIndex = 3;
            this.btnshoot.Text = "Shoot";
            this.btnshoot.UseVisualStyleBackColor = true;
            this.btnshoot.Click += new System.EventHandler(this.btnshoot_Click);
            // 
            // btnspin
            // 
            this.btnspin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnspin.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnspin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnspin.Location = new System.Drawing.Point(32, 151);
            this.btnspin.Name = "btnspin";
            this.btnspin.Size = new System.Drawing.Size(105, 39);
            this.btnspin.TabIndex = 4;
            this.btnspin.Text = "Spin";
            this.btnspin.UseVisualStyleBackColor = true;
            this.btnspin.Click += new System.EventHandler(this.btnspin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(178, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(597, 324);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // buttonsa
            // 
            this.buttonsa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsa.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonsa.Location = new System.Drawing.Point(32, 277);
            this.buttonsa.Name = "buttonsa";
            this.buttonsa.Size = new System.Drawing.Size(105, 65);
            this.buttonsa.TabIndex = 6;
            this.buttonsa.Text = "Shoot Away";
            this.buttonsa.UseVisualStyleBackColor = true;
            this.buttonsa.Click += new System.EventHandler(this.Buttonsa_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonsa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnspin);
            this.Controls.Add(this.btnshoot);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.label1);
            this.Name = "game";
            this.Text = "Russian Roullete";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Button btnshoot;
        private System.Windows.Forms.Button btnspin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonsa;
    }
}

