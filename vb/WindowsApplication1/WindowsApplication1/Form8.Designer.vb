<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim Id_adminLabel As System.Windows.Forms.Label
        Dim Nom_adminLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.text2 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.AdministrateurBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataDataSet = New WindowsApplication1.DataDataSet()
        Me.text1 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.text3 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.text4 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.BunifuMaterialTextbox1 = New ns1.BunifuMaterialTextbox()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceTileButton5 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaAdvenceTileButton2 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaAdvenceTileButton1 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaAdvenceTileButton3 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaAdvenceTileButton4 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.BunifuCustomDataGrid1 = New ns1.BunifuCustomDataGrid()
        Me.IdadminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomadminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdministrateurTableAdapter = New WindowsApplication1.DataDataSetTableAdapters.administrateurTableAdapter()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Id_adminLabel = New System.Windows.Forms.Label()
        Nom_adminLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        CType(Me.AdministrateurBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_adminLabel
        '
        Id_adminLabel.AutoSize = True
        Id_adminLabel.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Id_adminLabel.Location = New System.Drawing.Point(156, 533)
        Id_adminLabel.Name = "Id_adminLabel"
        Id_adminLabel.Size = New System.Drawing.Size(101, 22)
        Id_adminLabel.TabIndex = 8
        Id_adminLabel.Text = "Id Admin :"
        '
        'Nom_adminLabel
        '
        Nom_adminLabel.AutoSize = True
        Nom_adminLabel.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Nom_adminLabel.Location = New System.Drawing.Point(156, 577)
        Nom_adminLabel.Name = "Nom_adminLabel"
        Nom_adminLabel.Size = New System.Drawing.Size(120, 22)
        Nom_adminLabel.TabIndex = 10
        Nom_adminLabel.Text = "Nom Admin:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        UsernameLabel.Location = New System.Drawing.Point(666, 541)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(106, 22)
        UsernameLabel.TabIndex = 12
        UsernameLabel.Text = "UserName:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        PasswordLabel.Location = New System.Drawing.Point(666, 577)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(99, 22)
        PasswordLabel.TabIndex = 14
        PasswordLabel.Text = "PassWord:"
        '
        'text2
        '
        Me.text2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.text2.BackColor = System.Drawing.Color.White
        Me.text2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.text2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdministrateurBindingSource, "Nom_admin", True))
        Me.text2.FocusedLineColor = System.Drawing.Color.Gray
        Me.text2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.text2.LineColor = System.Drawing.Color.Gainsboro
        Me.text2.Location = New System.Drawing.Point(342, 577)
        Me.text2.Name = "text2"
        Me.text2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.text2.SelectedText = ""
        Me.text2.Size = New System.Drawing.Size(256, 30)
        Me.text2.TabIndex = 27
        '
        'AdministrateurBindingSource
        '
        Me.AdministrateurBindingSource.DataMember = "administrateur"
        Me.AdministrateurBindingSource.DataSource = Me.DataDataSet
        '
        'DataDataSet
        '
        Me.DataDataSet.DataSetName = "DataDataSet"
        Me.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'text1
        '
        Me.text1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.text1.BackColor = System.Drawing.Color.White
        Me.text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.text1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdministrateurBindingSource, "id_admin", True))
        Me.text1.FocusedLineColor = System.Drawing.Color.Gray
        Me.text1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.text1.LineColor = System.Drawing.Color.Gainsboro
        Me.text1.Location = New System.Drawing.Point(343, 533)
        Me.text1.Name = "text1"
        Me.text1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.text1.SelectedText = ""
        Me.text1.Size = New System.Drawing.Size(256, 30)
        Me.text1.TabIndex = 28
        '
        'text3
        '
        Me.text3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.text3.BackColor = System.Drawing.Color.White
        Me.text3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.text3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdministrateurBindingSource, "username", True))
        Me.text3.FocusedLineColor = System.Drawing.Color.Gray
        Me.text3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.text3.LineColor = System.Drawing.Color.Gainsboro
        Me.text3.Location = New System.Drawing.Point(812, 533)
        Me.text3.Name = "text3"
        Me.text3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.text3.SelectedText = ""
        Me.text3.Size = New System.Drawing.Size(256, 30)
        Me.text3.TabIndex = 29
        '
        'text4
        '
        Me.text4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.text4.BackColor = System.Drawing.Color.White
        Me.text4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.text4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdministrateurBindingSource, "password", True))
        Me.text4.FocusedLineColor = System.Drawing.Color.Gray
        Me.text4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.text4.LineColor = System.Drawing.Color.Gainsboro
        Me.text4.Location = New System.Drawing.Point(812, 577)
        Me.text4.Name = "text4"
        Me.text4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.text4.SelectedText = ""
        Me.text4.Size = New System.Drawing.Size(256, 30)
        Me.text4.TabIndex = 30
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
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(449, 85)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(646, 42)
        Me.BunifuMaterialTextbox1.TabIndex = 58
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
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(216, 85)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(180, 42)
        Me.GunaAdvenceButton1.TabIndex = 57
        Me.GunaAdvenceButton1.Text = "Rechercher"
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
        Me.GunaAdvenceTileButton5.Location = New System.Drawing.Point(691, 422)
        Me.GunaAdvenceTileButton5.Name = "GunaAdvenceTileButton5"
        Me.GunaAdvenceTileButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceTileButton5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton5.OnHoverImage = Nothing
        Me.GunaAdvenceTileButton5.OnHoverLineColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton5.Size = New System.Drawing.Size(64, 65)
        Me.GunaAdvenceTileButton5.TabIndex = 56
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
        Me.GunaAdvenceTileButton2.Location = New System.Drawing.Point(761, 422)
        Me.GunaAdvenceTileButton2.Name = "GunaAdvenceTileButton2"
        Me.GunaAdvenceTileButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceTileButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton2.OnHoverImage = Nothing
        Me.GunaAdvenceTileButton2.OnHoverLineColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton2.Size = New System.Drawing.Size(64, 65)
        Me.GunaAdvenceTileButton2.TabIndex = 55
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
        Me.GunaAdvenceTileButton1.Location = New System.Drawing.Point(480, 422)
        Me.GunaAdvenceTileButton1.Name = "GunaAdvenceTileButton1"
        Me.GunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.OnHoverImage = Nothing
        Me.GunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.Size = New System.Drawing.Size(64, 65)
        Me.GunaAdvenceTileButton1.TabIndex = 54
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
        Me.GunaAdvenceTileButton3.Location = New System.Drawing.Point(620, 422)
        Me.GunaAdvenceTileButton3.Name = "GunaAdvenceTileButton3"
        Me.GunaAdvenceTileButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceTileButton3.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GunaAdvenceTileButton3.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GunaAdvenceTileButton3.OnHoverImage = Nothing
        Me.GunaAdvenceTileButton3.OnHoverLineColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton3.Size = New System.Drawing.Size(65, 65)
        Me.GunaAdvenceTileButton3.TabIndex = 53
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
        Me.GunaAdvenceTileButton4.Location = New System.Drawing.Point(550, 422)
        Me.GunaAdvenceTileButton4.Name = "GunaAdvenceTileButton4"
        Me.GunaAdvenceTileButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceTileButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton4.OnHoverImage = Nothing
        Me.GunaAdvenceTileButton4.OnHoverLineColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton4.Size = New System.Drawing.Size(64, 65)
        Me.GunaAdvenceTileButton4.TabIndex = 52
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
        Me.BunifuCustomDataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdadminDataGridViewTextBoxColumn, Me.NomadminDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn})
        Me.BunifuCustomDataGrid1.DataSource = Me.AdministrateurBindingSource
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(407, 160)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.RowTemplate.Height = 26
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(512, 209)
        Me.BunifuCustomDataGrid1.TabIndex = 51
        '
        'IdadminDataGridViewTextBoxColumn
        '
        Me.IdadminDataGridViewTextBoxColumn.DataPropertyName = "id_admin"
        Me.IdadminDataGridViewTextBoxColumn.HeaderText = "id_admin"
        Me.IdadminDataGridViewTextBoxColumn.Name = "IdadminDataGridViewTextBoxColumn"
        '
        'NomadminDataGridViewTextBoxColumn
        '
        Me.NomadminDataGridViewTextBoxColumn.DataPropertyName = "Nom_admin"
        Me.NomadminDataGridViewTextBoxColumn.HeaderText = "Nom_admin"
        Me.NomadminDataGridViewTextBoxColumn.Name = "NomadminDataGridViewTextBoxColumn"
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'AdministrateurTableAdapter
        '
        Me.AdministrateurTableAdapter.ClearBeforeFill = True
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(524, 9)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(243, 36)
        Me.GunaLabel1.TabIndex = 59
        Me.GunaLabel1.Text = "Ajouter Admin"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1288, 700)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.GunaAdvenceTileButton5)
        Me.Controls.Add(Me.GunaAdvenceTileButton2)
        Me.Controls.Add(Me.GunaAdvenceTileButton1)
        Me.Controls.Add(Me.GunaAdvenceTileButton3)
        Me.Controls.Add(Me.GunaAdvenceTileButton4)
        Me.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.Controls.Add(Me.text4)
        Me.Controls.Add(Me.text3)
        Me.Controls.Add(Me.text1)
        Me.Controls.Add(Me.text2)
        Me.Controls.Add(Id_adminLabel)
        Me.Controls.Add(Nom_adminLabel)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(PasswordLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form8"
        Me.Text = "Form8"
        CType(Me.AdministrateurBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents text2 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents text1 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents text3 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents text4 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents BunifuMaterialTextbox1 As ns1.BunifuMaterialTextbox
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceTileButton5 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaAdvenceTileButton2 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaAdvenceTileButton1 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaAdvenceTileButton3 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaAdvenceTileButton4 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents BunifuCustomDataGrid1 As ns1.BunifuCustomDataGrid
    Friend WithEvents DataDataSet As WindowsApplication1.DataDataSet
    Friend WithEvents AdministrateurBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdministrateurTableAdapter As WindowsApplication1.DataDataSetTableAdapters.administrateurTableAdapter
    Friend WithEvents IdadminDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomadminDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
End Class
