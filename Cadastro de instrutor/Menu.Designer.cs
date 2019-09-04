namespace Cadastro_de_instrutor
{
    partial class frmMenu
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
            this.btnExercicio = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnInstrutor = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExercicio
            // 
            this.btnExercicio.Location = new System.Drawing.Point(6, 251);
            this.btnExercicio.Name = "btnExercicio";
            this.btnExercicio.Size = new System.Drawing.Size(142, 65);
            this.btnExercicio.TabIndex = 0;
            this.btnExercicio.Text = "Cadastrar exercício";
            this.btnExercicio.UseVisualStyleBackColor = true;
            this.btnExercicio.Click += new System.EventHandler(this.btnExercicio_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Location = new System.Drawing.Point(200, 251);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(142, 65);
            this.btnPaciente.TabIndex = 1;
            this.btnPaciente.Text = "Cadastrar paciente";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnInstrutor
            // 
            this.btnInstrutor.Location = new System.Drawing.Point(386, 251);
            this.btnInstrutor.Name = "btnInstrutor";
            this.btnInstrutor.Size = new System.Drawing.Size(142, 65);
            this.btnInstrutor.TabIndex = 2;
            this.btnInstrutor.Text = "Cadastrar novo instrutor";
            this.btnInstrutor.UseVisualStyleBackColor = true;
            this.btnInstrutor.Click += new System.EventHandler(this.btnInstrutor_Click);
            // 
            // menu
            // 
            this.menu.Controls.Add(this.button1);
            this.menu.Controls.Add(this.btnExercicio);
            this.menu.Controls.Add(this.btnInstrutor);
            this.menu.Controls.Add(this.btnPaciente);
            this.menu.Location = new System.Drawing.Point(141, 42);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(534, 322);
            this.menu.TabIndex = 3;
            this.menu.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 371);
            this.Controls.Add(this.menu);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExercicio;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnInstrutor;
        private System.Windows.Forms.GroupBox menu;
        private System.Windows.Forms.Button button1;
    }
}