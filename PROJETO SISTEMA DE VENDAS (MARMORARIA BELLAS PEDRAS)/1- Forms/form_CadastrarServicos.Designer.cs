
namespace PROJETO_SISTEMA_DE_VENDAS__MARMORARIA_BELLAS_PEDRAS_._1__Forms
{
    partial class form_CadastrarServicos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_CadastrarServicos));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.cmbNomeClientes = new System.Windows.Forms.ComboBox();
            this.gdvExibirListaServicos = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.marmorariaDataSet = new PROJETO_SISTEMA_DE_VENDAS__MARMORARIA_BELLAS_PEDRAS_.MarmorariaDataSet();
            this.dataSet1 = new PROJETO_SISTEMA_DE_VENDAS__MARMORARIA_BELLAS_PEDRAS_.DataSet1();
            this.marmorariaDataSet1 = new PROJETO_SISTEMA_DE_VENDAS__MARMORARIA_BELLAS_PEDRAS_.MarmorariaDataSet1();
            this.cmbNomeMateriais = new System.Windows.Forms.ComboBox();
            this.btnCadastrarServico = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.cmbNomeServicos = new System.Windows.Forms.ComboBox();
            this.rtextDescricaoServico = new System.Windows.Forms.RichTextBox();
            this.txtQuantidade = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtComprimento = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtLargura = new Bunifu.UI.WinForms.BunifuTextBox();
            this.X = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdvExibirListaServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marmorariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marmorariaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNomeClientes
            // 
            this.cmbNomeClientes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmbNomeClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNomeClientes.FormattingEnabled = true;
            this.cmbNomeClientes.Location = new System.Drawing.Point(12, 12);
            this.cmbNomeClientes.Name = "cmbNomeClientes";
            this.cmbNomeClientes.Size = new System.Drawing.Size(415, 32);
            this.cmbNomeClientes.TabIndex = 29;
            this.cmbNomeClientes.Text = "[Nome Clientes]";
            // 
            // gdvExibirListaServicos
            // 
            this.gdvExibirListaServicos.AllowCustomTheming = false;
            this.gdvExibirListaServicos.AllowUserToAddRows = false;
            this.gdvExibirListaServicos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gdvExibirListaServicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvExibirListaServicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvExibirListaServicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvExibirListaServicos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdvExibirListaServicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvExibirListaServicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdvExibirListaServicos.ColumnHeadersHeight = 40;
            this.gdvExibirListaServicos.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gdvExibirListaServicos.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gdvExibirListaServicos.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gdvExibirListaServicos.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gdvExibirListaServicos.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gdvExibirListaServicos.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.gdvExibirListaServicos.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gdvExibirListaServicos.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.gdvExibirListaServicos.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gdvExibirListaServicos.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdvExibirListaServicos.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.gdvExibirListaServicos.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gdvExibirListaServicos.CurrentTheme.Name = null;
            this.gdvExibirListaServicos.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdvExibirListaServicos.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gdvExibirListaServicos.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gdvExibirListaServicos.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gdvExibirListaServicos.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvExibirListaServicos.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdvExibirListaServicos.EnableHeadersVisualStyles = false;
            this.gdvExibirListaServicos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gdvExibirListaServicos.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gdvExibirListaServicos.HeaderBgColor = System.Drawing.Color.Empty;
            this.gdvExibirListaServicos.HeaderForeColor = System.Drawing.Color.White;
            this.gdvExibirListaServicos.Location = new System.Drawing.Point(14, 207);
            this.gdvExibirListaServicos.Name = "gdvExibirListaServicos";
            this.gdvExibirListaServicos.ReadOnly = true;
            this.gdvExibirListaServicos.RowHeadersVisible = false;
            this.gdvExibirListaServicos.RowTemplate.Height = 40;
            this.gdvExibirListaServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvExibirListaServicos.Size = new System.Drawing.Size(1175, 343);
            this.gdvExibirListaServicos.TabIndex = 35;
            this.gdvExibirListaServicos.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // marmorariaDataSet
            // 
            this.marmorariaDataSet.DataSetName = "MarmorariaDataSet";
            this.marmorariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marmorariaDataSet1
            // 
            this.marmorariaDataSet1.DataSetName = "MarmorariaDataSet1";
            this.marmorariaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbNomeMateriais
            // 
            this.cmbNomeMateriais.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmbNomeMateriais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNomeMateriais.FormattingEnabled = true;
            this.cmbNomeMateriais.Location = new System.Drawing.Point(433, 12);
            this.cmbNomeMateriais.Name = "cmbNomeMateriais";
            this.cmbNomeMateriais.Size = new System.Drawing.Size(415, 32);
            this.cmbNomeMateriais.TabIndex = 36;
            this.cmbNomeMateriais.Text = "[Nome Materiais]";
            // 
            // btnCadastrarServico
            // 
            this.btnCadastrarServico.AllowAnimations = true;
            this.btnCadastrarServico.AllowMouseEffects = true;
            this.btnCadastrarServico.AllowToggling = false;
            this.btnCadastrarServico.AnimationSpeed = 200;
            this.btnCadastrarServico.AutoGenerateColors = false;
            this.btnCadastrarServico.AutoRoundBorders = false;
            this.btnCadastrarServico.AutoSizeLeftIcon = true;
            this.btnCadastrarServico.AutoSizeRightIcon = true;
            this.btnCadastrarServico.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarServico.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnCadastrarServico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrarServico.BackgroundImage")));
            this.btnCadastrarServico.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCadastrarServico.ButtonText = "CADASTRAR";
            this.btnCadastrarServico.ButtonTextMarginLeft = 0;
            this.btnCadastrarServico.ColorContrastOnClick = 45;
            this.btnCadastrarServico.ColorContrastOnHover = 45;
            this.btnCadastrarServico.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCadastrarServico.CustomizableEdges = borderEdges1;
            this.btnCadastrarServico.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCadastrarServico.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCadastrarServico.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCadastrarServico.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCadastrarServico.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCadastrarServico.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCadastrarServico.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarServico.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarServico.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCadastrarServico.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCadastrarServico.IconMarginLeft = 11;
            this.btnCadastrarServico.IconPadding = 10;
            this.btnCadastrarServico.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarServico.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCadastrarServico.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCadastrarServico.IconSize = 25;
            this.btnCadastrarServico.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnCadastrarServico.IdleBorderRadius = 28;
            this.btnCadastrarServico.IdleBorderThickness = 1;
            this.btnCadastrarServico.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnCadastrarServico.IdleIconLeftImage = null;
            this.btnCadastrarServico.IdleIconRightImage = null;
            this.btnCadastrarServico.IndicateFocus = false;
            this.btnCadastrarServico.Location = new System.Drawing.Point(875, 9);
            this.btnCadastrarServico.Name = "btnCadastrarServico";
            this.btnCadastrarServico.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCadastrarServico.OnDisabledState.BorderRadius = 28;
            this.btnCadastrarServico.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCadastrarServico.OnDisabledState.BorderThickness = 1;
            this.btnCadastrarServico.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCadastrarServico.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCadastrarServico.OnDisabledState.IconLeftImage = null;
            this.btnCadastrarServico.OnDisabledState.IconRightImage = null;
            this.btnCadastrarServico.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnCadastrarServico.onHoverState.BorderRadius = 28;
            this.btnCadastrarServico.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCadastrarServico.onHoverState.BorderThickness = 1;
            this.btnCadastrarServico.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnCadastrarServico.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarServico.onHoverState.IconLeftImage = null;
            this.btnCadastrarServico.onHoverState.IconRightImage = null;
            this.btnCadastrarServico.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnCadastrarServico.OnIdleState.BorderRadius = 28;
            this.btnCadastrarServico.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCadastrarServico.OnIdleState.BorderThickness = 1;
            this.btnCadastrarServico.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnCadastrarServico.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarServico.OnIdleState.IconLeftImage = null;
            this.btnCadastrarServico.OnIdleState.IconRightImage = null;
            this.btnCadastrarServico.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnCadastrarServico.OnPressedState.BorderRadius = 28;
            this.btnCadastrarServico.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCadastrarServico.OnPressedState.BorderThickness = 1;
            this.btnCadastrarServico.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnCadastrarServico.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarServico.OnPressedState.IconLeftImage = null;
            this.btnCadastrarServico.OnPressedState.IconRightImage = null;
            this.btnCadastrarServico.Size = new System.Drawing.Size(285, 37);
            this.btnCadastrarServico.TabIndex = 37;
            this.btnCadastrarServico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCadastrarServico.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCadastrarServico.TextMarginLeft = 0;
            this.btnCadastrarServico.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCadastrarServico.UseDefaultRadiusAndThickness = true;
            // 
            // cmbNomeServicos
            // 
            this.cmbNomeServicos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmbNomeServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNomeServicos.FormattingEnabled = true;
            this.cmbNomeServicos.Items.AddRange(new object[] {
            "PEITORIL",
            "SOLEIRA",
            "BANCADA",
            "BALCAO",
            "REQUADRAÇAO",
            "ESCADA",
            "RODAPE",
            "",
            ""});
            this.cmbNomeServicos.Location = new System.Drawing.Point(64, 57);
            this.cmbNomeServicos.Name = "cmbNomeServicos";
            this.cmbNomeServicos.Size = new System.Drawing.Size(363, 32);
            this.cmbNomeServicos.TabIndex = 38;
            this.cmbNomeServicos.Text = "[Nome Serviços]";
            // 
            // rtextDescricaoServico
            // 
            this.rtextDescricaoServico.Location = new System.Drawing.Point(14, 101);
            this.rtextDescricaoServico.Name = "rtextDescricaoServico";
            this.rtextDescricaoServico.Size = new System.Drawing.Size(834, 96);
            this.rtextDescricaoServico.TabIndex = 39;
            this.rtextDescricaoServico.Text = "DESCRIÇAO DO SERVIÇO";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.AcceptsReturn = false;
            this.txtQuantidade.AcceptsTab = false;
            this.txtQuantidade.AnimationSpeed = 200;
            this.txtQuantidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtQuantidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantidade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtQuantidade.BackgroundImage")));
            this.txtQuantidade.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtQuantidade.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtQuantidade.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtQuantidade.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtQuantidade.BorderRadius = 1;
            this.txtQuantidade.BorderThickness = 1;
            this.txtQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtQuantidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantidade.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtQuantidade.DefaultText = "";
            this.txtQuantidade.FillColor = System.Drawing.Color.White;
            this.txtQuantidade.HideSelection = true;
            this.txtQuantidade.IconLeft = null;
            this.txtQuantidade.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantidade.IconPadding = 10;
            this.txtQuantidade.IconRight = null;
            this.txtQuantidade.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantidade.Lines = new string[0];
            this.txtQuantidade.Location = new System.Drawing.Point(14, 57);
            this.txtQuantidade.MaxLength = 32767;
            this.txtQuantidade.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtQuantidade.Modified = false;
            this.txtQuantidade.Multiline = false;
            this.txtQuantidade.Name = "txtQuantidade";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQuantidade.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtQuantidade.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQuantidade.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQuantidade.OnIdleState = stateProperties4;
            this.txtQuantidade.Padding = new System.Windows.Forms.Padding(3);
            this.txtQuantidade.PasswordChar = '\0';
            this.txtQuantidade.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtQuantidade.PlaceholderText = "Qtd.";
            this.txtQuantidade.ReadOnly = false;
            this.txtQuantidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantidade.SelectedText = "";
            this.txtQuantidade.SelectionLength = 0;
            this.txtQuantidade.SelectionStart = 0;
            this.txtQuantidade.ShortcutsEnabled = true;
            this.txtQuantidade.Size = new System.Drawing.Size(46, 32);
            this.txtQuantidade.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtQuantidade.TabIndex = 40;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuantidade.TextMarginBottom = 0;
            this.txtQuantidade.TextMarginLeft = 3;
            this.txtQuantidade.TextMarginTop = 0;
            this.txtQuantidade.TextPlaceholder = "Qtd.";
            this.txtQuantidade.UseSystemPasswordChar = false;
            this.txtQuantidade.WordWrap = true;
            // 
            // txtComprimento
            // 
            this.txtComprimento.AcceptsReturn = false;
            this.txtComprimento.AcceptsTab = false;
            this.txtComprimento.AnimationSpeed = 200;
            this.txtComprimento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtComprimento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtComprimento.BackColor = System.Drawing.Color.Transparent;
            this.txtComprimento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtComprimento.BackgroundImage")));
            this.txtComprimento.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtComprimento.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtComprimento.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtComprimento.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtComprimento.BorderRadius = 1;
            this.txtComprimento.BorderThickness = 1;
            this.txtComprimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtComprimento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComprimento.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtComprimento.DefaultText = "";
            this.txtComprimento.FillColor = System.Drawing.Color.White;
            this.txtComprimento.HideSelection = true;
            this.txtComprimento.IconLeft = null;
            this.txtComprimento.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComprimento.IconPadding = 10;
            this.txtComprimento.IconRight = null;
            this.txtComprimento.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComprimento.Lines = new string[0];
            this.txtComprimento.Location = new System.Drawing.Point(433, 57);
            this.txtComprimento.MaxLength = 32767;
            this.txtComprimento.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtComprimento.Modified = false;
            this.txtComprimento.Multiline = false;
            this.txtComprimento.Name = "txtComprimento";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtComprimento.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtComprimento.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtComprimento.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtComprimento.OnIdleState = stateProperties8;
            this.txtComprimento.Padding = new System.Windows.Forms.Padding(3);
            this.txtComprimento.PasswordChar = '\0';
            this.txtComprimento.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtComprimento.PlaceholderText = "Comprimento";
            this.txtComprimento.ReadOnly = false;
            this.txtComprimento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComprimento.SelectedText = "";
            this.txtComprimento.SelectionLength = 0;
            this.txtComprimento.SelectionStart = 0;
            this.txtComprimento.ShortcutsEnabled = true;
            this.txtComprimento.Size = new System.Drawing.Size(184, 32);
            this.txtComprimento.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtComprimento.TabIndex = 41;
            this.txtComprimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtComprimento.TextMarginBottom = 0;
            this.txtComprimento.TextMarginLeft = 3;
            this.txtComprimento.TextMarginTop = 0;
            this.txtComprimento.TextPlaceholder = "Comprimento";
            this.txtComprimento.UseSystemPasswordChar = false;
            this.txtComprimento.WordWrap = true;
            // 
            // txtLargura
            // 
            this.txtLargura.AcceptsReturn = false;
            this.txtLargura.AcceptsTab = false;
            this.txtLargura.AnimationSpeed = 200;
            this.txtLargura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLargura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLargura.BackColor = System.Drawing.Color.Transparent;
            this.txtLargura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtLargura.BackgroundImage")));
            this.txtLargura.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtLargura.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtLargura.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtLargura.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtLargura.BorderRadius = 1;
            this.txtLargura.BorderThickness = 1;
            this.txtLargura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLargura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLargura.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtLargura.DefaultText = "";
            this.txtLargura.FillColor = System.Drawing.Color.White;
            this.txtLargura.HideSelection = true;
            this.txtLargura.IconLeft = null;
            this.txtLargura.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLargura.IconPadding = 10;
            this.txtLargura.IconRight = null;
            this.txtLargura.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLargura.Lines = new string[0];
            this.txtLargura.Location = new System.Drawing.Point(664, 57);
            this.txtLargura.MaxLength = 32767;
            this.txtLargura.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtLargura.Modified = false;
            this.txtLargura.Multiline = false;
            this.txtLargura.Name = "txtLargura";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLargura.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtLargura.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLargura.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLargura.OnIdleState = stateProperties12;
            this.txtLargura.Padding = new System.Windows.Forms.Padding(3);
            this.txtLargura.PasswordChar = '\0';
            this.txtLargura.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtLargura.PlaceholderText = "Largura";
            this.txtLargura.ReadOnly = false;
            this.txtLargura.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLargura.SelectedText = "";
            this.txtLargura.SelectionLength = 0;
            this.txtLargura.SelectionStart = 0;
            this.txtLargura.ShortcutsEnabled = true;
            this.txtLargura.Size = new System.Drawing.Size(184, 32);
            this.txtLargura.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtLargura.TabIndex = 42;
            this.txtLargura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLargura.TextMarginBottom = 0;
            this.txtLargura.TextMarginLeft = 3;
            this.txtLargura.TextMarginTop = 0;
            this.txtLargura.TextPlaceholder = "Largura";
            this.txtLargura.UseSystemPasswordChar = false;
            this.txtLargura.WordWrap = true;
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.Location = new System.Drawing.Point(631, 64);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(18, 18);
            this.X.TabIndex = 43;
            this.X.Text = "X";
            // 
            // form_CadastrarServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1170, 484);
            this.Controls.Add(this.X);
            this.Controls.Add(this.txtLargura);
            this.Controls.Add(this.txtComprimento);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.rtextDescricaoServico);
            this.Controls.Add(this.cmbNomeServicos);
            this.Controls.Add(this.btnCadastrarServico);
            this.Controls.Add(this.cmbNomeMateriais);
            this.Controls.Add(this.gdvExibirListaServicos);
            this.Controls.Add(this.cmbNomeClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_CadastrarServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_CadastrarServicos";
            this.Load += new System.EventHandler(this.form_CadastrarServicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvExibirListaServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marmorariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marmorariaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNomeClientes;
        public Bunifu.UI.WinForms.BunifuDataGridView gdvExibirListaServicos;
        private MarmorariaDataSet marmorariaDataSet;
        private DataSet1 dataSet1;
        private MarmorariaDataSet1 marmorariaDataSet1;
        private System.Windows.Forms.ComboBox cmbNomeMateriais;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCadastrarServico;
        private System.Windows.Forms.ComboBox cmbNomeServicos;
        private System.Windows.Forms.RichTextBox rtextDescricaoServico;
        private Bunifu.UI.WinForms.BunifuTextBox txtQuantidade;
        private Bunifu.UI.WinForms.BunifuTextBox txtComprimento;
        private Bunifu.UI.WinForms.BunifuTextBox txtLargura;
        private System.Windows.Forms.Label X;
    }
}