namespace Assignment1
{
    partial class TrainDisplay
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
            labelStation = new Label();
            labelTrack = new Label();
            SuspendLayout();
            // 
            // labelStation
            // 
            labelStation.AutoSize = true;
            labelStation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStation.Location = new Point(30, 35);
            labelStation.Name = "labelStation";
            labelStation.Size = new Size(121, 21);
            labelStation.TabIndex = 0;
            labelStation.Text = "Current station: ";
            // 
            // labelTrack
            // 
            labelTrack.AutoSize = true;
            labelTrack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTrack.Location = new Point(30, 72);
            labelTrack.Name = "labelTrack";
            labelTrack.Size = new Size(111, 21);
            labelTrack.TabIndex = 1;
            labelTrack.Text = "Railway Track: ";
            // 
            // TrainDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 138);
            Controls.Add(labelTrack);
            Controls.Add(labelStation);
            Name = "TrainDisplay";
            Text = "TrainDisplay";
            Load += TrainDisplay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelStation;
        private Label labelTrack;
    }
}