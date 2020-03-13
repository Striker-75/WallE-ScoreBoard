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
        Me.scoreHeader = New System.Windows.Forms.Label()
        Me.teamHeader = New System.Windows.Forms.Label()
        Me.placeHeader = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.fieldOneTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fieldTwoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fieldThreeTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fieldFourTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.globalScoreTable.SuspendLayout()
        Me.fieldOneTable.SuspendLayout()
        Me.fieldTwoTable.SuspendLayout()
        Me.fieldThreeTable.SuspendLayout()
        Me.fieldFourTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'scoreSheetButton
        '
        Me.scoreSheetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreSheetButton.Location = New System.Drawing.Point(713, 455)
        Me.scoreSheetButton.Name = "scoreSheetButton"
        Me.scoreSheetButton.Size = New System.Drawing.Size(533, 47)
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
        Me.teamTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teamTextBox.Location = New System.Drawing.Point(996, 372)
        Me.teamTextBox.Name = "teamTextBox"
        Me.teamTextBox.Size = New System.Drawing.Size(250, 44)
        Me.teamTextBox.TabIndex = 1
        '
        'teamLabel
        '
        Me.teamLabel.AutoSize = True
        Me.teamLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teamLabel.Location = New System.Drawing.Point(706, 376)
        Me.teamLabel.Name = "teamLabel"
        Me.teamLabel.Size = New System.Drawing.Size(275, 37)
        Me.teamLabel.TabIndex = 2
        Me.teamLabel.Text = "Number of Teams"
        '
        'tableTimer
        '
        Me.tableTimer.Interval = 500
        '
        'globalScoreTable
        '
        Me.globalScoreTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.globalScoreTable.ColumnCount = 3
        Me.globalScoreTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.globalScoreTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.globalScoreTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.globalScoreTable.Controls.Add(Me.scoreHeader, 2, 0)
        Me.globalScoreTable.Controls.Add(Me.teamHeader, 1, 0)
        Me.globalScoreTable.Controls.Add(Me.placeHeader, 0, 0)
        Me.globalScoreTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.globalScoreTable.Location = New System.Drawing.Point(0, 0)
        Me.globalScoreTable.Name = "globalScoreTable"
        Me.globalScoreTable.RowCount = 1
        Me.globalScoreTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.globalScoreTable.Size = New System.Drawing.Size(950, 1040)
        Me.globalScoreTable.TabIndex = 3
        '
        'scoreHeader
        '
        Me.scoreHeader.AutoSize = True
        Me.scoreHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scoreHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreHeader.Location = New System.Drawing.Point(635, 0)
        Me.scoreHeader.Name = "scoreHeader"
        Me.scoreHeader.Size = New System.Drawing.Size(312, 1040)
        Me.scoreHeader.TabIndex = 2
        Me.scoreHeader.Text = "Overall Score"
        Me.scoreHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'teamHeader
        '
        Me.teamHeader.AutoSize = True
        Me.teamHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.teamHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teamHeader.Location = New System.Drawing.Point(319, 0)
        Me.teamHeader.Name = "teamHeader"
        Me.teamHeader.Size = New System.Drawing.Size(310, 1040)
        Me.teamHeader.TabIndex = 1
        Me.teamHeader.Text = "Team"
        Me.teamHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'placeHeader
        '
        Me.placeHeader.AutoSize = True
        Me.placeHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.placeHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.placeHeader.Location = New System.Drawing.Point(3, 0)
        Me.placeHeader.Name = "placeHeader"
        Me.placeHeader.Size = New System.Drawing.Size(310, 1040)
        Me.placeHeader.TabIndex = 0
        Me.placeHeader.Text = "Place"
        Me.placeHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'fieldOneTable
        '
        Me.fieldOneTable.ColumnCount = 2
        Me.fieldOneTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.fieldOneTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.fieldOneTable.Controls.Add(Me.Label2, 1, 0)
        Me.fieldOneTable.Controls.Add(Me.Label1, 0, 0)
        Me.fieldOneTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fieldOneTable.Location = New System.Drawing.Point(956, 0)
        Me.fieldOneTable.Name = "fieldOneTable"
        Me.fieldOneTable.RowCount = 4
        Me.fieldOneTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.fieldOneTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.fieldOneTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.fieldOneTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.fieldOneTable.Size = New System.Drawing.Size(470, 515)
        Me.fieldOneTable.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(238, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 128)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "One"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 128)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Field"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fieldTwoTable
        '
        Me.fieldTwoTable.ColumnCount = 2
        Me.fieldTwoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.fieldTwoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.fieldTwoTable.Controls.Add(Me.Label3, 1, 0)
        Me.fieldTwoTable.Controls.Add(Me.Label4, 0, 0)
        Me.fieldTwoTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fieldTwoTable.Location = New System.Drawing.Point(1432, 0)
        Me.fieldTwoTable.Name = "fieldTwoTable"
        Me.fieldTwoTable.RowCount = 4
        Me.fieldTwoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.fieldTwoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.fieldTwoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.fieldTwoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.fieldTwoTable.Size = New System.Drawing.Size(470, 515)
        Me.fieldTwoTable.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(238, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 128)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Two"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(229, 128)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Field"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fieldThreeTable
        '
        Me.fieldThreeTable.ColumnCount = 2
        Me.fieldThreeTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.fieldThreeTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.fieldThreeTable.Controls.Add(Me.Label5, 1, 0)
        Me.fieldThreeTable.Controls.Add(Me.Label6, 0, 0)
        Me.fieldThreeTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fieldThreeTable.Location = New System.Drawing.Point(956, 525)
        Me.fieldThreeTable.Name = "fieldThreeTable"
        Me.fieldThreeTable.RowCount = 4
        Me.fieldThreeTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.fieldThreeTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.fieldThreeTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.fieldThreeTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.fieldThreeTable.Size = New System.Drawing.Size(470, 515)
        Me.fieldThreeTable.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(238, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 128)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Three"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(229, 128)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Field"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fieldFourTable
        '
        Me.fieldFourTable.ColumnCount = 2
        Me.fieldFourTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.fieldFourTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.fieldFourTable.Controls.Add(Me.Label7, 1, 0)
        Me.fieldFourTable.Controls.Add(Me.Label8, 0, 0)
        Me.fieldFourTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fieldFourTable.Location = New System.Drawing.Point(1432, 525)
        Me.fieldFourTable.Name = "fieldFourTable"
        Me.fieldFourTable.RowCount = 4
        Me.fieldFourTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.fieldFourTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.fieldFourTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.fieldFourTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.fieldFourTable.Size = New System.Drawing.Size(470, 515)
        Me.fieldFourTable.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(238, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(229, 128)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Four"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(229, 128)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Field"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.fieldFourTable)
        Me.Controls.Add(Me.fieldThreeTable)
        Me.Controls.Add(Me.fieldTwoTable)
        Me.Controls.Add(Me.teamTextBox)
        Me.Controls.Add(Me.teamLabel)
        Me.Controls.Add(Me.scoreSheetButton)
        Me.Controls.Add(Me.globalScoreTable)
        Me.Controls.Add(Me.fieldOneTable)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IEEE Leader Boards"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.globalScoreTable.ResumeLayout(False)
        Me.globalScoreTable.PerformLayout()
        Me.fieldOneTable.ResumeLayout(False)
        Me.fieldOneTable.PerformLayout()
        Me.fieldTwoTable.ResumeLayout(False)
        Me.fieldTwoTable.PerformLayout()
        Me.fieldThreeTable.ResumeLayout(False)
        Me.fieldThreeTable.PerformLayout()
        Me.fieldFourTable.ResumeLayout(False)
        Me.fieldFourTable.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents scoreSheetButton As Button
    Friend WithEvents teamTimer As Timer
    Friend WithEvents teamTextBox As TextBox
    Friend WithEvents teamLabel As Label
    Friend WithEvents tableTimer As Timer
    Friend WithEvents globalScoreTable As TableLayoutPanel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents fieldOneTable As TableLayoutPanel
    Friend WithEvents placeHeader As Label
    Friend WithEvents scoreHeader As Label
    Friend WithEvents teamHeader As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents fieldTwoTable As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents fieldThreeTable As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents fieldFourTable As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
