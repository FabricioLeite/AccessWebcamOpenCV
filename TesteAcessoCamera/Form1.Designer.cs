namespace TesteAcessoCamera
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
            this.components = new System.ComponentModel.Container();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.CamImageBox = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(660, 13);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 37);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(660, 98);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 37);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(660, 56);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 36);
            this.btnParar.TabIndex = 3;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // CamImageBox
            // 
            this.CamImageBox.BackColor = System.Drawing.Color.Transparent;
            this.CamImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CamImageBox.Location = new System.Drawing.Point(13, 13);
            this.CamImageBox.Name = "CamImageBox";
            this.CamImageBox.Size = new System.Drawing.Size(641, 443);
            this.CamImageBox.TabIndex = 2;
            this.CamImageBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 468);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.CamImageBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox CamImageBox;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnParar;
    }
}

