
namespace AgenciaSeguros
{
    partial class FormularioPolizas
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtNomCli = new ControlesWinform.TextBoxHint();
            this.txtIdCli = new ControlesWinform.TextBoxHint();
            this.txtNum = new ControlesWinform.TextBoxHint();
            this.txtObservaciones = new ControlesWinform.TextBoxHint();
            this.lblError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImporte = new ControlesWinform.TextBoxNumerico();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(336, 17);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(265, 22);
            this.dtpFecha.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha:";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Cobrada",
            "A cuenta",
            "Liquidada",
            "Pre anulada",
            "Anulada"});
            this.cbEstado.Location = new System.Drawing.Point(79, 113);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(160, 24);
            this.cbEstado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Estado:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 156);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BuscarCliente);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 187);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Aceptar);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(503, 187);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtNomCli
            // 
            this.txtNomCli.ForeColor = System.Drawing.Color.Gray;
            this.txtNomCli.Hint = "Nombre del cliente";
            this.txtNomCli.Location = new System.Drawing.Point(79, 183);
            this.txtNomCli.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomCli.Name = "txtNomCli";
            this.txtNomCli.ReadOnly = true;
            this.txtNomCli.Size = new System.Drawing.Size(160, 22);
            this.txtNomCli.TabIndex = 10;
            this.txtNomCli.Text = "Nombre del cliente";
            // 
            // txtIdCli
            // 
            this.txtIdCli.ForeColor = System.Drawing.Color.Gray;
            this.txtIdCli.HideSelection = false;
            this.txtIdCli.Hint = "Nombre del cliente";
            this.txtIdCli.Location = new System.Drawing.Point(21, 159);
            this.txtIdCli.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCli.Name = "txtIdCli";
            this.txtIdCli.ReadOnly = true;
            this.txtIdCli.Size = new System.Drawing.Size(57, 22);
            this.txtIdCli.TabIndex = 11;
            this.txtIdCli.Text = "ID";
            this.txtIdCli.Visible = false;
            this.txtIdCli.TextChanged += new System.EventHandler(this.txtIdCli_TextChanged);
            // 
            // txtNum
            // 
            this.txtNum.ForeColor = System.Drawing.Color.Gray;
            this.txtNum.Hint = "Número";
            this.txtNum.Location = new System.Drawing.Point(79, 19);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(160, 22);
            this.txtNum.TabIndex = 1;
            this.txtNum.Text = "Número";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.ForeColor = System.Drawing.Color.Gray;
            this.txtObservaciones.Hint = "Observaciones";
            this.txtObservaciones.Location = new System.Drawing.Point(336, 65);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(265, 100);
            this.txtObservaciones.TabIndex = 5;
            this.txtObservaciones.Text = "Observaciones";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblError.Location = new System.Drawing.Point(402, 169);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(201, 17);
            this.lblError.TabIndex = 56;
            this.lblError.Text = "Debes rellenar todos los datos";
            this.lblError.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "Importe:";
            // 
            // txtImporte
            // 
            this.txtImporte.Decimal = false;
            this.txtImporte.ForeColor = System.Drawing.Color.Gray;
            this.txtImporte.Hint = "";
            this.txtImporte.Location = new System.Drawing.Point(79, 65);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtImporte.MaxLength = 9;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(161, 22);
            this.txtImporte.TabIndex = 2;
            // 
            // FormularioPolizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(624, 230);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtIdCli);
            this.Controls.Add(this.txtNomCli);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioPolizas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Polizas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        public System.Windows.Forms.ComboBox cbEstado;
        public ControlesWinform.TextBoxHint txtNomCli;
        public ControlesWinform.TextBoxHint txtIdCli;
        public ControlesWinform.TextBoxHint txtNum;
        public ControlesWinform.TextBoxHint txtObservaciones;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label4;
        public ControlesWinform.TextBoxNumerico txtImporte;
    }
}