Public Class Form2

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDataSet.administrateur' table. You can move, or remove it, as needed.
        Me.AdministrateurTableAdapter.Fill(Me.DataDataSet.administrateur)
        'TODO: This line of code loads data into the 'DataDataSet.Livre' table. You can move, or remove it, as needed.
        Me.LivreTableAdapter.Fill(Me.DataDataSet.Livre)
        'TODO: This line of code loads data into the 'DataDataSet.Livre' table. You can move, or remove it, as needed.
        Me.LivreTableAdapter.Fill(Me.DataDataSet.Livre)
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        With Form3
            .TopLevel = False
            Panel3.Controls.Add(Form3)
            .BringToFront()
            .Show()


        End With
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles TIME.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TIME.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")
    End Sub


    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        SwitchPanel(Form3)
    End Sub
    Sub SwitchPanel(ByVal panel As Form)
        Panel3.Controls.Clear()
        panel.TopLevel = False
        Panel3.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        SwitchPanel(Form4)
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click

        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
        SwitchPanel(Form5)
    End Sub

    Private Sub LivreBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LivreBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataDataSet)

    End Sub

    Private Sub LivreBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LivreBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataDataSet)

    End Sub

    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        SwitchPanel(Form6)
    End Sub

    Private Sub GunaAdvenceButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton6.Click
        SwitchPanel(Form7)
    End Sub

    Private Sub GunaAdvenceButton7_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton7.Click
        SwitchPanel(Form8)
    End Sub
End Class