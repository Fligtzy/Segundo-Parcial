namespace Examen_RentaCar_SuNombre
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.chkCorporativo = new System.Windows.Forms.CheckBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.nudDias = new System.Windows.Forms.NumericUpDown();
            this.grpSeguro = new System.Windows.Forms.GroupBox();
            this.rbtBasico = new System.Windows.Forms.RadioButton();
            this.rbtCompleto = new System.Windows.Forms.RadioButton();
            this.chkGps = new System.Windows.Forms.CheckBox();
            this.grpEntrega = new System.Windows.Forms.GroupBox();
            this.rbtSucursal = new System.Windows.Forms.RadioButton();
            this.rbtDomicilio = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.lstAlquileres = new System.Windows.Forms.ListBox();
            this.lblSubtotalT = new System.Windows.Forms.Label();
            this.lblDescuentoT = new System.Windows.Forms.Label();
            this.lblDomicilioT = new System.Windows.Forms.Label();
            this.lblItbisT = new System.Windows.Forms.Label();
            this.lblTotalT = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblItbis = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).BeginInit();
            this.grpSeguro.SuspendLayout();
            this.grpEntrega.SuspendLayout();
            this.SuspendLayout();

            
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(20, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Text = "Cliente:";
           
            this.txtCliente.Location = new System.Drawing.Point(120, 17);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(220, 22);
            this.txtCliente.TabIndex = 0;
           
            this.chkCorporativo.AutoSize = true;
            this.chkCorporativo.Location = new System.Drawing.Point(120, 50);
            this.chkCorporativo.Name = "chkCorporativo";
            this.chkCorporativo.TabIndex = 1;
            this.chkCorporativo.Text = "Cliente corporativo";
            this.chkCorporativo.UseVisualStyleBackColor = true;
           
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(20, 85);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Text = "Salida:";
          
            this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalida.Location = new System.Drawing.Point(120, 82);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(220, 22);
            this.dtpSalida.TabIndex = 2;
          
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(20, 120);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Text = "Vehículo:";
          
            this.txtVehiculo.Location = new System.Drawing.Point(120, 117);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(220, 22);
            this.txtVehiculo.TabIndex = 3;
         
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Location = new System.Drawing.Point(20, 155);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Text = "Tarifa:";
          
            this.txtTarifa.Location = new System.Drawing.Point(120, 152);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(220, 22);
            this.txtTarifa.TabIndex = 4;
           
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(20, 190);
            this.lblDias.Name = "lblDias";
            this.lblDias.Text = "Días:";
          
            this.nudDias.Location = new System.Drawing.Point(120, 187);
            this.nudDias.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            this.nudDias.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudDias.Name = "nudDias";
            this.nudDias.Size = new System.Drawing.Size(80, 22);
            this.nudDias.TabIndex = 5;
            this.nudDias.Value = new decimal(new int[] { 1, 0, 0, 0 });
           
            this.grpSeguro.Controls.Add(this.rbtBasico);
            this.grpSeguro.Controls.Add(this.rbtCompleto);
            this.grpSeguro.Location = new System.Drawing.Point(20, 225);
            this.grpSeguro.Name = "grpSeguro";
            this.grpSeguro.Size = new System.Drawing.Size(220, 90);
            this.grpSeguro.TabIndex = 6;
            this.grpSeguro.TabStop = false;
            this.grpSeguro.Text = "Seguro";
         
            this.rbtBasico.AutoSize = true;
            this.rbtBasico.Checked = true;
            this.rbtBasico.Location = new System.Drawing.Point(15, 25);
            this.rbtBasico.Name = "rbtBasico";
            this.rbtBasico.TabIndex = 0;
            this.rbtBasico.TabStop = true;
            this.rbtBasico.Text = "Básico";
            this.rbtBasico.UseVisualStyleBackColor = true;
          
            this.rbtCompleto.AutoSize = true;
            this.rbtCompleto.Location = new System.Drawing.Point(15, 55);
            this.rbtCompleto.Name = "rbtCompleto";
            this.rbtCompleto.TabIndex = 1;
            this.rbtCompleto.Text = "Completo (+RD$300)";
            this.rbtCompleto.UseVisualStyleBackColor = true;
          
            this.chkGps.AutoSize = true;
            this.chkGps.Location = new System.Drawing.Point(20, 325);
            this.chkGps.Name = "chkGps";
            this.chkGps.TabIndex = 7;
            this.chkGps.Text = "GPS (+RD$100 por día)";
            this.chkGps.UseVisualStyleBackColor = true;
         
            this.grpEntrega.Controls.Add(this.rbtSucursal);
            this.grpEntrega.Controls.Add(this.rbtDomicilio);
            this.grpEntrega.Location = new System.Drawing.Point(20, 360);
            this.grpEntrega.Name = "grpEntrega";
            this.grpEntrega.Size = new System.Drawing.Size(220, 90);
            this.grpEntrega.TabIndex = 8;
            this.grpEntrega.TabStop = false;
            this.grpEntrega.Text = "Entrega";
        
            this.rbtSucursal.AutoSize = true;
            this.rbtSucursal.Checked = true;
            this.rbtSucursal.Location = new System.Drawing.Point(15, 25);
            this.rbtSucursal.Name = "rbtSucursal";
            this.rbtSucursal.TabIndex = 0;
            this.rbtSucursal.TabStop = true;
            this.rbtSucursal.Text = "En sucursal";
            this.rbtSucursal.UseVisualStyleBackColor = true;
          
            this.rbtDomicilio.AutoSize = true;
            this.rbtDomicilio.Location = new System.Drawing.Point(15, 55);
            this.rbtDomicilio.Name = "rbtDomicilio";
            this.rbtDomicilio.TabIndex = 1;
            this.rbtDomicilio.Text = "Domicilio (+RD$500)";
            this.rbtDomicilio.UseVisualStyleBackColor = true;
        
            this.btnAgregar.Location = new System.Drawing.Point(380, 15);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(200, 35);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar al alquiler";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
          
            this.lblEncabezado.AutoSize = false;
            this.lblEncabezado.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblEncabezado.Location = new System.Drawing.Point(380, 65);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(400, 20);
            this.lblEncabezado.Text = "";
          
            this.lstAlquileres.Font = new System.Drawing.Font("Consolas", 10F);
            this.lstAlquileres.FormattingEnabled = true;
            this.lstAlquileres.ItemHeight = 16;
            this.lstAlquileres.Location = new System.Drawing.Point(380, 90);
            this.lstAlquileres.Name = "lstAlquileres";
            this.lstAlquileres.Size = new System.Drawing.Size(400, 164);
            this.lstAlquileres.TabIndex = 10;
          
            this.lblSubtotalT.AutoSize = true;
            this.lblSubtotalT.Location = new System.Drawing.Point(400, 280);
            this.lblSubtotalT.Name = "lblSubtotalT";
            this.lblSubtotalT.Text = "Subtotal";
           
            this.lblDescuentoT.AutoSize = true;
            this.lblDescuentoT.Location = new System.Drawing.Point(400, 310);
            this.lblDescuentoT.Name = "lblDescuentoT";
            this.lblDescuentoT.Text = "Descuento (15%)";
         
            this.lblDomicilioT.AutoSize = true;
            this.lblDomicilioT.Location = new System.Drawing.Point(400, 340);
            this.lblDomicilioT.Name = "lblDomicilioT";
            this.lblDomicilioT.Text = "Domicilio";
          
            this.lblItbisT.AutoSize = true;
            this.lblItbisT.Location = new System.Drawing.Point(400, 370);
            this.lblItbisT.Name = "lblItbisT";
            this.lblItbisT.Text = "ITBIS (18%)";
           
            this.lblTotalT.AutoSize = true;
            this.lblTotalT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalT.Location = new System.Drawing.Point(400, 410);
            this.lblTotalT.Name = "lblTotalT";
            this.lblTotalT.Text = "TOTAL A PAGAR";
         
            this.lblSubtotal.AutoSize = false;
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.Location = new System.Drawing.Point(620, 278);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(150, 22);
            this.lblSubtotal.Text = "RD$ 0.00";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            
            this.lblDescuento.AutoSize = false;
            this.lblDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescuento.Location = new System.Drawing.Point(620, 308);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(150, 22);
            this.lblDescuento.Text = "RD$ 0.00";
            this.lblDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
           
            this.lblDomicilio.AutoSize = false;
            this.lblDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDomicilio.Location = new System.Drawing.Point(620, 338);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(150, 22);
            this.lblDomicilio.Text = "RD$ 0.00";
            this.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          
            this.lblItbis.AutoSize = false;
            this.lblItbis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItbis.Location = new System.Drawing.Point(620, 368);
            this.lblItbis.Name = "lblItbis";
            this.lblItbis.Size = new System.Drawing.Size(150, 22);
            this.lblItbis.Text = "RD$ 0.00";
            this.lblItbis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          
            this.lblTotal.AutoSize = false;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(620, 408);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(150, 22);
            this.lblTotal.Text = "RD$ 0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         
            this.btnCalcular.Location = new System.Drawing.Point(380, 460);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(110, 35);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular total";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
         
            this.btnLimpiar.Location = new System.Drawing.Point(500, 460);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 35);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Nuevo alquiler";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
          
            this.btnSalir.Location = new System.Drawing.Point(620, 460);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 35);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 521);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.chkCorporativo);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.txtVehiculo);
            this.Controls.Add(this.lblTarifa);
            this.Controls.Add(this.txtTarifa);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.nudDias);
            this.Controls.Add(this.grpSeguro);
            this.Controls.Add(this.chkGps);
            this.Controls.Add(this.grpEntrega);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.lstAlquileres);
            this.Controls.Add(this.lblSubtotalT);
            this.Controls.Add(this.lblDescuentoT);
            this.Controls.Add(this.lblDomicilioT);
            this.Controls.Add(this.lblItbisT);
            this.Controls.Add(this.lblTotalT);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblItbis);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentaCar Express - Alquileres";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).EndInit();
            this.grpSeguro.ResumeLayout(false);
            this.grpSeguro.PerformLayout();
            this.grpEntrega.ResumeLayout(false);
            this.grpEntrega.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.CheckBox chkCorporativo;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.NumericUpDown nudDias;
        private System.Windows.Forms.GroupBox grpSeguro;
        private System.Windows.Forms.RadioButton rbtBasico;
        private System.Windows.Forms.RadioButton rbtCompleto;
        private System.Windows.Forms.CheckBox chkGps;
        private System.Windows.Forms.GroupBox grpEntrega;
        private System.Windows.Forms.RadioButton rbtSucursal;
        private System.Windows.Forms.RadioButton rbtDomicilio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.ListBox lstAlquileres;
        private System.Windows.Forms.Label lblSubtotalT;
        private System.Windows.Forms.Label lblDescuentoT;
        private System.Windows.Forms.Label lblDomicilioT;
        private System.Windows.Forms.Label lblItbisT;
        private System.Windows.Forms.Label lblTotalT;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblItbis;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}
