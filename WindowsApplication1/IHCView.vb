Public Class IHCView

    Private Sub IHCView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.OrderTBLTableAdapter1.Fill(Me.TBredDataDataSetIHCView.OrderTBL)
        Me.OrderTBLTableAdapter.Fill(Me.IhctBredDataDataSet.OrderTBL)

        Me.WindowState = FormWindowState.Maximized
        Me.TbredBufferTableAdapter.Fill(Me.MachWipHistDataSet1.TbredBuffer)
        Me.MachStat_IHCTableAdapter.Fill(Me.IhcMachWipHistDataSet.MachStat_IHC)
        Me.IHC_QueTableAdapter.Fill(Me.IhctBredDataDataSet.IHC_Que)
        IHC_QueDataGridView.Sort(IHC_QueDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

        Call Timer_Tick(sender, e)

    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Try

            Me.TbredBufferTableAdapter.Fill(Me.MachWipHistDataSet1.TbredBuffer)
            Me.IHC_QueTableAdapter.Fill(Me.IhctBredDataDataSet.IHC_Que)

            IHC_QueDataGridView.Sort(IHC_QueDataGridView.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
            IHC_QueDataGridView.Refresh()

            Dim bufferView As DataView = New DataView(MachWipHistDataSet1.TbredBuffer)

            For Each bufRow As DataRowView In bufferView
                Dim row As DataRow = bufRow.Row
                Dim test = Len(row.Item(3))
                Dim OrderPrecent As Integer
                Dim OrderNoQue As String = DirectCast(row, QueueManager.MachWipHistDataSet1.TbredBufferRow).OrderNo
                Dim BarCount As Integer = DirectCast(row, QueueManager.MachWipHistDataSet1.TbredBufferRow).PartCnt

                Me.OrderTBLTableAdapter1.Fill(Me.TBredDataDataSetIHCView.OrderTBL)
                Me.OrderTBLBindingSource1.Filter = "OrderNo='" & OrderNoQue & "'"
                ' if Position = 0 then record found, if position=-1 record not found
                If Me.OrderTBLBindingSource1.Position = -1 Then 'Order Not Found

                End If

                Me.OrderNoTextBox.ForeColor = Color.White
                Me.Bar_CntTextBox.ForeColor = Color.White

                If Me.Bar_CntTextBox.Text = "" Then
                    Me.Bar_CntTextBox.Text = "0"
                End If

                OrderPrecent = Bar_CntTextBox.Text * 0.1
                Bar_CntTextBox.Text = Bar_CntTextBox.Text + OrderPrecent

                Select Case row.Item(3)

                    Case "H1    "
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(0)(0) = row.Item(2)
                        ' IHCMachWipHistDataSet.MachStat_IHC.Rows(0)(1) = row.Item(3)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(0)(2) = row.Item(4)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(0)(3) = row.Item(5)
                        If Bar_CntTextBox.Text < BarCount Then
                            Me.Indicator1.BackColor = Color.Yellow
                        Else
                            Me.Indicator1.BackColor = Color.Green
                        End If
                    Case "H3    "
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(1)(0) = row.Item(2)
                        'IHCMachWipHistDataSet.MachStat_IHC.Rows(1)(1) = row.Item(3)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(1)(2) = row.Item(4)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(1)(3) = row.Item(5)
                        If Bar_CntTextBox.Text < BarCount Then
                            Me.Indicator2.BackColor = Color.Yellow
                        Else
                            Me.Indicator2.BackColor = Color.Green
                        End If
                    Case "P10   "
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(2)(0) = row.Item(2)
                        ' IHCMachWipHistDataSet.MachStat_IHC.Rows(2)(1) = row.Item(3)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(2)(2) = row.Item(4)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(2)(3) = row.Item(5)
                        If Bar_CntTextBox.Text < BarCount Then
                            Me.Indicator3.BackColor = Color.Yellow
                        Else
                            Me.Indicator3.BackColor = Color.Green
                        End If
                    Case "P11   "
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(3)(0) = row.Item(2)
                        ' IHCMachWipHistDataSet.MachStat_IHC.Rows(2)(1) = row.Item(3)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(3)(2) = row.Item(4)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(3)(3) = row.Item(5)
                        If Bar_CntTextBox.Text < BarCount Then
                            Me.Indicator4.BackColor = Color.Yellow
                        Else
                            Me.Indicator4.BackColor = Color.Green
                        End If
                    Case "P12   "
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(4)(0) = row.Item(2)
                        ' IHCMachWipHistDataSet.MachStat_IHC.Rows(3)(1) = row.Item(3)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(4)(2) = row.Item(4)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(4)(3) = row.Item(5)
                        If Bar_CntTextBox.Text < BarCount Then
                            Me.Indicator5.BackColor = Color.Yellow
                        Else
                            Me.Indicator5.BackColor = Color.Green
                        End If
                    Case "P19   "
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(5)(0) = row.Item(2)
                        ' IHCMachWipHistDataSet.MachStat_IHC.Rows(4)(1) = row.Item(3)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(5)(2) = row.Item(4)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(5)(3) = row.Item(5)
                        If Bar_CntTextBox.Text < BarCount Then
                            Me.Indicator6.BackColor = Color.Yellow
                        Else
                            Me.Indicator6.BackColor = Color.Green
                        End If
                    Case "P14   "
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(6)(0) = row.Item(2)
                        '  IHCMachWipHistDataSet.MachStat_IHC.Rows(5)(1) = row.Item(3)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(6)(2) = row.Item(4)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(6)(3) = row.Item(5)
                        If Bar_CntTextBox.Text < BarCount Then
                            Me.Indicator7.BackColor = Color.Yellow
                        Else
                            Me.Indicator7.BackColor = Color.Green
                        End If
                    Case "P15   "
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(7)(0) = row.Item(2)
                        '   IHCMachWipHistDataSet.MachStat_IHC.Rows(6)(1) = row.Item(3)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(7)(2) = row.Item(4)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(7)(3) = row.Item(5)
                        If Bar_CntTextBox.Text < BarCount Then
                            Me.Indicator8.BackColor = Color.Yellow
                        Else
                            Me.Indicator8.BackColor = Color.Green
                        End If
                    Case "P16   "
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(8)(0) = row.Item(2)
                        '   IHCMachWipHistDataSet.MachStat_IHC.Rows(7)(1) = row.Item(3)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(8)(2) = row.Item(4)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(8)(3) = row.Item(5)
                        If Bar_CntTextBox.Text < BarCount Then
                            Me.Indicator9.BackColor = Color.Yellow
                        Else
                            Me.Indicator9.BackColor = Color.Green
                        End If
                    Case "P17   "
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(9)(0) = row.Item(2)
                        '  IHCMachWipHistDataSet.MachStat_IHC.Rows(8)(1) = row.Item(3)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(9)(2) = row.Item(4)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(9)(3) = row.Item(5)
                        If Bar_CntTextBox.Text < BarCount Then
                            Me.Indicator10.BackColor = Color.Yellow
                        Else
                            Me.Indicator10.BackColor = Color.Green
                        End If
                    Case "P7    "
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(10)(0) = row.Item(2)
                        '  IHCMachWipHistDataSet.MachStat_IHC.Rows(8)(1) = row.Item(3)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(10)(2) = row.Item(4)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(10)(3) = row.Item(5)
                        If Bar_CntTextBox.Text < BarCount Then
                            Me.Indicator11.BackColor = Color.Yellow
                        Else
                            Me.Indicator11.BackColor = Color.Green
                        End If
                    Case "PL2   "
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(11)(0) = row.Item(2)
                        '  IHCMachWipHistDataSet.MachStat_IHC.Rows(8)(1) = row.Item(3)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(11)(2) = row.Item(4)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(11)(3) = row.Item(5)
                        If Bar_CntTextBox.Text < BarCount Then
                            Me.Indicator12.BackColor = Color.Yellow
                        Else
                            Me.Indicator12.BackColor = Color.Green
                        End If
                    Case "PLE   "
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(12)(0) = row.Item(2)
                        '  IHCMachWipHistDataSet.MachStat_IHC.Rows(8)(1) = row.Item(3)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(12)(2) = row.Item(4)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(12)(3) = row.Item(5)
                        If Bar_CntTextBox.Text < BarCount Then
                            Me.Indicator13.BackColor = Color.Yellow
                        Else
                            Me.Indicator13.BackColor = Color.Green
                        End If
                    Case "PLW   "
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(13)(0) = row.Item(2)
                        '  IHCMachWipHistDataSet.MachStat_IHC.Rows(8)(1) = row.Item(3)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(13)(2) = row.Item(4)
                        IhcMachWipHistDataSet.MachStat_IHC.Rows(13)(3) = row.Item(5)
                        If Bar_CntTextBox.Text < BarCount Then
                            Me.Indicator14.BackColor = Color.Yellow
                        Else
                            Me.Indicator14.BackColor = Color.Green
                        End If

                End Select
                MachStat_IHCTableAdapter.Update(Me.IhcMachWipHistDataSet.MachStat_IHC)
                MachStat_IHCDataGridView.Refresh()
            Next

        Catch ex As Exception
            Exit Sub
            'MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    
End Class