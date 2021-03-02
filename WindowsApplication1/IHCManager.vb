Public Class IHCManager

    Private fromIndex As Integer
    Private dragIndex As Integer
    Private dragRect As Rectangle
    Private aasdf As Type

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

    Private Sub OrderTBLDataGridView_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles OrderTBLDataGridView.CellClick

        OrderTBLDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub IHCManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.OrderTBLTableAdapter.Fill(Me.IhctBredDataDataSet.OrderTBL)
        Me.WindowState = FormWindowState.Maximized
        Me.TbredBufferTableAdapter.Fill(Me.MachWipHistDataSet1.TbredBuffer)
        Me.MachIDs_IHCTableAdapter.Fill(Me.IhctBredDataDataSet.MachIDs_IHC)
        Me.MachStat_IHCTableAdapter.Fill(Me.IhcMachWipHistDataSet.MachStat_IHC)
        Me.OrderTBLTableAdapter.Fill(Me.IhctBredDataDataSet.OrderTBL)

        Try
            Me.OrderTBLTableAdapter.FillBy(Me.IhctBredDataDataSet.OrderTBL)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        OrderTBLDataGridView.Sort(OrderTBLDataGridView.Columns(6), System.ComponentModel.ListSortDirection.Descending)
        Me.IHC_QueTableAdapter.Fill(Me.IhctBredDataDataSet.IHC_Que)
        IHC_QueDataGridView.Sort(IHC_QueDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

        For Each d As DataGridViewColumn In IHC_QueDataGridView.Columns()
            Select Case d.Index
                Case 0
                    d.Width = 50
                Case 1
                    d.Width = 50
            End Select
        Next

        If Environment.MachineName = "INTERN-WS" Then
            Call managerMode()
        End If

        Call Button4_Click(sender, e)
        Call Button5_Click(sender, e)
        Call Timer_Tick(sender, e)
        Button4.Enabled = False

        ' IHC_QueDataGridView.AllowDrop()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click           'CLEAR BUTTON
        Try

            Dim result As Integer = MessageBox.Show("Clear the Queue?", "Clear All", MessageBoxButtons.YesNo)

            If result = DialogResult.No Then
                Exit Sub
            End If

            Do While IhctBredDataDataSet.Tables("IHC_Que").Rows.Count <> 0
                Dim dr As DataRow
                dr = IhctBredDataDataSet.Tables("IHC_Que").Rows(0)
                dr.Delete() 'Delete the row
                IHC_QueTableAdapter.Update(Me.IhctBredDataDataSet.IHC_Que)
                IHC_QueDataGridView.Refresh()
            Loop

        Catch ex As Exception
            MsgBox("Clear Failed")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub IHC_QueDataGridView_DragDrop_1(sender As Object, e As DragEventArgs) Handles IHC_QueDataGridView.DragDrop
        Try
            IHC_QueDataGridView.Refresh()

            Dim r As DataGridViewRow = e.Data.GetData(GetType(DataGridViewRow))
            Dim machine As String
            machine = "A100"

            Dim duplicate As Boolean = False

            If IHC_QueDataGridView.Rows.Count() = 1 Then
                'Dim p As Point = IHC_QueDataGridView.PointToClient(New Point(e.X, e.Y))
                ' dragIndex = IHC_QueDataGridView.HitTest(p.X, p.Y).RowIndex
                Dim newRow As DataRow = IhctBredDataDataSet.Tables("IHC_Que").NewRow()
                newRow("Priority") = IHC_QueDataGridView.Rows.Count()        'dec
                newRow("CompanyNo") = r.Cells(0).Value              ' dec
                newRow("OrderNo") = r.Cells(1).Value                'string
                newRow("Cust") = r.Cells(3).Value
                newRow("Diameter") = r.Cells(4).Value

                IhctBredDataDataSet.Tables("IHC_Que").Rows.Add(newRow)    'Add row

                IHC_QueTableAdapter.Update(Me.IhctBredDataDataSet.IHC_Que)    'update datatable
                Exit Sub
            Else
                For Each row As DataGridViewRow In IHC_QueDataGridView.Rows
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
                Dim p As Point = IHC_QueDataGridView.PointToClient(New Point(e.X, e.Y))
                dragIndex = IHC_QueDataGridView.HitTest(p.X, p.Y).RowIndex
                Dim newRow As DataRow = IhctBredDataDataSet.Tables("IHC_Que").NewRow()
                newRow("CompanyNo") = r.Cells(0).Value
                newRow("OrderNo") = r.Cells(1).Value
                newRow("Cust") = r.Cells(3).Value
                newRow("Diameter") = r.Cells(4).Value

                If dragIndex = -1 Then
                    newRow("Priority") = IHC_QueDataGridView.Rows.Count()
                Else
                    For Each row As DataGridViewRow In IHC_QueDataGridView.Rows
                        If row.Cells(0).Value = (dragIndex + 1) Then
                            inserted = True
                            Exit For
                        End If
                    Next
                    If inserted = True Then
                        newRow("Priority") = dragIndex + 1
                        For Each row1 As DataGridViewRow In IHC_QueDataGridView.Rows()
                            If row1.Cells(0).Value >= dragIndex + 1 Then
                                row1.Cells(0).Value += 1
                            End If
                        Next
                    Else
                        newRow("Priority") = (dragIndex + 1)
                    End If

                End If
                IhctBredDataDataSet.Tables("IHC_Que").Rows.Add(newRow)    'Add row

                IHC_QueTableAdapter.Update(Me.IhctBredDataDataSet.IHC_Que)    'update datatable

            Else                                                                'is now working with a duplicate
                Dim p As Point = IHC_QueDataGridView.PointToClient(New Point(e.X, e.Y))
                dragIndex = IHC_QueDataGridView.HitTest(p.X, p.Y).RowIndex
                If (e.Effect = DragDropEffects.Move) Then
                    Dim dragRow As New DataGridViewRow
                    dragRow = e.Data.GetData(GetType(DataGridViewRow))

                    Dim sourceIndex As Integer
                    sourceIndex = dragRow.Cells(0).Value - 1

                    Dim previous As String
                    previous = Nothing
                    Dim oldPrio As String
                    oldPrio = Nothing

                    'Dim newRow1 As DataRow = IHCTbredDataDataSet.Tables("IHC_Que").NewRow()
                    'newRow1("CompanyNo") = dragRow.Cells(1).Value
                    'newRow1("OrderNo") = dragRow.Cells(2).Value
                    'newRow1("Priority") = dragIndex + 1
                    'newRow1("Machine") = dragRow.Cells(3)

                    For Each row As DataGridViewRow In IHC_QueDataGridView.Rows

                        ' MsgBox(row.Cells(2).Value)
                        'MsgBox((previous) + "previous")
                        If row.Index >= dragIndex Then          'check if below insertion index
                            If row.Index < sourceIndex Then     'and above removal index?
                                If previous = row.Cells(2).Value Then       'loop skipped a row?
                                    ' MsgBox("skipped")
                                    Dim previousIndex2 = row.Cells(2).RowIndex - 1
                                    For Each row5 As DataGridViewRow In IHC_QueDataGridView.Rows
                                        If row5.Index = previousIndex2 Then     'finds skipped row and increases the prio
                                            row5.Cells(0).Value += 1
                                            IHC_QueTableAdapter.Update(Me.IhctBredDataDataSet.IHC_Que)
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

                                        For Each row4 As DataGridViewRow In IHC_QueDataGridView.Rows
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

                    '   For Each row3 As DataRow In IHCTbredDataDataSet.Tables("IHC_Que").Rows
                    ' Dim dr As DataRow


                    'If row3.Item(2) = oldPrio Then

                    '     MsgBox("match")
                    '    MsgBox(row3.Item(3))
                    ' row3.Delete()                 'change
                    ' MsgBox(row3.Item(2))
                    'IHCTbredDataDataSet.Tables("IHC_Que").Rows.Add(newRow1)    '         CHANGE Add row
                    ' IHC_QueTableAdapter.Update(Me.IHCTBredDataDataSet.IHC_Que)
                    'Exit For
                    ' IHCTbredDataDataSet.Tables("IHC_Que").Rows(row.Index).Delete()
                    'End If
                    ' Next
                    'End If
                    ' IHCTbredDataDataSet.Tables("IHC_Que").Rows.Add(newRow1)    'Add row
                    IHC_QueTableAdapter.Update(Me.IhctBredDataDataSet.IHC_Que)

                End If

            End If

            IHC_QueDataGridView.Sort(IHC_QueDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
            IHC_QueTableAdapter.Update(Me.IhctBredDataDataSet.IHC_Que)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub IHC_QueDataGridView_DragEnter_1(sender As Object, e As DragEventArgs) Handles IHC_QueDataGridView.DragEnter
        Try
            e.Effect = DragDropEffects.Copy

            e.Effect = DragDropEffects.Move

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub IHC_QueDataGridView_MouseDown(sender As Object, e As MouseEventArgs) Handles IHC_QueDataGridView.MouseDown 'mouse down button
        fromIndex = IHC_QueDataGridView.HitTest(e.X, e.Y).RowIndex
        If fromIndex > -1 Then
            Dim dragSize As Size = SystemInformation.DragSize
            dragRect = New Rectangle(New Point(e.X - (dragSize.Width / 2), _
                                  e.Y - (dragSize.Height / 2)), _
                                     dragSize)
        Else
            dragRect = Rectangle.Empty
        End If
    End Sub

    Private Sub IHC_QueDataGridView_MouseMove(sender As Object, e As MouseEventArgs) Handles IHC_QueDataGridView.MouseMove ' mouse move in que grid
        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
            If (dragRect <> Rectangle.Empty _
            AndAlso Not dragRect.Contains(e.X, e.Y)) Then

                IHC_QueDataGridView.DoDragDrop(IHC_QueDataGridView.Rows(fromIndex), _
                                         DragDropEffects.Move)
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        IHC_QueTableAdapter.Update(Me.IHCTBredDataDataSet.IHC_Que)
        IHC_QueDataGridView.Refresh()
    End Sub

    Private Sub IHC_QueDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles IHC_QueDataGridView.DataError
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
    Private Sub IHC_QueDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles IHC_QueDataGridView.CellContentClick 'CellLeave  'CellValueChanged  '.CellClick

        If IHC_QueDataGridView.AllowDrop() = False Then Exit Sub

        For Each row As DataGridViewRow In IHC_QueDataGridView.Rows

            Dim rowindex = row.Index
            Dim currentrow = IHC_QueDataGridView.CurrentRow.Index

            If row.Cells(8).Value Is DBNull.Value Then
                Exit Sub ' Else auto load cells
            Else ' WEST SIDE DEFAULTS WITH H1
                If row.Cells(8).Selected = True And row.Cells(8).IsInEditMode = True Then
                    If row.Cells(8).Value = "H1   " And rowindex = currentrow Then
                        If row.Cells(9).Value Is DBNull.Value And row.Cells(10).Value Is DBNull.Value Then
                            GoTo AddDefaultH1
                        End If
                        If row.Cells(8).Selected = True And row.Cells(8).IsInEditMode = True And row.Cells(9).Value = "P11  " Or row.Cells(10).Value = "PLW  " Then
                            Dim button As DialogResult =
                            MessageBox.Show("Change Cell Values to Default?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                            If button = Windows.Forms.DialogResult.Cancel Then
                                Exit Sub
                            End If
AddDefaultH1:               row.Cells(9).Value = "P11 "
                            row.Cells(10).Value = "PLW "
                            row.Cells(11).Value = "P10 "
                            row.Cells(12).Value = "P15 "
                        End If
                    End If
                End If
            End If
            ' WEST SIDE DEFAULTS WITH P11
            If row.Cells(8).Selected = True And row.Cells(8).IsInEditMode = True Then
                If row.Cells(8).Value = "P11  " And rowindex = currentrow Then
                    If row.Cells(9).Value Is DBNull.Value And row.Cells(10).Value Is DBNull.Value Then
                        GoTo AddDefaultP11
                    End If
                    If row.Cells(8).Selected = True And row.Cells(8).IsInEditMode = True Then 'And row.Cells(8).Value = "PLW  " Then
                        Dim button As DialogResult =
                        MessageBox.Show("Change Cell Values to Default?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                        If button = Windows.Forms.DialogResult.Cancel Then
                            Exit Sub
                        End If
AddDefaultP11:          row.Cells(9).Value = "PLW "
                        row.Cells(10).Value = "P10 "
                        row.Cells(11).Value = "P15 "
                        row.Cells(12).Value = ""
                    End If
                End If
            End If

            ' EAST SIDE DEFAULTS WITH H3
            If row.Cells(8).Selected = True And row.Cells(8).IsInEditMode = True Then
                If row.Cells(8).Value = "H3   " And rowindex = currentrow Then
                    If row.Cells(9).Value Is DBNull.Value And row.Cells(10).Value Is DBNull.Value Then
                        GoTo AddDefaultH3
                    End If
                    If row.Cells(8).Selected = True And row.Cells(8).IsInEditMode = True And row.Cells(9).Value = "P12  " Or row.Cells(10).Value = "PLE  " Then
                        Dim button As DialogResult =
                        MessageBox.Show("Change Cell Values to Default?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                        If button = Windows.Forms.DialogResult.Cancel Then
                            Exit Sub
                        End If
AddDefaultH3:           row.Cells(9).Value = "P12 "
                        row.Cells(10).Value = "PLE "
                        row.Cells(11).Value = "P19 "
                        row.Cells(12).Value = "P14 "
                    End If
                End If
            End If
            ' EAST SIDE DEFAULTS WITH P12
            If row.Cells(8).Selected = True And row.Cells(8).IsInEditMode = True Then
                If row.Cells(8).Value = "P12  " And rowindex = currentrow Then
                    If row.Cells(9).Value Is DBNull.Value And row.Cells(10).Value Is DBNull.Value Then
                        GoTo AddDefaultP12
                    End If
                    If row.Cells(8).Selected = True And row.Cells(8).IsInEditMode = True Then 'And row.Cells(8).Value = "PLE  " Then
                        Dim button As DialogResult =
                        MessageBox.Show("Change Cell Values to Default?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                        If button = Windows.Forms.DialogResult.Cancel Then
                            Exit Sub
                        End If
AddDefaultP12:          row.Cells(9).Value = "PLE "
                        row.Cells(10).Value = "P19 "
                        row.Cells(11).Value = "P14 "
                        row.Cells(12).Value = ""
                    End If
                End If
            End If
            ' PL2 DEFAULTS WITH P17
            If row.Cells(8).Selected = True And row.Cells(8).IsInEditMode = True Then
                If row.Cells(8).Value = "P17  " And rowindex = currentrow Then
                    If row.Cells(9).Value Is DBNull.Value And row.Cells(10).Value Is DBNull.Value Then
                        GoTo AddDefaultP17
                    End If
                    If row.Cells(8).Selected = True And row.Cells(8).IsInEditMode = True Then 'And row.Cells(7).Value = "PL2  " Then
                        Dim button As DialogResult =
                        MessageBox.Show("Change Cell Values to Default?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                        If button = Windows.Forms.DialogResult.Cancel Then
                            Exit Sub
                        End If
AddDefaultP17:          row.Cells(9).Value = "PL2 "
                        row.Cells(10).Value = "P16 "
                        row.Cells(11).Value = ""
                        row.Cells(12).Value = ""
                    End If
                End If
            End If


        Next

        IHC_QueTableAdapter.Update(Me.IhctBredDataDataSet.IHC_Que)
        ' IHC_QueDataGridView.Refresh()

    End Sub

    ' Private Sub IHC_QueDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles IHC_QueDataGridView.CellClick 'dropdown cells click
    '    IHC_QueTableAdapter.Update(Me.IhctBredDataDataSet.IHC_Que)
    '   IHC_QueDataGridView.Refresh()
    'End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Try

            Me.TbredBufferTableAdapter.Fill(Me.MachWipHistDataSet1.TbredBuffer)
            Me.MachStat_IHCTableAdapter.Fill(IhcMachWipHistDataSet.MachStat_IHC)            'pulling from view display
            MachStat_IHCDataGridView.Update()
            MachStat_IHCDataGridView.Refresh()


            'Dim bufferView As DataView = New DataView(MachWipHistDataSet1.TbredBuffer)                     'COMMENTED CUZ PULLING FROM VIEW DISPLAY

            'For Each bufRow As DataRowView In bufferView
            '    Dim row As DataRow = bufRow.Row
            '    Dim test = Len(row.Item(3))
            '    Select Case row.Item(3)

            '        Case "H1    "
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(0)(0) = row.Item(2)
            '            ' IHCMachWipHistDataSet.MachStat_IHC.Rows(0)(1) = row.Item(3)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(0)(2) = row.Item(4)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(0)(3) = row.Item(5)
            '        Case "H3   "
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(1)(0) = row.Item(2)
            '            'IHCMachWipHistDataSet.MachStat_IHC.Rows(1)(1) = row.Item(3)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(1)(2) = row.Item(4)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(1)(3) = row.Item(5)
            '        Case "P11   "
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(2)(0) = row.Item(2)
            '            ' IHCMachWipHistDataSet.MachStat_IHC.Rows(2)(1) = row.Item(3)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(2)(2) = row.Item(4)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(2)(3) = row.Item(5)
            '        Case "P12   "
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(3)(0) = row.Item(2)
            '            ' IHCMachWipHistDataSet.MachStat_IHC.Rows(3)(1) = row.Item(3)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(3)(2) = row.Item(4)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(3)(3) = row.Item(5)
            '        Case "P19   "
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(4)(0) = row.Item(2)
            '            ' IHCMachWipHistDataSet.MachStat_IHC.Rows(4)(1) = row.Item(3)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(4)(2) = row.Item(4)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(4)(3) = row.Item(5)
            '        Case "P14   "
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(5)(0) = row.Item(2)
            '            '  IHCMachWipHistDataSet.MachStat_IHC.Rows(5)(1) = row.Item(3)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(5)(2) = row.Item(4)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(5)(3) = row.Item(5)
            '        Case "P15   "
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(6)(0) = row.Item(2)
            '            '   IHCMachWipHistDataSet.MachStat_IHC.Rows(6)(1) = row.Item(3)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(6)(2) = row.Item(4)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(6)(3) = row.Item(5)
            '        Case "P16   "
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(7)(0) = row.Item(2)
            '            '   IHCMachWipHistDataSet.MachStat_IHC.Rows(7)(1) = row.Item(3)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(7)(2) = row.Item(4)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(7)(3) = row.Item(5)
            '        Case "P17   "
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(8)(0) = row.Item(2)
            '            '  IHCMachWipHistDataSet.MachStat_IHC.Rows(8)(1) = row.Item(3)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(8)(2) = row.Item(4)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(8)(3) = row.Item(5)
            '        Case "P7    "
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(9)(0) = row.Item(2)
            '            '  IHCMachWipHistDataSet.MachStat_IHC.Rows(8)(1) = row.Item(3)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(9)(2) = row.Item(4)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(9)(3) = row.Item(5)
            '        Case "PL2   "
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(10)(0) = row.Item(2)
            '            '  IHCMachWipHistDataSet.MachStat_IHC.Rows(8)(1) = row.Item(3)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(10)(2) = row.Item(4)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(10)(3) = row.Item(5)
            '        Case "PLE   "
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(11)(0) = row.Item(2)
            '            '  IHCMachWipHistDataSet.MachStat_IHC.Rows(8)(1) = row.Item(3)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(11)(2) = row.Item(4)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(11)(3) = row.Item(5)
            '        Case "PLW   "
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(12)(0) = row.Item(2)
            '            '  IHCMachWipHistDataSet.MachStat_IHC.Rows(8)(1) = row.Item(3)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(12)(2) = row.Item(4)
            '            IhcMachWipHistDataSet.MachStat_IHC.Rows(12)(3) = row.Item(5)



            '    End Select
            '    MachStat_IHCTableAdapter.Update(Me.IhcMachWipHistDataSet.MachStat_IHC)
            '    MachStat_IHCDataGridView.Refresh()
            'Next


        Catch ex As Exception
            Exit Sub
            'MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.OrderTBLTableAdapter.FillBy(Me.IhctBredDataDataSet.OrderTBL)
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
        If myValue = My.Settings.ihcpassword Then
            Call managerMode()
        Else
            MsgBox("Invalid Credentials")
        End If
    End Sub

    Private Sub managerMode()

        Label6.Visible = True
        Button1.Visible = True
        IHC_QueDataGridView.AllowDrop() = True
        IHC_QueDataGridView.Columns(0).ReadOnly = False
        IHC_QueDataGridView.Columns(1).ReadOnly = False
        IHC_QueDataGridView.Columns(2).ReadOnly = False
        IHC_QueDataGridView.Columns(3).ReadOnly = False
        IHC_QueDataGridView.Columns(4).ReadOnly = False
        IHC_QueDataGridView.Columns(5).ReadOnly = False
        IHC_QueDataGridView.Columns(6).ReadOnly = False
        IHC_QueDataGridView.Columns(7).ReadOnly = False
        IHC_QueDataGridView.Columns(8).ReadOnly = False
        IHC_QueDataGridView.Columns(9).ReadOnly = False
        IHC_QueDataGridView.Columns(10).ReadOnly = False
        IHC_QueDataGridView.Columns(11).ReadOnly = False
        IHC_QueDataGridView.Columns(12).ReadOnly = False
        Button4.Enabled = True
        Timer.Enabled = False

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.OrderTBLTableAdapter.FillBy1(Me.IhctBredDataDataSet.OrderTBL)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click           'search button
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

    Private Sub IHC_QueDataGridView_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles IHC_QueDataGridView.UserDeletedRow
        For Each row As DataGridViewRow In IHC_QueDataGridView.Rows
            If row.Cells(5).Value <> Nothing Then
                row.Cells(0).Value = row.Index + 1
            End If
        Next
        IHC_QueDataGridView.Sort(IHC_QueDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        IHC_QueTableAdapter.Update(IhctBredDataDataSet.IHC_Que)
        IHC_QueDataGridView.Refresh()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click           'REFRESH
        IHC_QueDataGridView.ClearSelection()

        For Each row As DataGridViewRow In IHC_QueDataGridView.Rows
            If row.Cells(5).Value <> Nothing Then
                row.Cells(0).Value = row.Index + 1
            End If
        Next

        IHC_QueDataGridView.Sort(IHC_QueDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        'IHC_QueDataGridView.Sort(IHC_QueDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

        IHC_QueTableAdapter.Update(Me.IhctBredDataDataSet.IHC_Que)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Label6.Visible = False
        Button1.Visible = False
        IHC_QueDataGridView.AllowDrop() = False
        IHC_QueDataGridView.Columns(4).ReadOnly = True
        IHC_QueDataGridView.Columns(5).ReadOnly = True
        IHC_QueDataGridView.Columns(6).ReadOnly = True
        IHC_QueDataGridView.Columns(7).ReadOnly = True
        IHC_QueDataGridView.Columns(8).ReadOnly = True
        IHC_QueDataGridView.Columns(2).ReadOnly = True
        IHC_QueDataGridView.Columns(3).ReadOnly = True
        IHC_QueDataGridView.Columns(1).ReadOnly = True
        IHC_QueDataGridView.Columns(0).ReadOnly = True
        IHC_QueDataGridView.Columns(9).ReadOnly = True
        IHC_QueDataGridView.Columns(10).ReadOnly = True
        IHC_QueDataGridView.Columns(11).ReadOnly = True
        IHC_QueDataGridView.Columns(12).ReadOnly = True
        Button4.Enabled = False
        Timer.Enabled = True

    End Sub

End Class

