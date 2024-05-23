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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            txtAssunto = new TextBox();
            txtLocal = new TextBox();
            txtData = new DateTimePicker();
            txtInicio = new DateTimePicker();
            txtTermino = new DateTimePicker();
            btnGravar = new Button();
            btnCancelar = new Button();
            comboContato = new ComboBox();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 29);
            label1.Name = "label1";
            label1.Size = new Size(41, 31);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 96);
            label2.Name = "label2";
            label2.Size = new Size(122, 31);
            label2.TabIndex = 1;
            label2.Text = "Local/Link:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 132);
            label3.Name = "label3";
            label3.Size = new Size(67, 31);
            label3.TabIndex = 2;
            label3.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(59, 177);
            label4.Name = "label4";
            label4.Size = new Size(74, 31);
            label4.TabIndex = 3;
            label4.Text = "Início:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(310, 177);
            label5.Name = "label5";
            label5.Size = new Size(101, 31);
            label5.TabIndex = 4;
            label5.Text = "Término:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 60);
            label6.Name = "label6";
            label6.Size = new Size(101, 31);
            label6.TabIndex = 5;
            label6.Text = "Assunto:";
            // 
            // txtId
            // 
            txtId.AccessibleRole = AccessibleRole.None;
            txtId.Enabled = false;
            txtId.Location = new Point(139, 29);
            txtId.Name = "txtId";
            txtId.Size = new Size(54, 27);
            txtId.TabIndex = 6;
            txtId.Text = "0";
            txtId.UseWaitCursor = true;
            txtId.TextChanged += textBox1_TextChanged;
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(139, 66);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(399, 27);
            txtAssunto.TabIndex = 7;
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(139, 102);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(297, 27);
            txtLocal.TabIndex = 8;
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(139, 136);
            txtData.Name = "txtData";
            txtData.Size = new Size(121, 27);
            txtData.TabIndex = 11;
            txtData.Value = new DateTime(2024, 5, 22, 0, 0, 0, 0);
            // 
            // txtInicio
            // 
            txtInicio.Format = DateTimePickerFormat.Time;
            txtInicio.Location = new Point(139, 181);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(121, 27);
            txtInicio.TabIndex = 12;
            txtInicio.Value = new DateTime(2024, 5, 22, 0, 0, 0, 0);
            // 
            // txtTermino
            // 
            txtTermino.Format = DateTimePickerFormat.Time;
            txtTermino.Location = new Point(417, 181);
            txtTermino.Name = "txtTermino";
            txtTermino.Size = new Size(121, 27);
            txtTermino.TabIndex = 13;
            txtTermino.Value = new DateTime(2024, 5, 22, 0, 0, 0, 0);
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(392, 307);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(114, 49);
            btnGravar.TabIndex = 17;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(512, 307);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 49);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // comboContato
            // 
            comboContato.Enabled = false;
            comboContato.FormattingEnabled = true;
            comboContato.Location = new Point(310, 254);
            comboContato.Name = "comboContato";
            comboContato.Size = new Size(228, 28);
            comboContato.TabIndex = 15;
            comboContato.SelectedIndexChanged += comboContato_SelectedIndexChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(59, 254);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(229, 24);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Deseja adicionar um contato?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(442, 105);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(96, 24);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Presencial";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(543, 105);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(83, 24);
            radioButton2.TabIndex = 10;
            radioButton2.Text = "Remoto";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 369);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(checkBox1);
            Controls.Add(comboContato);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtTermino);
            Controls.Add(txtInicio);
            Controls.Add(txtData);
            Controls.Add(txtLocal);
            Controls.Add(txtAssunto);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCompromissoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Compromissos";
            Load += TelaCompromissoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private TextBox txtAssunto;
        private TextBox txtLocal;
        private DateTimePicker txtData;
        private DateTimePicker txtInicio;
        private DateTimePicker txtTermino;
        private Button btnGravar;
        private Button btnCancelar;
        private ComboBox comboContato;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}