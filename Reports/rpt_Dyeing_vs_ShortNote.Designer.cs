namespace ReportHub_V2.Reports
{
    partial class rpt_Dyeing_vs_ShortNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_Dyeing_vs_ShortNote));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.table3 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupFooterBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.TotalCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.TotalData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.TotalBackground1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GrandTotalCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GrandTotalData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GrandTotalBackground1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.IR = new DevExpress.XtraReports.Parameters.Parameter();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DefaultConnection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "rptDYE_VS_SHORT_NOTE";
            storedProcQuery1.StoredProcName = "rptDYE_VS_SHORT_NOTE";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 50F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.pageInfo2});
            this.BottomMargin.HeightF = 50F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // pageInfo1
            // 
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo1.SizeF = new System.Drawing.SizeF(500F, 23F);
            this.pageInfo1.StyleName = "PageInfo";
            // 
            // pageInfo2
            // 
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(500F, 0F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.SizeF = new System.Drawing.SizeF(500F, 23F);
            this.pageInfo2.StyleName = "PageInfo";
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.pageInfo2.TextFormatString = "Page {0} of {1}";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label1});
            this.ReportHeader.HeightF = 43.33334F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // label1
            // 
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(1000F, 24.19433F);
            this.label1.StyleName = "Title";
            this.label1.Text = "Dyeing VS Short Note";
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
            this.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader2.HeightF = 28F;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            this.GroupHeader2.RepeatEveryPage = true;
            // 
            // table2
            // 
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table2.Name = "table2";
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
            this.table2.SizeF = new System.Drawing.SizeF(1051F, 28F);
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.tableCell3,
            this.tableCell4,
            this.tableCell5,
            this.tableCell6,
            this.tableCell7,
            this.tableCell8,
            this.tableCell9,
            this.tableCell10,
            this.tableCell11,
            this.tableCell12,
            this.tableCell13});
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Weight = 1D;
            // 
            // tableCell3
            // 
            this.tableCell3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.tableCell3.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell3.Name = "tableCell3";
            this.tableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell3.StyleName = "DetailCaption1";
            this.tableCell3.StylePriority.UseBorders = false;
            this.tableCell3.StylePriority.UseFont = false;
            this.tableCell3.StylePriority.UsePadding = false;
            this.tableCell3.Text = "COLOR NAME";
            this.tableCell3.Weight = 0.20228691036931476D;
            // 
            // tableCell4
            // 
            this.tableCell4.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell4.Name = "tableCell4";
            this.tableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell4.StyleName = "DetailCaption1";
            this.tableCell4.StylePriority.UseFont = false;
            this.tableCell4.StylePriority.UsePadding = false;
            this.tableCell4.StylePriority.UseTextAlignment = false;
            this.tableCell4.Text = "OUTSIDE BATCH QTY";
            this.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell4.Weight = 0.083724723148346752D;
            // 
            // tableCell5
            // 
            this.tableCell5.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell5.Name = "tableCell5";
            this.tableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell5.StyleName = "DetailCaption1";
            this.tableCell5.StylePriority.UseFont = false;
            this.tableCell5.StylePriority.UsePadding = false;
            this.tableCell5.StylePriority.UseTextAlignment = false;
            this.tableCell5.Text = "OUTSIDE FINISH QTY";
            this.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell5.Weight = 0.081914641666411547D;
            // 
            // tableCell6
            // 
            this.tableCell6.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell6.Name = "tableCell6";
            this.tableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell6.StyleName = "DetailCaption1";
            this.tableCell6.StylePriority.UseFont = false;
            this.tableCell6.StylePriority.UsePadding = false;
            this.tableCell6.StylePriority.UseTextAlignment = false;
            this.tableCell6.Text = "OUTSIDE REJECT QTY";
            this.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell6.Weight = 0.077907072801943172D;
            // 
            // tableCell7
            // 
            this.tableCell7.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell7.Name = "tableCell7";
            this.tableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell7.StyleName = "DetailCaption1";
            this.tableCell7.StylePriority.UseFont = false;
            this.tableCell7.StylePriority.UsePadding = false;
            this.tableCell7.StylePriority.UseTextAlignment = false;
            this.tableCell7.Text = "INSIDE BATCH QTY";
            this.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell7.Weight = 0.072710959616814383D;
            // 
            // tableCell8
            // 
            this.tableCell8.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell8.Name = "tableCell8";
            this.tableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell8.StyleName = "DetailCaption1";
            this.tableCell8.StylePriority.UseFont = false;
            this.tableCell8.StylePriority.UsePadding = false;
            this.tableCell8.StylePriority.UseTextAlignment = false;
            this.tableCell8.Text = "INSIDE FINISH QTY";
            this.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell8.Weight = 0.070704108410014649D;
            // 
            // tableCell9
            // 
            this.tableCell9.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell9.Name = "tableCell9";
            this.tableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell9.StyleName = "DetailCaption1";
            this.tableCell9.StylePriority.UseFont = false;
            this.tableCell9.StylePriority.UsePadding = false;
            this.tableCell9.StylePriority.UseTextAlignment = false;
            this.tableCell9.Text = "INSIDE REJECT QTY";
            this.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell9.Weight = 0.079336119993522289D;
            // 
            // tableCell10
            // 
            this.tableCell10.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell10.Name = "tableCell10";
            this.tableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell10.StyleName = "DetailCaption1";
            this.tableCell10.StylePriority.UseFont = false;
            this.tableCell10.StylePriority.UsePadding = false;
            this.tableCell10.StylePriority.UseTextAlignment = false;
            this.tableCell10.Text = "INHOUSE DYEING";
            this.tableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell10.Weight = 0.072478087933860957D;
            // 
            // tableCell11
            // 
            this.tableCell11.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell11.Name = "tableCell11";
            this.tableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell11.StyleName = "DetailCaption1";
            this.tableCell11.StylePriority.UseFont = false;
            this.tableCell11.StylePriority.UsePadding = false;
            this.tableCell11.StylePriority.UseTextAlignment = false;
            this.tableCell11.Text = "SHORT ALLOW GREY QTY";
            this.tableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell11.Weight = 0.078815854986513029D;
            // 
            // tableCell12
            // 
            this.tableCell12.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell12.Name = "tableCell12";
            this.tableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell12.StyleName = "DetailCaption1";
            this.tableCell12.StylePriority.UseFont = false;
            this.tableCell12.StylePriority.UsePadding = false;
            this.tableCell12.StylePriority.UseTextAlignment = false;
            this.tableCell12.Text = "REQ GREY FAB QNTY";
            this.tableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell12.Weight = 0.06901270143985748D;
            // 
            // tableCell13
            // 
            this.tableCell13.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell13.Name = "tableCell13";
            this.tableCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell13.StyleName = "DetailCaption1";
            this.tableCell13.StylePriority.UseFont = false;
            this.tableCell13.StylePriority.UsePadding = false;
            this.tableCell13.StylePriority.UseTextAlignment = false;
            this.tableCell13.Text = "REQ FIN FAB QNTY";
            this.tableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell13.Weight = 0.067358847514783965D;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table3});
            this.Detail.HeightF = 20F;
            this.Detail.Name = "Detail";
            // 
            // table3
            // 
            this.table3.LocationFloat = new DevExpress.Utils.PointFloat(7.629395E-06F, 0F);
            this.table3.Name = "table3";
            this.table3.OddStyleName = "DetailData3_Odd";
            this.table3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow3});
            this.table3.SizeF = new System.Drawing.SizeF(1051F, 20F);
            // 
            // tableRow3
            // 
            this.tableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2,
            this.tableCell14,
            this.tableCell15,
            this.tableCell16,
            this.tableCell17,
            this.tableCell18,
            this.tableCell19,
            this.tableCell20,
            this.tableCell21,
            this.tableCell22,
            this.tableCell23,
            this.tableCell24});
            this.tableRow3.Name = "tableRow3";
            this.tableRow3.Weight = 11.5D;
            // 
            // tableCell14
            // 
            this.tableCell14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.tableCell14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[COLOR_NAME]")});
            this.tableCell14.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell14.Name = "tableCell14";
            this.tableCell14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell14.StyleName = "DetailData1";
            this.tableCell14.StylePriority.UseBorders = false;
            this.tableCell14.StylePriority.UseFont = false;
            this.tableCell14.StylePriority.UsePadding = false;
            this.tableCell14.Weight = 0.20228690303975222D;
            // 
            // tableCell15
            // 
            this.tableCell15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OUTSIDE_BATCH_QTY]")});
            this.tableCell15.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell15.Name = "tableCell15";
            this.tableCell15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell15.StyleName = "DetailData1";
            this.tableCell15.StylePriority.UseFont = false;
            this.tableCell15.StylePriority.UsePadding = false;
            this.tableCell15.StylePriority.UseTextAlignment = false;
            this.tableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell15.TextFormatString = "{0:#.00}";
            this.tableCell15.Weight = 0.083724715900421492D;
            // 
            // tableCell16
            // 
            this.tableCell16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OUTSIDE_FINISH_QTY]")});
            this.tableCell16.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell16.Name = "tableCell16";
            this.tableCell16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell16.StyleName = "DetailData1";
            this.tableCell16.StylePriority.UseFont = false;
            this.tableCell16.StylePriority.UsePadding = false;
            this.tableCell16.StylePriority.UseTextAlignment = false;
            this.tableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell16.TextFormatString = "{0:#.00}";
            this.tableCell16.Weight = 0.0819146496772766D;
            // 
            // tableCell17
            // 
            this.tableCell17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OUTSIDE_REJECT_QTY]")});
            this.tableCell17.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell17.Name = "tableCell17";
            this.tableCell17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell17.StyleName = "DetailData1";
            this.tableCell17.StylePriority.UseFont = false;
            this.tableCell17.StylePriority.UsePadding = false;
            this.tableCell17.StylePriority.UseTextAlignment = false;
            this.tableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell17.TextFormatString = "{0:#.00}";
            this.tableCell17.Weight = 0.077907081101433018D;
            // 
            // tableCell18
            // 
            this.tableCell18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[INSIDE_BATCH_QTY]")});
            this.tableCell18.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell18.Name = "tableCell18";
            this.tableCell18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell18.StyleName = "DetailData1";
            this.tableCell18.StylePriority.UseFont = false;
            this.tableCell18.StylePriority.UsePadding = false;
            this.tableCell18.StylePriority.UseTextAlignment = false;
            this.tableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell18.TextFormatString = "{0:#.00}";
            this.tableCell18.Weight = 0.072710967686991645D;
            // 
            // tableCell19
            // 
            this.tableCell19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[INSIDE_FINISH_QTY]")});
            this.tableCell19.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell19.Name = "tableCell19";
            this.tableCell19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell19.StyleName = "DetailData1";
            this.tableCell19.StylePriority.UseFont = false;
            this.tableCell19.StylePriority.UsePadding = false;
            this.tableCell19.StylePriority.UseTextAlignment = false;
            this.tableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell19.TextFormatString = "{0:#.00}";
            this.tableCell19.Weight = 0.070703979157093325D;
            // 
            // tableCell20
            // 
            this.tableCell20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[INSIDE_REJECT_QTY]")});
            this.tableCell20.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell20.Name = "tableCell20";
            this.tableCell20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell20.StyleName = "DetailData1";
            this.tableCell20.StylePriority.UseFont = false;
            this.tableCell20.StylePriority.UsePadding = false;
            this.tableCell20.StylePriority.UseTextAlignment = false;
            this.tableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell20.TextFormatString = "{0:#.00}";
            this.tableCell20.Weight = 0.079336066937443231D;
            // 
            // tableCell21
            // 
            this.tableCell21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[INHOUSE_DYEING]")});
            this.tableCell21.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell21.Name = "tableCell21";
            this.tableCell21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell21.StyleName = "DetailData1";
            this.tableCell21.StylePriority.UseFont = false;
            this.tableCell21.StylePriority.UsePadding = false;
            this.tableCell21.StylePriority.UseTextAlignment = false;
            this.tableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell21.TextFormatString = "{0:#.00}";
            this.tableCell21.Weight = 0.072478263664250975D;
            // 
            // tableCell22
            // 
            this.tableCell22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SHORT_ALLOW_GREY_QTY]")});
            this.tableCell22.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell22.Name = "tableCell22";
            this.tableCell22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell22.StyleName = "DetailData1";
            this.tableCell22.StylePriority.UseFont = false;
            this.tableCell22.StylePriority.UsePadding = false;
            this.tableCell22.StylePriority.UseTextAlignment = false;
            this.tableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell22.TextFormatString = "{0:#.00}";
            this.tableCell22.Weight = 0.078815741658210189D;
            // 
            // tableCell23
            // 
            this.tableCell23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[REQ_GREY_FAB_QNTY]")});
            this.tableCell23.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell23.Name = "tableCell23";
            this.tableCell23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell23.StyleName = "DetailData1";
            this.tableCell23.StylePriority.UseFont = false;
            this.tableCell23.StylePriority.UsePadding = false;
            this.tableCell23.StylePriority.UseTextAlignment = false;
            this.tableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell23.TextFormatString = "{0:#.00}";
            this.tableCell23.Weight = 0.069012694668769831D;
            // 
            // tableCell24
            // 
            this.tableCell24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[REQ_FIN_FAB_QNTY]")});
            this.tableCell24.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell24.Name = "tableCell24";
            this.tableCell24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell24.StyleName = "DetailData1";
            this.tableCell24.StylePriority.UseFont = false;
            this.tableCell24.StylePriority.UsePadding = false;
            this.tableCell24.StylePriority.UseTextAlignment = false;
            this.tableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell24.TextFormatString = "{0:#.00}";
            this.tableCell24.Weight = 0.067358886265752829D;
            // 
            // ReportFooter
            // 
            this.ReportFooter.HeightF = 4.926109F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new DevExpress.Drawing.DXFont("Arial", 14.25F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Title.Name = "Title";
            this.Title.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // GroupCaption1
            // 
            this.GroupCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.GroupCaption1.BorderColor = System.Drawing.Color.White;
            this.GroupCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupCaption1.BorderWidth = 2F;
            this.GroupCaption1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GroupCaption1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.GroupCaption1.Name = "GroupCaption1";
            this.GroupCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.GroupCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GroupData1
            // 
            this.GroupData1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.GroupData1.BorderColor = System.Drawing.Color.White;
            this.GroupData1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupData1.BorderWidth = 2F;
            this.GroupData1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GroupData1.ForeColor = System.Drawing.Color.White;
            this.GroupData1.Name = "GroupData1";
            this.GroupData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.GroupData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailCaption1
            // 
            this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DetailCaption1.BorderColor = System.Drawing.Color.White;
            this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailCaption1.BorderWidth = 2F;
            this.DetailCaption1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.DetailCaption1.ForeColor = System.Drawing.Color.White;
            this.DetailCaption1.Name = "DetailCaption1";
            this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData1
            // 
            this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailData1.BorderWidth = 2F;
            this.DetailData1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.DetailData1.ForeColor = System.Drawing.Color.Black;
            this.DetailData1.Name = "DetailData1";
            this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GroupFooterBackground3
            // 
            this.GroupFooterBackground3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.GroupFooterBackground3.BorderColor = System.Drawing.Color.White;
            this.GroupFooterBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupFooterBackground3.BorderWidth = 2F;
            this.GroupFooterBackground3.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GroupFooterBackground3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.GroupFooterBackground3.Name = "GroupFooterBackground3";
            this.GroupFooterBackground3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.GroupFooterBackground3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3_Odd
            // 
            this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailData3_Odd.BorderWidth = 1F;
            this.DetailData3_Odd.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
            this.DetailData3_Odd.Name = "DetailData3_Odd";
            this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // TotalCaption1
            // 
            this.TotalCaption1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.TotalCaption1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.TotalCaption1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.TotalCaption1.Name = "TotalCaption1";
            this.TotalCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.TotalCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // TotalData1
            // 
            this.TotalData1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.TotalData1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.TotalData1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.TotalData1.Name = "TotalData1";
            this.TotalData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 6, 0, 0, 100F);
            this.TotalData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // TotalBackground1
            // 
            this.TotalBackground1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.TotalBackground1.BorderColor = System.Drawing.Color.White;
            this.TotalBackground1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.TotalBackground1.BorderWidth = 2F;
            this.TotalBackground1.Name = "TotalBackground1";
            // 
            // GrandTotalCaption1
            // 
            this.GrandTotalCaption1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.GrandTotalCaption1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GrandTotalCaption1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.GrandTotalCaption1.Name = "GrandTotalCaption1";
            this.GrandTotalCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.GrandTotalCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GrandTotalData1
            // 
            this.GrandTotalData1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.GrandTotalData1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GrandTotalData1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.GrandTotalData1.Name = "GrandTotalData1";
            this.GrandTotalData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 6, 0, 0, 100F);
            this.GrandTotalData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GrandTotalBackground1
            // 
            this.GrandTotalBackground1.BackColor = System.Drawing.Color.White;
            this.GrandTotalBackground1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.GrandTotalBackground1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GrandTotalBackground1.BorderWidth = 2F;
            this.GrandTotalBackground1.Name = "GrandTotalBackground1";
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // IR
            // 
            this.IR.Description = "Select Internal Reference";
            this.IR.MultiValue = true;
            this.IR.Name = "IR";
            this.IR.SelectAllValues = true;
            dynamicListLookUpSettings1.DataMember = "rptDYE_VS_SHORT_NOTE";
            dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings1.DisplayMember = "IR";
            dynamicListLookUpSettings1.FilterString = null;
            dynamicListLookUpSettings1.SortMember = "IR";
            dynamicListLookUpSettings1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            dynamicListLookUpSettings1.ValueMember = "IR";
            this.IR.ValueSourceSettings = dynamicListLookUpSettings1;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter1.HeightF = 0F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell1.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell1.StyleName = "DetailCaption1";
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "IR";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell1.Weight = 0.094750024515022249D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[IR]")});
            this.xrTableCell2.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell2.StyleName = "DetailData1";
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "xrTableCell2";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell2.Weight = 0.094750021917202124D;
            // 
            // rpt_Dyeing_vs_ShortNote
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader2,
            this.Detail,
            this.GroupFooter1,
            this.ReportFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "rptDYE_VS_SHORT_NOTE";
            this.DataSource = this.sqlDataSource1;
            this.FilterString = "[IR] In (?IR)";
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Landscape = true;
            this.Margins = new DevExpress.Drawing.DXMargins(25F, 24F, 50F, 50F);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IR});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.GroupCaption1,
            this.GroupData1,
            this.DetailCaption1,
            this.DetailData1,
            this.GroupFooterBackground3,
            this.DetailData3_Odd,
            this.TotalCaption1,
            this.TotalData1,
            this.TotalBackground1,
            this.GrandTotalCaption1,
            this.GrandTotalData1,
            this.GrandTotalBackground1,
            this.PageInfo});
            this.Version = "23.2";
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell4;
        private DevExpress.XtraReports.UI.XRTableCell tableCell5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell6;
        private DevExpress.XtraReports.UI.XRTableCell tableCell7;
        private DevExpress.XtraReports.UI.XRTableCell tableCell8;
        private DevExpress.XtraReports.UI.XRTableCell tableCell9;
        private DevExpress.XtraReports.UI.XRTableCell tableCell10;
        private DevExpress.XtraReports.UI.XRTableCell tableCell11;
        private DevExpress.XtraReports.UI.XRTableCell tableCell12;
        private DevExpress.XtraReports.UI.XRTableCell tableCell13;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable table3;
        private DevExpress.XtraReports.UI.XRTableRow tableRow3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell14;
        private DevExpress.XtraReports.UI.XRTableCell tableCell15;
        private DevExpress.XtraReports.UI.XRTableCell tableCell16;
        private DevExpress.XtraReports.UI.XRTableCell tableCell17;
        private DevExpress.XtraReports.UI.XRTableCell tableCell18;
        private DevExpress.XtraReports.UI.XRTableCell tableCell19;
        private DevExpress.XtraReports.UI.XRTableCell tableCell20;
        private DevExpress.XtraReports.UI.XRTableCell tableCell21;
        private DevExpress.XtraReports.UI.XRTableCell tableCell22;
        private DevExpress.XtraReports.UI.XRTableCell tableCell23;
        private DevExpress.XtraReports.UI.XRTableCell tableCell24;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle GroupCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle GroupData1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
        private DevExpress.XtraReports.UI.XRControlStyle GroupFooterBackground3;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle TotalCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle TotalData1;
        private DevExpress.XtraReports.UI.XRControlStyle TotalBackground1;
        private DevExpress.XtraReports.UI.XRControlStyle GrandTotalCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle GrandTotalData1;
        private DevExpress.XtraReports.UI.XRControlStyle GrandTotalBackground1;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.Parameters.Parameter IR;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
    }
}
