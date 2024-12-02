namespace LocaMais.App.Cadastros
{
    partial class CadastroImovel
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
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPrecoAluguel = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            chkDisponivel = new ReaLTaiizor.Controls.MaterialCheckBox();
            cboTipoImovel = new ReaLTaiizor.Controls.MaterialComboBox();
            TabControlCadastro.SuspendLayout();
            TabPageCadastro.SuspendLayout();
            TabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Size = new Size(794, 383);
            // 
            // TabPageCadastro
            // 
            TabPageCadastro.Controls.Add(cboTipoImovel);
            TabPageCadastro.Controls.Add(chkDisponivel);
            TabPageCadastro.Controls.Add(txtPrecoAluguel);
            TabPageCadastro.Controls.Add(txtEndereco);
            TabPageCadastro.Controls.Add(txtId);
            TabPageCadastro.Controls.Add(txtNome);
            TabPageCadastro.Size = new Size(786, 348);
            TabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            TabPageCadastro.Controls.SetChildIndex(txtId, 0);
            TabPageCadastro.Controls.SetChildIndex(txtEndereco, 0);
            TabPageCadastro.Controls.SetChildIndex(txtPrecoAluguel, 0);
            TabPageCadastro.Controls.SetChildIndex(chkDisponivel, 0);
            TabPageCadastro.Controls.SetChildIndex(cboTipoImovel, 0);
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(164, 31);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(599, 48);
            txtNome.TabIndex = 2;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "ID";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(30, 31);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = false;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(115, 48);
            txtId.TabIndex = 3;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtEndereco
            // 
            txtEndereco.AnimateReadOnly = false;
            txtEndereco.AutoCompleteMode = AutoCompleteMode.None;
            txtEndereco.AutoCompleteSource = AutoCompleteSource.None;
            txtEndereco.BackgroundImageLayout = ImageLayout.None;
            txtEndereco.CharacterCasing = CharacterCasing.Normal;
            txtEndereco.Depth = 0;
            txtEndereco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEndereco.HideSelection = true;
            txtEndereco.Hint = "Endereço";
            txtEndereco.LeadingIcon = null;
            txtEndereco.Location = new Point(30, 95);
            txtEndereco.MaxLength = 32767;
            txtEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PasswordChar = '\0';
            txtEndereco.PrefixSuffixText = null;
            txtEndereco.ReadOnly = false;
            txtEndereco.RightToLeft = RightToLeft.No;
            txtEndereco.SelectedText = "";
            txtEndereco.SelectionLength = 0;
            txtEndereco.SelectionStart = 0;
            txtEndereco.ShortcutsEnabled = true;
            txtEndereco.Size = new Size(593, 48);
            txtEndereco.TabIndex = 4;
            txtEndereco.TabStop = false;
            txtEndereco.TextAlign = HorizontalAlignment.Left;
            txtEndereco.TrailingIcon = null;
            txtEndereco.UseSystemPasswordChar = false;
            // 
            // txtPrecoAluguel
            // 
            txtPrecoAluguel.AllowPromptAsInput = true;
            txtPrecoAluguel.AnimateReadOnly = false;
            txtPrecoAluguel.AsciiOnly = false;
            txtPrecoAluguel.BackgroundImageLayout = ImageLayout.None;
            txtPrecoAluguel.BeepOnError = false;
            txtPrecoAluguel.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPrecoAluguel.Depth = 0;
            txtPrecoAluguel.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecoAluguel.HidePromptOnLeave = false;
            txtPrecoAluguel.HideSelection = true;
            txtPrecoAluguel.Hint = "Preço Aluguel";
            txtPrecoAluguel.InsertKeyMode = InsertKeyMode.Default;
            txtPrecoAluguel.LeadingIcon = null;
            txtPrecoAluguel.Location = new Point(461, 163);
            txtPrecoAluguel.Mask = "$ 999,999,99";
            txtPrecoAluguel.MaxLength = 32767;
            txtPrecoAluguel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPrecoAluguel.Name = "txtPrecoAluguel";
            txtPrecoAluguel.PasswordChar = '\0';
            txtPrecoAluguel.PrefixSuffixText = null;
            txtPrecoAluguel.PromptChar = '_';
            txtPrecoAluguel.ReadOnly = false;
            txtPrecoAluguel.RejectInputOnFirstFailure = false;
            txtPrecoAluguel.ResetOnPrompt = true;
            txtPrecoAluguel.ResetOnSpace = true;
            txtPrecoAluguel.RightToLeft = RightToLeft.No;
            txtPrecoAluguel.SelectedText = "";
            txtPrecoAluguel.SelectionLength = 0;
            txtPrecoAluguel.SelectionStart = 0;
            txtPrecoAluguel.ShortcutsEnabled = true;
            txtPrecoAluguel.Size = new Size(302, 48);
            txtPrecoAluguel.SkipLiterals = true;
            txtPrecoAluguel.TabIndex = 6;
            txtPrecoAluguel.TabStop = false;
            txtPrecoAluguel.Text = "R$    .   .";
            txtPrecoAluguel.TextAlign = HorizontalAlignment.Left;
            txtPrecoAluguel.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPrecoAluguel.TrailingIcon = null;
            txtPrecoAluguel.UseSystemPasswordChar = false;
            txtPrecoAluguel.ValidatingType = null;
            // 
            // chkDisponivel
            // 
            chkDisponivel.AutoSize = true;
            chkDisponivel.Depth = 0;
            chkDisponivel.Location = new Point(643, 102);
            chkDisponivel.Margin = new Padding(0);
            chkDisponivel.MouseLocation = new Point(-1, -1);
            chkDisponivel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            chkDisponivel.Name = "chkDisponivel";
            chkDisponivel.ReadOnly = false;
            chkDisponivel.Ripple = true;
            chkDisponivel.Size = new Size(109, 37);
            chkDisponivel.TabIndex = 7;
            chkDisponivel.Text = "Disponível";
            chkDisponivel.UseAccentColor = false;
            chkDisponivel.UseVisualStyleBackColor = true;
            // 
            // cboTipoImovel
            // 
            cboTipoImovel.AutoResize = false;
            cboTipoImovel.BackColor = Color.FromArgb(255, 255, 255);
            cboTipoImovel.Depth = 0;
            cboTipoImovel.DrawMode = DrawMode.OwnerDrawVariable;
            cboTipoImovel.DropDownHeight = 174;
            cboTipoImovel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoImovel.DropDownWidth = 121;
            cboTipoImovel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboTipoImovel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTipoImovel.FormattingEnabled = true;
            cboTipoImovel.Hint = "Tipo de Imóvel";
            cboTipoImovel.IntegralHeight = false;
            cboTipoImovel.ItemHeight = 43;
            cboTipoImovel.Location = new Point(30, 162);
            cboTipoImovel.MaxDropDownItems = 4;
            cboTipoImovel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTipoImovel.Name = "cboTipoImovel";
            cboTipoImovel.Size = new Size(406, 49);
            cboTipoImovel.StartIndex = 0;
            cboTipoImovel.TabIndex = 8;
            // 
            // CadastroImovel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroImovel";
            Text = "Cadastro de Imóvel";
            TabControlCadastro.ResumeLayout(false);
            TabPageCadastro.ResumeLayout(false);
            TabPageCadastro.PerformLayout();
            TabPageConsulta.ResumeLayout(false);
            TabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEndereco;
        private ReaLTaiizor.Controls.MaterialComboBox cboTipoImovel;
        private ReaLTaiizor.Controls.MaterialCheckBox chkDisponivel;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtPrecoAluguel;
    }
}