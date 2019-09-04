namespace Cadastro_de_instrutor
{
    partial class cadastroPaciente
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
            this.data = new System.Windows.Forms.DateTimePicker();
            this.btnlimp = new System.Windows.Forms.Button();
            this.btncad = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.Label();
            this.fem = new System.Windows.Forms.RadioButton();
            this.masc = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Endereço = new System.Windows.Forms.Label();
            this.textemail = new System.Windows.Forms.TextBox();
            this.texttelefone = new System.Windows.Forms.TextBox();
            this.textcpf = new System.Windows.Forms.TextBox();
            this.textocu = new System.Windows.Forms.TextBox();
            this.textnome = new System.Windows.Forms.TextBox();
            this.textendereco = new System.Windows.Forms.TextBox();
            this.textsobrenome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data.Location = new System.Drawing.Point(490, 116);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(200, 20);
            this.data.TabIndex = 8;
            this.data.ValueChanged += new System.EventHandler(this.data_ValueChanged);
            // 
            // btnlimp
            // 
            this.btnlimp.Location = new System.Drawing.Point(515, 231);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(75, 23);
            this.btnlimp.TabIndex = 11;
            this.btnlimp.Text = "Sair";
            this.btnlimp.UseVisualStyleBackColor = true;
            // 
            // btncad
            // 
            this.btncad.Location = new System.Drawing.Point(515, 202);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(75, 23);
            this.btncad.TabIndex = 10;
            this.btncad.Text = "Cadastrar";
            this.btncad.UseVisualStyleBackColor = true;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(228, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 22);
            this.label7.TabIndex = 41;
            this.label7.Text = "Cadastro de pacientes:";
            // 
            // Sexo
            // 
            this.Sexo.AutoSize = true;
            this.Sexo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sexo.Location = new System.Drawing.Point(145, 354);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(32, 12);
            this.Sexo.TabIndex = 40;
            this.Sexo.Text = "Sexo";
            // 
            // fem
            // 
            this.fem.AutoSize = true;
            this.fem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fem.Location = new System.Drawing.Point(269, 352);
            this.fem.Name = "fem";
            this.fem.Size = new System.Drawing.Size(74, 16);
            this.fem.TabIndex = 7;
            this.fem.TabStop = true;
            this.fem.Text = "Feminino";
            this.fem.UseVisualStyleBackColor = true;
            // 
            // masc
            // 
            this.masc.AutoSize = true;
            this.masc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masc.Location = new System.Drawing.Point(190, 352);
            this.masc.Name = "masc";
            this.masc.Size = new System.Drawing.Size(79, 16);
            this.masc.TabIndex = 6;
            this.masc.TabStop = true;
            this.masc.Text = "Masculino";
            this.masc.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 12);
            this.label5.TabIndex = 35;
            this.label5.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 12);
            this.label4.TabIndex = 34;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 12);
            this.label3.TabIndex = 33;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 32;
            this.label2.Text = "Ocupação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 12);
            this.label1.TabIndex = 31;
            this.label1.Text = "Data de nascimento";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(149, 212);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(38, 12);
            this.Email.TabIndex = 30;
            this.Email.Text = "E-Mail";
            // 
            // Endereço
            // 
            this.Endereço.AutoSize = true;
            this.Endereço.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endereço.Location = new System.Drawing.Point(141, 186);
            this.Endereço.Name = "Endereço";
            this.Endereço.Size = new System.Drawing.Size(59, 12);
            this.Endereço.TabIndex = 29;
            this.Endereço.Text = "Endereço";
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(216, 212);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(100, 20);
            this.textemail.TabIndex = 3;
            // 
            // texttelefone
            // 
            this.texttelefone.Location = new System.Drawing.Point(216, 238);
            this.texttelefone.Name = "texttelefone";
            this.texttelefone.Size = new System.Drawing.Size(100, 20);
            this.texttelefone.TabIndex = 4;
            // 
            // textcpf
            // 
            this.textcpf.Location = new System.Drawing.Point(216, 264);
            this.textcpf.Name = "textcpf";
            this.textcpf.Size = new System.Drawing.Size(100, 20);
            this.textcpf.TabIndex = 5;
            // 
            // textocu
            // 
            this.textocu.Location = new System.Drawing.Point(490, 158);
            this.textocu.Name = "textocu";
            this.textocu.Size = new System.Drawing.Size(100, 20);
            this.textocu.TabIndex = 9;
            // 
            // textnome
            // 
            this.textnome.Location = new System.Drawing.Point(216, 120);
            this.textnome.Name = "textnome";
            this.textnome.Size = new System.Drawing.Size(100, 20);
            this.textnome.TabIndex = 1;
            // 
            // textendereco
            // 
            this.textendereco.Location = new System.Drawing.Point(216, 186);
            this.textendereco.Name = "textendereco";
            this.textendereco.Size = new System.Drawing.Size(100, 20);
            this.textendereco.TabIndex = 2;
            // 
            // textsobrenome
            // 
            this.textsobrenome.Location = new System.Drawing.Point(216, 154);
            this.textsobrenome.Name = "textsobrenome";
            this.textsobrenome.Size = new System.Drawing.Size(100, 20);
            this.textsobrenome.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Sobrenome";
            // 
            // cadastroPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textsobrenome);
            this.Controls.Add(this.data);
            this.Controls.Add(this.btnlimp);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.fem);
            this.Controls.Add(this.masc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Endereço);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.texttelefone);
            this.Controls.Add(this.textcpf);
            this.Controls.Add(this.textocu);
            this.Controls.Add(this.textnome);
            this.Controls.Add(this.textendereco);
            this.Name = "cadastroPaciente";
            this.Text = "cadastroPaciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Sexo;
        private System.Windows.Forms.RadioButton fem;
        private System.Windows.Forms.RadioButton masc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Endereço;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox texttelefone;
        private System.Windows.Forms.TextBox textcpf;
        private System.Windows.Forms.TextBox textocu;
        private System.Windows.Forms.TextBox textnome;
        private System.Windows.Forms.TextBox textendereco;
        private System.Windows.Forms.TextBox textsobrenome;
        private System.Windows.Forms.Label label6;
    }
}