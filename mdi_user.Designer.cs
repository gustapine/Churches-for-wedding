namespace churches
{
    partial class mdi_user
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.igrejasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicioneNovasIgrejasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizeAsIgrejasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.igrejasToolStripMenuItem,
            this.usuárioToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(633, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // igrejasToolStripMenuItem
            // 
            this.igrejasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicioneNovasIgrejasToolStripMenuItem,
            this.vizualizeAsIgrejasToolStripMenuItem});
            this.igrejasToolStripMenuItem.Name = "igrejasToolStripMenuItem";
            this.igrejasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.igrejasToolStripMenuItem.Text = "Igrejas";
            // 
            // adicioneNovasIgrejasToolStripMenuItem
            // 
            this.adicioneNovasIgrejasToolStripMenuItem.Name = "adicioneNovasIgrejasToolStripMenuItem";
            this.adicioneNovasIgrejasToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.adicioneNovasIgrejasToolStripMenuItem.Text = "Adicione novas igrejas";
            this.adicioneNovasIgrejasToolStripMenuItem.Click += new System.EventHandler(this.adicioneNovasIgrejasToolStripMenuItem_Click);
            // 
            // vizualizeAsIgrejasToolStripMenuItem
            // 
            this.vizualizeAsIgrejasToolStripMenuItem.Name = "vizualizeAsIgrejasToolStripMenuItem";
            this.vizualizeAsIgrejasToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.vizualizeAsIgrejasToolStripMenuItem.Text = "Vizualize as igrejas";
            this.vizualizeAsIgrejasToolStripMenuItem.Click += new System.EventHandler(this.vizualizeAsIgrejasToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarUsuárioToolStripMenuItem,
            this.verToolStripMenuItem});
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // adicionarUsuárioToolStripMenuItem
            // 
            this.adicionarUsuárioToolStripMenuItem.Name = "adicionarUsuárioToolStripMenuItem";
            this.adicionarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.adicionarUsuárioToolStripMenuItem.Text = "Adicionar usuário";
            this.adicionarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.adicionarUsuárioToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.verToolStripMenuItem.Text = "Ver informações do usuário";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 348);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(633, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // mdi_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(633, 370);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "mdi_user";
            this.Text = "MDIParent1";
            this.Load += new System.EventHandler(this.mdi_user_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem igrejasToolStripMenuItem;
        private ToolStripMenuItem adicioneNovasIgrejasToolStripMenuItem;
        private ToolStripMenuItem vizualizeAsIgrejasToolStripMenuItem;
        private ToolStripMenuItem usuárioToolStripMenuItem;
        private ToolStripMenuItem adicionarUsuárioToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
    }
}



