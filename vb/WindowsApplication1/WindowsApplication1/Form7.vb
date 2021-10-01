Public Class Form7

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDataSet.type_livre' table. You can move, or remove it, as needed.
        Me.Type_livreTableAdapter.Fill(Me.DataDataSet.type_livre)

    End Sub
End Class