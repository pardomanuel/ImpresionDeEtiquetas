using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Collections;

namespace ModuloImpresion
{
    public partial class FrmPrincipal : Form
    {
        bool bandera = true;
        public FrmPrincipal()
        {
            
            InitializeComponent();
            this.cmbMaterial.Text = "Etiquetas";
            this.cmbPoliamidaSatin.SelectedIndex = 0;
            this.cmbRibbon.SelectedIndex = 0;
            this.cmbBuje.SelectedIndex = 0;
            this.nCantCopias.Value = 1;
            System.Diagnostics.Process.Start(@"C:\Users\Gabriela\Desktop\softImpresiones\inicio.bat");
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            /*COMANDOS PARA IMPRIMIR
             NET USE LPT1 \\USER-PC\impresor /PERSISTENT:YES
             el archivo .bat 
             print LPT1 "C:\Users\user\Desktop\ZPL\archivo.prn"
             */
            if(this.cmbMaterial.Text == "Etiquetas")
            {
                while(string.IsNullOrWhiteSpace(this.txtEmpresa.Text) && string.IsNullOrWhiteSpace(this.txtOrden.Text) && string.IsNullOrWhiteSpace(this.txtTipo.Text) && string.IsNullOrWhiteSpace(this.txtAncho.Text) && string.IsNullOrWhiteSpace(this.txtAlto.Text) && string.IsNullOrWhiteSpace(this.txtEtiqXRollo.Text) && string.IsNullOrWhiteSpace(this.txtEtiqXRollo.Text))
                {
                    MessageBox.Show("Error, Tiene que completar todos los campos");
                    bandera = false;
                    break;
                }
                if (string.IsNullOrWhiteSpace(this.txtEmpresa.Text) && string.IsNullOrWhiteSpace(this.txtOrden.Text) && string.IsNullOrWhiteSpace(this.txtTipo.Text) && string.IsNullOrWhiteSpace(this.txtAncho.Text) && string.IsNullOrWhiteSpace(this.txtAlto.Text) && string.IsNullOrWhiteSpace(this.txtEtiqXRollo.Text) && string.IsNullOrWhiteSpace(this.txtEtiqXRollo.Text))
                {

                }
                else { bandera = true; }
            }
            if (this.cmbMaterial.Text == "Ribbon")
            {
                while (string.IsNullOrWhiteSpace(this.txtEmpresa.Text) && string.IsNullOrWhiteSpace(this.txtOrden.Text) && string.IsNullOrWhiteSpace(this.txtAncho.Text) && string.IsNullOrWhiteSpace(this.txtAlto.Text) && string.IsNullOrWhiteSpace(this.txtCantidad.Text))
                {
                    MessageBox.Show("Error, Tiene que completar todos los campos");
                    bandera = false;
                    break;
                }
                if (string.IsNullOrWhiteSpace(this.txtEmpresa.Text) && string.IsNullOrWhiteSpace(this.txtOrden.Text) && string.IsNullOrWhiteSpace(this.txtAncho.Text) && string.IsNullOrWhiteSpace(this.txtAlto.Text) && string.IsNullOrWhiteSpace(this.txtCantidad.Text))
                {

                }
                else { bandera = true; }
            }
            if (this.cmbMaterial.Text == "Poliamida / Satin")
            {
                while (string.IsNullOrWhiteSpace(this.txtEmpresa.Text) && string.IsNullOrWhiteSpace(this.txtOrden.Text) && string.IsNullOrWhiteSpace(this.txtAncho.Text) && string.IsNullOrWhiteSpace(this.txtAlto.Text) && string.IsNullOrWhiteSpace(this.txtCantidad.Text))
                {
                    MessageBox.Show("Error, Tiene que completar todos los campos");
                    bandera = false;
                    break;
                }
                if (string.IsNullOrWhiteSpace(this.txtEmpresa.Text) && string.IsNullOrWhiteSpace(this.txtOrden.Text) && string.IsNullOrWhiteSpace(this.txtAncho.Text) && string.IsNullOrWhiteSpace(this.txtAlto.Text) && string.IsNullOrWhiteSpace(this.txtCantidad.Text))
                {

                }
                else { bandera = true; }
            }

            /*try
            {*/
            //Pass the filepath and filename to the StreamWriter Constructor

            if (this.cmbMaterial.Text == "Etiquetas")
            {
                if (bandera)
                {
                    StreamWriter sw = new StreamWriter("C:\\Users\\Gabriela\\Desktop\\softImpresiones\\archivo.prn");
                    int cantidadEtiquetas = int.Parse(this.txtEtiqXRollo.Text) * int.Parse(this.txtRollosXCaja.Text);
                    sw.WriteLine("CT~~CD,~CC^~CT~");
                    sw.WriteLine("^XA~TA000~JSN^LT0^MNW^MTD^PON^PMN^LH0,0^JMA^PR2,2~SD24^JUS^LRN^CI0^XZ");
                    sw.WriteLine("~DG000.GRF,83200,104,");
                    sw.WriteLine(",:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::P01FoIF0,::::P01F0o01F0,:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::P01FoGFDF0,:P01F0o01");
                    sw.WriteLine("F0,::::::::::::::::::::::::::::::::::::::::::::::::::::::P01F0gY070lY01F0,:P01FnYFE01F0,:P01F0gY070lY01F0,P01F0gY070jW01C0gY01F0,P01F0gY070iK0380gO01C0gY01F0,:P01");
                    sw.WriteLine("F0gY070gQ0380gQ0380gO01C0gY01F0,:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::P01F3FoGF0,:P01F0gY070gQ0380gQ0380gO01C0gY01F0,:::::::::");
                    sw.WriteLine("::::::::::::::::::::::::::::::::P01F0gY0E0gQ0380gQ0380gO01C0gY01F0,::P01F0gY0E0gQ0380gQ01C0gO01C0gY01F0,:::::::::::::::::::::::::::::::::::::::::::::::P01FjOFE0V01C0gO01C");
                    sw.WriteLine("0gY01F0,P01FoFC1F0,P01F0gY0E0gQ0380S01FjOFC1F0,P01F0gY0E0gQ0380gQ01C0gO01C0gY01F0,:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::P01");
                    sw.WriteLine("F0gY0E0gQ0380iI01C0gY01F0,:P01F0iR0380kK01F0,P03FoIF0,:P01FoIF0,::,:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::R01");
                    sw.WriteLine("FoFC0,::,::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::^XA");
                    sw.WriteLine("^MMT");
                    sw.WriteLine("^PW807");
                    sw.WriteLine("^LL0799");
                    sw.WriteLine("^LS0");
                    sw.WriteLine("^FT0,800^XG000.GRF,1,1^FS");
                    sw.WriteLine(@"^FT63,231^A0N,34,43^FH\^FDNRO ORDEN: " + this.txtOrden.Text + "^FS");
                    sw.WriteLine(@"^FT519,232^A0N,34,43^FH\^FDEtiquetas^FS");
                    sw.WriteLine(@"^FT69,321^A0N,44,43^FH\^FDTIPO^FS");
                    sw.WriteLine(@"^FT221,321^A0N,44,43^FH\^FDAncho^FS");
                    sw.WriteLine(@"^FT381,323^A0N,43,45^FH\^FDAlto^FS");
                    sw.WriteLine(@"^FT628,291^A0N,27,31^FH\^FDRollos x^FS");
                    sw.WriteLine(@"^FT628,326^A0N,27,31^FH\^FDCaja^FS");
                    sw.WriteLine(@"^FT49,739^A0N,56,36^FH\^FDwww.timingargentina.com.ar^FS");
                    sw.WriteLine(@"^FT556,746^A0N,56,28^FH\^FD0810-222-6261^FS");
                    sw.WriteLine(@"^FT498,293^A0N,27,31^FH\^FDEtiq. x^FS");
                    sw.WriteLine(@"^FT498,328^A0N,27,31^FH\^FDRollo^FS");
                    sw.WriteLine(@"^FT60,628^A0N,62,50^FH\^FDCantidad de etiquetas: " + cantidadEtiquetas.ToString() + "^FS");
                    sw.WriteLine(@"^FT374,422^A0N,47,45^FH\^FD" + this.txtAlto.Text + "^FS");
                    sw.WriteLine(@"^FT71,177^A0N,48,64^FH\^FD" + this.txtEmpresa.Text + "^FS");
                    sw.WriteLine(@"^FT495,423^A0N,56,28^FH\^FD" + this.txtEtiqXRollo.Text + "^FS");
                    sw.WriteLine(@"^FT56,417^A0N,55,28^FH\^FD" + this.txtTipo.Text + "^FS");
                    sw.WriteLine(@"^FT244,422^A0N,48,43^FH\^FD" + this.txtAncho.Text + "^FS");
                    sw.WriteLine(@"^FT640,421^A0N,43,60^FH\^FD" + this.txtRollosXCaja.Text + "^FS");
                    sw.WriteLine(@"^PQ1,0,1,Y^XZ");
                    sw.WriteLine(@"^XA^ID000.GRF^FS^XZ");

                    //Close the file
                    sw.Close();
                    for (int i = 0; i < this.nCantCopias.Value; i++)
                    {
                        System.Diagnostics.Process.Start(@"C:\Users\Gabriela\Desktop\softImpresiones\archivoBat.bat");
                        Thread.Sleep(2000);
                    }
                }

            }
            else if (this.cmbMaterial.Text == "Ribbon")
            {
                if (bandera)
                {
                    StreamWriter sw = new StreamWriter("C:\\Users\\Gabriela\\Desktop\\softImpresiones\\archivo.prn");
                    sw.WriteLine("CT~~CD,~CC^~CT~");
                    sw.WriteLine("^XA~TA000~JSN^LT0^MNW^MTD^PON^PMN^LH0,0^JMA^PR4,4~SD14^JUS^LRN^CI0^XZ");
                    sw.WriteLine("~DG000.GRF,80000,100,");
                    sw.WriteLine(",:::::::::::::::::::::::::::::::::::::::N01FoLF,::::::N01FC0oH07F,:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                    sw.WriteLine("N01FC0jQ0jSF,N01FoLF,:N01FjSFjQ07F,N01FC0oH07F,:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::N01FoIFC7F,::N01FC0jV0380jI07F,:::N0");
                    sw.WriteLine("1FC0jV0380hH0380gX07F,::N01FC0hK0E0hO0380hH0380gX07F,:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::N01FoJF7F,:N01FC0hK0E0hO0380hH0380gX07F,::::");
                    sw.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::N01FjQFC0K0380hH0380gX07F,N01FoHFE07F,:N01FC0hK070hH03FjOFE07F,N01FC0hK070hO0380hH0380gX07F,::::");
                    sw.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::N01FjRFL0380hH0380gX07F,N01FoLF,:N01FC0hK070hI0jTF,N01FC0hK070hO0380hH0380gX07F,:::::::::::::::::::::::::::::::::::");
                    sw.WriteLine("::::::::::::::::::::::::::::::::::::N01FoLF,::::::,::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::^XA");
                    sw.WriteLine("^MMT");
                    sw.WriteLine("^PW799");
                    sw.WriteLine("^LL0799");
                    sw.WriteLine("^LS0");
                    sw.WriteLine("^FT0,800^XG000.GRF,1,1^FS");
                    sw.WriteLine(@"^FT528,311^A0N,72,69^FH\^FDRIBBON^FS");
                    sw.WriteLine(@"^FT49,403^A0N,47,45^FH\^FDCantidad^FS");
                    sw.WriteLine(@"^FT273,405^A0N,49,48^FH\^FDAncho^FS");
                    sw.WriteLine(@"^FT468,406^A0N,49,48^FH\^FDLargo^FS");
                    sw.WriteLine(@"^FT643,401^A0N,47,52^FH\^FDTipo^FS");
                    sw.WriteLine(@"^FT42,757^A0N,39,31^FH\^FDwww.timingargentina.com.ar^FS");
                    sw.WriteLine(@"^FT489,757^A0N,39,38^FH\^FD0810-222-6261^FS");
                    sw.WriteLine(@"^FT66,308^A0N,69,38^FH\^FDNro de Orden: " + this.txtOrden.Text + "^FS");
                    sw.WriteLine(@"^FT271,500^A0N,60,81^FH\^FD" + this.txtAncho.Text + "^FS");
                    sw.WriteLine(@"^FT63,117^A0N,50,67^FH\^FD" + this.txtEmpresa.Text + "^FS");
                    sw.WriteLine(@"^FT644,491^A0N,56,52^FH\^FD" + this.cmbRibbon.Text + "^FS");
                    sw.WriteLine(@"^FT484,504^A0N,70,67^FH\^FD" + this.txtAlto.Text + "^FS");
                    sw.WriteLine(@"^FT108,493^A0N,57,74^FH\^FD" + this.txtCantidad.Text + "^FS");
                    sw.WriteLine(@"^PQ1,0,1,Y^XZ");
                    sw.WriteLine(@"^XA^ID000.GRF^FS^XZ");

                    sw.Close();
                    for (int i = 0; i < this.nCantCopias.Value; i++)
                    {
                        System.Diagnostics.Process.Start(@"C:\Users\Gabriela\Desktop\softImpresiones\archivoBat.bat");
                        Thread.Sleep(2000);
                    }
                }
            }
            else if (this.cmbMaterial.Text == "Poliamida / Satin")
            {
                if (bandera)
                {
                    StreamWriter sw = new StreamWriter("C:\\Users\\Gabriela\\Desktop\\softImpresiones\\archivo.prn");
                    sw.WriteLine("CT~~CD,~CC^~CT~");
                    sw.WriteLine("^XA~TA000~JSN^LT0^MNW^MTD^PON^PMN^LH0,0^JMA^PR3,3~SD20^JUS^LRN^CI0^XZ");
                    sw.WriteLine("~DG000.GRF,83200,104,");
                    sw.WriteLine(",:::::::::::::::::::::::::::::::::::::::::::::::::::::::::O07FoIF80,::::O07C0oG0F80,:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                    sw.WriteLine("::::::::::::::::N03FoHFEF80,:::O07C0oG0F80,::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::O0oIF8F80,:::O07C0hG01C0gY01C0jU0F80,:O07C0hG01C0gY01C0hK0380");
                    sw.WriteLine("hM0F80,:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::O07FoIF80,:O07C0hG01C0gY01C0hK0380hM0F80,::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::O07");
                    sw.WriteLine("FjPF80h0380hM0F80,O07FoGFCF80,:O07C0hG01C0gY01C0I07FjOFCF80,O07C0hG01C0gY01C0hK0380hM0F80,:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::O");
                    sw.WriteLine("07FoGFCF80,:O07C0hG01C0gY01C0hK0380hM0F80,:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::O07C0jI01C0hK0380hM0F80,:::O07C0lQ0380hM0F80,:O07C0oG0");
                    sw.WriteLine("F80,O07FoIF80,::::,:::::::::P03FoF80,:,::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::^XA");
                    sw.WriteLine("^MMT");
                    sw.WriteLine("^PW819");
                    sw.WriteLine("^LL0799");
                    sw.WriteLine("^LS0");
                    sw.WriteLine("^FT0,800^XG000.GRF,1,1^FS");
                    sw.WriteLine(@"^FT59,303^A0N,50,38^FH\^FDNro de Orden:" + this.txtOrden.Text + "^FS");
                    sw.WriteLine(@"^FT556,304^A0N,56,45^FH\^FD" + this.cmbPoliamidaSatin.Text + "^FS");
                    sw.WriteLine(@"^FT51,382^A0N,44,43^FH\^FDCantidad^FS");
                    sw.WriteLine(@"^FT240,387^A0N,50,50^FH\^FDAncho^FS");
                    sw.WriteLine(@"^FT432,384^A0N,50,50^FH\^FDLargo^FS");
                    sw.WriteLine(@"^FT619,386^A0N,50,60^FH\^FDBuje^FS");
                    sw.WriteLine(@"^FT93,754^A0N,44,28^FH\^FDwww.timingargentina.com.ar^FS");
                    sw.WriteLine(@"^FT514,758^A0N,44,31^FH\^FD0810-222-6261^FS");
                    sw.WriteLine(@"^FT60,135^A0N,65,81^FH\^FD" + this.txtEmpresa.Text + "^FS");
                    sw.WriteLine(@"^FT277,478^A0N,56,55^FH\^FD" + this.txtAncho.Text + "^FS");
                    sw.WriteLine(@"^FT441,478^A0N,56,55^FH\^FD" + this.txtAlto.Text + "^FS");
                    sw.WriteLine(@"^FT642,477^A0N,56,55^FH\^FD" + this.cmbBuje.Text + "^FS");
                    sw.WriteLine(@"^FT91,474^A0N,56,55^FH\^FD" + this.txtCantidad.Text + "^FS");
                    sw.WriteLine(@"^PQ1,0,1,Y^XZ");
                    sw.WriteLine(@"^XA^ID000.GRF^FS^XZ");

                    sw.Close();
                    for (int i = 0; i < this.nCantCopias.Value; i++)
                    {
                        System.Diagnostics.Process.Start(@"C:\Users\Gabriela\Desktop\softImpresiones\archivoBat.bat");
                        Thread.Sleep(2000);
                    }
                }
            }
                
            }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtCantidad.Text = "";
            this.txtEmpresa.Text = "";
            this.txtOrden.Text = "";
            this.txtTipo.Text = "";
            this.txtAncho.Text = "";
            this.txtAlto.Text = "";
            this.txtEtiqXRollo.Text = "";
            this.txtRollosXCaja.Text = "";
            this.nCantCopias.Value = 1;
            if (this.cmbMaterial.Text == "Etiquetas")
            {
                this.cmbPoliamidaSatin.Visible = false;
                this.cmbBuje.Visible = false;
                this.txtCantidad.Visible = false;
                this.txtEmpresa.Visible = true;
                this.txtOrden.Visible = true;
                this.txtTipo.Visible = true;
                this.txtAncho.Visible = true;
                this.txtAlto.Visible = true;
                this.txtEtiqXRollo.Visible = true;
                this.txtRollosXCaja.Visible = true;
                this.lblEmpresa.Visible = true;
                this.lblOrden.Visible = true;
                this.lblTipo.Visible = true;
                this.lblAncho.Visible = true;
                this.lblAlto.Visible = true;
                this.lblEtiqXRollo.Visible = true;
                this.lblRollosXCaja.Visible = true;
                this.lblPoliamidaSatin.Visible = false;
                this.lblBuje.Visible = false;
                this.lblCantidad.Visible = false;
                this.lblLargo.Visible = false;
                this.cmbRibbon.Visible = false;
                this.lblComposicion.Visible = false;
                this.lblCantidad.Location = new Point(132, 340);
                this.txtCantidad.Location = new Point(227, 343);
                this.label1.Location = new Point(66, 384);
                this.nCantCopias.Location = new Point(227, 387);
            }
            if (this.cmbMaterial.Text == "Poliamida / Satin")
            {
                this.cmbPoliamidaSatin.Visible = true;
                this.cmbBuje.Visible = true;
                this.txtCantidad.Visible = true;
                this.txtEmpresa.Visible = true;
                this.txtOrden.Visible = true;
                this.txtTipo.Visible = false;
                this.txtAncho.Visible = true;
                this.txtAlto.Visible = true;
                this.txtEtiqXRollo.Visible = false;
                this.txtRollosXCaja.Visible = false;
                this.lblEmpresa.Visible = true;
                this.lblOrden.Visible = true;
                this.lblTipo.Visible = false;
                this.lblAncho.Visible = true;
                this.lblAlto.Visible = false;
                this.lblEtiqXRollo.Visible = false;
                this.lblRollosXCaja.Visible = false;
                this.lblPoliamidaSatin.Visible = true;
                this.lblBuje.Visible = true;
                this.lblCantidad.Visible = true;
                this.lblLargo.Visible = true;
                this.cmbRibbon.Visible = false;
                this.lblComposicion.Visible = false;
                this.lblCantidad.Location = new Point(132, 340);
                this.txtCantidad.Location = new Point(227, 343);
                this.label1.Location = new Point(66, 384);
                this.nCantCopias.Location = new Point(227, 387);
            }
            if (this.cmbMaterial.Text == "Ribbon")
            {
                this.cmbPoliamidaSatin.Visible = false;
                this.cmbBuje.Visible = false;
                this.txtCantidad.Visible = true;
                this.txtEmpresa.Visible = true;
                this.txtOrden.Visible = true;
                this.txtTipo.Visible = false;
                this.txtAncho.Visible = true;
                this.txtAlto.Visible = true;
                this.txtEtiqXRollo.Visible = false;
                this.txtRollosXCaja.Visible = false;
                this.lblEmpresa.Visible = true;
                this.lblOrden.Visible = true;
                this.lblTipo.Visible = false;
                this.lblAncho.Visible = true;
                this.lblAlto.Visible = false;
                this.lblEtiqXRollo.Visible = false;
                this.lblRollosXCaja.Visible = false;
                this.lblPoliamidaSatin.Visible = false;
                this.lblBuje.Visible = false;
                this.lblCantidad.Visible = true;
                this.lblLargo.Visible = true;
                this.cmbRibbon.Visible = true;
                this.lblComposicion.Visible = true;
                this.lblCantidad.Location = new Point(132, 301);
                this.txtCantidad.Location = new Point(227, 304);
                this.label1.Location = new Point(66, 343);
                this.nCantCopias.Location = new Point(227, 341);
            }

        }

        private void txtOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtAncho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtAlto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtEtiqXRollo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtRollosXCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCantAImprimir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtOrden_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
