
namespace DESAFIO1
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
            this.PESO = new System.Windows.Forms.TextBox();
            this.ALTURA = new System.Windows.Forms.TextBox();
            this.GO = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PESO
            // 
            this.PESO.Location = new System.Drawing.Point(173, 191);
            this.PESO.Name = "PESO";
            this.PESO.Size = new System.Drawing.Size(125, 27);
            this.PESO.TabIndex = 0;
            this.PESO.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ALTURA
            // 
            this.ALTURA.Location = new System.Drawing.Point(458, 191);
            this.ALTURA.Name = "ALTURA";
            this.ALTURA.Size = new System.Drawing.Size(125, 27);
            this.ALTURA.TabIndex = 1;
            this.ALTURA.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // GO
            // 
            this.GO.Location = new System.Drawing.Point(346, 289);
            this.GO.Name = "GO";
            this.GO.Size = new System.Drawing.Size(94, 29);
            this.GO.TabIndex = 2;
            this.GO.Text = "Calcular";
            this.GO.UseVisualStyleBackColor = true;
            this.GO.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Insira seu peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Insira sua altura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calculadora de IMC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GO);
            this.Controls.Add(this.ALTURA);
            this.Controls.Add(this.PESO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PESO;
        private System.Windows.Forms.TextBox ALTURA;
        private System.Windows.Forms.Button GO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

