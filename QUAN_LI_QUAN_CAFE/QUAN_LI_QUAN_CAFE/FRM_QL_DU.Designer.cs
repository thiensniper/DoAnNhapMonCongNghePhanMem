namespace QUAN_LI_QUAN_CAFE
{
    partial class FRM_QL_DU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_QL_DU));
            this.dgridvDoUong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.BT_E = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDoUong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDoUong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbLoaiDoUong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.cbbDoTangKem = new System.Windows.Forms.ComboBox();
            this.GB_1 = new System.Windows.Forms.GroupBox();
            this.GB_2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgridvDoUong)).BeginInit();
            this.GB_1.SuspendLayout();
            this.GB_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgridvDoUong
            // 
            this.dgridvDoUong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridvDoUong.Location = new System.Drawing.Point(11, 53);
            this.dgridvDoUong.Margin = new System.Windows.Forms.Padding(4);
            this.dgridvDoUong.Name = "dgridvDoUong";
            this.dgridvDoUong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridvDoUong.Size = new System.Drawing.Size(747, 314);
            this.dgridvDoUong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÊM ĐỒ UỐNG VÀO DANH SÁCH";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(8, 16);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(253, 70);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "THÊM ĐỒ UỐNG MỚI";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(8, 91);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(253, 70);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "CHỈNH SỬA ĐỒ UỐNG";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(8, 166);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(253, 70);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "XÓA ĐỒ UỐNG";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // BT_E
            // 
            this.BT_E.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_E.ForeColor = System.Drawing.Color.Red;
            this.BT_E.Location = new System.Drawing.Point(8, 241);
            this.BT_E.Margin = new System.Windows.Forms.Padding(4);
            this.BT_E.Name = "BT_E";
            this.BT_E.Size = new System.Drawing.Size(253, 70);
            this.BT_E.TabIndex = 4;
            this.BT_E.Text = "THOÁT";
            this.BT_E.UseVisualStyleBackColor = true;
            this.BT_E.Click += new System.EventHandler(this.BT_E_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "MÃ ĐỒ UỐNG";
            // 
            // txtMaDoUong
            // 
            this.txtMaDoUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDoUong.Location = new System.Drawing.Point(217, 21);
            this.txtMaDoUong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDoUong.Multiline = true;
            this.txtMaDoUong.Name = "txtMaDoUong";
            this.txtMaDoUong.Size = new System.Drawing.Size(215, 27);
            this.txtMaDoUong.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "TÊN ĐỒ UỐNG";
            // 
            // txtTenDoUong
            // 
            this.txtTenDoUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDoUong.Location = new System.Drawing.Point(217, 69);
            this.txtTenDoUong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDoUong.Multiline = true;
            this.txtTenDoUong.Name = "txtTenDoUong";
            this.txtTenDoUong.Size = new System.Drawing.Size(215, 27);
            this.txtTenDoUong.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "LOẠI ĐỒ UỐNG";
            // 
            // cbbLoaiDoUong
            // 
            this.cbbLoaiDoUong.FormattingEnabled = true;
            this.cbbLoaiDoUong.Items.AddRange(new object[] {
            "GIẢI KHÁT CÓ GAS",
            "HOA QUẢ",
            "RƯỢU BIA"});
            this.cbbLoaiDoUong.Location = new System.Drawing.Point(217, 121);
            this.cbbLoaiDoUong.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLoaiDoUong.Name = "cbbLoaiDoUong";
            this.cbbLoaiDoUong.Size = new System.Drawing.Size(215, 24);
            this.cbbLoaiDoUong.TabIndex = 5;
            this.cbbLoaiDoUong.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiDoUong_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(505, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "ĐƠN GIÁ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(505, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "ĐỒ DÙNG TẶNG KÈM";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(796, 21);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(215, 27);
            this.txtDonGia.TabIndex = 4;
            // 
            // cbbDoTangKem
            // 
            this.cbbDoTangKem.FormattingEnabled = true;
            this.cbbDoTangKem.Items.AddRange(new object[] {
            "BÁNH CHOCOLATE",
            "KHOAI TÂY CHIÊN",
            "KEM",
            "KẸO"});
            this.cbbDoTangKem.Location = new System.Drawing.Point(796, 73);
            this.cbbDoTangKem.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDoTangKem.Name = "cbbDoTangKem";
            this.cbbDoTangKem.Size = new System.Drawing.Size(215, 24);
            this.cbbDoTangKem.TabIndex = 5;
            // 
            // GB_1
            // 
            this.GB_1.Controls.Add(this.btnAdd);
            this.GB_1.Controls.Add(this.btnEdit);
            this.GB_1.Controls.Add(this.btnDelete);
            this.GB_1.Controls.Add(this.BT_E);
            this.GB_1.Location = new System.Drawing.Point(765, 46);
            this.GB_1.Margin = new System.Windows.Forms.Padding(4);
            this.GB_1.Name = "GB_1";
            this.GB_1.Padding = new System.Windows.Forms.Padding(4);
            this.GB_1.Size = new System.Drawing.Size(271, 321);
            this.GB_1.TabIndex = 0;
            this.GB_1.TabStop = false;
            // 
            // GB_2
            // 
            this.GB_2.Controls.Add(this.txtMaDoUong);
            this.GB_2.Controls.Add(this.label2);
            this.GB_2.Controls.Add(this.label3);
            this.GB_2.Controls.Add(this.label5);
            this.GB_2.Controls.Add(this.cbbDoTangKem);
            this.GB_2.Controls.Add(this.label4);
            this.GB_2.Controls.Add(this.cbbLoaiDoUong);
            this.GB_2.Controls.Add(this.label6);
            this.GB_2.Controls.Add(this.txtDonGia);
            this.GB_2.Controls.Add(this.txtTenDoUong);
            this.GB_2.Location = new System.Drawing.Point(11, 374);
            this.GB_2.Margin = new System.Windows.Forms.Padding(4);
            this.GB_2.Name = "GB_2";
            this.GB_2.Padding = new System.Windows.Forms.Padding(4);
            this.GB_2.Size = new System.Drawing.Size(1027, 161);
            this.GB_2.TabIndex = 9;
            this.GB_2.TabStop = false;
            // 
            // FRM_QL_DU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 544);
            this.Controls.Add(this.GB_2);
            this.Controls.Add(this.GB_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgridvDoUong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FRM_QL_DU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LẬP DANH SÁCH ĐỒ UỐNG";
            this.Load += new System.EventHandler(this.FRM_QL_DU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridvDoUong)).EndInit();
            this.GB_1.ResumeLayout(false);
            this.GB_2.ResumeLayout(false);
            this.GB_2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgridvDoUong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button BT_E;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDoUong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDoUong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbLoaiDoUong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ComboBox cbbDoTangKem;
        private System.Windows.Forms.GroupBox GB_1;
        private System.Windows.Forms.GroupBox GB_2;
    }
}