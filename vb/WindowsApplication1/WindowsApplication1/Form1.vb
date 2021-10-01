Imports System.Data.OleDb


Public Class Form1
    Dim con As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\vb\WindowsApplication1\Data.accdb"
    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles user.OnValueChanged

    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub GunaPanel2_Paint(sender As Object, e As PaintEventArgs) Handles P1.Paint

    End Sub

    Private Sub GunaCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckBox1.CheckedChanged

    End Sub

    Private Sub LINK1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        anim1.HideSync(P1)

    End Sub

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs)
        anim1.HideSync(P1)

    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs)

        anim1.ShowSync(P1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        anim1.ShowSync(P1)
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If user.Text = Nothing And pass.Text = Nothing Then
            MsgBox(" Error Empty please ", MsgBoxStyle.Critical)
        End If

        If con.State = ConnectionState.Closed Then

            con.Open()
        End If
        Dim Userv As String = user.Text
        Dim Passv As String = pass.Text
        user.Text = ""
        pass.Text = ""
        Using login As New OleDbCommand("SELECT COUNT(*) FROM administrateur WHERE [Nom_admin] = @Nom_admin AND [password] = @password", con)
            login.Parameters.AddWithValue("@Nom_admin", OleDbType.VarChar).Value = Userv.Trim
            login.Parameters.AddWithValue("@password", OleDbType.VarChar).Value = Passv.Trim

            Dim loginCount = Convert.ToInt32(login.ExecuteScalar())

            If loginCount > 0 Then
                Me.Hide()
                Form2.Show()
            Else
                MsgBox("error")
                user.Text = ""
                pass.Text = ""


            End If
        End Using
        con.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = dbProvider & dbSource
    End Sub
End Class
  




