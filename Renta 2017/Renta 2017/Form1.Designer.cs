namespace Renta_2017
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtSalarioNominal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSalarioNominal = new System.Windows.Forms.Label();
            this.txtSalarioFinal = new System.Windows.Forms.TextBox();
            this.txtRenta = new System.Windows.Forms.TextBox();
            this.lblSalarioDescuento = new System.Windows.Forms.Label();
            this.lblRenta = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblTramo = new System.Windows.Forms.Label();
            this.lblExceso = new System.Windows.Forms.Label();
            this.lblCuota = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(10, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(363, 34);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculo de impuesto  sobre la renta";
            // 
            // txtSalarioNominal
            // 
            this.txtSalarioNominal.Font = new System.Drawing.Font("Poppins", 9F);
            this.txtSalarioNominal.Location = new System.Drawing.Point(10, 73);
            this.txtSalarioNominal.Name = "txtSalarioNominal";
            this.txtSalarioNominal.Size = new System.Drawing.Size(114, 25);
            this.txtSalarioNominal.TabIndex = 2;
            this.txtSalarioNominal.Tag = "";
            this.txtSalarioNominal.Enter += new System.EventHandler(this.txtSalarioNominal_Enter);
            this.txtSalarioNominal.Leave += new System.EventHandler(this.txtSalarioNominal_Leave);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnCalcular.Location = new System.Drawing.Point(10, 102);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(64, 24);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSalarioNominal
            // 
            this.lblSalarioNominal.AutoSize = true;
            this.lblSalarioNominal.Font = new System.Drawing.Font("Poppins", 9F);
            this.lblSalarioNominal.Location = new System.Drawing.Point(10, 49);
            this.lblSalarioNominal.Name = "lblSalarioNominal";
            this.lblSalarioNominal.Size = new System.Drawing.Size(104, 22);
            this.lblSalarioNominal.TabIndex = 3;
            this.lblSalarioNominal.Text = "Salario nominal";
            // 
            // txtSalarioFinal
            // 
            this.txtSalarioFinal.Enabled = false;
            this.txtSalarioFinal.Font = new System.Drawing.Font("Poppins", 9F);
            this.txtSalarioFinal.Location = new System.Drawing.Point(179, 73);
            this.txtSalarioFinal.Name = "txtSalarioFinal";
            this.txtSalarioFinal.Size = new System.Drawing.Size(86, 25);
            this.txtSalarioFinal.TabIndex = 4;
            // 
            // txtRenta
            // 
            this.txtRenta.Enabled = false;
            this.txtRenta.Font = new System.Drawing.Font("Poppins", 9F);
            this.txtRenta.Location = new System.Drawing.Point(179, 125);
            this.txtRenta.Name = "txtRenta";
            this.txtRenta.Size = new System.Drawing.Size(86, 25);
            this.txtRenta.TabIndex = 5;
            // 
            // lblSalarioDescuento
            // 
            this.lblSalarioDescuento.AutoSize = true;
            this.lblSalarioDescuento.Font = new System.Drawing.Font("Poppins", 9F);
            this.lblSalarioDescuento.Location = new System.Drawing.Point(179, 49);
            this.lblSalarioDescuento.Name = "lblSalarioDescuento";
            this.lblSalarioDescuento.Size = new System.Drawing.Size(210, 22);
            this.lblSalarioDescuento.TabIndex = 6;
            this.lblSalarioDescuento.Text = "Salarios con descuento AFP e ISSS";
            // 
            // lblRenta
            // 
            this.lblRenta.AutoSize = true;
            this.lblRenta.Font = new System.Drawing.Font("Poppins", 9F);
            this.lblRenta.Location = new System.Drawing.Point(179, 102);
            this.lblRenta.Name = "lblRenta";
            this.lblRenta.Size = new System.Drawing.Size(150, 22);
            this.lblRenta.TabIndex = 7;
            this.lblRenta.Text = "Impuesto sobre la renta";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(10, 167);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(134, 34);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Informacion";
            // 
            // lblTramo
            // 
            this.lblTramo.AutoSize = true;
            this.lblTramo.Font = new System.Drawing.Font("Poppins", 9F);
            this.lblTramo.Location = new System.Drawing.Point(10, 201);
            this.lblTramo.Name = "lblTramo";
            this.lblTramo.Size = new System.Drawing.Size(56, 22);
            this.lblTramo.TabIndex = 9;
            this.lblTramo.Text = "TRAMO :";
            // 
            // lblExceso
            // 
            this.lblExceso.AutoSize = true;
            this.lblExceso.Font = new System.Drawing.Font("Poppins", 9F);
            this.lblExceso.Location = new System.Drawing.Point(10, 232);
            this.lblExceso.Name = "lblExceso";
            this.lblExceso.Size = new System.Drawing.Size(99, 22);
            this.lblExceso.TabIndex = 10;
            this.lblExceso.Text = "SOBRE EXCESO :";
            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.Font = new System.Drawing.Font("Poppins", 9F);
            this.lblCuota.Location = new System.Drawing.Point(10, 295);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(82, 22);
            this.lblCuota.TabIndex = 11;
            this.lblCuota.Text = "CUOTA FIJA :";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Poppins", 9F);
            this.lblPorcentaje.Location = new System.Drawing.Point(10, 263);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(148, 22);
            this.lblPorcentaje.TabIndex = 12;
            this.lblPorcentaje.Text = "PORCENTAJE APLICADO :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 338);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.lblCuota);
            this.Controls.Add(this.lblExceso);
            this.Controls.Add(this.lblTramo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblRenta);
            this.Controls.Add(this.lblSalarioDescuento);
            this.Controls.Add(this.txtRenta);
            this.Controls.Add(this.txtSalarioFinal);
            this.Controls.Add(this.lblSalarioNominal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalarioNominal);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtSalarioNominal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSalarioNominal;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtRenta;
        private System.Windows.Forms.Label lblSalarioDescuento;
        private System.Windows.Forms.Label lblRenta;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblTramo;
        private System.Windows.Forms.Label lblExceso;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.TextBox txtSalarioFinal;
    }
}

