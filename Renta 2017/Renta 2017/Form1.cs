using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renta_2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetPlaceholder();
        }

        private void SetPlaceholder()
        {
            txtSalarioNominal.Text = "Ingrese su salario";
            txtSalarioNominal.ForeColor = Color.Gray;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double salarioNominal, afp, isss, descuento, salarioFinal, sobreExceso, exceso, cuota, renta, salarioNeto;

            if (txtSalarioNominal.Text == "0")
            {
                MessageBox.Show("Error ingrese un valor mayor a 0.", "Debe ingresar un valor valido.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioNominal.Focus();
                return;
            }
            try
            {
                salarioNominal = Convert.ToDouble(txtSalarioNominal.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico ", "Error valor Invalido.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            afp = salarioNominal * .0725;
            isss = salarioNominal * .03;
            if (isss > 30)
            {
                isss = 30;
            }
            descuento = afp + isss;
            salarioFinal = salarioNominal - descuento;
            txtSalarioFinal.Text = Math.Round(salarioFinal, 2).ToString();

            switch (salarioFinal)
            {
                case var Tramo1 when salarioFinal >= 0.01 && salarioFinal <= 472.00:
                    renta = 0;
                    salarioNeto = salarioFinal - renta;
                    txtRenta.Text = renta.ToString();
                    lblTramo.Text = "TRAMO: 1";
                    lblExceso.Text = "SOBRE EXCESO: NO APLICA";
                    lblPorcentaje.Text = "PORCENTAJE APLICADO: NO APLICA";
                    lblCuota.Text = "CUOTA FIJA: NO APLICA";
                    lblsalarioNeto.Text = ("SALARIO LÍQUIDO: $" + Math.Round(salarioNeto, 2));
                    break;
                case var Tramo2 when salarioFinal >= 472.01 && salarioFinal <= 895.24:
                    sobreExceso = 472;
                    cuota = 17.67;
                    exceso = salarioFinal - sobreExceso;
                    renta = (exceso * .1) + cuota;
                    salarioNeto = salarioFinal - renta;
                    txtRenta.Text = Math.Round(renta, 2).ToString();
                    lblTramo.Text = "TRAMO: 2";
                    lblExceso.Text = ("SOBRE EXCESO: " + Math.Round(exceso, 2));
                    lblPorcentaje.Text = "PORCENTAJE APLICADO: 10%";
                    lblCuota.Text = "CUOTA FIJA: $17.67";
                    lblsalarioNeto.Text = ("SALARIO LÍQUIDO: $" + Math.Round(salarioNeto, 2));
                    break;
                case var Tramo3 when salarioFinal >= 895.25 && salarioFinal <= 2038.10:
                    sobreExceso = 895.24;
                    cuota = 60;
                    exceso = salarioFinal - sobreExceso;
                    renta = (exceso * .2) + cuota;
                    salarioNeto = salarioFinal - renta;
                    txtRenta.Text = Math.Round(renta, 2).ToString();
                    lblTramo.Text = "TRAMO: 3";
                    lblExceso.Text = ("SOBRE EXCESO: " + Math.Round(exceso, 2));
                    lblPorcentaje.Text = "PORCENTAJE APLICADO: 20%";
                    lblCuota.Text = "CUOTA FIJA: $60.00";
                    lblsalarioNeto.Text = ("SALARIO LÍQUIDO: $" + Math.Round(salarioNeto, 2));
                    break;
                case var Tramo4 when salarioFinal >= 2038.11:
                    sobreExceso = 2038.10;
                    cuota = 288.57;
                    exceso = salarioFinal - sobreExceso;
                    renta = (exceso * .3) + cuota;
                    salarioNeto = salarioFinal - renta;
                    txtRenta.Text = Math.Round(renta, 2).ToString();
                    lblTramo.Text = "TRAMO: 4";
                    lblExceso.Text = ("SOBRE EXCESO: " + Math.Round(exceso, 2));
                    lblPorcentaje.Text = "PORCENTAJE APLICADO: 30%";
                    lblCuota.Text = "CUOTA FIJA: $288.57";
                    lblsalarioNeto.Text = ("SALARIO LÍQUIDO: $" + Math.Round(salarioNeto, 2));
                    break;
                default:
                    Console.WriteLine("\tEl valor ingresado no es valido");
                    break;
            }


        }

        private void txtSalarioNominal_Enter(object sender, EventArgs e)
        {
            if (txtSalarioNominal.Text == "Ingrese su salario")
            {
                txtSalarioNominal.Text = string.Empty;
                txtSalarioNominal.ForeColor = Color.Black;
            }
        }

        private void txtSalarioNominal_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtSalarioNominal.Text))
            {
                SetPlaceholder();
            }

        }
    }
}
