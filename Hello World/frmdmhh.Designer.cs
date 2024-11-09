
namespace Hello_World
{
    partial class frmdmhh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDgusd = new System.Windows.Forms.TextBox();
            this.txtSanxuat = new System.Windows.Forms.TextBox();
            this.txtDgvnd = new System.Windows.Forms.TextBox();
            this.txtDvt = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.txtMaNhom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrv = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.GrdData = new System.Windows.Forms.DataGridView();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGvnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sanxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGusd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGvndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGusdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baoHanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDMHHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHDataSet = new Hello_World.QLBHDataSet();
            this.tblDMHHTableAdapter = new Hello_World.QLBHDataSetTableAdapters.tblDMHHTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.comTenTruong = new System.Windows.Forms.ComboBox();
            this.comGT = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDMHHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupbox1
            // 
            this.groupbox1.Location = new System.Drawing.Point(9, 29);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(721, 317);
            this.groupbox1.TabIndex = 0;
            this.groupbox1.TabStop = false;
            this.groupbox1.Enter += new System.EventHandler(this.GrdData_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDgusd);
            this.groupBox2.Controls.Add(this.txtSanxuat);
            this.groupBox2.Controls.Add(this.txtDgvnd);
            this.groupBox2.Controls.Add(this.txtDvt);
            this.groupBox2.Controls.Add(this.txtTenHH);
            this.groupBox2.Controls.Add(this.txtMaHH);
            this.groupBox2.Controls.Add(this.txtMaNhom);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(745, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 354);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtDgusd
            // 
            this.txtDgusd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDgusd.Location = new System.Drawing.Point(129, 275);
            this.txtDgusd.Name = "txtDgusd";
            this.txtDgusd.Size = new System.Drawing.Size(309, 27);
            this.txtDgusd.TabIndex = 13;
            // 
            // txtSanxuat
            // 
            this.txtSanxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSanxuat.Location = new System.Drawing.Point(130, 243);
            this.txtSanxuat.Name = "txtSanxuat";
            this.txtSanxuat.Size = new System.Drawing.Size(308, 27);
            this.txtSanxuat.TabIndex = 12;
            // 
            // txtDgvnd
            // 
            this.txtDgvnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDgvnd.Location = new System.Drawing.Point(130, 210);
            this.txtDgvnd.Name = "txtDgvnd";
            this.txtDgvnd.Size = new System.Drawing.Size(308, 27);
            this.txtDgvnd.TabIndex = 11;
            // 
            // txtDvt
            // 
            this.txtDvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDvt.Location = new System.Drawing.Point(130, 177);
            this.txtDvt.Name = "txtDvt";
            this.txtDvt.Size = new System.Drawing.Size(308, 27);
            this.txtDvt.TabIndex = 10;
            // 
            // txtTenHH
            // 
            this.txtTenHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHH.Location = new System.Drawing.Point(130, 109);
            this.txtTenHH.Multiline = true;
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(308, 50);
            this.txtTenHH.TabIndex = 9;
            // 
            // txtMaHH
            // 
            this.txtMaHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHH.Location = new System.Drawing.Point(130, 73);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(308, 27);
            this.txtMaHH.TabIndex = 8;
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhom.Location = new System.Drawing.Point(130, 35);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(308, 27);
            this.txtMaNhom.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đơn giá USD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nước SX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ĐVT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hàng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhóm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLast);
            this.groupBox3.Controls.Add(this.btnNext);
            this.groupBox3.Controls.Add(this.btnPrv);
            this.groupBox3.Controls.Add(this.btnFirst);
            this.groupBox3.Location = new System.Drawing.Point(9, 363);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(721, 148);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.SystemColors.Control;
            this.btnLast.Location = new System.Drawing.Point(334, 51);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(87, 41);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = "Cuối";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.Location = new System.Drawing.Point(241, 51);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(87, 41);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Sau";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrv
            // 
            this.btnPrv.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrv.Location = new System.Drawing.Point(148, 51);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(87, 41);
            this.btnPrv.TabIndex = 1;
            this.btnPrv.Text = "Trước";
            this.btnPrv.UseVisualStyleBackColor = false;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.SystemColors.Control;
            this.btnFirst.Location = new System.Drawing.Point(55, 51);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(87, 41);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "Đầu";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.button1_Click);
            // 
            // GrdData
            // 
            this.GrdData.AllowUserToDeleteRows = false;
            this.GrdData.AutoGenerateColumns = false;
            this.GrdData.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.GrdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhom,
            this.MaHH,
            this.TenHH,
            this.Dvt,
            this.DGvnd,
            this.Sanxuat,
            this.DGusd,
            this.BaoHanh,
            this.maNhomDataGridViewTextBoxColumn,
            this.maHHDataGridViewTextBoxColumn,
            this.tenHHDataGridViewTextBoxColumn,
            this.dvtDataGridViewTextBoxColumn,
            this.dGvndDataGridViewTextBoxColumn,
            this.dGusdDataGridViewTextBoxColumn,
            this.sanXuatDataGridViewTextBoxColumn,
            this.baoHanhDataGridViewTextBoxColumn});
            this.GrdData.DataSource = this.tblDMHHBindingSource;
            this.GrdData.Location = new System.Drawing.Point(12, 29);
            this.GrdData.Name = "GrdData";
            this.GrdData.RowHeadersWidth = 51;
            this.GrdData.RowTemplate.Height = 24;
            this.GrdData.Size = new System.Drawing.Size(718, 317);
            this.GrdData.TabIndex = 0;
            this.GrdData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdData_CellContentClick);
            // 
            // MaNhom
            // 
            this.MaNhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaNhom.DataPropertyName = "MaNhom";
            this.MaNhom.HeaderText = "Mã Nhóm";
            this.MaNhom.MinimumWidth = 6;
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.ReadOnly = true;
            this.MaNhom.Width = 97;
            // 
            // MaHH
            // 
            this.MaHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaHH.DataPropertyName = "MaHH";
            this.MaHH.HeaderText = "Mã Hàng";
            this.MaHH.MinimumWidth = 6;
            this.MaHH.Name = "MaHH";
            this.MaHH.Width = 94;
            // 
            // TenHH
            // 
            this.TenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenHH.DataPropertyName = "TenHH";
            this.TenHH.HeaderText = "Tên Hàng";
            this.TenHH.MinimumWidth = 6;
            this.TenHH.Name = "TenHH";
            // 
            // Dvt
            // 
            this.Dvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Dvt.DataPropertyName = "Dvt";
            this.Dvt.HeaderText = "Dv Tính";
            this.Dvt.MinimumWidth = 6;
            this.Dvt.Name = "Dvt";
            this.Dvt.Width = 86;
            // 
            // DGvnd
            // 
            this.DGvnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DGvnd.DataPropertyName = "DGvnd";
            this.DGvnd.HeaderText = "Đơn giá";
            this.DGvnd.MinimumWidth = 6;
            this.DGvnd.Name = "DGvnd";
            this.DGvnd.Width = 86;
            // 
            // Sanxuat
            // 
            this.Sanxuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sanxuat.DataPropertyName = "SanXuat";
            this.Sanxuat.HeaderText = "Nước Sx";
            this.Sanxuat.MinimumWidth = 6;
            this.Sanxuat.Name = "Sanxuat";
            this.Sanxuat.Width = 89;
            // 
            // DGusd
            // 
            this.DGusd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DGusd.DataPropertyName = "DGusd";
            this.DGusd.HeaderText = "Đơn giá USD";
            this.DGusd.MinimumWidth = 6;
            this.DGusd.Name = "DGusd";
            this.DGusd.Width = 119;
            // 
            // BaoHanh
            // 
            this.BaoHanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BaoHanh.DataPropertyName = "BaoHanh";
            this.BaoHanh.HeaderText = "Bảo Hành";
            this.BaoHanh.MinimumWidth = 6;
            this.BaoHanh.Name = "BaoHanh";
            // 
            // maNhomDataGridViewTextBoxColumn
            // 
            this.maNhomDataGridViewTextBoxColumn.DataPropertyName = "MaNhom";
            this.maNhomDataGridViewTextBoxColumn.HeaderText = "MaNhom";
            this.maNhomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNhomDataGridViewTextBoxColumn.Name = "maNhomDataGridViewTextBoxColumn";
            this.maNhomDataGridViewTextBoxColumn.Width = 125;
            // 
            // maHHDataGridViewTextBoxColumn
            // 
            this.maHHDataGridViewTextBoxColumn.DataPropertyName = "MaHH";
            this.maHHDataGridViewTextBoxColumn.HeaderText = "MaHH";
            this.maHHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHHDataGridViewTextBoxColumn.Name = "maHHDataGridViewTextBoxColumn";
            this.maHHDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenHHDataGridViewTextBoxColumn
            // 
            this.tenHHDataGridViewTextBoxColumn.DataPropertyName = "TenHH";
            this.tenHHDataGridViewTextBoxColumn.HeaderText = "TenHH";
            this.tenHHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenHHDataGridViewTextBoxColumn.Name = "tenHHDataGridViewTextBoxColumn";
            this.tenHHDataGridViewTextBoxColumn.Width = 125;
            // 
            // dvtDataGridViewTextBoxColumn
            // 
            this.dvtDataGridViewTextBoxColumn.DataPropertyName = "Dvt";
            this.dvtDataGridViewTextBoxColumn.HeaderText = "Dvt";
            this.dvtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dvtDataGridViewTextBoxColumn.Name = "dvtDataGridViewTextBoxColumn";
            this.dvtDataGridViewTextBoxColumn.Width = 125;
            // 
            // dGvndDataGridViewTextBoxColumn
            // 
            this.dGvndDataGridViewTextBoxColumn.DataPropertyName = "DGvnd";
            this.dGvndDataGridViewTextBoxColumn.HeaderText = "DGvnd";
            this.dGvndDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dGvndDataGridViewTextBoxColumn.Name = "dGvndDataGridViewTextBoxColumn";
            this.dGvndDataGridViewTextBoxColumn.Width = 125;
            // 
            // dGusdDataGridViewTextBoxColumn
            // 
            this.dGusdDataGridViewTextBoxColumn.DataPropertyName = "DGusd";
            this.dGusdDataGridViewTextBoxColumn.HeaderText = "DGusd";
            this.dGusdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dGusdDataGridViewTextBoxColumn.Name = "dGusdDataGridViewTextBoxColumn";
            this.dGusdDataGridViewTextBoxColumn.Width = 125;
            // 
            // sanXuatDataGridViewTextBoxColumn
            // 
            this.sanXuatDataGridViewTextBoxColumn.DataPropertyName = "SanXuat";
            this.sanXuatDataGridViewTextBoxColumn.HeaderText = "SanXuat";
            this.sanXuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sanXuatDataGridViewTextBoxColumn.Name = "sanXuatDataGridViewTextBoxColumn";
            this.sanXuatDataGridViewTextBoxColumn.Width = 125;
            // 
            // baoHanhDataGridViewTextBoxColumn
            // 
            this.baoHanhDataGridViewTextBoxColumn.DataPropertyName = "BaoHanh";
            this.baoHanhDataGridViewTextBoxColumn.HeaderText = "BaoHanh";
            this.baoHanhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.baoHanhDataGridViewTextBoxColumn.Name = "baoHanhDataGridViewTextBoxColumn";
            this.baoHanhDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblDMHHBindingSource
            // 
            this.tblDMHHBindingSource.DataMember = "tblDMHH";
            this.tblDMHHBindingSource.DataSource = this.qLBHDataSet;
            // 
            // qLBHDataSet
            // 
            this.qLBHDataSet.DataSetName = "QLBHDataSet";
            this.qLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDMHHTableAdapter
            // 
            this.tblDMHHTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(754, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Lọc dữ liệu:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // comTenTruong
            // 
            this.comTenTruong.FormattingEnabled = true;
            this.comTenTruong.Items.AddRange(new object[] {
            "MaNhom",
            "MaHH",
            "SanXuat",
            "TenHH"});
            this.comTenTruong.Location = new System.Drawing.Point(745, 102);
            this.comTenTruong.Name = "comTenTruong";
            this.comTenTruong.Size = new System.Drawing.Size(208, 24);
            this.comTenTruong.TabIndex = 5;
            this.comTenTruong.SelectedIndexChanged += new System.EventHandler(this.comTenTruong_SelectedIndexChanged);
            // 
            // comGT
            // 
            this.comGT.FormattingEnabled = true;
            this.comGT.Location = new System.Drawing.Point(985, 102);
            this.comGT.Name = "comGT";
            this.comGT.Size = new System.Drawing.Size(208, 24);
            this.comGT.TabIndex = 6;
            this.comGT.SelectedIndexChanged += new System.EventHandler(this.comGT_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1094, 29);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 37);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Nạp lại";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(982, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Giá trị";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(750, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tên trường";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(960, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "=";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(985, 29);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(89, 37);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "Lọc dữ liệu";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // frmdmhh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1205, 541);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.comGT);
            this.Controls.Add(this.comTenTruong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GrdData);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupbox1);
            this.Name = "frmdmhh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmdmhh";
            this.Load += new System.EventHandler(this.frmdmhh_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDMHHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView GrdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGvnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sanxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGusd;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaoHanh;
        private QLBHDataSet qLBHDataSet;
        private System.Windows.Forms.BindingSource tblDMHHBindingSource;
        private QLBHDataSetTableAdapters.tblDMHHTableAdapter tblDMHHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGvndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGusdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baoHanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrv;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDvt;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.TextBox txtMaNhom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDgusd;
        private System.Windows.Forms.TextBox txtSanxuat;
        private System.Windows.Forms.TextBox txtDgvnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comTenTruong;
        private System.Windows.Forms.ComboBox comGT;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnFilter;
    }
}