<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dtvResponse = New DataGridView()
        lblSectionsApprovalStatus = New Label()
        CType(dtvResponse, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtvResponse
        ' 
        dtvResponse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtvResponse.GridColor = SystemColors.ControlLight
        dtvResponse.Location = New Point(168, 119)
        dtvResponse.Name = "dtvResponse"
        dtvResponse.RowTemplate.Height = 25
        dtvResponse.Size = New Size(476, 266)
        dtvResponse.TabIndex = 0
        ' 
        ' lblSectionsApprovalStatus
        ' 
        lblSectionsApprovalStatus.Anchor = AnchorStyles.Top
        lblSectionsApprovalStatus.AutoSize = True
        lblSectionsApprovalStatus.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblSectionsApprovalStatus.Location = New Point(318, 67)
        lblSectionsApprovalStatus.Name = "lblSectionsApprovalStatus"
        lblSectionsApprovalStatus.Size = New Size(192, 21)
        lblSectionsApprovalStatus.TabIndex = 1
        lblSectionsApprovalStatus.Text = "Sections Approval Status"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblSectionsApprovalStatus)
        Controls.Add(dtvResponse)
        Name = "Form2"
        Text = "Form2"
        CType(dtvResponse, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtvResponse As DataGridView
    Friend WithEvents lblSectionsApprovalStatus As Label
End Class
