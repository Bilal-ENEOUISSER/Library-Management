<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.DataDataSet = New WindowsApplication1.DataDataSet()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientTableAdapter = New WindowsApplication1.DataDataSetTableAdapters.ClientTableAdapter()
        Me.BunifuCustomDataGrid1 = New ns1.BunifuCustomDataGrid()
        Me.IdClientDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdadminDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomClientDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrenomClientDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatenaiClientDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RueClientDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CpClientDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailClientDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeleClientDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.BunifuMaterialTextbox1 = New ns1.BunifuMaterialTextbox()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataDataSet
        '
        Me.DataDataSet.DataSetName = "DataDataSet"
        Me.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataMember = "Client"
        Me.ClientBindingSource.DataSource = Me.DataDataSet
        '
        'ClientTableAdapter
        '
        Me.ClientTableAdapter.ClearBeforeFill = True
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
        Me.BunifuCustomDataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdClientDataGridViewTextBoxColumn1, Me.IdadminDataGridViewTextBoxColumn1, Me.NomClientDataGridViewTextBoxColumn1, Me.PrenomClientDataGridViewTextBoxColumn1, Me.DatenaiClientDataGridViewTextBoxColumn1, Me.RueClientDataGridViewTextBoxColumn1, Me.CpClientDataGridViewTextBoxColumn1, Me.EmailClientDataGridViewTextBoxColumn1, Me.TeleClientDataGridViewTextBoxColumn1})
        Me.BunifuCustomDataGrid1.DataSource = Me.ClientBindingSource1
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(47, 43)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.RowTemplate.Height = 26
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(1191, 439)
        Me.BunifuCustomDataGrid1.TabIndex = 1
        '
        'IdClientDataGridViewTextBoxColumn1
        '
        Me.IdClientDataGridViewTextBoxColumn1.DataPropertyName = "id_Client"
        Me.IdClientDataGridViewTextBoxColumn1.HeaderText = "id_Client"
        Me.IdClientDataGridViewTextBoxColumn1.Name = "IdClientDataGridViewTextBoxColumn1"
        '
        'IdadminDataGridViewTextBoxColumn1
        '
        Me.IdadminDataGridViewTextBoxColumn1.DataPropertyName = "id_admin"
        Me.IdadminDataGridViewTextBoxColumn1.HeaderText = "id_admin"
        Me.IdadminDataGridViewTextBoxColumn1.Name = "IdadminDataGridViewTextBoxColumn1"
        '
        'NomClientDataGridViewTextBoxColumn1
        '
        Me.NomClientDataGridViewTextBoxColumn1.DataPropertyName = "Nom_Client"
        Me.NomClientDataGridViewTextBoxColumn1.HeaderText = "Nom_Client"
        Me.NomClientDataGridViewTextBoxColumn1.Name = "NomClientDataGridViewTextBoxColumn1"
        '
        'PrenomClientDataGridViewTextBoxColumn1
        '
        Me.PrenomClientDataGridViewTextBoxColumn1.DataPropertyName = "Prenom_Client"
        Me.PrenomClientDataGridViewTextBoxColumn1.HeaderText = "Prenom_Client"
        Me.PrenomClientDataGridViewTextBoxColumn1.Name = "PrenomClientDataGridViewTextBoxColumn1"
        '
        'DatenaiClientDataGridViewTextBoxColumn1
        '
        Me.DatenaiClientDataGridViewTextBoxColumn1.DataPropertyName = "date_nai_Client"
        Me.DatenaiClientDataGridViewTextBoxColumn1.HeaderText = "date_nai_Client"
        Me.DatenaiClientDataGridViewTextBoxColumn1.Name = "DatenaiClientDataGridViewTextBoxColumn1"
        '
        'RueClientDataGridViewTextBoxColumn1
        '
        Me.RueClientDataGridViewTextBoxColumn1.DataPropertyName = "rue_Client"
        Me.RueClientDataGridViewTextBoxColumn1.HeaderText = "rue_Client"
        Me.RueClientDataGridViewTextBoxColumn1.Name = "RueClientDataGridViewTextBoxColumn1"
        '
        'CpClientDataGridViewTextBoxColumn1
        '
        Me.CpClientDataGridViewTextBoxColumn1.DataPropertyName = "cp_Client"
        Me.CpClientDataGridViewTextBoxColumn1.HeaderText = "cp_Client"
        Me.CpClientDataGridViewTextBoxColumn1.Name = "CpClientDataGridViewTextBoxColumn1"
        '
        'EmailClientDataGridViewTextBoxColumn1
        '
        Me.EmailClientDataGridViewTextBoxColumn1.DataPropertyName = "email_Client"
        Me.EmailClientDataGridViewTextBoxColumn1.HeaderText = "email_Client"
        Me.EmailClientDataGridViewTextBoxColumn1.Name = "EmailClientDataGridViewTextBoxColumn1"
        '
        'TeleClientDataGridViewTextBoxColumn1
        '
        Me.TeleClientDataGridViewTextBoxColumn1.DataPropertyName = "tele_Client"
        Me.TeleClientDataGridViewTextBoxColumn1.HeaderText = "tele_Client"
        Me.TeleClientDataGridViewTextBoxColumn1.Name = "TeleClientDataGridViewTextBoxColumn1"
        '
        'ClientBindingSource1
        '
        Me.ClientBindingSource1.DataMember = "Client"
        Me.ClientBindingSource1.DataSource = Me.DataDataSet
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaElipse2
        '
        Me.GunaElipse2.TargetControl = Me
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = CType(resources.GetObject("GunaAdvenceButton1.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(164, 529)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(180, 42)
        Me.GunaAdvenceButton1.TabIndex = 5
        Me.GunaAdvenceButton1.Text = "Rechercher"
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(399, 529)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(646, 42)
        Me.BunifuMaterialTextbox1.TabIndex = 6
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1288, 700)
        Me.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataDataSet As WindowsApplication1.DataDataSet
    Friend WithEvents ClientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientTableAdapter As WindowsApplication1.DataDataSetTableAdapters.ClientTableAdapter
    Friend WithEvents BunifuCustomDataGrid1 As ns1.BunifuCustomDataGrid
    Friend WithEvents IdClientDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdadminDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomClientDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrenomClientDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatenaiClientDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RueClientDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CpClientDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailClientDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TeleClientDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents BunifuMaterialTextbox1 As ns1.BunifuMaterialTextbox
End Class
