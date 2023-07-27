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
End Class

