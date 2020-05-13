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
            this.NameL = new System.Windows.Forms.Label();
            this.MeasureLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Regret_ECGB
            // 
            this.Regret_ECGB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Regret_ECGB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Regret_ECGB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Regret_ECGB.Location = new System.Drawing.Point(84, 309);
            this.Regret_ECGB.Name = "Regret_ECGB";
            this.Regret_ECGB.Size = new System.Drawing.Size(224, 69);
            this.Regret_ECGB.TabIndex = 1;
            this.Regret_ECGB.Text = "Ny patient";
            this.Regret_ECGB.UseVisualStyleBackColor = false;
            this.Regret_ECGB.Click += new System.EventHandler(this.Regret_ECGB_Click);
            // 
            // Start_SendB
            // 
            this.Start_SendB.BackColor = System.Drawing.Color.Green;
            this.Start_SendB.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Start_SendB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Start_SendB.Location = new System.Drawing.Point(625, 297);
            this.Start_SendB.Name = "Start_SendB";
            this.Start_SendB.Size = new System.Drawing.Size(274, 91);
            this.Start_SendB.TabIndex = 0;
            this.Start_SendB.Text = "Start EKG-måling";
            this.Start_SendB.UseVisualStyleBackColor = false;
            this.Start_SendB.Click += new System.EventHandler(this.Start_SendB_Click);
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameL.Location = new System.Drawing.Point(84, 65);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(65, 27);
            this.NameL.TabIndex = 3;
            this.NameL.Text = "Navn:";
            // 
            // MeasureLabel
            // 
            this.MeasureLabel.AutoSize = true;
            this.MeasureLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MeasureLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MeasureLabel.Location = new System.Drawing.Point(326, 155);
            this.MeasureLabel.Name = "MeasureLabel";
            this.MeasureLabel.Size = new System.Drawing.Size(288, 49);
            this.MeasureLabel.TabIndex = 5;
            this.MeasureLabel.Text = "Måling 0 ud af 3";
            // 
            // Measure_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.MeasureLabel);
            this.Controls.Add(this.NameL);
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
        private System.Windows.Forms.Label MeasureLabel;
        public System.Windows.Forms.Label NameL;
    }
}