<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.scoreSheetButton = New System.Windows.Forms.Button()
        Me.teamTimer = New System.Windows.Forms.Timer(Me.components)
        Me.teamTextBox = New System.Windows.Forms.TextBox()
        Me.teamLabel = New System.Windows.Forms.Label()
        Me.tableTimer = New System.Windows.Forms.Timer(Me.components)
        Me.globalScoreTable = New System.Windows.Forms.TableLayoutPanel()
        Me.SuspendLayout()
        '
        'scoreSheetButton
        '
        Me.scoreSheetButton.Location = New System.Drawing.Point(246, 239)
        Me.scoreSheetButton.Name = "scoreSheetButton"
        Me.scoreSheetButton.Size = New System.Drawing.Size(357, 23)
        Me.scoreSheetButton.TabIndex = 0
        Me.scoreSheetButton.Text = "Open Scoresheet"
        Me.scoreSheetButton.UseVisualStyleBackColor = True
        '
        'teamTimer
        '
        Me.teamTimer.Interval = 15
        '
        'teamTextBox
        '
        Me.teamTextBox.Location = New System.Drawing.Point(340, 190)
        Me.teamTextBox.Name = "teamTextBox"
        Me.teamTextBox.Size = New System.Drawing.Size(263, 20)
        Me.teamTextBox.TabIndex = 1
        '
        'teamLabel
        '
        Me.teamLabel.AutoSize = True
        Me.teamLabel.Location = New System.Drawing.Point(243, 193)
        Me.teamLabel.Name = "teamLabel"
        Me.teamLabel.Size = New System.Drawing.Size(91, 13)
        Me.teamLabel.TabIndex = 2
        Me.teamLabel.Text = "Number of Teams"
        '
        'tableTimer
        '
        Me.tableTimer.Interval = 3000
        '
        'globalScoreTable
        '
        Me.globalScoreTable.ColumnCount = 1
        Me.globalScoreTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.globalScoreTable.Location = New System.Drawing.Point(0, 0)
        Me.globalScoreTable.Name = "globalScoreTable"
        Me.globalScoreTable.RowCount = 1
        Me.globalScoreTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.globalScoreTable.Size = New System.Drawing.Size(390, 462)
        Me.globalScoreTable.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 461)
        Me.Controls.Add(Me.teamLabel)
        Me.Controls.Add(Me.teamTextBox)
        Me.Controls.Add(Me.scoreSheetButton)
        Me.Controls.Add(Me.globalScoreTable)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents scoreSheetButton As Button
    Friend WithEvents teamTimer As Timer
    Friend WithEvents teamTextBox As TextBox
    Friend WithEvents teamLabel As Label
    Friend WithEvents tableTimer As Timer
    Friend WithEvents globalScoreTable As TableLayoutPanel
End Class
