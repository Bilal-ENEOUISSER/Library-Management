Imports System.Data.OleDb

Public Class Form8
    Dim conne As New OleDbConnection

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDataSet.administrateur' table. You can move, or remove it, as needed.
        Me.AdministrateurTableAdapter.Fill(Me.DataDataSet.administrateur)

    End Sub

    Private Sub GunaAdvenceTileButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton4.Click
       

 

    End Sub
End Class