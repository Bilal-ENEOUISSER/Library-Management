Public Class Form5

    Private Sub LivreBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LivreBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDataSet.Livre' table. You can move, or remove it, as needed.
        Me.LivreTableAdapter.Fill(Me.DataDataSet.Livre)

    End Sub
End Class