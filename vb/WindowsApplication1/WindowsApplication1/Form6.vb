Public Class Form6

    Private Sub AuteurBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AuteurBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataDataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDataSet.type_livre' table. You can move, or remove it, as needed.
        Me.Type_livreTableAdapter.Fill(Me.DataDataSet.type_livre)
        'TODO: This line of code loads data into the 'DataDataSet.Auteur' table. You can move, or remove it, as needed.
        Me.AuteurTableAdapter.Fill(Me.DataDataSet.Auteur)

    End Sub
End Class