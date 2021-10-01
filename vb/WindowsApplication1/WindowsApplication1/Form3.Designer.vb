<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim Id_ClientLabel As System.Windows.Forms.Label
        Dim Id_adminLabel As System.Windows.Forms.Label
        Dim Nom_ClientLabel As System.Windows.Forms.Label
        Dim Prenom_ClientLabel As System.Windows.Forms.Label
        Dim Date_nai_ClientLabel As System.Windows.Forms.Label
        Dim Rue_ClientLabel As System.Windows.Forms.Label
        Dim Cp_ClientLabel As System.Windows.Forms.Label
        Dim Email_ClientLabel As System.Windows.Forms.Label
        Dim Tele_ClientLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.DataDataSet = New WindowsApplication1.DataDataSet()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientTableAdapter = New WindowsApplication1.DataDataSetTableAdapters.ClientTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.DataDataSetTableAdapters.TableAdapterManager()
        Me.idclt = New Guna.UI.WinForms.GunaLineTextBox()
        Me.idadm = New Guna.UI.WinForms.GunaLineTextBox()
        Me.nclt = New Guna.UI.WinForms.GunaLineTextBox()
        Me.pclt = New Guna.UI.WinForms.GunaLineTextBox()
        Me.tclt = New Guna.UI.WinForms.GunaLineTextBox()
        Me.eclt = New Guna.UI.WinForms.GunaLineTextBox()
        Me.cclt = New Guna.UI.WinForms.GunaLineTextBox()
        Me.raclt = New Guna.UI.WinForms.GunaLineTextBox()
        Me.dclt = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.GunaAdvenceTileButton4 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaAdvenceTileButton3 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaAdvenceTileButton1 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaAdvenceTileButton2 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.GunaAdvenceTileButton5 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Id_ClientLabel = New System.Windows.Forms.Label()
        Id_adminLabel = New System.Windows.Forms.Label()
        Nom_ClientLabel = New System.Windows.Forms.Label()
        Prenom_ClientLabel = New System.Windows.Forms.Label()
        Date_nai_ClientLabel = New System.Windows.Forms.Label()
        Rue_ClientLabel = New System.Windows.Forms.Label()
        Cp_ClientLabel = New System.Windows.Forms.Label()
        Email_ClientLabel = New System.Windows.Forms.Label()
        Tele_ClientLabel = New System.Windows.Forms.Label()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_ClientLabel
        '
        Id_ClientLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Id_ClientLabel.AutoSize = True
        Id_ClientLabel.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_ClientLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Id_ClientLabel.Location = New System.Drawing.Point(101, 160)
        Id_ClientLabel.Name = "Id_ClientLabel"
        Id_ClientLabel.Size = New System.Drawing.Size(96, 22)
        Id_ClientLabel.TabIndex = 1
        Id_ClientLabel.Text = "Id Client :"
        '
        'Id_adminLabel
        '
        Id_adminLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Id_adminLabel.AutoSize = True
        Id_adminLabel.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Id_adminLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Id_adminLabel.Location = New System.Drawing.Point(101, 210)
        Id_adminLabel.Name = "Id_adminLabel"
        Id_adminLabel.Size = New System.Drawing.Size(101, 22)
        Id_adminLabel.TabIndex = 3
        Id_adminLabel.Text = "Id Admin :"
        '
        'Nom_ClientLabel
        '
        Nom_ClientLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Nom_ClientLabel.AutoSize = True
        Nom_ClientLabel.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Nom_ClientLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Nom_ClientLabel.Location = New System.Drawing.Point(101, 259)
        Nom_ClientLabel.Name = "Nom_ClientLabel"
        Nom_ClientLabel.Size = New System.Drawing.Size(120, 22)
        Nom_ClientLabel.TabIndex = 5
        Nom_ClientLabel.Text = "Nom Client :"
        '
        'Prenom_ClientLabel
        '
        Prenom_ClientLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Prenom_ClientLabel.AutoSize = True
        Prenom_ClientLabel.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Prenom_ClientLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Prenom_ClientLabel.Location = New System.Drawing.Point(101, 310)
        Prenom_ClientLabel.Name = "Prenom_ClientLabel"
        Prenom_ClientLabel.Size = New System.Drawing.Size(142, 22)
        Prenom_ClientLabel.TabIndex = 7
        Prenom_ClientLabel.Text = "Prenom Client :"
        '
        'Date_nai_ClientLabel
        '
        Date_nai_ClientLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Date_nai_ClientLabel.AutoSize = True
        Date_nai_ClientLabel.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Date_nai_ClientLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Date_nai_ClientLabel.Location = New System.Drawing.Point(503, 365)
        Date_nai_ClientLabel.Name = "Date_nai_ClientLabel"
        Date_nai_ClientLabel.Size = New System.Drawing.Size(211, 22)
        Date_nai_ClientLabel.TabIndex = 9
        Date_nai_ClientLabel.Text = "Date Naissance Client :"
        '
        'Rue_ClientLabel
        '
        Rue_ClientLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Rue_ClientLabel.AutoSize = True
        Rue_ClientLabel.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Rue_ClientLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Rue_ClientLabel.Location = New System.Drawing.Point(751, 160)
        Rue_ClientLabel.Name = "Rue_ClientLabel"
        Rue_ClientLabel.Size = New System.Drawing.Size(106, 22)
        Rue_ClientLabel.TabIndex = 11
        Rue_ClientLabel.Text = "Rue Client:"
        '
        'Cp_ClientLabel
        '
        Cp_ClientLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Cp_ClientLabel.AutoSize = True
        Cp_ClientLabel.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Cp_ClientLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Cp_ClientLabel.Location = New System.Drawing.Point(751, 210)
        Cp_ClientLabel.Name = "Cp_ClientLabel"
        Cp_ClientLabel.Size = New System.Drawing.Size(97, 22)
        Cp_ClientLabel.TabIndex = 13
        Cp_ClientLabel.Text = "Cp Client:"
        '
        'Email_ClientLabel
        '
        Email_ClientLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Email_ClientLabel.AutoSize = True
        Email_ClientLabel.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Email_ClientLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Email_ClientLabel.Location = New System.Drawing.Point(751, 259)
        Email_ClientLabel.Name = "Email_ClientLabel"
        Email_ClientLabel.Size = New System.Drawing.Size(124, 22)
        Email_ClientLabel.TabIndex = 15
        Email_ClientLabel.Text = "Email Client:"
        '
        'Tele_ClientLabel
        '
        Tele_ClientLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Tele_ClientLabel.AutoSize = True
        Tele_ClientLabel.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold)
        Tele_ClientLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Tele_ClientLabel.Location = New System.Drawing.Point(751, 310)
        Tele_ClientLabel.Name = "Tele_ClientLabel"
        Tele_ClientLabel.Size = New System.Drawing.Size(168, 22)
        Tele_ClientLabel.TabIndex = 17
        Tele_ClientLabel.Text = "TelePhone Client :"
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.administrateurTableAdapter = Nothing
        Me.TableAdapterManager.AuteurTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BoissonTableAdapter = Nothing
        Me.TableAdapterManager.ClientTableAdapter = Me.ClientTableAdapter
        Me.TableAdapterManager.facture_BoissonTableAdapter = Nothing
        Me.TableAdapterManager.FactureTableAdapter = Nothing
        Me.TableAdapterManager.LivreTableAdapter = Nothing
        Me.TableAdapterManager.type_livreTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.DataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'idclt
        '
        Me.idclt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.idclt.BackColor = System.Drawing.Color.White
        Me.idclt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.idclt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "id_Client", True))
        Me.idclt.FocusedLineColor = System.Drawing.Color.Gray
        Me.idclt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.idclt.LineColor = System.Drawing.Color.Gainsboro
        Me.idclt.Location = New System.Drawing.Point(262, 152)
        Me.idclt.Name = "idclt"
        Me.idclt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.idclt.SelectedText = ""
        Me.idclt.Size = New System.Drawing.Size(217, 30)
        Me.idclt.TabIndex = 18
        '
        'idadm
        '
        Me.idadm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.idadm.BackColor = System.Drawing.Color.White
        Me.idadm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.idadm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "id_admin", True))
        Me.idadm.FocusedLineColor = System.Drawing.Color.Gray
        Me.idadm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.idadm.LineColor = System.Drawing.Color.Gainsboro
        Me.idadm.Location = New System.Drawing.Point(262, 202)
        Me.idadm.Name = "idadm"
        Me.idadm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.idadm.SelectedText = ""
        Me.idadm.Size = New System.Drawing.Size(217, 30)
        Me.idadm.TabIndex = 19
        '
        'nclt
        '
        Me.nclt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nclt.BackColor = System.Drawing.Color.White
        Me.nclt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nclt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "Nom_Client", True))
        Me.nclt.FocusedLineColor = System.Drawing.Color.Gray
        Me.nclt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nclt.LineColor = System.Drawing.Color.Gainsboro
        Me.nclt.Location = New System.Drawing.Point(262, 251)
        Me.nclt.Name = "nclt"
        Me.nclt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nclt.SelectedText = ""
        Me.nclt.Size = New System.Drawing.Size(217, 30)
        Me.nclt.TabIndex = 20
        '
        'pclt
        '
        Me.pclt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pclt.BackColor = System.Drawing.Color.White
        Me.pclt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pclt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "Prenom_Client", True))
        Me.pclt.FocusedLineColor = System.Drawing.Color.Gray
        Me.pclt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.pclt.LineColor = System.Drawing.Color.Gainsboro
        Me.pclt.Location = New System.Drawing.Point(262, 302)
        Me.pclt.Name = "pclt"
        Me.pclt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pclt.SelectedText = ""
        Me.pclt.Size = New System.Drawing.Size(217, 30)
        Me.pclt.TabIndex = 21
        '
        'tclt
        '
        Me.tclt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tclt.BackColor = System.Drawing.Color.White
        Me.tclt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tclt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "tele_Client", True))
        Me.tclt.FocusedLineColor = System.Drawing.Color.Gray
        Me.tclt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tclt.LineColor = System.Drawing.Color.Gainsboro
        Me.tclt.Location = New System.Drawing.Point(939, 302)
        Me.tclt.Name = "tclt"
        Me.tclt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tclt.SelectedText = ""
        Me.tclt.Size = New System.Drawing.Size(217, 30)
        Me.tclt.TabIndex = 25
        '
        'eclt
        '
        Me.eclt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.eclt.BackColor = System.Drawing.Color.White
        Me.eclt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.eclt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "email_Client", True))
        Me.eclt.FocusedLineColor = System.Drawing.Color.Gray
        Me.eclt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.eclt.LineColor = System.Drawing.Color.Gainsboro
        Me.eclt.Location = New System.Drawing.Point(939, 251)
        Me.eclt.Name = "eclt"
        Me.eclt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.eclt.SelectedText = ""
        Me.eclt.Size = New System.Drawing.Size(217, 30)
        Me.eclt.TabIndex = 24
        '
        'cclt
        '
        Me.cclt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cclt.BackColor = System.Drawing.Color.White
        Me.cclt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cclt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "cp_Client", True))
        Me.cclt.FocusedLineColor = System.Drawing.Color.Gray
        Me.cclt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cclt.LineColor = System.Drawing.Color.Gainsboro
        Me.cclt.Location = New System.Drawing.Point(939, 202)
        Me.cclt.Name = "cclt"
        Me.cclt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cclt.SelectedText = ""
        Me.cclt.Size = New System.Drawing.Size(217, 30)
        Me.cclt.TabIndex = 23
        '
        'raclt
        '
        Me.raclt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.raclt.BackColor = System.Drawing.Color.White
        Me.raclt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.raclt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "rue_Client", True))
        Me.raclt.FocusedLineColor = System.Drawing.Color.Gray
        Me.raclt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.raclt.LineColor = System.Drawing.Color.Gainsboro
        Me.raclt.Location = New System.Drawing.Point(939, 152)
        Me.raclt.Name = "raclt"
        Me.raclt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.raclt.SelectedText = ""
        Me.raclt.Size = New System.Drawing.Size(217, 30)
        Me.raclt.TabIndex = 22
        '
        'dclt
        '
        Me.dclt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dclt.BaseColor = System.Drawing.Color.White
        Me.dclt.BorderColor = System.Drawing.Color.Silver
        Me.dclt.CustomFormat = Nothing
        Me.dclt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientBindingSource, "date_nai_Client", True))
        Me.dclt.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dclt.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dclt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dclt.ForeColor = System.Drawing.Color.Black
        Me.dclt.Location = New System.Drawing.Point(491, 390)
        Me.dclt.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dclt.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dclt.Name = "dclt"
        Me.dclt.OnHoverBaseColor = System.Drawing.Color.White
        Me.dclt.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dclt.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dclt.OnPressedColor = System.Drawing.Color.Black
        Me.dclt.Size = New System.Drawing.Size(236, 30)
        Me.dclt.TabIndex = 26
        Me.dclt.Text = "Monday, 14 June 2021"
        Me.dclt.Value = New Date(2021, 6, 14, 1, 19, 6, 119)
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
        Me.GunaAdvenceTileButton4.Location = New System.Drawing.Point(517, 446)
        Me.GunaAdvenceTileButton4.Name = "GunaAdvenceTileButton4"
        Me.GunaAdvenceTileButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceTileButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton4.OnHoverImage = Nothing
        Me.GunaAdvenceTileButton4.OnHoverLineColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton4.Size = New System.Drawing.Size(64, 65)
        Me.GunaAdvenceTileButton4.TabIndex = 30
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(491, 9)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(235, 36)
        Me.GunaLabel1.TabIndex = 33
        Me.GunaLabel1.Text = "Ajouter Client"
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
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
        Me.GunaAdvenceTileButton3.Location = New System.Drawing.Point(587, 446)
        Me.GunaAdvenceTileButton3.Name = "GunaAdvenceTileButton3"
        Me.GunaAdvenceTileButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceTileButton3.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GunaAdvenceTileButton3.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GunaAdvenceTileButton3.OnHoverImage = Nothing
        Me.GunaAdvenceTileButton3.OnHoverLineColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton3.Size = New System.Drawing.Size(65, 65)
        Me.GunaAdvenceTileButton3.TabIndex = 34
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
        Me.GunaAdvenceTileButton1.Location = New System.Drawing.Point(447, 446)
        Me.GunaAdvenceTileButton1.Name = "GunaAdvenceTileButton1"
        Me.GunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.OnHoverImage = Nothing
        Me.GunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton1.Size = New System.Drawing.Size(64, 65)
        Me.GunaAdvenceTileButton1.TabIndex = 35
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
        Me.GunaAdvenceTileButton2.Location = New System.Drawing.Point(728, 446)
        Me.GunaAdvenceTileButton2.Name = "GunaAdvenceTileButton2"
        Me.GunaAdvenceTileButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceTileButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton2.OnHoverImage = Nothing
        Me.GunaAdvenceTileButton2.OnHoverLineColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton2.Size = New System.Drawing.Size(64, 65)
        Me.GunaAdvenceTileButton2.TabIndex = 36
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
        Me.GunaAdvenceTileButton5.Location = New System.Drawing.Point(658, 446)
        Me.GunaAdvenceTileButton5.Name = "GunaAdvenceTileButton5"
        Me.GunaAdvenceTileButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceTileButton5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton5.OnHoverImage = Nothing
        Me.GunaAdvenceTileButton5.OnHoverLineColor = System.Drawing.Color.White
        Me.GunaAdvenceTileButton5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceTileButton5.Size = New System.Drawing.Size(64, 65)
        Me.GunaAdvenceTileButton5.TabIndex = 37
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1288, 700)
        Me.Controls.Add(Me.GunaAdvenceTileButton5)
        Me.Controls.Add(Me.GunaAdvenceTileButton2)
        Me.Controls.Add(Me.GunaAdvenceTileButton1)
        Me.Controls.Add(Me.GunaAdvenceTileButton3)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaAdvenceTileButton4)
        Me.Controls.Add(Me.dclt)
        Me.Controls.Add(Me.tclt)
        Me.Controls.Add(Me.eclt)
        Me.Controls.Add(Me.cclt)
        Me.Controls.Add(Me.raclt)
        Me.Controls.Add(Me.pclt)
        Me.Controls.Add(Me.nclt)
        Me.Controls.Add(Me.idadm)
        Me.Controls.Add(Me.idclt)
        Me.Controls.Add(Id_ClientLabel)
        Me.Controls.Add(Id_adminLabel)
        Me.Controls.Add(Nom_ClientLabel)
        Me.Controls.Add(Prenom_ClientLabel)
        Me.Controls.Add(Date_nai_ClientLabel)
        Me.Controls.Add(Rue_ClientLabel)
        Me.Controls.Add(Cp_ClientLabel)
        Me.Controls.Add(Email_ClientLabel)
        Me.Controls.Add(Tele_ClientLabel)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataDataSet As WindowsApplication1.DataDataSet
    Friend WithEvents ClientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientTableAdapter As WindowsApplication1.DataDataSetTableAdapters.ClientTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.DataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents idclt As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents idadm As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents nclt As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents pclt As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents tclt As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents eclt As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents cclt As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents raclt As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents dclt As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents GunaAdvenceTileButton4 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaAdvenceTileButton3 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaAdvenceTileButton5 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaAdvenceTileButton2 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaAdvenceTileButton1 As Guna.UI.WinForms.GunaAdvenceTileButton
End Class
