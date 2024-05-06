namespace ContadorCliques
{
    partial class FormContadorCliques
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.labelContador = new System.Windows.Forms.Label();
            this.labelNomeAluno = new System.Windows.Forms.Label();
            this.labelRAAluno = new System.Windows.Forms.Label();
            this.SuspendLayout();
      
            this.btnMais.Location = new System.Drawing.Point(50, 50);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(75, 23);
            this.btnMais.TabIndex = 0;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
      
            this.btnMenos.Location = new System.Drawing.Point(150, 50);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(75, 23);
            this.btnMenos.TabIndex = 1;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
         

            this.btnReset.Location = new System.Drawing.Point(250, 50);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
         
            
            this.labelContador.AutoSize = true;
            this.labelContador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContador.Location = new System.Drawing.Point(50, 100);
            this.labelContador.Name = "labelContador";
            this.labelContador.Size = new System.Drawing.Size(152, 18);
            this.labelContador.TabIndex = 3;
            this.labelContador.Text = "Número de cliques: 0";
         

            this.labelNomeAluno.AutoSize = true;
            this.labelNomeAluno.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeAluno.Location = new System.Drawing.Point(50, 150);
            this.labelNomeAluno.Name = "labelNomeAluno";
            this.labelNomeAluno.Size = new System.Drawing.Size(92, 16);
            this.labelNomeAluno.TabIndex = 4;
            this.labelNomeAluno.Text = "Nome Aluno: Vinícius Alexandre Franco";
         

            this.labelRAAluno.AutoSize = true;
            this.labelRAAluno.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRAAluno.Location = new System.Drawing.Point(50, 180);
            this.labelRAAluno.Name = "labelRAAluno";
            this.labelRAAluno.Size = new System.Drawing.Size(75, 16);
            this.labelRAAluno.TabIndex = 5;
            this.labelRAAluno.Text = "RA Aluno: 2020202163";
           

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.labelRAAluno);
            this.Controls.Add(this.labelNomeAluno);
            this.Controls.Add(this.labelContador);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Name = "FormContadorCliques";
            this.Text = "Contador de Cliques";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label labelContador;
        private System.Windows.Forms.Label labelNomeAluno;
        private System.Windows.Forms.Label labelRAAluno;
    }
}
