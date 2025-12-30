namespace XDPMQLCuaHangMT.ThongKe
{
    partial class FormRpPhieuNhapKho
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.uspGetVoucherDetailsByVoucherIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cuaHangMayTinh3DataSet = new XDPMQLCuaHangMT.cuaHangMayTinh3DataSet();
            this.uspGetVoucherDetailsByVoucherIdBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usp_GetVoucherDetailsByVoucherIdTableAdapter = new XDPMQLCuaHangMT.cuaHangMayTinh3DataSetTableAdapters.usp_GetVoucherDetailsByVoucherIdTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uspGetVoucherDetailsByVoucherIdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangMayTinh3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspGetVoucherDetailsByVoucherIdBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // uspGetVoucherDetailsByVoucherIdBindingSource
            // 
            this.uspGetVoucherDetailsByVoucherIdBindingSource.DataMember = "usp_GetVoucherDetailsByVoucherId";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "GetPhieuNhapKho";
            reportDataSource1.Value = this.uspGetVoucherDetailsByVoucherIdBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "XDPMQLCuaHangMT.ThongKe.ReportPhieuNhapKho.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // cuaHangMayTinh3DataSet
            // 
            this.cuaHangMayTinh3DataSet.DataSetName = "cuaHangMayTinh3DataSet";
            this.cuaHangMayTinh3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspGetVoucherDetailsByVoucherIdBindingSource1
            // 
            this.uspGetVoucherDetailsByVoucherIdBindingSource1.DataMember = "usp_GetVoucherDetailsByVoucherId";
            this.uspGetVoucherDetailsByVoucherIdBindingSource1.DataSource = this.cuaHangMayTinh3DataSet;
            // 
            // usp_GetVoucherDetailsByVoucherIdTableAdapter
            // 
            this.usp_GetVoucherDetailsByVoucherIdTableAdapter.ClearBeforeFill = true;
            // 
            // FormRpPhieuNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRpPhieuNhapKho";
            this.Text = "FormRpPhieuXuatKho";
            this.Load += new System.EventHandler(this.FormRpPhieuXuatKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uspGetVoucherDetailsByVoucherIdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuaHangMayTinh3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspGetVoucherDetailsByVoucherIdBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uspGetVoucherDetailsByVoucherIdBindingSource;
        private System.Windows.Forms.BindingSource uspGetVoucherDetailsByVoucherIdBindingSource1;
        private cuaHangMayTinh3DataSet cuaHangMayTinh3DataSet;
        private cuaHangMayTinh3DataSetTableAdapters.usp_GetVoucherDetailsByVoucherIdTableAdapter usp_GetVoucherDetailsByVoucherIdTableAdapter;
    }
}