Public Class Form2


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'declare array of type Double to hold a week's worth of ski school revenue 
        ' Dim WeekRevenue() As Double = {842.55, 340.05, 725.25, 680.43, 1120.38, 2675.99, 2175.64} 'declare two string arrays with instructor names 
        '    Dim WeekdayInstructors() As String = {"Bart", "Ken", "Maria", "Eve", "Claude", "Nikki"}
        '  Dim WeekendInstructors() As String = {"Eve", "Allen", "Juan", "Larry", "Kim", "Al"} 'declare a generic collection list to hold student names input by user 
        '  Dim StudentNames As New Generic.List(Of String)


        ' RichTextBox1.Text = "Days with revenue greater than $500 this week" & vbCrLf & vbCrLf
        ' Dim queryData = From dayrevenue In WeekRevenue
        'Where dayrevenue > 500
        '  For Each scanResult In queryData
        'RichTextBox1.Text = RichTextBox1.Text & scanResult & vbCrLf
        '  Next

        'declare new generic collection of type String to hold names 
        Dim FrenchNames As New Generic.List(Of String)
        'add the name from the NameInput text box to the collection
        FrenchNames.Add(RichTextBox1.Text)
        'clear the new name from the text box and keep cursor there 
        RichTextBox1.Text = ""
        RichTextBox1.Focus(Windows.UI.Xaml.FocusState.Programmatic)
        'determine how many names are in the collection and display a message 
        If FrenchNames.Count >= 2 Then

            OutputTextBox.Text = "There are " & FrenchNames.Count & " names: " & vbCrLf
            'sort names in alphabetical order     FrenchNames.Sort() 
        ElseIf FrenchNames.Count = 1 Then
            OutputTextBox.Text = "There is 1 name:" & vbCrLf
        End If 'then loop through collection, trim trailing spaces, and display 
        For Each Name As String In FrenchNames
        OutputTextBox.Text = OutputTextBox.Text & Name.TrimEnd & vbCrLf Next


    End Sub
End Class