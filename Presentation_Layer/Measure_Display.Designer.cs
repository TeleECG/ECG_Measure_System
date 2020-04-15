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
            this.Regret_ECGB.Location = new System.Drawing.Point(32, 371);
            this.Regret_ECGB.Name = "Regret_ECGB";
            this.Regret_ECGB.Size = new System.Drawing.Size(189, 47);
            this.Regret_ECGB.TabIndex = 0;
            this.Regret_ECGB.Text = "Ny patient";
            this.Regret_ECGB.UseVisualStyleBackColor = false;
            // 
            // Start_SendB
            // 
            this.Start_SendB.BackColor = System.Drawing.Color.Green;
            this.Start_SendB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Start_SendB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Start_SendB.Location = new System.Drawing.Point(707, 360);
            this.Start_SendB.Name = "Start_SendB";
            this.Start_SendB.Size = new System.Drawing.Size(224, 69);
            this.Start_SendB.TabIndex = 1;
            this.Start_SendB.Text = "Start EKG-måling";
            this.Start_SendB.UseVisualStyleBackColor = false;
            // 
            // MeasureNumberTB
            // 
            this.MeasureNumberTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.MeasureNumberTB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MeasureNumberTB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MeasureNumberTB.Location = new System.Drawing.Point(617, 30);
            this.MeasureNumberTB.Name = "MeasureNumberTB";
            this.MeasureNumberTB.Size = new System.Drawing.Size(69, 34);
            this.MeasureNumberTB.TabIndex = 2;
            this.MeasureNumberTB.Visible = false;
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameL.Location = new System.Drawing.Point(13, 27);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(65, 27);
            this.NameL.TabIndex = 3;
            this.NameL.Text = "Navn:";
            this.NameL.Visible = false;
            // 
            // NameMeasureTB
            // 
            this.NameMeasureTB.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NameMeasureTB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameMeasureTB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameMeasureTB.Location = new System.Drawing.Point(84, 30);
            this.NameMeasureTB.Name = "NameMeasureTB";
            this.NameMeasureTB.Size = new System.Drawing.Size(273, 34);
            this.NameMeasureTB.TabIndex = 4;
            this.NameMeasureTB.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(526, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Måling: ";
            this.label1.Visible = false;
            // 
            // Measure_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameMeasureTB);
            this.Controls.Add(this.NameL);
            this.Controls.Add(this.MeasureNumberTB);
            this.Controls.Add(this.Start_SendB);
            this.Controls.Add(this.Regret_ECGB);
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