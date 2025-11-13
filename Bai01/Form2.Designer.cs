namespace Bai01
{
    partial class Form2
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
            Status_lbl = new Label();
            SuspendLayout();
            // 
            // Status_lbl
            // 
            Status_lbl.AutoSize = true;
            Status_lbl.Font = new Font("Segoe UI", 25F);
            Status_lbl.Location = new Point(143, 201);
            Status_lbl.Name = "Status_lbl";
            Status_lbl.Size = new Size(0, 57);
            Status_lbl.TabIndex = 0;
            Status_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Status_lbl);
            Name = "Form2";
            Text = "Form2";
            Activated += Form2_Activated;
            Deactivate += Form2_Deactivate;
            FormClosing += Form2_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form2_Load;
            Shown += Form2_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Status_lbl;
    }
}