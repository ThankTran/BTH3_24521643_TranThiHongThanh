namespace Bai05
{
    partial class Form1
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
            this.tb_Num1 = new System.Windows.Forms.TextBox();
            this.tb_Num2 = new System.Windows.Forms.TextBox();
            this.b_Add = new System.Windows.Forms.Button();
            this.b_Sub = new System.Windows.Forms.Button();
            this.b_Mul = new System.Windows.Forms.Button();
            this.b_Div = new System.Windows.Forms.Button();
            this.tb_Ans = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 2";
            // 
            // tb_Num1
            // 
            this.tb_Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Num1.Location = new System.Drawing.Point(204, 22);
            this.tb_Num1.Name = "tb_Num1";
            this.tb_Num1.Size = new System.Drawing.Size(237, 38);
            this.tb_Num1.TabIndex = 2;
            // 
            // tb_Num2
            // 
            this.tb_Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Num2.Location = new System.Drawing.Point(204, 69);
            this.tb_Num2.Name = "tb_Num2";
            this.tb_Num2.Size = new System.Drawing.Size(237, 38);
            this.tb_Num2.TabIndex = 3;
            // 
            // b_Add
            // 
            this.b_Add.Location = new System.Drawing.Point(187, 125);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(64, 60);
            this.b_Add.TabIndex = 8;
            this.b_Add.Text = "+";
            this.b_Add.UseVisualStyleBackColor = true;
            this.b_Add.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // b_Sub
            // 
            this.b_Sub.Location = new System.Drawing.Point(257, 125);
            this.b_Sub.Name = "b_Sub";
            this.b_Sub.Size = new System.Drawing.Size(64, 60);
            this.b_Sub.TabIndex = 9;
            this.b_Sub.Text = "-";
            this.b_Sub.UseVisualStyleBackColor = true;
            this.b_Sub.Click += new System.EventHandler(this.b_Sub_Click);
            // 
            // b_Mul
            // 
            this.b_Mul.Location = new System.Drawing.Point(327, 125);
            this.b_Mul.Name = "b_Mul";
            this.b_Mul.Size = new System.Drawing.Size(64, 60);
            this.b_Mul.TabIndex = 10;
            this.b_Mul.Text = "x";
            this.b_Mul.UseVisualStyleBackColor = true;
            this.b_Mul.Click += new System.EventHandler(this.b_Mul_Click);
            // 
            // b_Div
            // 
            this.b_Div.Location = new System.Drawing.Point(397, 125);
            this.b_Div.Name = "b_Div";
            this.b_Div.Size = new System.Drawing.Size(64, 60);
            this.b_Div.TabIndex = 11;
            this.b_Div.Text = "/";
            this.b_Div.UseVisualStyleBackColor = true;
            this.b_Div.Click += new System.EventHandler(this.b_Div_Click);
            // 
            // tb_Ans
            // 
            this.tb_Ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ans.Location = new System.Drawing.Point(204, 203);
            this.tb_Ans.Name = "tb_Ans";
            this.tb_Ans.Size = new System.Drawing.Size(237, 38);
            this.tb_Ans.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Answer ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 287);
            this.Controls.Add(this.tb_Ans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b_Div);
            this.Controls.Add(this.b_Mul);
            this.Controls.Add(this.b_Sub);
            this.Controls.Add(this.b_Add);
            this.Controls.Add(this.tb_Num2);
            this.Controls.Add(this.tb_Num1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Num1;
        private System.Windows.Forms.TextBox tb_Num2;
        private System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.Button b_Sub;
        private System.Windows.Forms.Button b_Mul;
        private System.Windows.Forms.Button b_Div;
        private System.Windows.Forms.TextBox tb_Ans;
        private System.Windows.Forms.Label label3;
    }
}

