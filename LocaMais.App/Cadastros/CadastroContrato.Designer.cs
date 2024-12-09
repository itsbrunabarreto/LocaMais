namespace LocaMais.App.Cadastros
{
    partial class CadastroContrato
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
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtValorAluguel = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtDataInicio = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtDataFim = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cboProprietario = new ReaLTaiizor.Controls.MaterialComboBox();
            cboInquilino = new ReaLTaiizor.Controls.MaterialComboBox();
            cboImovel = new ReaLTaiizor.Controls.MaterialComboBox();
            TabControlCadastro.SuspendLayout();
            TabPageCadastro.SuspendLayout();
            TabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Size = new Size(696, 414);
            // 
            // TabPageCadastro
            // 
            TabPageCadastro.Controls.Add(cboImovel);
            TabPageCadastro.Controls.Add(cboInquilino);
            TabPageCadastro.Controls.Add(cboProprietario);
            TabPageCadastro.Controls.Add(txtDataFim);
            TabPageCadastro.Controls.Add(txtDataInicio);
            TabPageCadastro.Controls.Add(txtValorAluguel);
            TabPageCadastro.Controls.Add(txtId);
            TabPageCadastro.Size = new Size(688, 379);
            TabPageCadastro.Controls.SetChildIndex(txtId, 0);
            TabPageCadastro.Controls.SetChildIndex(txtValorAluguel, 0);
            TabPageCadastro.Controls.SetChildIndex(txtDataInicio, 0);
            TabPageCadastro.Controls.SetChildIndex(txtDataFim, 0);
            TabPageCadastro.Controls.SetChildIndex(cboProprietario, 0);
            TabPageCadastro.Controls.SetChildIndex(cboInquilino, 0);
            TabPageCadastro.Controls.SetChildIndex(cboImovel, 0);
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(600, 327);
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(521, 327);
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(449, 327);
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
            txtId.Location = new Point(35, 28);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(116, 48);
            txtId.TabIndex = 2;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtValorAluguel
            // 
            txtValorAluguel.AllowPromptAsInput = true;
            txtValorAluguel.AnimateReadOnly = false;
            txtValorAluguel.AsciiOnly = false;
            txtValorAluguel.BackgroundImageLayout = ImageLayout.None;
            txtValorAluguel.BeepOnError = false;
            txtValorAluguel.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtValorAluguel.Depth = 0;
            txtValorAluguel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtValorAluguel.HidePromptOnLeave = false;
            txtValorAluguel.HideSelection = true;
            txtValorAluguel.Hint = "Valor Aluguel";
            txtValorAluguel.InsertKeyMode = InsertKeyMode.Default;
            txtValorAluguel.LeadingIcon = null;
            txtValorAluguel.Location = new Point(170, 28);
            txtValorAluguel.Mask = "$999,999.99";
            txtValorAluguel.MaxLength = 32767;
            txtValorAluguel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtValorAluguel.Name = "txtValorAluguel";
            txtValorAluguel.PasswordChar = '\0';
            txtValorAluguel.PrefixSuffixText = null;
            txtValorAluguel.PromptChar = '_';
            txtValorAluguel.ReadOnly = false;
            txtValorAluguel.RejectInputOnFirstFailure = false;
            txtValorAluguel.ResetOnPrompt = true;
            txtValorAluguel.ResetOnSpace = true;
            txtValorAluguel.RightToLeft = RightToLeft.No;
            txtValorAluguel.SelectedText = "";
            txtValorAluguel.SelectionLength = 0;
            txtValorAluguel.SelectionStart = 0;
            txtValorAluguel.ShortcutsEnabled = true;
            txtValorAluguel.Size = new Size(168, 48);
            txtValorAluguel.SkipLiterals = true;
            txtValorAluguel.TabIndex = 3;
            txtValorAluguel.TabStop = false;
            txtValorAluguel.Text = "R$   .   ,";
            txtValorAluguel.TextAlign = HorizontalAlignment.Left;
            txtValorAluguel.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtValorAluguel.TrailingIcon = null;
            txtValorAluguel.UseSystemPasswordChar = false;
            txtValorAluguel.ValidatingType = null;
            // 
            // txtDataInicio
            // 
            txtDataInicio.AllowPromptAsInput = true;
            txtDataInicio.AnimateReadOnly = false;
            txtDataInicio.AsciiOnly = false;
            txtDataInicio.BackgroundImageLayout = ImageLayout.None;
            txtDataInicio.BeepOnError = false;
            txtDataInicio.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataInicio.Depth = 0;
            txtDataInicio.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataInicio.HidePromptOnLeave = false;
            txtDataInicio.HideSelection = true;
            txtDataInicio.Hint = "Data Início";
            txtDataInicio.InsertKeyMode = InsertKeyMode.Default;
            txtDataInicio.LeadingIcon = null;
            txtDataInicio.Location = new Point(356, 28);
            txtDataInicio.Mask = "99/99/9999";
            txtDataInicio.MaxLength = 32767;
            txtDataInicio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataInicio.Name = "txtDataInicio";
            txtDataInicio.PasswordChar = '\0';
            txtDataInicio.PrefixSuffixText = null;
            txtDataInicio.PromptChar = '_';
            txtDataInicio.ReadOnly = false;
            txtDataInicio.RejectInputOnFirstFailure = false;
            txtDataInicio.ResetOnPrompt = true;
            txtDataInicio.ResetOnSpace = true;
            txtDataInicio.RightToLeft = RightToLeft.No;
            txtDataInicio.SelectedText = "";
            txtDataInicio.SelectionLength = 0;
            txtDataInicio.SelectionStart = 0;
            txtDataInicio.ShortcutsEnabled = true;
            txtDataInicio.Size = new Size(141, 48);
            txtDataInicio.SkipLiterals = true;
            txtDataInicio.TabIndex = 4;
            txtDataInicio.TabStop = false;
            txtDataInicio.Text = "  /  /";
            txtDataInicio.TextAlign = HorizontalAlignment.Left;
            txtDataInicio.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataInicio.TrailingIcon = null;
            txtDataInicio.UseSystemPasswordChar = false;
            txtDataInicio.ValidatingType = null;
            // 
            // txtDataFim
            // 
            txtDataFim.AllowPromptAsInput = true;
            txtDataFim.AnimateReadOnly = false;
            txtDataFim.AsciiOnly = false;
            txtDataFim.BackgroundImageLayout = ImageLayout.None;
            txtDataFim.BeepOnError = false;
            txtDataFim.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataFim.Depth = 0;
            txtDataFim.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataFim.HidePromptOnLeave = false;
            txtDataFim.HideSelection = true;
            txtDataFim.Hint = "Data Fim";
            txtDataFim.InsertKeyMode = InsertKeyMode.Default;
            txtDataFim.LeadingIcon = null;
            txtDataFim.Location = new Point(514, 28);
            txtDataFim.Mask = "99/99/9999";
            txtDataFim.MaxLength = 32767;
            txtDataFim.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataFim.Name = "txtDataFim";
            txtDataFim.PasswordChar = '\0';
            txtDataFim.PrefixSuffixText = null;
            txtDataFim.PromptChar = '_';
            txtDataFim.ReadOnly = false;
            txtDataFim.RejectInputOnFirstFailure = false;
            txtDataFim.ResetOnPrompt = true;
            txtDataFim.ResetOnSpace = true;
            txtDataFim.RightToLeft = RightToLeft.No;
            txtDataFim.SelectedText = "";
            txtDataFim.SelectionLength = 0;
            txtDataFim.SelectionStart = 0;
            txtDataFim.ShortcutsEnabled = true;
            txtDataFim.Size = new Size(141, 48);
            txtDataFim.SkipLiterals = true;
            txtDataFim.TabIndex = 5;
            txtDataFim.TabStop = false;
            txtDataFim.Text = "  /  /";
            txtDataFim.TextAlign = HorizontalAlignment.Left;
            txtDataFim.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataFim.TrailingIcon = null;
            txtDataFim.UseSystemPasswordChar = false;
            txtDataFim.ValidatingType = null;
            // 
            // cboProprietario
            // 
            cboProprietario.AutoResize = false;
            cboProprietario.BackColor = Color.FromArgb(255, 255, 255);
            cboProprietario.Depth = 0;
            cboProprietario.DrawMode = DrawMode.OwnerDrawVariable;
            cboProprietario.DropDownHeight = 174;
            cboProprietario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProprietario.DropDownWidth = 121;
            cboProprietario.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboProprietario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboProprietario.FormattingEnabled = true;
            cboProprietario.Hint = "Proprietário";
            cboProprietario.IntegralHeight = false;
            cboProprietario.ItemHeight = 43;
            cboProprietario.Location = new Point(35, 100);
            cboProprietario.MaxDropDownItems = 4;
            cboProprietario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboProprietario.Name = "cboProprietario";
            cboProprietario.Size = new Size(620, 49);
            cboProprietario.StartIndex = 0;
            cboProprietario.TabIndex = 6;
            // 
            // cboInquilino
            // 
            cboInquilino.AutoResize = false;
            cboInquilino.BackColor = Color.FromArgb(255, 255, 255);
            cboInquilino.Depth = 0;
            cboInquilino.DrawMode = DrawMode.OwnerDrawVariable;
            cboInquilino.DropDownHeight = 174;
            cboInquilino.DropDownStyle = ComboBoxStyle.DropDownList;
            cboInquilino.DropDownWidth = 121;
            cboInquilino.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboInquilino.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboInquilino.FormattingEnabled = true;
            cboInquilino.Hint = "Inquilino";
            cboInquilino.IntegralHeight = false;
            cboInquilino.ItemHeight = 43;
            cboInquilino.Location = new Point(35, 172);
            cboInquilino.MaxDropDownItems = 4;
            cboInquilino.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboInquilino.Name = "cboInquilino";
            cboInquilino.Size = new Size(620, 49);
            cboInquilino.StartIndex = 0;
            cboInquilino.TabIndex = 7;
            // 
            // cboImovel
            // 
            cboImovel.AutoResize = false;
            cboImovel.BackColor = Color.FromArgb(255, 255, 255);
            cboImovel.Depth = 0;
            cboImovel.DrawMode = DrawMode.OwnerDrawVariable;
            cboImovel.DropDownHeight = 174;
            cboImovel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboImovel.DropDownWidth = 121;
            cboImovel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboImovel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboImovel.FormattingEnabled = true;
            cboImovel.Hint = "Imóvel";
            cboImovel.IntegralHeight = false;
            cboImovel.ItemHeight = 43;
            cboImovel.Location = new Point(35, 241);
            cboImovel.MaxDropDownItems = 4;
            cboImovel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboImovel.Name = "cboImovel";
            cboImovel.Size = new Size(620, 49);
            cboImovel.StartIndex = 0;
            cboImovel.TabIndex = 8;
            // 
            // CadastroContrato
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 481);
            Location = new Point(0, 0);
            Name = "CadastroContrato";
            Text = "Cadastro de Contrato";
            TabControlCadastro.ResumeLayout(false);
            TabPageCadastro.ResumeLayout(false);
            TabPageCadastro.PerformLayout();
            TabPageConsulta.ResumeLayout(false);
            TabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtValorAluguel;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataInicio;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataFim;
        private ReaLTaiizor.Controls.MaterialComboBox cboInquilino;
        private ReaLTaiizor.Controls.MaterialComboBox cboProprietario;
        private ReaLTaiizor.Controls.MaterialComboBox cboImovel;
    }
}