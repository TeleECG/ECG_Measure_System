namespace Presentation_Layer
{
    partial class Patient_Display
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CPRTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.AdressTB = new System.Windows.Forms.TextBox();
            this.SaveB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(287, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indtast patientdata";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(61, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPR-nummer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(61, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Navn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(61, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresse:";
            // 
            // CPRTB
            // 
            this.CPRTB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CPRTB.Location = new System.Drawing.Point(219, 130);
            this.CPRTB.Name = "CPRTB";
            this.CPRTB.Size = new System.Drawing.Size(375, 34);
            this.CPRTB.TabIndex = 4;
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameTB.Location = new System.Drawing.Point(219, 204);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(375, 34);
            this.NameTB.TabIndex = 5;
            // 
            // AdressTB
            // 
            this.AdressTB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdressTB.Location = new System.Drawing.Point(219, 273);
            this.AdressTB.Name = "AdressTB";
            this.AdressTB.Size = new System.Drawing.Size(375, 34);
            this.AdressTB.TabIndex = 6;
            // 
            // SaveB
            // 
            this.SaveB.BackColor = System.Drawing.Color.Green;
            this.SaveB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveB.Location = new System.Drawing.Point(276, 351);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(251, 59);
            this.SaveB.TabIndex = 7;
            this.SaveB.Text = "Gem patientoplysninger";
            this.SaveB.UseVisualStyleBackColor = false;
            // 
            // Patient_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.AdressTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.CPRTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Patient_Display";
            this.Text = "Patient_Display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CPRTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox AdressTB;
        private System.Windows.Forms.Button SaveB;
    }
}