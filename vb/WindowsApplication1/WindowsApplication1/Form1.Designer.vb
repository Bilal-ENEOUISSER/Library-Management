<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.P1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaCheckBox1 = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.pass = New ns1.BunifuMaterialTextbox()
        Me.user = New ns1.BunifuMaterialTextbox()
        Me.anim1 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.GunaPanel1.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.GunaPictureBox1)
        Me.anim1.SetDecoration(Me.GunaPanel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaPanel1.Location = New System.Drawing.Point(2, 2)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(303, 558)
        Me.GunaPanel1.TabIndex = 0
        Me.GunaPanel1.TabStop = True
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.anim1.SetDecoration(Me.GunaPictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(-49, 78)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(394, 381)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'P1
        '
        Me.P1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.P1.Controls.Add(Me.GunaCheckBox1)
        Me.P1.Controls.Add(Me.GunaButton1)
        Me.P1.Controls.Add(Me.pass)
        Me.P1.Controls.Add(Me.user)
        Me.anim1.SetDecoration(Me.P1, Guna.UI.Animation.DecorationType.None)
        Me.P1.Location = New System.Drawing.Point(303, 2)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(333, 558)
        Me.P1.TabIndex = 1
        Me.P1.TabStop = True
        '
        'GunaCheckBox1
        '
        Me.GunaCheckBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox1.CheckedOnColor = System.Drawing.Color.Beige
        Me.anim1.SetDecoration(Me.GunaCheckBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaCheckBox1.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GunaCheckBox1.Location = New System.Drawing.Point(36, 228)
        Me.GunaCheckBox1.Name = "GunaCheckBox1"
        Me.GunaCheckBox1.Size = New System.Drawing.Size(125, 20)
        Me.GunaCheckBox1.TabIndex = 5
        Me.GunaCheckBox1.Text = "Show Password"
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.Beige
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.anim1.SetDecoration(Me.GunaButton1, Guna.UI.Animation.DecorationType.None)
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.Black
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(36, 315)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(247, 42)
        Me.GunaButton1.TabIndex = 3
        Me.GunaButton1.Text = "Sign In"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pass
        '
        Me.pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anim1.SetDecoration(Me.pass, Guna.UI.Animation.DecorationType.None)
        Me.pass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.pass.ForeColor = System.Drawing.Color.White
        Me.pass.HintForeColor = System.Drawing.Color.White
        Me.pass.HintText = "Password"
        Me.pass.isPassword = False
        Me.pass.LineFocusedColor = System.Drawing.Color.Beige
        Me.pass.LineIdleColor = System.Drawing.Color.White
        Me.pass.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.pass.LineThickness = 3
        Me.pass.Location = New System.Drawing.Point(36, 156)
        Me.pass.Margin = New System.Windows.Forms.Padding(4)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(247, 57)
        Me.pass.TabIndex = 2
        Me.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'user
        '
        Me.user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anim1.SetDecoration(Me.user, Guna.UI.Animation.DecorationType.None)
        Me.user.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.user.ForeColor = System.Drawing.Color.White
        Me.user.HintForeColor = System.Drawing.Color.Silver
        Me.user.HintText = "Username"
        Me.user.isPassword = False
        Me.user.LineFocusedColor = System.Drawing.Color.Beige
        Me.user.LineIdleColor = System.Drawing.Color.White
        Me.user.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.user.LineThickness = 3
        Me.user.Location = New System.Drawing.Point(36, 78)
        Me.user.Margin = New System.Windows.Forms.Padding(4)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(247, 58)
        Me.user.TabIndex = 1
        Me.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'anim1
        '
        Me.anim1.AnimationType = Guna.UI.Animation.AnimationType.Scale
        Me.anim1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0.0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0.0!
        Animation1.RotateLimit = 0.0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0.0!
        Animation1.TransparencyCoeff = 0.0!
        Me.anim1.DefaultAnimation = Animation1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(633, 558)
        Me.Controls.Add(Me.P1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.anim1.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GunaPanel1.ResumeLayout(False)
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P1.ResumeLayout(False)
        Me.P1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents P1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents anim1 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents GunaCheckBox1 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents pass As ns1.BunifuMaterialTextbox
    Friend WithEvents user As ns1.BunifuMaterialTextbox

End Class
