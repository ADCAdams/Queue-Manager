<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BTManager
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BTManager))
        Me.BTOrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.PriorityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderPriority = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cust = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diameter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Machine1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MachIDsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBredDataDataSet31 = New QueueManager.TBredDataDataSet3()
        Me.Machine2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MachIDsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Machine3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MachIDsBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Machine4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MachIDsBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Machine5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MachIDsBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BTQBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBredDataDataSet5 = New QueueManager.TBredDataDataSet5()
        Me.machIDsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BT_OrderQueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MachineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderTBLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBredDataDataSet = New QueueManager.TBredDataDataSet()
        Me.OrderTBLTableAdapter = New QueueManager.TBredDataDataSetTableAdapters.OrderTBLTableAdapter()
        Me.BTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBredDataDataSet4 = New QueueManager.TBredDataDataSet4()
        Me.BTOrderQueTableAdapter = New QueueManager.TBredDataDataSet2TableAdapters.BT_OrderQueTableAdapter()
        Me.OrderTBLBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MachIDsTableAdapter = New QueueManager.TBredDataDataSet3TableAdapters.MachIDsTableAdapter()
        Me.BT_OrderQueTableAdapter = New QueueManager.TBredDataDataSet4TableAdapters.BT_OrderQueTableAdapter()
        Me.TableAdapterManager = New QueueManager.TBredDataDataSetTableAdapters.TableAdapterManager()
        Me.MachWipHistDataSet = New QueueManager.MachWipHistDataSet()
        Me.MachStatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MachWipHistDataSet2 = New QueueManager.MachWipHistDataSet2()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MachWipHistDataSet1 = New QueueManager.MachWipHistDataSet1()
        Me.TBredBufferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbredBufferTableAdapter = New QueueManager.MachWipHistDataSet1TableAdapters.TbredBufferTableAdapter()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.MachStatTableAdapter = New QueueManager.MachWipHistDataSet2TableAdapters.MachStatTableAdapter()
        Me.TableAdapterManager1 = New QueueManager.MachWipHistDataSet2TableAdapters.TableAdapterManager()
        Me.MachStatDataGridView = New System.Windows.Forms.DataGridView()
        Me.OrderNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartCntDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastUpdatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OrderTBLDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BTQTableAdapter = New QueueManager.TBredDataDataSet5TableAdapters.BT_QueTableAdapter()
        CType(Me.BTOrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachIDsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBredDataDataSet31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachIDsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachIDsBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachIDsBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachIDsBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTQBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBredDataDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.machIDsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BT_OrderQueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderTBLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBredDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBredDataDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderTBLBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachWipHistDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachStatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachWipHistDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachWipHistDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBredBufferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachStatDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderTBLDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTOrderDataGridView
        '
        Me.BTOrderDataGridView.AutoGenerateColumns = False
        Me.BTOrderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BTOrderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PriorityDataGridViewTextBoxColumn, Me.CompanyNoDataGridViewTextBoxColumn1, Me.OrderPriority, Me.DateDue, Me.OrderNoDataGridViewTextBoxColumn1, Me.Cust, Me.Diameter, Me.Machine1, Me.Machine2, Me.Machine3, Me.Machine4, Me.Machine5})
        Me.BTOrderDataGridView.DataSource = Me.BTQBindingSource
        Me.BTOrderDataGridView.Location = New System.Drawing.Point(597, 48)
        Me.BTOrderDataGridView.Name = "BTOrderDataGridView"
        Me.BTOrderDataGridView.Size = New System.Drawing.Size(710, 381)
        Me.BTOrderDataGridView.TabIndex = 1
        '
        'PriorityDataGridViewTextBoxColumn
        '
        Me.PriorityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PriorityDataGridViewTextBoxColumn.DataPropertyName = "Priority"
        Me.PriorityDataGridViewTextBoxColumn.FillWeight = 30.0!
        Me.PriorityDataGridViewTextBoxColumn.HeaderText = "Priority"
        Me.PriorityDataGridViewTextBoxColumn.Name = "PriorityDataGridViewTextBoxColumn"
        Me.PriorityDataGridViewTextBoxColumn.Visible = False
        '
        'CompanyNoDataGridViewTextBoxColumn1
        '
        Me.CompanyNoDataGridViewTextBoxColumn1.DataPropertyName = "CompanyNo"
        Me.CompanyNoDataGridViewTextBoxColumn1.FillWeight = 53.73894!
        Me.CompanyNoDataGridViewTextBoxColumn1.HeaderText = "CompanyNo"
        Me.CompanyNoDataGridViewTextBoxColumn1.Name = "CompanyNoDataGridViewTextBoxColumn1"
        Me.CompanyNoDataGridViewTextBoxColumn1.Visible = False
        '
        'OrderPriority
        '
        Me.OrderPriority.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.OrderPriority.DataPropertyName = "OrderPriority"
        Me.OrderPriority.FillWeight = 80.69527!
        Me.OrderPriority.HeaderText = "OrderPriority"
        Me.OrderPriority.Name = "OrderPriority"
        Me.OrderPriority.Width = 45
        '
        'DateDue
        '
        Me.DateDue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DateDue.DataPropertyName = "DateDue"
        Me.DateDue.FillWeight = 163.7056!
        Me.DateDue.HeaderText = "DateDue"
        Me.DateDue.Name = "DateDue"
        Me.DateDue.Width = 75
        '
        'OrderNoDataGridViewTextBoxColumn1
        '
        Me.OrderNoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.OrderNoDataGridViewTextBoxColumn1.DataPropertyName = "OrderNo"
        Me.OrderNoDataGridViewTextBoxColumn1.FillWeight = 55.66019!
        Me.OrderNoDataGridViewTextBoxColumn1.HeaderText = "OrderNo"
        Me.OrderNoDataGridViewTextBoxColumn1.Name = "OrderNoDataGridViewTextBoxColumn1"
        Me.OrderNoDataGridViewTextBoxColumn1.Width = 80
        '
        'Cust
        '
        Me.Cust.DataPropertyName = "Cust"
        Me.Cust.HeaderText = "Cust"
        Me.Cust.Name = "Cust"
        '
        'Diameter
        '
        Me.Diameter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Diameter.DataPropertyName = "Diameter"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Diameter.DefaultCellStyle = DataGridViewCellStyle1
        Me.Diameter.FillWeight = 56.52766!
        Me.Diameter.HeaderText = "Diameter"
        Me.Diameter.Name = "Diameter"
        Me.Diameter.Width = 75
        '
        'Machine1
        '
        Me.Machine1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Machine1.DataPropertyName = "Machine1"
        Me.Machine1.DataSource = Me.MachIDsBindingSource1
        Me.Machine1.DisplayMember = "MachID"
        Me.Machine1.FillWeight = 14.68226!
        Me.Machine1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Machine1.HeaderText = "Machine1"
        Me.Machine1.Name = "Machine1"
        Me.Machine1.ReadOnly = True
        Me.Machine1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Machine1.ToolTipText = "Double Click to Set Defaults Machines"
        Me.Machine1.ValueMember = "MachID"
        Me.Machine1.Width = 60
        '
        'MachIDsBindingSource1
        '
        Me.MachIDsBindingSource1.DataMember = "MachIDs"
        Me.MachIDsBindingSource1.DataSource = Me.TBredDataDataSet31
        '
        'TBredDataDataSet31
        '
        Me.TBredDataDataSet31.DataSetName = "TBredDataDataSet3"
        Me.TBredDataDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Machine2
        '
        Me.Machine2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Machine2.DataPropertyName = "Machine2"
        Me.Machine2.DataSource = Me.MachIDsBindingSource2
        Me.Machine2.DisplayMember = "MachID"
        Me.Machine2.FillWeight = 14.68226!
        Me.Machine2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Machine2.HeaderText = "Machine2"
        Me.Machine2.Name = "Machine2"
        Me.Machine2.ReadOnly = True
        Me.Machine2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Machine2.ValueMember = "MachID"
        Me.Machine2.Width = 60
        '
        'MachIDsBindingSource2
        '
        Me.MachIDsBindingSource2.DataMember = "MachIDs"
        Me.MachIDsBindingSource2.DataSource = Me.TBredDataDataSet31
        '
        'Machine3
        '
        Me.Machine3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Machine3.DataPropertyName = "Machine3"
        Me.Machine3.DataSource = Me.MachIDsBindingSource3
        Me.Machine3.DisplayMember = "MachID"
        Me.Machine3.FillWeight = 14.68226!
        Me.Machine3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Machine3.HeaderText = "Machine3"
        Me.Machine3.Name = "Machine3"
        Me.Machine3.ReadOnly = True
        Me.Machine3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Machine3.ValueMember = "MachID"
        Me.Machine3.Width = 60
        '
        'MachIDsBindingSource3
        '
        Me.MachIDsBindingSource3.DataMember = "MachIDs"
        Me.MachIDsBindingSource3.DataSource = Me.TBredDataDataSet31
        '
        'Machine4
        '
        Me.Machine4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Machine4.DataPropertyName = "Machine4"
        Me.Machine4.DataSource = Me.MachIDsBindingSource4
        Me.Machine4.DisplayMember = "MachID"
        Me.Machine4.FillWeight = 14.68226!
        Me.Machine4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Machine4.HeaderText = "Machine4"
        Me.Machine4.Name = "Machine4"
        Me.Machine4.ReadOnly = True
        Me.Machine4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Machine4.ValueMember = "MachID"
        Me.Machine4.Width = 60
        '
        'MachIDsBindingSource4
        '
        Me.MachIDsBindingSource4.DataMember = "MachIDs"
        Me.MachIDsBindingSource4.DataSource = Me.TBredDataDataSet31
        '
        'Machine5
        '
        Me.Machine5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Machine5.DataPropertyName = "Machine5"
        Me.Machine5.DataSource = Me.MachIDsBindingSource5
        Me.Machine5.DisplayMember = "MachID"
        Me.Machine5.FillWeight = 14.68226!
        Me.Machine5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Machine5.HeaderText = "Machine5"
        Me.Machine5.Name = "Machine5"
        Me.Machine5.ReadOnly = True
        Me.Machine5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Machine5.ValueMember = "MachID"
        Me.Machine5.Width = 60
        '
        'MachIDsBindingSource5
        '
        Me.MachIDsBindingSource5.DataMember = "MachIDs"
        Me.MachIDsBindingSource5.DataSource = Me.TBredDataDataSet31
        '
        'BTQBindingSource
        '
        Me.BTQBindingSource.DataMember = "BT_Que"
        Me.BTQBindingSource.DataSource = Me.TBredDataDataSet5
        '
        'TBredDataDataSet5
        '
        Me.TBredDataDataSet5.DataSetName = "TBredDataDataSet5"
        Me.TBredDataDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'machIDsBindingSource
        '
        Me.machIDsBindingSource.DataMember = "MachIDs"
        Me.machIDsBindingSource.DataSource = Me.TBredDataDataSet31
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(943, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'MachineDataGridViewTextBoxColumn
        '
        Me.MachineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MachineDataGridViewTextBoxColumn.DataPropertyName = "Machine"
        Me.MachineDataGridViewTextBoxColumn.HeaderText = "Machine"
        Me.MachineDataGridViewTextBoxColumn.Name = "MachineDataGridViewTextBoxColumn"
        Me.MachineDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MachineDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(448, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "BT Active Orders"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(807, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "BT Order Queue"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Bar Diameter"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Bar Diameter"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'OrderTBLBindingSource
        '
        Me.OrderTBLBindingSource.DataMember = "OrderTBL"
        Me.OrderTBLBindingSource.DataSource = Me.TBredDataDataSet
        '
        'TBredDataDataSet
        '
        Me.TBredDataDataSet.DataSetName = "TBredDataDataSet"
        Me.TBredDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderTBLTableAdapter
        '
        Me.OrderTBLTableAdapter.ClearBeforeFill = True
        '
        'BTBindingSource
        '
        Me.BTBindingSource.DataMember = "BT-OrderQue"
        Me.BTBindingSource.DataSource = Me.TBredDataDataSet4
        '
        'TBredDataDataSet4
        '
        Me.TBredDataDataSet4.DataSetName = "TBredDataDataSet4"
        Me.TBredDataDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BTOrderQueTableAdapter
        '
        Me.BTOrderQueTableAdapter.ClearBeforeFill = True
        '
        'OrderTBLBindingSource1
        '
        Me.OrderTBLBindingSource1.DataMember = "OrderTBL"
        Me.OrderTBLBindingSource1.DataSource = Me.TBredDataDataSet
        '
        'MachIDsTableAdapter
        '
        Me.MachIDsTableAdapter.ClearBeforeFill = True
        '
        'BT_OrderQueTableAdapter
        '
        Me.BT_OrderQueTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.OrderTBLTableAdapter = Me.OrderTBLTableAdapter
        Me.TableAdapterManager.UpdateOrder = QueueManager.TBredDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MachWipHistDataSet
        '
        Me.MachWipHistDataSet.DataSetName = "MachWipHistDataSet"
        Me.MachWipHistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MachStatBindingSource
        '
        Me.MachStatBindingSource.DataMember = "MachStat"
        Me.MachStatBindingSource.DataSource = Me.MachWipHistDataSet2
        '
        'MachWipHistDataSet2
        '
        Me.MachWipHistDataSet2.DataSetName = "MachWipHistDataSet2"
        Me.MachWipHistDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "OrderNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "OrderNo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Location"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PartCnt"
        Me.DataGridViewTextBoxColumn9.HeaderText = "PartCnt"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "LastUpdated"
        Me.DataGridViewTextBoxColumn10.HeaderText = "LastUpdated"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
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
        'MachStatTableAdapter
        '
        Me.MachStatTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.MachStatTableAdapter = Me.MachStatTableAdapter
        Me.TableAdapterManager1.UpdateOrder = QueueManager.MachWipHistDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MachStatDataGridView
        '
        Me.MachStatDataGridView.AutoGenerateColumns = False
        Me.MachStatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MachStatDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderNoDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.PartCntDataGridViewTextBoxColumn, Me.LastUpdatedDataGridViewTextBoxColumn})
        Me.MachStatDataGridView.DataSource = Me.MachStatBindingSource
        Me.MachStatDataGridView.Location = New System.Drawing.Point(367, 467)
        Me.MachStatDataGridView.Name = "MachStatDataGridView"
        Me.MachStatDataGridView.Size = New System.Drawing.Size(448, 255)
        Me.MachStatDataGridView.TabIndex = 5
        '
        'OrderNoDataGridViewTextBoxColumn
        '
        Me.OrderNoDataGridViewTextBoxColumn.DataPropertyName = "OrderNo"
        Me.OrderNoDataGridViewTextBoxColumn.HeaderText = "OrderNo"
        Me.OrderNoDataGridViewTextBoxColumn.Name = "OrderNoDataGridViewTextBoxColumn"
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        '
        'PartCntDataGridViewTextBoxColumn
        '
        Me.PartCntDataGridViewTextBoxColumn.DataPropertyName = "PartCnt"
        Me.PartCntDataGridViewTextBoxColumn.HeaderText = "PartCnt"
        Me.PartCntDataGridViewTextBoxColumn.Name = "PartCntDataGridViewTextBoxColumn"
        '
        'LastUpdatedDataGridViewTextBoxColumn
        '
        Me.LastUpdatedDataGridViewTextBoxColumn.DataPropertyName = "LastUpdated"
        Me.LastUpdatedDataGridViewTextBoxColumn.HeaderText = "LastUpdated"
        Me.LastUpdatedDataGridViewTextBoxColumn.Name = "LastUpdatedDataGridViewTextBoxColumn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(543, 432)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Drag && Drop --->"
        '
        'OrderTBLDataGridView
        '
        Me.OrderTBLDataGridView.AutoGenerateColumns = False
        Me.OrderTBLDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderTBLDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn32})
        Me.OrderTBLDataGridView.DataSource = Me.OrderTBLBindingSource
        Me.OrderTBLDataGridView.Location = New System.Drawing.Point(29, 48)
        Me.OrderTBLDataGridView.Name = "OrderTBLDataGridView"
        Me.OrderTBLDataGridView.Size = New System.Drawing.Size(557, 381)
        Me.OrderTBLDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Company No"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Company No"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "OrderNo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "OrderNo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Cust ID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cust ID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 65
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Cust Name"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cust Name"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Bar Diameter"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Bar Diameter"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 75
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "UD DateTime"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.Width = 75
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(123, 467)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(217, 102)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Manager Authorization"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(175, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 18
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(281, 18)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Snap To Order"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Exact Order #"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(943, 435)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 27)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Save Changes"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(593, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 20)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "MANAGER MODE"
        Me.Label6.Visible = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(155, 594)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(142, 61)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "Exit Manager Mode"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'BTQTableAdapter
        '
        Me.BTQTableAdapter.ClearBeforeFill = True
        '
        'BTManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1647, 899)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.OrderTBLDataGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MachStatDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTOrderDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BTManager"
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bar Tech Queue Manager"
        CType(Me.BTOrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachIDsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBredDataDataSet31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachIDsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachIDsBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachIDsBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachIDsBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTQBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBredDataDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.machIDsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BT_OrderQueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderTBLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBredDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBredDataDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderTBLBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachWipHistDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachStatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachWipHistDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachWipHistDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBredBufferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachStatDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderTBLDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBredDataDataSet As QueueManager.TBredDataDataSet
    Friend WithEvents OrderTBLTableAdapter As QueueManager.TBredDataDataSetTableAdapters.OrderTBLTableAdapter
    Friend WithEvents OrderTBLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BT_OrderQueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BTOrderQueTableAdapter As QueueManager.TBredDataDataSet2TableAdapters.BT_OrderQueTableAdapter
    Friend WithEvents BTOrderDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OrderTBLBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MachineDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TBredDataDataSet31 As QueueManager.TBredDataDataSet3
    Friend WithEvents machIDsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MachIDsTableAdapter As QueueManager.TBredDataDataSet3TableAdapters.MachIDsTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBredDataDataSet4 As QueueManager.TBredDataDataSet4
    Friend WithEvents BTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BT_OrderQueTableAdapter As QueueManager.TBredDataDataSet4TableAdapters.BT_OrderQueTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As QueueManager.TBredDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TBredDataDataSet5 As QueueManager.TBredDataDataSet5
    Friend WithEvents BTQBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BTQTableAdapter As QueueManager.TBredDataDataSet5TableAdapters.BT_QueTableAdapter
    Friend WithEvents MachWipHistDataSet As QueueManager.MachWipHistDataSet
    Friend WithEvents MachStatBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents MachStatTableAdapter As WindowsApplication1.MachWipHistDataSetTableAdapters.MachStatTableAdapter
    'Friend WithEvents TableAdapterManager1 As WindowsApplication1.MachWipHistDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MachWipHistDataSet1 As QueueManager.MachWipHistDataSet1
    Friend WithEvents TBredBufferBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbredBufferTableAdapter As QueueManager.MachWipHistDataSet1TableAdapters.TbredBufferTableAdapter
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents MachWipHistDataSet2 As QueueManager.MachWipHistDataSet2
    Friend WithEvents MachStatTableAdapter As QueueManager.MachWipHistDataSet2TableAdapters.MachStatTableAdapter
    Friend WithEvents TableAdapterManager1 As QueueManager.MachWipHistDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents MachStatDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents OrderNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PartCntDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastUpdatedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OrderTBLDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents MachIDsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MachIDsBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents MachIDsBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents MachIDsBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents MachIDsBindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriorityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompanyNoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderPriority As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderNoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cust As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diameter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Machine1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Machine2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Machine3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Machine4 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Machine5 As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
