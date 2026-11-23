namespace ReportHub_V2.Reports
{
    partial class rptShortNote_Tools
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrSubreport7 = new DevExpress.XtraReports.UI.XRSubreport();
            this.IR = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrSubreport5 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport4 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport3 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport2 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport6 = new DevExpress.XtraReports.UI.XRSubreport();
            this.Booking = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DefaultConnection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "Query";
            storedProcQuery1.StoredProcName = "BOOKING_NO_SHORT";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IlF1ZXJ5Ij48RmllbGQgTmFtZ" +
    "T0iQk9PS0lOR19OTyIgVHlwZT0iU3RyaW5nIiAvPjxGaWVsZCBOYW1lPSJHUk9VUElORyIgVHlwZT0iU" +
    "3RyaW5nIiAvPjwvVmlldz48L0RhdGFTZXQ+";
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 13.2917F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport7,
            this.xrSubreport5,
            this.xrSubreport4,
            this.xrSubreport3,
            this.xrSubreport2,
            this.xrSubreport1,
            this.xrSubreport6});
            this.ReportHeader.HeightF = 188.375F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrSubreport7
            // 
            this.xrSubreport7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 165.375F);
            this.xrSubreport7.Name = "xrSubreport7";
            this.xrSubreport7.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("IR", this.IR));
            this.xrSubreport7.ReportSource = new ReportHub_V2.Reports.rptShortNote_Sewing();
            this.xrSubreport7.SizeF = new System.Drawing.SizeF(918.7499F, 23F);
            // 
            // IR
            // 
            this.IR.Description = "Select IR/IB";
            this.IR.Name = "IR";
            dynamicListLookUpSettings1.DataMember = "Query";
            dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings1.DisplayMember = "GROUPING";
            dynamicListLookUpSettings1.FilterString = "[BOOKING_NO] = ?Booking";
            dynamicListLookUpSettings1.SortMember = null;
            dynamicListLookUpSettings1.ValueMember = "GROUPING";
            this.IR.ValueSourceSettings = dynamicListLookUpSettings1;
            // 
            // xrSubreport5
            // 
            this.xrSubreport5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 131.0416F);
            this.xrSubreport5.Name = "xrSubreport5";
            this.xrSubreport5.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("IR", this.IR));
            this.xrSubreport5.ReportSource = new ReportHub_V2.Reports.rptCuttingDetails();
            this.xrSubreport5.SizeF = new System.Drawing.SizeF(918.7499F, 23F);
            // 
            // xrSubreport4
            // 
            this.xrSubreport4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 96.04164F);
            this.xrSubreport4.Name = "xrSubreport4";
            this.xrSubreport4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("IR", this.IR));
            this.xrSubreport4.ReportSource = new ReportHub_V2.Reports.rptDyeingDetails();
            this.xrSubreport4.SizeF = new System.Drawing.SizeF(918.7499F, 23.00001F);
            // 
            // xrSubreport3
            // 
            this.xrSubreport3.LocationFloat = new DevExpress.Utils.PointFloat(1001.5F, 61.54162F);
            this.xrSubreport3.Name = "xrSubreport3";
            this.xrSubreport3.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("IR", this.IR));
            this.xrSubreport3.ReportSource = new ReportHub_V2.Reports.rptFabricTransfer();
            this.xrSubreport3.SizeF = new System.Drawing.SizeF(352.4999F, 23F);
            // 
            // xrSubreport2
            // 
            this.xrSubreport2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 61.54161F);
            this.xrSubreport2.Name = "xrSubreport2";
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("IR", this.IR));
            this.xrSubreport2.ReportSource = new ReportHub_V2.Reports.rptShortNote_Knit();
            this.xrSubreport2.SizeF = new System.Drawing.SizeF(918.7499F, 23F);
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.54161F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("IR", this.IR));
            this.xrSubreport1.ReportSource = new ReportHub_V2.Reports.rptShortNoteYarn();
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(677.0833F, 23F);
            // 
            // xrSubreport6
            // 
            this.xrSubreport6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreport6.Name = "xrSubreport6";
            this.xrSubreport6.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Booking", this.Booking));
            this.xrSubreport6.ReportSource = new ReportHub_V2.Reports.rptShortNoteAnalysis();
            this.xrSubreport6.SizeF = new System.Drawing.SizeF(1064F, 23F);
            // 
            // Booking
            // 
            this.Booking.Description = "Select Booking No.";
            this.Booking.Name = "Booking";
            dynamicListLookUpSettings2.DataMember = "Query";
            dynamicListLookUpSettings2.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings2.DisplayMember = "BOOKING_NO";
            dynamicListLookUpSettings2.FilterString = null;
            dynamicListLookUpSettings2.SortMember = "BOOKING_NO";
            dynamicListLookUpSettings2.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            dynamicListLookUpSettings2.ValueMember = "BOOKING_NO";
            this.Booking.ValueSourceSettings = dynamicListLookUpSettings2;
            // 
            // PageHeader
            // 
            this.PageHeader.HeightF = 0.8333333F;
            this.PageHeader.Name = "PageHeader";
            // 
            // PageFooter
            // 
            this.PageFooter.HeightF = 10.83333F;
            this.PageFooter.Name = "PageFooter";
            // 
            // ReportFooter
            // 
            this.ReportFooter.HeightF = 0F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // rptShortNote_Tools
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.PageHeader,
            this.PageFooter,
            this.ReportFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Landscape = true;
            this.Margins = new DevExpress.Drawing.DXMargins(20F, 16F, 13.2917F, 0F);
            this.PageHeight = 850;
            this.PageWidth = 1400;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Legal;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Booking, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IR, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.Booking,
            this.IR});
            this.Version = "23.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport6;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport1;
        private DevExpress.XtraReports.Parameters.Parameter Booking;
        private DevExpress.XtraReports.Parameters.Parameter IR;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport2;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport3;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport4;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport5;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport7;
    }
}
