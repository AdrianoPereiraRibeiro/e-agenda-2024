namespace eAgenda.WinApp.ModuloCompromisso
{
    partial class TelaCompromissoForm
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
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtAssunto = new TextBox();
            label3 = new Label();
            txtData = new DateTimePicker();
            label4 = new Label();
            txtHoraInicio = new DateTimePicker();
            label5 = new Label();
            txtHoraTermino = new DateTimePicker();
            checkMarcarContato = new CheckBox();
            cmbContatos = new ComboBox();
            rdbRemoto = new RadioButton();
            rdbPresencial = new RadioButton();
            txtLink = new TextBox();
            txtLocal = new TextBox();
            groupBox1 = new GroupBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(57, 95);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F);
            txtId.Location = new Point(110, 95);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(114, 32);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(6, 132);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 0;
            label2.Text = "Assunto:";
            label2.Click += label2_Click;
            // 
            // txtAssunto
            // 
            txtAssunto.Font = new Font("Segoe UI", 11.25F);
            txtAssunto.Location = new Point(110, 135);
            txtAssunto.Margin = new Padding(3, 4, 3, 4);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(363, 32);
            txtAssunto.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(34, 171);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 0;
            label3.Text = "Data:";
            // 
            // txtData
            // 
            txtData.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(110, 175);
            txtData.Margin = new Padding(3, 4, 3, 4);
            txtData.Name = "txtData";
            txtData.Size = new Size(159, 32);
            txtData.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(34, 224);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 0;
            label4.Text = "Início:";
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.CustomFormat = "HH:mm";
            txtHoraInicio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoraInicio.Format = DateTimePickerFormat.Custom;
            txtHoraInicio.Location = new Point(110, 224);
            txtHoraInicio.Margin = new Padding(3, 4, 3, 4);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.ShowUpDown = true;
            txtHoraInicio.Size = new Size(127, 32);
            txtHoraInicio.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(267, 231);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 0;
            label5.Text = "Término:";
            // 
            // txtHoraTermino
            // 
            txtHoraTermino.CustomFormat = "HH:mm";
            txtHoraTermino.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoraTermino.Format = DateTimePickerFormat.Custom;
            txtHoraTermino.Location = new Point(359, 224);
            txtHoraTermino.Margin = new Padding(3, 4, 3, 4);
            txtHoraTermino.Name = "txtHoraTermino";
            txtHoraTermino.ShowUpDown = true;
            txtHoraTermino.Size = new Size(127, 32);
            txtHoraTermino.TabIndex = 2;
            // 
            // checkMarcarContato
            // 
            checkMarcarContato.AutoSize = true;
            checkMarcarContato.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkMarcarContato.Location = new Point(12, 297);
            checkMarcarContato.Margin = new Padding(3, 4, 3, 4);
            checkMarcarContato.Name = "checkMarcarContato";
            checkMarcarContato.Size = new Size(264, 29);
            checkMarcarContato.TabIndex = 3;
            checkMarcarContato.Text = "Deseja marcar um contato?";
            checkMarcarContato.UseVisualStyleBackColor = true;
            checkMarcarContato.CheckedChanged += checkMarcarContato_CheckedChanged;
            // 
            // cmbContatos
            // 
            cmbContatos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbContatos.Enabled = false;
            cmbContatos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbContatos.FormattingEnabled = true;
            cmbContatos.Location = new Point(286, 297);
            cmbContatos.Margin = new Padding(3, 4, 3, 4);
            cmbContatos.Name = "cmbContatos";
            cmbContatos.Size = new Size(187, 33);
            cmbContatos.TabIndex = 4;
            // 
            // rdbRemoto
            // 
            rdbRemoto.AutoSize = true;
            rdbRemoto.Checked = true;
            rdbRemoto.Location = new Point(19, 49);
            rdbRemoto.Margin = new Padding(3, 4, 3, 4);
            rdbRemoto.Name = "rdbRemoto";
            rdbRemoto.Size = new Size(101, 29);
            rdbRemoto.TabIndex = 0;
            rdbRemoto.TabStop = true;
            rdbRemoto.Text = "Remoto:";
            rdbRemoto.UseVisualStyleBackColor = true;
            rdbRemoto.CheckedChanged += rdbRemoto_CheckedChanged;
            // 
            // rdbPresencial
            // 
            rdbPresencial.AutoSize = true;
            rdbPresencial.Location = new Point(21, 93);
            rdbPresencial.Margin = new Padding(3, 4, 3, 4);
            rdbPresencial.Name = "rdbPresencial";
            rdbPresencial.Size = new Size(123, 29);
            rdbPresencial.TabIndex = 0;
            rdbPresencial.TabStop = true;
            rdbPresencial.Text = "Presencial:";
            rdbPresencial.UseVisualStyleBackColor = true;
            rdbPresencial.CheckedChanged += rdbPresencial_CheckedChanged;
            // 
            // txtLink
            // 
            txtLink.Location = new Point(137, 48);
            txtLink.Margin = new Padding(3, 4, 3, 4);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(243, 32);
            txtLink.TabIndex = 1;
            // 
            // txtLocal
            // 
            txtLocal.Enabled = false;
            txtLocal.Location = new Point(137, 92);
            txtLocal.Margin = new Padding(3, 4, 3, 4);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(243, 32);
            txtLocal.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLocal);
            groupBox1.Controls.Add(txtLink);
            groupBox1.Controls.Add(rdbPresencial);
            groupBox1.Controls.Add(rdbRemoto);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(74, 353);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(399, 143);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Localização";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(238, 549);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(114, 49);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(359, 549);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 49);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 615);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            Controls.Add(cmbContatos);
            Controls.Add(checkMarcarContato);
            Controls.Add(txtHoraTermino);
            Controls.Add(txtHoraInicio);
            Controls.Add(label5);
            Controls.Add(txtData);
            Controls.Add(label4);
            Controls.Add(txtAssunto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCompromissoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Compromisso";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtAssunto;
        private Label label3;
        private DateTimePicker txtData;
        private Label label4;
        private DateTimePicker txtHoraInicio;
        private Label label5;
        private DateTimePicker txtHoraTermino;
        private CheckBox checkMarcarContato;
        private ComboBox cmbContatos;
        private RadioButton rdbRemoto;
        private RadioButton rdbPresencial;
        private TextBox txtLink;
        private TextBox txtLocal;
        private GroupBox groupBox1;
        private Button btnGravar;
        private Button btnCancelar;
    }
}