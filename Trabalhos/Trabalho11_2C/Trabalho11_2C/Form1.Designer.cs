namespace Trabalho11_2C
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
            this.qtdcarros = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ModeloBox = new System.Windows.Forms.TextBox();
            this.MarcaBox = new System.Windows.Forms.TextBox();
            this.PlacaBox = new System.Windows.Forms.TextBox();
            this.VagasBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.qtdpassageiros = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantos carros?";
            // 
            // qtdcarros
            // 
            this.qtdcarros.Location = new System.Drawing.Point(103, 16);
            this.qtdcarros.Name = "qtdcarros";
            this.qtdcarros.Size = new System.Drawing.Size(92, 20);
            this.qtdcarros.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Placa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Vagas";
            // 
            // ModeloBox
            // 
            this.ModeloBox.Location = new System.Drawing.Point(103, 141);
            this.ModeloBox.Name = "ModeloBox";
            this.ModeloBox.Size = new System.Drawing.Size(92, 20);
            this.ModeloBox.TabIndex = 7;
            // 
            // MarcaBox
            // 
            this.MarcaBox.Location = new System.Drawing.Point(103, 167);
            this.MarcaBox.Name = "MarcaBox";
            this.MarcaBox.Size = new System.Drawing.Size(92, 20);
            this.MarcaBox.TabIndex = 8;
            // 
            // PlacaBox
            // 
            this.PlacaBox.Location = new System.Drawing.Point(103, 193);
            this.PlacaBox.Name = "PlacaBox";
            this.PlacaBox.Size = new System.Drawing.Size(92, 20);
            this.PlacaBox.TabIndex = 9;
            // 
            // VagasBox
            // 
            this.VagasBox.Location = new System.Drawing.Point(103, 219);
            this.VagasBox.Name = "VagasBox";
            this.VagasBox.Size = new System.Drawing.Size(92, 20);
            this.VagasBox.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add Carro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quantidade de Passageiros";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Id do Carro";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(206, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Add Pessoa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // qtdpassageiros
            // 
            this.qtdpassageiros.Location = new System.Drawing.Point(155, 42);
            this.qtdpassageiros.Name = "qtdpassageiros";
            this.qtdpassageiros.Size = new System.Drawing.Size(40, 20);
            this.qtdpassageiros.TabIndex = 15;
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(103, 295);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(92, 20);
            this.IdBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 333);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.qtdpassageiros);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.VagasBox);
            this.Controls.Add(this.PlacaBox);
            this.Controls.Add(this.MarcaBox);
            this.Controls.Add(this.ModeloBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.qtdcarros);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qtdcarros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ModeloBox;
        private System.Windows.Forms.TextBox MarcaBox;
        private System.Windows.Forms.TextBox PlacaBox;
        private System.Windows.Forms.TextBox VagasBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox qtdpassageiros;
        private System.Windows.Forms.TextBox IdBox;
    }
}

