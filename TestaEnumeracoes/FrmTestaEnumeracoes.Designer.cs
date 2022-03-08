
namespace TestaEnumeracoes
{
    partial class FrmTestaEnumeracoes
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
            this.TabCtrlEnumeracoes = new System.Windows.Forms.TabControl();
            this.TabRegiao = new System.Windows.Forms.TabPage();
            this.TxtBxRegiao = new System.Windows.Forms.TextBox();
            this.LblSelecionarRegiao = new System.Windows.Forms.Label();
            this.CbxRegioes = new System.Windows.Forms.ComboBox();
            this.TabUF = new System.Windows.Forms.TabPage();
            this.TxtBxUF = new System.Windows.Forms.TextBox();
            this.CbxUFs = new System.Windows.Forms.ComboBox();
            this.LblSelecionarUF = new System.Windows.Forms.Label();
            this.TabCtrlEnumeracoes.SuspendLayout();
            this.TabRegiao.SuspendLayout();
            this.TabUF.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabCtrlEnumeracoes
            // 
            this.TabCtrlEnumeracoes.Controls.Add(this.TabRegiao);
            this.TabCtrlEnumeracoes.Controls.Add(this.TabUF);
            this.TabCtrlEnumeracoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabCtrlEnumeracoes.Location = new System.Drawing.Point(0, 0);
            this.TabCtrlEnumeracoes.Name = "TabCtrlEnumeracoes";
            this.TabCtrlEnumeracoes.SelectedIndex = 0;
            this.TabCtrlEnumeracoes.Size = new System.Drawing.Size(384, 249);
            this.TabCtrlEnumeracoes.TabIndex = 0;
            // 
            // TabRegiao
            // 
            this.TabRegiao.Controls.Add(this.TxtBxRegiao);
            this.TabRegiao.Controls.Add(this.LblSelecionarRegiao);
            this.TabRegiao.Controls.Add(this.CbxRegioes);
            this.TabRegiao.Location = new System.Drawing.Point(4, 24);
            this.TabRegiao.Name = "TabRegiao";
            this.TabRegiao.Padding = new System.Windows.Forms.Padding(3);
            this.TabRegiao.Size = new System.Drawing.Size(376, 221);
            this.TabRegiao.TabIndex = 0;
            this.TabRegiao.Text = "Região";
            this.TabRegiao.UseVisualStyleBackColor = true;
            // 
            // TxtBxRegiao
            // 
            this.TxtBxRegiao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBxRegiao.Location = new System.Drawing.Point(16, 72);
            this.TxtBxRegiao.MinimumSize = new System.Drawing.Size(4, 88);
            this.TxtBxRegiao.Multiline = true;
            this.TxtBxRegiao.Name = "TxtBxRegiao";
            this.TxtBxRegiao.ReadOnly = true;
            this.TxtBxRegiao.Size = new System.Drawing.Size(336, 88);
            this.TxtBxRegiao.TabIndex = 2;
            // 
            // LblSelecionarRegiao
            // 
            this.LblSelecionarRegiao.AutoSize = true;
            this.LblSelecionarRegiao.Location = new System.Drawing.Point(16, 15);
            this.LblSelecionarRegiao.Name = "LblSelecionarRegiao";
            this.LblSelecionarRegiao.Size = new System.Drawing.Size(120, 15);
            this.LblSelecionarRegiao.TabIndex = 1;
            this.LblSelecionarRegiao.Text = "Selecione uma região";
            // 
            // CbxRegioes
            // 
            this.CbxRegioes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxRegioes.FormattingEnabled = true;
            this.CbxRegioes.Location = new System.Drawing.Point(16, 33);
            this.CbxRegioes.Name = "CbxRegioes";
            this.CbxRegioes.Size = new System.Drawing.Size(200, 23);
            this.CbxRegioes.TabIndex = 0;
            this.CbxRegioes.SelectedIndexChanged += new System.EventHandler(this.CbxRegioes_SelectedIndexChanged);
            // 
            // TabUF
            // 
            this.TabUF.Controls.Add(this.TxtBxUF);
            this.TabUF.Controls.Add(this.CbxUFs);
            this.TabUF.Controls.Add(this.LblSelecionarUF);
            this.TabUF.Location = new System.Drawing.Point(4, 24);
            this.TabUF.Name = "TabUF";
            this.TabUF.Padding = new System.Windows.Forms.Padding(3);
            this.TabUF.Size = new System.Drawing.Size(376, 221);
            this.TabUF.TabIndex = 1;
            this.TabUF.Text = "UF";
            this.TabUF.UseVisualStyleBackColor = true;
            // 
            // TxtBxUF
            // 
            this.TxtBxUF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBxUF.Location = new System.Drawing.Point(16, 70);
            this.TxtBxUF.MinimumSize = new System.Drawing.Size(4, 88);
            this.TxtBxUF.Multiline = true;
            this.TxtBxUF.Name = "TxtBxUF";
            this.TxtBxUF.ReadOnly = true;
            this.TxtBxUF.Size = new System.Drawing.Size(336, 88);
            this.TxtBxUF.TabIndex = 2;
            // 
            // CbxUFs
            // 
            this.CbxUFs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxUFs.FormattingEnabled = true;
            this.CbxUFs.Location = new System.Drawing.Point(16, 32);
            this.CbxUFs.Name = "CbxUFs";
            this.CbxUFs.Size = new System.Drawing.Size(200, 23);
            this.CbxUFs.TabIndex = 1;
            this.CbxUFs.SelectedIndexChanged += new System.EventHandler(this.CbxUFs_SelectedIndexChanged);
            // 
            // LblSelecionarUF
            // 
            this.LblSelecionarUF.AutoSize = true;
            this.LblSelecionarUF.Location = new System.Drawing.Point(16, 14);
            this.LblSelecionarUF.Name = "LblSelecionarUF";
            this.LblSelecionarUF.Size = new System.Drawing.Size(101, 15);
            this.LblSelecionarUF.TabIndex = 0;
            this.LblSelecionarUF.Text = "Selecione uma UF";
            // 
            // FrmTestaEnumeracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 249);
            this.Controls.Add(this.TabCtrlEnumeracoes);
            this.MinimumSize = new System.Drawing.Size(400, 288);
            this.Name = "FrmTestaEnumeracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste das enumerações";
            this.Load += new System.EventHandler(this.FrmTestaEnumeracoes_Load);
            this.TabCtrlEnumeracoes.ResumeLayout(false);
            this.TabRegiao.ResumeLayout(false);
            this.TabRegiao.PerformLayout();
            this.TabUF.ResumeLayout(false);
            this.TabUF.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabCtrlEnumeracoes;
        private System.Windows.Forms.TabPage TabRegiao;
        private System.Windows.Forms.TabPage TabUF;
        private System.Windows.Forms.ComboBox CbxRegioes;
        private System.Windows.Forms.Label LblSelecionarRegiao;
        private System.Windows.Forms.TextBox TxtBxRegiao;
        private System.Windows.Forms.Label LblSelecionarUF;
        private System.Windows.Forms.ComboBox CbxUFs;
        private System.Windows.Forms.TextBox TxtBxUF;
    }
}

