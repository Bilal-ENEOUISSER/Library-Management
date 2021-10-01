<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim Id_type_livreLabel As System.Windows.Forms.Label
        Dim Type_livreLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.BunifuCustomDataGrid2 = New ns1.BunifuCustomDataGrid()
        Me.IdtypelivreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypelivreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypelivreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataDataSet = New WindowsApplication1.DataDataSet()
        Me.GunaLineTextBox4 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLineTextBox5 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Type_livreTableAdapter = New WindowsApplication1.DataDataSetTableAdapters.type_livreTableAdapter()
        Me.GunaAdvenceTileButton5 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaAdvenceTileButton2 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaAdvenceTileButton1 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaAdvenceTileButton3 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaAdvenceTileButton4 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.BunifuMaterialTextbox1 = New ns1.BunifuMaterialTextbox()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Id_type_livreLabel = New System.Windows.Forms.Label()
        Type_livreLabel = New System.Windows.Forms.Label()
        CType(Me.BunifuCustomDataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypelivreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_type_livreLabel
        '
        Id_type_livreLabel.AutoSize = True
        Id_type_livreLabel.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Id_type_livreLabel.Location = New System.Drawing.Point(397, 542)
        Id_type_livreLabel.Name = "Id_type_livreLabel"
        Id_type_livreLabel.Size = New System.Drawing.Size(131, 22)
        Id_type_livreLabel.TabIndex = 33
        Id_type_livreLabel.Text = "Id Type Livre:"
        '
        'Type_livreLabel
        '
        Type_livreLabel.AutoSize = True
        Type_livreLabel.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Type_livreLabel.Location = New System.Drawing.Point(397, 598)
        Type_livreLabel.Name = "Type_livreLabel"
        Type_livreLabel.Size = New System.Drawing.Size(107, 22)
        Type_livreLabel.TabIndex = 34
        Type_livreLabel.Text = "Type Livre:"
        '
        'BunifuCustomDataGrid2
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuCustomDataGrid2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomDataGrid2.AutoGenerateColumns = False
        Me.BunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.BunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuCustomDataGrid2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdtypelivreDataGridViewTextBoxColumn, Me.TypelivreDataGridViewTextBoxColumn})
        Me.BunifuCustomDataGrid2.DataSource = Me.TypelivreBindingSource
        Me.BunifuCustomDataGrid2.DoubleBuffered = True
        Me.BunifuCustomDataGrid2.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid2.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.BunifuCustomDataGrid2.Location = New System.Drawing.Point(383, 187)
        Me.BunifuCustomDataGrid2.Name = "BunifuCustomDataGrid2"
        Me.BunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid2.RowTemplate.Height = 26
        Me.BunifuCustomDataGrid2.Size = New System.Drawing.Size(530, 209)
        Me.BunifuCustomDataGrid2.TabIndex = 37
        '
        'IdtypelivreDataGridViewTextBoxColumn
        '
        Me.IdtypelivreDataGridViewTextBoxColumn.DataPropertyName = "id_type_livre"
        Me.IdtypelivreDataGridViewTextBoxColumn.HeaderText = "id_type_livre"
        Me.IdtypelivreDataGridViewTextBoxColumn.Name = "IdtypelivreDataGridViewTextBoxColumn"
        '
        'TypelivreDataGridViewTextBoxColumn
        '
        Me.TypelivreDataGridViewTextBoxColumn.DataPropertyName = "type_livre"
        Me.TypelivreDataGridViewTextBoxColumn.HeaderText = "type_livre"
        Me.TypelivreDataGridViewTextBoxColumn.Name = "TypelivreDataGridViewTextBoxColumn"
        '
        'TypelivreBindingSource
        '
        Me.TypelivreBindingSource.DataMember = "type_livre"
        Me.TypelivreBindingSource.DataSource = Me.DataDataSet
        '
        'DataDataSet
        '
        Me.DataDataSet.DataSetName = "DataDataSet"
        Me.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GunaLineTextBox4
        '
        Me.GunaLineTextBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLineTextBox4.BackColor = System.Drawing.Color.White
        Me.GunaLineTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox4.FocusedLineColor = System.Drawing.Color.Gray
        Me.GunaLineTextBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox4.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLineTextBox4.Location = New System.Drawing.Point(622, 590)
        Me.GunaLineTextBox4.Name = "GunaLineTextBox4"
        Me.GunaLineTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox4.SelectedText = ""
        Me.GunaLineTextBox4.Size = New System.Drawing.Size(256, 30)
        Me.GunaLineTextBox4.TabIndex = 36
        '
        'GunaLineTextBox5
        '
        Me.GunaLineTextBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLineTextBox5.BackColor = System.Drawing.Color.White
        Me.GunaLineTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox5.FocusedLineColor = System.Drawing.Color.Gray
        Me.GunaLineTextBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox5.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLineTextBox5.Location = New System.Drawing.Point(622, 542)
        Me.GunaLineTextBox5.Name = "GunaLineTextBox5"
        Me.GunaLineTextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox5.SelectedText = ""
        Me.GunaLineTextBox5.Size = New System.Drawing.Size(256, 30)
        Me.GunaLineTextBox5.TabIndex = 35
        '
        'Type_livreTableAdapter
        '
        Me.Type_livreTableAdapter.ClearBeforeFill = True
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
        Me.GunaAdvenceTileButton5.Location = New System.Drawing.Point(675, 426)
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
        Me.GunaAdvenceTileButton2.Location = New System.Drawing.Point(745, 426)
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
        Me.GunaAdvenceTileButton1.Location = New System.Drawing.Point(464, 426)
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
        Me.GunaAdvenceTileButton3.Location = New System.Drawing.Point(604, 426)
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
        Me.GunaAdvenceTileButton4.Location = New System.Drawing.Point(534, 426)
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
        Me.GunaLabel1.Location = New System.Drawing.Point(505, 22)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(242, 36)
        Me.GunaLabel1.TabIndex = 48
        Me.GunaLabel1.Text = "Les Type Livre"
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
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(439, 112)
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
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(206, 112)
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
        'Form7
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
        Me.Controls.Add(Me.BunifuCustomDataGrid2)
        Me.Controls.Add(Me.GunaLineTextBox4)
        Me.Controls.Add(Me.GunaLineTextBox5)
        Me.Controls.Add(Id_type_livreLabel)
        Me.Controls.Add(Type_livreLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.BunifuCustomDataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypelivreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuCustomDataGrid2 As ns1.BunifuCustomDataGrid
    Friend WithEvents GunaLineTextBox4 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLineTextBox5 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents DataDataSet As WindowsApplication1.DataDataSet
    Friend WithEvents TypelivreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Type_livreTableAdapter As WindowsApplication1.DataDataSetTableAdapters.type_livreTableAdapter
    Friend WithEvents IdtypelivreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypelivreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GunaAdvenceTileButton5 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaAdvenceTileButton2 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaAdvenceTileButton1 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaAdvenceTileButton3 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaAdvenceTileButton4 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BunifuMaterialTextbox1 As ns1.BunifuMaterialTextbox
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
End Class
