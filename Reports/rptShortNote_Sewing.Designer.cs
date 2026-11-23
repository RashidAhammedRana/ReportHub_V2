namespace ReportHub_V2.Reports
{
    partial class rptShortNote_Sewing
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
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptShortNote_Sewing));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.IR = new DevExpress.XtraReports.Parameters.Parameter();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DefaultConnection";
            this.sqlDataSource1.ConnectionOptions.CommandTimeout = 300;
            this.sqlDataSource1.ConnectionOptions.DbCommandTimeout = 300;
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "rptSewing_WIP";
            queryParameter1.Name = "@BOOKING_NO";
            queryParameter1.Type = typeof(global::DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?IR", typeof(string));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            storedProcQuery1.StoredProcName = "rpt_Short_Note_Sewing";
            storedProcQuery2.Name = "Query";
            storedProcQuery2.StoredProcName = "BOOKING_NO";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 16.66667F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label1});
            this.ReportHeader.HeightF = 24.19433F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // label1
            // 
            this.label1.Font = new DevExpress.Drawing.DXFont("Calibri", 14F, DevExpress.Drawing.DXFontStyle.Bold);
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(1059F, 24.19433F);
            this.label1.StyleName = "Title";
            this.label1.StylePriority.UseFont = false;
            this.label1.Text = "Sewing Details";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader1.HeightF = 28F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // table1
            // 
            this.table1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.table1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.table1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.table1.BorderWidth = 0.5F;
            this.table1.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.table1.ForeColor = System.Drawing.Color.DarkGray;
            this.table1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table1.Name = "table1";
            this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
            this.table1.SizeF = new System.Drawing.SizeF(1059F, 28F);
            this.table1.StylePriority.UseBackColor = false;
            this.table1.StylePriority.UseBorderColor = false;
            this.table1.StylePriority.UseBorders = false;
            this.table1.StylePriority.UseBorderWidth = false;
            this.table1.StylePriority.UseFont = false;
            this.table1.StylePriority.UseForeColor = false;
            // 
            // tableRow1
            // 
            this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell7,
            this.tableCell9,
            this.tableCell10,
            this.tableCell11,
            this.tableCell12,
            this.tableCell13,
            this.tableCell14,
            this.tableCell15});
            this.tableRow1.Name = "tableRow1";
            this.tableRow1.Weight = 1D;
            // 
            // tableCell7
            // 
            this.tableCell7.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell7.Name = "tableCell7";
            this.tableCell7.StyleName = "DetailCaption1";
            this.tableCell7.StylePriority.UseFont = false;
            this.tableCell7.Text = "Style";
            this.tableCell7.Weight = 0.091127554068704611D;
            // 
            // tableCell9
            // 
            this.tableCell9.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell9.Name = "tableCell9";
            this.tableCell9.StyleName = "DetailCaption1";
            this.tableCell9.StylePriority.UseFont = false;
            this.tableCell9.Text = "Booking No.";
            this.tableCell9.Weight = 0.065246173263687382D;
            // 
            // tableCell10
            // 
            this.tableCell10.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell10.Name = "tableCell10";
            this.tableCell10.StyleName = "DetailCaption1";
            this.tableCell10.StylePriority.UseFont = false;
            this.tableCell10.Text = "Item";
            this.tableCell10.Weight = 0.066647414980165048D;
            // 
            // tableCell11
            // 
            this.tableCell11.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell11.Name = "tableCell11";
            this.tableCell11.StyleName = "DetailCaption1";
            this.tableCell11.StylePriority.UseFont = false;
            this.tableCell11.Text = "Color";
            this.tableCell11.Weight = 0.13481267471309008D;
            // 
            // tableCell12
            // 
            this.tableCell12.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell12.Name = "tableCell12";
            this.tableCell12.StyleName = "DetailCaption1";
            this.tableCell12.StylePriority.UseFont = false;
            this.tableCell12.StylePriority.UseTextAlignment = false;
            this.tableCell12.Text = "Send to Sewing Qty";
            this.tableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell12.Weight = 0.079928374871191921D;
            // 
            // tableCell13
            // 
            this.tableCell13.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell13.Name = "tableCell13";
            this.tableCell13.StyleName = "DetailCaption1";
            this.tableCell13.StylePriority.UseFont = false;
            this.tableCell13.StylePriority.UseTextAlignment = false;
            this.tableCell13.Text = "Input Qty";
            this.tableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell13.Weight = 0.042994500138251769D;
            // 
            // tableCell14
            // 
            this.tableCell14.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell14.Name = "tableCell14";
            this.tableCell14.StyleName = "DetailCaption1";
            this.tableCell14.StylePriority.UseFont = false;
            this.tableCell14.StylePriority.UseTextAlignment = false;
            this.tableCell14.Text = "Output Qty";
            this.tableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell14.Weight = 0.042994500564201281D;
            // 
            // tableCell15
            // 
            this.tableCell15.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell15.Name = "tableCell15";
            this.tableCell15.StyleName = "DetailCaption1";
            this.tableCell15.StylePriority.UseFont = false;
            this.tableCell15.StylePriority.UseTextAlignment = false;
            this.tableCell15.Text = "Reject Qty";
            this.tableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell15.Weight = 0.03980152983914758D;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
            this.Detail.HeightF = 20F;
            this.Detail.Name = "Detail";
            // 
            // table2
            // 
            this.table2.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table2.Name = "table2";
            this.table2.OddStyleName = "DetailData3_Odd";
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
            this.table2.SizeF = new System.Drawing.SizeF(1059F, 20F);
            this.table2.StylePriority.UseFont = false;
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell22,
            this.tableCell24,
            this.tableCell25,
            this.tableCell26,
            this.tableCell27,
            this.tableCell28,
            this.tableCell29,
            this.tableCell30});
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Weight = 11.5D;
            // 
            // tableCell22
            // 
            this.tableCell22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[STYLE_REF_NO]")});
            this.tableCell22.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell22.Name = "tableCell22";
            this.tableCell22.StyleName = "DetailData1";
            this.tableCell22.StylePriority.UseFont = false;
            this.tableCell22.Weight = 0.091127545756100964D;
            // 
            // tableCell24
            // 
            this.tableCell24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BOOKING_NO]")});
            this.tableCell24.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell24.Name = "tableCell24";
            this.tableCell24.StyleName = "DetailData1";
            this.tableCell24.StylePriority.UseFont = false;
            this.tableCell24.Weight = 0.065246197657997079D;
            // 
            // tableCell25
            // 
            this.tableCell25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ITEM_NAME]")});
            this.tableCell25.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell25.Name = "tableCell25";
            this.tableCell25.StyleName = "DetailData1";
            this.tableCell25.StylePriority.UseFont = false;
            this.tableCell25.Weight = 0.066647465945812792D;
            // 
            // tableCell26
            // 
            this.tableCell26.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[COLOR_NAME]")});
            this.tableCell26.Font = new DevExpress.Drawing.DXFont("Calibri", 8F);
            this.tableCell26.Name = "tableCell26";
            this.tableCell26.StyleName = "DetailData1";
            this.tableCell26.StylePriority.UseFont = false;
            this.tableCell26.Weight = 0.13481260653517363D;
            // 
            // tableCell27
            // 
            this.tableCell27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SEND_TO_SEWING_QTY]")});
            this.tableCell27.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell27.Name = "tableCell27";
            this.tableCell27.StyleName = "DetailData1";
            this.tableCell27.StylePriority.UseFont = false;
            this.tableCell27.StylePriority.UseTextAlignment = false;
            this.tableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell27.Weight = 0.079928363419575474D;
            // 
            // tableCell28
            // 
            this.tableCell28.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[INPUT_QTY]")});
            this.tableCell28.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell28.Name = "tableCell28";
            this.tableCell28.StyleName = "DetailData1";
            this.tableCell28.StylePriority.UseFont = false;
            this.tableCell28.StylePriority.UseTextAlignment = false;
            this.tableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell28.Weight = 0.042994500306301177D;
            // 
            // tableCell29
            // 
            this.tableCell29.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OUTPUT_QTY]")});
            this.tableCell29.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell29.Name = "tableCell29";
            this.tableCell29.StyleName = "DetailData1";
            this.tableCell29.StylePriority.UseFont = false;
            this.tableCell29.StylePriority.UseTextAlignment = false;
            this.tableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell29.Weight = 0.042994500845087533D;
            // 
            // tableCell30
            // 
            this.tableCell30.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[REJECT_QTY]")});
            this.tableCell30.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell30.Name = "tableCell30";
            this.tableCell30.StyleName = "DetailData1";
            this.tableCell30.StylePriority.UseFont = false;
            this.tableCell30.StylePriority.UseTextAlignment = false;
            this.tableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell30.Weight = 0.039801535437382518D;
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
            // IR
            // 
            this.IR.Description = "IR";
            this.IR.Name = "IR";
            dynamicListLookUpSettings1.DataMember = "Query";
            dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings1.DisplayMember = "GROUPING";
            dynamicListLookUpSettings1.FilterString = null;
            dynamicListLookUpSettings1.SortMember = "GROUPING";
            dynamicListLookUpSettings1.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            dynamicListLookUpSettings1.ValueMember = "GROUPING";
            this.IR.ValueSourceSettings = dynamicListLookUpSettings1;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.GroupFooter1.HeightF = 20F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(419.0903F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.OddStyleName = "DetailData3_Odd";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(639.9097F, 20F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 11.5D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StyleName = "DetailData1";
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "Total:";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell4.Weight = 0.13481260653517363D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([SEND_TO_SEWING_QTY])")});
            this.xrTableCell5.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StyleName = "DetailData1";
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell5.Summary = xrSummary1;
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell5.Weight = 0.079928363419575474D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([INPUT_QTY])")});
            this.xrTableCell6.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StyleName = "DetailData1";
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell6.Summary = xrSummary2;
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell6.Weight = 0.042994500306301177D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([OUTPUT_QTY])")});
            this.xrTableCell7.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StyleName = "DetailData1";
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell7.Summary = xrSummary3;
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell7.Weight = 0.042994500845087533D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([REJECT_QTY])")});
            this.xrTableCell8.Font = new DevExpress.Drawing.DXFont("Calibri", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StyleName = "DetailData1";
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell8.Summary = xrSummary4;
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell8.Weight = 0.039801535437382518D;
            // 
            // rptShortNote_Sewing
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.Detail,
            this.GroupFooter1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "rptSewing_WIP";
            this.DataSource = this.sqlDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Landscape = true;
            this.Margins = new DevExpress.Drawing.DXMargins(20F, 21F, 16.66667F, 0F);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IR, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IR});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.PageInfo});
            this.Version = "23.2";
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable table1;
        private DevExpress.XtraReports.UI.XRTableRow tableRow1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell9;
        private DevExpress.XtraReports.UI.XRTableCell tableCell10;
        private DevExpress.XtraReports.UI.XRTableCell tableCell11;
        private DevExpress.XtraReports.UI.XRTableCell tableCell12;
        private DevExpress.XtraReports.UI.XRTableCell tableCell13;
        private DevExpress.XtraReports.UI.XRTableCell tableCell14;
        private DevExpress.XtraReports.UI.XRTableCell tableCell15;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell22;
        private DevExpress.XtraReports.UI.XRTableCell tableCell24;
        private DevExpress.XtraReports.UI.XRTableCell tableCell25;
        private DevExpress.XtraReports.UI.XRTableCell tableCell26;
        private DevExpress.XtraReports.UI.XRTableCell tableCell27;
        private DevExpress.XtraReports.UI.XRTableCell tableCell28;
        private DevExpress.XtraReports.UI.XRTableCell tableCell29;
        private DevExpress.XtraReports.UI.XRTableCell tableCell30;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.Parameters.Parameter IR;
        private DevExpress.XtraReports.UI.XRTableCell tableCell7;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
    }
}
