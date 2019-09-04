namespace Cadastro_de_instrutor
{
    partial class cadastroExercicio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enviaimg = new System.Windows.Forms.Button();
            this.obsexe = new System.Windows.Forms.TextBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fotoEx = new System.Windows.Forms.PictureBox();
            this.idexercicio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descexe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mandarImagem = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoEx)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enviaimg);
            this.groupBox1.Controls.Add(this.btnCad);
            this.groupBox1.Controls.Add(this.obsexe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fotoEx);
            this.groupBox1.Controls.Add(this.idexercicio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.descexe);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(177, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 426);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // enviaimg
            // 
            this.enviaimg.Location = new System.Drawing.Point(32, 347);
            this.enviaimg.Name = "enviaimg";
            this.enviaimg.Size = new System.Drawing.Size(75, 23);
            this.enviaimg.TabIndex = 11;
            this.enviaimg.Text = "Enviar imagem";
            this.enviaimg.UseVisualStyleBackColor = true;
            this.enviaimg.Click += new System.EventHandler(this.enviaimg_Click);
            // 
            // obsexe
            // 
            this.obsexe.Location = new System.Drawing.Point(185, 162);
            this.obsexe.Multiline = true;
            this.obsexe.Name = "obsexe";
            this.obsexe.Size = new System.Drawing.Size(194, 73);
            this.obsexe.TabIndex = 3;
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(315, 386);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(64, 34);
            this.btnCad.TabIndex = 10;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de exercícios";
            // 
            // fotoEx
            // 
            this.fotoEx.Location = new System.Drawing.Point(185, 241);
            this.fotoEx.Name = "fotoEx";
            this.fotoEx.Size = new System.Drawing.Size(194, 143);
            this.fotoEx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoEx.TabIndex = 9;
            this.fotoEx.TabStop = false;
            // 
            // idexercicio
            // 
            this.idexercicio.Location = new System.Drawing.Point(185, 90);
            this.idexercicio.Name = "idexercicio";
            this.idexercicio.Size = new System.Drawing.Size(100, 20);
            this.idexercicio.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descrição do exercício";
            // 
            // descexe
            // 
            this.descexe.Location = new System.Drawing.Point(185, 126);
            this.descexe.Name = "descexe";
            this.descexe.Size = new System.Drawing.Size(125, 20);
            this.descexe.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Observações do exercício";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID Exercício";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Foto do exercício";
            // 
            // mandarImagem
            // 
            this.mandarImagem.FileName = "mandaImg";
            this.mandarImagem.FileOk += new System.ComponentModel.CancelEventHandler(this.mandarImagem_FileOk);
            // 
            // cadastroExercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "cadastroExercicio";
            this.Text = "cadastroExercicio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoEx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox obsexe;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox fotoEx;
        private System.Windows.Forms.TextBox idexercicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descexe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog mandarImagem;
        private System.Windows.Forms.Button enviaimg;
    }
}