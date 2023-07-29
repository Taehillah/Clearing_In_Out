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
        cmbRank = New ComboBox()
        lblName = New Label()
        txtName = New TextBox()
        lblHomeUnit = New Label()
        txtHomeUnit = New TextBox()
        txtAuthNum = New TextBox()
        lblAuthNum = New Label()
        cmbClearingInOut = New ComboBox()
        Label1 = New Label()
        lblReturnDate = New Label()
        dtpReturnDate = New DateTimePicker()
        PictureBox1 = New PictureBox()
        txtUnitVisiting = New TextBox()
        lblUnitVisiting = New Label()
        btnSubmit = New Button()
        lblBrigadeName1 = New Label()
        Label2 = New Label()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        CheckedListBox1 = New CheckedListBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtForceNum
        ' 
        txtForceNum.Location = New Point(336, 175)
        txtForceNum.Name = "txtForceNum"
        txtForceNum.Size = New Size(176, 23)
        txtForceNum.TabIndex = 0
        ' 
        ' lblForceNum
        ' 
        lblForceNum.AutoSize = True
        lblForceNum.Location = New Point(228, 183)
        lblForceNum.Name = "lblForceNum"
        lblForceNum.Size = New Size(86, 15)
        lblForceNum.TabIndex = 1
        lblForceNum.Text = "Force Number:"
        ' 
        ' lblRank
        ' 
        lblRank.AutoSize = True
        lblRank.Location = New Point(228, 225)
        lblRank.Name = "lblRank"
        lblRank.Size = New Size(36, 15)
        lblRank.TabIndex = 2
        lblRank.Text = "Rank:"
        ' 
        ' cmbRank
        ' 
        cmbRank.FormattingEnabled = True
        cmbRank.Items.AddRange(New Object() {"Pte", "L/Cpl ", "Cpl ", "Sgt ", "S/Sgt", "WO2", "WO1", "SWO", "MWO", "CWO", "SCWO", "MCWO", "Chaplain", "CO", "2Lt ", "Lt ", "Capt", "Maj", "Lt Col", "Col", "Brig Gen", "Maj Gen", "Lt Gen", "Gen"})
        cmbRank.Location = New Point(336, 217)
        cmbRank.Name = "cmbRank"
        cmbRank.Size = New Size(176, 23)
        cmbRank.TabIndex = 3
        cmbRank.Text = "Select Rank"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(228, 267)
        lblName.Name = "lblName"
        lblName.Size = New Size(69, 15)
        lblName.TabIndex = 4
        lblName.Text = "Full Names:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(336, 259)
        txtName.Name = "txtName"
        txtName.Size = New Size(176, 23)
        txtName.TabIndex = 5
        ' 
        ' lblHomeUnit
        ' 
        lblHomeUnit.AutoSize = True
        lblHomeUnit.Location = New Point(228, 309)
        lblHomeUnit.Name = "lblHomeUnit"
        lblHomeUnit.Size = New Size(73, 15)
        lblHomeUnit.TabIndex = 6
        lblHomeUnit.Text = "Unit(Home):"
        ' 
        ' txtHomeUnit
        ' 
        txtHomeUnit.Location = New Point(336, 301)
        txtHomeUnit.Name = "txtHomeUnit"
        txtHomeUnit.Size = New Size(176, 23)
        txtHomeUnit.TabIndex = 7
        ' 
        ' txtAuthNum
        ' 
        txtAuthNum.Location = New Point(721, 217)
        txtAuthNum.Name = "txtAuthNum"
        txtAuthNum.Size = New Size(176, 23)
        txtAuthNum.TabIndex = 8
        ' 
        ' lblAuthNum
        ' 
        lblAuthNum.AutoSize = True
        lblAuthNum.Location = New Point(611, 225)
        lblAuthNum.Name = "lblAuthNum"
        lblAuthNum.Size = New Size(79, 15)
        lblAuthNum.TabIndex = 9
        lblAuthNum.Text = "Authority No:"
        ' 
        ' cmbClearingInOut
        ' 
        cmbClearingInOut.FormattingEnabled = True
        cmbClearingInOut.Location = New Point(721, 175)
        cmbClearingInOut.Name = "cmbClearingInOut"
        cmbClearingInOut.Size = New Size(176, 23)
        cmbClearingInOut.TabIndex = 10
        cmbClearingInOut.Text = "Select (In/Out)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(611, 183)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 15)
        Label1.TabIndex = 11
        Label1.Text = "Clearing In/Out:"
        ' 
        ' lblReturnDate
        ' 
        lblReturnDate.AutoSize = True
        lblReturnDate.Location = New Point(611, 267)
        lblReturnDate.Name = "lblReturnDate"
        lblReturnDate.Size = New Size(77, 15)
        lblReturnDate.TabIndex = 12
        lblReturnDate.Text = "Date(Return):"
        ' 
        ' dtpReturnDate
        ' 
        dtpReturnDate.AllowDrop = True
        dtpReturnDate.Format = DateTimePickerFormat.Short
        dtpReturnDate.Location = New Point(721, 261)
        dtpReturnDate.Name = "dtpReturnDate"
        dtpReturnDate.Size = New Size(176, 23)
        dtpReturnDate.TabIndex = 14
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(513, 44)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(74, 69)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' txtUnitVisiting
        ' 
        txtUnitVisiting.Location = New Point(721, 301)
        txtUnitVisiting.Name = "txtUnitVisiting"
        txtUnitVisiting.Size = New Size(176, 23)
        txtUnitVisiting.TabIndex = 16
        ' 
        ' lblUnitVisiting
        ' 
        lblUnitVisiting.AutoSize = True
        lblUnitVisiting.Location = New Point(611, 309)
        lblUnitVisiting.Name = "lblUnitVisiting"
        lblUnitVisiting.Size = New Size(79, 15)
        lblUnitVisiting.TabIndex = 17
        lblUnitVisiting.Text = "Unit(Visiting):"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Anchor = AnchorStyles.Top
        btnSubmit.Location = New Point(513, 570)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(112, 26)
        btnSubmit.TabIndex = 18
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' lblBrigadeName1
        ' 
        lblBrigadeName1.Anchor = AnchorStyles.Top
        lblBrigadeName1.AutoSize = True
        lblBrigadeName1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblBrigadeName1.Location = New Point(468, 20)
        lblBrigadeName1.Name = "lblBrigadeName1"
        lblBrigadeName1.Size = New Size(152, 21)
        lblBrigadeName1.TabIndex = 19
        lblBrigadeName1.Text = "HQ 46 SA BRIGADE"
        lblBrigadeName1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(476, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 17)
        Label2.TabIndex = 20
        Label2.Text = "Clearing In | Out Form"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Location = New Point(409, 362)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(306, 148)
        CheckedListBox1.TabIndex = 21
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1125, 705)
        Controls.Add(CheckedListBox1)
        Controls.Add(Label2)
        Controls.Add(lblBrigadeName1)
        Controls.Add(btnSubmit)
        Controls.Add(lblUnitVisiting)
        Controls.Add(txtUnitVisiting)
        Controls.Add(PictureBox1)
        Controls.Add(dtpReturnDate)
        Controls.Add(lblReturnDate)
        Controls.Add(Label1)
        Controls.Add(cmbClearingInOut)
        Controls.Add(lblAuthNum)
        Controls.Add(txtAuthNum)
        Controls.Add(txtHomeUnit)
        Controls.Add(lblHomeUnit)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Controls.Add(cmbRank)
        Controls.Add(lblRank)
        Controls.Add(lblForceNum)
        Controls.Add(txtForceNum)
        Name = "Form1"
        Text = "Clearing In Out"
        TransparencyKey = SystemColors.ControlDark
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtForceNum As TextBox
    Friend WithEvents lblForceNum As Label
    Friend WithEvents lblRank As Label
    Friend WithEvents cmbRank As ComboBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblHomeUnit As Label
    Friend WithEvents txtHomeUnit As TextBox
    Friend WithEvents txtAuthNum As TextBox
    Friend WithEvents lblAuthNum As Label
    Friend WithEvents cmbClearingInOut As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblReturnDate As Label
    Friend WithEvents dtpReturnDate As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtUnitVisiting As TextBox
    Friend WithEvents lblUnitVisiting As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblBrigadeName1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents CheckedListBox1 As CheckedListBox
End Class
