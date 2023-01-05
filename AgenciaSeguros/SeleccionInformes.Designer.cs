
namespace AgenciaSeguros
{
    partial class SeleccionInformes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cbCliDesde = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset_seleccionInformesClientes = new AgenciaSeguros.dataset_seleccionInformesClientes();
            this.clientesTableAdapter = new AgenciaSeguros.dataset_seleccionInformesClientesTableAdapters.clientesTableAdapter();
            this.cbCliHasta = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataset_seleccionInformesClientesHasta = new AgenciaSeguros.dataset_seleccionInformesClientesHasta();
            this.clientesTableAdapter1 = new AgenciaSeguros.dataset_seleccionInformesClientesHastaTableAdapters.clientesTableAdapter();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.polizasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset_seleccionInformesEstados = new AgenciaSeguros.dataset_seleccionInformesEstados();
            this.rbEstado = new System.Windows.Forms.RadioButton();
            this.polizasTableAdapter = new AgenciaSeguros.dataset_seleccionInformesEstadosTableAdapters.polizasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_seleccionInformesClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_seleccionInformesClientesHasta)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polizasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_seleccionInformesEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo de cliente desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha desde";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(139, 46);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(100, 20);
            this.dtpDesde.TabIndex = 6;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(284, 46);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(100, 20);
            this.dtpHasta.TabIndex = 7;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(139, 149);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(118, 33);
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Text = "Generar informe";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.Generar);
            // 
            // cbCliDesde
            // 
            this.cbCliDesde.DataSource = this.clientesBindingSource;
            this.cbCliDesde.DisplayMember = "Apellidos";
            this.cbCliDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliDesde.FormattingEnabled = true;
            this.cbCliDesde.Location = new System.Drawing.Point(139, 6);
            this.cbCliDesde.Name = "cbCliDesde";
            this.cbCliDesde.Size = new System.Drawing.Size(100, 21);
            this.cbCliDesde.TabIndex = 9;
            this.cbCliDesde.ValueMember = "Id";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.dataset_seleccionInformesClientes;
            // 
            // dataset_seleccionInformesClientes
            // 
            this.dataset_seleccionInformesClientes.DataSetName = "dataset_seleccionInformesClientes";
            this.dataset_seleccionInformesClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // cbCliHasta
            // 
            this.cbCliHasta.DataSource = this.clientesBindingSource1;
            this.cbCliHasta.DisplayMember = "Apellidos";
            this.cbCliHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliHasta.FormattingEnabled = true;
            this.cbCliHasta.Location = new System.Drawing.Point(284, 6);
            this.cbCliHasta.Name = "cbCliHasta";
            this.cbCliHasta.Size = new System.Drawing.Size(100, 21);
            this.cbCliHasta.TabIndex = 10;
            this.cbCliHasta.ValueMember = "Id";
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "clientes";
            this.clientesBindingSource1.DataSource = this.dataset_seleccionInformesClientesHasta;
            // 
            // dataset_seleccionInformesClientesHasta
            // 
            this.dataset_seleccionInformesClientesHasta.DataSetName = "dataset_seleccionInformesClientesHasta";
            this.dataset_seleccionInformesClientesHasta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(8, 19);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(106, 17);
            this.rbTodos.TabIndex = 11;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todas las pólizas";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEstado);
            this.groupBox1.Controls.Add(this.rbEstado);
            this.groupBox1.Controls.Add(this.rbTodos);
            this.groupBox1.Location = new System.Drawing.Point(7, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 55);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cbEstado
            // 
            this.cbEstado.DataSource = this.polizasBindingSource;
            this.cbEstado.DisplayMember = "Estado";
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Enabled = false;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(241, 18);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 13;
            this.cbEstado.ValueMember = "Estado";
            // 
            // polizasBindingSource
            // 
            this.polizasBindingSource.DataMember = "polizas";
            this.polizasBindingSource.DataSource = this.dataset_seleccionInformesEstados;
            // 
            // dataset_seleccionInformesEstados
            // 
            this.dataset_seleccionInformesEstados.DataSetName = "dataset_seleccionInformesEstados";
            this.dataset_seleccionInformesEstados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rbEstado
            // 
            this.rbEstado.AutoSize = true;
            this.rbEstado.Location = new System.Drawing.Point(144, 19);
            this.rbEstado.Name = "rbEstado";
            this.rbEstado.Size = new System.Drawing.Size(76, 17);
            this.rbEstado.TabIndex = 12;
            this.rbEstado.Text = "Por estado";
            this.rbEstado.UseVisualStyleBackColor = true;
            this.rbEstado.CheckedChanged += new System.EventHandler(this.rbEstado_CheckedChanged);
            // 
            // polizasTableAdapter
            // 
            this.polizasTableAdapter.ClearBeforeFill = true;
            // 
            // SeleccionInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(391, 193);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbCliHasta);
            this.Controls.Add(this.cbCliDesde);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SeleccionInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion de Informes";
            this.Load += new System.EventHandler(this.SeleccionInformes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_seleccionInformesClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_seleccionInformesClientesHasta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polizasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_seleccionInformesEstados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cbCliDesde;
        private dataset_seleccionInformesClientes dataset_seleccionInformesClientes;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private dataset_seleccionInformesClientesTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.ComboBox cbCliHasta;
        private dataset_seleccionInformesClientesHasta dataset_seleccionInformesClientesHasta;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private dataset_seleccionInformesClientesHastaTableAdapters.clientesTableAdapter clientesTableAdapter1;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.RadioButton rbEstado;
        private dataset_seleccionInformesEstados dataset_seleccionInformesEstados;
        private System.Windows.Forms.BindingSource polizasBindingSource;
        private dataset_seleccionInformesEstadosTableAdapters.polizasTableAdapter polizasTableAdapter;
    }
}