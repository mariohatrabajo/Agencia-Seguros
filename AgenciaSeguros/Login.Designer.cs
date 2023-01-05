
namespace AgenciaSeguros
{
    partial class Login
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
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.txtUsu = new ControlesWinform.TextBoxHint();
            this.txtContra = new ControlesWinform.TextBoxHint();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.Location = new System.Drawing.Point(12, 84);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(102, 33);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Iniciar sesión";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.Transparent;
            this.btnReg.Location = new System.Drawing.Point(125, 84);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(102, 33);
            this.btnReg.TabIndex = 3;
            this.btnReg.Text = "Registrarse";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 61);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 4;
            this.lblError.Visible = false;
            // 
            // txtUsu
            // 
            this.txtUsu.ForeColor = System.Drawing.Color.Gray;
            this.txtUsu.Hint = "Usuario";
            this.txtUsu.Location = new System.Drawing.Point(12, 12);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(215, 20);
            this.txtUsu.TabIndex = 5;
            this.txtUsu.Text = "Usuario";
            // 
            // txtContra
            // 
            this.txtContra.ForeColor = System.Drawing.Color.Gray;
            this.txtContra.Hint = "Contraseña";
            this.txtContra.Location = new System.Drawing.Point(12, 38);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(215, 20);
            this.txtContra.TabIndex = 6;
            this.txtContra.Text = "Contraseña";
            this.txtContra.Enter += new System.EventHandler(this.txtContra_Enter);
            this.txtContra.Leave += new System.EventHandler(this.txtContra_Leave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(239, 120);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsu);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnInicio);
            this.KeyPreview = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pulsarEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lblError;
        private ControlesWinform.TextBoxHint txtUsu;
        private ControlesWinform.TextBoxHint txtContra;
    }
}

