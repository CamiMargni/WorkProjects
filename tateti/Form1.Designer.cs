namespace tateti
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
            this.sup1 = new System.Windows.Forms.Button();
            this.sup2 = new System.Windows.Forms.Button();
            this.sup3 = new System.Windows.Forms.Button();
            this.medio1 = new System.Windows.Forms.Button();
            this.medio2 = new System.Windows.Forms.Button();
            this.medio3 = new System.Windows.Forms.Button();
            this.inf1 = new System.Windows.Forms.Button();
            this.inf2 = new System.Windows.Forms.Button();
            this.inf3 = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.juegaUsuario = new System.Windows.Forms.Button();
            this.juegaPc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sup1
            // 
            this.sup1.AccessibleName = "sup1";
            this.sup1.Location = new System.Drawing.Point(270, 125);
            this.sup1.Name = "sup1";
            this.sup1.Size = new System.Drawing.Size(75, 23);
            this.sup1.TabIndex = 0;
            this.sup1.UseVisualStyleBackColor = true;
            this.sup1.Click += new System.EventHandler(this.Sup1_Click);
            // 
            // sup2
            // 
            this.sup2.AccessibleName = "sup2";
            this.sup2.Location = new System.Drawing.Point(351, 125);
            this.sup2.Name = "sup2";
            this.sup2.Size = new System.Drawing.Size(75, 23);
            this.sup2.TabIndex = 1;
            this.sup2.UseVisualStyleBackColor = true;
            this.sup2.Click += new System.EventHandler(this.Sup2_Click);
            // 
            // sup3
            // 
            this.sup3.AccessibleName = "sup3";
            this.sup3.Location = new System.Drawing.Point(432, 125);
            this.sup3.Name = "sup3";
            this.sup3.Size = new System.Drawing.Size(75, 23);
            this.sup3.TabIndex = 2;
            this.sup3.UseVisualStyleBackColor = true;
            this.sup3.Click += new System.EventHandler(this.Sup3_Click);
            // 
            // medio1
            // 
            this.medio1.AccessibleName = "medio1";
            this.medio1.Location = new System.Drawing.Point(270, 154);
            this.medio1.Name = "medio1";
            this.medio1.Size = new System.Drawing.Size(75, 23);
            this.medio1.TabIndex = 3;
            this.medio1.UseVisualStyleBackColor = true;
            this.medio1.Click += new System.EventHandler(this.Medio1_Click);
            // 
            // medio2
            // 
            this.medio2.AccessibleName = "medio2";
            this.medio2.Location = new System.Drawing.Point(351, 154);
            this.medio2.Name = "medio2";
            this.medio2.Size = new System.Drawing.Size(75, 23);
            this.medio2.TabIndex = 4;
            this.medio2.UseVisualStyleBackColor = true;
            this.medio2.Click += new System.EventHandler(this.Medio2_Click);
            // 
            // medio3
            // 
            this.medio3.AccessibleName = "medio3";
            this.medio3.Location = new System.Drawing.Point(432, 154);
            this.medio3.Name = "medio3";
            this.medio3.Size = new System.Drawing.Size(75, 23);
            this.medio3.TabIndex = 5;
            this.medio3.UseVisualStyleBackColor = true;
            this.medio3.Click += new System.EventHandler(this.Medio3_Click);
            // 
            // inf1
            // 
            this.inf1.AccessibleName = "inf1";
            this.inf1.Location = new System.Drawing.Point(270, 184);
            this.inf1.Name = "inf1";
            this.inf1.Size = new System.Drawing.Size(75, 23);
            this.inf1.TabIndex = 6;
            this.inf1.UseVisualStyleBackColor = true;
            this.inf1.Click += new System.EventHandler(this.Inf1_Click);
            // 
            // inf2
            // 
            this.inf2.AccessibleName = "inf2";
            this.inf2.Location = new System.Drawing.Point(351, 183);
            this.inf2.Name = "inf2";
            this.inf2.Size = new System.Drawing.Size(75, 23);
            this.inf2.TabIndex = 7;
            this.inf2.UseVisualStyleBackColor = true;
            this.inf2.Click += new System.EventHandler(this.Inf2_Click);
            // 
            // inf3
            // 
            this.inf3.AccessibleName = "inf3";
            this.inf3.Location = new System.Drawing.Point(433, 183);
            this.inf3.Name = "inf3";
            this.inf3.Size = new System.Drawing.Size(75, 23);
            this.inf3.TabIndex = 8;
            this.inf3.UseVisualStyleBackColor = true;
            this.inf3.Click += new System.EventHandler(this.Inf3_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.titulo.Location = new System.Drawing.Point(364, 94);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(51, 13);
            this.titulo.TabIndex = 9;
            this.titulo.Text = "TA TE TI";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(348, 225);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(81, 13);
            this.resultado.TabIndex = 10;
            this.resultado.Text = "Juego en Curso";
            this.resultado.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(567, 138);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(70, 55);
            this.reset.TabIndex = 11;
            this.reset.TabStop = false;
            this.reset.Text = "Jugar otra vez!";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // juegaUsuario
            // 
            this.juegaUsuario.Location = new System.Drawing.Point(308, 281);
            this.juegaUsuario.Name = "juegaUsuario";
            this.juegaUsuario.Size = new System.Drawing.Size(75, 23);
            this.juegaUsuario.TabIndex = 12;
            this.juegaUsuario.Text = "juego yo";
            this.juegaUsuario.UseVisualStyleBackColor = true;
            this.juegaUsuario.Click += new System.EventHandler(this.JuegaUsuario_Click);
            // 
            // juegaPc
            // 
            this.juegaPc.Location = new System.Drawing.Point(389, 281);
            this.juegaPc.Name = "juegaPc";
            this.juegaPc.Size = new System.Drawing.Size(75, 23);
            this.juegaPc.TabIndex = 13;
            this.juegaPc.Text = "juega la pc";
            this.juegaPc.UseVisualStyleBackColor = true;
            this.juegaPc.Click += new System.EventHandler(this.JuegaPc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.juegaPc);
            this.Controls.Add(this.juegaUsuario);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.inf3);
            this.Controls.Add(this.inf2);
            this.Controls.Add(this.inf1);
            this.Controls.Add(this.medio3);
            this.Controls.Add(this.medio2);
            this.Controls.Add(this.medio1);
            this.Controls.Add(this.sup3);
            this.Controls.Add(this.sup2);
            this.Controls.Add(this.sup1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sup1;
        private System.Windows.Forms.Button sup2;
        private System.Windows.Forms.Button sup3;
        private System.Windows.Forms.Button medio1;
        private System.Windows.Forms.Button medio2;
        private System.Windows.Forms.Button medio3;
        private System.Windows.Forms.Button inf1;
        private System.Windows.Forms.Button inf2;
        private System.Windows.Forms.Button inf3;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button juegaUsuario;
        private System.Windows.Forms.Button juegaPc;
    }
}

