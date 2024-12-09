namespace LocaMais.App
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            usuárioToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            imóvelToolStripMenuItem = new ToolStripMenuItem();
            tipoImóvelToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            próprietárioToolStripMenuItem = new ToolStripMenuItem();
            inquilinoToolStripMenuItem = new ToolStripMenuItem();
            cidadeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            contratoToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblUsuario = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(794, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuárioToolStripMenuItem, toolStripMenuItem2, imóvelToolStripMenuItem, tipoImóvelToolStripMenuItem, toolStripMenuItem1, próprietárioToolStripMenuItem, inquilinoToolStripMenuItem, cidadeToolStripMenuItem, toolStripMenuItem3, contratoToolStripMenuItem });
            cadastrosToolStripMenuItem.Image = Properties.Resources.CadastrosLocaMais;
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(108, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // usuárioToolStripMenuItem
            // 
            usuárioToolStripMenuItem.Image = Properties.Resources.UserLocaMais;
            usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            usuárioToolStripMenuItem.Size = new Size(171, 26);
            usuárioToolStripMenuItem.Text = "Usuário";
            usuárioToolStripMenuItem.Click += usuárioToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(168, 6);
            // 
            // imóvelToolStripMenuItem
            // 
            imóvelToolStripMenuItem.Image = Properties.Resources.PropertyLocaMais;
            imóvelToolStripMenuItem.Name = "imóvelToolStripMenuItem";
            imóvelToolStripMenuItem.Size = new Size(171, 26);
            imóvelToolStripMenuItem.Text = "Imóvel";
            imóvelToolStripMenuItem.Click += imóvelToolStripMenuItem_Click;
            // 
            // tipoImóvelToolStripMenuItem
            // 
            tipoImóvelToolStripMenuItem.Image = Properties.Resources.TypePropertyLocaMais;
            tipoImóvelToolStripMenuItem.Name = "tipoImóvelToolStripMenuItem";
            tipoImóvelToolStripMenuItem.Size = new Size(171, 26);
            tipoImóvelToolStripMenuItem.Text = "Tipo Imóvel";
            tipoImóvelToolStripMenuItem.Click += tipoImóvelToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(168, 6);
            // 
            // próprietárioToolStripMenuItem
            // 
            próprietárioToolStripMenuItem.Image = Properties.Resources.LandlordLocaMais;
            próprietárioToolStripMenuItem.Name = "próprietárioToolStripMenuItem";
            próprietárioToolStripMenuItem.Size = new Size(171, 26);
            próprietárioToolStripMenuItem.Text = "Proprietário";
            próprietárioToolStripMenuItem.Click += próprietárioToolStripMenuItem_Click;
            // 
            // inquilinoToolStripMenuItem
            // 
            inquilinoToolStripMenuItem.Image = Properties.Resources.RenterLocaMais;
            inquilinoToolStripMenuItem.Name = "inquilinoToolStripMenuItem";
            inquilinoToolStripMenuItem.Size = new Size(171, 26);
            inquilinoToolStripMenuItem.Text = "Inquilino";
            inquilinoToolStripMenuItem.Click += inquilinoToolStripMenuItem_Click;
            // 
            // cidadeToolStripMenuItem
            // 
            cidadeToolStripMenuItem.Image = Properties.Resources.CityLocaMais;
            cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            cidadeToolStripMenuItem.Size = new Size(171, 26);
            cidadeToolStripMenuItem.Text = "Cidade";
            cidadeToolStripMenuItem.Click += cidadeToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(168, 6);
            // 
            // contratoToolStripMenuItem
            // 
            contratoToolStripMenuItem.Image = Properties.Resources.ContractLocaMais;
            contratoToolStripMenuItem.Name = "contratoToolStripMenuItem";
            contratoToolStripMenuItem.Size = new Size(171, 26);
            contratoToolStripMenuItem.Text = "Contrato";
            contratoToolStripMenuItem.Click += contratoToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUsuario });
            statusStrip1.Location = new Point(3, 421);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(794, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(66, 20);
            lblUsuario.Text = "Usuário: ";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackGroundLocaMais;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sistema LocaMais";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormPrincipal_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem usuárioToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem imóvelToolStripMenuItem;
        private ToolStripMenuItem tipoImóvelToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem próprietárioToolStripMenuItem;
        private ToolStripMenuItem inquilinoToolStripMenuItem;
        private ToolStripMenuItem cidadeToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem contratoToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUsuario;
    }
}
