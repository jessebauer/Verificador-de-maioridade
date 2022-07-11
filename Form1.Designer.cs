namespace maiorDeIdade
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
            this.btnVerifica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerifica
            // 
            this.btnVerifica.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerifica.Location = new System.Drawing.Point(371, 188);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(160, 63);
            this.btnVerifica.TabIndex = 0;
            this.btnVerifica.Text = "Verificar";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(129, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite sua idade";
            // 
            // txtIdade
            // 
            this.txtIdade.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIdade.Location = new System.Drawing.Point(309, 129);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(298, 34);
            this.txtIdade.TabIndex = 1;
            this.txtIdade.TextChanged += new System.EventHandler(this.txtIdade_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(338, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Verificador de idade";
            // 
            // resposta
            // 
            this.resposta.AutoSize = true;
            this.resposta.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resposta.Location = new System.Drawing.Point(415, 277);
            this.resposta.Name = "resposta";
            this.resposta.Size = new System.Drawing.Size(91, 28);
            this.resposta.TabIndex = 4;
            this.resposta.Text = "idade \"x\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resposta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerifica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVerifica;
        private Label label1;
        private TextBox txtIdade;
        private Label label2;
        private Label resposta;
    }
}