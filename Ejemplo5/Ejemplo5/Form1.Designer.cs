namespace Ejemplo3
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listbArreglo = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCalculo1 = new System.Windows.Forms.TextBox();
            this.txtCalculo2 = new System.Windows.Forms.TextBox();
            this.txtCalculo3 = new System.Windows.Forms.TextBox();
            this.txtCalculo4 = new System.Windows.Forms.TextBox();
            this.btnCalc1 = new System.Windows.Forms.Button();
            this.btnCalc2 = new System.Windows.Forms.Button();
            this.btnCalculo3 = new System.Windows.Forms.Button();
            this.btnCalculo4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un valor al arreglo";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(194, 34);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnIngresar.Location = new System.Drawing.Point(328, 26);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(86, 32);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalculo4);
            this.groupBox1.Controls.Add(this.btnCalculo3);
            this.groupBox1.Controls.Add(this.btnCalc2);
            this.groupBox1.Controls.Add(this.btnCalc1);
            this.groupBox1.Controls.Add(this.txtCalculo4);
            this.groupBox1.Controls.Add(this.txtCalculo3);
            this.groupBox1.Controls.Add(this.txtCalculo2);
            this.groupBox1.Controls.Add(this.txtCalculo1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(328, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 317);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPERACIONES CON ARREGLO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número mayor de pares negativos";
            // 
            // listbArreglo
            // 
            this.listbArreglo.FormattingEnabled = true;
            this.listbArreglo.Location = new System.Drawing.Point(73, 133);
            this.listbArreglo.Name = "listbArreglo";
            this.listbArreglo.Size = new System.Drawing.Size(169, 264);
            this.listbArreglo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Porcentaje de ceros en el arreglo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Promedio de impares positivos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mayor de los pares positivos";
            // 
            // txtCalculo1
            // 
            this.txtCalculo1.Location = new System.Drawing.Point(227, 44);
            this.txtCalculo1.Name = "txtCalculo1";
            this.txtCalculo1.ReadOnly = true;
            this.txtCalculo1.Size = new System.Drawing.Size(100, 20);
            this.txtCalculo1.TabIndex = 4;
            // 
            // txtCalculo2
            // 
            this.txtCalculo2.Location = new System.Drawing.Point(227, 87);
            this.txtCalculo2.Name = "txtCalculo2";
            this.txtCalculo2.ReadOnly = true;
            this.txtCalculo2.Size = new System.Drawing.Size(100, 20);
            this.txtCalculo2.TabIndex = 5;
            // 
            // txtCalculo3
            // 
            this.txtCalculo3.Location = new System.Drawing.Point(227, 136);
            this.txtCalculo3.Name = "txtCalculo3";
            this.txtCalculo3.ReadOnly = true;
            this.txtCalculo3.Size = new System.Drawing.Size(100, 20);
            this.txtCalculo3.TabIndex = 6;
            // 
            // txtCalculo4
            // 
            this.txtCalculo4.Location = new System.Drawing.Point(227, 179);
            this.txtCalculo4.Name = "txtCalculo4";
            this.txtCalculo4.ReadOnly = true;
            this.txtCalculo4.Size = new System.Drawing.Size(100, 20);
            this.txtCalculo4.TabIndex = 7;
            // 
            // btnCalc1
            // 
            this.btnCalc1.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCalc1.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCalc1.Location = new System.Drawing.Point(350, 42);
            this.btnCalc1.Name = "btnCalc1";
            this.btnCalc1.Size = new System.Drawing.Size(75, 23);
            this.btnCalc1.TabIndex = 8;
            this.btnCalc1.Text = "Mostrar";
            this.btnCalc1.UseVisualStyleBackColor = false;
            this.btnCalc1.Click += new System.EventHandler(this.btnCalc1_Click);
            // 
            // btnCalc2
            // 
            this.btnCalc2.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCalc2.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCalc2.Location = new System.Drawing.Point(350, 84);
            this.btnCalc2.Name = "btnCalc2";
            this.btnCalc2.Size = new System.Drawing.Size(75, 23);
            this.btnCalc2.TabIndex = 9;
            this.btnCalc2.Text = "Mostrar";
            this.btnCalc2.UseVisualStyleBackColor = false;
            this.btnCalc2.Click += new System.EventHandler(this.btnCalc2_Click);
            // 
            // btnCalculo3
            // 
            this.btnCalculo3.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCalculo3.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCalculo3.Location = new System.Drawing.Point(350, 134);
            this.btnCalculo3.Name = "btnCalculo3";
            this.btnCalculo3.Size = new System.Drawing.Size(75, 23);
            this.btnCalculo3.TabIndex = 10;
            this.btnCalculo3.Text = "Mostrar";
            this.btnCalculo3.UseVisualStyleBackColor = false;
            this.btnCalculo3.Click += new System.EventHandler(this.btnCalculo3_Click);
            // 
            // btnCalculo4
            // 
            this.btnCalculo4.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCalculo4.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCalculo4.Location = new System.Drawing.Point(350, 179);
            this.btnCalculo4.Name = "btnCalculo4";
            this.btnCalculo4.Size = new System.Drawing.Size(75, 23);
            this.btnCalculo4.TabIndex = 11;
            this.btnCalculo4.Text = "Mostrar";
            this.btnCalculo4.UseVisualStyleBackColor = false;
            this.btnCalculo4.Click += new System.EventHandler(this.btnCalculo4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listbArreglo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listbArreglo;
        private System.Windows.Forms.Button btnCalc1;
        private System.Windows.Forms.TextBox txtCalculo4;
        private System.Windows.Forms.TextBox txtCalculo3;
        private System.Windows.Forms.TextBox txtCalculo2;
        private System.Windows.Forms.TextBox txtCalculo1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculo4;
        private System.Windows.Forms.Button btnCalculo3;
        private System.Windows.Forms.Button btnCalc2;
    }
}

