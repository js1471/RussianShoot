
namespace RussianShoot
{
    partial class Russian
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
            this.btnLoadgun = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnSpinShot = new System.Windows.Forms.Button();
            this.btnHeadShoot = new System.Windows.Forms.Button();
            this.btnShootOut = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblChances = new System.Windows.Forms.Label();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.txtChance = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoadgun
            // 
            this.btnLoadgun.BackColor = System.Drawing.Color.Gray;
            this.btnLoadgun.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadgun.Location = new System.Drawing.Point(304, 35);
            this.btnLoadgun.Name = "btnLoadgun";
            this.btnLoadgun.Size = new System.Drawing.Size(123, 52);
            this.btnLoadgun.TabIndex = 0;
            this.btnLoadgun.Text = "Load Gun";
            this.btnLoadgun.UseVisualStyleBackColor = false;
            this.btnLoadgun.Click += new System.EventHandler(this.btnLoadGun_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Maroon;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRestart.Location = new System.Drawing.Point(12, 375);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(110, 53);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnSpinShot
            // 
            this.btnSpinShot.BackColor = System.Drawing.Color.Gray;
            this.btnSpinShot.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpinShot.Location = new System.Drawing.Point(484, 157);
            this.btnSpinShot.Name = "btnSpinShot";
            this.btnSpinShot.Size = new System.Drawing.Size(123, 52);
            this.btnSpinShot.TabIndex = 6;
            this.btnSpinShot.Text = "Spin Shot";
            this.btnSpinShot.UseVisualStyleBackColor = false;
            this.btnSpinShot.Click += new System.EventHandler(this.btnSpinShot_Click);
            // 
            // btnHeadShoot
            // 
            this.btnHeadShoot.BackColor = System.Drawing.Color.Gray;
            this.btnHeadShoot.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeadShoot.Location = new System.Drawing.Point(304, 296);
            this.btnHeadShoot.Name = "btnHeadShoot";
            this.btnHeadShoot.Size = new System.Drawing.Size(133, 52);
            this.btnHeadShoot.TabIndex = 7;
            this.btnHeadShoot.Text = "Head Shoot";
            this.btnHeadShoot.UseVisualStyleBackColor = false;
            this.btnHeadShoot.Click += new System.EventHandler(this.btnHeadShoot_Click);
            // 
            // btnShootOut
            // 
            this.btnShootOut.BackColor = System.Drawing.Color.Gray;
            this.btnShootOut.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShootOut.Location = new System.Drawing.Point(108, 157);
            this.btnShootOut.Name = "btnShootOut";
            this.btnShootOut.Size = new System.Drawing.Size(123, 52);
            this.btnShootOut.TabIndex = 8;
            this.btnShootOut.Text = "Shoot out";
            this.btnShootOut.UseVisualStyleBackColor = false;
            this.btnShootOut.Click += new System.EventHandler(this.btnShootOut_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Maroon;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuit.Location = new System.Drawing.Point(607, 375);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(110, 53);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblChances
            // 
            this.lblChances.AutoSize = true;
            this.lblChances.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblChances.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChances.Location = new System.Drawing.Point(625, 21);
            this.lblChances.Name = "lblChances";
            this.lblChances.Size = new System.Drawing.Size(92, 24);
            this.lblChances.TabIndex = 11;
            this.lblChances.Text = "Chances";
            // 
            // txtStore
            // 
            this.txtStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStore.Location = new System.Drawing.Point(576, 296);
            this.txtStore.Multiline = true;
            this.txtStore.Name = "txtStore";
            this.txtStore.Size = new System.Drawing.Size(10, 10);
            this.txtStore.TabIndex = 15;
            this.txtStore.Text = "0";
            this.txtStore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStore.Visible = false;
            // 
            // txtChance
            // 
            this.txtChance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChance.Location = new System.Drawing.Point(631, 62);
            this.txtChance.Multiline = true;
            this.txtChance.Name = "txtChance";
            this.txtChance.Size = new System.Drawing.Size(86, 42);
            this.txtChance.TabIndex = 16;
            this.txtChance.Text = "0";
            this.txtChance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(128, 375);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(473, 60);
            this.txtResult.TabIndex = 17;
            this.txtResult.Text = "Good Luck .. Load The gun for Play Game";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 94);
            this.label1.TabIndex = 18;
            this.label1.Text = "Russian \r\nShoot";
            // 
            // Russian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RussianShoot.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtChance);
            this.Controls.Add(this.txtStore);
            this.Controls.Add(this.lblChances);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnShootOut);
            this.Controls.Add(this.btnHeadShoot);
            this.Controls.Add(this.btnSpinShot);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnLoadgun);
            this.Name = "Russian";
            this.Text = "RussianShoot";
            this.Load += new System.EventHandler(this.Russian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadgun;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnSpinShot;
        private System.Windows.Forms.Button btnHeadShoot;
        private System.Windows.Forms.Button btnShootOut;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblChances;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.TextBox txtChance;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
    }
}

