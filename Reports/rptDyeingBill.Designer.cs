namespace ReportHub_V2.Reports
{
    partial class rptDyeingBill
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptDyeingBill));
            DevExpress.XtraReports.Parameters.StaticListLookUpSettings staticListLookUpSettings1 = new DevExpress.XtraReports.Parameters.StaticListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.table3 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupFooterBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DD_Start = new DevExpress.XtraReports.Parameters.RangeStartParameter();
            this.DD_End = new DevExpress.XtraReports.Parameters.RangeEndParameter();
            this.DD = new DevExpress.XtraReports.Parameters.Parameter();
            this.W_COMPANY = new DevExpress.XtraReports.Parameters.Parameter();
            this.IR = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DefaultConnection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "DYEING_BILL";
            storedProcQuery1.StoredProcName = "DYEING_BILL";
            storedProcQuery2.Name = "Query_1";
            storedProcQuery2.StoredProcName = "BOOKING_NO";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 18.75F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.pageInfo2});
            this.BottomMargin.HeightF = 30.04166F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // pageInfo1
            // 
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo1.SizeF = new System.Drawing.SizeF(534.5F, 23F);
            this.pageInfo1.StyleName = "PageInfo";
            // 
            // pageInfo2
            // 
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(534.5F, 0F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.SizeF = new System.Drawing.SizeF(534.5F, 23F);
            this.pageInfo2.StyleName = "PageInfo";
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.pageInfo2.TextFormatString = "Page {0} of {1}";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label1});
            this.ReportHeader.HeightF = 27.70834F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // label1
            // 
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(1069F, 24.19433F);
            this.label1.StyleName = "Title";
            this.label1.Text = "Dyeing Finishing Bill Report";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("TRANS_TYPE", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader1.HeightF = 27F;
            this.GroupHeader1.Level = 1;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // table1
            // 
            this.table1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table1.Name = "table1";
            this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
            this.table1.SizeF = new System.Drawing.SizeF(1069F, 25F);
            // 
            // tableRow1
            // 
            this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell1,
            this.tableCell2});
            this.tableRow1.Name = "tableRow1";
            this.tableRow1.Weight = 1D;
            // 
            // tableCell1
            // 
            this.tableCell1.Name = "tableCell1";
            this.tableCell1.StyleName = "GroupCaption1";
            this.tableCell1.Text = "Transaction Type";
            this.tableCell1.Weight = 0.097415620752090148D;
            // 
            // tableCell2
            // 
            this.tableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TRANS_TYPE]")});
            this.tableCell2.Name = "tableCell2";
            this.tableCell2.StyleName = "GroupData1";
            this.tableCell2.Weight = 0.90258435070012866D;
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
            this.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader2.HeightF = 28F;
            this.GroupHeader2.Level = 2;
            this.GroupHeader2.Name = "GroupHeader2";
            this.GroupHeader2.RepeatEveryPage = true;
            // 
            // table2
            // 
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table2.Name = "table2";
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
            this.table2.SizeF = new System.Drawing.SizeF(1069F, 28F);
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell3,
            this.tableCell5,
            this.tableCell6,
            this.tableCell8,
            this.tableCell11,
            this.tableCell12,
            this.xrTableCell1,
            this.tableCell13,
            this.tableCell14,
            this.tableCell17,
            this.xrTableCell3});
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Weight = 1D;
            // 
            // tableCell3
            // 
            this.tableCell3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.tableCell3.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell3.Name = "tableCell3";
            this.tableCell3.StyleName = "DetailCaption1";
            this.tableCell3.StylePriority.UseBorders = false;
            this.tableCell3.StylePriority.UseFont = false;
            this.tableCell3.Text = "IR";
            this.tableCell3.Weight = 0.050555942125293275D;
            // 
            // tableCell5
            // 
            this.tableCell5.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell5.Name = "tableCell5";
            this.tableCell5.StyleName = "DetailCaption1";
            this.tableCell5.StylePriority.UseFont = false;
            this.tableCell5.Text = "Batch No.";
            this.tableCell5.Weight = 0.09354021732830993D;
            // 
            // tableCell6
            // 
            this.tableCell6.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell6.Name = "tableCell6";
            this.tableCell6.StyleName = "DetailCaption1";
            this.tableCell6.StylePriority.UseFont = false;
            this.tableCell6.StylePriority.UseTextAlignment = false;
            this.tableCell6.Text = "Batch Type";
            this.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell6.Weight = 0.05571570543048672D;
            // 
            // tableCell8
            // 
            this.tableCell8.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell8.Name = "tableCell8";
            this.tableCell8.StyleName = "DetailCaption1";
            this.tableCell8.StylePriority.UseFont = false;
            this.tableCell8.Text = "Color";
            this.tableCell8.Weight = 0.091457068407336251D;
            // 
            // tableCell11
            // 
            this.tableCell11.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell11.Name = "tableCell11";
            this.tableCell11.StyleName = "DetailCaption1";
            this.tableCell11.StylePriority.UseFont = false;
            this.tableCell11.Text = "Working Company";
            this.tableCell11.Weight = 0.082620818557460313D;
            // 
            // tableCell12
            // 
            this.tableCell12.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell12.Name = "tableCell12";
            this.tableCell12.StyleName = "DetailCaption1";
            this.tableCell12.StylePriority.UseFont = false;
            this.tableCell12.Text = "Construction";
            this.tableCell12.Weight = 0.15316498586659952D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StyleName = "DetailCaption1";
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.Text = "Delivery Date";
            this.xrTableCell1.Weight = 0.053191225126820632D;
            // 
            // tableCell13
            // 
            this.tableCell13.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell13.Name = "tableCell13";
            this.tableCell13.StyleName = "DetailCaption1";
            this.tableCell13.StylePriority.UseFont = false;
            this.tableCell13.StylePriority.UseTextAlignment = false;
            this.tableCell13.Text = "Fabric  Qty";
            this.tableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell13.Weight = 0.062639403001367611D;
            // 
            // tableCell14
            // 
            this.tableCell14.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell14.Name = "tableCell14";
            this.tableCell14.StyleName = "DetailCaption1";
            this.tableCell14.StylePriority.UseFont = false;
            this.tableCell14.StylePriority.UseTextAlignment = false;
            this.tableCell14.Text = "G_Del Qty";
            this.tableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell14.Weight = 0.05620159409777703D;
            // 
            // tableCell17
            // 
            this.tableCell17.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell17.Name = "tableCell17";
            this.tableCell17.StyleName = "DetailCaption1";
            this.tableCell17.StylePriority.UseFont = false;
            this.tableCell17.StylePriority.UseTextAlignment = false;
            this.tableCell17.Text = "Rate";
            this.tableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell17.Weight = 0.046805932312966418D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StyleName = "DetailCaption1";
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "Amount";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell3.Weight = 0.068369775022901924D;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table3});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            // 
            // table3
            // 
            this.table3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table3.Name = "table3";
            this.table3.OddStyleName = "DetailData3_Odd";
            this.table3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow3});
            this.table3.SizeF = new System.Drawing.SizeF(1069F, 25F);
            // 
            // tableRow3
            // 
            this.tableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell18,
            this.tableCell20,
            this.tableCell21,
            this.tableCell23,
            this.tableCell26,
            this.tableCell27,
            this.xrTableCell2,
            this.tableCell28,
            this.tableCell29,
            this.tableCell32,
            this.xrTableCell4});
            this.tableRow3.Name = "tableRow3";
            this.tableRow3.Weight = 11.5D;
            // 
            // tableCell18
            // 
            this.tableCell18.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.tableCell18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[INTERNAL_REF]")});
            this.tableCell18.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell18.Name = "tableCell18";
            this.tableCell18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell18.StyleName = "DetailData1";
            this.tableCell18.StylePriority.UseBorders = false;
            this.tableCell18.StylePriority.UseFont = false;
            this.tableCell18.StylePriority.UsePadding = false;
            this.tableCell18.Weight = 0.050555936680959958D;
            // 
            // tableCell20
            // 
            this.tableCell20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BATCH_NO]")});
            this.tableCell20.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell20.Name = "tableCell20";
            this.tableCell20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell20.StyleName = "DetailData1";
            this.tableCell20.StylePriority.UseFont = false;
            this.tableCell20.StylePriority.UsePadding = false;
            this.tableCell20.Weight = 0.093540248766968245D;
            // 
            // tableCell21
            // 
            this.tableCell21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([BATCH_AGAINST]=1,\'Bulk\' ,Iif([BATCH_AGAINST]=2,\'Re-Process\' ,Iif([BATCH_AGAI" +
                    "NST]=3, \'Sample\',\'\' ) ) )\n")});
            this.tableCell21.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell21.Name = "tableCell21";
            this.tableCell21.StyleName = "DetailData1";
            this.tableCell21.StylePriority.UseFont = false;
            this.tableCell21.StylePriority.UseTextAlignment = false;
            this.tableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.tableCell21.TextFormatString = "{0}";
            this.tableCell21.Weight = 0.055715665919193191D;
            // 
            // tableCell23
            // 
            this.tableCell23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[COLOR_NAME]")});
            this.tableCell23.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell23.Name = "tableCell23";
            this.tableCell23.StyleName = "DetailData1";
            this.tableCell23.StylePriority.UseFont = false;
            this.tableCell23.Weight = 0.09145707110805032D;
            // 
            // tableCell26
            // 
            this.tableCell26.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([COMPANY_NAME] is null,\'Off-Site\' ,[COMPANY_NAME] )")});
            this.tableCell26.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell26.Name = "tableCell26";
            this.tableCell26.StyleName = "DetailData1";
            this.tableCell26.StylePriority.UseFont = false;
            this.tableCell26.Weight = 0.082620914660884948D;
            // 
            // tableCell27
            // 
            this.tableCell27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PRODUCT_NAME_DETAILS]")});
            this.tableCell27.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell27.Name = "tableCell27";
            this.tableCell27.StyleName = "DetailData1";
            this.tableCell27.StylePriority.UseFont = false;
            this.tableCell27.Weight = 0.15316499199618944D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DELIVERY_DATE]")});
            this.xrTableCell2.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StyleName = "DetailData1";
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.Text = "xrTableCell2";
            this.xrTableCell2.TextFormatString = "{0:dd-MMM-yy}";
            this.xrTableCell2.Weight = 0.053191224205705184D;
            // 
            // tableCell28
            // 
            this.tableCell28.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BATCH_QNTY]")});
            this.tableCell28.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell28.Name = "tableCell28";
            this.tableCell28.ProcessDuplicatesMode = DevExpress.XtraReports.UI.ProcessDuplicatesMode.Merge;
            this.tableCell28.StyleName = "DetailData1";
            this.tableCell28.StylePriority.UseFont = false;
            this.tableCell28.StylePriority.UseTextAlignment = false;
            this.tableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell28.Weight = 0.062639408887110545D;
            // 
            // tableCell29
            // 
            this.tableCell29.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DELIVERY_QTY]")});
            this.tableCell29.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell29.Name = "tableCell29";
            this.tableCell29.StyleName = "DetailData1";
            this.tableCell29.StylePriority.UseFont = false;
            this.tableCell29.StylePriority.UseTextAlignment = false;
            this.tableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell29.Weight = 0.056201507063477672D;
            // 
            // tableCell32
            // 
            this.tableCell32.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[RATE]")});
            this.tableCell32.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell32.Name = "tableCell32";
            this.tableCell32.StyleName = "DetailData1";
            this.tableCell32.StylePriority.UseFont = false;
            this.tableCell32.StylePriority.UseTextAlignment = false;
            this.tableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell32.Weight = 0.046805853287602062D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AMOUNT]")});
            this.xrTableCell4.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StyleName = "DetailData1";
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "xrTableCell4";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell4.TextFormatString = "{0:N}";
            this.xrTableCell4.Weight = 0.0683699021275077D;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter1.HeightF = 0F;
            this.GroupFooter1.Name = "GroupFooter1";
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
            // PageInfo
            // 
            this.PageInfo.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // DD_Start
            // 
            this.DD_Start.ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] {
            new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Value", "Today()")});
            this.DD_Start.Name = "DD_Start";
            this.DD_Start.ValueInfo = "2026-07-05";
            // 
            // DD_End
            // 
            this.DD_End.ExpressionBindings.AddRange(new DevExpress.XtraReports.Expressions.BasicExpressionBinding[] {
            new DevExpress.XtraReports.Expressions.BasicExpressionBinding("Value", "Today()")});
            this.DD_End.Name = "DD_End";
            this.DD_End.ValueInfo = "2026-07-05";
            // 
            // DD
            // 
            this.DD.Description = "Select Delivery Date";
            this.DD.Name = "DD";
            this.DD.Type = typeof(global::System.DateTime);
            this.DD.ValueSourceSettings = new DevExpress.XtraReports.Parameters.RangeParametersSettings(this.DD_Start, this.DD_End);
            // 
            // W_COMPANY
            // 
            this.W_COMPANY.Description = "Select Working Company";
            this.W_COMPANY.MultiValue = true;
            this.W_COMPANY.Name = "W_COMPANY";
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue("Tropical Knitex Ltd.", null));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue("Cotton Club BD Ltd.", null));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue("OFF-SITE", null));
            this.W_COMPANY.ValueSourceSettings = staticListLookUpSettings1;
            // 
            // IR
            // 
            this.IR.AllowNull = true;
            this.IR.Description = "Select Internal Ref.";
            this.IR.MultiValue = true;
            this.IR.Name = "IR";
            this.IR.SelectAllValues = true;
            dynamicListLookUpSettings1.DataMember = "Query_1";
            dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings1.DisplayMember = "GROUPING";
            dynamicListLookUpSettings1.FilterString = null;
            dynamicListLookUpSettings1.SortMember = "GROUPING";
            dynamicListLookUpSettings1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            dynamicListLookUpSettings1.ValueMember = "GROUPING";
            this.IR.ValueSourceSettings = dynamicListLookUpSettings1;
            // 
            // rptDyeingBill
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.GroupHeader2,
            this.Detail,
            this.GroupFooter1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "DYEING_BILL";
            this.DataSource = this.sqlDataSource1;
            this.FilterString = "[DELIVERY_DATE] Between(?DD_Start, ?DD_End) And [COMPANY_NAME] In (?W_COMPANY) An" +
    "d [INTERNAL_REF] In (?IR)";
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Landscape = true;
            this.Margins = new DevExpress.Drawing.DXMargins(50F, 50F, 18.75F, 30.04166F);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DD, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.W_COMPANY, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IR, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.DD,
            this.W_COMPANY,
            this.IR});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.GroupCaption1,
            this.GroupData1,
            this.DetailCaption1,
            this.DetailData1,
            this.GroupFooterBackground3,
            this.DetailData3_Odd,
            this.PageInfo});
            this.Version = "23.2";
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
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
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable table1;
        private DevExpress.XtraReports.UI.XRTableRow tableRow1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell6;
        private DevExpress.XtraReports.UI.XRTableCell tableCell8;
        private DevExpress.XtraReports.UI.XRTableCell tableCell11;
        private DevExpress.XtraReports.UI.XRTableCell tableCell12;
        private DevExpress.XtraReports.UI.XRTableCell tableCell13;
        private DevExpress.XtraReports.UI.XRTableCell tableCell14;
        private DevExpress.XtraReports.UI.XRTableCell tableCell17;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable table3;
        private DevExpress.XtraReports.UI.XRTableRow tableRow3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell18;
        private DevExpress.XtraReports.UI.XRTableCell tableCell20;
        private DevExpress.XtraReports.UI.XRTableCell tableCell21;
        private DevExpress.XtraReports.UI.XRTableCell tableCell23;
        private DevExpress.XtraReports.UI.XRTableCell tableCell26;
        private DevExpress.XtraReports.UI.XRTableCell tableCell27;
        private DevExpress.XtraReports.UI.XRTableCell tableCell28;
        private DevExpress.XtraReports.UI.XRTableCell tableCell29;
        private DevExpress.XtraReports.UI.XRTableCell tableCell32;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle GroupCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle GroupData1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
        private DevExpress.XtraReports.UI.XRControlStyle GroupFooterBackground3;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.Parameters.RangeStartParameter DD_Start;
        private DevExpress.XtraReports.Parameters.RangeEndParameter DD_End;
        private DevExpress.XtraReports.Parameters.Parameter DD;
        private DevExpress.XtraReports.Parameters.Parameter W_COMPANY;
        private DevExpress.XtraReports.UI.XRTableCell tableCell2;
        private DevExpress.XtraReports.Parameters.Parameter IR;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
    }
}
