namespace Asignacion04_00000253313
{
    partial class Winform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Winform));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXi = new System.Windows.Forms.TextBox();
            this.txtXf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtErrorMaximo = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.radbtnBiseccion = new System.Windows.Forms.RadioButton();
            this.radbtnReglaFalsa = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa el valor de la xi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa el valor de xf";
            // 
            // txtXi
            // 
            this.txtXi.Location = new System.Drawing.Point(28, 93);
            this.txtXi.Name = "txtXi";
            this.txtXi.Size = new System.Drawing.Size(311, 22);
            this.txtXi.TabIndex = 2;
            // 
            // txtXf
            // 
            this.txtXf.Location = new System.Drawing.Point(28, 171);
            this.txtXf.Name = "txtXf";
            this.txtXf.Size = new System.Drawing.Size(311, 22);
            this.txtXf.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingresa el Error Aproximado Maximo";
            // 
            // txtErrorMaximo
            // 
            this.txtErrorMaximo.Location = new System.Drawing.Point(28, 248);
            this.txtErrorMaximo.Name = "txtErrorMaximo";
            this.txtErrorMaximo.Size = new System.Drawing.Size(311, 22);
            this.txtErrorMaximo.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(95, 291);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(135, 39);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(402, 68);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.RowHeadersWidth = 51;
            this.dgvResultado.RowTemplate.Height = 24;
            this.dgvResultado.Size = new System.Drawing.Size(363, 231);
            this.dgvResultado.TabIndex = 7;
            // 
            // radbtnBiseccion
            // 
            this.radbtnBiseccion.AutoSize = true;
            this.radbtnBiseccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnBiseccion.Location = new System.Drawing.Point(467, 349);
            this.radbtnBiseccion.Name = "radbtnBiseccion";
            this.radbtnBiseccion.Size = new System.Drawing.Size(206, 24);
            this.radbtnBiseccion.TabIndex = 8;
            this.radbtnBiseccion.TabStop = true;
            this.radbtnBiseccion.Text = "Metodo de Bisección";
            this.radbtnBiseccion.UseVisualStyleBackColor = true;
            // 
            // radbtnReglaFalsa
            // 
            this.radbtnReglaFalsa.AutoSize = true;
            this.radbtnReglaFalsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnReglaFalsa.Location = new System.Drawing.Point(467, 313);
            this.radbtnReglaFalsa.Name = "radbtnReglaFalsa";
            this.radbtnReglaFalsa.Size = new System.Drawing.Size(244, 24);
            this.radbtnReglaFalsa.TabIndex = 9;
            this.radbtnReglaFalsa.TabStop = true;
            this.radbtnReglaFalsa.Text = "Metodo de la Regla Falsa";
            this.radbtnReglaFalsa.UseVisualStyleBackColor = true;
            // 
            // Winform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radbtnReglaFalsa);
            this.Controls.Add(this.radbtnBiseccion);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtErrorMaximo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtXf);
            this.Controls.Add(this.txtXi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Winform";
            this.Text = "Implementacion de Metodos de Raices de Funciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXi;
        private System.Windows.Forms.TextBox txtXf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtErrorMaximo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.RadioButton radbtnBiseccion;
        private System.Windows.Forms.RadioButton radbtnReglaFalsa;
    }
}

