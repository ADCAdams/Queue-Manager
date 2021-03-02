Public Class FPMView

    Private Sub FPM_QueBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

        Me.Validate()
        Me.FPM_QueBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FpmtBredDataDataSet)

    End Sub

    Private Sub FPMView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.OrderTBLTableAdapter1.Fill(Me.FpmtBredDataDataSet.OrderTBL)
        Me.OrderTBLTableAdapter.Fill(Me.TBredDataDataSet.OrderTBL)

        Me.TbredBufferTableAdapter.Fill(Me.MachWipHistDataSet1.TbredBuffer)
        Me.WindowState = FormWindowState.Maximized
        Me.MachIDs_FPMTableAdapter.Fill(Me.FpmtBredDataDataSet.MachIDs_FPM)
        Me.MachStat_FPMTableAdapter.Fill(Me.FpmMachWipHistDataSet.MachStat_FPM)
        Me.FPM_QueTableAdapter.Fill(Me.FpmtBredDataDataSet.FPM_Que)
        FPM_QueDataGridView.Sort(FPM_QueDataGridView.Columns(2), System.ComponentModel.ListSortDirection.Ascending)

        Call Timer_Tick(sender, e)

    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick


        'Try
        Me.FPM_QueTableAdapter.Fill(Me.FpmtBredDataDataSet.FPM_Que)
        FPM_QueDataGridView.Sort(FPM_QueDataGridView.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
        FPM_QueDataGridView.Refresh()
        Me.TbredBufferTableAdapter.Fill(Me.MachWipHistDataSet1.TbredBuffer)

        Dim bufferView As DataView = New DataView(MachWipHistDataSet1.TbredBuffer)
        Dim tester As String
        For Each bufRow As DataRowView In bufferView
            Dim row As DataRow = bufRow.Row
            Dim test = Len(row.Item(3))
            Dim OrderPrecent As Integer
            Dim OrderNoQue As String = DirectCast(row, QueueManager.MachWipHistDataSet1.TbredBufferRow).OrderNo
            Dim BarCount As Integer = DirectCast(row, QueueManager.MachWipHistDataSet1.TbredBufferRow).PartCnt

            Me.OrderTBLTableAdapter1.Fill(Me.FpmtBredDataDataSet.OrderTBL)
            Me.OrderTBLBindingSource1.Filter = "OrderNo='" & OrderNoQue & "'"
            ' if Position = 0 then record found, if position=-1 record not found
            If Me.OrderTBLBindingSource1.Position = -1 Then 'Order Not Found

            End If
            Me.OrderNoTextBox.ForeColor = Color.White
            Me.Blank_CntTextBox.ForeColor = Color.White

            If Me.Blank_CntTextBox.Text = "" Then
                Me.Blank_CntTextBox.Text = "0"
            End If

            OrderPrecent = Blank_CntTextBox.Text * 0.1
            Blank_CntTextBox.Text = Blank_CntTextBox.Text + OrderPrecent

            Select Case row.Item(3)

                Case "B5    "
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(0)(0) = row.Item(2)
                    ' FPMMachWipHistDataSet.MachStat_FPM.Rows(0)(1) = row.Item(3)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(0)(2) = row.Item(4)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(0)(3) = row.Item(5)
                    If Blank_CntTextBox.Text < BarCount Then
                        Me.Indicator1.BackColor = Color.Yellow
                    Else
                        Me.Indicator1.BackColor = Color.Green
                    End If
                Case "B6    "
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(1)(0) = row.Item(2)
                    'FPMMachWipHistDataSet.MachStat_FPM.Rows(1)(1) = row.Item(3)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(1)(2) = row.Item(4)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(1)(3) = row.Item(5)
                    If Blank_CntTextBox.Text < BarCount Then
                        Me.Indicator2.BackColor = Color.Yellow
                    Else
                        Me.Indicator2.BackColor = Color.Green
                    End If
                Case "S7    "
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(2)(0) = row.Item(2)
                    ' FPMMachWipHistDataSet.MachStat_FPM.Rows(2)(1) = row.Item(3)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(2)(2) = row.Item(4)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(2)(3) = row.Item(5)
                    If Blank_CntTextBox.Text < BarCount Then
                        Me.Indicator3.BackColor = Color.Yellow
                    Else
                        Me.Indicator3.BackColor = Color.Green
                    End If
                Case "S8    "
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(3)(0) = row.Item(2)
                    ' FPMMachWipHistDataSet.MachStat_FPM.Rows(3)(1) = row.Item(3)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(3)(2) = row.Item(4)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(3)(3) = row.Item(5)
                    If Blank_CntTextBox.Text < BarCount Then
                        Me.Indicator4.BackColor = Color.Yellow
                    Else
                        Me.Indicator4.BackColor = Color.Green
                    End If
                Case "Z10   "
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(4)(0) = row.Item(2)
                    ' FPMMachWipHistDataSet.MachStat_FPM.Rows(4)(1) = row.Item(3)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(4)(2) = row.Item(4)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(4)(3) = row.Item(5)
                    If Blank_CntTextBox.Text < BarCount Then
                        Me.Indicator5.BackColor = Color.Yellow
                    Else
                        Me.Indicator5.BackColor = Color.Green
                    End If
                Case "Z11   "
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(5)(0) = row.Item(2)
                    '  FPMMachWipHistDataSet.MachStat_FPM.Rows(5)(1) = row.Item(3)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(5)(2) = row.Item(4)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(5)(3) = row.Item(5)
                    If Blank_CntTextBox.Text < BarCount Then
                        Me.Indicator6.BackColor = Color.Yellow
                    Else
                        Me.Indicator6.BackColor = Color.Green
                    End If
                Case "Z12   "
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(6)(0) = row.Item(2)
                    '   FPMMachWipHistDataSet.MachStat_FPM.Rows(6)(1) = row.Item(3)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(6)(2) = row.Item(4)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(6)(3) = row.Item(5)
                    If Blank_CntTextBox.Text < BarCount Then
                        Me.Indicator7.BackColor = Color.Yellow
                    Else
                        Me.Indicator7.BackColor = Color.Green
                    End If
                Case "Z13   "
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(7)(0) = row.Item(2)
                    '   FPMMachWipHistDataSet.MachStat_FPM.Rows(7)(1) = row.Item(3)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(7)(2) = row.Item(4)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(7)(3) = row.Item(5)
                    If Blank_CntTextBox.Text < BarCount Then
                        Me.Indicator8.BackColor = Color.Yellow
                    Else
                        Me.Indicator8.BackColor = Color.Green
                    End If
                Case "Z16   "
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(8)(0) = row.Item(2)
                    '  FPMMachWipHistDataSet.MachStat_FPM.Rows(8)(1) = row.Item(3)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(8)(2) = row.Item(4)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(8)(3) = row.Item(5)
                    If Blank_CntTextBox.Text < BarCount Then
                        Me.Indicator9.BackColor = Color.Yellow
                    Else
                        Me.Indicator9.BackColor = Color.Green
                    End If
                Case "Z17   "
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(9)(0) = row.Item(2)
                    '  FPMMachWipHistDataSet.MachStat_FPM.Rows(8)(1) = row.Item(3)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(9)(2) = row.Item(4)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(9)(3) = row.Item(5)
                    If Blank_CntTextBox.Text < BarCount Then
                        Me.Indicator10.BackColor = Color.Yellow
                    Else
                        Me.Indicator10.BackColor = Color.Green
                    End If
                Case "Z18   "
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(10)(0) = row.Item(2)
                    '  FPMMachWipHistDataSet.MachStat_FPM.Rows(8)(1) = row.Item(3)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(10)(2) = row.Item(4)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(10)(3) = row.Item(5)
                    If Blank_CntTextBox.Text < BarCount Then
                        Me.Indicator11.BackColor = Color.Yellow
                    Else
                        Me.Indicator11.BackColor = Color.Green
                    End If
                Case "Z6    "
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(11)(0) = row.Item(2)
                    '  FPMMachWipHistDataSet.MachStat_FPM.Rows(8)(1) = row.Item(3)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(11)(2) = row.Item(4)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(11)(3) = row.Item(5)
                    If Blank_CntTextBox.Text < BarCount Then
                        Me.Indicator12.BackColor = Color.Yellow
                    Else
                        Me.Indicator12.BackColor = Color.Green
                    End If
                Case "Z7    "
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(12)(0) = row.Item(2)
                    '  FPMMachWipHistDataSet.MachStat_FPM.Rows(8)(1) = row.Item(3)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(12)(2) = row.Item(4)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(12)(3) = row.Item(5)
                    If Blank_CntTextBox.Text < BarCount Then
                        Me.Indicator13.BackColor = Color.Yellow
                    Else
                        Me.Indicator13.BackColor = Color.Green
                    End If
                Case "Z8    "
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(13)(0) = row.Item(2)
                    '  FPMMachWipHistDataSet.MachStat_FPM.Rows(8)(1) = row.Item(3)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(13)(2) = row.Item(4)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(13)(3) = row.Item(5)
                    If Blank_CntTextBox.Text < BarCount Then
                        Me.Indicator14.BackColor = Color.Yellow
                    Else
                        Me.Indicator14.BackColor = Color.Green
                    End If
                Case "Z9    "
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(14)(0) = row.Item(2)
                    '  FPMMachWipHistDataSet.MachStat_FPM.Rows(8)(1) = row.Item(3)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(14)(2) = row.Item(4)
                    FpmMachWipHistDataSet.MachStat_FPM.Rows(14)(3) = row.Item(5)
                    If Blank_CntTextBox.Text < BarCount Then
                        Me.Indicator15.BackColor = Color.Yellow
                    Else
                        Me.Indicator15.BackColor = Color.Green
                    End If

            End Select

            MachStat_FPMTableAdapter.Update(Me.FpmMachWipHistDataSet.MachStat_FPM)
            MachStat_FPMDataGridView.Refresh()

        Next

        ' Catch ex As Exception
        'Exit Sub
        'MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

        'End Try
    End Sub

End Class