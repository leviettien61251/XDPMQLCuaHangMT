namespace XDPMQLCuaHangMT
{
    partial class FormVoucherOUT
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
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddProductToDetail = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonRemoveProductFromDetail = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxSearchProduct = new System.Windows.Forms.TextBox();
            this.buttonSearchProduct = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxCreatedDate = new System.Windows.Forms.TextBox();
            this.labelCreatedDate = new System.Windows.Forms.Label();
            this.textBoxVoucherId = new System.Windows.Forms.TextBox();
            this.labelVoucherId = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxSearchVoucherIN = new System.Windows.Forms.TextBox();
            this.buttonSearchVoucherIN = new System.Windows.Forms.Button();
            this.dgvDetailProduct = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailProduct)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.Location = new System.Drawing.Point(89, 3);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(128, 24);
            this.textBoxQuantity.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.textBoxQuantity);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.tableLayoutPanel6.SetRowSpan(this.flowLayoutPanel2, 2);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(225, 80);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng:";
            // 
            // buttonAddProductToDetail
            // 
            this.buttonAddProductToDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProductToDetail.Location = new System.Drawing.Point(3, 3);
            this.buttonAddProductToDetail.Name = "buttonAddProductToDetail";
            this.buttonAddProductToDetail.Size = new System.Drawing.Size(113, 34);
            this.buttonAddProductToDetail.TabIndex = 0;
            this.buttonAddProductToDetail.Text = "Chọn";
            this.buttonAddProductToDetail.UseVisualStyleBackColor = true;
            this.buttonAddProductToDetail.Click += new System.EventHandler(this.buttonAddProductToDetail_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(122, 3);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(113, 34);
            this.buttonConfirm.TabIndex = 1;
            this.buttonConfirm.Text = "Xác nhận";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonRemoveProductFromDetail
            // 
            this.buttonRemoveProductFromDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveProductFromDetail.Location = new System.Drawing.Point(3, 43);
            this.buttonRemoveProductFromDetail.Name = "buttonRemoveProductFromDetail";
            this.buttonRemoveProductFromDetail.Size = new System.Drawing.Size(113, 34);
            this.buttonRemoveProductFromDetail.TabIndex = 2;
            this.buttonRemoveProductFromDetail.Text = "Xóa";
            this.buttonRemoveProductFromDetail.UseVisualStyleBackColor = true;
            this.buttonRemoveProductFromDetail.Click += new System.EventHandler(this.buttonRemoveProductFromDetail_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonAddProductToDetail);
            this.flowLayoutPanel1.Controls.Add(this.buttonConfirm);
            this.flowLayoutPanel1.Controls.Add(this.buttonRemoveProductFromDetail);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(234, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.tableLayoutPanel6.SetRowSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(243, 80);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // textBoxSearchProduct
            // 
            this.textBoxSearchProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchProduct.Location = new System.Drawing.Point(3, 3);
            this.textBoxSearchProduct.Name = "textBoxSearchProduct";
            this.textBoxSearchProduct.Size = new System.Drawing.Size(375, 24);
            this.textBoxSearchProduct.TabIndex = 0;
            this.textBoxSearchProduct.TextChanged += new System.EventHandler(this.textBoxSearchProduct_TextChanged);
            // 
            // buttonSearchProduct
            // 
            this.buttonSearchProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchProduct.Location = new System.Drawing.Point(384, 3);
            this.buttonSearchProduct.Name = "buttonSearchProduct";
            this.buttonSearchProduct.Size = new System.Drawing.Size(93, 28);
            this.buttonSearchProduct.TabIndex = 1;
            this.buttonSearchProduct.Text = "Tìm kiếm";
            this.buttonSearchProduct.UseVisualStyleBackColor = true;
            this.buttonSearchProduct.Click += new System.EventHandler(this.buttonSearchProduct_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel5.SetColumnSpan(this.dgvProduct, 2);
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(3, 37);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 62;
            this.dgvProduct.Size = new System.Drawing.Size(474, 334);
            this.dgvProduct.TabIndex = 2;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.375F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.625F));
            this.tableLayoutPanel5.Controls.Add(this.textBoxSearchProduct, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonSearchProduct, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.dgvProduct, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.192201F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.8078F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(480, 374);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // textBoxCreatedDate
            // 
            this.textBoxCreatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCreatedDate.Location = new System.Drawing.Point(135, 34);
            this.textBoxCreatedDate.Name = "textBoxCreatedDate";
            this.textBoxCreatedDate.Size = new System.Drawing.Size(347, 24);
            this.textBoxCreatedDate.TabIndex = 3;
            // 
            // labelCreatedDate
            // 
            this.labelCreatedDate.AutoSize = true;
            this.labelCreatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreatedDate.Location = new System.Drawing.Point(3, 31);
            this.labelCreatedDate.Name = "labelCreatedDate";
            this.labelCreatedDate.Size = new System.Drawing.Size(125, 18);
            this.labelCreatedDate.TabIndex = 2;
            this.labelCreatedDate.Text = "Ngày tạo phiếu:";
            // 
            // textBoxVoucherId
            // 
            this.textBoxVoucherId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVoucherId.Location = new System.Drawing.Point(135, 3);
            this.textBoxVoucherId.Name = "textBoxVoucherId";
            this.textBoxVoucherId.Size = new System.Drawing.Size(347, 24);
            this.textBoxVoucherId.TabIndex = 1;
            // 
            // labelVoucherId
            // 
            this.labelVoucherId.AutoSize = true;
            this.labelVoucherId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoucherId.Location = new System.Drawing.Point(3, 0);
            this.labelVoucherId.Name = "labelVoucherId";
            this.labelVoucherId.Size = new System.Drawing.Size(117, 18);
            this.labelVoucherId.TabIndex = 0;
            this.labelVoucherId.Text = "Mã phiếu xuất:";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.66667F));
            this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 383);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.31624F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.68376F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(480, 86);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.36625F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.63375F));
            this.tableLayoutPanel4.Controls.Add(this.textBoxCreatedDate, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelCreatedDate, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBoxVoucherId, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelVoucherId, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(486, 94);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // textBoxSearchVoucherIN
            // 
            this.textBoxSearchVoucherIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearchVoucherIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchVoucherIN.Location = new System.Drawing.Point(3, 3);
            this.textBoxSearchVoucherIN.Name = "textBoxSearchVoucherIN";
            this.textBoxSearchVoucherIN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSearchVoucherIN.Size = new System.Drawing.Size(381, 24);
            this.textBoxSearchVoucherIN.TabIndex = 0;
            this.textBoxSearchVoucherIN.WordWrap = false;
            // 
            // buttonSearchVoucherIN
            // 
            this.buttonSearchVoucherIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSearchVoucherIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchVoucherIN.Location = new System.Drawing.Point(390, 3);
            this.buttonSearchVoucherIN.Name = "buttonSearchVoucherIN";
            this.buttonSearchVoucherIN.Size = new System.Drawing.Size(93, 28);
            this.buttonSearchVoucherIN.TabIndex = 1;
            this.buttonSearchVoucherIN.Text = "Tìm kiếm";
            this.buttonSearchVoucherIN.UseVisualStyleBackColor = true;
            // 
            // dgvDetailProduct
            // 
            this.dgvDetailProduct.AllowUserToAddRows = false;
            this.dgvDetailProduct.AllowUserToDeleteRows = false;
            this.dgvDetailProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.dgvDetailProduct, 2);
            this.dgvDetailProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetailProduct.Location = new System.Drawing.Point(3, 37);
            this.dgvDetailProduct.Name = "dgvDetailProduct";
            this.dgvDetailProduct.ReadOnly = true;
            this.dgvDetailProduct.RowHeadersWidth = 62;
            this.dgvDetailProduct.Size = new System.Drawing.Size(480, 532);
            this.dgvDetailProduct.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.62963F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.37037F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxSearchVoucherIN, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSearchVoucherIN, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvDetailProduct, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(495, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.944056F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.05595F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(486, 572);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.53278F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.46721F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(486, 472);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.47405F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.52596F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 578);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // FormVoucherOUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 578);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormVoucherOUT";
            this.Text = "Phiếu xuất kho";
            this.Load += new System.EventHandler(this.FormVoucherOUT_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailProduct)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonAddProductToDetail;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonRemoveProductFromDetail;
        private System.Windows.Forms.TextBox textBoxSearchProduct;
        private System.Windows.Forms.Button buttonSearchProduct;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox textBoxCreatedDate;
        private System.Windows.Forms.Label labelCreatedDate;
        private System.Windows.Forms.TextBox textBoxVoucherId;
        private System.Windows.Forms.Label labelVoucherId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox textBoxSearchVoucherIN;
        private System.Windows.Forms.Button buttonSearchVoucherIN;
        private System.Windows.Forms.DataGridView dgvDetailProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}