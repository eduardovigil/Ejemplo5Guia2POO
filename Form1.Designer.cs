namespace Guia2_Ejemplo5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lblArreglo = new System.Windows.Forms.Label();
            this.txtnegativo = new System.Windows.Forms.TextBox();
            this.lsbArreglo = new System.Windows.Forms.ListBox();
            this.grbArreglo = new System.Windows.Forms.GroupBox();
            this.lblnegativo = new System.Windows.Forms.Label();
            this.lblprocentaje = new System.Windows.Forms.Label();
            this.lblpositivos = new System.Windows.Forms.Label();
            this.lblmayposi = new System.Windows.Forms.Label();
            this.txtprocentaje = new System.Windows.Forms.TextBox();
            this.txtpositivos = new System.Windows.Forms.TextBox();
            this.txtmayoposi = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnmostrar1 = new System.Windows.Forms.Button();
            this.btnmostrar2 = new System.Windows.Forms.Button();
            this.btnmostrar3 = new System.Windows.Forms.Button();
            this.btnmostrar4 = new System.Windows.Forms.Button();
            this.grbArreglo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(309, 12);
            this.txtnumero.Multiline = true;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 90);
            this.txtnumero.TabIndex = 0;
            // 
            // lblArreglo
            // 
            this.lblArreglo.AutoSize = true;
            this.lblArreglo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArreglo.Location = new System.Drawing.Point(36, 44);
            this.lblArreglo.Name = "lblArreglo";
            this.lblArreglo.Size = new System.Drawing.Size(267, 24);
            this.lblArreglo.TabIndex = 1;
            this.lblArreglo.Text = "Ingrese el valor del arreglo:";
            // 
            // txtnegativo
            // 
            this.txtnegativo.Location = new System.Drawing.Point(237, 33);
            this.txtnegativo.Name = "txtnegativo";
            this.txtnegativo.ReadOnly = true;
            this.txtnegativo.Size = new System.Drawing.Size(87, 20);
            this.txtnegativo.TabIndex = 2;
            // 
            // lsbArreglo
            // 
            this.lsbArreglo.FormattingEnabled = true;
            this.lsbArreglo.Location = new System.Drawing.Point(40, 84);
            this.lsbArreglo.Name = "lsbArreglo";
            this.lsbArreglo.Size = new System.Drawing.Size(183, 160);
            this.lsbArreglo.TabIndex = 3;
            // 
            // grbArreglo
            // 
            this.grbArreglo.Controls.Add(this.btnmostrar4);
            this.grbArreglo.Controls.Add(this.btnmostrar3);
            this.grbArreglo.Controls.Add(this.btnmostrar2);
            this.grbArreglo.Controls.Add(this.btnmostrar1);
            this.grbArreglo.Controls.Add(this.txtmayoposi);
            this.grbArreglo.Controls.Add(this.txtpositivos);
            this.grbArreglo.Controls.Add(this.txtprocentaje);
            this.grbArreglo.Controls.Add(this.lblmayposi);
            this.grbArreglo.Controls.Add(this.lblpositivos);
            this.grbArreglo.Controls.Add(this.lblprocentaje);
            this.grbArreglo.Controls.Add(this.lblnegativo);
            this.grbArreglo.Controls.Add(this.txtnegativo);
            this.grbArreglo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbArreglo.Location = new System.Drawing.Point(229, 108);
            this.grbArreglo.Name = "grbArreglo";
            this.grbArreglo.Size = new System.Drawing.Size(424, 141);
            this.grbArreglo.TabIndex = 4;
            this.grbArreglo.TabStop = false;
            this.grbArreglo.Text = "Operaciones Con Arreglo:";
            // 
            // lblnegativo
            // 
            this.lblnegativo.AutoSize = true;
            this.lblnegativo.Location = new System.Drawing.Point(15, 33);
            this.lblnegativo.Name = "lblnegativo";
            this.lblnegativo.Size = new System.Drawing.Size(216, 13);
            this.lblnegativo.TabIndex = 3;
            this.lblnegativo.Text = "Números mayores de pares negativo:";
            // 
            // lblprocentaje
            // 
            this.lblprocentaje.AutoSize = true;
            this.lblprocentaje.Location = new System.Drawing.Point(15, 59);
            this.lblprocentaje.Name = "lblprocentaje";
            this.lblprocentaje.Size = new System.Drawing.Size(186, 13);
            this.lblprocentaje.TabIndex = 4;
            this.lblprocentaje.Text = "Porcentaje de ceros en arreglo:";
            // 
            // lblpositivos
            // 
            this.lblpositivos.AutoSize = true;
            this.lblpositivos.Location = new System.Drawing.Point(15, 85);
            this.lblpositivos.Name = "lblpositivos";
            this.lblpositivos.Size = new System.Drawing.Size(182, 13);
            this.lblpositivos.TabIndex = 5;
            this.lblpositivos.Text = "Promedio de impares positivos:";
            // 
            // lblmayposi
            // 
            this.lblmayposi.AutoSize = true;
            this.lblmayposi.Location = new System.Drawing.Point(15, 110);
            this.lblmayposi.Name = "lblmayposi";
            this.lblmayposi.Size = new System.Drawing.Size(172, 13);
            this.lblmayposi.TabIndex = 6;
            this.lblmayposi.Text = "Mayor de los pares positivos:";
            // 
            // txtprocentaje
            // 
            this.txtprocentaje.Location = new System.Drawing.Point(237, 59);
            this.txtprocentaje.Name = "txtprocentaje";
            this.txtprocentaje.ReadOnly = true;
            this.txtprocentaje.Size = new System.Drawing.Size(87, 20);
            this.txtprocentaje.TabIndex = 7;
            // 
            // txtpositivos
            // 
            this.txtpositivos.Location = new System.Drawing.Point(237, 86);
            this.txtpositivos.Name = "txtpositivos";
            this.txtpositivos.ReadOnly = true;
            this.txtpositivos.Size = new System.Drawing.Size(87, 20);
            this.txtpositivos.TabIndex = 8;
            // 
            // txtmayoposi
            // 
            this.txtmayoposi.Location = new System.Drawing.Point(237, 110);
            this.txtmayoposi.Name = "txtmayoposi";
            this.txtmayoposi.ReadOnly = true;
            this.txtmayoposi.Size = new System.Drawing.Size(87, 20);
            this.txtmayoposi.TabIndex = 9;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(442, 29);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(101, 58);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnmostrar1
            // 
            this.btnmostrar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnmostrar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar1.Location = new System.Drawing.Point(333, 29);
            this.btnmostrar1.Name = "btnmostrar1";
            this.btnmostrar1.Size = new System.Drawing.Size(85, 25);
            this.btnmostrar1.TabIndex = 10;
            this.btnmostrar1.Text = "Mostrar";
            this.btnmostrar1.UseVisualStyleBackColor = false;
            this.btnmostrar1.Click += new System.EventHandler(this.btnmostrar1_Click);
            // 
            // btnmostrar2
            // 
            this.btnmostrar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnmostrar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar2.Location = new System.Drawing.Point(333, 55);
            this.btnmostrar2.Name = "btnmostrar2";
            this.btnmostrar2.Size = new System.Drawing.Size(85, 25);
            this.btnmostrar2.TabIndex = 11;
            this.btnmostrar2.Text = "Mostrar";
            this.btnmostrar2.UseVisualStyleBackColor = false;
            this.btnmostrar2.Click += new System.EventHandler(this.btnmostrar2_Click);
            // 
            // btnmostrar3
            // 
            this.btnmostrar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnmostrar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar3.Location = new System.Drawing.Point(333, 81);
            this.btnmostrar3.Name = "btnmostrar3";
            this.btnmostrar3.Size = new System.Drawing.Size(85, 25);
            this.btnmostrar3.TabIndex = 12;
            this.btnmostrar3.Text = "Mostrar";
            this.btnmostrar3.UseVisualStyleBackColor = false;
            this.btnmostrar3.Click += new System.EventHandler(this.btnmostrar3_Click);
            // 
            // btnmostrar4
            // 
            this.btnmostrar4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnmostrar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar4.Location = new System.Drawing.Point(333, 107);
            this.btnmostrar4.Name = "btnmostrar4";
            this.btnmostrar4.Size = new System.Drawing.Size(85, 25);
            this.btnmostrar4.TabIndex = 13;
            this.btnmostrar4.Text = "Mostrar";
            this.btnmostrar4.UseVisualStyleBackColor = false;
            this.btnmostrar4.Click += new System.EventHandler(this.btnmostrar4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 264);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.grbArreglo);
            this.Controls.Add(this.lsbArreglo);
            this.Controls.Add(this.lblArreglo);
            this.Controls.Add(this.txtnumero);
            this.Name = "Form1";
            this.Text = "Cálculos Básicos";
            this.grbArreglo.ResumeLayout(false);
            this.grbArreglo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lblArreglo;
        private System.Windows.Forms.TextBox txtnegativo;
        private System.Windows.Forms.ListBox lsbArreglo;
        private System.Windows.Forms.GroupBox grbArreglo;
        private System.Windows.Forms.Button btnmostrar4;
        private System.Windows.Forms.Button btnmostrar3;
        private System.Windows.Forms.Button btnmostrar2;
        private System.Windows.Forms.Button btnmostrar1;
        private System.Windows.Forms.TextBox txtmayoposi;
        private System.Windows.Forms.TextBox txtpositivos;
        private System.Windows.Forms.TextBox txtprocentaje;
        private System.Windows.Forms.Label lblmayposi;
        private System.Windows.Forms.Label lblpositivos;
        private System.Windows.Forms.Label lblprocentaje;
        private System.Windows.Forms.Label lblnegativo;
        private System.Windows.Forms.Button btnIngresar;
    }
}

