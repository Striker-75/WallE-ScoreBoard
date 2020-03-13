Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop

Public Class Form1

    'Creating a structure for the team scores
    Private Structure teamData
        Public teamName As String
        Public overallScore As Integer
    End Structure

    Dim teamNumberStr As String
    Dim teamNumberint As Integer

    'Keep the application object and the workbook object global, so you can  
    'retrieve the data in multiple methods
    Dim objApp As Excel.Application
    Dim objBook As Excel._Workbook

    'What happens when the form starts
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set screen size
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        'Start the Timer
        teamTimer.Start()
        'Hide the tables
        globalScoreTable.Visible = False
        fieldOneTable.Visible = False
        fieldTwoTable.Visible = False
        fieldThreeTable.Visible = False
        fieldFourTable.Visible = False
    End Sub

    'Open the file
    Private Sub scoreSheetButton_Click(ByVal sender As System.Object,
   ByVal e As System.EventArgs) Handles scoreSheetButton.Click
        OpenFileDialog1.Title = "Please Select the score sheet"

        OpenFileDialog1.InitialDirectory = "C:"

        OpenFileDialog1.ShowDialog()
    End Sub

    'When the file is selected
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim objBooks As Excel.Workbooks
        Dim objSheets As Excel.Sheets
        Dim objScoreSheet As Excel._Worksheet
        Dim objFieldOneSheet As Excel._Worksheet
        Dim objFieldTwoSheet As Excel._Worksheet
        Dim objFieldThreeSheet As Excel._Worksheet
        Dim objFieldFourSheet As Excel._Worksheet
        Dim globalScoreRange As Excel.Range
        Dim fieldOneRange As Excel.Range
        Dim fieldTwoRange As Excel.Range
        Dim fieldThreeRange As Excel.Range
        Dim fieldFourRange As Excel.Range

        'Open and start a saved worksheet
        objApp = New Excel.Application()
        objBooks = objApp.Workbooks
        objBook = objBooks.Open(OpenFileDialog1.FileName.ToString())
        objSheets = objBook.Worksheets
        objScoreSheet = objSheets(1)
        objFieldOneSheet = objSheets(1)
        objFieldTwoSheet = objSheets(1)
        objFieldThreeSheet = objSheets(1)
        objFieldFourSheet = objSheets(1)


        'Get the range where the starting cell has the address
        'm_sStartingCell and its dimensions are m_iNumRows x m_iNumCols.
        globalScoreRange = objScoreSheet.Range("A1", Reflection.Missing.Value)
        fieldOneRange = objFieldOneSheet.Range("A1", Reflection.Missing.Value)
        fieldTwoRange = objFieldTwoSheet.Range("A1", Reflection.Missing.Value)
        fieldThreeRange = objFieldThreeSheet.Range("A1", Reflection.Missing.Value)
        fieldFourRange = objFieldFourSheet.Range("A1", Reflection.Missing.Value)

        'Return control of Excel to the user.
        objApp.Visible = True
        objApp.UserControl = True

        'Clean up a little.
        globalScoreRange = Nothing
        fieldOneRange = Nothing
        fieldTwoRange = Nothing
        fieldThreeRange = Nothing
        fieldFourRange = Nothing
        objScoreSheet = Nothing
        objFieldOneSheet = Nothing
        objFieldTwoSheet = Nothing
        objFieldThreeSheet = Nothing
        objFieldFourSheet = Nothing
        objSheets = Nothing
        objBooks = Nothing

        'Hide buttons and textbox
        scoreSheetButton.Visible = False
        scoreSheetButton.Enabled = False
        teamTextBox.Visible = False
        teamTextBox.Enabled = False
        teamLabel.Visible = False
        teamLabel.Enabled = False

        'set the number of teams
        teamNumberStr = teamTextBox.Text
        teamNumberint = CInt(teamTextBox.Text)

        'Stop one timer and start the other
        teamTimer.Stop()
        tableTimer.Start()

        'Create a table to hold the team data
        globalScoreTable.BackColor = Color.LightBlue
        globalScoreTable.RowCount = 0
        globalScoreTable.RowStyles.Clear()
        For row As Integer = 0 To teamNumberint - 1
            globalScoreTable.RowStyles.Add(New RowStyle(SizeType.Percent, (100 / teamNumberint)))
            globalScoreTable.RowCount += 1
        Next
        Controls.Add(globalScoreTable)

        'Set background colors of the other tables
        fieldOneTable.BackColor = Color.LightBlue
        fieldTwoTable.BackColor = Color.LightBlue
        fieldThreeTable.BackColor = Color.LightBlue
        fieldFourTable.BackColor = Color.LightBlue

        'Show the tables
        globalScoreTable.Visible = True
        fieldOneTable.Visible = True
        fieldTwoTable.Visible = True
        fieldThreeTable.Visible = True
        fieldFourTable.Visible = True

        Me.BackColor = Color.Black

    End Sub
    'Restricts textbox to numbers only
    Private Sub teamTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles teamTextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub
    Private Sub teamTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles teamTextBox.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        teamTextBox.Text = digitsOnly.Replace(teamTextBox.Text, "")
    End Sub

    'Checks to make sure that there is a value in the text box before allowing the button press
    Private Sub teamTimer_Tick(sender As Object, e As EventArgs) Handles teamTimer.Tick
        If String.IsNullOrEmpty(teamTextBox.Text) Then
            scoreSheetButton.Enabled = False
        Else
            scoreSheetButton.Enabled = True
        End If
    End Sub

    'Check and read in data from excel every 5 seconds
    Private Sub tableTimer_Tick(sender As Object, e As EventArgs) Handles tableTimer.Tick
        Dim objSheets As Excel.Sheets
        Dim objScoreSheet As Excel._Worksheet
        Dim objFieldOneSheet As Excel._Worksheet
        Dim objFieldTwoSheet As Excel._Worksheet
        Dim objFieldThreeSheet As Excel._Worksheet
        Dim objFieldFourSheet As Excel._Worksheet
        Dim globalScoreRange As Excel.Range
        Dim fieldOneRange As Excel.Range
        Dim fieldTwoRange As Excel.Range
        Dim fieldThreeRange As Excel.Range
        Dim fieldFourRange As Excel.Range

        'Get a reference to the first sheet of the workbook.
        objSheets = objBook.Worksheets
        objScoreSheet = objSheets(1)
        objFieldOneSheet = objSheets(1)
        objFieldTwoSheet = objSheets(1)
        objFieldThreeSheet = objSheets(1)
        objFieldFourSheet = objSheets(1)

        'Use the number of teams to set the range
        Dim endpoint As String = "H" + teamNumberStr

        'Get a range of data.
        globalScoreRange = objScoreSheet.Range("A2", endpoint)
        fieldOneRange = objFieldOneSheet.Range("J2", "J4")
        fieldTwoRange = objFieldTwoSheet.Range("L2", "L4")
        fieldThreeRange = objFieldThreeSheet.Range("N2", "N4")
        fieldFourRange = objFieldFourSheet.Range("P2", "P4")

        'Retrieve the data from the range.
        Dim teamResults(,) As Object
        Dim fieldOne(,) As Object
        Dim fieldTwo(,) As Object
        Dim fieldThree(,) As Object
        Dim fieldFour(,) As Object
        teamResults = globalScoreRange.Value
        fieldOne = fieldOneRange.Value
        fieldTwo = fieldTwoRange.Value
        fieldThree = fieldThreeRange.Value
        fieldFour = fieldFourRange.Value

        'Create arrays for the fields
        Dim fieldOneTeams(3) As String
        Dim fieldTwoTeams(3) As String
        Dim fieldThreeTeams(3) As String
        Dim fieldFourTeams(3) As String
        Dim teamCounter As Integer

        'Fill up the the arrays of teams
        For teamCounter = 1 To 3
            'Set field one
            If fieldOne(teamCounter, 1) IsNot Nothing Then
                fieldOneTeams(teamCounter - 1) = fieldOne(teamCounter, 1)
            Else
                fieldOneTeams(teamCounter - 1) = " "
            End If
            'Set field two
            If fieldTwo(teamCounter, 1) IsNot Nothing Then
                fieldTwoTeams(teamCounter - 1) = fieldTwo(teamCounter, 1)
            Else
                fieldTwoTeams(teamCounter - 1) = " "
            End If
            'Set field three
            If fieldThree(teamCounter, 1) IsNot Nothing Then
                fieldThreeTeams(teamCounter - 1) = fieldThree(teamCounter, 1)
            Else
                fieldThreeTeams(teamCounter - 1) = " "
            End If
            'Set field four
            If fieldFour(teamCounter, 1) IsNot Nothing Then
                fieldFourTeams(teamCounter - 1) = fieldFour(teamCounter, 1)
            Else
                fieldFourTeams(teamCounter - 1) = " "
            End If
        Next

        'Determine the dimensions of the array.
        Dim iRows As Long
        iRows = teamResults.GetUpperBound(0)
        Dim rowCounter As Long

        'Save the data into the struts
        Dim teams(teamNumberint) As teamData
        rowCounter = iRows
        teamCounter = 0

        'Get the team data
        For rowCounter = 1 To iRows
            'Set Team Name
            If teamResults(rowCounter, 1) IsNot Nothing Then
                teams(teamCounter).teamName = teamResults(rowCounter, 1).ToString()
            Else
                teams(teamCounter).teamName = ""
            End If
            'Set overall score
            If teamResults(rowCounter, 8) IsNot Nothing Then
                teams(teamCounter).overallScore = teamResults(rowCounter, 8)
            Else
                teams(teamCounter).overallScore = 0
            End If
            teamCounter = teamCounter + 1
        Next

        'Sorting the array by top scores
        Dim First As Integer, Last As Long
        Dim i As Long, j As Long
        Dim Temp As teamData

        First = LBound(teams)
        Last = UBound(teams)
        For i = First To Last - 1
            For j = i + 1 To Last
                If teams(i).overallScore < teams(j).overallScore Then
                    Temp = teams(j)
                    teams(j) = teams(i)
                    teams(i) = Temp
                End If
            Next j
        Next i

        'Populate The tables
        updateScores(teams, globalScoreTable)
        updateFields(fieldOneTeams, fieldOneTable)
        updateFields(fieldTwoTeams, fieldTwoTable)
        updateFields(fieldThreeTeams, fieldThreeTable)
        updateFields(fieldFourTeams, fieldFourTable)

        'Clean up a little.
        globalScoreRange = Nothing
        fieldOneRange = Nothing
        fieldTwoRange = Nothing
        fieldThreeRange = Nothing
        fieldFourRange = Nothing
        objScoreSheet = Nothing
        objFieldOneSheet = Nothing
        objFieldTwoSheet = Nothing
        objFieldThreeSheet = Nothing
        objFieldFourSheet = Nothing
        objSheets = Nothing
    End Sub

    'Generating the table
    Private Sub updateScores(teams() As teamData, table As TableLayoutPanel)

        'Get number of rows and cols of the table
        Dim rows As Integer
        rows = table.RowCount

        'Put data in the rows
        Dim row As Integer
        For row = 1 To rows
            'Set placings
            Dim placing As Control = table.GetControlFromPosition(0, row)
            Dim placingLabel As Label = placing
            If placingLabel IsNot Nothing Then
                placing.Text = row
            Else
                placingLabel = New Label()
                placingLabel.TextAlign = ContentAlignment.MiddleCenter
                placingLabel.Dock = DockStyle.Fill
                table.Controls.Add(placingLabel, 0, row)
                placingLabel.Text = row
            End If

            'Set team names
            Dim teamName As Control = table.GetControlFromPosition(1, row)
            Dim teamLabel As Label = teamName
            If teamLabel IsNot Nothing Then
                teamLabel.Text = teams(row - 1).teamName
            Else
                teamLabel = New Label()
                teamLabel.TextAlign = ContentAlignment.MiddleCenter
                teamLabel.Dock = DockStyle.Fill
                table.Controls.Add(teamLabel, 1, row)
                teamLabel.Text = teams(row - 1).teamName
            End If

            'Set score
            Dim score As Control = table.GetControlFromPosition(2, row)
            Dim scoreLabel As Label = score
            If scoreLabel IsNot Nothing Then
                scoreLabel.Text = teams(row - 1).overallScore
            Else
                scoreLabel = New Label()
                scoreLabel.TextAlign = ContentAlignment.MiddleCenter
                scoreLabel.Dock = DockStyle.Fill
                table.Controls.Add(scoreLabel, 2, row)
                scoreLabel.Text = teams(row - 1).overallScore
            End If
        Next

    End Sub

    'Process to fill in the up next tables
    Private Sub updateFields(teams() As String, table As TableLayoutPanel)

        'Get number of rows and cols of the table
        Dim rows As Integer
        rows = table.RowCount

        'Put data in the rows
        Dim row As Integer
        For row = 1 To rows - 1
            'Set placings
            Dim placing As Control = table.GetControlFromPosition(0, row)
            Dim placingLabel As Label = placing
            If placingLabel IsNot Nothing Then
                placing.Text = row
            Else
                placingLabel = New Label()
                placingLabel.TextAlign = ContentAlignment.MiddleCenter
                placingLabel.Dock = DockStyle.Fill
                table.Controls.Add(placingLabel, 0, row)
                placingLabel.Text = row
            End If

            'Set team names
            Dim teamName As Control = table.GetControlFromPosition(1, row)
            Dim teamLabel As Label = teamName
            If teamLabel IsNot Nothing Then
                teamLabel.Text = teams(row - 1)
            Else
                teamLabel = New Label()
                teamLabel.TextAlign = ContentAlignment.MiddleCenter
                teamLabel.Dock = DockStyle.Fill
                table.Controls.Add(teamLabel, 1, row)
                teamLabel.Text = teams(row - 1)
            End If
        Next
    End Sub
End Class




