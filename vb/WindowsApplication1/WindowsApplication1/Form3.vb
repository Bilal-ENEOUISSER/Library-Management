Imports System.Data.OleDb

Public Class Form3
  
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDataSet.Client' table. You can move, or remove it, as needed.
        Me.ClientTableAdapter.Fill(Me.DataDataSet.Client)
        'TODO: This line of code loads data into the 'DataDataSet.Client' table. You can move, or remove it, as needed.
        Me.ClientTableAdapter.Fill(Me.DataDataSet.Client)

    End Sub

    Private Sub ClientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataDataSet)

    End Sub

    Private Sub ClientBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataDataSet)

    End Sub

    Private Sub GunaAdvenceTileButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton3.Click

    End Sub

    Private Sub GunaAdvenceTileButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton4.Click
        
       
    End Sub
End Class