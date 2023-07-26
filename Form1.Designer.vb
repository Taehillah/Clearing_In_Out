<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtForceNum = New TextBox()
        lblForceNum = New Label()
        lblRank = New Label()
        cbRank = New ComboBox()
        lblName = New Label()
        TextBox1 = New TextBox()
        lblHomeUnit = New Label()
        txtHomeUnit = New TextBox()
        txtAuthNum = New TextBox()
        lblAuthNum = New Label()
        cbClearingInOut = New ComboBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtForceNum
        ' 
        txtForceNum.Location = New Point(146, 124)
        txtForceNum.Name = "txtForceNum"
        txtForceNum.Size = New Size(176, 23)
        txtForceNum.TabIndex = 0
        ' 
        ' lblForceNum
        ' 
        lblForceNum.AutoSize = True
        lblForceNum.Location = New Point(51, 132)
        lblForceNum.Name = "lblForceNum"
        lblForceNum.Size = New Size(86, 15)
        lblForceNum.TabIndex = 1
        lblForceNum.Text = "Force Number:"
        ' 
        ' lblRank
        ' 
        lblRank.AutoSize = True
        lblRank.Location = New Point(51, 174)
        lblRank.Name = "lblRank"
        lblRank.Size = New Size(36, 15)
        lblRank.TabIndex = 2
        lblRank.Text = "Rank:"
        ' 
        ' cbRank
        ' 
        cbRank.FormattingEnabled = True
        cbRank.Items.AddRange(New Object() {"Pte", "L/Cpl ", "Cpl ", "Sgt ", "S/Sgt", "WO2", "WO1", "SWO", "MWO", "CWO", "SCWO", "MCWO", "Chaplain", "CO", "2Lt ", "Lt ", "Capt", "Maj", "Lt Col", "Col", "Brig Gen", "Maj Gen", "Lt Gen", "Gen"})
        cbRank.Location = New Point(146, 166)
        cbRank.Name = "cbRank"
        cbRank.Size = New Size(176, 23)
        cbRank.TabIndex = 3
        cbRank.Text = "Select Rank"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(51, 216)
        lblName.Name = "lblName"
        lblName.Size = New Size(69, 15)
        lblName.TabIndex = 4
        lblName.Text = "Full Names:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(146, 208)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(176, 23)
        TextBox1.TabIndex = 5
        ' 
        ' lblHomeUnit
        ' 
        lblHomeUnit.AutoSize = True
        lblHomeUnit.Location = New Point(51, 258)
        lblHomeUnit.Name = "lblHomeUnit"
        lblHomeUnit.Size = New Size(73, 15)
        lblHomeUnit.TabIndex = 6
        lblHomeUnit.Text = "Unit(Home):"
        ' 
        ' txtHomeUnit
        ' 
        txtHomeUnit.Location = New Point(146, 250)
        txtHomeUnit.Name = "txtHomeUnit"
        txtHomeUnit.Size = New Size(176, 23)
        txtHomeUnit.TabIndex = 7
        ' 
        ' txtAuthNum
        ' 
        txtAuthNum.Location = New Point(146, 334)
        txtAuthNum.Name = "txtAuthNum"
        txtAuthNum.Size = New Size(176, 23)
        txtAuthNum.TabIndex = 8
        ' 
        ' lblAuthNum
        ' 
        lblAuthNum.AutoSize = True
        lblAuthNum.Location = New Point(51, 342)
        lblAuthNum.Name = "lblAuthNum"
        lblAuthNum.Size = New Size(79, 15)
        lblAuthNum.TabIndex = 9
        lblAuthNum.Text = "Authority No:"
        ' 
        ' cbClearingInOut
        ' 
        cbClearingInOut.FormattingEnabled = True
        cbClearingInOut.Items.AddRange(New Object() {"Out", "In"})
        cbClearingInOut.Location = New Point(146, 292)
        cbClearingInOut.Name = "cbClearingInOut"
        cbClearingInOut.Size = New Size(176, 23)
        cbClearingInOut.TabIndex = 10
        cbClearingInOut.Text = "Select (In/Out)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(51, 300)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 15)
        Label1.TabIndex = 11
        Label1.Text = "Clearing In/Out"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(cbClearingInOut)
        Controls.Add(lblAuthNum)
        Controls.Add(txtAuthNum)
        Controls.Add(txtHomeUnit)
        Controls.Add(lblHomeUnit)
        Controls.Add(TextBox1)
        Controls.Add(lblName)
        Controls.Add(cbRank)
        Controls.Add(lblRank)
        Controls.Add(lblForceNum)
        Controls.Add(txtForceNum)
        Name = "Form1"
        Text = "Clearing In Out"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtForceNum As TextBox
    Friend WithEvents lblForceNum As Label
    Friend WithEvents lblRank As Label
    Friend WithEvents cbRank As ComboBox
    Friend WithEvents lblName As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblHomeUnit As Label
    Friend WithEvents txtHomeUnit As TextBox
    Friend WithEvents txtAuthNum As TextBox
    Friend WithEvents lblAuthNum As Label
    Friend WithEvents cbClearingInOut As ComboBox
    Friend WithEvents Label1 As Label
End Class
