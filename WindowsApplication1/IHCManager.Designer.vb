<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IHCManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IHC_QueDataGridView = New System.Windows.Forms.DataGridView()
        Me.IhcMachWipHistDataSet = New QueueManager.IHCMachWipHistDataSet()
        Me.MachStat_IHCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MachStat_IHCTableAdapter = New QueueManager.IHCMachWipHistDataSetTableAdapters.MachStat_IHCTableAdapter()
        Me.TableAdapterManager1 = New QueueManager.IHCMachWipHistDataSetTableAdapters.TableAdapterManager()
        Me.MachStat_IHCDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MachWipHistDataSet1 = New QueueManager.MachWipHistDataSet1()
        Me.TBredBufferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbredBufferTableAdapter = New QueueManager.MachWipHistDataSet1TableAdapters.TbredBufferTableAdapter()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.OrderTBLDataGridView = New System.Windows.Forms.DataGridView()
        Me.CompanyNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarDiameterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarCntDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UDDateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderTBLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IhctBredDataDataSet = New QueueManager.IHCTBredDataDataSet()
        Me.MachIDsIHCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IHC_QueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IHCMachIDsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IHC_QueTableAdapter = New QueueManager.IHCTBredDataDataSetTableAdapters.IHC_QueTableAdapter()
        Me.TableAdapterManager = New QueueManager.IHCTBredDataDataSetTableAdapters.TableAdapterManager()
        Me.MachIDs_IHCTableAdapter = New QueueManager.IHCTBredDataDataSetTableAdapters.MachIDs_IHCTableAdapter()
        Me.OrderTBLTableAdapter = New QueueManager.IHCTBredDataDataSetTableAdapters.OrderTBLTableAdapter()
        Me.PriorityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderPriority = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScheduleDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HardenDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cust = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiameterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Machine1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Machine2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Machine3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Machine4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Machine5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.IHC_QueDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IhcMachWipHistDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachStat_IHCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachStat_IHCDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachWipHistDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBredBufferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        CType(Me.OrderTBLDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderTBLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IhctBredDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachIDsIHCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IHC_QueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IHCMachIDsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(820, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'IHC_QueDataGridView
        '
        Me.IHC_QueDataGridView.AutoGenerateColumns = False
        Me.IHC_QueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IHC_QueDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PriorityDataGridViewTextBoxColumn, Me.OrderPriority, Me.ScheduleDate, Me.DateDue, Me.HardenDate, Me.OrderNoDataGridViewTextBoxColumn, Me.Cust, Me.DiameterDataGridViewTextBoxColumn, Me.Machine1, Me.Machine2, Me.Machine3, Me.Machine4, Me.Machine5})
        Me.IHC_QueDataGridView.DataSource = Me.IHC_QueBindingSource
        Me.IHC_QueDataGridView.Location = New System.Drawing.Point(478, 45)
        Me.IHC_QueDataGridView.Name = "IHC_QueDataGridView"
        Me.IHC_QueDataGridView.Size = New System.Drawing.Size(719, 451)
        Me.IHC_QueDataGridView.TabIndex = 2
        '
        'IhcMachWipHistDataSet
        '
        Me.IhcMachWipHistDataSet.DataSetName = "IHCMachWipHistDataSet"
        Me.IhcMachWipHistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MachStat_IHCBindingSource
        '
        Me.MachStat_IHCBindingSource.DataMember = "MachStat_IHC"
        Me.MachStat_IHCBindingSource.DataSource = Me.IhcMachWipHistDataSet
        '
        'MachStat_IHCTableAdapter
        '
        Me.MachStat_IHCTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.MachStat_IHCTableAdapter = Me.MachStat_IHCTableAdapter
        Me.TableAdapterManager1.UpdateOrder = QueueManager.IHCMachWipHistDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MachStat_IHCDataGridView
        '
        Me.MachStat_IHCDataGridView.AutoGenerateColumns = False
        Me.MachStat_IHCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MachStat_IHCDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.MachStat_IHCDataGridView.DataSource = Me.MachStat_IHCBindingSource
        Me.MachStat_IHCDataGridView.Location = New System.Drawing.Point(263, 535)
        Me.MachStat_IHCDataGridView.Name = "MachStat_IHCDataGridView"
        Me.MachStat_IHCDataGridView.Size = New System.Drawing.Size(450, 336)
        Me.MachStat_IHCDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "OrderNo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "OrderNo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Location"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "PartCnt"
        Me.DataGridViewTextBoxColumn13.HeaderText = "PartCnt"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "LastUpdated"
        Me.DataGridViewTextBoxColumn14.HeaderText = "LastUpdated"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'MachWipHistDataSet1
        '
        Me.MachWipHistDataSet1.DataSetName = "MachWipHistDataSet1"
        Me.MachWipHistDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBredBufferBindingSource
        '
        Me.TBredBufferBindingSource.DataMember = "TbredBuffer"
        Me.TBredBufferBindingSource.DataSource = Me.MachWipHistDataSet1
        '
        'TbredBufferTableAdapter
        '
        Me.TbredBufferTableAdapter.ClearBeforeFill = True
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 30000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(427, 499)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Drag && Drop --->"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(649, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "IHC Order Queue"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(331, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "IHC Active Orders"
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1380, 25)
        Me.FillByToolStrip.TabIndex = 12
        Me.FillByToolStrip.Text = "FillByToolStrip"
        Me.FillByToolStrip.Visible = False
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(14, 535)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(217, 102)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Manager Authorization"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(215, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Snap To Order"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(109, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Exact Order #"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(820, 502)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(114, 23)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Save Changes"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(474, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "MANAGER MODE"
        Me.Label6.Visible = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(53, 664)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(142, 61)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "Exit Manager Mode"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'OrderTBLDataGridView
        '
        Me.OrderTBLDataGridView.AutoGenerateColumns = False
        Me.OrderTBLDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderTBLDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CompanyNoDataGridViewTextBoxColumn1, Me.OrderNoDataGridViewTextBoxColumn1, Me.CustIDDataGridViewTextBoxColumn, Me.CustNameDataGridViewTextBoxColumn, Me.BarDiameterDataGridViewTextBoxColumn, Me.BarCntDataGridViewTextBoxColumn, Me.UDDateTimeDataGridViewTextBoxColumn})
        Me.OrderTBLDataGridView.DataSource = Me.OrderTBLBindingSource
        Me.OrderTBLDataGridView.Location = New System.Drawing.Point(12, 46)
        Me.OrderTBLDataGridView.Name = "OrderTBLDataGridView"
        Me.OrderTBLDataGridView.ReadOnly = True
        Me.OrderTBLDataGridView.Size = New System.Drawing.Size(458, 450)
        Me.OrderTBLDataGridView.TabIndex = 25
        '
        'CompanyNoDataGridViewTextBoxColumn
        '
        Me.CompanyNoDataGridViewTextBoxColumn.DataPropertyName = "Company No"
        Me.CompanyNoDataGridViewTextBoxColumn.HeaderText = "Company No"
        Me.CompanyNoDataGridViewTextBoxColumn.Name = "CompanyNoDataGridViewTextBoxColumn"
        Me.CompanyNoDataGridViewTextBoxColumn.Visible = False
        '
        'CompanyNoDataGridViewTextBoxColumn1
        '
        Me.CompanyNoDataGridViewTextBoxColumn1.DataPropertyName = "Company No"
        Me.CompanyNoDataGridViewTextBoxColumn1.HeaderText = "Company No"
        Me.CompanyNoDataGridViewTextBoxColumn1.Name = "CompanyNoDataGridViewTextBoxColumn1"
        Me.CompanyNoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CompanyNoDataGridViewTextBoxColumn1.Visible = False
        '
        'OrderNoDataGridViewTextBoxColumn1
        '
        Me.OrderNoDataGridViewTextBoxColumn1.DataPropertyName = "OrderNo"
        Me.OrderNoDataGridViewTextBoxColumn1.HeaderText = "OrderNo"
        Me.OrderNoDataGridViewTextBoxColumn1.Name = "OrderNoDataGridViewTextBoxColumn1"
        Me.OrderNoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.OrderNoDataGridViewTextBoxColumn1.Width = 70
        '
        'CustIDDataGridViewTextBoxColumn
        '
        Me.CustIDDataGridViewTextBoxColumn.DataPropertyName = "Cust ID"
        Me.CustIDDataGridViewTextBoxColumn.HeaderText = "Cust ID"
        Me.CustIDDataGridViewTextBoxColumn.Name = "CustIDDataGridViewTextBoxColumn"
        Me.CustIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustIDDataGridViewTextBoxColumn.Width = 70
        '
        'CustNameDataGridViewTextBoxColumn
        '
        Me.CustNameDataGridViewTextBoxColumn.DataPropertyName = "Cust Name"
        Me.CustNameDataGridViewTextBoxColumn.HeaderText = "Cust Name"
        Me.CustNameDataGridViewTextBoxColumn.Name = "CustNameDataGridViewTextBoxColumn"
        Me.CustNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BarDiameterDataGridViewTextBoxColumn
        '
        Me.BarDiameterDataGridViewTextBoxColumn.DataPropertyName = "Bar Diameter"
        Me.BarDiameterDataGridViewTextBoxColumn.HeaderText = "Bar Diameter"
        Me.BarDiameterDataGridViewTextBoxColumn.Name = "BarDiameterDataGridViewTextBoxColumn"
        Me.BarDiameterDataGridViewTextBoxColumn.ReadOnly = True
        Me.BarDiameterDataGridViewTextBoxColumn.Width = 60
        '
        'BarCntDataGridViewTextBoxColumn
        '
        Me.BarCntDataGridViewTextBoxColumn.DataPropertyName = "Bar Cnt"
        Me.BarCntDataGridViewTextBoxColumn.HeaderText = "Bar Cnt"
        Me.BarCntDataGridViewTextBoxColumn.Name = "BarCntDataGridViewTextBoxColumn"
        Me.BarCntDataGridViewTextBoxColumn.ReadOnly = True
        Me.BarCntDataGridViewTextBoxColumn.Width = 40
        '
        'UDDateTimeDataGridViewTextBoxColumn
        '
        Me.UDDateTimeDataGridViewTextBoxColumn.DataPropertyName = "UD DateTime"
        Me.UDDateTimeDataGridViewTextBoxColumn.HeaderText = "UD DateTime"
        Me.UDDateTimeDataGridViewTextBoxColumn.Name = "UDDateTimeDataGridViewTextBoxColumn"
        Me.UDDateTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.UDDateTimeDataGridViewTextBoxColumn.Width = 65
        '
        'OrderTBLBindingSource
        '
        Me.OrderTBLBindingSource.DataMember = "OrderTBL"
        Me.OrderTBLBindingSource.DataSource = Me.IhctBredDataDataSet
        '
        'IhctBredDataDataSet
        '
        Me.IhctBredDataDataSet.DataSetName = "IHCTBredDataDataSet"
        Me.IhctBredDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MachIDsIHCBindingSource
        '
        Me.MachIDsIHCBindingSource.DataMember = "MachIDs_IHC"
        Me.MachIDsIHCBindingSource.DataSource = Me.IhctBredDataDataSet
        '
        'IHC_QueBindingSource
        '
        Me.IHC_QueBindingSource.DataMember = "IHC_Que"
        Me.IHC_QueBindingSource.DataSource = Me.IhctBredDataDataSet
        '
        'IHCMachIDsBindingSource
        '
        Me.IHCMachIDsBindingSource.DataMember = "MachIDs_IHC"
        Me.IHCMachIDsBindingSource.DataSource = Me.IhctBredDataDataSet
        '
        'IHC_QueTableAdapter
        '
        Me.IHC_QueTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.IHC_QueTableAdapter = Me.IHC_QueTableAdapter
        Me.TableAdapterManager.MachIDs_IHCTableAdapter = Me.MachIDs_IHCTableAdapter
        Me.TableAdapterManager.OrderTBLTableAdapter = Me.OrderTBLTableAdapter
        Me.TableAdapterManager.UpdateOrder = QueueManager.IHCTBredDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MachIDs_IHCTableAdapter
        '
        Me.MachIDs_IHCTableAdapter.ClearBeforeFill = True
        '
        'OrderTBLTableAdapter
        '
        Me.OrderTBLTableAdapter.ClearBeforeFill = True
        '
        'PriorityDataGridViewTextBoxColumn
        '
        Me.PriorityDataGridViewTextBoxColumn.DataPropertyName = "Priority"
        Me.PriorityDataGridViewTextBoxColumn.HeaderText = "Priority"
        Me.PriorityDataGridViewTextBoxColumn.Name = "PriorityDataGridViewTextBoxColumn"
        Me.PriorityDataGridViewTextBoxColumn.Visible = False
        Me.PriorityDataGridViewTextBoxColumn.Width = 30
        '
        'OrderPriority
        '
        Me.OrderPriority.DataPropertyName = "OrderPriority"
        Me.OrderPriority.FillWeight = 25.0!
        Me.OrderPriority.HeaderText = "Order Priority"
        Me.OrderPriority.Name = "OrderPriority"
        Me.OrderPriority.Width = 20
        '
        'ScheduleDate
        '
        Me.ScheduleDate.DataPropertyName = "ScheduleDate"
        Me.ScheduleDate.HeaderText = "Finish Date"
        Me.ScheduleDate.Name = "ScheduleDate"
        Me.ScheduleDate.Width = 60
        '
        'DateDue
        '
        Me.DateDue.DataPropertyName = "DateDue"
        Me.DateDue.HeaderText = "Schedule Date"
        Me.DateDue.Name = "DateDue"
        Me.DateDue.Width = 60
        '
        'HardenDate
        '
        Me.HardenDate.DataPropertyName = "HardenDate"
        Me.HardenDate.HeaderText = "HardenDate"
        Me.HardenDate.Name = "HardenDate"
        Me.HardenDate.Visible = False
        Me.HardenDate.Width = 70
        '
        'OrderNoDataGridViewTextBoxColumn
        '
        Me.OrderNoDataGridViewTextBoxColumn.DataPropertyName = "OrderNo"
        Me.OrderNoDataGridViewTextBoxColumn.HeaderText = "Order No"
        Me.OrderNoDataGridViewTextBoxColumn.Name = "OrderNoDataGridViewTextBoxColumn"
        Me.OrderNoDataGridViewTextBoxColumn.Width = 60
        '
        'Cust
        '
        Me.Cust.DataPropertyName = "Cust"
        Me.Cust.HeaderText = "Cust"
        Me.Cust.Name = "Cust"
        Me.Cust.Width = 60
        '
        'DiameterDataGridViewTextBoxColumn
        '
        Me.DiameterDataGridViewTextBoxColumn.DataPropertyName = "Diameter"
        Me.DiameterDataGridViewTextBoxColumn.HeaderText = "Diameter"
        Me.DiameterDataGridViewTextBoxColumn.Name = "DiameterDataGridViewTextBoxColumn"
        Me.DiameterDataGridViewTextBoxColumn.Width = 47
        '
        'Machine1
        '
        Me.Machine1.DataPropertyName = "Machine1"
        Me.Machine1.DataSource = Me.MachIDsIHCBindingSource
        Me.Machine1.DisplayMember = "MachID"
        Me.Machine1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Machine1.HeaderText = "Mach 1"
        Me.Machine1.Name = "Machine1"
        Me.Machine1.ReadOnly = True
        Me.Machine1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Machine1.ToolTipText = "Double Click to Set Defaults Machines"
        Me.Machine1.ValueMember = "MachID"
        Me.Machine1.Width = 57
        '
        'Machine2
        '
        Me.Machine2.DataPropertyName = "Machine2"
        Me.Machine2.DataSource = Me.MachIDsIHCBindingSource
        Me.Machine2.DisplayMember = "MachID"
        Me.Machine2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Machine2.HeaderText = "Mach 2"
        Me.Machine2.Name = "Machine2"
        Me.Machine2.ReadOnly = True
        Me.Machine2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Machine2.ValueMember = "MachID"
        Me.Machine2.Width = 57
        '
        'Machine3
        '
        Me.Machine3.DataPropertyName = "Machine3"
        Me.Machine3.DataSource = Me.MachIDsIHCBindingSource
        Me.Machine3.DisplayMember = "MachID"
        Me.Machine3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Machine3.HeaderText = "Mach 3"
        Me.Machine3.Name = "Machine3"
        Me.Machine3.ReadOnly = True
        Me.Machine3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Machine3.ValueMember = "MachID"
        Me.Machine3.Width = 57
        '
        'Machine4
        '
        Me.Machine4.DataPropertyName = "Machine4"
        Me.Machine4.DataSource = Me.MachIDsIHCBindingSource
        Me.Machine4.DisplayMember = "MachID"
        Me.Machine4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Machine4.HeaderText = "Mach 4"
        Me.Machine4.Name = "Machine4"
        Me.Machine4.ReadOnly = True
        Me.Machine4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Machine4.ValueMember = "MachID"
        Me.Machine4.Width = 57
        '
        'Machine5
        '
        Me.Machine5.DataPropertyName = "Machine5"
        Me.Machine5.DataSource = Me.MachIDsIHCBindingSource
        Me.Machine5.DisplayMember = "MachID"
        Me.Machine5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Machine5.HeaderText = "Mach 5"
        Me.Machine5.Name = "Machine5"
        Me.Machine5.ReadOnly = True
        Me.Machine5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Machine5.ValueMember = "MachID"
        Me.Machine5.Width = 57
        '
        'IHCManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1701, 991)
        Me.Controls.Add(Me.OrderTBLDataGridView)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MachStat_IHCDataGridView)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.IHC_QueDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Name = "IHCManager"
        Me.Text = "IHC Queue Manager"
        CType(Me.IHC_QueDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IhcMachWipHistDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachStat_IHCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachStat_IHCDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachWipHistDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBredBufferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        CType(Me.OrderTBLDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderTBLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IhctBredDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachIDsIHCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IHC_QueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IHCMachIDsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents IhctBredDataDataSet As QueueManager.IHCTBredDataDataSet
    Friend WithEvents IHC_QueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IHC_QueTableAdapter As QueueManager.IHCTBredDataDataSetTableAdapters.IHC_QueTableAdapter
    Friend WithEvents TableAdapterManager As QueueManager.IHCTBredDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrderTBLTableAdapter As QueueManager.IHCTBredDataDataSetTableAdapters.OrderTBLTableAdapter
    Friend WithEvents IHC_QueDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IhcMachWipHistDataSet As QueueManager.IHCMachWipHistDataSet
    Friend WithEvents MachStat_IHCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MachStat_IHCTableAdapter As QueueManager.IHCMachWipHistDataSetTableAdapters.MachStat_IHCTableAdapter
    Friend WithEvents TableAdapterManager1 As QueueManager.IHCMachWipHistDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MachStat_IHCDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MachIDs_IHCTableAdapter As QueueManager.IHCTBredDataDataSetTableAdapters.MachIDs_IHCTableAdapter
    Friend WithEvents IHCMachIDsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MachWipHistDataSet1 As QueueManager.MachWipHistDataSet1
    Friend WithEvents TBredBufferBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbredBufferTableAdapter As QueueManager.MachWipHistDataSet1TableAdapters.TbredBufferTableAdapter
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MachIDsIHCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents OrderTBLDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents OrderTBLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompanyNoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderNoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BarDiameterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BarCntDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UDDateTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriorityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderPriority As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ScheduleDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HardenDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cust As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiameterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Machine1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Machine2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Machine3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Machine4 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Machine5 As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
