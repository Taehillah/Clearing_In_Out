Imports System.IO
Imports System.Data.SqlClient
Imports System.Reflection.Metadata

Public Class Form1

    Dim connectionString As String = "Data Source=clearing-in-outdbserver.database.windows.net;Initial Catalog=Clearing_In_Out_db;User ID=Taehillah;Password=Lehlohonolo@01;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Added items to the cmbClearingInOut ComboBox
        cmbClearingInOut.Items.Add("In")
        cmbClearingInOut.Items.Add("Out")
        ClbClearingSections.ScrollAlwaysVisible = False
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
        Dim checkedItems As String = ""

        For Each item In ClbClearingSections.CheckedItems
            checkedItems &= item.ToString() & ", "
        Next

        ' Remove the trailing comma and space from the checkedItems string
        If checkedItems.Length > 2 Then
            checkedItems = checkedItems.Substring(0, checkedItems.Length - 2)
        End If


        ' Dim strRankString As String = strRank.ToString()
        '  Dim strClearingInOutString As String = strClearingInOut.ToString()

        ' Dim filepath As String = "C:\Users\Public\Desktop"
        Dim documentsFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim filePath As String = Path.Combine(documentsFolder, "data.txt")

        Try
            ' Connect to the database
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Execute an SQL command to insert the data into the database
                Dim sqlInsertQuery As String = "INSERT INTO dbo.FORM1 (ForceNum, Ranks, FullNames, HomeUnit, ClearingInOut, Authority, ReturnDate, UnitVisiting) " &
                                               "VALUES (@ForceNumber, @Rank, @Name, @HomeUnit, @Clearing, @AuthorityNumber, @Date, @UnitVisiting)"

                Using cmd As New SqlCommand(sqlInsertQuery, connection)
                    cmd.Parameters.AddWithValue("@ForceNumber", strForceNum)
                    cmd.Parameters.AddWithValue("@Rank", strRank)
                    cmd.Parameters.AddWithValue("@Name", strName)
                    cmd.Parameters.AddWithValue("@HomeUnit", strHomeUnit)
                    cmd.Parameters.AddWithValue("@Clearing", strClearingInOut)
                    cmd.Parameters.AddWithValue("@AuthorityNumber", strAuthorityNum)
                    cmd.Parameters.AddWithValue("@Date", strDateTime)
                    cmd.Parameters.AddWithValue("@UnitVisiting", strUnitVisiting)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Display a success message to the user
            MessageBox.Show("Data has been exported to the database.")

            ' Clearing the input fields after exporting the data
            txtForceNum.Text = ""
            txtName.Text = ""
            cmbRank.SelectedValue = Nothing
            txtHomeUnit.Text = ""
            cmbClearingInOut.SelectedValue = Nothing
            txtAuthNum.Text = ""
            dtpReturnDate.Text = ""
            txtUnitVisiting.Text = ""



        Catch ex As Exception
            ' Handle any exceptions that may occur during database operations
            MessageBox.Show("Error exporting data: " & ex.Message)
        End Try

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
                writer.WriteLine("Checked Sections: " & checkedItems)

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

