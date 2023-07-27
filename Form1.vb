Imports System.IO
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Added items to the cmbClearingInOut ComboBox
        cmbClearingInOut.Items.Add("In")
        cmbClearingInOut.Items.Add("Out")

    End Sub

    Private Sub cmbClearingInOut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClearingInOut.SelectedIndexChanged
        ' Get the selected option from the cmbClearingInOut ComboBox
        Dim selectedOption As String = cmbClearingInOut.SelectedItem.ToString()

        ' Disable txtUnitVisiting if the selected option is "In"; otherwise, enable it.
        If selectedOption = "In" Then
            txtUnitVisiting.Enabled = False
            dtpReturnDate.Enabled = False
        Else
            txtUnitVisiting.Enabled = True
            dtpReturnDate.Enabled = True
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim strForceNum As String = txtForceNum.Text
        Dim strName As String = txtName.Text
        Dim strRank As String = cmbRank.SelectedValue 'if problems the type Object then toString()
        Dim strHomeUnit As String = txtHomeUnit.Text
        Dim strClearingInOut As String = cmbClearingInOut.SelectedValue
        Dim strAuthorityNum As String = txtAuthNum.Text
        Dim 

    End Sub
End Class

