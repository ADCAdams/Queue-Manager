<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPMManager
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
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FPMMachWipHistDataSet = New QueueManager.FPMMachWipHistDataSet()
        Me.MachStat_FPMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MachStat_FPMTableAdapter = New QueueManager.FPMMachWipHistDataSetTableAdapters.MachStat_FPMTableAdapter()
        Me.TableAdapterManager1 = New QueueManager.FPMMachWipHistDataSetTableAdapters.TableAdapterManager()
        Me.MachStat_FPMDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MachWipHistDataSet1 = New QueueManager.MachWipHistDataSet1()
        Me.TBredBufferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbredBufferTableAdapter = New QueueManager.MachWipHistDataSet1TableAdapters.TbredBufferTableAdapter()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OrderTBLDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarCnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderTBLBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FpmtBredDataDataSet = New QueueManager.FPMTBredDataDataSet()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FPM_QueDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderPriority = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cust = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MachIDsFPMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FPM_QueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.IHCTBredDataDataSet = New QueueManager.IHCTBredDataDataSet()
        Me.OrderTBLTableAdapter1 = New QueueManager.IHCTBredDataDataSetTableAdapters.OrderTBLTableAdapter()
        Me.TableAdapterManager2 = New QueueManager.IHCTBredDataDataSetTableAdapters.TableAdapterManager()
        Me.OrderTBLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderTBLTableAdapter = New QueueManager.FPMTBredDataDataSetTableAdapters.OrderTBLTableAdapter()
        Me.TableAdapterManager = New QueueManager.FPMTBredDataDataSetTableAdapters.TableAdapterManager()
        Me.FPM_QueTableAdapter = New QueueManager.FPMTBredDataDataSetTableAdapters.FPM_QueTableAdapter()
        Me.FpmtBredDataDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MachIDs_FPMTableAdapter = New QueueManager.FPMTBredDataDataSetTableAdapters.MachIDs_FPMTableAdapter()
        CType(Me.FPMMachWipHistDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachStat_FPMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachStat_FPMDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachWipHistDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBredBufferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderTBLDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderTBLBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FpmtBredDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FPM_QueDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachIDsFPMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FPM_QueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IHCTBredDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderTBLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FpmtBredDataDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(938, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'FPMMachWipHistDataSet
        '
        Me.FPMMachWipHistDataSet.DataSetName = "FPMMachWipHistDataSet"
        Me.FPMMachWipHistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MachStat_FPMBindingSource
        '
        Me.MachStat_FPMBindingSource.DataMember = "MachStat_FPM"
        Me.MachStat_FPMBindingSource.DataSource = Me.FPMMachWipHistDataSet
        '
        'MachStat_FPMTableAdapter
        '
        Me.MachStat_FPMTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.MachStat_FPMTableAdapter = Me.MachStat_FPMTableAdapter
        Me.TableAdapterManager1.UpdateOrder = QueueManager.FPMMachWipHistDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MachStat_FPMDataGridView
        '
        Me.MachStat_FPMDataGridView.AutoGenerateColumns = False
        Me.MachStat_FPMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MachStat_FPMDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.MachStat_FPMDataGridView.DataSource = Me.MachStat_FPMBindingSource
        Me.MachStat_FPMDataGridView.Location = New System.Drawing.Point(347, 474)
        Me.MachStat_FPMDataGridView.Name = "MachStat_FPMDataGridView"
        Me.MachStat_FPMDataGridView.ReadOnly = True
        Me.MachStat_FPMDataGridView.Size = New System.Drawing.Size(446, 374)
        Me.MachStat_FPMDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "OrderNo"
        Me.DataGridViewTextBoxColumn11.HeaderText = "OrderNo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Location"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "PartCnt"
        Me.DataGridViewTextBoxColumn13.HeaderText = "PartCnt"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "LastUpdated"
        DataGridViewCellStyle22.NullValue = Nothing
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridViewTextBoxColumn14.HeaderText = "LastUpdated"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
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
        Me.Timer.Interval = 15000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(525, 434)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Drag && Drop --->"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(797, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "FPM Order Queue"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(408, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "FPM Active Orders"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(108, 474)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(217, 102)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Manager Authorization"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(172, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 20
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(278, 21)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Snap To Order"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Exact Order #"
        '
        'OrderTBLDataGridView
        '
        Me.OrderTBLDataGridView.AutoGenerateColumns = False
        Me.OrderTBLDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderTBLDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn36, Me.BarCnt})
        Me.OrderTBLDataGridView.DataSource = Me.OrderTBLBindingSource1
        Me.OrderTBLDataGridView.Location = New System.Drawing.Point(29, 50)
        Me.OrderTBLDataGridView.Name = "OrderTBLDataGridView"
        Me.OrderTBLDataGridView.ReadOnly = True
        Me.OrderTBLDataGridView.Size = New System.Drawing.Size(540, 381)
        Me.OrderTBLDataGridView.TabIndex = 21
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Company No"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Comp. No"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "OrderNo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "OrderNo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 75
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cust ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cust ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 50
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Cust Name"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cust Name"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 130
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Cust Part No"
        Me.DataGridViewTextBoxColumn15.HeaderText = "PartNo"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 75
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Bar Diameter"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Diameter"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 60
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "UD DateTime"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        Me.DataGridViewTextBoxColumn36.Width = 60
        '
        'BarCnt
        '
        Me.BarCnt.DataPropertyName = "Bar Cnt"
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BarCnt.DefaultCellStyle = DataGridViewCellStyle23
        Me.BarCnt.HeaderText = "BarCnt"
        Me.BarCnt.Name = "BarCnt"
        Me.BarCnt.ReadOnly = True
        Me.BarCnt.Width = 30
        '
        'OrderTBLBindingSource1
        '
        Me.OrderTBLBindingSource1.DataMember = "OrderTBL"
        Me.OrderTBLBindingSource1.DataSource = Me.FpmtBredDataDataSet
        '
        'FpmtBredDataDataSet
        '
        Me.FpmtBredDataDataSet.DataSetName = "FPMTBredDataDataSet"
        Me.FpmtBredDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(938, 437)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(135, 23)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Save Changes"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(572, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 20)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "MANAGER MODE"
        Me.Label6.Visible = False
        '
        'FPM_QueDataGridView
        '
        Me.FPM_QueDataGridView.AutoGenerateColumns = False
        Me.FPM_QueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FPM_QueDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.OrderPriority, Me.DateDue, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn6, Me.Cust, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.FPM_QueDataGridView.DataSource = Me.FPM_QueBindingSource
        Me.FPM_QueDataGridView.Location = New System.Drawing.Point(576, 50)
        Me.FPM_QueDataGridView.Name = "FPM_QueDataGridView"
        Me.FPM_QueDataGridView.Size = New System.Drawing.Size(692, 381)
        Me.FPM_QueDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Priority"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridViewTextBoxColumn1.HeaderText = "Priority"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'OrderPriority
        '
        Me.OrderPriority.DataPropertyName = "OrderPriority"
        Me.OrderPriority.HeaderText = "OrderPriority"
        Me.OrderPriority.Name = "OrderPriority"
        Me.OrderPriority.Width = 50
        '
        'DateDue
        '
        Me.DateDue.DataPropertyName = "DateDue"
        Me.DateDue.HeaderText = "DateDue"
        Me.DateDue.Name = "DateDue"
        Me.DateDue.Width = 75
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CompanyNo"
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle25
        Me.DataGridViewTextBoxColumn2.HeaderText = "CompanyNo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 35
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "OrderNo"
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle26
        Me.DataGridViewTextBoxColumn6.HeaderText = "OrderNo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 60
        '
        'Cust
        '
        Me.Cust.DataPropertyName = "Cust"
        Me.Cust.HeaderText = "Customer"
        Me.Cust.Name = "Cust"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Diameter"
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle27
        Me.DataGridViewTextBoxColumn8.HeaderText = "Diameter"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 60
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Machine1"
        Me.DataGridViewTextBoxColumn9.DataSource = Me.MachIDsFPMBindingSource
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle28
        Me.DataGridViewTextBoxColumn9.DisplayMember = "MachID"
        Me.DataGridViewTextBoxColumn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DataGridViewTextBoxColumn9.HeaderText = "Machine1"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn9.ValueMember = "MachID"
        Me.DataGridViewTextBoxColumn9.Width = 60
        '
        'MachIDsFPMBindingSource
        '
        Me.MachIDsFPMBindingSource.DataMember = "MachIDs_FPM"
        Me.MachIDsFPMBindingSource.DataSource = Me.FpmtBredDataDataSet
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Machine2"
        Me.DataGridViewTextBoxColumn10.DataSource = Me.MachIDsFPMBindingSource
        Me.DataGridViewTextBoxColumn10.DisplayMember = "MachID"
        Me.DataGridViewTextBoxColumn10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DataGridViewTextBoxColumn10.HeaderText = "Machine2"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn10.ValueMember = "MachID"
        Me.DataGridViewTextBoxColumn10.Width = 60
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Machine3"
        Me.DataGridViewTextBoxColumn17.DataSource = Me.MachIDsFPMBindingSource
        Me.DataGridViewTextBoxColumn17.DisplayMember = "MachID"
        Me.DataGridViewTextBoxColumn17.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DataGridViewTextBoxColumn17.HeaderText = "Machine3"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn17.ValueMember = "MachID"
        Me.DataGridViewTextBoxColumn17.Width = 60
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Machine4"
        Me.DataGridViewTextBoxColumn18.DataSource = Me.MachIDsFPMBindingSource
        Me.DataGridViewTextBoxColumn18.DisplayMember = "MachID"
        Me.DataGridViewTextBoxColumn18.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DataGridViewTextBoxColumn18.HeaderText = "Machine4"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn18.ValueMember = "MachID"
        Me.DataGridViewTextBoxColumn18.Width = 60
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Machine5"
        Me.DataGridViewTextBoxColumn19.DataSource = Me.MachIDsFPMBindingSource
        Me.DataGridViewTextBoxColumn19.DisplayMember = "MachID"
        Me.DataGridViewTextBoxColumn19.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DataGridViewTextBoxColumn19.HeaderText = "Machine5"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn19.ValueMember = "MachID"
        Me.DataGridViewTextBoxColumn19.Width = 60
        '
        'FPM_QueBindingSource
        '
        Me.FPM_QueBindingSource.DataMember = "FPM_Que"
        Me.FPM_QueBindingSource.DataSource = Me.FpmtBredDataDataSet
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(140, 601)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(142, 61)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "Exit Manager Mode"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'IHCTBredDataDataSet
        '
        Me.IHCTBredDataDataSet.DataSetName = "IHCTBredDataDataSet"
        Me.IHCTBredDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderTBLTableAdapter1
        '
        Me.OrderTBLTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.IHC_QueTableAdapter = Nothing
        Me.TableAdapterManager2.MachIDs_IHCTableAdapter = Nothing
        Me.TableAdapterManager2.OrderTBLTableAdapter = Me.OrderTBLTableAdapter1
        Me.TableAdapterManager2.UpdateOrder = QueueManager.IHCTBredDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OrderTBLBindingSource
        '
        Me.OrderTBLBindingSource.DataMember = "OrderTBL"
        Me.OrderTBLBindingSource.DataSource = Me.FpmtBredDataDataSet
        '
        'OrderTBLTableAdapter
        '
        Me.OrderTBLTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FPM_QueTableAdapter = Me.FPM_QueTableAdapter
        Me.TableAdapterManager.MachIDs_FPMTableAdapter = Nothing
        Me.TableAdapterManager.OrderTBLTableAdapter = Me.OrderTBLTableAdapter
        Me.TableAdapterManager.UpdateOrder = QueueManager.FPMTBredDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FPM_QueTableAdapter
        '
        Me.FPM_QueTableAdapter.ClearBeforeFill = True
        '
        'FpmtBredDataDataSetBindingSource
        '
        Me.FpmtBredDataDataSetBindingSource.DataSource = Me.FpmtBredDataDataSet
        Me.FpmtBredDataDataSetBindingSource.Position = 0
        '
        'MachIDs_FPMTableAdapter
        '
        Me.MachIDs_FPMTableAdapter.ClearBeforeFill = True
        '
        'FPMManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1717, 924)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.FPM_QueDataGridView)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.OrderTBLDataGridView)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MachStat_FPMDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FPMManager"
        Me.Text = "FPM Queue Manager"
        CType(Me.FPMMachWipHistDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachStat_FPMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachStat_FPMDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachWipHistDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBredBufferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderTBLDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderTBLBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FpmtBredDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FPM_QueDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachIDsFPMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FPM_QueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IHCTBredDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderTBLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FpmtBredDataDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FpmtBredDataDataSet As QueueManager.FPMTBredDataDataSet
    Friend WithEvents OrderTBLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderTBLTableAdapter As QueueManager.FPMTBredDataDataSetTableAdapters.OrderTBLTableAdapter
    Friend WithEvents TableAdapterManager As QueueManager.FPMTBredDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FPM_QueTableAdapter As QueueManager.FPMTBredDataDataSetTableAdapters.FPM_QueTableAdapter
    Friend WithEvents FPM_QueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FPMMachWipHistDataSet As QueueManager.FPMMachWipHistDataSet
    Friend WithEvents MachStat_FPMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MachStat_FPMTableAdapter As QueueManager.FPMMachWipHistDataSetTableAdapters.MachStat_FPMTableAdapter
    Friend WithEvents TableAdapterManager1 As QueueManager.FPMMachWipHistDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MachStat_FPMDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MachWipHistDataSet1 As QueueManager.MachWipHistDataSet1
    Friend WithEvents TBredBufferBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbredBufferTableAdapter As QueueManager.MachWipHistDataSet1TableAdapters.TbredBufferTableAdapter
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents IHCTBredDataDataSet As QueueManager.IHCTBredDataDataSet
    Friend WithEvents OrderTBLBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents OrderTBLTableAdapter1 As QueueManager.IHCTBredDataDataSetTableAdapters.OrderTBLTableAdapter
    Friend WithEvents TableAdapterManager2 As QueueManager.IHCTBredDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrderTBLDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FpmtBredDataDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FPM_QueDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MachIDsFPMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MachIDs_FPMTableAdapter As QueueManager.FPMTBredDataDataSetTableAdapters.MachIDs_FPMTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BarCnt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderPriority As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cust As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
