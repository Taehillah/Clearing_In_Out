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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
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
        lblReturnDate = New Label()
        dtpReturnDate = New DateTimePicker()
        PictureBox1 = New PictureBox()
        txtUnitVisiting = New TextBox()
        lblUnitVisiting = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtForceNum
        ' 
        txtForceNum.Location = New Point(140, 131)
        txtForceNum.Name = "txtForceNum"
        txtForceNum.Size = New Size(176, 23)
        txtForceNum.TabIndex = 0
        ' 
        ' lblForceNum
        ' 
        lblForceNum.AutoSize = True
        lblForceNum.Location = New Point(45, 139)
        lblForceNum.Name = "lblForceNum"
        lblForceNum.Size = New Size(86, 15)
        lblForceNum.TabIndex = 1
        lblForceNum.Text = "Force Number:"
        ' 
        ' lblRank
        ' 
        lblRank.AutoSize = True
        lblRank.Location = New Point(45, 181)
        lblRank.Name = "lblRank"
        lblRank.Size = New Size(36, 15)
        lblRank.TabIndex = 2
        lblRank.Text = "Rank:"
        ' 
        ' cbRank
        ' 
        cbRank.FormattingEnabled = True
        cbRank.Items.AddRange(New Object() {"Pte", "L/Cpl ", "Cpl ", "Sgt ", "S/Sgt", "WO2", "WO1", "SWO", "MWO", "CWO", "SCWO", "MCWO", "Chaplain", "CO", "2Lt ", "Lt ", "Capt", "Maj", "Lt Col", "Col", "Brig Gen", "Maj Gen", "Lt Gen", "Gen"})
        cbRank.Location = New Point(140, 173)
        cbRank.Name = "cbRank"
        cbRank.Size = New Size(176, 23)
        cbRank.TabIndex = 3
        cbRank.Text = "Select Rank"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(45, 223)
        lblName.Name = "lblName"
        lblName.Size = New Size(69, 15)
        lblName.TabIndex = 4
        lblName.Text = "Full Names:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(140, 215)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(176, 23)
        TextBox1.TabIndex = 5
        ' 
        ' lblHomeUnit
        ' 
        lblHomeUnit.AutoSize = True
        lblHomeUnit.Location = New Point(45, 265)
        lblHomeUnit.Name = "lblHomeUnit"
        lblHomeUnit.Size = New Size(73, 15)
        lblHomeUnit.TabIndex = 6
        lblHomeUnit.Text = "Unit(Home):"
        ' 
        ' txtHomeUnit
        ' 
        txtHomeUnit.Location = New Point(140, 257)
        txtHomeUnit.Name = "txtHomeUnit"
        txtHomeUnit.Size = New Size(176, 23)
        txtHomeUnit.TabIndex = 7
        ' 
        ' txtAuthNum
        ' 
        txtAuthNum.Location = New Point(523, 173)
        txtAuthNum.Name = "txtAuthNum"
        txtAuthNum.Size = New Size(176, 23)
        txtAuthNum.TabIndex = 8
        ' 
        ' lblAuthNum
        ' 
        lblAuthNum.AutoSize = True
        lblAuthNum.Location = New Point(428, 181)
        lblAuthNum.Name = "lblAuthNum"
        lblAuthNum.Size = New Size(79, 15)
        lblAuthNum.TabIndex = 9
        lblAuthNum.Text = "Authority No:"
        ' 
        ' cbClearingInOut
        ' 
        cbClearingInOut.FormattingEnabled = True
        cbClearingInOut.Items.AddRange(New Object() {"Out", "In"})
        cbClearingInOut.Location = New Point(523, 131)
        cbClearingInOut.Name = "cbClearingInOut"
        cbClearingInOut.Size = New Size(176, 23)
        cbClearingInOut.TabIndex = 10
        cbClearingInOut.Text = "Select (In/Out)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(428, 139)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 15)
        Label1.TabIndex = 11
        Label1.Text = "Clearing In/Out:"
        ' 
        ' lblReturnDate
        ' 
        lblReturnDate.AutoSize = True
        lblReturnDate.Location = New Point(428, 223)
        lblReturnDate.Name = "lblReturnDate"
        lblReturnDate.Size = New Size(77, 15)
        lblReturnDate.TabIndex = 12
        lblReturnDate.Text = "Date(Return):"
        ' 
        ' dtpReturnDate
        ' 
        dtpReturnDate.Format = DateTimePickerFormat.Short
        dtpReturnDate.Location = New Point(523, 217)
        dtpReturnDate.Name = "dtpReturnDate"
        dtpReturnDate.Size = New Size(176, 23)
        dtpReturnDate.TabIndex = 14
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(345, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(74, 69)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' txtUnitVisiting
        ' 
        txtUnitVisiting.Location = New Point(523, 257)
        txtUnitVisiting.Name = "txtUnitVisiting"
        txtUnitVisiting.Size = New Size(176, 23)
        txtUnitVisiting.TabIndex = 16
        ' 
        ' lblUnitVisiting
        ' 
        lblUnitVisiting.AutoSize = True
        lblUnitVisiting.Location = New Point(428, 265)
        lblUnitVisiting.Name = "lblUnitVisiting"
        lblUnitVisiting.Size = New Size(79, 15)
        lblUnitVisiting.TabIndex = 17
        lblUnitVisiting.Text = "Unit(Visiting):"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblUnitVisiting)
        Controls.Add(txtUnitVisiting)
        Controls.Add(PictureBox1)
        Controls.Add(dtpReturnDate)
        Controls.Add(lblReturnDate)
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
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblReturnDate As Label
    Friend WithEvents dtpReturnDate As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtUnitVisiting As TextBox
    Friend WithEvents lblUnitVisiting As Label
End Class
