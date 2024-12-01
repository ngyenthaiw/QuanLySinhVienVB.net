<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pnTab = New System.Windows.Forms.Panel()
        Me.btDMHP = New System.Windows.Forms.Button()
        Me.btDMLop = New System.Windows.Forms.Button()
        Me.btDMDHP = New System.Windows.Forms.Button()
        Me.btDMSV = New System.Windows.Forms.Button()
        Me.btDMKhoa = New System.Windows.Forms.Button()
        Me.pnDMDHP = New System.Windows.Forms.Panel()
        Me.TTDHPBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TTDHPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet14 = New Quan_li_sinh_vien.DataSet1()
        Me.BindingNavigatorCountItem4 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem4 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem4 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem4 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem4 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem4 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.pnDMDHPbot = New System.Windows.Forms.Panel()
        Me.btInDMDHP = New System.Windows.Forms.Button()
        Me.btTimKiemDMDHP = New System.Windows.Forms.Button()
        Me.btThoatDMDHP = New System.Windows.Forms.Button()
        Me.btXoaDMDHP = New System.Windows.Forms.Button()
        Me.btSuaDMDHP = New System.Windows.Forms.Button()
        Me.btThemDMDHP = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDiemHPDMDHP = New System.Windows.Forms.TextBox()
        Me.txtMaHPDMDHP = New System.Windows.Forms.TextBox()
        Me.txtMaSVDMDHP = New System.Windows.Forms.TextBox()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.MaSinhVienDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaHocPhanDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiemHocPhanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnDMSV = New System.Windows.Forms.Panel()
        Me.TTSVBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TTSVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet12 = New Quan_li_sinh_vien.DataSet1()
        Me.BindingNavigatorCountItem2 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem2 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.pnDMSVbot = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbNu = New System.Windows.Forms.RadioButton()
        Me.rbNam = New System.Windows.Forms.RadioButton()
        Me.btInDMSV = New System.Windows.Forms.Button()
        Me.btTimKiemDMSV = New System.Windows.Forms.Button()
        Me.btThoatDMSV = New System.Windows.Forms.Button()
        Me.btXoaDMSV = New System.Windows.Forms.Button()
        Me.btSuaDMSV = New System.Windows.Forms.Button()
        Me.btThemDMSV = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDiaChiDMSV = New System.Windows.Forms.TextBox()
        Me.txtNgaySinhDMSV = New System.Windows.Forms.TextBox()
        Me.txtMaKhoaDMSV = New System.Windows.Forms.TextBox()
        Me.txtHoTenDMSV = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaSVDMSV = New System.Windows.Forms.TextBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.MaSinhVienDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoTenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaKhoaDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioiTinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaySinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnDMKhoa = New System.Windows.Forms.Panel()
        Me.TTKhoaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TTKhoaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Quan_li_sinh_vien.DataSet1()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.pnDMKhoabot = New System.Windows.Forms.Panel()
        Me.btInDMKhoa = New System.Windows.Forms.Button()
        Me.btTimKiemDMKhoa = New System.Windows.Forms.Button()
        Me.btThoatDMKhoa = New System.Windows.Forms.Button()
        Me.btXoaDMKhoa = New System.Windows.Forms.Button()
        Me.btSuaDMKhoa = New System.Windows.Forms.Button()
        Me.btThemDMKhoa = New System.Windows.Forms.Button()
        Me.txtTenKhoaDMK = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMaKhoaDMK = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MaKhoaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenKhoaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnDMLop = New System.Windows.Forms.Panel()
        Me.pnDMLopbot = New System.Windows.Forms.Panel()
        Me.TTLopBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TTLopBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New Quan_li_sinh_vien.DataSet1()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btThoatDMLop = New System.Windows.Forms.Button()
        Me.btInDMLop = New System.Windows.Forms.Button()
        Me.btTimKiemDMLop = New System.Windows.Forms.Button()
        Me.btXoaDMLop = New System.Windows.Forms.Button()
        Me.btSuaDMLop = New System.Windows.Forms.Button()
        Me.txtNamNhapHocDML = New System.Windows.Forms.TextBox()
        Me.txtHeDTDML = New System.Windows.Forms.TextBox()
        Me.txtKhoaHocDML = New System.Windows.Forms.TextBox()
        Me.txtMaKhoaDML = New System.Windows.Forms.TextBox()
        Me.txtTenLopDML = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btThemDMLop = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMaLopDML = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.MaLopDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenLopDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaKhoaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KhoaHocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeDaoTaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamNhapHocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnDMHocPhan = New System.Windows.Forms.Panel()
        Me.TTHPBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TTHPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet13 = New Quan_li_sinh_vien.DataSet1()
        Me.BindingNavigatorCountItem3 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem3 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.pnDMHocPhanbot = New System.Windows.Forms.Panel()
        Me.btThoatDMHP = New System.Windows.Forms.Button()
        Me.btInDMHP = New System.Windows.Forms.Button()
        Me.btTimKiemDMHP = New System.Windows.Forms.Button()
        Me.btXoaDMHP = New System.Windows.Forms.Button()
        Me.btSuaDMHP = New System.Windows.Forms.Button()
        Me.txtHocKyDMHP = New System.Windows.Forms.TextBox()
        Me.txtMaKhoaDMHP = New System.Windows.Forms.TextBox()
        Me.txtSoTCDMHP = New System.Windows.Forms.TextBox()
        Me.txtTenHPDMHP = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.sd = New System.Windows.Forms.Label()
        Me.qưe = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtMaHPDMHP = New System.Windows.Forms.TextBox()
        Me.btThemDMHP = New System.Windows.Forms.Button()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.MaHocPhanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenHocPhanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoTinChiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaKhoaDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HocKyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter3 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter4 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand5 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand5 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter5 = New System.Data.OleDb.OleDbDataAdapter()
        Me.DM_KhoaTableAdapter = New Quan_li_sinh_vien.DataSet1TableAdapters.DM_KhoaTableAdapter()
        Me.DM_LopTableAdapter = New Quan_li_sinh_vien.DataSet1TableAdapters.DM_LopTableAdapter()
        Me.DM_SinhVienTableAdapter = New Quan_li_sinh_vien.DataSet1TableAdapters.DM_SinhVienTableAdapter()
        Me.DM_HocPhanTableAdapter = New Quan_li_sinh_vien.DataSet1TableAdapters.DM_HocPhanTableAdapter()
        Me.DM_DiemHocPhanTableAdapter = New Quan_li_sinh_vien.DataSet1TableAdapters.DM_DiemHocPhanTableAdapter()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnTab.SuspendLayout()
        Me.pnDMDHP.SuspendLayout()
        CType(Me.TTDHPBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TTDHPBindingNavigator.SuspendLayout()
        CType(Me.TTDHPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnDMDHPbot.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnDMSV.SuspendLayout()
        CType(Me.TTSVBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TTSVBindingNavigator.SuspendLayout()
        CType(Me.TTSVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnDMSVbot.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnDMKhoa.SuspendLayout()
        CType(Me.TTKhoaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TTKhoaBindingNavigator.SuspendLayout()
        CType(Me.TTKhoaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnDMKhoabot.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnDMLop.SuspendLayout()
        Me.pnDMLopbot.SuspendLayout()
        CType(Me.TTLopBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TTLopBindingNavigator.SuspendLayout()
        CType(Me.TTLopBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnDMHocPhan.SuspendLayout()
        CType(Me.TTHPBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TTHPBindingNavigator.SuspendLayout()
        CType(Me.TTHPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnDMHocPhanbot.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnTab
        '
        Me.pnTab.BackColor = System.Drawing.Color.Silver
        Me.pnTab.Controls.Add(Me.btDMHP)
        Me.pnTab.Controls.Add(Me.btDMLop)
        Me.pnTab.Controls.Add(Me.btDMDHP)
        Me.pnTab.Controls.Add(Me.btDMSV)
        Me.pnTab.Controls.Add(Me.btDMKhoa)
        Me.pnTab.Location = New System.Drawing.Point(13, 12)
        Me.pnTab.Name = "pnTab"
        Me.pnTab.Size = New System.Drawing.Size(900, 140)
        Me.pnTab.TabIndex = 0
        '
        'btDMHP
        '
        Me.btDMHP.BackColor = System.Drawing.Color.Black
        Me.btDMHP.FlatAppearance.BorderSize = 3
        Me.btDMHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDMHP.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDMHP.ForeColor = System.Drawing.Color.White
        Me.btDMHP.Location = New System.Drawing.Point(554, 3)
        Me.btDMHP.Name = "btDMHP"
        Me.btDMHP.Size = New System.Drawing.Size(163, 134)
        Me.btDMHP.TabIndex = 4
        Me.btDMHP.Text = "Danh Mục Học Phần"
        Me.btDMHP.UseVisualStyleBackColor = False
        '
        'btDMLop
        '
        Me.btDMLop.BackColor = System.Drawing.Color.Black
        Me.btDMLop.FlatAppearance.BorderSize = 3
        Me.btDMLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDMLop.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDMLop.ForeColor = System.Drawing.Color.White
        Me.btDMLop.Location = New System.Drawing.Point(188, 3)
        Me.btDMLop.Name = "btDMLop"
        Me.btDMLop.Size = New System.Drawing.Size(178, 134)
        Me.btDMLop.TabIndex = 3
        Me.btDMLop.Text = "Danh Mục Lớp"
        Me.btDMLop.UseVisualStyleBackColor = False
        '
        'btDMDHP
        '
        Me.btDMDHP.BackColor = System.Drawing.Color.Black
        Me.btDMDHP.FlatAppearance.BorderSize = 3
        Me.btDMDHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDMDHP.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDMDHP.ForeColor = System.Drawing.Color.White
        Me.btDMDHP.Location = New System.Drawing.Point(723, 3)
        Me.btDMDHP.Name = "btDMDHP"
        Me.btDMDHP.Size = New System.Drawing.Size(173, 134)
        Me.btDMDHP.TabIndex = 2
        Me.btDMDHP.Text = "Danh Mục Điểm Học Phần"
        Me.btDMDHP.UseVisualStyleBackColor = False
        '
        'btDMSV
        '
        Me.btDMSV.BackColor = System.Drawing.Color.Black
        Me.btDMSV.FlatAppearance.BorderSize = 3
        Me.btDMSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDMSV.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDMSV.ForeColor = System.Drawing.Color.White
        Me.btDMSV.Location = New System.Drawing.Point(372, 3)
        Me.btDMSV.Name = "btDMSV"
        Me.btDMSV.Size = New System.Drawing.Size(176, 134)
        Me.btDMSV.TabIndex = 1
        Me.btDMSV.Text = "Danh Mục Sinh Viên"
        Me.btDMSV.UseVisualStyleBackColor = False
        '
        'btDMKhoa
        '
        Me.btDMKhoa.BackColor = System.Drawing.Color.Black
        Me.btDMKhoa.FlatAppearance.BorderSize = 3
        Me.btDMKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDMKhoa.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDMKhoa.ForeColor = System.Drawing.Color.White
        Me.btDMKhoa.Location = New System.Drawing.Point(3, 3)
        Me.btDMKhoa.Name = "btDMKhoa"
        Me.btDMKhoa.Size = New System.Drawing.Size(179, 134)
        Me.btDMKhoa.TabIndex = 0
        Me.btDMKhoa.Text = "Danh Mục Khoa"
        Me.btDMKhoa.UseVisualStyleBackColor = False
        '
        'pnDMDHP
        '
        Me.pnDMDHP.BackColor = System.Drawing.Color.Silver
        Me.pnDMDHP.Controls.Add(Me.TTDHPBindingNavigator)
        Me.pnDMDHP.Controls.Add(Me.pnDMDHPbot)
        Me.pnDMDHP.Controls.Add(Me.DataGridView5)
        Me.pnDMDHP.Location = New System.Drawing.Point(12, 158)
        Me.pnDMDHP.Name = "pnDMDHP"
        Me.pnDMDHP.Size = New System.Drawing.Size(901, 473)
        Me.pnDMDHP.TabIndex = 1
        '
        'TTDHPBindingNavigator
        '
        Me.TTDHPBindingNavigator.AddNewItem = Nothing
        Me.TTDHPBindingNavigator.BackColor = System.Drawing.Color.Silver
        Me.TTDHPBindingNavigator.BindingSource = Me.TTDHPBindingSource
        Me.TTDHPBindingNavigator.CountItem = Me.BindingNavigatorCountItem4
        Me.TTDHPBindingNavigator.CountItemFormat = "/{0}"
        Me.TTDHPBindingNavigator.DeleteItem = Nothing
        Me.TTDHPBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TTDHPBindingNavigator.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.TTDHPBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem4, Me.BindingNavigatorMovePreviousItem4, Me.BindingNavigatorSeparator12, Me.BindingNavigatorPositionItem4, Me.BindingNavigatorCountItem4, Me.BindingNavigatorSeparator13, Me.BindingNavigatorMoveNextItem4, Me.BindingNavigatorMoveLastItem4, Me.BindingNavigatorSeparator14})
        Me.TTDHPBindingNavigator.Location = New System.Drawing.Point(0, 441)
        Me.TTDHPBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem4
        Me.TTDHPBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem4
        Me.TTDHPBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem4
        Me.TTDHPBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem4
        Me.TTDHPBindingNavigator.Name = "TTDHPBindingNavigator"
        Me.TTDHPBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem4
        Me.TTDHPBindingNavigator.Size = New System.Drawing.Size(901, 32)
        Me.TTDHPBindingNavigator.TabIndex = 5
        Me.TTDHPBindingNavigator.Text = "BindingNavigator1"
        '
        'TTDHPBindingSource
        '
        Me.TTDHPBindingSource.DataMember = "DM_DiemHocPhan"
        Me.TTDHPBindingSource.DataSource = Me.DataSet14
        '
        'DataSet14
        '
        Me.DataSet14.DataSetName = "DataSet1"
        Me.DataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem4
        '
        Me.BindingNavigatorCountItem4.Name = "BindingNavigatorCountItem4"
        Me.BindingNavigatorCountItem4.Size = New System.Drawing.Size(33, 29)
        Me.BindingNavigatorCountItem4.Text = "/{0}"
        Me.BindingNavigatorCountItem4.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem4
        '
        Me.BindingNavigatorMoveFirstItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem4.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem4.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem4.Name = "BindingNavigatorMoveFirstItem4"
        Me.BindingNavigatorMoveFirstItem4.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem4.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMoveFirstItem4.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem4
        '
        Me.BindingNavigatorMovePreviousItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem4.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem4.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem4.Name = "BindingNavigatorMovePreviousItem4"
        Me.BindingNavigatorMovePreviousItem4.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem4.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMovePreviousItem4.Text = "Move previous"
        '
        'BindingNavigatorSeparator12
        '
        Me.BindingNavigatorSeparator12.Name = "BindingNavigatorSeparator12"
        Me.BindingNavigatorSeparator12.Size = New System.Drawing.Size(6, 32)
        '
        'BindingNavigatorPositionItem4
        '
        Me.BindingNavigatorPositionItem4.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem4.AutoSize = False
        Me.BindingNavigatorPositionItem4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem4.Name = "BindingNavigatorPositionItem4"
        Me.BindingNavigatorPositionItem4.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem4.Text = "0"
        Me.BindingNavigatorPositionItem4.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator13
        '
        Me.BindingNavigatorSeparator13.Name = "BindingNavigatorSeparator13"
        Me.BindingNavigatorSeparator13.Size = New System.Drawing.Size(6, 32)
        '
        'BindingNavigatorMoveNextItem4
        '
        Me.BindingNavigatorMoveNextItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem4.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem4.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem4.Name = "BindingNavigatorMoveNextItem4"
        Me.BindingNavigatorMoveNextItem4.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem4.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMoveNextItem4.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem4
        '
        Me.BindingNavigatorMoveLastItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem4.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem4.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem4.Name = "BindingNavigatorMoveLastItem4"
        Me.BindingNavigatorMoveLastItem4.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem4.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMoveLastItem4.Text = "Move last"
        '
        'BindingNavigatorSeparator14
        '
        Me.BindingNavigatorSeparator14.Name = "BindingNavigatorSeparator14"
        Me.BindingNavigatorSeparator14.Size = New System.Drawing.Size(6, 32)
        '
        'pnDMDHPbot
        '
        Me.pnDMDHPbot.BackColor = System.Drawing.Color.White
        Me.pnDMDHPbot.Controls.Add(Me.btInDMDHP)
        Me.pnDMDHPbot.Controls.Add(Me.btTimKiemDMDHP)
        Me.pnDMDHPbot.Controls.Add(Me.btThoatDMDHP)
        Me.pnDMDHPbot.Controls.Add(Me.btXoaDMDHP)
        Me.pnDMDHPbot.Controls.Add(Me.btSuaDMDHP)
        Me.pnDMDHPbot.Controls.Add(Me.btThemDMDHP)
        Me.pnDMDHPbot.Controls.Add(Me.Label11)
        Me.pnDMDHPbot.Controls.Add(Me.Label10)
        Me.pnDMDHPbot.Controls.Add(Me.Label9)
        Me.pnDMDHPbot.Controls.Add(Me.txtDiemHPDMDHP)
        Me.pnDMDHPbot.Controls.Add(Me.txtMaHPDMDHP)
        Me.pnDMDHPbot.Controls.Add(Me.txtMaSVDMDHP)
        Me.pnDMDHPbot.Location = New System.Drawing.Point(4, 229)
        Me.pnDMDHPbot.Name = "pnDMDHPbot"
        Me.pnDMDHPbot.Size = New System.Drawing.Size(893, 235)
        Me.pnDMDHPbot.TabIndex = 1
        '
        'btInDMDHP
        '
        Me.btInDMDHP.BackColor = System.Drawing.Color.Black
        Me.btInDMDHP.FlatAppearance.BorderSize = 2
        Me.btInDMDHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btInDMDHP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInDMDHP.ForeColor = System.Drawing.Color.White
        Me.btInDMDHP.Location = New System.Drawing.Point(623, 102)
        Me.btInDMDHP.Name = "btInDMDHP"
        Me.btInDMDHP.Size = New System.Drawing.Size(104, 39)
        Me.btInDMDHP.TabIndex = 11
        Me.btInDMDHP.Text = "In "
        Me.btInDMDHP.UseVisualStyleBackColor = False
        '
        'btTimKiemDMDHP
        '
        Me.btTimKiemDMDHP.BackColor = System.Drawing.Color.Black
        Me.btTimKiemDMDHP.FlatAppearance.BorderSize = 2
        Me.btTimKiemDMDHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btTimKiemDMDHP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTimKiemDMDHP.ForeColor = System.Drawing.Color.White
        Me.btTimKiemDMDHP.Location = New System.Drawing.Point(467, 102)
        Me.btTimKiemDMDHP.Name = "btTimKiemDMDHP"
        Me.btTimKiemDMDHP.Size = New System.Drawing.Size(104, 39)
        Me.btTimKiemDMDHP.TabIndex = 10
        Me.btTimKiemDMDHP.Text = "Tìm kiếm"
        Me.btTimKiemDMDHP.UseVisualStyleBackColor = False
        '
        'btThoatDMDHP
        '
        Me.btThoatDMDHP.BackColor = System.Drawing.Color.Black
        Me.btThoatDMDHP.FlatAppearance.BorderSize = 2
        Me.btThoatDMDHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btThoatDMDHP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btThoatDMDHP.ForeColor = System.Drawing.Color.White
        Me.btThoatDMDHP.Location = New System.Drawing.Point(774, 102)
        Me.btThoatDMDHP.Name = "btThoatDMDHP"
        Me.btThoatDMDHP.Size = New System.Drawing.Size(96, 39)
        Me.btThoatDMDHP.TabIndex = 9
        Me.btThoatDMDHP.Text = "Thoát"
        Me.btThoatDMDHP.UseVisualStyleBackColor = False
        '
        'btXoaDMDHP
        '
        Me.btXoaDMDHP.BackColor = System.Drawing.Color.Black
        Me.btXoaDMDHP.FlatAppearance.BorderSize = 2
        Me.btXoaDMDHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btXoaDMDHP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btXoaDMDHP.ForeColor = System.Drawing.Color.White
        Me.btXoaDMDHP.Location = New System.Drawing.Point(304, 101)
        Me.btXoaDMDHP.Name = "btXoaDMDHP"
        Me.btXoaDMDHP.Size = New System.Drawing.Size(113, 35)
        Me.btXoaDMDHP.TabIndex = 8
        Me.btXoaDMDHP.Text = "Xóa"
        Me.btXoaDMDHP.UseVisualStyleBackColor = False
        '
        'btSuaDMDHP
        '
        Me.btSuaDMDHP.BackColor = System.Drawing.Color.Black
        Me.btSuaDMDHP.FlatAppearance.BorderSize = 2
        Me.btSuaDMDHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSuaDMDHP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSuaDMDHP.ForeColor = System.Drawing.Color.White
        Me.btSuaDMDHP.Location = New System.Drawing.Point(163, 101)
        Me.btSuaDMDHP.Name = "btSuaDMDHP"
        Me.btSuaDMDHP.Size = New System.Drawing.Size(113, 35)
        Me.btSuaDMDHP.TabIndex = 7
        Me.btSuaDMDHP.Text = "Sửa"
        Me.btSuaDMDHP.UseVisualStyleBackColor = False
        '
        'btThemDMDHP
        '
        Me.btThemDMDHP.BackColor = System.Drawing.Color.Black
        Me.btThemDMDHP.FlatAppearance.BorderSize = 2
        Me.btThemDMDHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btThemDMDHP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btThemDMDHP.ForeColor = System.Drawing.Color.White
        Me.btThemDMDHP.Location = New System.Drawing.Point(20, 101)
        Me.btThemDMDHP.Name = "btThemDMDHP"
        Me.btThemDMDHP.Size = New System.Drawing.Size(113, 35)
        Me.btThemDMDHP.TabIndex = 6
        Me.btThemDMDHP.Text = "Thêm "
        Me.btThemDMDHP.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(713, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 21)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Điểm Học Phần"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(392, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 21)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Mã Học Phần"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(59, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 21)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Mã Sinh Viên"
        '
        'txtDiemHPDMDHP
        '
        Me.txtDiemHPDMDHP.BackColor = System.Drawing.Color.Silver
        Me.txtDiemHPDMDHP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet14, "DM_DiemHocPhan.DiemHocPhan", True))
        Me.txtDiemHPDMDHP.Location = New System.Drawing.Point(701, 54)
        Me.txtDiemHPDMDHP.Name = "txtDiemHPDMDHP"
        Me.txtDiemHPDMDHP.Size = New System.Drawing.Size(144, 22)
        Me.txtDiemHPDMDHP.TabIndex = 2
        '
        'txtMaHPDMDHP
        '
        Me.txtMaHPDMDHP.BackColor = System.Drawing.Color.Silver
        Me.txtMaHPDMDHP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet14, "DM_DiemHocPhan.MaHocPhan", True))
        Me.txtMaHPDMDHP.Location = New System.Drawing.Point(379, 54)
        Me.txtMaHPDMDHP.Name = "txtMaHPDMDHP"
        Me.txtMaHPDMDHP.Size = New System.Drawing.Size(144, 22)
        Me.txtMaHPDMDHP.TabIndex = 1
        '
        'txtMaSVDMDHP
        '
        Me.txtMaSVDMDHP.BackColor = System.Drawing.Color.Silver
        Me.txtMaSVDMDHP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet14, "DM_DiemHocPhan.MaSinhVien", True))
        Me.txtMaSVDMDHP.Location = New System.Drawing.Point(47, 54)
        Me.txtMaSVDMDHP.Name = "txtMaSVDMDHP"
        Me.txtMaSVDMDHP.Size = New System.Drawing.Size(144, 22)
        Me.txtMaSVDMDHP.TabIndex = 0
        '
        'DataGridView5
        '
        Me.DataGridView5.AutoGenerateColumns = False
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSinhVienDataGridViewTextBoxColumn1, Me.MaHocPhanDataGridViewTextBoxColumn1, Me.DiemHocPhanDataGridViewTextBoxColumn})
        Me.DataGridView5.DataSource = Me.TTDHPBindingSource
        Me.DataGridView5.Location = New System.Drawing.Point(4, 3)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.RowHeadersWidth = 51
        Me.DataGridView5.RowTemplate.Height = 24
        Me.DataGridView5.Size = New System.Drawing.Size(893, 219)
        Me.DataGridView5.TabIndex = 2
        '
        'MaSinhVienDataGridViewTextBoxColumn1
        '
        Me.MaSinhVienDataGridViewTextBoxColumn1.DataPropertyName = "MaSinhVien"
        Me.MaSinhVienDataGridViewTextBoxColumn1.HeaderText = "Mã Sinh Viên"
        Me.MaSinhVienDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.MaSinhVienDataGridViewTextBoxColumn1.Name = "MaSinhVienDataGridViewTextBoxColumn1"
        Me.MaSinhVienDataGridViewTextBoxColumn1.Width = 125
        '
        'MaHocPhanDataGridViewTextBoxColumn1
        '
        Me.MaHocPhanDataGridViewTextBoxColumn1.DataPropertyName = "MaHocPhan"
        Me.MaHocPhanDataGridViewTextBoxColumn1.HeaderText = "Mã Học Phần"
        Me.MaHocPhanDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.MaHocPhanDataGridViewTextBoxColumn1.Name = "MaHocPhanDataGridViewTextBoxColumn1"
        Me.MaHocPhanDataGridViewTextBoxColumn1.Width = 125
        '
        'DiemHocPhanDataGridViewTextBoxColumn
        '
        Me.DiemHocPhanDataGridViewTextBoxColumn.DataPropertyName = "DiemHocPhan"
        Me.DiemHocPhanDataGridViewTextBoxColumn.HeaderText = "Điểm Học Phần"
        Me.DiemHocPhanDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DiemHocPhanDataGridViewTextBoxColumn.Name = "DiemHocPhanDataGridViewTextBoxColumn"
        Me.DiemHocPhanDataGridViewTextBoxColumn.Width = 125
        '
        'pnDMSV
        '
        Me.pnDMSV.BackColor = System.Drawing.Color.Silver
        Me.pnDMSV.Controls.Add(Me.TTSVBindingNavigator)
        Me.pnDMSV.Controls.Add(Me.pnDMSVbot)
        Me.pnDMSV.Controls.Add(Me.DataGridView3)
        Me.pnDMSV.Location = New System.Drawing.Point(12, 158)
        Me.pnDMSV.Name = "pnDMSV"
        Me.pnDMSV.Size = New System.Drawing.Size(901, 470)
        Me.pnDMSV.TabIndex = 2
        '
        'TTSVBindingNavigator
        '
        Me.TTSVBindingNavigator.AddNewItem = Nothing
        Me.TTSVBindingNavigator.BindingSource = Me.TTSVBindingSource
        Me.TTSVBindingNavigator.CountItem = Me.BindingNavigatorCountItem2
        Me.TTSVBindingNavigator.CountItemFormat = "/{0}"
        Me.TTSVBindingNavigator.DeleteItem = Nothing
        Me.TTSVBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TTSVBindingNavigator.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.TTSVBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem2, Me.BindingNavigatorMovePreviousItem2, Me.BindingNavigatorSeparator6, Me.BindingNavigatorPositionItem2, Me.BindingNavigatorCountItem2, Me.BindingNavigatorSeparator7, Me.BindingNavigatorMoveNextItem2, Me.BindingNavigatorMoveLastItem2, Me.BindingNavigatorSeparator8})
        Me.TTSVBindingNavigator.Location = New System.Drawing.Point(0, 438)
        Me.TTSVBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem2
        Me.TTSVBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem2
        Me.TTSVBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem2
        Me.TTSVBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem2
        Me.TTSVBindingNavigator.Name = "TTSVBindingNavigator"
        Me.TTSVBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem2
        Me.TTSVBindingNavigator.Size = New System.Drawing.Size(901, 32)
        Me.TTSVBindingNavigator.TabIndex = 3
        Me.TTSVBindingNavigator.Text = "BindingNavigator1"
        '
        'TTSVBindingSource
        '
        Me.TTSVBindingSource.DataMember = "DM_SinhVien"
        Me.TTSVBindingSource.DataSource = Me.DataSet12
        '
        'DataSet12
        '
        Me.DataSet12.DataSetName = "DataSet1"
        Me.DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem2
        '
        Me.BindingNavigatorCountItem2.Name = "BindingNavigatorCountItem2"
        Me.BindingNavigatorCountItem2.Size = New System.Drawing.Size(33, 29)
        Me.BindingNavigatorCountItem2.Text = "/{0}"
        Me.BindingNavigatorCountItem2.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem2
        '
        Me.BindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem2.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem2.Name = "BindingNavigatorMoveFirstItem2"
        Me.BindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem2.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMoveFirstItem2.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem2
        '
        Me.BindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem2.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem2.Name = "BindingNavigatorMovePreviousItem2"
        Me.BindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem2.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMovePreviousItem2.Text = "Move previous"
        '
        'BindingNavigatorSeparator6
        '
        Me.BindingNavigatorSeparator6.Name = "BindingNavigatorSeparator6"
        Me.BindingNavigatorSeparator6.Size = New System.Drawing.Size(6, 32)
        '
        'BindingNavigatorPositionItem2
        '
        Me.BindingNavigatorPositionItem2.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem2.AutoSize = False
        Me.BindingNavigatorPositionItem2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem2.Name = "BindingNavigatorPositionItem2"
        Me.BindingNavigatorPositionItem2.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem2.Text = "0"
        Me.BindingNavigatorPositionItem2.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator7
        '
        Me.BindingNavigatorSeparator7.Name = "BindingNavigatorSeparator7"
        Me.BindingNavigatorSeparator7.Size = New System.Drawing.Size(6, 32)
        '
        'BindingNavigatorMoveNextItem2
        '
        Me.BindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem2.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem2.Name = "BindingNavigatorMoveNextItem2"
        Me.BindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem2.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMoveNextItem2.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem2
        '
        Me.BindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem2.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem2.Name = "BindingNavigatorMoveLastItem2"
        Me.BindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem2.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMoveLastItem2.Text = "Move last"
        '
        'BindingNavigatorSeparator8
        '
        Me.BindingNavigatorSeparator8.Name = "BindingNavigatorSeparator8"
        Me.BindingNavigatorSeparator8.Size = New System.Drawing.Size(6, 32)
        '
        'pnDMSVbot
        '
        Me.pnDMSVbot.BackColor = System.Drawing.Color.White
        Me.pnDMSVbot.Controls.Add(Me.Label3)
        Me.pnDMSVbot.Controls.Add(Me.GroupBox1)
        Me.pnDMSVbot.Controls.Add(Me.btInDMSV)
        Me.pnDMSVbot.Controls.Add(Me.btTimKiemDMSV)
        Me.pnDMSVbot.Controls.Add(Me.btThoatDMSV)
        Me.pnDMSVbot.Controls.Add(Me.btXoaDMSV)
        Me.pnDMSVbot.Controls.Add(Me.btSuaDMSV)
        Me.pnDMSVbot.Controls.Add(Me.btThemDMSV)
        Me.pnDMSVbot.Controls.Add(Me.Label6)
        Me.pnDMSVbot.Controls.Add(Me.Label5)
        Me.pnDMSVbot.Controls.Add(Me.Label4)
        Me.pnDMSVbot.Controls.Add(Me.Label2)
        Me.pnDMSVbot.Controls.Add(Me.txtDiaChiDMSV)
        Me.pnDMSVbot.Controls.Add(Me.txtNgaySinhDMSV)
        Me.pnDMSVbot.Controls.Add(Me.txtMaKhoaDMSV)
        Me.pnDMSVbot.Controls.Add(Me.txtHoTenDMSV)
        Me.pnDMSVbot.Controls.Add(Me.Label1)
        Me.pnDMSVbot.Controls.Add(Me.txtMaSVDMSV)
        Me.pnDMSVbot.Location = New System.Drawing.Point(4, 187)
        Me.pnDMSVbot.Name = "pnDMSVbot"
        Me.pnDMSVbot.Size = New System.Drawing.Size(890, 272)
        Me.pnDMSVbot.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(350, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "yyyy/mm/dd"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.rbNu)
        Me.GroupBox1.Controls.Add(Me.rbNam)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(162, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(158, 124)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Giới Tính"
        '
        'rbNu
        '
        Me.rbNu.AutoSize = True
        Me.rbNu.BackColor = System.Drawing.Color.Black
        Me.rbNu.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet12, "DM_SinhVien.GioiTinh", True))
        Me.rbNu.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNu.ForeColor = System.Drawing.Color.White
        Me.rbNu.Location = New System.Drawing.Point(20, 81)
        Me.rbNu.Name = "rbNu"
        Me.rbNu.Size = New System.Drawing.Size(55, 25)
        Me.rbNu.TabIndex = 15
        Me.rbNu.TabStop = True
        Me.rbNu.Text = "Nữ"
        Me.rbNu.UseVisualStyleBackColor = False
        '
        'rbNam
        '
        Me.rbNam.AutoSize = True
        Me.rbNam.BackColor = System.Drawing.Color.Black
        Me.rbNam.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet12, "DM_SinhVien.GioiTinh", True))
        Me.rbNam.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNam.ForeColor = System.Drawing.Color.White
        Me.rbNam.Location = New System.Drawing.Point(17, 40)
        Me.rbNam.Name = "rbNam"
        Me.rbNam.Size = New System.Drawing.Size(68, 25)
        Me.rbNam.TabIndex = 14
        Me.rbNam.TabStop = True
        Me.rbNam.Text = "Nam"
        Me.rbNam.UseVisualStyleBackColor = False
        '
        'btInDMSV
        '
        Me.btInDMSV.BackColor = System.Drawing.Color.Black
        Me.btInDMSV.FlatAppearance.BorderSize = 2
        Me.btInDMSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btInDMSV.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInDMSV.ForeColor = System.Drawing.Color.White
        Me.btInDMSV.Location = New System.Drawing.Point(623, 167)
        Me.btInDMSV.Name = "btInDMSV"
        Me.btInDMSV.Size = New System.Drawing.Size(104, 38)
        Me.btInDMSV.TabIndex = 18
        Me.btInDMSV.Text = "In"
        Me.btInDMSV.UseVisualStyleBackColor = False
        '
        'btTimKiemDMSV
        '
        Me.btTimKiemDMSV.BackColor = System.Drawing.Color.Black
        Me.btTimKiemDMSV.FlatAppearance.BorderSize = 2
        Me.btTimKiemDMSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btTimKiemDMSV.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTimKiemDMSV.ForeColor = System.Drawing.Color.White
        Me.btTimKiemDMSV.Location = New System.Drawing.Point(467, 167)
        Me.btTimKiemDMSV.Name = "btTimKiemDMSV"
        Me.btTimKiemDMSV.Size = New System.Drawing.Size(104, 38)
        Me.btTimKiemDMSV.TabIndex = 17
        Me.btTimKiemDMSV.Text = "Tìm kiếm"
        Me.btTimKiemDMSV.UseVisualStyleBackColor = False
        '
        'btThoatDMSV
        '
        Me.btThoatDMSV.BackColor = System.Drawing.Color.Black
        Me.btThoatDMSV.FlatAppearance.BorderSize = 2
        Me.btThoatDMSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btThoatDMSV.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btThoatDMSV.ForeColor = System.Drawing.Color.White
        Me.btThoatDMSV.Location = New System.Drawing.Point(765, 167)
        Me.btThoatDMSV.Name = "btThoatDMSV"
        Me.btThoatDMSV.Size = New System.Drawing.Size(105, 38)
        Me.btThoatDMSV.TabIndex = 16
        Me.btThoatDMSV.Text = "Thoát"
        Me.btThoatDMSV.UseVisualStyleBackColor = False
        '
        'btXoaDMSV
        '
        Me.btXoaDMSV.BackColor = System.Drawing.Color.Black
        Me.btXoaDMSV.FlatAppearance.BorderSize = 2
        Me.btXoaDMSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btXoaDMSV.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btXoaDMSV.ForeColor = System.Drawing.Color.White
        Me.btXoaDMSV.Location = New System.Drawing.Point(311, 167)
        Me.btXoaDMSV.Name = "btXoaDMSV"
        Me.btXoaDMSV.Size = New System.Drawing.Size(105, 38)
        Me.btXoaDMSV.TabIndex = 13
        Me.btXoaDMSV.Text = "Xóa"
        Me.btXoaDMSV.UseVisualStyleBackColor = False
        '
        'btSuaDMSV
        '
        Me.btSuaDMSV.BackColor = System.Drawing.Color.Black
        Me.btSuaDMSV.FlatAppearance.BorderSize = 2
        Me.btSuaDMSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSuaDMSV.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSuaDMSV.ForeColor = System.Drawing.Color.White
        Me.btSuaDMSV.Location = New System.Drawing.Point(163, 167)
        Me.btSuaDMSV.Name = "btSuaDMSV"
        Me.btSuaDMSV.Size = New System.Drawing.Size(105, 38)
        Me.btSuaDMSV.TabIndex = 12
        Me.btSuaDMSV.Text = "Sửa"
        Me.btSuaDMSV.UseVisualStyleBackColor = False
        '
        'btThemDMSV
        '
        Me.btThemDMSV.BackColor = System.Drawing.Color.Black
        Me.btThemDMSV.FlatAppearance.BorderSize = 2
        Me.btThemDMSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btThemDMSV.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btThemDMSV.ForeColor = System.Drawing.Color.White
        Me.btThemDMSV.Location = New System.Drawing.Point(20, 167)
        Me.btThemDMSV.Name = "btThemDMSV"
        Me.btThemDMSV.Size = New System.Drawing.Size(105, 38)
        Me.btThemDMSV.TabIndex = 11
        Me.btThemDMSV.Text = "Thêm"
        Me.btThemDMSV.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(556, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Địa Chỉ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(349, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Ngày Sinh"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(350, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Mã Khoa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Họ Tên"
        '
        'txtDiaChiDMSV
        '
        Me.txtDiaChiDMSV.BackColor = System.Drawing.Color.Silver
        Me.txtDiaChiDMSV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet12, "DM_SinhVien.DiaChi", True))
        Me.txtDiaChiDMSV.Location = New System.Drawing.Point(455, 33)
        Me.txtDiaChiDMSV.Multiline = True
        Me.txtDiaChiDMSV.Name = "txtDiaChiDMSV"
        Me.txtDiaChiDMSV.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDiaChiDMSV.Size = New System.Drawing.Size(415, 98)
        Me.txtDiaChiDMSV.TabIndex = 5
        '
        'txtNgaySinhDMSV
        '
        Me.txtNgaySinhDMSV.BackColor = System.Drawing.Color.Silver
        Me.txtNgaySinhDMSV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet12, "DM_SinhVien.NgaySinh", True))
        Me.txtNgaySinhDMSV.Location = New System.Drawing.Point(326, 116)
        Me.txtNgaySinhDMSV.Name = "txtNgaySinhDMSV"
        Me.txtNgaySinhDMSV.Size = New System.Drawing.Size(124, 22)
        Me.txtNgaySinhDMSV.TabIndex = 4
        '
        'txtMaKhoaDMSV
        '
        Me.txtMaKhoaDMSV.BackColor = System.Drawing.Color.Silver
        Me.txtMaKhoaDMSV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet12, "DM_SinhVien.MaKhoa", True))
        Me.txtMaKhoaDMSV.Location = New System.Drawing.Point(325, 41)
        Me.txtMaKhoaDMSV.Name = "txtMaKhoaDMSV"
        Me.txtMaKhoaDMSV.Size = New System.Drawing.Size(124, 22)
        Me.txtMaKhoaDMSV.TabIndex = 3
        '
        'txtHoTenDMSV
        '
        Me.txtHoTenDMSV.BackColor = System.Drawing.Color.Silver
        Me.txtHoTenDMSV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet12, "DM_SinhVien.HoTen", True))
        Me.txtHoTenDMSV.Location = New System.Drawing.Point(20, 115)
        Me.txtHoTenDMSV.Name = "txtHoTenDMSV"
        Me.txtHoTenDMSV.Size = New System.Drawing.Size(124, 22)
        Me.txtHoTenDMSV.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Sinh Viên"
        '
        'txtMaSVDMSV
        '
        Me.txtMaSVDMSV.BackColor = System.Drawing.Color.Silver
        Me.txtMaSVDMSV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet12, "DM_SinhVien.MaSinhVien", True))
        Me.txtMaSVDMSV.Location = New System.Drawing.Point(20, 41)
        Me.txtMaSVDMSV.Name = "txtMaSVDMSV"
        Me.txtMaSVDMSV.Size = New System.Drawing.Size(124, 22)
        Me.txtMaSVDMSV.TabIndex = 0
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSinhVienDataGridViewTextBoxColumn, Me.HoTenDataGridViewTextBoxColumn, Me.MaKhoaDataGridViewTextBoxColumn2, Me.GioiTinhDataGridViewTextBoxColumn, Me.NgaySinhDataGridViewTextBoxColumn, Me.DiaChiDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.TTSVBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(4, 3)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(893, 178)
        Me.DataGridView3.TabIndex = 2
        '
        'MaSinhVienDataGridViewTextBoxColumn
        '
        Me.MaSinhVienDataGridViewTextBoxColumn.DataPropertyName = "MaSinhVien"
        Me.MaSinhVienDataGridViewTextBoxColumn.HeaderText = "Mã Sinh Viên"
        Me.MaSinhVienDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaSinhVienDataGridViewTextBoxColumn.Name = "MaSinhVienDataGridViewTextBoxColumn"
        Me.MaSinhVienDataGridViewTextBoxColumn.Width = 125
        '
        'HoTenDataGridViewTextBoxColumn
        '
        Me.HoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen"
        Me.HoTenDataGridViewTextBoxColumn.HeaderText = "Họ Tên"
        Me.HoTenDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HoTenDataGridViewTextBoxColumn.Name = "HoTenDataGridViewTextBoxColumn"
        Me.HoTenDataGridViewTextBoxColumn.Width = 125
        '
        'MaKhoaDataGridViewTextBoxColumn2
        '
        Me.MaKhoaDataGridViewTextBoxColumn2.DataPropertyName = "MaKhoa"
        Me.MaKhoaDataGridViewTextBoxColumn2.HeaderText = "Mã Khoa"
        Me.MaKhoaDataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.MaKhoaDataGridViewTextBoxColumn2.Name = "MaKhoaDataGridViewTextBoxColumn2"
        Me.MaKhoaDataGridViewTextBoxColumn2.Width = 125
        '
        'GioiTinhDataGridViewTextBoxColumn
        '
        Me.GioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh"
        Me.GioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới Tính"
        Me.GioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GioiTinhDataGridViewTextBoxColumn.Name = "GioiTinhDataGridViewTextBoxColumn"
        Me.GioiTinhDataGridViewTextBoxColumn.Width = 125
        '
        'NgaySinhDataGridViewTextBoxColumn
        '
        Me.NgaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh"
        Me.NgaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh "
        Me.NgaySinhDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NgaySinhDataGridViewTextBoxColumn.Name = "NgaySinhDataGridViewTextBoxColumn"
        Me.NgaySinhDataGridViewTextBoxColumn.Width = 125
        '
        'DiaChiDataGridViewTextBoxColumn
        '
        Me.DiaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi"
        Me.DiaChiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ"
        Me.DiaChiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DiaChiDataGridViewTextBoxColumn.Name = "DiaChiDataGridViewTextBoxColumn"
        Me.DiaChiDataGridViewTextBoxColumn.Width = 125
        '
        'pnDMKhoa
        '
        Me.pnDMKhoa.BackColor = System.Drawing.Color.Silver
        Me.pnDMKhoa.Controls.Add(Me.TTKhoaBindingNavigator)
        Me.pnDMKhoa.Controls.Add(Me.pnDMKhoabot)
        Me.pnDMKhoa.Controls.Add(Me.DataGridView1)
        Me.pnDMKhoa.Location = New System.Drawing.Point(12, 158)
        Me.pnDMKhoa.Name = "pnDMKhoa"
        Me.pnDMKhoa.Size = New System.Drawing.Size(901, 443)
        Me.pnDMKhoa.TabIndex = 3
        '
        'TTKhoaBindingNavigator
        '
        Me.TTKhoaBindingNavigator.AddNewItem = Nothing
        Me.TTKhoaBindingNavigator.BindingSource = Me.TTKhoaBindingSource
        Me.TTKhoaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TTKhoaBindingNavigator.CountItemFormat = "/ {0}"
        Me.TTKhoaBindingNavigator.DeleteItem = Nothing
        Me.TTKhoaBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TTKhoaBindingNavigator.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.TTKhoaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.TTKhoaBindingNavigator.Location = New System.Drawing.Point(0, 411)
        Me.TTKhoaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TTKhoaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TTKhoaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TTKhoaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TTKhoaBindingNavigator.Name = "TTKhoaBindingNavigator"
        Me.TTKhoaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TTKhoaBindingNavigator.Size = New System.Drawing.Size(901, 32)
        Me.TTKhoaBindingNavigator.TabIndex = 5
        Me.TTKhoaBindingNavigator.Text = "BindingNavigator1"
        '
        'TTKhoaBindingSource
        '
        Me.TTKhoaBindingSource.DataMember = "DM_Khoa"
        Me.TTKhoaBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 29)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 32)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 32)
        '
        'pnDMKhoabot
        '
        Me.pnDMKhoabot.BackColor = System.Drawing.Color.White
        Me.pnDMKhoabot.Controls.Add(Me.btInDMKhoa)
        Me.pnDMKhoabot.Controls.Add(Me.btTimKiemDMKhoa)
        Me.pnDMKhoabot.Controls.Add(Me.btThoatDMKhoa)
        Me.pnDMKhoabot.Controls.Add(Me.btXoaDMKhoa)
        Me.pnDMKhoabot.Controls.Add(Me.btSuaDMKhoa)
        Me.pnDMKhoabot.Controls.Add(Me.btThemDMKhoa)
        Me.pnDMKhoabot.Controls.Add(Me.txtTenKhoaDMK)
        Me.pnDMKhoabot.Controls.Add(Me.Label8)
        Me.pnDMKhoabot.Controls.Add(Me.txtMaKhoaDMK)
        Me.pnDMKhoabot.Controls.Add(Me.Label7)
        Me.pnDMKhoabot.Location = New System.Drawing.Point(4, 220)
        Me.pnDMKhoabot.Name = "pnDMKhoabot"
        Me.pnDMKhoabot.Size = New System.Drawing.Size(893, 223)
        Me.pnDMKhoabot.TabIndex = 1
        '
        'btInDMKhoa
        '
        Me.btInDMKhoa.BackColor = System.Drawing.Color.Black
        Me.btInDMKhoa.FlatAppearance.BorderSize = 2
        Me.btInDMKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btInDMKhoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInDMKhoa.ForeColor = System.Drawing.Color.White
        Me.btInDMKhoa.Location = New System.Drawing.Point(592, 90)
        Me.btInDMKhoa.Name = "btInDMKhoa"
        Me.btInDMKhoa.Size = New System.Drawing.Size(118, 39)
        Me.btInDMKhoa.TabIndex = 9
        Me.btInDMKhoa.Text = "In"
        Me.btInDMKhoa.UseVisualStyleBackColor = False
        '
        'btTimKiemDMKhoa
        '
        Me.btTimKiemDMKhoa.BackColor = System.Drawing.Color.Black
        Me.btTimKiemDMKhoa.FlatAppearance.BorderSize = 2
        Me.btTimKiemDMKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btTimKiemDMKhoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTimKiemDMKhoa.ForeColor = System.Drawing.Color.White
        Me.btTimKiemDMKhoa.Location = New System.Drawing.Point(445, 90)
        Me.btTimKiemDMKhoa.Name = "btTimKiemDMKhoa"
        Me.btTimKiemDMKhoa.Size = New System.Drawing.Size(123, 39)
        Me.btTimKiemDMKhoa.TabIndex = 8
        Me.btTimKiemDMKhoa.Text = "Tìm Kiếm"
        Me.btTimKiemDMKhoa.UseVisualStyleBackColor = False
        '
        'btThoatDMKhoa
        '
        Me.btThoatDMKhoa.BackColor = System.Drawing.Color.Black
        Me.btThoatDMKhoa.FlatAppearance.BorderSize = 2
        Me.btThoatDMKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btThoatDMKhoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btThoatDMKhoa.ForeColor = System.Drawing.Color.White
        Me.btThoatDMKhoa.Location = New System.Drawing.Point(740, 90)
        Me.btThoatDMKhoa.Name = "btThoatDMKhoa"
        Me.btThoatDMKhoa.Size = New System.Drawing.Size(105, 39)
        Me.btThoatDMKhoa.TabIndex = 7
        Me.btThoatDMKhoa.Text = "Thoát"
        Me.btThoatDMKhoa.UseVisualStyleBackColor = False
        '
        'btXoaDMKhoa
        '
        Me.btXoaDMKhoa.BackColor = System.Drawing.Color.Black
        Me.btXoaDMKhoa.FlatAppearance.BorderSize = 2
        Me.btXoaDMKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btXoaDMKhoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btXoaDMKhoa.ForeColor = System.Drawing.Color.White
        Me.btXoaDMKhoa.Location = New System.Drawing.Point(304, 90)
        Me.btXoaDMKhoa.Name = "btXoaDMKhoa"
        Me.btXoaDMKhoa.Size = New System.Drawing.Size(113, 39)
        Me.btXoaDMKhoa.TabIndex = 6
        Me.btXoaDMKhoa.Text = "Xóa"
        Me.btXoaDMKhoa.UseVisualStyleBackColor = False
        '
        'btSuaDMKhoa
        '
        Me.btSuaDMKhoa.BackColor = System.Drawing.Color.Black
        Me.btSuaDMKhoa.FlatAppearance.BorderSize = 2
        Me.btSuaDMKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSuaDMKhoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSuaDMKhoa.ForeColor = System.Drawing.Color.White
        Me.btSuaDMKhoa.Location = New System.Drawing.Point(163, 90)
        Me.btSuaDMKhoa.Name = "btSuaDMKhoa"
        Me.btSuaDMKhoa.Size = New System.Drawing.Size(118, 39)
        Me.btSuaDMKhoa.TabIndex = 5
        Me.btSuaDMKhoa.Text = "Sửa"
        Me.btSuaDMKhoa.UseVisualStyleBackColor = False
        '
        'btThemDMKhoa
        '
        Me.btThemDMKhoa.BackColor = System.Drawing.Color.Black
        Me.btThemDMKhoa.FlatAppearance.BorderSize = 2
        Me.btThemDMKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btThemDMKhoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btThemDMKhoa.ForeColor = System.Drawing.Color.White
        Me.btThemDMKhoa.Location = New System.Drawing.Point(20, 90)
        Me.btThemDMKhoa.Name = "btThemDMKhoa"
        Me.btThemDMKhoa.Size = New System.Drawing.Size(119, 39)
        Me.btThemDMKhoa.TabIndex = 4
        Me.btThemDMKhoa.Text = "Thêm"
        Me.btThemDMKhoa.UseVisualStyleBackColor = False
        '
        'txtTenKhoaDMK
        '
        Me.txtTenKhoaDMK.BackColor = System.Drawing.Color.Silver
        Me.txtTenKhoaDMK.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "DM_Khoa.TenKhoa", True))
        Me.txtTenKhoaDMK.Location = New System.Drawing.Point(487, 49)
        Me.txtTenKhoaDMK.Name = "txtTenKhoaDMK"
        Me.txtTenKhoaDMK.Size = New System.Drawing.Size(138, 22)
        Me.txtTenKhoaDMK.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(514, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 21)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Tên Khoa"
        '
        'txtMaKhoaDMK
        '
        Me.txtMaKhoaDMK.BackColor = System.Drawing.Color.Silver
        Me.txtMaKhoaDMK.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "DM_Khoa.MaKhoa", True))
        Me.txtMaKhoaDMK.Location = New System.Drawing.Point(187, 48)
        Me.txtMaKhoaDMK.Name = "txtMaKhoaDMK"
        Me.txtMaKhoaDMK.Size = New System.Drawing.Size(138, 22)
        Me.txtMaKhoaDMK.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(216, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Mã Khoa"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaKhoaDataGridViewTextBoxColumn, Me.TenKhoaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TTKhoaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(4, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(893, 214)
        Me.DataGridView1.TabIndex = 2
        '
        'MaKhoaDataGridViewTextBoxColumn
        '
        Me.MaKhoaDataGridViewTextBoxColumn.DataPropertyName = "MaKhoa"
        Me.MaKhoaDataGridViewTextBoxColumn.HeaderText = "Mã Khoa"
        Me.MaKhoaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaKhoaDataGridViewTextBoxColumn.Name = "MaKhoaDataGridViewTextBoxColumn"
        Me.MaKhoaDataGridViewTextBoxColumn.Width = 125
        '
        'TenKhoaDataGridViewTextBoxColumn
        '
        Me.TenKhoaDataGridViewTextBoxColumn.DataPropertyName = "TenKhoa"
        Me.TenKhoaDataGridViewTextBoxColumn.HeaderText = "Tên Khoa"
        Me.TenKhoaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TenKhoaDataGridViewTextBoxColumn.Name = "TenKhoaDataGridViewTextBoxColumn"
        Me.TenKhoaDataGridViewTextBoxColumn.Width = 125
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'pnDMLop
        '
        Me.pnDMLop.BackColor = System.Drawing.Color.Gray
        Me.pnDMLop.Controls.Add(Me.pnDMLopbot)
        Me.pnDMLop.Controls.Add(Me.DataGridView2)
        Me.pnDMLop.Location = New System.Drawing.Point(12, 155)
        Me.pnDMLop.Name = "pnDMLop"
        Me.pnDMLop.Size = New System.Drawing.Size(901, 476)
        Me.pnDMLop.TabIndex = 4
        '
        'pnDMLopbot
        '
        Me.pnDMLopbot.BackColor = System.Drawing.Color.White
        Me.pnDMLopbot.Controls.Add(Me.TTLopBindingNavigator)
        Me.pnDMLopbot.Controls.Add(Me.btThoatDMLop)
        Me.pnDMLopbot.Controls.Add(Me.btInDMLop)
        Me.pnDMLopbot.Controls.Add(Me.btTimKiemDMLop)
        Me.pnDMLopbot.Controls.Add(Me.btXoaDMLop)
        Me.pnDMLopbot.Controls.Add(Me.btSuaDMLop)
        Me.pnDMLopbot.Controls.Add(Me.txtNamNhapHocDML)
        Me.pnDMLopbot.Controls.Add(Me.txtHeDTDML)
        Me.pnDMLopbot.Controls.Add(Me.txtKhoaHocDML)
        Me.pnDMLopbot.Controls.Add(Me.txtMaKhoaDML)
        Me.pnDMLopbot.Controls.Add(Me.txtTenLopDML)
        Me.pnDMLopbot.Controls.Add(Me.Label17)
        Me.pnDMLopbot.Controls.Add(Me.Label16)
        Me.pnDMLopbot.Controls.Add(Me.Label15)
        Me.pnDMLopbot.Controls.Add(Me.Label14)
        Me.pnDMLopbot.Controls.Add(Me.Label13)
        Me.pnDMLopbot.Controls.Add(Me.btThemDMLop)
        Me.pnDMLopbot.Controls.Add(Me.Label12)
        Me.pnDMLopbot.Controls.Add(Me.txtMaLopDML)
        Me.pnDMLopbot.Location = New System.Drawing.Point(4, 265)
        Me.pnDMLopbot.Name = "pnDMLopbot"
        Me.pnDMLopbot.Size = New System.Drawing.Size(890, 184)
        Me.pnDMLopbot.TabIndex = 1
        '
        'TTLopBindingNavigator
        '
        Me.TTLopBindingNavigator.AddNewItem = Nothing
        Me.TTLopBindingNavigator.BackColor = System.Drawing.Color.Silver
        Me.TTLopBindingNavigator.BindingSource = Me.TTLopBindingSource
        Me.TTLopBindingNavigator.CountItem = Me.BindingNavigatorCountItem1
        Me.TTLopBindingNavigator.CountItemFormat = "/{0}"
        Me.TTLopBindingNavigator.DeleteItem = Nothing
        Me.TTLopBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TTLopBindingNavigator.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.TTLopBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5})
        Me.TTLopBindingNavigator.Location = New System.Drawing.Point(0, 152)
        Me.TTLopBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.TTLopBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.TTLopBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.TTLopBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.TTLopBindingNavigator.Name = "TTLopBindingNavigator"
        Me.TTLopBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem1
        Me.TTLopBindingNavigator.Size = New System.Drawing.Size(890, 32)
        Me.TTLopBindingNavigator.TabIndex = 5
        Me.TTLopBindingNavigator.Text = "BindingNavigator1"
        '
        'TTLopBindingSource
        '
        Me.TTLopBindingSource.DataMember = "DM_Lop"
        Me.TTLopBindingSource.DataSource = Me.DataSet11
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(33, 29)
        Me.BindingNavigatorCountItem1.Text = "/{0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 32)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 32)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 32)
        '
        'btThoatDMLop
        '
        Me.btThoatDMLop.BackColor = System.Drawing.Color.Black
        Me.btThoatDMLop.FlatAppearance.BorderSize = 2
        Me.btThoatDMLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btThoatDMLop.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btThoatDMLop.ForeColor = System.Drawing.Color.White
        Me.btThoatDMLop.Location = New System.Drawing.Point(710, 92)
        Me.btThoatDMLop.Name = "btThoatDMLop"
        Me.btThoatDMLop.Size = New System.Drawing.Size(100, 39)
        Me.btThoatDMLop.TabIndex = 16
        Me.btThoatDMLop.Text = "Thoát"
        Me.btThoatDMLop.UseVisualStyleBackColor = False
        '
        'btInDMLop
        '
        Me.btInDMLop.BackColor = System.Drawing.Color.Black
        Me.btInDMLop.FlatAppearance.BorderSize = 2
        Me.btInDMLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btInDMLop.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInDMLop.ForeColor = System.Drawing.Color.White
        Me.btInDMLop.Location = New System.Drawing.Point(577, 92)
        Me.btInDMLop.Name = "btInDMLop"
        Me.btInDMLop.Size = New System.Drawing.Size(100, 39)
        Me.btInDMLop.TabIndex = 15
        Me.btInDMLop.Text = "In"
        Me.btInDMLop.UseVisualStyleBackColor = False
        '
        'btTimKiemDMLop
        '
        Me.btTimKiemDMLop.BackColor = System.Drawing.Color.Black
        Me.btTimKiemDMLop.FlatAppearance.BorderSize = 2
        Me.btTimKiemDMLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btTimKiemDMLop.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTimKiemDMLop.ForeColor = System.Drawing.Color.White
        Me.btTimKiemDMLop.Location = New System.Drawing.Point(423, 92)
        Me.btTimKiemDMLop.Name = "btTimKiemDMLop"
        Me.btTimKiemDMLop.Size = New System.Drawing.Size(110, 39)
        Me.btTimKiemDMLop.TabIndex = 14
        Me.btTimKiemDMLop.Text = "Tìm Kiếm"
        Me.btTimKiemDMLop.UseVisualStyleBackColor = False
        '
        'btXoaDMLop
        '
        Me.btXoaDMLop.BackColor = System.Drawing.Color.Black
        Me.btXoaDMLop.FlatAppearance.BorderSize = 2
        Me.btXoaDMLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btXoaDMLop.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btXoaDMLop.ForeColor = System.Drawing.Color.White
        Me.btXoaDMLop.Location = New System.Drawing.Point(287, 92)
        Me.btXoaDMLop.Name = "btXoaDMLop"
        Me.btXoaDMLop.Size = New System.Drawing.Size(100, 39)
        Me.btXoaDMLop.TabIndex = 13
        Me.btXoaDMLop.Text = "Xóa"
        Me.btXoaDMLop.UseVisualStyleBackColor = False
        '
        'btSuaDMLop
        '
        Me.btSuaDMLop.BackColor = System.Drawing.Color.Black
        Me.btSuaDMLop.FlatAppearance.BorderSize = 2
        Me.btSuaDMLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSuaDMLop.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSuaDMLop.ForeColor = System.Drawing.Color.White
        Me.btSuaDMLop.Location = New System.Drawing.Point(155, 92)
        Me.btSuaDMLop.Name = "btSuaDMLop"
        Me.btSuaDMLop.Size = New System.Drawing.Size(100, 39)
        Me.btSuaDMLop.TabIndex = 12
        Me.btSuaDMLop.Text = "Sửa"
        Me.btSuaDMLop.UseVisualStyleBackColor = False
        '
        'txtNamNhapHocDML
        '
        Me.txtNamNhapHocDML.BackColor = System.Drawing.Color.Silver
        Me.txtNamNhapHocDML.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet11, "DM_Lop.NamNhapHoc", True))
        Me.txtNamNhapHocDML.Location = New System.Drawing.Point(699, 40)
        Me.txtNamNhapHocDML.Name = "txtNamNhapHocDML"
        Me.txtNamNhapHocDML.Size = New System.Drawing.Size(158, 22)
        Me.txtNamNhapHocDML.TabIndex = 11
        '
        'txtHeDTDML
        '
        Me.txtHeDTDML.BackColor = System.Drawing.Color.Silver
        Me.txtHeDTDML.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet11, "DM_Lop.HeDaoTao", True))
        Me.txtHeDTDML.Location = New System.Drawing.Point(563, 41)
        Me.txtHeDTDML.Name = "txtHeDTDML"
        Me.txtHeDTDML.Size = New System.Drawing.Size(130, 22)
        Me.txtHeDTDML.TabIndex = 11
        '
        'txtKhoaHocDML
        '
        Me.txtKhoaHocDML.BackColor = System.Drawing.Color.Silver
        Me.txtKhoaHocDML.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet11, "DM_Lop.KhoaHoc", True))
        Me.txtKhoaHocDML.Location = New System.Drawing.Point(427, 41)
        Me.txtKhoaHocDML.Name = "txtKhoaHocDML"
        Me.txtKhoaHocDML.Size = New System.Drawing.Size(130, 22)
        Me.txtKhoaHocDML.TabIndex = 10
        '
        'txtMaKhoaDML
        '
        Me.txtMaKhoaDML.BackColor = System.Drawing.Color.Silver
        Me.txtMaKhoaDML.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet11, "DM_Lop.MaKhoa", True))
        Me.txtMaKhoaDML.Location = New System.Drawing.Point(287, 40)
        Me.txtMaKhoaDML.Name = "txtMaKhoaDML"
        Me.txtMaKhoaDML.Size = New System.Drawing.Size(130, 22)
        Me.txtMaKhoaDML.TabIndex = 9
        '
        'txtTenLopDML
        '
        Me.txtTenLopDML.BackColor = System.Drawing.Color.Silver
        Me.txtTenLopDML.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet11, "DM_Lop.TenLop", True))
        Me.txtTenLopDML.Location = New System.Drawing.Point(149, 40)
        Me.txtTenLopDML.Name = "txtTenLopDML"
        Me.txtTenLopDML.Size = New System.Drawing.Size(130, 22)
        Me.txtTenLopDML.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(716, 7)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(129, 21)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Năm Nhập Học"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(576, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 21)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Hệ Đào Tạo "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(451, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 21)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Khóa Học"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(322, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 21)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Mã Khoa"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(178, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 21)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Tên Lớp"
        '
        'btThemDMLop
        '
        Me.btThemDMLop.BackColor = System.Drawing.Color.Black
        Me.btThemDMLop.FlatAppearance.BorderSize = 2
        Me.btThemDMLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btThemDMLop.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btThemDMLop.ForeColor = System.Drawing.Color.White
        Me.btThemDMLop.Location = New System.Drawing.Point(33, 92)
        Me.btThemDMLop.Name = "btThemDMLop"
        Me.btThemDMLop.Size = New System.Drawing.Size(100, 39)
        Me.btThemDMLop.TabIndex = 2
        Me.btThemDMLop.Text = "Thêm "
        Me.btThemDMLop.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(50, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 21)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Mã Lớp"
        '
        'txtMaLopDML
        '
        Me.txtMaLopDML.BackColor = System.Drawing.Color.Silver
        Me.txtMaLopDML.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet11, "DM_Lop.MaLop", True))
        Me.txtMaLopDML.Location = New System.Drawing.Point(13, 41)
        Me.txtMaLopDML.Name = "txtMaLopDML"
        Me.txtMaLopDML.Size = New System.Drawing.Size(130, 22)
        Me.txtMaLopDML.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaLopDataGridViewTextBoxColumn, Me.TenLopDataGridViewTextBoxColumn, Me.MaKhoaDataGridViewTextBoxColumn1, Me.KhoaHocDataGridViewTextBoxColumn, Me.HeDaoTaoDataGridViewTextBoxColumn, Me.NamNhapHocDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.TTLopBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(4, 3)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(893, 259)
        Me.DataGridView2.TabIndex = 2
        '
        'MaLopDataGridViewTextBoxColumn
        '
        Me.MaLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop"
        Me.MaLopDataGridViewTextBoxColumn.HeaderText = "Mã Lớp"
        Me.MaLopDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaLopDataGridViewTextBoxColumn.Name = "MaLopDataGridViewTextBoxColumn"
        Me.MaLopDataGridViewTextBoxColumn.Width = 125
        '
        'TenLopDataGridViewTextBoxColumn
        '
        Me.TenLopDataGridViewTextBoxColumn.DataPropertyName = "TenLop"
        Me.TenLopDataGridViewTextBoxColumn.HeaderText = "Tên Lớp"
        Me.TenLopDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TenLopDataGridViewTextBoxColumn.Name = "TenLopDataGridViewTextBoxColumn"
        Me.TenLopDataGridViewTextBoxColumn.Width = 125
        '
        'MaKhoaDataGridViewTextBoxColumn1
        '
        Me.MaKhoaDataGridViewTextBoxColumn1.DataPropertyName = "MaKhoa"
        Me.MaKhoaDataGridViewTextBoxColumn1.HeaderText = "Mã Khoa"
        Me.MaKhoaDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.MaKhoaDataGridViewTextBoxColumn1.Name = "MaKhoaDataGridViewTextBoxColumn1"
        Me.MaKhoaDataGridViewTextBoxColumn1.Width = 125
        '
        'KhoaHocDataGridViewTextBoxColumn
        '
        Me.KhoaHocDataGridViewTextBoxColumn.DataPropertyName = "KhoaHoc"
        Me.KhoaHocDataGridViewTextBoxColumn.HeaderText = "Khóa Học"
        Me.KhoaHocDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KhoaHocDataGridViewTextBoxColumn.Name = "KhoaHocDataGridViewTextBoxColumn"
        Me.KhoaHocDataGridViewTextBoxColumn.Width = 125
        '
        'HeDaoTaoDataGridViewTextBoxColumn
        '
        Me.HeDaoTaoDataGridViewTextBoxColumn.DataPropertyName = "HeDaoTao"
        Me.HeDaoTaoDataGridViewTextBoxColumn.HeaderText = "Hệ Đào Tạo"
        Me.HeDaoTaoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HeDaoTaoDataGridViewTextBoxColumn.Name = "HeDaoTaoDataGridViewTextBoxColumn"
        Me.HeDaoTaoDataGridViewTextBoxColumn.Width = 125
        '
        'NamNhapHocDataGridViewTextBoxColumn
        '
        Me.NamNhapHocDataGridViewTextBoxColumn.DataPropertyName = "NamNhapHoc"
        Me.NamNhapHocDataGridViewTextBoxColumn.HeaderText = "Năm Nhập Học"
        Me.NamNhapHocDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NamNhapHocDataGridViewTextBoxColumn.Name = "NamNhapHocDataGridViewTextBoxColumn"
        Me.NamNhapHocDataGridViewTextBoxColumn.Width = 125
        '
        'pnDMHocPhan
        '
        Me.pnDMHocPhan.BackColor = System.Drawing.Color.Silver
        Me.pnDMHocPhan.Controls.Add(Me.TTHPBindingNavigator)
        Me.pnDMHocPhan.Controls.Add(Me.pnDMHocPhanbot)
        Me.pnDMHocPhan.Controls.Add(Me.DataGridView4)
        Me.pnDMHocPhan.Location = New System.Drawing.Point(12, 155)
        Me.pnDMHocPhan.Name = "pnDMHocPhan"
        Me.pnDMHocPhan.Size = New System.Drawing.Size(901, 476)
        Me.pnDMHocPhan.TabIndex = 2
        '
        'TTHPBindingNavigator
        '
        Me.TTHPBindingNavigator.AddNewItem = Nothing
        Me.TTHPBindingNavigator.BackColor = System.Drawing.Color.Silver
        Me.TTHPBindingNavigator.BindingSource = Me.TTHPBindingSource
        Me.TTHPBindingNavigator.CountItem = Me.BindingNavigatorCountItem3
        Me.TTHPBindingNavigator.CountItemFormat = "/{0}"
        Me.TTHPBindingNavigator.DeleteItem = Nothing
        Me.TTHPBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TTHPBindingNavigator.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.TTHPBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem3, Me.BindingNavigatorMovePreviousItem3, Me.BindingNavigatorSeparator9, Me.BindingNavigatorPositionItem3, Me.BindingNavigatorCountItem3, Me.BindingNavigatorSeparator10, Me.BindingNavigatorMoveNextItem3, Me.BindingNavigatorMoveLastItem3, Me.BindingNavigatorSeparator11})
        Me.TTHPBindingNavigator.Location = New System.Drawing.Point(0, 444)
        Me.TTHPBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem3
        Me.TTHPBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem3
        Me.TTHPBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem3
        Me.TTHPBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem3
        Me.TTHPBindingNavigator.Name = "TTHPBindingNavigator"
        Me.TTHPBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem3
        Me.TTHPBindingNavigator.Size = New System.Drawing.Size(901, 32)
        Me.TTHPBindingNavigator.TabIndex = 5
        Me.TTHPBindingNavigator.Text = "BindingNavigator1"
        '
        'TTHPBindingSource
        '
        Me.TTHPBindingSource.DataMember = "DM_HocPhan"
        Me.TTHPBindingSource.DataSource = Me.DataSet13
        '
        'DataSet13
        '
        Me.DataSet13.DataSetName = "DataSet1"
        Me.DataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem3
        '
        Me.BindingNavigatorCountItem3.Name = "BindingNavigatorCountItem3"
        Me.BindingNavigatorCountItem3.Size = New System.Drawing.Size(33, 29)
        Me.BindingNavigatorCountItem3.Text = "/{0}"
        Me.BindingNavigatorCountItem3.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem3
        '
        Me.BindingNavigatorMoveFirstItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem3.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem3.Name = "BindingNavigatorMoveFirstItem3"
        Me.BindingNavigatorMoveFirstItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem3.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMoveFirstItem3.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem3
        '
        Me.BindingNavigatorMovePreviousItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem3.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem3.Name = "BindingNavigatorMovePreviousItem3"
        Me.BindingNavigatorMovePreviousItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem3.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMovePreviousItem3.Text = "Move previous"
        '
        'BindingNavigatorSeparator9
        '
        Me.BindingNavigatorSeparator9.Name = "BindingNavigatorSeparator9"
        Me.BindingNavigatorSeparator9.Size = New System.Drawing.Size(6, 32)
        '
        'BindingNavigatorPositionItem3
        '
        Me.BindingNavigatorPositionItem3.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem3.AutoSize = False
        Me.BindingNavigatorPositionItem3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem3.Name = "BindingNavigatorPositionItem3"
        Me.BindingNavigatorPositionItem3.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem3.Text = "0"
        Me.BindingNavigatorPositionItem3.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator10
        '
        Me.BindingNavigatorSeparator10.Name = "BindingNavigatorSeparator10"
        Me.BindingNavigatorSeparator10.Size = New System.Drawing.Size(6, 32)
        '
        'BindingNavigatorMoveNextItem3
        '
        Me.BindingNavigatorMoveNextItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem3.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem3.Name = "BindingNavigatorMoveNextItem3"
        Me.BindingNavigatorMoveNextItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem3.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMoveNextItem3.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem3
        '
        Me.BindingNavigatorMoveLastItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem3.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem3.Name = "BindingNavigatorMoveLastItem3"
        Me.BindingNavigatorMoveLastItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem3.Size = New System.Drawing.Size(29, 29)
        Me.BindingNavigatorMoveLastItem3.Text = "Move last"
        '
        'BindingNavigatorSeparator11
        '
        Me.BindingNavigatorSeparator11.Name = "BindingNavigatorSeparator11"
        Me.BindingNavigatorSeparator11.Size = New System.Drawing.Size(6, 32)
        '
        'pnDMHocPhanbot
        '
        Me.pnDMHocPhanbot.BackColor = System.Drawing.Color.White
        Me.pnDMHocPhanbot.Controls.Add(Me.btThoatDMHP)
        Me.pnDMHocPhanbot.Controls.Add(Me.btInDMHP)
        Me.pnDMHocPhanbot.Controls.Add(Me.btTimKiemDMHP)
        Me.pnDMHocPhanbot.Controls.Add(Me.btXoaDMHP)
        Me.pnDMHocPhanbot.Controls.Add(Me.btSuaDMHP)
        Me.pnDMHocPhanbot.Controls.Add(Me.txtHocKyDMHP)
        Me.pnDMHocPhanbot.Controls.Add(Me.txtMaKhoaDMHP)
        Me.pnDMHocPhanbot.Controls.Add(Me.txtSoTCDMHP)
        Me.pnDMHocPhanbot.Controls.Add(Me.txtTenHPDMHP)
        Me.pnDMHocPhanbot.Controls.Add(Me.Label22)
        Me.pnDMHocPhanbot.Controls.Add(Me.Label21)
        Me.pnDMHocPhanbot.Controls.Add(Me.sd)
        Me.pnDMHocPhanbot.Controls.Add(Me.qưe)
        Me.pnDMHocPhanbot.Controls.Add(Me.Label18)
        Me.pnDMHocPhanbot.Controls.Add(Me.txtMaHPDMHP)
        Me.pnDMHocPhanbot.Controls.Add(Me.btThemDMHP)
        Me.pnDMHocPhanbot.Location = New System.Drawing.Point(4, 223)
        Me.pnDMHocPhanbot.Name = "pnDMHocPhanbot"
        Me.pnDMHocPhanbot.Size = New System.Drawing.Size(893, 247)
        Me.pnDMHocPhanbot.TabIndex = 0
        '
        'btThoatDMHP
        '
        Me.btThoatDMHP.BackColor = System.Drawing.Color.Black
        Me.btThoatDMHP.FlatAppearance.BorderSize = 2
        Me.btThoatDMHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btThoatDMHP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btThoatDMHP.ForeColor = System.Drawing.Color.White
        Me.btThoatDMHP.Location = New System.Drawing.Point(734, 111)
        Me.btThoatDMHP.Name = "btThoatDMHP"
        Me.btThoatDMHP.Size = New System.Drawing.Size(112, 39)
        Me.btThoatDMHP.TabIndex = 15
        Me.btThoatDMHP.Text = "Thoát"
        Me.btThoatDMHP.UseVisualStyleBackColor = False
        '
        'btInDMHP
        '
        Me.btInDMHP.BackColor = System.Drawing.Color.Black
        Me.btInDMHP.FlatAppearance.BorderSize = 2
        Me.btInDMHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btInDMHP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInDMHP.ForeColor = System.Drawing.Color.White
        Me.btInDMHP.Location = New System.Drawing.Point(598, 110)
        Me.btInDMHP.Name = "btInDMHP"
        Me.btInDMHP.Size = New System.Drawing.Size(112, 39)
        Me.btInDMHP.TabIndex = 14
        Me.btInDMHP.Text = "In"
        Me.btInDMHP.UseVisualStyleBackColor = False
        '
        'btTimKiemDMHP
        '
        Me.btTimKiemDMHP.BackColor = System.Drawing.Color.Black
        Me.btTimKiemDMHP.FlatAppearance.BorderSize = 2
        Me.btTimKiemDMHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btTimKiemDMHP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTimKiemDMHP.ForeColor = System.Drawing.Color.White
        Me.btTimKiemDMHP.Location = New System.Drawing.Point(455, 111)
        Me.btTimKiemDMHP.Name = "btTimKiemDMHP"
        Me.btTimKiemDMHP.Size = New System.Drawing.Size(112, 39)
        Me.btTimKiemDMHP.TabIndex = 13
        Me.btTimKiemDMHP.Text = "Tìm kiếm"
        Me.btTimKiemDMHP.UseVisualStyleBackColor = False
        '
        'btXoaDMHP
        '
        Me.btXoaDMHP.BackColor = System.Drawing.Color.Black
        Me.btXoaDMHP.FlatAppearance.BorderSize = 2
        Me.btXoaDMHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btXoaDMHP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btXoaDMHP.ForeColor = System.Drawing.Color.White
        Me.btXoaDMHP.Location = New System.Drawing.Point(304, 111)
        Me.btXoaDMHP.Name = "btXoaDMHP"
        Me.btXoaDMHP.Size = New System.Drawing.Size(112, 39)
        Me.btXoaDMHP.TabIndex = 12
        Me.btXoaDMHP.Text = "Xóa"
        Me.btXoaDMHP.UseVisualStyleBackColor = False
        '
        'btSuaDMHP
        '
        Me.btSuaDMHP.BackColor = System.Drawing.Color.Black
        Me.btSuaDMHP.FlatAppearance.BorderSize = 2
        Me.btSuaDMHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSuaDMHP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSuaDMHP.ForeColor = System.Drawing.Color.White
        Me.btSuaDMHP.Location = New System.Drawing.Point(155, 111)
        Me.btSuaDMHP.Name = "btSuaDMHP"
        Me.btSuaDMHP.Size = New System.Drawing.Size(112, 38)
        Me.btSuaDMHP.TabIndex = 11
        Me.btSuaDMHP.Text = "Sửa"
        Me.btSuaDMHP.UseVisualStyleBackColor = False
        '
        'txtHocKyDMHP
        '
        Me.txtHocKyDMHP.BackColor = System.Drawing.Color.Silver
        Me.txtHocKyDMHP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet13, "DM_HocPhan.HocKy", True))
        Me.txtHocKyDMHP.Location = New System.Drawing.Point(672, 63)
        Me.txtHocKyDMHP.Name = "txtHocKyDMHP"
        Me.txtHocKyDMHP.Size = New System.Drawing.Size(145, 22)
        Me.txtHocKyDMHP.TabIndex = 10
        '
        'txtMaKhoaDMHP
        '
        Me.txtMaKhoaDMHP.BackColor = System.Drawing.Color.Silver
        Me.txtMaKhoaDMHP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet13, "DM_HocPhan.MaKhoa", True))
        Me.txtMaKhoaDMHP.Location = New System.Drawing.Point(506, 63)
        Me.txtMaKhoaDMHP.Name = "txtMaKhoaDMHP"
        Me.txtMaKhoaDMHP.Size = New System.Drawing.Size(145, 22)
        Me.txtMaKhoaDMHP.TabIndex = 9
        '
        'txtSoTCDMHP
        '
        Me.txtSoTCDMHP.BackColor = System.Drawing.Color.Silver
        Me.txtSoTCDMHP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet13, "DM_HocPhan.SoTinChi", True))
        Me.txtSoTCDMHP.Location = New System.Drawing.Point(339, 63)
        Me.txtSoTCDMHP.Name = "txtSoTCDMHP"
        Me.txtSoTCDMHP.Size = New System.Drawing.Size(145, 22)
        Me.txtSoTCDMHP.TabIndex = 8
        '
        'txtTenHPDMHP
        '
        Me.txtTenHPDMHP.BackColor = System.Drawing.Color.Silver
        Me.txtTenHPDMHP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet13, "DM_HocPhan.TenHocPhan", True))
        Me.txtTenHPDMHP.Location = New System.Drawing.Point(173, 62)
        Me.txtTenHPDMHP.Name = "txtTenHPDMHP"
        Me.txtTenHPDMHP.Size = New System.Drawing.Size(145, 22)
        Me.txtTenHPDMHP.TabIndex = 7
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(716, 35)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 21)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "Học Kỳ"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(547, 30)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 21)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Mã Khoa"
        '
        'sd
        '
        Me.sd.AutoSize = True
        Me.sd.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sd.Location = New System.Drawing.Point(365, 30)
        Me.sd.Name = "sd"
        Me.sd.Size = New System.Drawing.Size(92, 21)
        Me.sd.TabIndex = 4
        Me.sd.Text = "Số Tín Chỉ"
        '
        'qưe
        '
        Me.qưe.AutoSize = True
        Me.qưe.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qưe.Location = New System.Drawing.Point(178, 28)
        Me.qưe.Name = "qưe"
        Me.qưe.Size = New System.Drawing.Size(120, 21)
        Me.qưe.TabIndex = 3
        Me.qưe.Text = "Tên Học Phần"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(23, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(116, 21)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Mã Học Phần"
        '
        'txtMaHPDMHP
        '
        Me.txtMaHPDMHP.BackColor = System.Drawing.Color.Silver
        Me.txtMaHPDMHP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet13, "DM_HocPhan.MaHocPhan", True))
        Me.txtMaHPDMHP.Location = New System.Drawing.Point(13, 62)
        Me.txtMaHPDMHP.Name = "txtMaHPDMHP"
        Me.txtMaHPDMHP.Size = New System.Drawing.Size(145, 22)
        Me.txtMaHPDMHP.TabIndex = 1
        '
        'btThemDMHP
        '
        Me.btThemDMHP.BackColor = System.Drawing.Color.Black
        Me.btThemDMHP.FlatAppearance.BorderSize = 2
        Me.btThemDMHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btThemDMHP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btThemDMHP.ForeColor = System.Drawing.Color.White
        Me.btThemDMHP.Location = New System.Drawing.Point(13, 111)
        Me.btThemDMHP.Name = "btThemDMHP"
        Me.btThemDMHP.Size = New System.Drawing.Size(112, 38)
        Me.btThemDMHP.TabIndex = 0
        Me.btThemDMHP.Text = "Thêm"
        Me.btThemDMHP.UseVisualStyleBackColor = False
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaHocPhanDataGridViewTextBoxColumn, Me.TenHocPhanDataGridViewTextBoxColumn, Me.SoTinChiDataGridViewTextBoxColumn, Me.MaKhoaDataGridViewTextBoxColumn3, Me.HocKyDataGridViewTextBoxColumn})
        Me.DataGridView4.DataSource = Me.TTHPBindingSource
        Me.DataGridView4.Location = New System.Drawing.Point(4, 6)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 51
        Me.DataGridView4.RowTemplate.Height = 24
        Me.DataGridView4.Size = New System.Drawing.Size(893, 211)
        Me.DataGridView4.TabIndex = 1
        '
        'MaHocPhanDataGridViewTextBoxColumn
        '
        Me.MaHocPhanDataGridViewTextBoxColumn.DataPropertyName = "MaHocPhan"
        Me.MaHocPhanDataGridViewTextBoxColumn.HeaderText = "Mã Học Phần"
        Me.MaHocPhanDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaHocPhanDataGridViewTextBoxColumn.Name = "MaHocPhanDataGridViewTextBoxColumn"
        Me.MaHocPhanDataGridViewTextBoxColumn.Width = 125
        '
        'TenHocPhanDataGridViewTextBoxColumn
        '
        Me.TenHocPhanDataGridViewTextBoxColumn.DataPropertyName = "TenHocPhan"
        Me.TenHocPhanDataGridViewTextBoxColumn.HeaderText = "Tên Học Phần"
        Me.TenHocPhanDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TenHocPhanDataGridViewTextBoxColumn.Name = "TenHocPhanDataGridViewTextBoxColumn"
        Me.TenHocPhanDataGridViewTextBoxColumn.Width = 125
        '
        'SoTinChiDataGridViewTextBoxColumn
        '
        Me.SoTinChiDataGridViewTextBoxColumn.DataPropertyName = "SoTinChi"
        Me.SoTinChiDataGridViewTextBoxColumn.HeaderText = "Số Tín Chỉ"
        Me.SoTinChiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SoTinChiDataGridViewTextBoxColumn.Name = "SoTinChiDataGridViewTextBoxColumn"
        Me.SoTinChiDataGridViewTextBoxColumn.Width = 125
        '
        'MaKhoaDataGridViewTextBoxColumn3
        '
        Me.MaKhoaDataGridViewTextBoxColumn3.DataPropertyName = "MaKhoa"
        Me.MaKhoaDataGridViewTextBoxColumn3.HeaderText = "Mã Khoa"
        Me.MaKhoaDataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.MaKhoaDataGridViewTextBoxColumn3.Name = "MaKhoaDataGridViewTextBoxColumn3"
        Me.MaKhoaDataGridViewTextBoxColumn3.Width = 125
        '
        'HocKyDataGridViewTextBoxColumn
        '
        Me.HocKyDataGridViewTextBoxColumn.DataPropertyName = "HocKy"
        Me.HocKyDataGridViewTextBoxColumn.HeaderText = "Học Kỳ"
        Me.HocKyDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HocKyDataGridViewTextBoxColumn.Name = "HocKyDataGridViewTextBoxColumn"
        Me.HocKyDataGridViewTextBoxColumn.Width = 125
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT DM_Khoa.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     DM_Khoa"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLOLEDB.1;Data Source=LAPTOP-3DLTQ9EI\MSSQLSERVER01;Password=123456;Use" &
    "r ID=sa;Initial Catalog=QL_SinhVien"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [DM_Khoa] ([MaKhoa], [TenKhoa]) VALUES (?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, "MaKhoa"), New System.Data.OleDb.OleDbParameter("TenKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, "TenKhoa")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE [DM_Khoa] SET [MaKhoa] = ?, [TenKhoa] = ? WHERE (([MaKhoa] = ?) AND ([TenK" &
    "hoa] = ?))"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, "MaKhoa"), New System.Data.OleDb.OleDbParameter("TenKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, "TenKhoa"), New System.Data.OleDb.OleDbParameter("Original_MaKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenKhoa", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM [DM_Khoa] WHERE (([MaKhoa] = ?) AND ([TenKhoa] = ?))"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MaKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenKhoa", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DM_Khoa", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaKhoa", "MaKhoa"), New System.Data.Common.DataColumnMapping("TenKhoa", "TenKhoa")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT DM_Lop.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     DM_Lop"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO [DM_Lop] ([MaLop], [TenLop], [MaKhoa], [KhoaHoc], [HeDaoTao], [NamNha" &
    "pHoc]) VALUES (?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaLop", System.Data.OleDb.OleDbType.VarWChar, 0, "MaLop"), New System.Data.OleDb.OleDbParameter("TenLop", System.Data.OleDb.OleDbType.VarWChar, 0, "TenLop"), New System.Data.OleDb.OleDbParameter("MaKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, "MaKhoa"), New System.Data.OleDb.OleDbParameter("KhoaHoc", System.Data.OleDb.OleDbType.VarWChar, 0, "KhoaHoc"), New System.Data.OleDb.OleDbParameter("HeDaoTao", System.Data.OleDb.OleDbType.VarWChar, 0, "HeDaoTao"), New System.Data.OleDb.OleDbParameter("NamNhapHoc", System.Data.OleDb.OleDbType.[Integer], 0, "NamNhapHoc")})
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = resources.GetString("OleDbUpdateCommand2.CommandText")
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaLop", System.Data.OleDb.OleDbType.VarWChar, 0, "MaLop"), New System.Data.OleDb.OleDbParameter("TenLop", System.Data.OleDb.OleDbType.VarWChar, 0, "TenLop"), New System.Data.OleDb.OleDbParameter("MaKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, "MaKhoa"), New System.Data.OleDb.OleDbParameter("KhoaHoc", System.Data.OleDb.OleDbType.VarWChar, 0, "KhoaHoc"), New System.Data.OleDb.OleDbParameter("HeDaoTao", System.Data.OleDb.OleDbType.VarWChar, 0, "HeDaoTao"), New System.Data.OleDb.OleDbParameter("NamNhapHoc", System.Data.OleDb.OleDbType.[Integer], 0, "NamNhapHoc"), New System.Data.OleDb.OleDbParameter("Original_MaLop", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaLop", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenLop", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenLop", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_MaKhoa", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_KhoaHoc", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "KhoaHoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HeDaoTao", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HeDaoTao", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NamNhapHoc", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NamNhapHoc", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM [DM_Lop] WHERE (([MaLop] = ?) AND ([TenLop] = ?) AND ((? = 1 AND [MaK" &
    "hoa] IS NULL) OR ([MaKhoa] = ?)) AND ([KhoaHoc] = ?) AND ([HeDaoTao] = ?) AND ([" &
    "NamNhapHoc] = ?))"
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MaLop", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaLop", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenLop", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenLop", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_MaKhoa", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_KhoaHoc", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "KhoaHoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HeDaoTao", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HeDaoTao", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NamNhapHoc", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NamNhapHoc", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DM_Lop", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaLop", "MaLop"), New System.Data.Common.DataColumnMapping("TenLop", "TenLop"), New System.Data.Common.DataColumnMapping("MaKhoa", "MaKhoa"), New System.Data.Common.DataColumnMapping("KhoaHoc", "KhoaHoc"), New System.Data.Common.DataColumnMapping("HeDaoTao", "HeDaoTao"), New System.Data.Common.DataColumnMapping("NamNhapHoc", "NamNhapHoc")})})
        Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = "SELECT DM_SinhVien.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     DM_SinhVien"
        Me.OleDbSelectCommand3.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand3
        '
        Me.OleDbInsertCommand3.CommandText = "INSERT INTO [DM_SinhVien] ([MaSinhVien], [HoTen], [MaKhoa], [GioiTinh], [NgaySinh" &
    "], [DiaChi]) VALUES (?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand3.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand3.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaSinhVien", System.Data.OleDb.OleDbType.VarWChar, 0, "MaSinhVien"), New System.Data.OleDb.OleDbParameter("HoTen", System.Data.OleDb.OleDbType.VarWChar, 0, "HoTen"), New System.Data.OleDb.OleDbParameter("MaKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, "MaKhoa"), New System.Data.OleDb.OleDbParameter("GioiTinh", System.Data.OleDb.OleDbType.VarWChar, 0, "GioiTinh"), New System.Data.OleDb.OleDbParameter("NgaySinh", System.Data.OleDb.OleDbType.VarWChar, 0, "NgaySinh"), New System.Data.OleDb.OleDbParameter("DiaChi", System.Data.OleDb.OleDbType.LongVarWChar, 0, "DiaChi")})
        '
        'OleDbDataAdapter3
        '
        Me.OleDbDataAdapter3.InsertCommand = Me.OleDbInsertCommand3
        Me.OleDbDataAdapter3.SelectCommand = Me.OleDbSelectCommand3
        Me.OleDbDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DM_SinhVien", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaSinhVien", "MaSinhVien"), New System.Data.Common.DataColumnMapping("HoTen", "HoTen"), New System.Data.Common.DataColumnMapping("MaKhoa", "MaKhoa"), New System.Data.Common.DataColumnMapping("GioiTinh", "GioiTinh"), New System.Data.Common.DataColumnMapping("NgaySinh", "NgaySinh"), New System.Data.Common.DataColumnMapping("DiaChi", "DiaChi")})})
        '
        'OleDbSelectCommand4
        '
        Me.OleDbSelectCommand4.CommandText = "SELECT MaHocPhan, TenHocPhan, SoTinChi, MaKhoa, HocKy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     DM_HocPhan"
        Me.OleDbSelectCommand4.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand4
        '
        Me.OleDbInsertCommand4.CommandText = "INSERT INTO [DM_HocPhan] ([MaHocPhan], [TenHocPhan], [SoTinChi], [MaKhoa], [HocKy" &
    "]) VALUES (?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand4.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand4.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaHocPhan", System.Data.OleDb.OleDbType.VarWChar, 0, "MaHocPhan"), New System.Data.OleDb.OleDbParameter("TenHocPhan", System.Data.OleDb.OleDbType.VarWChar, 0, "TenHocPhan"), New System.Data.OleDb.OleDbParameter("SoTinChi", System.Data.OleDb.OleDbType.[Integer], 0, "SoTinChi"), New System.Data.OleDb.OleDbParameter("MaKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, "MaKhoa"), New System.Data.OleDb.OleDbParameter("HocKy", System.Data.OleDb.OleDbType.[Integer], 0, "HocKy")})
        '
        'OleDbUpdateCommand3
        '
        Me.OleDbUpdateCommand3.CommandText = resources.GetString("OleDbUpdateCommand3.CommandText")
        Me.OleDbUpdateCommand3.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand3.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaHocPhan", System.Data.OleDb.OleDbType.VarWChar, 0, "MaHocPhan"), New System.Data.OleDb.OleDbParameter("TenHocPhan", System.Data.OleDb.OleDbType.VarWChar, 0, "TenHocPhan"), New System.Data.OleDb.OleDbParameter("SoTinChi", System.Data.OleDb.OleDbType.[Integer], 0, "SoTinChi"), New System.Data.OleDb.OleDbParameter("MaKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, "MaKhoa"), New System.Data.OleDb.OleDbParameter("HocKy", System.Data.OleDb.OleDbType.[Integer], 0, "HocKy"), New System.Data.OleDb.OleDbParameter("Original_MaHocPhan", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaHocPhan", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenHocPhan", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenHocPhan", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SoTinChi", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SoTinChi", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_MaKhoa", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_HocKy", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "HocKy", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_HocKy", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HocKy", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand3
        '
        Me.OleDbDeleteCommand3.CommandText = "DELETE FROM [DM_HocPhan] WHERE (([MaHocPhan] = ?) AND ([TenHocPhan] = ?) AND ([So" &
    "TinChi] = ?) AND ((? = 1 AND [MaKhoa] IS NULL) OR ([MaKhoa] = ?)) AND ((? = 1 AN" &
    "D [HocKy] IS NULL) OR ([HocKy] = ?)))"
        Me.OleDbDeleteCommand3.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand3.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MaHocPhan", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaHocPhan", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenHocPhan", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenHocPhan", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SoTinChi", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SoTinChi", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_MaKhoa", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_HocKy", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "HocKy", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_HocKy", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HocKy", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter4
        '
        Me.OleDbDataAdapter4.DeleteCommand = Me.OleDbDeleteCommand3
        Me.OleDbDataAdapter4.InsertCommand = Me.OleDbInsertCommand4
        Me.OleDbDataAdapter4.SelectCommand = Me.OleDbSelectCommand4
        Me.OleDbDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DM_HocPhan", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaHocPhan", "MaHocPhan"), New System.Data.Common.DataColumnMapping("TenHocPhan", "TenHocPhan"), New System.Data.Common.DataColumnMapping("SoTinChi", "SoTinChi"), New System.Data.Common.DataColumnMapping("MaKhoa", "MaKhoa"), New System.Data.Common.DataColumnMapping("HocKy", "HocKy")})})
        Me.OleDbDataAdapter4.UpdateCommand = Me.OleDbUpdateCommand3
        '
        'OleDbSelectCommand5
        '
        Me.OleDbSelectCommand5.CommandText = "SELECT DM_DiemHocPhan.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     DM_DiemHocPhan"
        Me.OleDbSelectCommand5.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand5
        '
        Me.OleDbInsertCommand5.CommandText = "INSERT INTO [DM_DiemHocPhan] ([MaSinhVien], [MaHocPhan], [DiemHocPhan]) VALUES (?" &
    ", ?, ?)"
        Me.OleDbInsertCommand5.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand5.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaSinhVien", System.Data.OleDb.OleDbType.VarWChar, 0, "MaSinhVien"), New System.Data.OleDb.OleDbParameter("MaHocPhan", System.Data.OleDb.OleDbType.VarWChar, 0, "MaHocPhan"), New System.Data.OleDb.OleDbParameter("DiemHocPhan", System.Data.OleDb.OleDbType.[Double], 0, "DiemHocPhan")})
        '
        'OleDbUpdateCommand4
        '
        Me.OleDbUpdateCommand4.CommandText = "UPDATE [DM_DiemHocPhan] SET [MaSinhVien] = ?, [MaHocPhan] = ?, [DiemHocPhan] = ? " &
    "WHERE (([MaSinhVien] = ?) AND ([MaHocPhan] = ?) AND ((? = 1 AND [DiemHocPhan] IS" &
    " NULL) OR ([DiemHocPhan] = ?)))"
        Me.OleDbUpdateCommand4.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand4.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaSinhVien", System.Data.OleDb.OleDbType.VarWChar, 0, "MaSinhVien"), New System.Data.OleDb.OleDbParameter("MaHocPhan", System.Data.OleDb.OleDbType.VarWChar, 0, "MaHocPhan"), New System.Data.OleDb.OleDbParameter("DiemHocPhan", System.Data.OleDb.OleDbType.[Double], 0, "DiemHocPhan"), New System.Data.OleDb.OleDbParameter("Original_MaSinhVien", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSinhVien", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaHocPhan", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaHocPhan", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_DiemHocPhan", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DiemHocPhan", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_DiemHocPhan", System.Data.OleDb.OleDbType.[Double], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiemHocPhan", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand4
        '
        Me.OleDbDeleteCommand4.CommandText = "DELETE FROM [DM_DiemHocPhan] WHERE (([MaSinhVien] = ?) AND ([MaHocPhan] = ?) AND " &
    "((? = 1 AND [DiemHocPhan] IS NULL) OR ([DiemHocPhan] = ?)))"
        Me.OleDbDeleteCommand4.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand4.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MaSinhVien", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSinhVien", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaHocPhan", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaHocPhan", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_DiemHocPhan", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DiemHocPhan", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_DiemHocPhan", System.Data.OleDb.OleDbType.[Double], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiemHocPhan", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter5
        '
        Me.OleDbDataAdapter5.DeleteCommand = Me.OleDbDeleteCommand4
        Me.OleDbDataAdapter5.InsertCommand = Me.OleDbInsertCommand5
        Me.OleDbDataAdapter5.SelectCommand = Me.OleDbSelectCommand5
        Me.OleDbDataAdapter5.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DM_DiemHocPhan", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaSinhVien", "MaSinhVien"), New System.Data.Common.DataColumnMapping("MaHocPhan", "MaHocPhan"), New System.Data.Common.DataColumnMapping("DiemHocPhan", "DiemHocPhan")})})
        Me.OleDbDataAdapter5.UpdateCommand = Me.OleDbUpdateCommand4
        '
        'DM_KhoaTableAdapter
        '
        Me.DM_KhoaTableAdapter.ClearBeforeFill = True
        '
        'DM_LopTableAdapter
        '
        Me.DM_LopTableAdapter.ClearBeforeFill = True
        '
        'DM_SinhVienTableAdapter
        '
        Me.DM_SinhVienTableAdapter.ClearBeforeFill = True
        '
        'DM_HocPhanTableAdapter
        '
        Me.DM_HocPhanTableAdapter.ClearBeforeFill = True
        '
        'DM_DiemHocPhanTableAdapter
        '
        Me.DM_DiemHocPhanTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 643)
        Me.Controls.Add(Me.pnDMKhoa)
        Me.Controls.Add(Me.pnDMLop)
        Me.Controls.Add(Me.pnDMSV)
        Me.Controls.Add(Me.pnDMHocPhan)
        Me.Controls.Add(Me.pnDMDHP)
        Me.Controls.Add(Me.pnTab)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnTab.ResumeLayout(False)
        Me.pnDMDHP.ResumeLayout(False)
        Me.pnDMDHP.PerformLayout()
        CType(Me.TTDHPBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TTDHPBindingNavigator.ResumeLayout(False)
        Me.TTDHPBindingNavigator.PerformLayout()
        CType(Me.TTDHPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnDMDHPbot.ResumeLayout(False)
        Me.pnDMDHPbot.PerformLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnDMSV.ResumeLayout(False)
        Me.pnDMSV.PerformLayout()
        CType(Me.TTSVBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TTSVBindingNavigator.ResumeLayout(False)
        Me.TTSVBindingNavigator.PerformLayout()
        CType(Me.TTSVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnDMSVbot.ResumeLayout(False)
        Me.pnDMSVbot.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnDMKhoa.ResumeLayout(False)
        Me.pnDMKhoa.PerformLayout()
        CType(Me.TTKhoaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TTKhoaBindingNavigator.ResumeLayout(False)
        Me.TTKhoaBindingNavigator.PerformLayout()
        CType(Me.TTKhoaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnDMKhoabot.ResumeLayout(False)
        Me.pnDMKhoabot.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnDMLop.ResumeLayout(False)
        Me.pnDMLopbot.ResumeLayout(False)
        Me.pnDMLopbot.PerformLayout()
        CType(Me.TTLopBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TTLopBindingNavigator.ResumeLayout(False)
        Me.TTLopBindingNavigator.PerformLayout()
        CType(Me.TTLopBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnDMHocPhan.ResumeLayout(False)
        Me.pnDMHocPhan.PerformLayout()
        CType(Me.TTHPBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TTHPBindingNavigator.ResumeLayout(False)
        Me.TTHPBindingNavigator.PerformLayout()
        CType(Me.TTHPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnDMHocPhanbot.ResumeLayout(False)
        Me.pnDMHocPhanbot.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnTab As Panel
    Friend WithEvents btDMDHP As Button
    Friend WithEvents btDMSV As Button
    Friend WithEvents btDMKhoa As Button
    Public WithEvents pnDMDHP As Panel
    Public WithEvents pnDMSV As Panel
    Public WithEvents pnDMKhoa As Panel
    Friend WithEvents pnDMSVbot As Panel
    Friend WithEvents rbNu As RadioButton
    Friend WithEvents rbNam As RadioButton
    Friend WithEvents btXoaDMSV As Button
    Friend WithEvents btSuaDMSV As Button
    Friend WithEvents btThemDMSV As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDiaChiDMSV As TextBox
    Friend WithEvents txtNgaySinhDMSV As TextBox
    Friend WithEvents txtMaKhoaDMSV As TextBox
    Friend WithEvents txtHoTenDMSV As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaSVDMSV As TextBox
    Friend WithEvents pnDMDHPbot As Panel
    Friend WithEvents btXoaDMDHP As Button
    Friend WithEvents btSuaDMDHP As Button
    Friend WithEvents btThemDMDHP As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDiemHPDMDHP As TextBox
    Friend WithEvents txtMaHPDMDHP As TextBox
    Friend WithEvents txtMaSVDMDHP As TextBox
    Friend WithEvents btThoatDMSV As Button
    Friend WithEvents btThoatDMDHP As Button
    Friend WithEvents btInDMDHP As Button
    Friend WithEvents btTimKiemDMDHP As Button
    Friend WithEvents btInDMSV As Button
    Friend WithEvents btTimKiemDMSV As Button
    Friend WithEvents pnDMLop As Panel
    Friend WithEvents pnDMLopbot As Panel
    Friend WithEvents btThemDMLop As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtMaLopDML As TextBox
    Public WithEvents btDMHP As Button
    Public WithEvents btDMLop As Button
    Friend WithEvents txtTenLopDML As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btThoatDMLop As Button
    Friend WithEvents btInDMLop As Button
    Friend WithEvents btTimKiemDMLop As Button
    Friend WithEvents btXoaDMLop As Button
    Friend WithEvents btSuaDMLop As Button
    Friend WithEvents txtNamNhapHocDML As TextBox
    Friend WithEvents txtHeDTDML As TextBox
    Friend WithEvents txtKhoaHocDML As TextBox
    Friend WithEvents txtMaKhoaDML As TextBox
    Friend WithEvents pnDMHocPhan As Panel
    Friend WithEvents pnDMHocPhanbot As Panel
    Friend WithEvents btThoatDMHP As Button
    Friend WithEvents btInDMHP As Button
    Friend WithEvents btTimKiemDMHP As Button
    Friend WithEvents btXoaDMHP As Button
    Friend WithEvents btSuaDMHP As Button
    Friend WithEvents txtHocKyDMHP As TextBox
    Friend WithEvents txtMaKhoaDMHP As TextBox
    Friend WithEvents txtSoTCDMHP As TextBox
    Friend WithEvents txtTenHPDMHP As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents sd As Label
    Friend WithEvents qưe As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtMaHPDMHP As TextBox
    Friend WithEvents btThemDMHP As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents OleDbSelectCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter2 As OleDb.OleDbDataAdapter
    Friend WithEvents DataSet12 As DataSet1
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents OleDbSelectCommand3 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand3 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter3 As OleDb.OleDbDataAdapter
    Friend WithEvents DataSet14 As DataSet1
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents DataSet13 As DataSet1
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents OleDbSelectCommand4 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand4 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand3 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand3 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter4 As OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand5 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand5 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand4 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand4 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter5 As OleDb.OleDbDataAdapter
    Friend WithEvents TTKhoaBindingSource As BindingSource
    Friend WithEvents DM_KhoaTableAdapter As DataSet1TableAdapters.DM_KhoaTableAdapter
    Friend WithEvents pnDMKhoabot As Panel
    Friend WithEvents btInDMKhoa As Button
    Friend WithEvents btTimKiemDMKhoa As Button
    Friend WithEvents btThoatDMKhoa As Button
    Friend WithEvents btXoaDMKhoa As Button
    Friend WithEvents btSuaDMKhoa As Button
    Friend WithEvents btThemDMKhoa As Button
    Friend WithEvents txtTenKhoaDMK As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMaKhoaDMK As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TTKhoaBindingNavigator As BindingNavigator
    Friend WithEvents TTLopBindingSource As BindingSource
    Friend WithEvents DM_LopTableAdapter As DataSet1TableAdapters.DM_LopTableAdapter
    Friend WithEvents TTLopBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
    Friend WithEvents TTSVBindingSource As BindingSource
    Friend WithEvents DM_SinhVienTableAdapter As DataSet1TableAdapters.DM_SinhVienTableAdapter
    Friend WithEvents TTSVBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem2 As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator6 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem2 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator7 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator8 As ToolStripSeparator
    Friend WithEvents TTHPBindingSource As BindingSource
    Friend WithEvents DM_HocPhanTableAdapter As DataSet1TableAdapters.DM_HocPhanTableAdapter
    Friend WithEvents TTHPBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem3 As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem3 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem3 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator9 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem3 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator10 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem3 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem3 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator11 As ToolStripSeparator
    Friend WithEvents TTDHPBindingSource As BindingSource
    Friend WithEvents DM_DiemHocPhanTableAdapter As DataSet1TableAdapters.DM_DiemHocPhanTableAdapter
    Friend WithEvents TTDHPBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem4 As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem4 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem4 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator12 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem4 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator13 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem4 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem4 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator14 As ToolStripSeparator
    Friend WithEvents MaSinhVienDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MaHocPhanDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DiemHocPhanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaKhoaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenKhoaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaLopDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenLopDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaKhoaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents KhoaHocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HeDaoTaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamNhapHocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaHocPhanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenHocPhanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoTinChiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaKhoaDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents HocKyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MaSinhVienDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoTenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaKhoaDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents GioiTinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgaySinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiaChiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BindingSource1 As BindingSource
End Class
