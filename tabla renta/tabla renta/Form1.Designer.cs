namespace tabla_renta
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
            lblTitulo = new Label();
            txtSalarioNominal = new TextBox();
            btnCalcular = new Button();
            lblSalarioNominal = new Label();
            txtDescuento = new TextBox();
            txtRenta = new TextBox();
            lblSalarioDescuento = new Label();
            lblRenta = new Label();
            lblInfo = new Label();
            lblTramo = new Label();
            lblExceso = new Label();
            lblCuota = new Label();
            lblPorcentaje = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(363, 34);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Calculo de impuesto  sobre la renta";
            // 
            // txtSalarioNominal
            // 
            txtSalarioNominal.Font = new Font("Poppins", 9F);
            txtSalarioNominal.Location = new Point(12, 81);
            txtSalarioNominal.Name = "txtSalarioNominal";
            txtSalarioNominal.Size = new Size(120, 25);
            txtSalarioNominal.TabIndex = 2;
            txtSalarioNominal.Tag = "";
            txtSalarioNominal.Enter += txtSalarioNominal_Enter;
            txtSalarioNominal.Leave += txtSalarioNominal_Leave;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Poppins", 9F);
            btnCalcular.Location = new Point(12, 114);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 28);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lblSalarioNominal
            // 
            lblSalarioNominal.AutoSize = true;
            lblSalarioNominal.Font = new Font("Poppins", 9F);
            lblSalarioNominal.Location = new Point(12, 57);
            lblSalarioNominal.Name = "lblSalarioNominal";
            lblSalarioNominal.Size = new Size(104, 22);
            lblSalarioNominal.TabIndex = 3;
            lblSalarioNominal.Text = "Salario nominal";
            // 
            // txtDescuento
            // 
            txtDescuento.Enabled = false;
            txtDescuento.Font = new Font("Poppins", 9F);
            txtDescuento.Location = new Point(209, 81);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(100, 25);
            txtDescuento.TabIndex = 4;
            // 
            // txtRenta
            // 
            txtRenta.Enabled = false;
            txtRenta.Font = new Font("Poppins", 9F);
            txtRenta.Location = new Point(209, 139);
            txtRenta.Name = "txtRenta";
            txtRenta.Size = new Size(100, 25);
            txtRenta.TabIndex = 5;
            // 
            // lblSalarioDescuento
            // 
            lblSalarioDescuento.AutoSize = true;
            lblSalarioDescuento.Font = new Font("Poppins", 9F);
            lblSalarioDescuento.Location = new Point(209, 57);
            lblSalarioDescuento.Name = "lblSalarioDescuento";
            lblSalarioDescuento.Size = new Size(210, 22);
            lblSalarioDescuento.TabIndex = 6;
            lblSalarioDescuento.Text = "Salarios con descuento AFP e ISSS";
            // 
            // lblRenta
            // 
            lblRenta.AutoSize = true;
            lblRenta.Font = new Font("Poppins", 9F);
            lblRenta.Location = new Point(209, 114);
            lblRenta.Name = "lblRenta";
            lblRenta.Size = new Size(150, 22);
            lblRenta.TabIndex = 7;
            lblRenta.Text = "Impuesto sobre la renta";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Poppins SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfo.Location = new Point(12, 193);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(134, 34);
            lblInfo.TabIndex = 8;
            lblInfo.Text = "Informacion";
            // 
            // lblTramo
            // 
            lblTramo.AutoSize = true;
            lblTramo.Font = new Font("Poppins", 9F);
            lblTramo.Location = new Point(12, 232);
            lblTramo.Name = "lblTramo";
            lblTramo.Size = new Size(56, 22);
            lblTramo.TabIndex = 9;
            lblTramo.Text = "TRAMO :";
            // 
            // lblExceso
            // 
            lblExceso.AutoSize = true;
            lblExceso.Font = new Font("Poppins", 9F);
            lblExceso.Location = new Point(12, 268);
            lblExceso.Name = "lblExceso";
            lblExceso.Size = new Size(99, 22);
            lblExceso.TabIndex = 10;
            lblExceso.Text = "SOBRE EXCESO :";
            // 
            // lblCuota
            // 
            lblCuota.AutoSize = true;
            lblCuota.Font = new Font("Poppins", 9F);
            lblCuota.Location = new Point(12, 340);
            lblCuota.Name = "lblCuota";
            lblCuota.Size = new Size(82, 22);
            lblCuota.TabIndex = 11;
            lblCuota.Text = "CUOTA FIJA :";
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Font = new Font("Poppins", 9F);
            lblPorcentaje.Location = new Point(12, 304);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(148, 22);
            lblPorcentaje.TabIndex = 12;
            lblPorcentaje.Text = "PORCENTAJE APLICADO :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 380);
            Controls.Add(lblPorcentaje);
            Controls.Add(lblCuota);
            Controls.Add(lblExceso);
            Controls.Add(lblTramo);
            Controls.Add(lblInfo);
            Controls.Add(lblRenta);
            Controls.Add(lblSalarioDescuento);
            Controls.Add(txtRenta);
            Controls.Add(txtDescuento);
            Controls.Add(lblSalarioNominal);
            Controls.Add(btnCalcular);
            Controls.Add(txtSalarioNominal);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtSalarioNominal;
        private Button btnCalcular;
        private Label lblSalarioNominal;
        private TextBox txtDescuento;
        private TextBox txtRenta;
        private Label lblSalarioDescuento;
        private Label lblRenta;
        private Label lblInfo;
        private Label lblTramo;
        private Label lblExceso;
        private Label lblCuota;
        private Label lblPorcentaje;
    }
}
