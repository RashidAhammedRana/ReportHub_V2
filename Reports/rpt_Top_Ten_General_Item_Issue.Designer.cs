namespace ReportHub_V2.Reports
{
    partial class rpt_Top_Ten_General_Item_Issue
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
            DevExpress.XtraReports.Parameters.StaticListLookUpSettings staticListLookUpSettings1 = new DevExpress.XtraReports.Parameters.StaticListLookUpSettings();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrSubreport4 = new DevExpress.XtraReports.UI.XRSubreport();
            this.company = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrSubreport3 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport2 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.finyear = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DefaultConnection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "COMPANY";
            storedProcQuery1.StoredProcName = "COMPANY";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IkNPTVBBTlkiPjxGaWVsZCBOY" +
    "W1lPSJJRCIgVHlwZT0iRGVjaW1hbCIgLz48RmllbGQgTmFtZT0iQ09NUEFOWV9OQU1FIiBUeXBlPSJTd" +
    "HJpbmciIC8+PC9WaWV3PjwvRGF0YVNldD4=";
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 25F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 25F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.HeightF = 10.41667F;
            this.Detail.Name = "Detail";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport4,
            this.xrSubreport3,
            this.xrSubreport2,
            this.xrSubreport1});
            this.ReportHeader.HeightF = 121.5958F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrSubreport4
            // 
            this.xrSubreport4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 88.59577F);
            this.xrSubreport4.Name = "xrSubreport4";
            this.xrSubreport4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("company", this.company));
            this.xrSubreport4.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("finyear", this.finyear));
            this.xrSubreport4.ReportSource = new ReportHub_V2.Reports.Top_Ten_Dept_Catagory_wise();
            this.xrSubreport4.SizeF = new System.Drawing.SizeF(1350F, 23F);
            // 
            // company
            // 
            this.company.Description = "Select Company";
            this.company.MultiValue = true;
            this.company.Name = "company";
            dynamicListLookUpSettings1.DataMember = "COMPANY";
            dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings1.DisplayMember = "COMPANY_NAME";
            dynamicListLookUpSettings1.FilterString = null;
            dynamicListLookUpSettings1.SortMember = "COMPANY_NAME";
            dynamicListLookUpSettings1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            dynamicListLookUpSettings1.ValueMember = "COMPANY_NAME";
            this.company.ValueSourceSettings = dynamicListLookUpSettings1;
            // 
            // xrSubreport3
            // 
            this.xrSubreport3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 60.29167F);
            this.xrSubreport3.Name = "xrSubreport3";
            this.xrSubreport3.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("company", this.company));
            this.xrSubreport3.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("finyear", this.finyear));
            this.xrSubreport3.ReportSource = new ReportHub_V2.Reports.rpt_Top_Ten_Dept_Month_Wise();
            this.xrSubreport3.SizeF = new System.Drawing.SizeF(1350F, 23F);
            // 
            // xrSubreport2
            // 
            this.xrSubreport2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 30F);
            this.xrSubreport2.Name = "xrSubreport2";
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("company", this.company));
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("finyear", this.finyear));
            this.xrSubreport2.ReportSource = new ReportHub_V2.Reports.rpt_Top_10_Item_dept();
            this.xrSubreport2.SizeF = new System.Drawing.SizeF(1350F, 23F);
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("company", this.company));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("finyear", this.finyear));
            this.xrSubreport1.ReportSource = new ReportHub_V2.Reports.rpt_Top_Ten_Dept_Month_Wise();
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(1350F, 23F);
            // 
            // finyear
            // 
            this.finyear.Description = "Select Financial Year";
            this.finyear.MultiValue = true;
            this.finyear.Name = "finyear";
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue("2024-2025", null));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue("2025-2026", null));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue("2026-2027", null));
            this.finyear.ValueSourceSettings = staticListLookUpSettings1;
            // 
            // rpt_Top_Ten_General_Item_Issue
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "COMPANY";
            this.DataSource = this.sqlDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Landscape = true;
            this.Margins = new DevExpress.Drawing.DXMargins(25F, 25F, 25F, 25F);
            this.PageHeight = 850;
            this.PageWidth = 1400;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Legal;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.company, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.company,
            this.finyear});
            this.Version = "23.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.Parameters.Parameter company;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport1;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport2;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport3;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport4;
        private DevExpress.XtraReports.Parameters.Parameter finyear;
    }
}
