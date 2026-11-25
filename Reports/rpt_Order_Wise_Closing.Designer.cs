namespace ReportHub_V2.Reports
{
    partial class rpt_Order_Wise_Closing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_Order_Wise_Closing));
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrSubreport11 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport10 = new DevExpress.XtraReports.UI.XRSubreport();
            this.IRIB = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrPageBreak1 = new DevExpress.XtraReports.UI.XRPageBreak();
            this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrSubreport7 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport9 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport8 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport6 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport5 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport4 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport3 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport2 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DefaultConnection";
            this.sqlDataSource1.ConnectionOptions.CommandTimeout = 500;
            this.sqlDataSource1.ConnectionOptions.DbCommandTimeout = 500;
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "BOOKING_NO";
            storedProcQuery1.StoredProcName = "BOOKING_NO";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IkJPT0tJTkdfTk8iPjxGaWVsZ" +
    "CBOYW1lPSJHUk9VUElORyIgVHlwZT0iU3RyaW5nIiAvPjwvVmlldz48L0RhdGFTZXQ+";
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 16.66667F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 14.11133F;
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
            this.xrSubreport11,
            this.xrSubreport10,
            this.xrPageBreak1,
            this.xrRichText1,
            this.xrSubreport7,
            this.xrSubreport9,
            this.xrSubreport8,
            this.xrSubreport6,
            this.xrSubreport5,
            this.xrSubreport4,
            this.xrSubreport3,
            this.xrSubreport2,
            this.xrSubreport1,
            this.label1});
            this.ReportHeader.HeightF = 363.5417F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrSubreport11
            // 
            this.xrSubreport11.LocationFloat = new DevExpress.Utils.PointFloat(0F, 93.06934F);
            this.xrSubreport11.Name = "xrSubreport11";
            this.xrSubreport11.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("IRIB", this.IRIB));
            this.xrSubreport11.ReportSource = new ReportHub_V2.Reports.rpt_Closing_Req_Fabric();
            this.xrSubreport11.SizeF = new System.Drawing.SizeF(1371F, 23F);
            // 
            // xrSubreport10
            // 
            this.xrSubreport10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 319.5F);
            this.xrSubreport10.Name = "xrSubreport10";
            this.xrSubreport10.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("IRIB", this.IRIB));
            this.xrSubreport10.ReportSource = new ReportHub_V2.Reports.rptClosing_WIP();
            this.xrSubreport10.SizeF = new System.Drawing.SizeF(1361F, 24.04169F);
            // 
            // IRIB
            // 
            this.IRIB.Description = "Select IR/IB";
            this.IRIB.Name = "IRIB";
            dynamicListLookUpSettings1.DataMember = "BOOKING_NO";
            dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings1.DisplayMember = "GROUPING";
            dynamicListLookUpSettings1.FilterString = null;
            dynamicListLookUpSettings1.SortMember = null;
            dynamicListLookUpSettings1.ValueMember = "GROUPING";
            this.IRIB.ValueSourceSettings = dynamicListLookUpSettings1;
            // 
            // xrPageBreak1
            // 
            this.xrPageBreak1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 192.9444F);
            this.xrPageBreak1.Name = "xrPageBreak1";
            // 
            // xrRichText1
            // 
            this.xrRichText1.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(0.0002861023F, 33.56934F);
            this.xrRichText1.Name = "xrRichText1";
            this.xrRichText1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
            this.xrRichText1.SizeF = new System.Drawing.SizeF(1371F, 35.50002F);
            // 
            // xrSubreport7
            // 
            this.xrSubreport7.LocationFloat = new DevExpress.Utils.PointFloat(0.0002861023F, 289.2777F);
            this.xrSubreport7.Name = "xrSubreport7";
            this.xrSubreport7.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("IRIB", this.IRIB));
            this.xrSubreport7.ReportSource = new ReportHub_V2.Reports.rpt_Closing_Sewing();
            this.xrSubreport7.SizeF = new System.Drawing.SizeF(1371F, 23F);
            // 
            // xrSubreport9
            // 
            this.xrSubreport9.LocationFloat = new DevExpress.Utils.PointFloat(0.0001589457F, 194.9444F);
            this.xrSubreport9.Name = "xrSubreport9";
            this.xrSubreport9.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("IR", this.IRIB));
            this.xrSubreport9.ReportSource = new ReportHub_V2.Reports.rptCuttingDetails();
            this.xrSubreport9.SizeF = new System.Drawing.SizeF(1371F, 23F);
            // 
            // xrSubreport8
            // 
            this.xrSubreport8.LocationFloat = new DevExpress.Utils.PointFloat(0.0002861023F, 226.736F);
            this.xrSubreport8.Name = "xrSubreport8";
            this.xrSubreport8.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("IRIB", this.IRIB));
            this.xrSubreport8.ReportSource = new ReportHub_V2.Reports.rpt_Closing_EMB();
            this.xrSubreport8.SizeF = new System.Drawing.SizeF(1371F, 23F);
            // 
            // xrSubreport6
            // 
            this.xrSubreport6.LocationFloat = new DevExpress.Utils.PointFloat(995.8331F, 145.9444F);
            this.xrSubreport6.Name = "xrSubreport6";
            this.xrSubreport6.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("IR", this.IRIB));
            this.xrSubreport6.ReportSource = new ReportHub_V2.Reports.rptFabricTransfer_C();
            this.xrSubreport6.SizeF = new System.Drawing.SizeF(375.167F, 23F);
            // 
            // xrSubreport5
            // 
            this.xrSubreport5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 169.9444F);
            this.xrSubreport5.Name = "xrSubreport5";
            this.xrSubreport5.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("IR", this.IRIB));
            this.xrSubreport5.ReportSource = new ReportHub_V2.Reports.rptDyeingDetails_C();
            this.xrSubreport5.SizeF = new System.Drawing.SizeF(1371F, 23F);
            // 
            // xrSubreport4
            // 
            this.xrSubreport4.LocationFloat = new DevExpress.Utils.PointFloat(0.0001589457F, 145.9444F);
            this.xrSubreport4.Name = "xrSubreport4";
            this.xrSubreport4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("IR", this.IRIB));
            this.xrSubreport4.ReportSource = new ReportHub_V2.Reports.rptShortNote_Knit_C();
            this.xrSubreport4.SizeF = new System.Drawing.SizeF(969.9582F, 23F);
            // 
            // xrSubreport3
            // 
            this.xrSubreport3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 118.9444F);
            this.xrSubreport3.Name = "xrSubreport3";
            this.xrSubreport3.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("IR", this.IRIB));
            this.xrSubreport3.ReportSource = new ReportHub_V2.Reports.rptShortNoteYarn_C();
            this.xrSubreport3.SizeF = new System.Drawing.SizeF(1371F, 23F);
            // 
            // xrSubreport2
            // 
            this.xrSubreport2.LocationFloat = new DevExpress.Utils.PointFloat(0.0002861023F, 257.7777F);
            this.xrSubreport2.Name = "xrSubreport2";
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("IRIB", this.IRIB));
            this.xrSubreport2.ReportSource = new ReportHub_V2.Reports.rpt_Closing_Trims_Details();
            this.xrSubreport2.SizeF = new System.Drawing.SizeF(1371F, 22.99998F);
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 69.06935F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("IRIB", this.IRIB));
            this.xrSubreport1.ReportSource = new ReportHub_V2.Reports.rpt_Closing_Order_Details();
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(1371F, 23F);
            // 
            // label1
            // 
            this.label1.Font = new DevExpress.Drawing.DXFont("Calibri", 18F, ((DevExpress.Drawing.DXFontStyle)((DevExpress.Drawing.DXFontStyle.Bold | DevExpress.Drawing.DXFontStyle.Underline))));
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(1371F, 33.56933F);
            this.label1.StylePriority.UseFont = false;
            this.label1.StylePriority.UseTextAlignment = false;
            this.label1.Text = "Order Wise Closing Report";
            this.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // ReportFooter
            // 
            this.ReportFooter.HeightF = 0F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.HeightF = 0F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.HeightF = 0F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // PageHeader
            // 
            this.PageHeader.HeightF = 0F;
            this.PageHeader.Name = "PageHeader";
            // 
            // PageFooter
            // 
            this.PageFooter.HeightF = 0F;
            this.PageFooter.Name = "PageFooter";
            // 
            // rpt_Order_Wise_Closing
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.ReportFooter,
            this.GroupHeader1,
            this.GroupFooter1,
            this.PageHeader,
            this.PageFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "BOOKING_NO";
            this.DataSource = this.sqlDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Landscape = true;
            this.Margins = new DevExpress.Drawing.DXMargins(14F, 15F, 16.66667F, 14.11133F);
            this.PageHeight = 850;
            this.PageWidth = 1400;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Legal;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IRIB, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IRIB});
            this.Version = "23.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport1;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport2;
        private DevExpress.XtraReports.Parameters.Parameter IRIB;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport3;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport4;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport5;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport6;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport8;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport9;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport7;
        private DevExpress.XtraReports.UI.XRRichText xrRichText1;
        private DevExpress.XtraReports.UI.XRPageBreak xrPageBreak1;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport10;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport11;
    }
}
