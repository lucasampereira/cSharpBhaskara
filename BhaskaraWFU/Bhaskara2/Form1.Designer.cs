namespace Bhaskara2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.aTb = new System.Windows.Forms.TextBox();
            this.bTb = new System.Windows.Forms.TextBox();
            this.cTb = new System.Windows.Forms.TextBox();
            this.calcBt = new System.Windows.Forms.Button();
            this.deltaLb = new System.Windows.Forms.Label();
            this.msgLb = new System.Windows.Forms.Label();
            this.a1Lb = new System.Windows.Forms.Label();
            this.a2Lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aTb
            // 
            this.aTb.Location = new System.Drawing.Point(52, 25);
            this.aTb.Name = "aTb";
            this.aTb.Size = new System.Drawing.Size(100, 23);
            this.aTb.TabIndex = 0;
            // 
            // bTb
            // 
            this.bTb.Location = new System.Drawing.Point(52, 58);
            this.bTb.Name = "bTb";
            this.bTb.Size = new System.Drawing.Size(100, 23);
            this.bTb.TabIndex = 1;
            // 
            // cTb
            // 
            this.cTb.Location = new System.Drawing.Point(51, 93);
            this.cTb.Name = "cTb";
            this.cTb.Size = new System.Drawing.Size(100, 23);
            this.cTb.TabIndex = 2;
            // 
            // calcBt
            // 
            this.calcBt.Location = new System.Drawing.Point(52, 141);
            this.calcBt.Name = "calcBt";
            this.calcBt.Size = new System.Drawing.Size(75, 23);
            this.calcBt.TabIndex = 3;
            this.calcBt.Text = "calcular";
            this.calcBt.UseVisualStyleBackColor = true;
            this.calcBt.Click += new System.EventHandler(this.calcBt_Click);
            // 
            // deltaLb
            // 
            this.deltaLb.AutoSize = true;
            this.deltaLb.Location = new System.Drawing.Point(52, 196);
            this.deltaLb.Name = "deltaLb";
            this.deltaLb.Size = new System.Drawing.Size(33, 15);
            this.deltaLb.TabIndex = 4;
            this.deltaLb.Text = "delta";
            // 
            // msgLb
            // 
            this.msgLb.AutoSize = true;
            this.msgLb.Location = new System.Drawing.Point(51, 221);
            this.msgLb.Name = "msgLb";
            this.msgLb.Size = new System.Drawing.Size(66, 15);
            this.msgLb.TabIndex = 5;
            this.msgLb.Text = "mensagem";
            // 
            // a1Lb
            // 
            this.a1Lb.AutoSize = true;
            this.a1Lb.Location = new System.Drawing.Point(52, 253);
            this.a1Lb.Name = "a1Lb";
            this.a1Lb.Size = new System.Drawing.Size(19, 15);
            this.a1Lb.TabIndex = 6;
            this.a1Lb.Text = "a1";
            // 
            // a2Lb
            // 
            this.a2Lb.AutoSize = true;
            this.a2Lb.Location = new System.Drawing.Point(51, 283);
            this.a2Lb.Name = "a2Lb";
            this.a2Lb.Size = new System.Drawing.Size(19, 15);
            this.a2Lb.TabIndex = 7;
            this.a2Lb.Text = "a2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "c:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 325);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.a2Lb);
            this.Controls.Add(this.a1Lb);
            this.Controls.Add(this.msgLb);
            this.Controls.Add(this.deltaLb);
            this.Controls.Add(this.calcBt);
            this.Controls.Add(this.cTb);
            this.Controls.Add(this.bTb);
            this.Controls.Add(this.aTb);
            this.Name = "Form1";
            this.Text = "Fórmula de Bháskara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox aTb;
        private TextBox bTb;
        private TextBox cTb;
        private Button calcBt;
        private Label deltaLb;
        private Label msgLb;
        private Label a1Lb;
        private Label a2Lb;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}