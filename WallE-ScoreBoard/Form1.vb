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
        'Start the Timer
        teamTimer.Start()
    End Sub

    Private Sub scoreSheetButton_Click(ByVal sender As System.Object,
   ByVal e As System.EventArgs) Handles scoreSheetButton.Click
        Dim objBooks As Excel.Workbooks
        Dim objSheets As Excel.Sheets
        Dim objSheet As Excel._Worksheet
        Dim range As Excel.Range

        'Open and start a saved worksheet
        objApp = New Excel.Application()
        objBooks = objApp.Workbooks
        objBook = objBooks.Open("C:\Users\natem\Documents\College Stuff\Senior Year\Systems III\WallE-ScoreBoard\ScoreBoardBeta.xlsx")
        objSheets = objBook.Worksheets
        objSheet = objSheets(1)


        'Get the range where the starting cell has the address
        'm_sStartingCell and its dimensions are m_iNumRows x m_iNumCols.
        range = objSheet.Range("A1", Reflection.Missing.Value)

        'Return control of Excel to the user.
        objApp.Visible = True
        objApp.UserControl = True

        'Clean up a little.
        range = Nothing
        objSheet = Nothing
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
        globalScoreTable.ColumnCount = 3
        globalScoreTable.RowCount = teamNumberint
        globalScoreTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F))
        globalScoreTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F))
        globalScoreTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F))
        For row As Integer = 0 To teamNumberint
            globalScoreTable.RowStyles.Add(New RowStyle(SizeType.Percent, (100 / teamNumberint)))
        Next

        Controls.Add(globalScoreTable)
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
        Dim objSheet As Excel._Worksheet
        Dim range As Excel.Range

        'Get a reference to the first sheet of the workbook.
        objSheets = objBook.Worksheets
        objSheet = objSheets(1)

        'Use the number of teams to set the range
        Dim endpoint As String = "H" + teamNumberStr

        'Get a range of data.
        range = objSheet.Range("A2", endpoint)

        'Retrieve the data from the range.
        Dim teamResults(,) As Object
        teamResults = range.Value

        'Determine the dimensions of the array.
        Dim iRows As Long
        iRows = teamResults.GetUpperBound(0)
        Dim rowCounter As Long

        'Save the data into the struts
        Dim teams(teamNumberint) As teamData
        Dim teamCounter As Long
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

        'Populate The table
        populateTable(teams, globalScoreTable)

        'Clean up a little.
        range = Nothing
        objSheet = Nothing
        objSheets = Nothing
    End Sub

    'Generating the table
    Private Sub populateTable(teams() As teamData, table As TableLayoutPanel)

        'Get number of rows and cols of the table
        Dim rows As Integer
        rows = table.RowCount

        'Put data in the rows
        Dim row As Integer
        For row = 0 To rows - 1
            'Set placings
            Dim placing As Control = table.GetControlFromPosition(0, row)
            Dim placingLabel As Label = placing
            If placingLabel IsNot Nothing Then
                placing.Text = row + 1
            Else
                placingLabel = New Label()
                table.Controls.Add(placingLabel, 0, row)
                placingLabel.Text = row + 1
            End If

            'Set team names
            Dim teamName As Control = table.GetControlFromPosition(1, row)
            Dim teamLabel As Label = teamName
            If teamLabel IsNot Nothing Then
                teamLabel.Text = teams(row).teamName
            Else
                teamLabel = New Label()
                table.Controls.Add(teamLabel, 1, row)
                teamLabel.Text = teams(row).teamName
            End If

            'Set score
            Dim score As Control = table.GetControlFromPosition(2, row)
            Dim scoreLabel As Label = score
            If scoreLabel IsNot Nothing Then
                scoreLabel.Text = teams(row).overallScore
            Else
                scoreLabel = New Label()
                table.Controls.Add(scoreLabel, 2, row)
                scoreLabel.Text = teams(row).overallScore
            End If
        Next

    End Sub
End Class




