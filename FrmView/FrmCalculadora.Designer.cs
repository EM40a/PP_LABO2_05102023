namespace FrmView
{
    partial class FrmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            lblPrimerOperador = new Label();
            lblResultado = new Label();
            lblSegundoOperador = new Label();
            txtSegundoOperando = new TextBox();
            btnHistorial = new Button();
            btnLimpiar = new Button();
            lblOperacion = new Label();
            cmbOperacion = new ComboBox();
            txtPrimerOperando = new TextBox();
            rdbBinario = new RadioButton();
            grpSistema = new GroupBox();
            rdbOctal = new RadioButton();
            rdbDecimal = new RadioButton();
            lblPrimerOperando = new Label();
            btnOperar = new Button();
            lblHistorial = new Label();
            lstHistorial = new ListBox();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(16, 268);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(0, 32);
            lblPrimerOperador.TabIndex = 0;
            // 
            // lblResultado
            // 
            lblResultado.AutoEllipsis = true;
            lblResultado.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.ForeColor = Color.Black;
            lblResultado.Location = new Point(37, 44);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(559, 67);
            lblResultado.TabIndex = 14;
            lblResultado.Text = "0";
            lblResultado.TextAlign = ContentAlignment.TopRight;
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundoOperador.ForeColor = Color.Gray;
            lblSegundoOperador.Location = new Point(415, 280);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(140, 20);
            lblSegundoOperador.TabIndex = 17;
            lblSegundoOperador.Text = "Segundo operando:";
            // 
            // txtSegundoOperando
            // 
            txtSegundoOperando.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoOperando.Location = new Point(415, 304);
            txtSegundoOperando.Margin = new Padding(3, 4, 3, 4);
            txtSegundoOperando.Name = "txtSegundoOperando";
            txtSegundoOperando.Size = new Size(181, 42);
            txtSegundoOperando.TabIndex = 2;
            // 
            // btnHistorial
            // 
            btnHistorial.Cursor = Cursors.Hand;
            btnHistorial.Location = new Point(229, 354);
            btnHistorial.Margin = new Padding(3, 4, 3, 4);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(180, 51);
            btnHistorial.TabIndex = 5;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Location = new Point(415, 354);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(182, 51);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperacion.ForeColor = Color.Gray;
            lblOperacion.Location = new Point(229, 280);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(73, 20);
            lblOperacion.TabIndex = 16;
            lblOperacion.Text = "Operador";
            // 
            // cmbOperacion
            // 
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(229, 302);
            cmbOperacion.Margin = new Padding(3, 4, 3, 4);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(180, 44);
            cmbOperacion.TabIndex = 1;
            // 
            // txtPrimerOperando
            // 
            txtPrimerOperando.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerOperando.Location = new Point(37, 304);
            txtPrimerOperando.Margin = new Padding(3, 4, 3, 4);
            txtPrimerOperando.Name = "txtPrimerOperando";
            txtPrimerOperando.Size = new Size(185, 42);
            txtPrimerOperando.TabIndex = 0;
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Cursor = Cursors.Hand;
            rdbBinario.Location = new Point(108, 43);
            rdbBinario.Margin = new Padding(3, 4, 3, 4);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(77, 24);
            rdbBinario.TabIndex = 8;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbOctal);
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Location = new Point(168, 156);
            grpSistema.Margin = new Padding(3, 4, 3, 4);
            grpSistema.Name = "grpSistema";
            grpSistema.Padding = new Padding(3, 4, 3, 4);
            grpSistema.Size = new Size(287, 88);
            grpSistema.TabIndex = 6;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            // 
            // rdbOctal
            // 
            rdbOctal.AutoSize = true;
            rdbOctal.Cursor = Cursors.Hand;
            rdbOctal.Enabled = false;
            rdbOctal.Location = new Point(191, 43);
            rdbOctal.Margin = new Padding(3, 4, 3, 4);
            rdbOctal.Name = "rdbOctal";
            rdbOctal.Size = new Size(65, 24);
            rdbOctal.TabIndex = 9;
            rdbOctal.Text = "Octal";
            rdbOctal.UseVisualStyleBackColor = true;
            rdbOctal.CheckedChanged += rdbOctal_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Checked = true;
            rdbDecimal.Cursor = Cursors.Hand;
            rdbDecimal.Location = new Point(17, 43);
            rdbDecimal.Margin = new Padding(3, 4, 3, 4);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(85, 24);
            rdbDecimal.TabIndex = 7;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // lblPrimerOperando
            // 
            lblPrimerOperando.AutoSize = true;
            lblPrimerOperando.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerOperando.ForeColor = Color.Gray;
            lblPrimerOperando.Location = new Point(37, 280);
            lblPrimerOperando.Margin = new Padding(0);
            lblPrimerOperando.Name = "lblPrimerOperando";
            lblPrimerOperando.Size = new Size(124, 20);
            lblPrimerOperando.TabIndex = 15;
            lblPrimerOperando.Text = "Primer operando:";
            // 
            // btnOperar
            // 
            btnOperar.Cursor = Cursors.Hand;
            btnOperar.Location = new Point(37, 354);
            btnOperar.Margin = new Padding(3, 4, 3, 4);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(186, 51);
            btnOperar.TabIndex = 20;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHistorial.ForeColor = Color.Gray;
            lblHistorial.Location = new Point(37, 112);
            lblHistorial.Margin = new Padding(0);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(85, 28);
            lblHistorial.TabIndex = 23;
            lblHistorial.Text = "Historial";
            lblHistorial.Visible = false;
            // 
            // lstHistorial
            // 
            lstHistorial.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 25;
            lstHistorial.Location = new Point(37, 142);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(560, 204);
            lstHistorial.TabIndex = 24;
            lstHistorial.Visible = false;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 440);
            Controls.Add(lstHistorial);
            Controls.Add(lblHistorial);
            Controls.Add(btnOperar);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperando);
            Controls.Add(lblResultado);
            Controls.Add(grpSistema);
            Controls.Add(btnHistorial);
            Controls.Add(btnLimpiar);
            Controls.Add(cmbOperacion);
            Controls.Add(txtSegundoOperando);
            Controls.Add(txtPrimerOperando);
            Controls.Add(lblPrimerOperador);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora - EM40a";
            FormClosing += FrmCalculadora_FormClosing;
            Load += FrmCalculadora_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrimerOperador;
        private Label lblResultado;
        private Label lblSegundoOperador;
        private TextBox txtSegundoOperando;
        private Button btnHistorial;
        private Button btnLimpiar;
        private Label lblOperacion;
        private ComboBox cmbOperacion;
        private TextBox txtPrimerOperando;
        private RadioButton rdbBinario;
        private GroupBox grpSistema;
        private RadioButton rdbOctal;
        private RadioButton rdbDecimal;
        private Label lblPrimerOperando;
        private Button btnOperar;
        private Label lblHistorial;
        private ListBox lstHistorial;
    }
}