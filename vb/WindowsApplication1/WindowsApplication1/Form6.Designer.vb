<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Id__AuteurLabel As System.Windows.Forms.Label
        Dim Nom_AuteurLabel As System.Windows.Forms.Label
        Dim Prenom_AuteurLabel As System.Windows.Forms.Label
        Dim Date_nai_AuteurLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.DataDataSet = New WindowsApplication1.DataDataSet()
        Me.AuteurBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuteurTableAdapter = New WindowsApplication1.DataDataSetTableAdapters.AuteurTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.DataDataSetTableAdapters.TableAdapterManager()
        Me.Type_livreTableAdapter = New WindowsApplication1.DataDataSetTableAdapters.type_livreTableAdapter()
        Me.Type_livreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GunaLineTextBox3 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLineTextBox2 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLineTextBox1 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaDateTimePicker1 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.BunifuCustomDataGrid1 = New ns1.BunifuCustomDataGrid()
        Me.IdAuteurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomAuteurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrenomAuteurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatenaiAuteurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuteurBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TypelivreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GunaAdvenceTileButton5 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaAdvenceTileButton2 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaAdvenceTileButton1 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaAdvenceTileButton3 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaAdvenceTileButton4 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.BunifuMaterialTextbox1 = New ns1.BunifuMaterialTextbox()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Id__AuteurLabel = New System.Windows.Forms.Label()
        Nom_AuteurLabel = New System.Windows.Forms.Label()
        Prenom_AuteurLabel = New System.Windows.Forms.Label()
        Date_nai_AuteurLabel = New System.Windows.Forms.Label()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuteurBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Type_livreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuteurBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypelivreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id__AuteurLabel
        '
        Id__AuteurLabel.AutoSize = True
        Id__AuteurLabel.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Id__AuteurLabel.Location = New System.Drawing.Point(42, 560)
        Id__AuteurLabel.Name = "Id__AuteurLabel"
        Id__AuteurLabel.Size = New System.Drawing.Size(96, 22)
        Id__AuteurLabel.TabIndex = 1
        Id__AuteurLabel.Text = "Id Auteur:"
        '
        'Nom_AuteurLabel
        '
        Nom_AuteurLabel.AutoSize = True
        Nom_AuteurLabel.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Nom_AuteurLabel.Location = New System.Drawing.Point(42, 616)
        Nom_AuteurLabel.Name = "Nom_AuteurLabel"
        Nom_AuteurLabel.Size = New System.Drawing.Size(120, 22)
        Nom_AuteurLabel.TabIndex = 3
        Nom_AuteurLabel.Text = "Nom Auteur:"
        '
        'Prenom_AuteurLabel
        '
        Prenom_AuteurLabel.AutoSize = True
        Prenom_AuteurLabel.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Prenom_AuteurLabel.Location = New System.Drawing.Point(700, 560)
        Prenom_AuteurLabel.Name = "Prenom_AuteurLabel"
        Prenom_AuteurLabel.Size = New System.Drawing.Size(142, 22)
        Prenom_AuteurLabel.TabIndex = 5
        Prenom_AuteurLabel.Text = "Prenom Auteur:"
        '
        'Date_nai_AuteurLabel
        '
        Date_nai_AuteurLabel.AutoSize = True
        Date_nai_AuteurLabel.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Date_nai_AuteurLabel.Location = New System.Drawing.Point(700, 610)
        Date_nai_AuteurLabel.Name = "Date_nai_AuteurLabel"
        Date_nai_AuteurLabel.Size = New System.Drawing.Size(211, 22)
        Date_nai_AuteurLabel.TabIndex = 7
        Date_nai_AuteurLabel.Text = "Date Naissance Auteur:"
        '
        'DataDataSet
        '
        Me.DataDataSet.DataSetName = "DataDataSet"
        Me.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AuteurBindingSource
        '
        Me.AuteurBindingSource.DataMember = "Auteur"
        Me.AuteurBindingSource.DataSource = Me.DataDataSet
        '
        'AuteurTableAdapter
        '
        Me.AuteurTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.administrateurTableAdapter = Nothing
        Me.TableAdapterManager.AuteurTableAdapter = Me.AuteurTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BoissonTableAdapter = Nothing
        Me.TableAdapterManager.ClientTableAdapter = Nothing
        Me.TableAdapterManager.facture_BoissonTableAdapter = Nothing
        Me.TableAdapterManager.FactureTableAdapter = Nothing
        Me.TableAdapterManager.LivreTableAdapter = Nothing
        Me.TableAdapterManager.type_livreTableAdapter = Me.Type_livreTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.DataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Type_livreTableAdapter
        '
        Me.Type_livreTableAdapter.ClearBeforeFill = True
        '
        'Type_livreBindingSource
        '
        Me.Type_livreBindingSource.DataMember = "type_livre"
        Me.Type_livreBindingSource.DataSource = Me.DataDataSet
        '
        'GunaLineTextBox3
        '
        Me.GunaLineTextBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLineTextBox3.BackColor = System.Drawing.Color.White
        Me.GunaLineTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox3.FocusedLineColor = System.Drawing.Color.Gray
        Me.GunaLineTextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox3.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLineTextBox3.Location = New System.Drawing.Point(1021, 552)
        Me.GunaLineTextBox3.Name = "GunaLineTextBox3"
        Me.GunaLineTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox3.SelectedText = ""
        Me.GunaLineTextBox3.Size = New System.Drawing.Size(256, 30)
        Me.GunaLineTextBox3.TabIndex = 27
        '
        'GunaLineTextBox2
        '
        Me.GunaLineTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLineTextBox2.BackColor = System.Drawing.Color.White
        Me.GunaLineTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox2.FocusedLineColor = System.Drawing.Color.Gray
        Me.GunaLineTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox2.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLineTextBox2.Location = New System.Drawing.Point(363, 608)
        Me.GunaLineTextBox2.Name = "GunaLineTextBox2"
        Me.GunaLineTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox2.SelectedText = ""
        Me.GunaLineTextBox2.Size = New System.Drawing.Size(256, 30)
        Me.GunaLineTextBox2.TabIndex = 26
        '
        'GunaLineTextBox1
        '
        Me.GunaLineTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLineTextBox1.BackColor = System.Drawing.Color.White
        Me.GunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox1.FocusedLineColor = System.Drawing.Color.Gray
        Me.GunaLineTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLineTextBox1.Location = New System.Drawing.Point(363, 552)
        Me.GunaLineTextBox1.Name = "GunaLineTextBox1"
        Me.GunaLineTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox1.SelectedText = ""
        Me.GunaLineTextBox1.Size = New System.Drawing.Size(256, 30)
        Me.GunaLineTextBox1.TabIndex = 25
        '
        'GunaDateTimePicker1
        '
        Me.GunaDateTimePicker1.BaseColor = System.Drawing.Color.White
        Me.GunaDateTimePicker1.BorderColor = System.Drawing.Color.Silver
        Me.GunaDateTimePicker1.CustomFormat = Nothing
        Me.GunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.GunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaDateTimePicker1.ForeColor = System.Drawing.Color.Black
        Me.GunaDateTimePicker1.Location = New System.Drawing.Point(1021, 602)
        Me.GunaDateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.GunaDateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.GunaDateTimePicker1.Name = "GunaDateTimePicker1"
        Me.GunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaDateTimePicker1.Size = New System.Drawing.Size(256, 30)
        Me.GunaDateTimePicker1.TabIndex = 30
        Me.GunaDateTimePicker1.Text = "Monday, 14 June 2021"
        Me.GunaDateTimePicker1.Value = New Date(2021, 6, 14, 20, 23, 49, 909)
        '
        'BunifuCustomDataGrid1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuCustomDataGrid1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomDataGrid1.AutoGenerateColumns = False
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuCustomDataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAuteurDataGridViewTextBoxColumn, Me.NomAuteurDataGridViewTextBoxColumn, Me.PrenomAuteurDataGridViewTextBoxColumn, Me.DatenaiAuteurDataGridViewTextBoxColumn})
        Me.BunifuCustomDataGrid1.DataSource = Me.AuteurBindingSource1
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(374, 181)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.RowTemplate.Height = 26
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(573, 260)
        Me.BunifuCustomDataGrid1.TabIndex = 31
        '
        'IdAuteurDataGridViewTextBoxColumn
        '
        Me.IdAuteurDataGridViewTextBoxColumn.DataPropertyName = "id _Auteur"
        Me.IdAuteurDataGridViewTextBoxColumn.HeaderText = "id _Auteur"
        Me.IdAuteurDataGridViewTextBoxColumn.Name = "IdAuteurDataGridViewTextBoxColumn"
        '
        'NomAuteurDataGridViewTextBoxColumn
        '
        Me.NomAuteurDataGridViewTextBoxColumn.DataPropertyName = "Nom_Auteur"
        Me.NomAuteurDataGridViewTextBoxColumn.HeaderText = "Nom_Auteur"
        Me.NomAuteurDataGridViewTextBoxColumn.Name = "NomAuteurDataGridViewTextBoxColumn"
        '
        'PrenomAuteurDataGridViewTextBoxColumn
        '
        Me.PrenomAuteurDataGridViewTextBoxColumn.DataPropertyName = "Prenom_Auteur"
        Me.PrenomAuteurDataGridViewTextBoxColumn.HeaderText = "Prenom_Auteur"
        Me.PrenomAuteurDataGridViewTextBoxColumn.Name = "PrenomAuteurDataGridViewTextBoxColumn"
        '
        'DatenaiAuteurDataGridViewTextBoxColumn
        '
        Me.DatenaiAuteurDataGridViewTextBoxColumn.DataPropertyName = "date_nai_Auteur"
        Me.DatenaiAuteurDataGridViewTextBoxColumn.HeaderText = "date_nai_Auteur"
        Me.DatenaiAuteurDataGridViewTextBoxColumn.Name = "DatenaiAuteurDataGridViewTextBoxColumn"
        '
        'AuteurBindingSource1
        '
        Me.AuteurBindingSource1.DataMember = "Auteur"
        Me.AuteurBindingSource1.DataSource = Me.DataDataSet
        '
        'TypelivreBindingSource
        '
        Me.TypelivreBindingSource.DataMember = "type_livre"
        Me.TypelivreBindingSource.DataSource = Me.DataDataSet
        '
        'GunaAdvenceTileButton5
        '
        Me.GunaAdvenceTileButton5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaAdvenceTileButton5.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceTileButton5.AnimationSpeed = 0.03!
        Me.GunaAdvenceTileButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceTileButton5.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton5.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceTileButton5.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton5.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton5.CheckedImage = CType(resources.GetObject("GunaAdvenceTileButton5.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceTileButton5.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceTileButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceTileButton5.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceTileButton5.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.GunaAdvenceTileButton5.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton5.Image = CType(resources.GetObject("GunaAdvenceTileButton5.Image"), System.Drawing.Image)
        Me.GunaAdvenceTileButton5.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaAdvenceTileButton5.LineColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton5.Location = New System.Drawing.Point(680, 447)
        Me.GunaAdvenceTileButton5.Name = "GunaAdvenceTileButton5"
        Me.GunaAdvenceTileButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceTileButton5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton5.OnHoverImage = Nothing
        Me.GunaAdvenceTileButton5.OnHoverLineColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton5.Size = New System.Drawing.Size(64, 65)
        Me.GunaAdvenceTileButton5.TabIndex = 47
        '
        'GunaAdvenceTileButton2
        '
        Me.GunaAdvenceTileButton2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaAdvenceTileButton2.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceTileButton2.AnimationSpeed = 0.03!
        Me.GunaAdvenceTileButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceTileButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton2.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceTileButton2.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton2.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GunaAdvenceTileButton2.CheckedImage = CType(resources.GetObject("GunaAdvenceTileButton2.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceTileButton2.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceTileButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceTileButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceTileButton2.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.GunaAdvenceTileButton2.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton2.Image = CType(resources.GetObject("GunaAdvenceTileButton2.Image"), System.Drawing.Image)
        Me.GunaAdvenceTileButton2.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaAdvenceTileButton2.LineColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton2.Location = New System.Drawing.Point(750, 447)
        Me.GunaAdvenceTileButton2.Name = "GunaAdvenceTileButton2"
        Me.GunaAdvenceTileButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceTileButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton2.OnHoverImage = Nothing
        Me.GunaAdvenceTileButton2.OnHoverLineColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton2.Size = New System.Drawing.Size(64, 65)
        Me.GunaAdvenceTileButton2.TabIndex = 46
        '
        'GunaAdvenceTileButton1
        '
        Me.GunaAdvenceTileButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaAdvenceTileButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceTileButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceTileButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceTileButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceTileButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceTileButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceTileButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceTileButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceTileButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceTileButton1.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.GunaAdvenceTileButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.Image = CType(resources.GetObject("GunaAdvenceTileButton1.Image"), System.Drawing.Image)
        Me.GunaAdvenceTileButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaAdvenceTileButton1.LineColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.Location = New System.Drawing.Point(469, 447)
        Me.GunaAdvenceTileButton1.Name = "GunaAdvenceTileButton1"
        Me.GunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.OnHoverImage = Nothing
        Me.GunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.Size = New System.Drawing.Size(64, 65)
        Me.GunaAdvenceTileButton1.TabIndex = 45
        '
        'GunaAdvenceTileButton3
        '
        Me.GunaAdvenceTileButton3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaAdvenceTileButton3.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceTileButton3.AnimationSpeed = 0.03!
        Me.GunaAdvenceTileButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceTileButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton3.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceTileButton3.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton3.CheckedForeColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton3.CheckedImage = CType(resources.GetObject("GunaAdvenceTileButton3.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceTileButton3.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceTileButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceTileButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceTileButton3.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.GunaAdvenceTileButton3.ForeColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton3.Image = CType(resources.GetObject("GunaAdvenceTileButton3.Image"), System.Drawing.Image)
        Me.GunaAdvenceTileButton3.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaAdvenceTileButton3.LineColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton3.Location = New System.Drawing.Point(609, 447)
        Me.GunaAdvenceTileButton3.Name = "GunaAdvenceTileButton3"
        Me.GunaAdvenceTileButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceTileButton3.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GunaAdvenceTileButton3.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GunaAdvenceTileButton3.OnHoverImage = Nothing
        Me.GunaAdvenceTileButton3.OnHoverLineColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton3.Size = New System.Drawing.Size(65, 65)
        Me.GunaAdvenceTileButton3.TabIndex = 44
        '
        'GunaAdvenceTileButton4
        '
        Me.GunaAdvenceTileButton4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaAdvenceTileButton4.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceTileButton4.AnimationSpeed = 0.03!
        Me.GunaAdvenceTileButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceTileButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton4.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceTileButton4.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton4.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton4.CheckedImage = CType(resources.GetObject("GunaAdvenceTileButton4.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceTileButton4.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceTileButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceTileButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceTileButton4.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.GunaAdvenceTileButton4.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton4.Image = CType(resources.GetObject("GunaAdvenceTileButton4.Image"), System.Drawing.Image)
        Me.GunaAdvenceTileButton4.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaAdvenceTileButton4.LineColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton4.Location = New System.Drawing.Point(539, 447)
        Me.GunaAdvenceTileButton4.Name = "GunaAdvenceTileButton4"
        Me.GunaAdvenceTileButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceTileButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton4.OnHoverImage = Nothing
        Me.GunaAdvenceTileButton4.OnHoverLineColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton4.Size = New System.Drawing.Size(64, 65)
        Me.GunaAdvenceTileButton4.TabIndex = 43
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(504, 35)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(248, 36)
        Me.GunaLabel1.TabIndex = 48
        Me.GunaLabel1.Text = "Ajouter Auteur"
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox1.HintText = "Search"
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Black
        Me.BunifuMaterialTextbox1.LineThickness = 3
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(453, 132)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(646, 42)
        Me.BunifuMaterialTextbox1.TabIndex = 50
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI Emoji", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceButton1.Image = CType(resources.GetObject("GunaAdvenceButton1.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(220, 132)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(180, 42)
        Me.GunaAdvenceButton1.TabIndex = 49
        Me.GunaAdvenceButton1.Text = "Rechercher"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1288, 700)
        Me.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaAdvenceTileButton5)
        Me.Controls.Add(Me.GunaAdvenceTileButton2)
        Me.Controls.Add(Me.GunaAdvenceTileButton1)
        Me.Controls.Add(Me.GunaAdvenceTileButton3)
        Me.Controls.Add(Me.GunaAdvenceTileButton4)
        Me.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.Controls.Add(Me.GunaDateTimePicker1)
        Me.Controls.Add(Me.GunaLineTextBox3)
        Me.Controls.Add(Me.GunaLineTextBox2)
        Me.Controls.Add(Me.GunaLineTextBox1)
        Me.Controls.Add(Id__AuteurLabel)
        Me.Controls.Add(Nom_AuteurLabel)
        Me.Controls.Add(Prenom_AuteurLabel)
        Me.Controls.Add(Date_nai_AuteurLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuteurBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Type_livreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuteurBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypelivreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataDataSet As WindowsApplication1.DataDataSet
    Friend WithEvents AuteurBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AuteurTableAdapter As WindowsApplication1.DataDataSetTableAdapters.AuteurTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.DataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Type_livreTableAdapter As WindowsApplication1.DataDataSetTableAdapters.type_livreTableAdapter
    Friend WithEvents Type_livreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GunaLineTextBox3 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLineTextBox2 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLineTextBox1 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaDateTimePicker1 As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents BunifuCustomDataGrid1 As ns1.BunifuCustomDataGrid
    Friend WithEvents IdAuteurDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomAuteurDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrenomAuteurDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatenaiAuteurDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuteurBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TypelivreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GunaAdvenceTileButton5 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaAdvenceTileButton2 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaAdvenceTileButton1 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaAdvenceTileButton3 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaAdvenceTileButton4 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BunifuMaterialTextbox1 As ns1.BunifuMaterialTextbox
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
End Class
