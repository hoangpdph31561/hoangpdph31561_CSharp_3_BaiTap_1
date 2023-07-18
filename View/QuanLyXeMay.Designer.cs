namespace hoangpdph31561_CSharp_3_BaiTap_1.View
{
    partial class QuanLyXeMay
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            cmbSoLuong = new ComboBox();
            txtGiaNhap = new TextBox();
            txtMoTa = new TextBox();
            txtTenXe = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            groupBox3 = new GroupBox();
            dgvXeMay = new DataGridView();
            txtTimKiem = new TextBox();
            label5 = new Label();
            err = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvXeMay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbSoLuong);
            groupBox1.Controls.Add(txtGiaNhap);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(txtTenXe);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(638, 345);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // cmbSoLuong
            // 
            cmbSoLuong.FormattingEnabled = true;
            cmbSoLuong.Location = new Point(193, 288);
            cmbSoLuong.Name = "cmbSoLuong";
            cmbSoLuong.Size = new Size(390, 28);
            cmbSoLuong.TabIndex = 7;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(193, 209);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(390, 27);
            txtGiaNhap.TabIndex = 6;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(193, 129);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(390, 27);
            txtMoTa.TabIndex = 5;
            // 
            // txtTenXe
            // 
            txtTenXe.Location = new Point(193, 53);
            txtTenXe.Name = "txtTenXe";
            txtTenXe.Size = new Size(390, 27);
            txtTenXe.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 296);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 216);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "Giá nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 136);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Mô tả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 56);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên xe";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(656, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(398, 345);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(6, 236);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(386, 80);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(6, 139);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(386, 80);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 48);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(386, 80);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvXeMay);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(12, 363);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1042, 380);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hiển thị";
            // 
            // dgvXeMay
            // 
            dgvXeMay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvXeMay.Location = new Point(43, 122);
            dgvXeMay.Name = "dgvXeMay";
            dgvXeMay.RowHeadersWidth = 51;
            dgvXeMay.RowTemplate.Height = 29;
            dgvXeMay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvXeMay.Size = new Size(950, 228);
            dgvXeMay.TabIndex = 2;
            dgvXeMay.CellClick += dgvXeMay_CellClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(193, 59);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(733, 27);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.Text = "Nhập tên cần tìm ở đây";
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            txtTimKiem.Leave += txtTimKiem_Leave;
            txtTimKiem.MouseEnter += textBox4_MouseEnter;
            txtTimKiem.MouseLeave += txtTimKiem_MouseLeave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 62);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 0;
            label5.Text = "Tìm kiếm";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // QuanLyXeMay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 755);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "QuanLyXeMay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuanLyXeMay";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvXeMay).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox cmbSoLuong;
        private TextBox txtGiaNhap;
        private TextBox txtMoTa;
        private TextBox txtTenXe;
        private Button btnClear;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dgvXeMay;
        private TextBox txtTimKiem;
        private Label label5;
        private ErrorProvider err;
    }
}