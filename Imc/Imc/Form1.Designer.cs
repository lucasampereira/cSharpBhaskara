
namespace Imc
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
            this.pesoTb = new System.Windows.Forms.TextBox();
            this.alturaTb = new System.Windows.Forms.TextBox();
            this.calcularBt = new System.Windows.Forms.Button();
            this.imcLb = new System.Windows.Forms.Label();
            this.msgLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pesoTb
            // 
            this.pesoTb.Location = new System.Drawing.Point(57, 56);
            this.pesoTb.Name = "pesoTb";
            this.pesoTb.Size = new System.Drawing.Size(100, 23);
            this.pesoTb.TabIndex = 0;
            // 
            // alturaTb
            // 
            this.alturaTb.Location = new System.Drawing.Point(57, 112);
            this.alturaTb.Name = "alturaTb";
            this.alturaTb.Size = new System.Drawing.Size(100, 23);
            this.alturaTb.TabIndex = 1;
            // 
            // calcularBt
            // 
            this.calcularBt.Location = new System.Drawing.Point(57, 183);
            this.calcularBt.Name = "calcularBt";
            this.calcularBt.Size = new System.Drawing.Size(75, 23);
            this.calcularBt.TabIndex = 2;
            this.calcularBt.Text = "calcular";
            this.calcularBt.UseVisualStyleBackColor = true;
            this.calcularBt.Click += new System.EventHandler(this.calcularBt_Click);
            // 
            // imcLb
            // 
            this.imcLb.AutoSize = true;
            this.imcLb.Location = new System.Drawing.Point(57, 242);
            this.imcLb.Name = "imcLb";
            this.imcLb.Size = new System.Drawing.Size(13, 15);
            this.imcLb.TabIndex = 3;
            this.imcLb.Text = "0";
            // 
            // msgLb
            // 
            this.msgLb.AutoSize = true;
            this.msgLb.Location = new System.Drawing.Point(57, 273);
            this.msgLb.Name = "msgLb";
            this.msgLb.Size = new System.Drawing.Size(66, 15);
            this.msgLb.TabIndex = 4;
            this.msgLb.Text = "mensagem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Peso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Altura:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 354);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msgLb);
            this.Controls.Add(this.imcLb);
            this.Controls.Add(this.calcularBt);
            this.Controls.Add(this.alturaTb);
            this.Controls.Add(this.pesoTb);
            this.Name = "Form1";
            this.Text = "Cálculo do IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pesoTb;
        private System.Windows.Forms.TextBox alturaTb;
        private System.Windows.Forms.Button calcularBt;
        private System.Windows.Forms.Label imcLb;
        private System.Windows.Forms.Label msgLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

