Public Class BTManager

    Private fromIndex As Integer
    Private dragIndex As Integer
    Private dragRect As Rectangle
    Private aasdf As Type


    Private Sub BTManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        Me.MachStatTableAdapter.Fill(Me.MachWipHistDataSet2.MachStat)
        Me.TbredBufferTableAdapter.Fill(Me.MachWipHistDataSet1.TbredBuffer)
        Me.BTQTableAdapter.Fill(Me.TBredDataDataSet5.BT_Que)
        Me.MachIDsTableAdapter.Fill(Me.TBredDataDataSet31.MachIDs)
        'Me.BTQTableAdapter.ClearBeforeFill = True
        BTOrderDataGridView.Sort(BTOrderDataGridView.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
        Me.OrderTBLTableAdapter.Fill(Me.TBredDataDataSet.OrderTBL)
        OrderTBLDataGridView.Sort(OrderTBLDataGridView.Columns(5), System.ComponentModel.ListSortDirection.Descending)

        If Environment.MachineName = "INTERN-WS" Then
            Call managerMode()
        End If
        Call Button4_Click(sender, e)
        Call Timer_Tick(sender, e)
        Button4.Enabled = False

    End Sub
    Private Sub OrderTBLDataGridView_MouseDown_2(sender As Object, e As MouseEventArgs) Handles OrderTBLDataGridView.MouseDown
        Try
            If Me.OrderTBLDataGridView.SelectedRows.Count = 0 Then
                Exit Sub
            End If
            Me.OrderTBLDataGridView.DoDragDrop(Me.OrderTBLDataGridView.SelectedRows(0), DragDropEffects.All)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub OrderTBLDataGridView_RowHeaderMouseClick_2(sender As Object, e As DataGridViewCellMouseEventArgs) Handles OrderTBLDataGridView.RowHeaderMouseClick
        OrderTBLDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub OrderTBLDataGridView_CellClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles OrderTBLDataGridView.CellClick
        OrderTBLDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub



    Private Sub BTOrderDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        OrderTBLDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try


            Dim result As Integer = MessageBox.Show("Clear the Queue?", "Clear All", MessageBoxButtons.YesNo)

            If result = DialogResult.No Then
                Exit Sub
            End If

            Do While TBredDataDataSet5.Tables("BT_Que").Rows.Count <> 0
                Dim dr As DataRow
                dr = TBredDataDataSet5.Tables("BT_Que").Rows(0)
                dr.Delete() 'Delete the row
                BTQTableAdapter.Update(TBredDataDataSet5.BT_Que)
                BTOrderDataGridView.Refresh()
            Loop


        Catch ex As Exception
            MsgBox("Clear Failed")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTOrderDataGridView_DragDrop_1(sender As Object, e As DragEventArgs) Handles BTOrderDataGridView.DragDrop
        Try
            BTOrderDataGridView.Refresh()

            Dim r As DataGridViewRow = e.Data.GetData(GetType(DataGridViewRow))
            Dim machine As String
            machine = "A100"

            Dim duplicate As Boolean = False

            If BTOrderDataGridView.Rows.Count() = 1 Then
                'Dim p As Point = BTOrderDataGridView.PointToClient(New Point(e.X, e.Y))
                ' dragIndex = BTOrderDataGridView.HitTest(p.X, p.Y).RowIndex
                Dim newRow As DataRow = TBredDataDataSet5.Tables("BT_Que").NewRow()
                newRow("Priority") = BTOrderDataGridView.Rows.Count()        'dec
                newRow("CompanyNo") = r.Cells(0).Value              ' dec
                newRow("OrderNo") = r.Cells(1).Value                 'string
                newRow("Cust") = r.Cells(3).Value
                newRow("Diameter") = r.Cells(4).Value

                TBredDataDataSet5.Tables("BT_Que").Rows.Add(newRow)    'Add row

                BTQTableAdapter.Update(Me.TBredDataDataSet5.BT_Que)    'update datatable
                Exit Sub
            Else
                For Each row As DataGridViewRow In BTOrderDataGridView.Rows
                    'MsgBox("looking for copy of" + r.Cells(2).Value)
                    ' MsgBox("checking against" + row.Cells(2).Value)
                    If r.Cells().Count = 6 Then     ' transferring from active orders
                        If Object.Equals(r.Cells(1).Value, row.Cells(2).Value) Then
                            MsgBox("Error: Order " & r.Cells(1).Value & " Already In Queue")
                            duplicate = True
                            Exit Sub
                            Exit For
                        End If
                    Else
                        If Object.Equals(r.Cells(2).Value, row.Cells(2).Value) Then
                            duplicate = True
                            Exit For
                        End If
                    End If
                Next
            End If


            If duplicate = False Then
                Dim inserted = False
                Dim p As Point = BTOrderDataGridView.PointToClient(New Point(e.X, e.Y))
                dragIndex = BTOrderDataGridView.HitTest(p.X, p.Y).RowIndex
                Dim newRow As DataRow = TBredDataDataSet5.Tables("BT_Que").NewRow()
                newRow("CompanyNo") = r.Cells(0).Value
                newRow("OrderNo") = r.Cells(1).Value
                newRow("Cust") = r.Cells(3).Value
                newRow("Diameter") = r.Cells(4).Value

                If dragIndex = -1 Then
                    newRow("Priority") = BTOrderDataGridView.Rows.Count()
                Else
                    For Each row As DataGridViewRow In BTOrderDataGridView.Rows
                        If row.Cells(0).Value = (dragIndex + 1) Then
                            inserted = True
                            Exit For
                        End If
                    Next
                    If inserted = True Then
                        newRow("Priority") = dragIndex + 1
                        For Each row1 As DataGridViewRow In BTOrderDataGridView.Rows()
                            If row1.Cells(0).Value >= dragIndex + 1 Then
                                row1.Cells(0).Value += 1
                            End If
                        Next
                    Else
                        newRow("Priority") = (dragIndex + 1)
                    End If

                End If
                TBredDataDataSet5.Tables("BT_Que").Rows.Add(newRow)    'Add row

                BTQTableAdapter.Update(Me.TBredDataDataSet5.BT_Que)    'update datatable



            Else                                                                'is now working with a duplicate
                Dim p As Point = BTOrderDataGridView.PointToClient(New Point(e.X, e.Y))
                dragIndex = BTOrderDataGridView.HitTest(p.X, p.Y).RowIndex
                If (e.Effect = DragDropEffects.Move) Then
                    Dim dragRow As New DataGridViewRow
                    dragRow = e.Data.GetData(GetType(DataGridViewRow))

                    Dim sourceIndex As Integer
                    sourceIndex = dragRow.Cells(0).Value - 1

                    Dim previous As String
                    previous = Nothing
                    Dim oldPrio As String
                    oldPrio = Nothing

                    'Dim newRow1 As DataRow = TbredDataDataSet5.Tables("BT_Que").NewRow()
                    'newRow1("CompanyNo") = dragRow.Cells(1).Value
                    'newRow1("OrderNo") = dragRow.Cells(2).Value
                    'newRow1("Priority") = dragIndex + 1
                    'newRow1("Machine") = dragRow.Cells(3)

                    For Each row As DataGridViewRow In BTOrderDataGridView.Rows

                        ' MsgBox(row.Cells(2).Value)
                        'MsgBox((previous) + "previous")
                        If row.Index >= dragIndex Then          'check if below insertion index
                            If row.Index < sourceIndex Then     'and above removal index?
                                If previous = row.Cells(2).Value Then       'loop skipped a row?
                                    ' MsgBox("skipped")
                                    Dim previousIndex2 = row.Cells(2).RowIndex - 1
                                    For Each row5 As DataGridViewRow In BTOrderDataGridView.Rows
                                        If row5.Index = previousIndex2 Then     'finds skipped row and increases the prio
                                            row5.Cells(0).Value += 1
                                            BTQTableAdapter.Update(Me.TBredDataDataSet5.BT_Que)
                                            Exit For
                                        End If
                                    Next
                                    Continue For
                                End If
                                previous = row.Cells(2).Value
                                row.Cells(0).Value += 1         'increases by 1

                                Continue For
                            Else
                                If row.Index = sourceIndex Then     'old row is to be removed
                                    If previous = row.Cells(2).Value Then
                                        Dim previousIndex = row.Cells(2).RowIndex - 1

                                        For Each row4 As DataGridViewRow In BTOrderDataGridView.Rows
                                            If row4.Index = previousIndex Then
                                                oldPrio = row4.Cells(2).Value

                                                row4.Cells(0).Value = dragIndex + 1         'NEW THING

                                                Exit For
                                            End If
                                        Next
                                        Continue For
                                    End If

                                    oldPrio = row.Cells(2).Value
                                    row.Cells(0).Value = dragIndex + 1                  'NEW THING

                                    Continue For

                                Else
                                    If row.Index = dragIndex Then
                                        row.Cells(0).Value = row.Cells(0).Value - 1
                                        previous = row.Cells(2).Value 'newprev
                                        Continue For
                                    End If

                                End If
                            End If
                        Else
                            If row.Index < dragIndex Then      'above insertion
                                If row.Index > sourceIndex Then 'below removal
                                    row.Cells(0).Value -= 1     'decreases by 1
                                    previous = row.Cells(2).Value
                                    Continue For
                                Else
                                    If row.Index = sourceIndex Then
                                        oldPrio = row.Cells(2).Value
                                        row.Cells(0).Value = dragIndex + 1 'NEW THING
                                        previous = row.Cells(2).Value       'newprev
                                        '  MsgBox("oldprio")
                                        ' MsgBox(oldPrio)
                                        Continue For

                                    End If
                                End If
                            Else
                                If row.Index = dragIndex Then
                                    row.Cells(0).Value += 1
                                    previous = row.Cells(2).Value       'newprev
                                    Continue For
                                End If
                            End If

                        End If
                    Next
                    ' If oldPrio <> Nothing Then

                    '   For Each row3 As DataRow In TbredDataDataSet5.Tables("BT_Que").Rows
                    ' Dim dr As DataRow


                    'If row3.Item(2) = oldPrio Then

                    '     MsgBox("match")
                    '    MsgBox(row3.Item(3))
                    ' row3.Delete()                 'change
                    ' MsgBox(row3.Item(2))
                    'TbredDataDataSet5.Tables("BT_Que").Rows.Add(newRow1)    '         CHANGE Add row
                    ' BTQTableAdapter.Update(Me.TbredDataDataSet5.BT_Que)
                    'Exit For
                    ' TbredDataDataSet5.Tables("BT_Que").Rows(row.Index).Delete()
                    'End If
                    ' Next
                    'End If
                    ' TbredDataDataSet5.Tables("BT_Que").Rows.Add(newRow1)    'Add row
                    BTQTableAdapter.Update(Me.TBredDataDataSet5.BT_Que)


                End If


            End If



            BTOrderDataGridView.Sort(BTOrderDataGridView.Columns(2), System.ComponentModel.ListSortDirection.Ascending)

            BTQTableAdapter.Update(Me.TBredDataDataSet5.BT_Que)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTOrderDataGridView_DragEnter_1(sender As Object, e As DragEventArgs) Handles BTOrderDataGridView.DragEnter
        Try
            e.Effect = DragDropEffects.Copy

            e.Effect = DragDropEffects.Move


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTOrderDataGridView_MouseDown(sender As Object, e As MouseEventArgs) Handles BTOrderDataGridView.MouseDown
        fromIndex = BTOrderDataGridView.HitTest(e.X, e.Y).RowIndex
        If fromIndex > -1 Then
            Dim dragSize As Size = SystemInformation.DragSize
            dragRect = New Rectangle(New Point(e.X - (dragSize.Width / 2), _
                                  e.Y - (dragSize.Height / 2)), _
                                     dragSize)
        Else
            dragRect = Rectangle.Empty
        End If
    End Sub

    Private Sub BTOrderDataGridView_MouseMove(sender As Object, e As MouseEventArgs) Handles BTOrderDataGridView.MouseMove
        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
            If (dragRect <> Rectangle.Empty _
            AndAlso Not dragRect.Contains(e.X, e.Y)) Then

                BTOrderDataGridView.DoDragDrop(BTOrderDataGridView.Rows(fromIndex), _
                                         DragDropEffects.Move)
            End If
        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        BTQTableAdapter.Update(Me.TBredDataDataSet5.BT_Que)
        BTOrderDataGridView.Refresh()
    End Sub


    Private Sub BTOrderDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles BTOrderDataGridView.DataError
        MessageBox.Show("Error happened " _
       & e.Context.ToString())

        If (e.Context = DataGridViewDataErrorContexts.Commit) _
            Then
            MessageBox.Show("Commit error")
        End If
        If (e.Context = DataGridViewDataErrorContexts _
            .CurrentCellChange) Then
            MessageBox.Show("Cell change")
        End If
        If (e.Context = DataGridViewDataErrorContexts.Parsing) _
            Then
            MessageBox.Show("parsing error")
        End If
        If (e.Context = _
            DataGridViewDataErrorContexts.LeaveControl) Then
            MessageBox.Show("leave control error")
        End If

        If (TypeOf (e.Exception) Is ConstraintException) Then
            Dim view As DataGridView = CType(sender, DataGridView)
            view.Rows(e.RowIndex).ErrorText = "an error"
            view.Rows(e.RowIndex).Cells(e.ColumnIndex) _
                .ErrorText = "an error"

            e.ThrowException = False
        End If

    End Sub

    Private Sub BTOrderDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BTOrderDataGridView.CellContentClick 'CellLeave  'CellValueChanged  '.CellClick

        If BTOrderDataGridView.AllowDrop() = False Then Exit Sub

        For Each row As DataGridViewRow In BTOrderDataGridView.Rows

            Dim rowindex = row.Index
            Dim currentrow = BTOrderDataGridView.CurrentRow.Index

            If row.Cells(7).Value Is DBNull.Value Then
                'Exit Sub ' Else auto load cells
            Else
                If row.Cells(7).Selected = True And row.Cells(7).IsInEditMode = True Then
                    If row.Cells(7).Value = "BS1  " And rowindex = currentrow Then
                        If row.Cells(8).Value Is DBNull.Value And row.Cells(9).Value Is DBNull.Value Then
                            GoTo AddDefault
                        End If
                        If row.Cells(7).Selected = True And row.Cells(7).IsInEditMode = True And row.Cells(8).Value = "BT1  " Or row.Cells(9).Value = "BS2  " Then
                            Dim button As DialogResult =
                       MessageBox.Show("Change Cell Values to Default?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                            If button = Windows.Forms.DialogResult.Cancel Then
                                Exit Sub
                            End If
AddDefault:                 row.Cells(8).Value = "BT1 "
                            row.Cells(9).Value = "BS2 "
                            If row.Cells(6).Value > "2.9000" Then
                                row.Cells(10).Value = "TG4 "
                                row.Cells(11).Value = "TG5 "
                            ElseIf row.Cells(6).Value < "2.8900" Then
                                row.Cells(10).Value = "TG1 "
                                row.Cells(11).Value = "TG2 "
                            End If

                            ' BTQTableAdapter.Update(Me.TBredDataDataSet5.BT_Que)
                            ' BTOrderDataGridView.Refresh()
                        End If
                    End If
                End If
            End If
        Next

        BTQTableAdapter.Update(Me.TBredDataDataSet5.BT_Que)
        'BTOrderDataGridView.Refresh()

    End Sub

    Private Sub OrderTBLDataGridView_MouseDown(sender As Object, e As MouseEventArgs)
        Try
            If Me.OrderTBLDataGridView.SelectedRows.Count = 0 Then
                Exit Sub
            End If
            Me.OrderTBLDataGridView.DoDragDrop(Me.OrderTBLDataGridView.SelectedRows(0), DragDropEffects.All)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub OrderTBLDataGridView_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        OrderTBLDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub


    Private Sub OrderTBLDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        OrderTBLDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Try
            Me.TbredBufferTableAdapter.Fill(Me.MachWipHistDataSet1.TbredBuffer)
            Me.MachStatTableAdapter.Fill(Me.MachWipHistDataSet2.MachStat)
            MachStatDataGridView.Update()
            MachStatDataGridView.Refresh()
            BTOrderDataGridView.Sort(BTOrderDataGridView.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
           
        Catch ex As Exception
            Exit Sub
            'MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim message, title, defaultValue As String
        Dim myValue As Object
        message = "Enter Manager's Key"
        title = "Authorization To Edit"
        defaultValue = "enter password"
        myValue = InputBox(message, title, defaultValue)
        If myValue = My.Settings.btpassword Then

            Call managerMode()
        Else
            MsgBox("Invalid Credentials")
        End If
    End Sub

    Private Sub managerMode()

        Label6.Visible = True
        Button1.Visible = True
        BTOrderDataGridView.AllowDrop() = True
        BTOrderDataGridView.Columns(0).ReadOnly = False
        BTOrderDataGridView.Columns(1).ReadOnly = False
        BTOrderDataGridView.Columns(2).ReadOnly = False
        BTOrderDataGridView.Columns(3).ReadOnly = False
        BTOrderDataGridView.Columns(4).ReadOnly = False
        BTOrderDataGridView.Columns(5).ReadOnly = False
        BTOrderDataGridView.Columns(6).ReadOnly = False
        BTOrderDataGridView.Columns(7).ReadOnly = False
        BTOrderDataGridView.Columns(8).ReadOnly = False
        BTOrderDataGridView.Columns(9).ReadOnly = False
        BTOrderDataGridView.Columns(10).ReadOnly = False
        BTOrderDataGridView.Columns(11).ReadOnly = False
        Button4.Enabled = True
        BTOrderDataGridView.ReadOnly = False
        Timer.Enabled = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim found As Boolean
        found = False
        OrderTBLDataGridView.ClearSelection()
        For Each row As DataGridViewRow In OrderTBLDataGridView.Rows
            If row.Cells(1).Value = TextBox1.Text Then
                found = True
                row.Selected = True
                OrderTBLDataGridView.FirstDisplayedScrollingRowIndex = OrderTBLDataGridView.SelectedRows(0).Index
           
            End If
        Next

        If found = False Then
            MsgBox("Order Not Found!")
        Else
            TextBox1.Clear()
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Button3_Click(sender, e)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Update and Save changes
        BTOrderDataGridView.ClearSelection()

        For Each row As DataGridViewRow In BTOrderDataGridView.Rows
            If row.Cells(4).Value <> Nothing Then
                row.Cells(0).Value = row.Index + 1
            End If
        Next

        BTOrderDataGridView.Sort(BTOrderDataGridView.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
        BTQTableAdapter.Update(Me.TBredDataDataSet5.BT_Que)

    End Sub

    Private Sub BTOrderDataGridView_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles BTOrderDataGridView.UserDeletedRow

        BTOrderDataGridView.ClearSelection()

        For Each row As DataGridViewRow In BTOrderDataGridView.Rows
            If row.Cells(4).Value <> Nothing Then
                row.Cells(0).Value = row.Index + 1
            End If
        Next
        BTOrderDataGridView.ClearSelection()
        BTOrderDataGridView.Sort(BTOrderDataGridView.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
        BTQTableAdapter.Update(Me.TBredDataDataSet5.BT_Que)
        BTOrderDataGridView.Refresh()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Label6.Visible = False
        Button1.Visible = False
        BTOrderDataGridView.AllowDrop() = False
        BTOrderDataGridView.Columns(0).ReadOnly = True
        BTOrderDataGridView.Columns(1).ReadOnly = True
        BTOrderDataGridView.Columns(2).ReadOnly = True
        BTOrderDataGridView.Columns(3).ReadOnly = True
        BTOrderDataGridView.Columns(4).ReadOnly = True
        BTOrderDataGridView.Columns(5).ReadOnly = True
        BTOrderDataGridView.Columns(6).ReadOnly = True
        BTOrderDataGridView.Columns(7).ReadOnly = True
        BTOrderDataGridView.Columns(8).ReadOnly = True
        BTOrderDataGridView.Columns(9).ReadOnly = True
        BTOrderDataGridView.Columns(10).ReadOnly = True
        BTOrderDataGridView.Columns(11).ReadOnly = True
        Button4.Enabled = False
        BTOrderDataGridView.ReadOnly = True
        Timer.Enabled = True

    End Sub

    Private Sub BTOrderDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles BTOrderDataGridView.CellContentClick

    End Sub
End Class