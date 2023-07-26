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
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' txtForceNum
        ' 
        txtForceNum.Location = New Point(146, 114)
        txtForceNum.Name = "txtForceNum"
        txtForceNum.Size = New Size(176, 23)
        txtForceNum.TabIndex = 0
        ' 
        ' lblForceNum
        ' 
        lblForceNum.AutoSize = True
        lblForceNum.Location = New Point(54, 122)
        lblForceNum.Name = "lblForceNum"
        lblForceNum.Size = New Size(86, 15)
        lblForceNum.TabIndex = 1
        lblForceNum.Text = "Force Number:"
        ' 
        ' lblRank
        ' 
        lblRank.AutoSize = True
        lblRank.Location = New Point(54, 176)
        lblRank.Name = "lblRank"
        lblRank.Size = New Size(36, 15)
        lblRank.TabIndex = 2
        lblRank.Text = "Rank:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Pte", "L/Cpl ", "Cpl ", "Sgt ", "S/Sgt", "WO2", "WO1", "SWO", "MWO", "CWO", "SCWO", "MCWO", "Chaplain", "CO", "2Lt ", "Lt ", "Capt", "Maj", "Lt Col", "Col", "Brig Gen", "Maj Gen", "Lt Gen", "Gen"})
        ComboBox1.Location = New Point(146, 177)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(176, 23)
        ComboBox1.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ComboBox1)
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
    Friend WithEvents ComboBox1 As ComboBox
End Class
