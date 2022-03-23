namespace atv_02_23._03
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
            this.btCalcular = new System.Windows.Forms.Button();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor3 = new System.Windows.Forms.TextBox();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblEquacao = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(80, 241);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(134, 46);
            this.btCalcular.TabIndex = 0;
            this.btCalcular.Text = "CALCULAR";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(70, 50);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(76, 23);
            this.txtValor1.TabIndex = 1;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(192, 50);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(81, 23);
            this.txtValor2.TabIndex = 2;
            // 
            // txtValor3
            // 
            this.txtValor3.Location = new System.Drawing.Point(327, 50);
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Size = new System.Drawing.Size(96, 23);
            this.txtValor3.TabIndex = 3;
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValor1.Location = new System.Drawing.Point(70, 90);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(77, 25);
            this.lblValor1.TabIndex = 4;
            this.lblValor1.Text = "Valores";
            this.lblValor1.Click += new System.EventHandler(this.lblValor1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(70, 199);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(65, 25);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "label1";
            // 
            // lblEquacao
            // 
            this.lblEquacao.AutoSize = true;
            this.lblEquacao.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblEquacao.Location = new System.Drawing.Point(70, 126);
            this.lblEquacao.Name = "lblEquacao";
            this.lblEquacao.Size = new System.Drawing.Size(65, 25);
            this.lblEquacao.TabIndex = 6;
            this.lblEquacao.Text = "label1";
            this.lblEquacao.Click += new System.EventHandler(this.lblEquacao_Click);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblB.Location = new System.Drawing.Point(70, 151);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(65, 25);
            this.lblB.TabIndex = 7;
            this.lblB.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 299);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblEquacao);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.txtValor3);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.btCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btCalcular;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private TextBox txtValor3;
        private Label lblValor1;
        private Label lblResultado;
        private Label lblEquacao;
        private Label lblB;
    }
}