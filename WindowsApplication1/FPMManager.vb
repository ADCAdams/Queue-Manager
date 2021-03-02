Public Class FPMManager

    Private fromIndex As Integer
    Private dragIndex As Integer
    Private dragRect As Rectangle
    Private aasdf As Type
    Private pass As String

    Private Sub OrderTBLBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.OrderTBLBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FpmtBredDataDataSet)

    End Sub

    Private Sub FPMManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MachIDs_FPMTableAdapter.Fill(Me.FpmtBredDataDataSet.MachIDs_FPM)
        Me.WindowState = FormWindowState.Maximized
        Me.TbredBufferTableAdapter.Fill(Me.MachWipHistDataSet1.TbredBuffer)
        Me.MachStat_FPMTableAdapter.Fill(Me.FPMMachWipHistDataSet.MachStat_FPM)
        Me.FPM_QueTableAdapter.Fill(Me.FpmtBredDataDataSet.FPM_Que)
        FPM_QueDataGridView.Sort(FPM_QueDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)         'sorts for priority
        Me.OrderTBLTableAdapter.Fill(Me.FpmtBredDataDataSet.OrderTBL)
        OrderTBLDataGridView.Sort(OrderTBLDataGridView.Columns(6), System.ComponentModel.ListSortDirection.Descending)

        If Environment.MachineName = "INTERN-WS" Then
            Call managerMode()
        End If

        Try
            Me.OrderTBLTableAdapter1.FillBy2(Me.IHCTBredDataDataSet.OrderTBL)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Call Button4_Click(sender, e)       'refresh button 
        Call Button5_Click(sender, e)
        Call Timer_Tick(sender, e)
        Button4.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click           'Clear Queue
        Try

            Dim result As Integer = MessageBox.Show("Clear the Queue?", "Clear All", MessageBoxButtons.YesNo)

            If result = DialogResult.No Then
                Exit Sub
            End If

            Do While FpmtBredDataDataSet.Tables("FPM_Que").Rows.Count <> 0
                Dim dr As DataRow
                dr = FpmtBredDataDataSet.Tables("FPM_Que").Rows(0)
                dr.Delete() 'Delete the row
                FPM_QueTableAdapter.Update(Me.FpmtBredDataDataSet.FPM_Que)
                FPM_QueDataGridView.Refresh()
            Loop

        Catch ex As Exception
            MsgBox("Clear Failed")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub OrderTBLDataGridView_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles OrderTBLDataGridView.CellClick

        OrderTBLDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect    'selects the row

    End Sub

    Private Sub OrderTBLDataGridView_MouseDown_1(sender As Object, e As MouseEventArgs) Handles OrderTBLDataGridView.MouseDown
        Try
            If Me.OrderTBLDataGridView.SelectedRows.Count = 0 Then
                Exit Sub
            End If
            Me.OrderTBLDataGridView.DoDragDrop(Me.OrderTBLDataGridView.SelectedRows(0), DragDropEffects.All)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub OrderTBLDataGridView_RowHeaderMouseClick_1(sender As Object, e As DataGridViewCellMouseEventArgs) Handles OrderTBLDataGridView.RowHeaderMouseClick

        OrderTBLDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub FPM_QueDataGridView_DragDrop_1(sender As Object, e As DragEventArgs) Handles FPM_QueDataGridView.DragDrop
        Try
            FPM_QueDataGridView.Refresh()

            Dim r As DataGridViewRow = e.Data.GetData(GetType(DataGridViewRow))                'r is the row that has been dragged into/reordered in the queue
            
            Dim duplicate As Boolean = False

            If FPM_QueDataGridView.Rows.Count() = 1 Then                                                             'if there are no rows already
                'Dim p As Point = FPM_QueDataGridView.PointToClient(New Point(e.X, e.Y))
                ' dragIndex = FPM_QueDataGridView.HitTest(p.X, p.Y).RowIndex
                Dim newRow As DataRow = FpmtBredDataDataSet.Tables("FPM_Que").NewRow()                              'simply adds one row
                newRow("Priority") = FPM_QueDataGridView.Rows.Count()        'dec
                newRow("CompanyNo") = r.Cells(0).Value              ' dec
                newRow("OrderNo") = r.Cells(1).Value                 'string                                        'Assigning values to columns in newRow
                newRow("Cust") = r.Cells(3).Value
                newRow("Diameter") = r.Cells(5).Value

                FpmtBredDataDataSet.Tables("FPM_Que").Rows.Add(newRow)    'Add row

                FPM_QueTableAdapter.Update(Me.FpmtBredDataDataSet.FPM_Que)    'update datatable
                Exit Sub
            Else                                                                                                    '(if there are rows presently)
                For Each row As DataGridViewRow In FPM_QueDataGridView.Rows
                    'MsgBox("looking for copy of" + r.Cells(2).Value)
                    ' MsgBox("checking against" + row.Cells(2).Value)
                    If r.Cells().Count = 7 Then                                                          'checks if r is from the OrderTBL or the QueTBL
                        If Object.Equals(r.Cells(1).Value, row.Cells(2).Value) Then                     'checks for duplicate from the OrderTBL
                            MsgBox("Error: Order " & r.Cells(1).Value & " Already In Queue")
                            duplicate = True
                            Exit Sub
                            Exit For
                        End If
                    Else
                        If Object.Equals(r.Cells(2).Value, row.Cells(2).Value) Then                     'checks against queTBL to see if just rearranging the queue
                            duplicate = True
                            Exit For
                        End If
                    End If
                Next
            End If


            If duplicate = False Then                                                                   'new queue order
                Dim inserted = False
                Dim p As Point = FPM_QueDataGridView.PointToClient(New Point(e.X, e.Y))                 'p is a the point where the mouse is
                dragIndex = FPM_QueDataGridView.HitTest(p.X, p.Y).RowIndex                                  'Drag index is the INDEX the row has been dragged TO (index starts at 0)
                Dim newRow As DataRow = FpmtBredDataDataSet.Tables("FPM_Que").NewRow()                  'prepares to create a new row
                newRow("CompanyNo") = r.Cells(0).Value                                                  'assigns new values
                newRow("OrderNo") = r.Cells(1).Value
                newRow("Cust") = r.Cells(3).Value
                newRow("Diameter") = r.Cells(5).Value

                If dragIndex = -1 Then                                                                  '-1 = the gray area ,not a specific spot
                    newRow("Priority") = FPM_QueDataGridView.Rows.Count()                               'drops it at the bottom, by assigning prio = the total rows
                Else                                                                            'dropped in a real row spot
                    For Each row As DataGridViewRow In FPM_QueDataGridView.Rows                     'checks if the index has been inserted into the queue, rather than dropped at the bottom
                        If row.Cells(0).Value = (dragIndex + 1) Then
                            inserted = True
                            Exit For
                        End If
                    Next
                    If inserted = True Then
                        newRow("Priority") = dragIndex + 1                                      'Priority = the place it was dragged to
                        For Each row1 As DataGridViewRow In FPM_QueDataGridView.Rows()
                            If row1.Cells(0).Value >= dragIndex + 1 Then                        'cycles through and adjust the other rows Priority values
                                row1.Cells(0).Value += 1
                            End If
                        Next
                    Else
                        newRow("Priority") = (dragIndex + 1)
                    End If

                End If
                FpmtBredDataDataSet.Tables("FPM_Que").Rows.Add(newRow)    'Add row

                FPM_QueTableAdapter.Update(Me.FpmtBredDataDataSet.FPM_Que)    'update datatable



            Else                                                                                          'working with a duplicate from the queue(rearranging queue)
                Dim p As Point = FPM_QueDataGridView.PointToClient(New Point(e.X, e.Y))                     'where the mouse dropped
                dragIndex = FPM_QueDataGridView.HitTest(p.X, p.Y).RowIndex
                If (e.Effect = DragDropEffects.Move) Then                               'drag n drop
                    Dim dragRow As New DataGridViewRow                                                  'drag row is the row being dragged
                    dragRow = e.Data.GetData(GetType(DataGridViewRow))                                  'makes it a datagridviewrow

                    Dim sourceIndex As Integer                                                          'the index that row was dragged from
                    sourceIndex = dragRow.Cells(0).Value - 1                                            ' = priority - 1 = index

                    Dim previous As String
                    previous = Nothing
                    Dim oldPrio As String
                    oldPrio = Nothing

                    'Dim newRow1 As DataRow = FPMTBredDataDataSet.Tables("FPM_Que").NewRow()
                    'newRow1("CompanyNo") = dragRow.Cells(1).Value
                    'newRow1("OrderNo") = dragRow.Cells(2).Value
                    'newRow1("Priority") = dragIndex + 1
                    'newRow1("Machine") = dragRow.Cells(3)

                    For Each row As DataGridViewRow In FPM_QueDataGridView.Rows

                        ' MsgBox(row.Cells(2).Value)
                        'MsgBox((previous) + "previous")
                        If row.Index >= dragIndex Then                                           'checks if below insertion index
                            If row.Index < sourceIndex Then                                         'and above removal index?
                                If previous = row.Cells(2).Value Then                           'if loop skipped a row due to reordering during the loop

                                    Dim previousIndex2 = row.Cells(2).RowIndex - 1                  'checks if the pevious row iterated is the curent row
                                    For Each row5 As DataGridViewRow In FPM_QueDataGridView.Rows
                                        If row5.Index = previousIndex2 Then                             'finds skipped row and increases the prio
                                            row5.Cells(0).Value += 1
                                            FPM_QueTableAdapter.Update(Me.FpmtBredDataDataSet.FPM_Que)
                                            Exit For
                                        End If
                                    Next
                                    Continue For
                                End If
                                previous = row.Cells(2).Value
                                row.Cells(0).Value += 1         'increases by 1

                                Continue For
                            Else
                                If row.Index = sourceIndex Then                          'its found the original row, old row is to be removed
                                    If previous = row.Cells(2).Value Then               'checks for dumbass reordering during loop
                                        Dim previousIndex = row.Cells(2).RowIndex - 1

                                        For Each row4 As DataGridViewRow In FPM_QueDataGridView.Rows
                                            If row4.Index = previousIndex Then
                                                oldPrio = row4.Cells(2).Value

                                                row4.Cells(0).Value = dragIndex + 1         'changes prio to new prio (where it was dragged)

                                                Exit For
                                            End If
                                        Next
                                        Continue For
                                    End If

                                    oldPrio = row.Cells(2).Value
                                    row.Cells(0).Value = dragIndex + 1                  'changes prio to new prio (where it was dragged)

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
                            If row.Index < dragIndex Then                    'above insertion
                                If row.Index > sourceIndex Then                 'below removal
                                    row.Cells(0).Value -= 1                 'decreases by 1
                                    previous = row.Cells(2).Value
                                    Continue For
                                Else
                                    If row.Index = sourceIndex Then
                                        oldPrio = row.Cells(2).Value
                                        row.Cells(0).Value = dragIndex + 1              'changes prio to new prio (where it was dragged)
                                        previous = row.Cells(2).Value                   'newprev
                                        '  MsgBox("oldprio")
                                        ' MsgBox(oldPrio)
                                        Continue For

                                    End If
                                End If
                            Else
                                If row.Index = dragIndex Then
                                    row.Cells(0).Value += 1
                                    previous = row.Cells(2).Value                     'newprev
                                    Continue For
                                End If
                            End If

                        End If
                    Next
                    ' If oldPrio <> Nothing Then

                    '   For Each row3 As DataRow In FPMTBredDataDataSet.Tables("FPM_Que").Rows
                    ' Dim dr As DataRow


                    'If row3.Item(2) = oldPrio Then

                    '     MsgBox("match")
                    '    MsgBox(row3.Item(3))
                    ' row3.Delete()                 'change
                    ' MsgBox(row3.Item(2))
                    'FPMTBredDataDataSet.Tables("FPM_Que").Rows.Add(newRow1)    '         CHANGE Add row
                    ' FPM_QueTableAdapter.Update(Me.FPMTBredDataDataSet.FPM_Que)
                    'Exit For
                    ' FPMTBredDataDataSet.Tables("FPM_Que").Rows(row.Index).Delete()
                    'End If
                    ' Next
                    'End If
                    ' FPMTBredDataDataSet.Tables("FPM_Que").Rows.Add(newRow1)    'Add row
                    FPM_QueTableAdapter.Update(Me.FpmtBredDataDataSet.FPM_Que)


                End If


            End If

            FPM_QueTableAdapter.Update(Me.FpmtBredDataDataSet.FPM_Que)
            FPM_QueDataGridView.Sort(FPM_QueDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
            FPM_QueDataGridView.Refresh()

            Call Button4_Click(sender, e)               'button4 = refresh button

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FPM_QueDataGridView_DragEnter_1(sender As Object, e As DragEventArgs) Handles FPM_QueDataGridView.DragEnter
        Try
            e.Effect = DragDropEffects.Copy

            e.Effect = DragDropEffects.Move


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FPM_QueDataGridView_MouseDown(sender As Object, e As MouseEventArgs) Handles FPM_QueDataGridView.MouseDown
        fromIndex = FPM_QueDataGridView.HitTest(e.X, e.Y).RowIndex
        If fromIndex > -1 Then
            Dim dragSize As Size = SystemInformation.DragSize
            dragRect = New Rectangle(New Point(e.X - (dragSize.Width / 2), _
                                  e.Y - (dragSize.Height / 2)), _
                                     dragSize)
        Else
            dragRect = Rectangle.Empty
        End If
    End Sub

    Private Sub FPM_QueDataGridView_MouseMove(sender As Object, e As MouseEventArgs) Handles FPM_QueDataGridView.MouseMove
        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
            If (dragRect <> Rectangle.Empty _
            AndAlso Not dragRect.Contains(e.X, e.Y)) Then

                FPM_QueDataGridView.DoDragDrop(FPM_QueDataGridView.Rows(fromIndex), _
                                         DragDropEffects.Move)
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        FPM_QueTableAdapter.Update(Me.FpmtBredDataDataSet.FPM_Que)
        FPM_QueDataGridView.Refresh()
    End Sub

    Private Sub FPM_QueDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles FPM_QueDataGridView.DataError
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

    Private Sub FPM_QueDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles FPM_QueDataGridView.CellClick
        Try
            FPM_QueTableAdapter.Update(Me.FpmtBredDataDataSet.FPM_Que)

        Catch
        End Try
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
            Me.MachStat_FPMTableAdapter.Fill(Me.FPMMachWipHistDataSet.MachStat_FPM)
            FPM_QueDataGridView.Sort(FPM_QueDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
            MachStat_FPMDataGridView.Refresh()

            'Dim bufferView As DataView = New DataView(MachWipHistDataSet1.TbredBuffer)                           'SKIPPING TO PULL FROM DISPLAY

            'For Each bufRow As DataRowView In bufferView
            '    Dim row As DataRow = bufRow.Row
            '    Dim test = Len(row.Item(3))
            '    Select Case row.Item(3)

            '        Case "B5    "
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(0)(0) = row.Item(2)
            '            ' FPMMachWipHistDataSet.MachStat_FPM.Rows(0)(1) = row.Item(3)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(0)(2) = row.Item(4)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(0)(3) = row.Item(5)
            '        Case "B6    "
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(1)(0) = row.Item(2)
            '            'FPMMachWipHistDataSet.MachStat_FPM.Rows(1)(1) = row.Item(3)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(1)(2) = row.Item(4)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(1)(3) = row.Item(5)
            '        Case "S7    "
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(2)(0) = row.Item(2)
            '            ' FPMMachWipHistDataSet.MachStat_FPM.Rows(2)(1) = row.Item(3)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(2)(2) = row.Item(4)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(2)(3) = row.Item(5)
            '        Case "S8    "
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(3)(0) = row.Item(2)
            '            ' FPMMachWipHistDataSet.MachStat_FPM.Rows(3)(1) = row.Item(3)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(3)(2) = row.Item(4)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(3)(3) = row.Item(5)
            '        Case "Z10   "
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(4)(0) = row.Item(2)
            '            ' FPMMachWipHistDataSet.MachStat_FPM.Rows(4)(1) = row.Item(3)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(4)(2) = row.Item(4)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(4)(3) = row.Item(5)
            '        Case "Z11   "
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(5)(0) = row.Item(2)
            '            '  FPMMachWipHistDataSet.MachStat_FPM.Rows(5)(1) = row.Item(3)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(5)(2) = row.Item(4)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(5)(3) = row.Item(5)
            '        Case "Z12   "
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(6)(0) = row.Item(2)
            '            '   FPMMachWipHistDataSet.MachStat_FPM.Rows(6)(1) = row.Item(3)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(6)(2) = row.Item(4)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(6)(3) = row.Item(5)
            '        Case "Z13   "
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(7)(0) = row.Item(2)
            '            '   FPMMachWipHistDataSet.MachStat_FPM.Rows(7)(1) = row.Item(3)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(7)(2) = row.Item(4)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(7)(3) = row.Item(5)
            '        Case "Z16   "
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(8)(0) = row.Item(2)
            '            '  FPMMachWipHistDataSet.MachStat_FPM.Rows(8)(1) = row.Item(3)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(8)(2) = row.Item(4)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(8)(3) = row.Item(5)
            '        Case "Z17   "
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(9)(0) = row.Item(2)
            '            '  FPMMachWipHistDataSet.MachStat_FPM.Rows(8)(1) = row.Item(3)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(9)(2) = row.Item(4)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(9)(3) = row.Item(5)
            '        Case "Z18   "
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(10)(0) = row.Item(2)
            '            '  FPMMachWipHistDataSet.MachStat_FPM.Rows(8)(1) = row.Item(3)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(10)(2) = row.Item(4)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(10)(3) = row.Item(5)
            '        Case "Z7    "
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(11)(0) = row.Item(2)
            '            '  FPMMachWipHistDataSet.MachStat_FPM.Rows(8)(1) = row.Item(3)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(11)(2) = row.Item(4)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(11)(3) = row.Item(5)
            '        Case "Z8    "
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(12)(0) = row.Item(2)
            '            '  FPMMachWipHistDataSet.MachStat_FPM.Rows(8)(1) = row.Item(3)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(12)(2) = row.Item(4)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(12)(3) = row.Item(5)
            '        Case "Z9    "
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(13)(0) = row.Item(2)
            '            '  FPMMachWipHistDataSet.MachStat_FPM.Rows(8)(1) = row.Item(3)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(13)(2) = row.Item(4)
            '            FPMMachWipHistDataSet.MachStat_FPM.Rows(13)(3) = row.Item(5)



            '    End Select
            '    MachStat_FPMTableAdapter.Update(Me.FPMMachWipHistDataSet.MachStat_FPM)
            '    MachStat_FPMDataGridView.Refresh()
            'Next



        Catch ex As Exception
            'Exit Sub
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.OrderTBLTableAdapter.FillBy1(Me.FpmtBredDataDataSet.OrderTBL)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        Dim message, title, defaultValue As String
        Dim myValue As Object
        message = "Enter Manager's Key"
        title = "Authorization To Edit"
        defaultValue = "enter password"
        myValue = InputBox(message, title, defaultValue)
        If myValue = My.Settings.fpmpassword Then

            Call managerMode()

        Else
            MsgBox("Invalid Credentials")
        End If
    End Sub

    Private Sub managerMode()

        Label6.Visible = True
        Button1.Visible = True
        FPM_QueDataGridView.AllowDrop() = True
        FPM_QueDataGridView.Columns(0).ReadOnly = False
        FPM_QueDataGridView.Columns(1).ReadOnly = False
        FPM_QueDataGridView.Columns(2).ReadOnly = False
        FPM_QueDataGridView.Columns(3).ReadOnly = False
        FPM_QueDataGridView.Columns(4).ReadOnly = False
        FPM_QueDataGridView.Columns(5).ReadOnly = False
        FPM_QueDataGridView.Columns(6).ReadOnly = False
        FPM_QueDataGridView.Columns(7).ReadOnly = False
        FPM_QueDataGridView.Columns(8).ReadOnly = False
        FPM_QueDataGridView.Columns(9).ReadOnly = False
        FPM_QueDataGridView.Columns(10).ReadOnly = False
        FPM_QueDataGridView.Columns(11).ReadOnly = False
        Button4.Enabled = True
        FPM_QueDataGridView.ReadOnly = False
        Timer.Enabled = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click                   'OrderTBL search function

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

    Private Sub FillBy2ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.OrderTBLTableAdapter1.FillBy2(Me.IHCTBredDataDataSet.OrderTBL)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click       'REFRESH button
        FPM_QueDataGridView.ClearSelection()
        'Me.FPM_QueTableAdapter.Fill(Me.FpmtBredDataDataSet.FPM_Que)
        'FPM_QueDataGridView.Sort(FPM_QueDataGridView.Columns(2), System.ComponentModel.ListSortDirection.Ascending)

        For Each row As DataGridViewRow In FPM_QueDataGridView.Rows
            If row.Cells(4).Value <> Nothing Then
                row.Cells(0).Value = row.Index + 1
            End If
        Next
        FPM_QueTableAdapter.Update(Me.FpmtBredDataDataSet.FPM_Que)
        FPM_QueDataGridView.Sort(FPM_QueDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

    End Sub


    Private Sub FPM_QueDataGridView_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles FPM_QueDataGridView.UserDeletedRow

        'For Each row As DataGridViewRow In IHC_QueDataGridView.Rows
        '   If row.Cells(2).Value <> Nothing Then
        '      row.Cells(0).Value = row.Index + 1
        ' End If
        ' Next
        ' IHC_QueDataGridView.Sort(IHC_QueDataGridView.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
        ' IHC_QueTableAdapter.Update(IhctBredDataDataSet.IHC_Que)
        ' IHC_QueDataGridView.Refresh()

        '    End Sub


        ' Private Sub FPM_QueDataGridView_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles FPM_QueDataGridView.UserDeletedRow

        FPM_QueDataGridView.ClearSelection()

        For Each row As DataGridViewRow In FPM_QueDataGridView.Rows
            If row.Cells(4).Value <> Nothing Then
                row.Cells(0).Value = row.Index + 1
            End If
        Next
        FPM_QueDataGridView.Sort(FPM_QueDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        FPM_QueTableAdapter.Update(FpmtBredDataDataSet.FPM_Que)
        FPM_QueDataGridView.Refresh()
        FPM_QueDataGridView.ClearSelection()

    End Sub

    Private Sub FPMManager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        FPM_QueTableAdapter.Update(Me.FpmtBredDataDataSet.FPM_Que)
        FPM_QueDataGridView.Refresh()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click           'exiting manager mode

        Label6.Visible = False
        Button1.Visible = False
        FPM_QueDataGridView.AllowDrop() = False
        FPM_QueDataGridView.Columns(4).ReadOnly = True
        FPM_QueDataGridView.Columns(5).ReadOnly = True
        FPM_QueDataGridView.Columns(6).ReadOnly = True
        FPM_QueDataGridView.Columns(7).ReadOnly = True
        FPM_QueDataGridView.Columns(8).ReadOnly = True
        FPM_QueDataGridView.Columns(2).ReadOnly = True
        FPM_QueDataGridView.Columns(3).ReadOnly = True
        FPM_QueDataGridView.Columns(1).ReadOnly = True
        FPM_QueDataGridView.Columns(0).ReadOnly = True
        FPM_QueDataGridView.Columns(10).ReadOnly = True
        FPM_QueDataGridView.Columns(9).ReadOnly = True
        FPM_QueDataGridView.Columns(11).ReadOnly = True
        Button4.Enabled = False
        FPM_QueDataGridView.ReadOnly = True
        Timer.Enabled = True

    End Sub
End Class