Public Class Form1
    Private Sub cbClearingInOut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClearingInOut.SelectedIndexChanged
        Dim selectedOption As String = cmbClearingInOut.SelectedItem.ToString()

        Select Case selectedOption
            Case "Option 1"
                dtpReturnDate.Enabled = True
                txtUnitVisiting.Enabled = True
            Case "Option 2"
                dtpReturnDate.Enabled = False
                txtUnitVisiting.Enabled = False
        End Select
    End Sub
End Class
