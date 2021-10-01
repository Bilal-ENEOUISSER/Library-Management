<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaAdvenceButton6 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton5 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaAdvenceButton3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton4 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TIME = New System.Windows.Forms.Label()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataDataSet = New WindowsApplication1.DataDataSet()
        Me.LivreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LivreTableAdapter = New WindowsApplication1.DataDataSetTableAdapters.LivreTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.DataDataSetTableAdapters.TableAdapterManager()
        Me.GunaAdvenceButton7 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.AdministrateurBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdministrateurTableAdapter = New WindowsApplication1.DataDataSetTableAdapters.administrateurTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdministrateurBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaAdvenceButton7)
        Me.Panel1.Controls.Add(Me.GunaAdvenceButton6)
        Me.Panel1.Controls.Add(Me.GunaAdvenceButton5)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.GunaAdvenceButton3)
        Me.Panel1.Controls.Add(Me.GunaAdvenceButton4)
        Me.Panel1.Controls.Add(Me.GunaAdvenceButton1)
        Me.Panel1.Controls.Add(Me.GunaAdvenceButton2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 816)
        Me.Panel1.TabIndex = 0
        '
        'GunaAdvenceButton6
        '
        Me.GunaAdvenceButton6.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton6.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GunaAdvenceButton6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaAdvenceButton6.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton6.CheckedBaseColor = System.Drawing.Color.Beige
        Me.GunaAdvenceButton6.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton6.CheckedForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaAdvenceButton6.CheckedImage = CType(resources.GetObject("GunaAdvenceButton6.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton6.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton6.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton6.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceButton6.Image = CType(resources.GetObject("GunaAdvenceButton6.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton6.ImageSize = New System.Drawing.Size(40, 40)
        Me.GunaAdvenceButton6.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton6.Location = New System.Drawing.Point(3, 544)
        Me.GunaAdvenceButton6.Name = "GunaAdvenceButton6"
        Me.GunaAdvenceButton6.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton6.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GunaAdvenceButton6.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GunaAdvenceButton6.OnHoverImage = Nothing
        Me.GunaAdvenceButton6.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton6.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton6.OnPressedDepth = 0
        Me.GunaAdvenceButton6.Size = New System.Drawing.Size(197, 53)
        Me.GunaAdvenceButton6.TabIndex = 6
        Me.GunaAdvenceButton6.Text = "Type Livre"
        Me.GunaAdvenceButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton6.TextOffsetX = 10
        '
        'GunaAdvenceButton5
        '
        Me.GunaAdvenceButton5.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton5.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GunaAdvenceButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaAdvenceButton5.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton5.CheckedBaseColor = System.Drawing.Color.Beige
        Me.GunaAdvenceButton5.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton5.CheckedForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaAdvenceButton5.CheckedImage = CType(resources.GetObject("GunaAdvenceButton5.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton5.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton5.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceButton5.Image = CType(resources.GetObject("GunaAdvenceButton5.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton5.ImageSize = New System.Drawing.Size(40, 40)
        Me.GunaAdvenceButton5.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton5.Location = New System.Drawing.Point(3, 485)
        Me.GunaAdvenceButton5.Name = "GunaAdvenceButton5"
        Me.GunaAdvenceButton5.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton5.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GunaAdvenceButton5.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GunaAdvenceButton5.OnHoverImage = Nothing
        Me.GunaAdvenceButton5.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton5.OnPressedDepth = 0
        Me.GunaAdvenceButton5.Size = New System.Drawing.Size(197, 53)
        Me.GunaAdvenceButton5.TabIndex = 5
        Me.GunaAdvenceButton5.Text = "Auteur"
        Me.GunaAdvenceButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton5.TextOffsetX = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-28, -51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(263, 283)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GunaAdvenceButton3
        '
        Me.GunaAdvenceButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GunaAdvenceButton3.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton3.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaAdvenceButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.CheckedImage = CType(resources.GetObject("GunaAdvenceButton3.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceButton3.Image = CType(resources.GetObject("GunaAdvenceButton3.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GunaAdvenceButton3.ImageSize = New System.Drawing.Size(40, 40)
        Me.GunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.Location = New System.Drawing.Point(0, 762)
        Me.GunaAdvenceButton3.Name = "GunaAdvenceButton3"
        Me.GunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton3.OnHoverImage = Nothing
        Me.GunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton3.Size = New System.Drawing.Size(197, 42)
        Me.GunaAdvenceButton3.TabIndex = 3
        Me.GunaAdvenceButton3.Text = "LogOut"
        '
        'GunaAdvenceButton4
        '
        Me.GunaAdvenceButton4.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton4.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GunaAdvenceButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaAdvenceButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.Beige
        Me.GunaAdvenceButton4.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaAdvenceButton4.CheckedImage = CType(resources.GetObject("GunaAdvenceButton4.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceButton4.Image = CType(resources.GetObject("GunaAdvenceButton4.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton4.ImageOffsetX = 2
        Me.GunaAdvenceButton4.ImageSize = New System.Drawing.Size(40, 40)
        Me.GunaAdvenceButton4.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton4.Location = New System.Drawing.Point(3, 426)
        Me.GunaAdvenceButton4.Name = "GunaAdvenceButton4"
        Me.GunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GunaAdvenceButton4.OnHoverImage = Nothing
        Me.GunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.OnPressedDepth = 0
        Me.GunaAdvenceButton4.Size = New System.Drawing.Size(197, 53)
        Me.GunaAdvenceButton4.TabIndex = 4
        Me.GunaAdvenceButton4.Text = "Livre"
        Me.GunaAdvenceButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton4.TextOffsetX = 10
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Beige
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceButton1.Image = CType(resources.GetObject("GunaAdvenceButton1.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(40, 40)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(0, 308)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnPressedDepth = 0
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(200, 53)
        Me.GunaAdvenceButton1.TabIndex = 1
        Me.GunaAdvenceButton1.Text = "Client"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton1.TextOffsetX = 10
        '
        'GunaAdvenceButton2
        '
        Me.GunaAdvenceButton2.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton2.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaAdvenceButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Beige
        Me.GunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaAdvenceButton2.CheckedImage = CType(resources.GetObject("GunaAdvenceButton2.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceButton2.Image = CType(resources.GetObject("GunaAdvenceButton2.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton2.ImageSize = New System.Drawing.Size(40, 40)
        Me.GunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(3, 367)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverImage = Nothing
        Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.OnPressedDepth = 0
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(197, 53)
        Me.GunaAdvenceButton2.TabIndex = 2
        Me.GunaAdvenceButton2.Text = "List Client"
        Me.GunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton2.TextOffsetX = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TIME)
        Me.Panel2.Controls.Add(Me.GunaLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1288, 116)
        Me.Panel2.TabIndex = 1
        '
        'TIME
        '
        Me.TIME.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TIME.AutoSize = True
        Me.TIME.Font = New System.Drawing.Font("Traditional Arabic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.TIME.Location = New System.Drawing.Point(971, 66)
        Me.TIME.Name = "TIME"
        Me.TIME.Size = New System.Drawing.Size(202, 50)
        Me.TIME.TabIndex = 1
        Me.TIME.Text = "DATE TIME"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Imprint MT Shadow", 40.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(407, 9)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(462, 80)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "READ DOTS"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(200, 116)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1288, 700)
        Me.Panel3.TabIndex = 2
        '
        'Timer1
        '
        '
        'DataDataSet
        '
        Me.DataDataSet.DataSetName = "DataDataSet"
        Me.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LivreBindingSource
        '
        Me.LivreBindingSource.DataMember = "Livre"
        Me.LivreBindingSource.DataSource = Me.DataDataSet
        '
        'LivreTableAdapter
        '
        Me.LivreTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.administrateurTableAdapter = Nothing
        Me.TableAdapterManager.AuteurTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BoissonTableAdapter = Nothing
        Me.TableAdapterManager.ClientTableAdapter = Nothing
        Me.TableAdapterManager.facture_BoissonTableAdapter = Nothing
        Me.TableAdapterManager.FactureTableAdapter = Nothing
        Me.TableAdapterManager.LivreTableAdapter = Me.LivreTableAdapter
        Me.TableAdapterManager.type_livreTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.DataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GunaAdvenceButton7
        '
        Me.GunaAdvenceButton7.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton7.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GunaAdvenceButton7.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaAdvenceButton7.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton7.CheckedBaseColor = System.Drawing.Color.Beige
        Me.GunaAdvenceButton7.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton7.CheckedForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaAdvenceButton7.CheckedImage = CType(resources.GetObject("GunaAdvenceButton7.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton7.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton7.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton7.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton7.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GunaAdvenceButton7.Image = CType(resources.GetObject("GunaAdvenceButton7.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton7.ImageOffsetX = 5
        Me.GunaAdvenceButton7.ImageSize = New System.Drawing.Size(35, 35)
        Me.GunaAdvenceButton7.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton7.Location = New System.Drawing.Point(0, 249)
        Me.GunaAdvenceButton7.Name = "GunaAdvenceButton7"
        Me.GunaAdvenceButton7.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton7.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GunaAdvenceButton7.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.GunaAdvenceButton7.OnHoverImage = Nothing
        Me.GunaAdvenceButton7.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton7.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton7.OnPressedDepth = 0
        Me.GunaAdvenceButton7.Size = New System.Drawing.Size(200, 53)
        Me.GunaAdvenceButton7.TabIndex = 7
        Me.GunaAdvenceButton7.Text = "Admin"
        Me.GunaAdvenceButton7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton7.TextOffsetX = 10
        '
        'AdministrateurBindingSource
        '
        Me.AdministrateurBindingSource.DataMember = "administrateur"
        Me.AdministrateurBindingSource.DataSource = Me.DataDataSet
        '
        'AdministrateurTableAdapter
        '
        Me.AdministrateurTableAdapter.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1488, 816)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdministrateurBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents TIME As System.Windows.Forms.Label
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton4 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents DataDataSet As WindowsApplication1.DataDataSet
    Friend WithEvents LivreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LivreTableAdapter As WindowsApplication1.DataDataSetTableAdapters.LivreTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.DataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GunaAdvenceButton6 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton5 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton7 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents AdministrateurBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdministrateurTableAdapter As WindowsApplication1.DataDataSetTableAdapters.administrateurTableAdapter
End Class
