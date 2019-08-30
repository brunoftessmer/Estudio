namespace Cadastro_de_instrutor
{
    partial class frmcaduser
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
            this.btncadastro = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.TextBox();
            this.senha2text = new System.Windows.Forms.TextBox();
            this.senha1text = new System.Windows.Forms.TextBox();
            this.usuariotext = new System.Windows.Forms.TextBox();
            this.cpftext = new System.Windows.Forms.TextBox();
            this.nome2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Sobrensome = new System.Windows.Forms.Label();
            this.radiopadrao = new System.Windows.Forms.RadioButton();
            this.radioadm = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sobretext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncadastro
            // 
            this.btncadastro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastro.Location = new System.Drawing.Point(312, 258);
            this.btncadastro.Name = "btncadastro";
            this.btncadastro.Size = new System.Drawing.Size(100, 41);
            this.btncadastro.TabIndex = 9;
            this.btncadastro.Text = "Cadastrar";
            this.btncadastro.UseVisualStyleBackColor = true;
            this.btncadastro.Click += new System.EventHandler(this.btncadastro_Click);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(312, 43);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(100, 20);
            this.nome.TabIndex = 1;
            // 
            // senha2text
            // 
            this.senha2text.Location = new System.Drawing.Point(312, 173);
            this.senha2text.Name = "senha2text";
            this.senha2text.PasswordChar = '*';
            this.senha2text.Size = new System.Drawing.Size(100, 20);
            this.senha2text.TabIndex = 6;
            // 
            // senha1text
            // 
            this.senha1text.Location = new System.Drawing.Point(312, 147);
            this.senha1text.Name = "senha1text";
            this.senha1text.PasswordChar = '*';
            this.senha1text.Size = new System.Drawing.Size(100, 20);
            this.senha1text.TabIndex = 5;
            // 
            // usuariotext
            // 
            this.usuariotext.Location = new System.Drawing.Point(312, 121);
            this.usuariotext.Name = "usuariotext";
            this.usuariotext.Size = new System.Drawing.Size(100, 20);
            this.usuariotext.TabIndex = 4;
            // 
            // cpftext
            // 
            this.cpftext.Location = new System.Drawing.Point(312, 95);
            this.cpftext.Name = "cpftext";
            this.cpftext.Size = new System.Drawing.Size(100, 20);
            this.cpftext.TabIndex = 3;
            // 
            // nome2
            // 
            this.nome2.AutoSize = true;
            this.nome2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome2.Location = new System.Drawing.Point(254, 46);
            this.nome2.Name = "nome2";
            this.nome2.Size = new System.Drawing.Size(41, 14);
            this.nome2.TabIndex = 7;
            this.nome2.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Repita sua senha";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nome de usuário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "CPF";
            // 
            // Sobrensome
            // 
            this.Sobrensome.AutoSize = true;
            this.Sobrensome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sobrensome.Location = new System.Drawing.Point(228, 72);
            this.Sobrensome.Name = "Sobrensome";
            this.Sobrensome.Size = new System.Drawing.Size(74, 14);
            this.Sobrensome.TabIndex = 12;
            this.Sobrensome.Text = "Sobrenome";
            // 
            // radiopadrao
            // 
            this.radiopadrao.AutoSize = true;
            this.radiopadrao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiopadrao.Location = new System.Drawing.Point(312, 210);
            this.radiopadrao.Name = "radiopadrao";
            this.radiopadrao.Size = new System.Drawing.Size(115, 18);
            this.radiopadrao.TabIndex = 7;
            this.radiopadrao.TabStop = true;
            this.radiopadrao.Text = "Usuário Padrão";
            this.radiopadrao.UseVisualStyleBackColor = true;
            // 
            // radioadm
            // 
            this.radioadm.AutoSize = true;
            this.radioadm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioadm.Location = new System.Drawing.Point(312, 234);
            this.radioadm.Name = "radioadm";
            this.radioadm.Size = new System.Drawing.Size(157, 18);
            this.radioadm.TabIndex = 8;
            this.radioadm.TabStop = true;
            this.radioadm.Text = "Usuário Administrador";
            this.radioadm.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(199, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 14);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tipo de usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cadastro de usuário";
            // 
            // sobretext
            // 
            this.sobretext.Location = new System.Drawing.Point(312, 69);
            this.sobretext.Name = "sobretext";
            this.sobretext.Size = new System.Drawing.Size(100, 20);
            this.sobretext.TabIndex = 2;
            // 
            // frmcaduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(742, 345);
            this.Controls.Add(this.sobretext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioadm);
            this.Controls.Add(this.radiopadrao);
            this.Controls.Add(this.Sobrensome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nome2);
            this.Controls.Add(this.cpftext);
            this.Controls.Add(this.usuariotext);
            this.Controls.Add(this.senha1text);
            this.Controls.Add(this.senha2text);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.btncadastro);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmcaduser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de usuários";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncadastro;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox senha2text;
        private System.Windows.Forms.TextBox senha1text;
        private System.Windows.Forms.TextBox usuariotext;
        private System.Windows.Forms.TextBox cpftext;
        private System.Windows.Forms.Label nome2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Sobrensome;
        private System.Windows.Forms.RadioButton radiopadrao;
        private System.Windows.Forms.RadioButton radioadm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sobretext;
    }
}

