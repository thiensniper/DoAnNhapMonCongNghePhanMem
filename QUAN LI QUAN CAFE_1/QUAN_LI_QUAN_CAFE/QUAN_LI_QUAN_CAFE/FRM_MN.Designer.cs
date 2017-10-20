namespace QUAN_LI_QUAN_CAFE
{
    partial class FRM_MN
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
            this.GB_1 = new System.Windows.Forms.GroupBox();
            this.BT_DU = new System.Windows.Forms.Button();
            this.BT_CB = new System.Windows.Forms.Button();
            this.BT_E = new System.Windows.Forms.Button();
            this.BT_TIM = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GB_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_1
            // 
            this.GB_1.Controls.Add(this.BT_DU);
            this.GB_1.Controls.Add(this.BT_CB);
            this.GB_1.Controls.Add(this.BT_E);
            this.GB_1.Controls.Add(this.BT_TIM);
            this.GB_1.Location = new System.Drawing.Point(564, 7);
            this.GB_1.Name = "GB_1";
            this.GB_1.Size = new System.Drawing.Size(203, 264);
            this.GB_1.TabIndex = 3;
            this.GB_1.TabStop = false;
            // 
            // BT_DU
            // 
            this.BT_DU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_DU.Location = new System.Drawing.Point(6, 13);
            this.BT_DU.Name = "BT_DU";
            this.BT_DU.Size = new System.Drawing.Size(190, 57);
            this.BT_DU.TabIndex = 1;
            this.BT_DU.Text = "XEM MENU ĐỒ UỐNG";
            this.BT_DU.UseVisualStyleBackColor = true;
            this.BT_DU.Click += new System.EventHandler(this.BT_DU_Click);
            // 
            // BT_CB
            // 
            this.BT_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CB.Location = new System.Drawing.Point(6, 74);
            this.BT_CB.Name = "BT_CB";
            this.BT_CB.Size = new System.Drawing.Size(190, 57);
            this.BT_CB.TabIndex = 2;
            this.BT_CB.Text = "XEM MENU COMBO";
            this.BT_CB.UseVisualStyleBackColor = true;
            // 
            // BT_E
            // 
            this.BT_E.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_E.ForeColor = System.Drawing.Color.Red;
            this.BT_E.Location = new System.Drawing.Point(6, 199);
            this.BT_E.Name = "BT_E";
            this.BT_E.Size = new System.Drawing.Size(190, 57);
            this.BT_E.TabIndex = 4;
            this.BT_E.Text = "THOÁT";
            this.BT_E.UseVisualStyleBackColor = true;
            this.BT_E.Click += new System.EventHandler(this.BT_E_Click);
            // 
            // BT_TIM
            // 
            this.BT_TIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_TIM.Location = new System.Drawing.Point(6, 137);
            this.BT_TIM.Name = "BT_TIM";
            this.BT_TIM.Size = new System.Drawing.Size(190, 57);
            this.BT_TIM.TabIndex = 3;
            this.BT_TIM.Text = "TÌM NÂNG CAO";
            this.BT_TIM.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 422);
            this.dataGridView1.TabIndex = 2;
            // 
            // FRM_MN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 442);
            this.Controls.Add(this.GB_1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "FRM_MN";
            this.Text = "TRA CỨU ĐỒ UỐNG (MENU)";
            this.GB_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_1;
        private System.Windows.Forms.Button BT_DU;
        private System.Windows.Forms.Button BT_CB;
        private System.Windows.Forms.Button BT_E;
        private System.Windows.Forms.Button BT_TIM;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}