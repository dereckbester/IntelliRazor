@*@Code
    Me.Cursor = Cursors.AppStarting

    'set variables for company information
    Dim borrowersrow As PlannerFilesDataSet.CompanytableRow
    'create today's date variable
    Dim tdate As Date
    'find installed directory of program so that csv file can be saved
    Dim appPath As String = Path.GetDirectoryName(Application.ExecutablePath)
    'create variable for current client status and add value
    Dim emailstatus As String
    'save email count value
    Dim emailcount As Integer
    'save the email template if sending directly from software
    Dim emailtosend As String = ""
    Dim emailtemplate As String = ""
    Dim sDBPath As String
    Dim foundtag As Integer = 0
    Dim tag As String = ""
    Dim i As Integer = 0
    Dim p As Integer
    Dim emailrow As PlannerFilesDataSet.BorrowersRow
    Dim addedrowcount As Integer = 0
   

    'create email account variables
    Dim emailaddress As String = ""
    Dim emailpass As String = ""
    Dim emailport As String = ""
    Dim emailhost As String = ""
    Dim emailssl As String = ""

    Try

        'PREPARE DATAGRID-------------------------------------------------------------------

        GroupBox3.Visible = False
        GroupBox4.Visible = True

        'fill variables
        borrowersrow = Main.PlannerFilesDataSet.Companytable.Rows(0)
        tdate = Today.Date
        emailstatus = cboMailMergeStatus.Text
        'save email account variables
        emailaddress = borrowersrow.Item("setemailaddress").ToString()
        emailpass = borrowersrow.Item("setemailpassword").ToString()
        emailport = borrowersrow.Item("setoutgoingport").ToString()
        emailhost = borrowersrow.Item("setoutgoingserver").ToString()
        If borrowersrow.Item("setemailusessl").ToString() = "Yes" Then
            emailssl = "True"
        Else
            emailssl = "False"
        End If

        Main.BorrowersBindingSource.Filter = Nothing

        'set variables to delete empty rows

        p = Main.DataGridLoad.Rows.Count - 1

        'remove blank rows from the datagrid
        For i = 0 To p
            If i <= p Then
                If Convert.ToString(Main.DataGridLoad.Rows(i).Cells(0).Value) = "" And Convert.ToString(Main.DataGridLoad.Rows(i).Cells(1).Value) = "" And Convert.ToString(Main.DataGridLoad.Rows(i).Cells(2).Value) = "" And Convert.ToString(Main.DataGridLoad.Rows(i).Cells(3).Value) = "" And Convert.ToString(Main.DataGridLoad.Rows(i).Cells(4).Value) = "" And Convert.ToString(Main.DataGridLoad.Rows(i).Cells(5).Value) = "" Then
                    Main.DataGridLoad.Rows.RemoveAt(i)
                    i = i - 1
                    p = Main.DataGridLoad.Rows.Count - 1
                End If
            End If
        Next

        'sort datelastemailed by oldest to be emailed first
        Main.GridMailMerge.Sort(Main.DateLastEmailedDataGridViewTextBoxColumn, ListSortDirection.Ascending)

        'Check the email total borrowers radio buttons
        If rdo50.Checked = True Then
            emailcount = 50
        ElseIf rdo100.Checked = True Then
            emailcount = 100
        ElseIf rdo150.Checked = True Then
            emailcount = 150
        End If

        'set counter for datagridview looping
        Dim loannumbersemailed(emailcount)

        'filter the datagridview by lead status
        Main.BorrowersBindingSource.Filter = String.Format("Status Like '" & emailstatus & "*'" & " AND " & "Bemail Like '%@%'")

        'CREATE CSV FILE AND COUNT LEADS AVAILABLE FOR EMAIL---------------------------

        If Main.GridMailMerge.Rows.Count > 1 Then

            'begin to create the csv file from the current datagridview
            Dim headers = (From header As DataGridViewColumn In Main.GridMailMerge.Columns.Cast(Of DataGridViewColumn)() Select header.HeaderText).ToArray
            Dim rows = From row As DataGridViewRow In Main.GridMailMerge.Rows.Cast(Of DataGridViewRow)() Where Not row.IsNewRow Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
            Using sw As New IO.StreamWriter(appPath & "massmailcsv.txt")
                sw.WriteLine(String.Join(",", headers))

                'for each row in the datagridview up to 150, write the file to a csv file and also update the datelastemailed column with today's date
                For Each r In rows

                    If addedrowcount <= emailcount - 1 Then

                        'make sure they borrower has not been emailed today
                        If Not IsDBNull(Main.GridMailMerge.Item("DateLastEmailedDataGridViewTextBoxColumn", addedrowcount).Value) Then
                            If DateDiff(DateInterval.Day, Main.GridMailMerge.Item("DateLastEmailedDataGridViewTextBoxColumn", addedrowcount).Value, tdate) >= My.Settings.EmailFrequency Then

                                sw.WriteLine(String.Join(",", r))

                                'workaround - datagridview will not update the date and commit changes to database if row is selected
                                If addedrowcount = 0 Then
                                    Main.GridMailMerge.CurrentCell = Main.GridMailMerge.Rows(addedrowcount + 1).Cells(0)
                                End If

                                'save the emailed loan numbers to an array
                                loannumbersemailed(addedrowcount) = Main.GridMailMerge.Item("LoanNumber", addedrowcount).Value

                                addedrowcount = addedrowcount + 1

                            End If
                        Else
                            sw.WriteLine(String.Join(",", r))

                            'workaround - datagridview will not update the date and commit changes to database if row is selected
                            If addedrowcount = 0 Then
                                Main.GridMailMerge.CurrentCell = Main.GridMailMerge.Rows(addedrowcount + 1).Cells(0)
                            End If

                            'save the emailed loan numbers to an array
                            loannumbersemailed(addedrowcount) = Main.GridMailMerge.Item("LoanNumber", addedrowcount).Value

                            addedrowcount = addedrowcount + 1

                        End If

                    Else
                        Exit For
                    End If
                Next

            End Using

        End If

        'PREPARE EMAILS---------------------------------------------------------------

        'make sure there are emails in the datagrid
        If addedrowcount > 1 Then

            'create the email body template and the email body to be sent if not using outlook
            If My.Settings.UseOutlook = "No" And emailaddress <> "" And emailpass <> "" And emailport <> "" And emailhost <> "" And emailssl <> "" Then

                For g As Integer = 0 To addedrowcount - 1

                    'save the current row to be emailed
                    emailrow = Main.PlannerFilesDataSet.Borrowers.FindByLoanNumber(loannumbersemailed(g))

                    'save the email template to a variable so that it can be altered and filled in with client information
                    emailtemplate = txtBody.Text

                    'Add the data to the email
                    For Each s As String In emailtemplate
                        If s <> "[" And foundtag = 0 Then
                            emailtosend += s
                        Else
                            If s = "[" Then
                                foundtag = 1
                            ElseIf s <> "[" And s <> "]" And foundtag = 1 Then
                                tag = tag + s
                            Else
                                tag = tag.Replace("_", "")
                                tag = "B" & tag
                                emailtosend += emailrow.Item(tag)
                                foundtag = 0
                                tag = ""
                            End If
                        End If
                    Next

                    'send the email

                    Dim SmtpServer As New SmtpClient()
                    Dim mail As New MailMessage()

                    SmtpServer.Credentials = New Net.NetworkCredential(emailaddress, emailpass)
                    SmtpServer.Timeout = 20000
                    SmtpServer.Port = emailport
                    SmtpServer.Host = emailhost
                    SmtpServer.EnableSsl = emailssl

                    mail = New MailMessage()
                    mail.From = New MailAddress(emailaddress)
                    mail.To.Add(emailrow.Item("BEmail"))
                    mail.Subject = cboTemplates.Text
                    mail.Body = emailtosend
                    SmtpServer.Send(mail)

                    'clear the email template
                    emailtosend = ""

                    'save the successfully emailed borrower email date to the database
                    emailrow.Item("DateLastEmailed") = tdate

                Next

                'save updated 'datelastemailed' back to database
                Main.BorrowersTableAdapter.Update(Main.PlannerFilesDataSet.Borrowers)

                MsgBox("Your emails have been sent")

                Me.Dispose()
End Code*@