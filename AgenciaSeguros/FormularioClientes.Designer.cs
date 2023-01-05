
namespace AgenciaSeguros
{
    partial class FormularioClientes
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMun = new System.Windows.Forms.ComboBox();
            this.municipiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset_municipios = new AgenciaSeguros.dataset_municipios();
            this.cbProv = new System.Windows.Forms.ComboBox();
            this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset_provincias = new AgenciaSeguros.dataset_provincias();
            this.txtNombre = new ControlesWinform.TextBoxHint();
            this.txtApell = new ControlesWinform.TextBoxHint();
            this.txtDNI = new ControlesWinform.TextBoxDNI(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbPart = new System.Windows.Forms.RadioButton();
            this.rbEmp = new System.Windows.Forms.RadioButton();
            this.provinciasTableAdapter = new AgenciaSeguros.dataset_provinciasTableAdapters.provinciasTableAdapter();
            this.municipiosTableAdapter = new AgenciaSeguros.dataset_municipiosTableAdapters.municipiosTableAdapter();
            this.txtTlf = new ControlesWinform.TextBoxNumerico();
            this.label4 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCP = new ControlesWinform.TextBoxNumerico();
            ((System.ComponentModel.ISupportInitialize)(this.municipiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_municipios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_provincias)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(483, 255);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 38;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 255);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Municipio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Provincia:";
            // 
            // cbMun
            // 
            this.cbMun.DataSource = this.municipiosBindingSource;
            this.cbMun.DisplayMember = "municipio";
            this.cbMun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMun.Enabled = false;
            this.cbMun.FormattingEnabled = true;
            this.cbMun.Location = new System.Drawing.Point(93, 214);
            this.cbMun.Margin = new System.Windows.Forms.Padding(4);
            this.cbMun.Name = "cbMun";
            this.cbMun.Size = new System.Drawing.Size(204, 24);
            this.cbMun.TabIndex = 27;
            this.cbMun.ValueMember = "id";
            // 
            // municipiosBindingSource
            // 
            this.municipiosBindingSource.DataMember = "municipios";
            this.municipiosBindingSource.DataSource = this.dataset_municipios;
            // 
            // dataset_municipios
            // 
            this.dataset_municipios.DataSetName = "dataset_municipios";
            this.dataset_municipios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbProv
            // 
            this.cbProv.DataSource = this.provinciasBindingSource;
            this.cbProv.DisplayMember = "provincia";
            this.cbProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProv.FormattingEnabled = true;
            this.cbProv.Location = new System.Drawing.Point(93, 181);
            this.cbProv.Margin = new System.Windows.Forms.Padding(4);
            this.cbProv.Name = "cbProv";
            this.cbProv.Size = new System.Drawing.Size(204, 24);
            this.cbProv.TabIndex = 26;
            this.cbProv.ValueMember = "id";
            this.cbProv.SelectedIndexChanged += new System.EventHandler(this.comboBoxProv_SelectedIndexChanged);
            // 
            // provinciasBindingSource
            // 
            this.provinciasBindingSource.DataMember = "provincias";
            this.provinciasBindingSource.DataSource = this.dataset_provincias;
            // 
            // dataset_provincias
            // 
            this.dataset_provincias.DataSetName = "dataset_provincias";
            this.dataset_provincias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.Location = new System.Drawing.Point(16, 41);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre";
            // 
            // txtApell
            // 
            this.txtApell.ForeColor = System.Drawing.Color.Gray;
            this.txtApell.Hint = "Apellidos";
            this.txtApell.Location = new System.Drawing.Point(243, 41);
            this.txtApell.Margin = new System.Windows.Forms.Padding(4);
            this.txtApell.Name = "txtApell";
            this.txtApell.Size = new System.Drawing.Size(339, 22);
            this.txtApell.TabIndex = 2;
            this.txtApell.Text = "Apellidos";
            // 
            // txtDNI
            // 
            this.txtDNI.ForeColor = System.Drawing.Color.Gray;
            this.txtDNI.Hint = "DNI";
            this.txtDNI.Location = new System.Drawing.Point(16, 73);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNI.MaxLength = 10;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Numero = 0;
            this.txtDNI.Size = new System.Drawing.Size(217, 22);
            this.txtDNI.TabIndex = 3;
            this.txtDNI.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 22);
            this.label1.TabIndex = 47;
            this.label1.Text = "Información personal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 48;
            this.label2.Text = "Localización";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Tipo:";
            // 
            // rbPart
            // 
            this.rbPart.AutoSize = true;
            this.rbPart.Location = new System.Drawing.Point(65, 119);
            this.rbPart.Margin = new System.Windows.Forms.Padding(4);
            this.rbPart.Name = "rbPart";
            this.rbPart.Size = new System.Drawing.Size(89, 21);
            this.rbPart.TabIndex = 51;
            this.rbPart.TabStop = true;
            this.rbPart.Text = "Particular";
            this.rbPart.UseVisualStyleBackColor = true;
            // 
            // rbEmp
            // 
            this.rbEmp.AutoSize = true;
            this.rbEmp.Location = new System.Drawing.Point(167, 119);
            this.rbEmp.Margin = new System.Windows.Forms.Padding(4);
            this.rbEmp.Name = "rbEmp";
            this.rbEmp.Size = new System.Drawing.Size(85, 21);
            this.rbEmp.TabIndex = 52;
            this.rbEmp.TabStop = true;
            this.rbEmp.Text = "Empresa";
            this.rbEmp.UseVisualStyleBackColor = true;
            // 
            // provinciasTableAdapter
            // 
            this.provinciasTableAdapter.ClearBeforeFill = true;
            // 
            // municipiosTableAdapter
            // 
            this.municipiosTableAdapter.ClearBeforeFill = true;
            // 
            // txtTlf
            // 
            this.txtTlf.Decimal = false;
            this.txtTlf.ForeColor = System.Drawing.Color.Gray;
            this.txtTlf.Hint = "";
            this.txtTlf.Location = new System.Drawing.Point(320, 73);
            this.txtTlf.Margin = new System.Windows.Forms.Padding(4);
            this.txtTlf.MaxLength = 9;
            this.txtTlf.Name = "txtTlf";
            this.txtTlf.Size = new System.Drawing.Size(132, 22);
            this.txtTlf.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Teléfono:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblError.Location = new System.Drawing.Point(381, 234);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(201, 17);
            this.lblError.TabIndex = 55;
            this.lblError.Text = "Debes rellenar todos los datos";
            this.lblError.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 184);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 57;
            this.label7.Text = "CP:";
            // 
            // txtCP
            // 
            this.txtCP.Decimal = false;
            this.txtCP.ForeColor = System.Drawing.Color.Gray;
            this.txtCP.Hint = "";
            this.txtCP.Location = new System.Drawing.Point(343, 182);
            this.txtCP.Margin = new System.Windows.Forms.Padding(4);
            this.txtCP.MaxLength = 5;
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(109, 22);
            this.txtCP.TabIndex = 56;
            // 
            // FormularioClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(599, 298);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTlf);
            this.Controls.Add(this.rbEmp);
            this.Controls.Add(this.rbPart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApell);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMun);
            this.Controls.Add(this.cbProv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Clientes";
            this.Load += new System.EventHandler(this.FormularioClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.municipiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_municipios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_provincias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbMun;
        public System.Windows.Forms.ComboBox cbProv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public ControlesWinform.TextBoxHint txtNombre;
        public ControlesWinform.TextBoxHint txtApell;
        public ControlesWinform.TextBoxDNI txtDNI;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RadioButton rbPart;
        public System.Windows.Forms.RadioButton rbEmp;
        private dataset_provincias dataset_provincias;
        private System.Windows.Forms.BindingSource provinciasBindingSource;
        private dataset_provinciasTableAdapters.provinciasTableAdapter provinciasTableAdapter;
        private dataset_municipios dataset_municipios;
        private System.Windows.Forms.BindingSource municipiosBindingSource;
        private dataset_municipiosTableAdapters.municipiosTableAdapter municipiosTableAdapter;
        private System.Windows.Forms.Label label4;
        public ControlesWinform.TextBoxNumerico txtTlf;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label7;
        public ControlesWinform.TextBoxNumerico txtCP;
    }
}