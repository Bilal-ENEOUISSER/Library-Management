Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDataSet.Client' table. You can move, or remove it, as needed.
        Me.ClientTableAdapter.Fill(Me.DataDataSet.Client)

    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class