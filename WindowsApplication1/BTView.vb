Public Class BTView

    Private Sub BT_QueBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

        Me.Validate()
        Me.BT_QueBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TBredDataDataSet5)

    End Sub

    Private Sub BTView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.OrderTBLTableAdapter.Fill(Me.TBredDataDataSet.OrderTBL)
        Me.MachStatTableAdapter.Fill(Me.MachWipHistDataSet2.MachStat)
        Me.WindowState = FormWindowState.Maximized
        Me.TbredBufferTableAdapter.Fill(Me.MachWipHistDataSet1.TbredBuffer)
        Me.BT_QueTableAdapter.Fill(Me.TBredDataDataSet5.BT_Que)
        BT_QueDataGridView.Sort(BT_QueDataGridView.Columns(2), System.ComponentModel.ListSortDirection.Ascending)

        Call Timer_Tick(sender, e)

    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Try
            Me.BT_QueTableAdapter.Fill(Me.TBredDataDataSet5.BT_Que)
            BT_QueDataGridView.Sort(BT_QueDataGridView.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
            BT_QueDataGridView.Refresh()
            Me.TbredBufferTableAdapter.Fill(Me.MachWipHistDataSet1.TbredBuffer)

            Dim bufferView As DataView = New DataView(MachWipHistDataSet1.TbredBuffer)

            For Each bufRow As DataRowView In bufferView
                Dim row As DataRow = bufRow.Row
                Dim test = Len(row.Item(3))
                Dim OrderPrecent As Integer
                Dim OrderNoQue As String = DirectCast(row, QueueManager.MachWipHistDataSet1.TbredBufferRow).OrderNo
                Dim BarCount As Integer = DirectCast(row, QueueManager.MachWipHistDataSet1.TbredBufferRow).PartCnt

                Me.OrderTBLTableAdapter.Fill(Me.TBredDataDataSet.OrderTBL)
                Me.OrderTBLBindingSource.Filter = "OrderNo='" & OrderNoQue & "'"
                ' if Position = 0 then record found, if position=-1 record not found
                If Me.OrderTBLBindingSource.Position = -1 Then 'Order Not Found

                End If

                Me.OrderNoTextBox.ForeColor = Color.White
                Me.Bar_CntTextBox.ForeColor = Color.White

                If Me.Bar_CntTextBox.Text = "" Then
                    Me.Bar_CntTextBox.Text = "0"
                End If

                OrderPrecent = Bar_CntTextBox.Text * 0.1
                Bar_CntTextBox.Text = Bar_CntTextBox.Text + OrderPrecent

                Select Case row.Item(3)

                    Case "BS1   "
                        MachWipHistDataSet2.MachStat.Rows(0)(0) = row.Item(2)
                        ' MachWipHistDataSet2.machstat.Rows(0)(1) = row.Item(3)
                        MachWipHistDataSet2.MachStat.Rows(0)(2) = row.Item(4)
                        MachWipHistDataSet2.MachStat.Rows(0)(3) = row.Item(5)
                        If Bar_CntTextBox.Text < BarCount Then
                            Me.Indicator1.BackColor = Color.Yellow
                        Else
                            Me.Indicator1.BackColor = Color.Green
                        End If
                    Case "BS2   "
                        MachWipHistDataSet2.MachStat.Rows(1)(0) = row.Item(2)
                        'MachWipHistDataSet2.machstat.Rows(1)(1) = row.Item(3)
                        MachWipHistDataSet2.MachStat.Rows(1)(2) = row.Item(4)
                        MachWipHistDataSet2.MachStat.Rows(1)(3) = row.Item(5)
                        If Bar_CntTextBox.Text < BarCount Then
                            Me.Indicator2.BackColor = Color.Yellow
                        Else
                            Me.Indicator2.BackColor = Color.Green
                        End If
                    Case "BT1   "
                        MachWipHistDataSet2.MachStat.Rows(2)(0) = row.Item(2)
                        ' MachWipHistDataSet2.machstat.Rows(2)(1) = row.Item(3)
                        MachWipHistDataSet2.MachStat.Rows(2)(2) = row.Item(4)
                        MachWipHistDataSet2.MachStat.Rows(2)(3) = row.Item(5)
                        If Bar_CntTextBox.Text < BarCount Then
                            Me.Indicator3.BackColor = Color.Yellow
                        Else
                            Me.Indicator3.BackColor = Color.Green
                        End If
                    Case "TG1   "
                        MachWipHistDataSet2.MachStat.Rows(3)(0) = row.Item(2)
                        ' MachWipHistDataSet2.machstat.Rows(3)(1) = row.Item(3)
                        MachWipHistDataSet2.MachStat.Rows(3)(2) = row.Item(4)
                        MachWipHistDataSet2.MachStat.Rows(3)(3) = row.Item(5)
                        If Bar_CntTextBox.Text < BarCount Then
                            Me.Indicator4.BackColor = Color.Yellow
                        Else
                            Me.Indicator4.BackColor = Color.Green
                        End If
                    Case "TG2   "
                        MachWipHistDataSet2.MachStat.Rows(4)(0) = row.Item(2)
                        ' MachWipHistDataSet2.machstat.Rows(4)(1) = row.Item(3)
                        MachWipHistDataSet2.MachStat.Rows(4)(2) = row.Item(4)
                        MachWipHistDataSet2.MachStat.Rows(4)(3) = row.Item(5)
                        If Bar_CntTextBox.Text < BarCount Then
                            Me.Indicator5.BackColor = Color.Yellow
                        Else
                            Me.Indicator5.BackColor = Color.Green
                        End If
                    Case "TG3   "
                        MachWipHistDataSet2.MachStat.Rows(5)(0) = row.Item(2)
                        '  MachWipHistDataSet2.machstat.Rows(5)(1) = row.Item(3)
                        MachWipHistDataSet2.MachStat.Rows(5)(2) = row.Item(4)
                        MachWipHistDataSet2.MachStat.Rows(5)(3) = row.Item(5)
                        If Bar_CntTextBox.Text < BarCount Then
                            Me.Indicator6.BackColor = Color.Yellow
                        Else
                            Me.Indicator6.BackColor = Color.Green
                        End If
                    Case "TG4   "
                        MachWipHistDataSet2.MachStat.Rows(6)(0) = row.Item(2)
                        '   MachWipHistDataSet2.machstat.Rows(6)(1) = row.Item(3)
                        MachWipHistDataSet2.MachStat.Rows(6)(2) = row.Item(4)
                        MachWipHistDataSet2.MachStat.Rows(6)(3) = row.Item(5)
                        If Bar_CntTextBox.Text < BarCount Then
                            Me.Indicator7.BackColor = Color.Yellow
                        Else
                            Me.Indicator7.BackColor = Color.Green
                        End If
                    Case "TG5   "
                        MachWipHistDataSet2.MachStat.Rows(7)(0) = row.Item(2)
                        '   MachWipHistDataSet2.machstat.Rows(7)(1) = row.Item(3)
                        MachWipHistDataSet2.MachStat.Rows(7)(2) = row.Item(4)
                        MachWipHistDataSet2.MachStat.Rows(7)(3) = row.Item(5)
                        If Bar_CntTextBox.Text < BarCount Then
                            Me.Indicator8.BackColor = Color.Yellow
                        Else
                            Me.Indicator8.BackColor = Color.Green
                        End If
                    Case "TG6   "
                        MachWipHistDataSet2.MachStat.Rows(8)(0) = row.Item(2)
                        '  MachWipHistDataSet2.machstat.Rows(8)(1) = row.Item(3)
                        MachWipHistDataSet2.MachStat.Rows(8)(2) = row.Item(4)
                        MachWipHistDataSet2.MachStat.Rows(8)(3) = row.Item(5)
                        If Bar_CntTextBox.Text < BarCount Then
                            Me.Indicator9.BackColor = Color.Yellow
                        Else
                            Me.Indicator9.BackColor = Color.Green
                        End If

                End Select
                MachStatTableAdapter.Update(Me.MachWipHistDataSet2.MachStat)
                MachStatDataGridView.Refresh()
            Next

        Catch ex As Exception
            Exit Sub
            'MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

End Class