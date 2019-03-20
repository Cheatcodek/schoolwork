<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnInput = New System.Windows.Forms.Button()
        Me.grpSort = New System.Windows.Forms.GroupBox()
        Me.btnDescending = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnAscending = New System.Windows.Forms.Button()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.grpSort.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(12, 210)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(85, 23)
        Me.btnInput.TabIndex = 0
        Me.btnInput.Tag = "1"
        Me.btnInput.Text = "Input Contacts"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'grpSort
        '
        Me.grpSort.Controls.Add(Me.btnDescending)
        Me.grpSort.Controls.Add(Me.btnFind)
        Me.grpSort.Controls.Add(Me.btnAscending)
        Me.grpSort.Enabled = False
        Me.grpSort.Location = New System.Drawing.Point(103, 168)
        Me.grpSort.Name = "grpSort"
        Me.grpSort.Size = New System.Drawing.Size(108, 89)
        Me.grpSort.TabIndex = 1
        Me.grpSort.TabStop = False
        Me.grpSort.Text = "Sort"
        '
        'btnDescending
        '
        Me.btnDescending.Location = New System.Drawing.Point(7, 37)
        Me.btnDescending.Name = "btnDescending"
        Me.btnDescending.Size = New System.Drawing.Size(75, 23)
        Me.btnDescending.TabIndex = 1
        Me.btnDescending.Tag = "3"
        Me.btnDescending.Text = "Descending"
        Me.btnDescending.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(7, 58)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 2
        Me.btnFind.Tag = "4"
        Me.btnFind.Text = "Find..."
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnAscending
        '
        Me.btnAscending.Location = New System.Drawing.Point(7, 15)
        Me.btnAscending.Name = "btnAscending"
        Me.btnAscending.Size = New System.Drawing.Size(75, 23)
        Me.btnAscending.TabIndex = 0
        Me.btnAscending.Tag = "2"
        Me.btnAscending.Text = "Ascending"
        Me.btnAscending.UseVisualStyleBackColor = True
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMain.Location = New System.Drawing.Point(12, 62)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(2, 15)
        Me.lblMain.TabIndex = 3
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 261)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.grpSort)
        Me.Controls.Add(Me.btnInput)
        Me.Name = "frmMain"
        Me.Text = "MyFriends"
        Me.grpSort.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInput As Button
    Friend WithEvents grpSort As GroupBox
    Friend WithEvents btnDescending As Button
    Friend WithEvents btnAscending As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents lblMain As Label
End Class
