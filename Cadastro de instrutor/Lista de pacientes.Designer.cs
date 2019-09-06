namespace Cadastro_de_instrutor
{
    partial class Lista_de_pacientes
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
            this.listusu = new System.Windows.Forms.ListBox();
            this.btnlistar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // listusu
            // 
            this.listusu.FormattingEnabled = true;
            this.listusu.Location = new System.Drawing.Point(50, 44);
            this.listusu.Name = "listusu";
            this.listusu.Size = new System.Drawing.Size(636, 329);
            this.listusu.TabIndex = 0;
            this.listusu.SelectedIndexChanged += new System.EventHandler(this.listusu_SelectedIndexChanged);
            // 
            // btnlistar
            // 
            this.btnlistar.Location = new System.Drawing.Point(713, 203);
            this.btnlistar.Name = "btnlistar";
            this.btnlistar.Size = new System.Drawing.Size(75, 23);
            this.btnlistar.TabIndex = 1;
            this.btnlistar.Text = "Listar";
            this.btnlistar.UseVisualStyleBackColor = true;
            this.btnlistar.Click += new System.EventHandler(this.btnlistar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(154, 182);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(469, 122);
            this.dataGridView2.TabIndex = 2;
            // 
            // Lista_de_pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnlistar);
            this.Controls.Add(this.listusu);
            this.Name = "Lista_de_pacientes";
            this.Text = "Lista_de_pacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listusu;
        private System.Windows.Forms.Button btnlistar;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}