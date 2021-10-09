
namespace CursoWindowsForms
{
    partial class Frm_DemonstracaoKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DemonstracaoKey));
            this.Txt_Entrada = new System.Windows.Forms.TextBox();
            this.Txt_Informacoes = new System.Windows.Forms.TextBox();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Lbl_Maiuscula = new System.Windows.Forms.Label();
            this.Lbl_Minuscula = new System.Windows.Forms.Label();
            this.Lbl_ResultadoMinuscula = new System.Windows.Forms.Label();
            this.Lbl_ResultadoMaiuscula = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Entrada
            // 
            this.Txt_Entrada.Location = new System.Drawing.Point(8, 8);
            this.Txt_Entrada.Name = "Txt_Entrada";
            this.Txt_Entrada.Size = new System.Drawing.Size(100, 20);
            this.Txt_Entrada.TabIndex = 0;
            this.Txt_Entrada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Entrada_KeyDown);
            // 
            // Txt_Informacoes
            // 
            this.Txt_Informacoes.Location = new System.Drawing.Point(8, 40);
            this.Txt_Informacoes.Multiline = true;
            this.Txt_Informacoes.Name = "Txt_Informacoes";
            this.Txt_Informacoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_Informacoes.Size = new System.Drawing.Size(304, 232);
            this.Txt_Informacoes.TabIndex = 1;
            this.Txt_Informacoes.TabStop = false;
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Location = new System.Drawing.Point(328, 8);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(75, 28);
            this.Btn_Limpar.TabIndex = 2;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Lbl_Maiuscula
            // 
            this.Lbl_Maiuscula.AutoSize = true;
            this.Lbl_Maiuscula.Location = new System.Drawing.Point(320, 106);
            this.Lbl_Maiuscula.Name = "Lbl_Maiuscula";
            this.Lbl_Maiuscula.Size = new System.Drawing.Size(55, 13);
            this.Lbl_Maiuscula.TabIndex = 3;
            this.Lbl_Maiuscula.Text = "Maiúscula";
            // 
            // Lbl_Minuscula
            // 
            this.Lbl_Minuscula.AutoSize = true;
            this.Lbl_Minuscula.Location = new System.Drawing.Point(320, 56);
            this.Lbl_Minuscula.Name = "Lbl_Minuscula";
            this.Lbl_Minuscula.Size = new System.Drawing.Size(55, 13);
            this.Lbl_Minuscula.TabIndex = 4;
            this.Lbl_Minuscula.Text = "Minúscula";
            // 
            // Lbl_ResultadoMinuscula
            // 
            this.Lbl_ResultadoMinuscula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_ResultadoMinuscula.Location = new System.Drawing.Point(323, 69);
            this.Lbl_ResultadoMinuscula.Name = "Lbl_ResultadoMinuscula";
            this.Lbl_ResultadoMinuscula.Size = new System.Drawing.Size(49, 23);
            this.Lbl_ResultadoMinuscula.TabIndex = 5;
            // 
            // Lbl_ResultadoMaiuscula
            // 
            this.Lbl_ResultadoMaiuscula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_ResultadoMaiuscula.Location = new System.Drawing.Point(323, 119);
            this.Lbl_ResultadoMaiuscula.Name = "Lbl_ResultadoMaiuscula";
            this.Lbl_ResultadoMaiuscula.Size = new System.Drawing.Size(49, 23);
            this.Lbl_ResultadoMaiuscula.TabIndex = 6;
            // 
            // Frm_DemonstracaoKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 281);
            this.Controls.Add(this.Lbl_ResultadoMaiuscula);
            this.Controls.Add(this.Lbl_ResultadoMinuscula);
            this.Controls.Add(this.Lbl_Minuscula);
            this.Controls.Add(this.Lbl_Maiuscula);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Txt_Informacoes);
            this.Controls.Add(this.Txt_Entrada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_DemonstracaoKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstração Evento Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Entrada;
        private System.Windows.Forms.TextBox Txt_Informacoes;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.Label Lbl_Maiuscula;
        private System.Windows.Forms.Label Lbl_Minuscula;
        private System.Windows.Forms.Label Lbl_ResultadoMinuscula;
        private System.Windows.Forms.Label Lbl_ResultadoMaiuscula;
    }
}