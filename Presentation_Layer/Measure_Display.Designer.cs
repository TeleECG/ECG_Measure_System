namespace Presentation_Layer
{
    partial class Measure_Display
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
            this.Regret_ECGB = new System.Windows.Forms.Button();
            this.Start_SendB = new System.Windows.Forms.Button();
            this.MeasureNumberTB = new System.Windows.Forms.TextBox();
            this.NameL = new System.Windows.Forms.Label();
            this.NameMeasureTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Regret_ECGB
            // 
            this.Regret_ECGB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Regret_ECGB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Regret_ECGB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Regret_ECGB.Location = new System.Drawing.Point(26, 297);
            this.Regret_ECGB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Regret_ECGB.Name = "Regret_ECGB";
            this.Regret_ECGB.Size = new System.Drawing.Size(151, 38);
            this.Regret_ECGB.TabIndex = 0;
            this.Regret_ECGB.Text = "Ny patient";
            this.Regret_ECGB.UseVisualStyleBackColor = false;
            this.Regret_ECGB.Click += new System.EventHandler(this.Regret_ECGB_Click);
            // 
            // Start_SendB
            // 
            this.Start_SendB.BackColor = System.Drawing.Color.Green;
            this.Start_SendB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Start_SendB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Start_SendB.Location = new System.Drawing.Point(566, 288);
            this.Start_SendB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Start_SendB.Name = "Start_SendB";
            this.Start_SendB.Size = new System.Drawing.Size(179, 55);
            this.Start_SendB.TabIndex = 1;
            this.Start_SendB.Text = "Start EKG-måling";
            this.Start_SendB.UseVisualStyleBackColor = false;
            this.Start_SendB.Click += new System.EventHandler(this.Start_SendB_Click);
            // 
            // MeasureNumberTB
            // 
            this.MeasureNumberTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.MeasureNumberTB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MeasureNumberTB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MeasureNumberTB.Location = new System.Drawing.Point(494, 24);
            this.MeasureNumberTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MeasureNumberTB.Name = "MeasureNumberTB";
            this.MeasureNumberTB.ReadOnly = true;
            this.MeasureNumberTB.Size = new System.Drawing.Size(56, 30);
            this.MeasureNumberTB.TabIndex = 2;
            this.MeasureNumberTB.Visible = false;
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameL.Location = new System.Drawing.Point(10, 22);
            this.NameL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(56, 23);
            this.NameL.TabIndex = 3;
            this.NameL.Text = "Navn:";
            this.NameL.Visible = false;
            // 
            // NameMeasureTB
            // 
            this.NameMeasureTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NameMeasureTB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameMeasureTB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameMeasureTB.Location = new System.Drawing.Point(67, 24);
            this.NameMeasureTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameMeasureTB.Multiline = true;
            this.NameMeasureTB.Name = "NameMeasureTB";
            this.NameMeasureTB.ReadOnly = true;
            this.NameMeasureTB.Size = new System.Drawing.Size(219, 26);
            this.NameMeasureTB.TabIndex = 4;
            this.NameMeasureTB.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(421, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Måling: ";
            this.label1.Visible = false;
            // 
            // Measure_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(778, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameMeasureTB);
            this.Controls.Add(this.NameL);
            this.Controls.Add(this.MeasureNumberTB);
            this.Controls.Add(this.Start_SendB);
            this.Controls.Add(this.Regret_ECGB);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Measure_Display";
            this.Text = "Measure_Display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Regret_ECGB;
        private System.Windows.Forms.Button Start_SendB;
        private System.Windows.Forms.TextBox MeasureNumberTB;
        private System.Windows.Forms.Label NameL;
        private System.Windows.Forms.TextBox NameMeasureTB;
        private System.Windows.Forms.Label label1;
    }
}