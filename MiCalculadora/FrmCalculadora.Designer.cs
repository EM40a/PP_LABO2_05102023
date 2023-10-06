namespace MiCalculadora
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
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            rdbDecimal = new RadioButton();
            rdbBinario = new RadioButton();
            grpSistema = new GroupBox();
            cmbOperacion = new ComboBox();
            lblResultado = new Label();
            txtPrimerOperador = new RichTextBox();
            txtSegundoOperador = new RichTextBox();
            lblPrimerOperador = new Label();
            lblOperacion = new Label();
            lblSegundoOperador = new Label();
            lblResultadoNumerico = new Label();
            lblHistorial = new Label();
            lstHistorial = new ListBox();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // btnOperar
            // 
            btnOperar.BackColor = Color.FromArgb(71, 177, 232);
            btnOperar.Cursor = Cursors.Hand;
            btnOperar.FlatAppearance.BorderSize = 0;
            btnOperar.FlatStyle = FlatStyle.Flat;
            btnOperar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(62, 545);
            btnOperar.Margin = new Padding(0);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(292, 75);
            btnOperar.TabIndex = 4;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = false;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ButtonFace;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(367, 545);
            btnLimpiar.Margin = new Padding(0);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(292, 75);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.ButtonFace;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(672, 545);
            btnCerrar.Margin = new Padding(0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(292, 75);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Checked = true;
            rdbDecimal.Location = new Point(39, 40);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(85, 24);
            rdbDecimal.TabIndex = 8;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(166, 40);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(77, 24);
            rdbBinario.TabIndex = 9;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.ForeColor = Color.White;
            grpSistema.Location = new Point(372, 278);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(280, 85);
            grpSistema.TabIndex = 7;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            // 
            // cmbOperacion
            // 
            cmbOperacion.Cursor = Cursors.Hand;
            cmbOperacion.DropDownHeight = 265;
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.IntegralHeight = false;
            cmbOperacion.ItemHeight = 45;
            cmbOperacion.Items.AddRange(new object[] { " ", "+", "-", "*", "/" });
            cmbOperacion.Location = new Point(415, 473);
            cmbOperacion.Margin = new Padding(16, 3, 16, 3);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(200, 53);
            cmbOperacion.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.AutoEllipsis = true;
            lblResultado.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.ForeColor = Color.FromArgb(71, 177, 232);
            lblResultado.Location = new Point(62, 148);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(301, 67);
            lblResultado.TabIndex = 13;
            lblResultado.Text = "Resultado: ";
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerOperador.Location = new Point(62, 473);
            txtPrimerOperador.Margin = new Padding(0);
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.Size = new Size(334, 53);
            txtPrimerOperador.TabIndex = 1;
            txtPrimerOperador.Text = "";
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoOperador.Location = new Point(628, 473);
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.Size = new Size(336, 53);
            txtSegundoOperador.TabIndex = 3;
            txtSegundoOperador.Text = "";
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerOperador.ForeColor = Color.FromArgb(215, 215, 215);
            lblPrimerOperador.Location = new Point(62, 445);
            lblPrimerOperador.Margin = new Padding(0);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(143, 23);
            lblPrimerOperador.TabIndex = 10;
            lblPrimerOperador.Text = "Primer operando:";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperacion.ForeColor = Color.FromArgb(215, 215, 215);
            lblOperacion.Location = new Point(411, 445);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(83, 23);
            lblOperacion.TabIndex = 11;
            lblOperacion.Text = "Operador";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundoOperador.ForeColor = Color.FromArgb(215, 215, 215);
            lblSegundoOperador.Location = new Point(628, 445);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(161, 23);
            lblSegundoOperador.TabIndex = 12;
            lblSegundoOperador.Text = "Segundo operando:";
            // 
            // lblResultadoNumerico
            // 
            lblResultadoNumerico.AutoEllipsis = true;
            lblResultadoNumerico.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultadoNumerico.ForeColor = Color.White;
            lblResultadoNumerico.Location = new Point(367, 148);
            lblResultadoNumerico.Name = "lblResultadoNumerico";
            lblResultadoNumerico.Size = new Size(595, 67);
            lblResultadoNumerico.TabIndex = 14;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblHistorial.ForeColor = Color.Gray;
            lblHistorial.Location = new Point(975, 160);
            lblHistorial.Margin = new Padding(0);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(116, 37);
            lblHistorial.TabIndex = 15;
            lblHistorial.Text = "Historial";
            // 
            // lstHistorial
            // 
            lstHistorial.BackColor = SystemColors.Info;
            lstHistorial.BorderStyle = BorderStyle.None;
            lstHistorial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 28;
            lstHistorial.Location = new Point(984, 200);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(332, 420);
            lstHistorial.TabIndex = 18;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1354, 721);
            Controls.Add(lstHistorial);
            Controls.Add(lblHistorial);
            Controls.Add(lblResultadoNumerico);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperador);
            Controls.Add(txtSegundoOperador);
            Controls.Add(txtPrimerOperador);
            Controls.Add(lblResultado);
            Controls.Add(cmbOperacion);
            Controls.Add(grpSistema);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += FrmCalculadora_FormClosing;
            Load += FrmCalculadora_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private RadioButton rdbDecimal;
        private RadioButton rdbBinario;
        private GroupBox grpSistema;
        private ComboBox cmbOperacion;
        private Label lblResultado;
        private RichTextBox txtPrimerOperador;
        private RichTextBox txtSegundoOperador;
        private Label lblPrimerOperador;
        private Label lblOperacion;
        private Label lblSegundoOperador;
        private Label lblResultadoNumerico;
        private Label lblHistorial;
        private ListBox lstHistorial;
    }
}