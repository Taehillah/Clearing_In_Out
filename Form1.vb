Imports System.IO
Imports System.Data.SqlClient

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

        Dim strForceNum As String = txtForceNum.Text.Trim()
        Dim strName As String = txtName.Text.Trim()
        Dim strRank As String = cmbRank.SelectedItem 'if problems the type Object then toString()
        Dim strHomeUnit As String = txtHomeUnit.Text.Trim()
        Dim strClearingInOut As Object = cmbClearingInOut.SelectedItem
        Dim strAuthorityNum As String = txtAuthNum.Text.Trim()
        Dim strDateTime As String = dtpReturnDate.Text.Trim() 'object if problem
        Dim strUnitVisiting As String = txtUnitVisiting.Text.Trim()

        ' Dim strRankString As String = strRank.ToString()
        '  Dim strClearingInOutString As String = strClearingInOut.ToString()

        ' Dim filepath As String = "C:\Users\Public\Desktop"
        Dim documentsFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim filePath As String = Path.Combine(documentsFolder, "data.txt")



        Try
            ' Create or append to the text file and write the data
            Using writer As New StreamWriter(filePath, True)
                writer.WriteLine("Force Number: " & strForceNum)
                writer.WriteLine("Name: " & strName)
                writer.WriteLine("Rank: " & strRank)
                writer.WriteLine("Home Unit: " & strHomeUnit)
                writer.WriteLine("Clearing: " & strClearingInOut)
                writer.WriteLine("Authority Number: " & strAuthorityNum)
                writer.WriteLine("Date: " & strDateTime)
                writer.WriteLine("Unit (Visiting): " & strUnitVisiting)
                writer.WriteLine("----------") ' Separating line between entries
            End Using

            ' Display a success message to the user
            MessageBox.Show("Data has been exported to " & filePath)

            ' Clear the input fields after exporting the data
            txtForceNum.Text = ""
            txtName.Text = ""
            cmbRank.SelectedValue = ""
            txtHomeUnit.Text = ""
            cmbClearingInOut.SelectedValue = ""
            txtAuthNum.Text = ""
            dtpReturnDate.Text = ""
            txtUnitVisiting.Text = ""

        Catch ex As Exception
            ' Handle any exceptions that may occur during writing to the file
            MessageBox.Show("Error exporting data: " & ex.Message)
        End Try

    End Sub
End Class

