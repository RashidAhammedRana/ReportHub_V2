namespace ReportHub_V2.Reports
{
    partial class rptCuttingDetails
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
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo1 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptCuttingDetails));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.IR = new DevExpress.XtraReports.Parameters.Parameter();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.InputQty3 = new DevExpress.XtraReports.UI.CalculatedField();
            this.BalanceQty = new DevExpress.XtraReports.UI.CalculatedField();
            this.Actual_Cons = new DevExpress.XtraReports.UI.CalculatedField();
            this.ActualConsumption = new DevExpress.XtraReports.UI.CalculatedField();
            this.FabricCuttingBalance = new DevExpress.XtraReports.UI.CalculatedField();
            this.RequiredShortNote = new DevExpress.XtraReports.UI.CalculatedField();
            this.RequiredFabric = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DefaultConnection";
            this.sqlDataSource1.ConnectionOptions.CommandTimeout = 600;
            this.sqlDataSource1.ConnectionOptions.DbCommandTimeout = 600;
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.MetaSerializable = "<Meta X=\"20\" Y=\"20\" Width=\"162\" Height=\"244\" />";
            storedProcQuery1.Name = "rpt_Cutting_Details";
            queryParameter1.Name = "@Grouping";
            queryParameter1.Type = typeof(global::DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?IR", typeof(string));
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            storedProcQuery1.StoredProcName = "rpt_Cutting_Details";
            storedProcQuery2.MetaSerializable = "<Meta X=\"202\" Y=\"20\" Width=\"100\" Height=\"64\" />";
            storedProcQuery2.Name = "Query";
            storedProcQuery2.StoredProcName = "BOOKING_NO";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2});
            masterDetailInfo1.DetailQueryName = "Query_1";
            relationColumnInfo1.NestedKeyColumn = "JOB_NO";
            relationColumnInfo1.ParentKeyColumn = "JOB_NO";
            relationColumnInfo2.NestedKeyColumn = "COLOR_NAME";
            relationColumnInfo2.ParentKeyColumn = "COLOR_NAME";
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo1);
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo2);
            masterDetailInfo1.MasterQueryName = "rpt_Cutting_Details";
            this.sqlDataSource1.Relations.AddRange(new DevExpress.DataAccess.Sql.MasterDetailInfo[] {
            masterDetailInfo1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 7.5F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 14.33334F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
            this.Detail.HeightF = 18.33333F;
            this.Detail.Name = "Detail";
            // 
            // table2
            // 
            this.table2.BorderColor = System.Drawing.Color.DimGray;
            this.table2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.table2.BorderWidth = 0.5F;
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table2.Name = "table2";
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
            this.table2.SizeF = new System.Drawing.SizeF(1240.628F, 18.33333F);
            this.table2.StylePriority.UseBorderColor = false;
            this.table2.StylePriority.UseBorders = false;
            this.table2.StylePriority.UseBorderWidth = false;
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.tableCell12,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell19,
            this.xrTableCell20,
            this.xrTableCell21,
            this.xrTableCell22,
            this.xrTableCell23,
            this.xrTableCell24,
            this.xrTableCell25,
            this.xrTableCell26,
            this.xrTableCell27,
            this.xrTableCell28,
            this.xrTableCell29,
            this.xrTableCell30});
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Weight = 11.5D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CONSTRUCTION]")});
            this.xrTableCell7.Font = new DevExpress.Drawing.DXFont("Calibri", 7F);
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrTableCell7.StylePriority.UseBorders = false;
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UsePadding = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "xrTableCell7";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell7.Weight = 0.10940110629531626D;
            // 
            // tableCell12
            // 
            this.tableCell12.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[COLOR_NAME]")});
            this.tableCell12.Font = new DevExpress.Drawing.DXFont("Calibri", 7F);
            this.tableCell12.Name = "tableCell12";
            this.tableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100F);
            this.tableCell12.StylePriority.UseBorders = false;
            this.tableCell12.StylePriority.UseFont = false;
            this.tableCell12.StylePriority.UsePadding = false;
            this.tableCell12.StylePriority.UseTextAlignment = false;
            this.tableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell12.Weight = 0.09655479952507319D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ToInt(Round([REQ_FIN_FAB], 0))")});
            this.xrTableCell4.Font = new DevExpress.Drawing.DXFont("Calibri", 7F);
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell4.TextFormatString = "{0}";
            this.xrTableCell4.Weight = 0.03209599173734265D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ToInt(Round([ORDER_QUANTITY], 0))\n")});
            this.xrTableCell5.Font = new DevExpress.Drawing.DXFont("Calibri", 7F);
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 4, 0, 0, 100F);
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "xrTableCell5";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell5.Weight = 0.029831047304090051D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ToInt(Round([InputQty3], 0))\n")});
            this.xrTableCell19.Font = new DevExpress.Drawing.DXFont("Calibri", 7F);
            this.xrTableCell19.Multiline = true;
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 4, 0, 0, 100F);
            this.xrTableCell19.StylePriority.UseBorders = false;
            this.xrTableCell19.StylePriority.UseFont = false;
            this.xrTableCell19.StylePriority.UsePadding = false;
            this.xrTableCell19.StylePriority.UseTextAlignment = false;
            this.xrTableCell19.Text = "xrTableCell19";
            this.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell19.Weight = 0.028406775415903446D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ToInt(Round([CUTTING_PRODUCTION], 0))\n")});
            this.xrTableCell20.Font = new DevExpress.Drawing.DXFont("Calibri", 7F);
            this.xrTableCell20.Multiline = true;
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 4, 0, 0, 100F);
            this.xrTableCell20.StylePriority.UseBorders = false;
            this.xrTableCell20.StylePriority.UseFont = false;
            this.xrTableCell20.StylePriority.UsePadding = false;
            this.xrTableCell20.StylePriority.UseTextAlignment = false;
            this.xrTableCell20.Text = "xrTableCell20";
            this.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell20.Weight = 0.031588537670326704D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ToInt(Round([QC_PASS_QTY], 0))\n")});
            this.xrTableCell21.Font = new DevExpress.Drawing.DXFont("Calibri", 7F);
            this.xrTableCell21.Multiline = true;
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 4, 0, 0, 100F);
            this.xrTableCell21.StylePriority.UseBorders = false;
            this.xrTableCell21.StylePriority.UseFont = false;
            this.xrTableCell21.StylePriority.UsePadding = false;
            this.xrTableCell21.StylePriority.UseTextAlignment = false;
            this.xrTableCell21.Text = "xrTableCell21";
            this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell21.Weight = 0.031088471918405039D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ToInt(Round([REJECT_QTY], 0))")});
            this.xrTableCell22.Font = new DevExpress.Drawing.DXFont("Calibri", 7F);
            this.xrTableCell22.Multiline = true;
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 4, 0, 0, 100F);
            this.xrTableCell22.StylePriority.UseBorders = false;
            this.xrTableCell22.StylePriority.UseFont = false;
            this.xrTableCell22.StylePriority.UsePadding = false;
            this.xrTableCell22.StylePriority.UseTextAlignment = false;
            this.xrTableCell22.Text = "xrTableCell22";
            this.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell22.Weight = 0.030088395326169349D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ToInt(Round([REPLACE_QTY], 0))")});
            this.xrTableCell23.Font = new DevExpress.Drawing.DXFont("Calibri", 7F);
            this.xrTableCell23.Multiline = true;
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 4, 0, 0, 100F);
            this.xrTableCell23.StylePriority.UseBorders = false;
            this.xrTableCell23.StylePriority.UseFont = false;
            this.xrTableCell23.StylePriority.UsePadding = false;
            this.xrTableCell23.StylePriority.UseTextAlignment = false;
            this.xrTableCell23.Text = "xrTableCell23";
            this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell23.Weight = 0.032088585125637364D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ToInt(Round([BalanceQty], 0))")});
            this.xrTableCell24.Font = new DevExpress.Drawing.DXFont("Calibri", 7F);
            this.xrTableCell24.Multiline = true;
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 4, 0, 0, 100F);
            this.xrTableCell24.StylePriority.UseBorders = false;
            this.xrTableCell24.StylePriority.UseFont = false;
            this.xrTableCell24.StylePriority.UsePadding = false;
            this.xrTableCell24.StylePriority.UseTextAlignment = false;
            this.xrTableCell24.Text = "xrTableCell24";
            this.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell24.Weight = 0.038588597741090337D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ActualConsumption]")});
            this.xrTableCell25.Font = new DevExpress.Drawing.DXFont("Calibri", 7F);
            this.xrTableCell25.Multiline = true;
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 4, 0, 0, 100F);
            this.xrTableCell25.StylePriority.UseBorders = false;
            this.xrTableCell25.StylePriority.UseFont = false;
            this.xrTableCell25.StylePriority.UsePadding = false;
            this.xrTableCell25.StylePriority.UseTextAlignment = false;
            this.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell25.TextFormatString = "{0:#.000}";
            this.xrTableCell25.Weight = 0.032588577644955305D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell26.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ToInt(Round([RequiredFabric],0))")});
            this.xrTableCell26.Font = new DevExpress.Drawing.DXFont("Calibri", 7F);
            this.xrTableCell26.Multiline = true;
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 4, 0, 0, 100F);
            this.xrTableCell26.StylePriority.UseBorders = false;
            this.xrTableCell26.StylePriority.UseFont = false;
            this.xrTableCell26.StylePriority.UsePadding = false;
            this.xrTableCell26.StylePriority.UseTextAlignment = false;
            this.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell26.Weight = 0.04116085098805064D;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell27.Font = new DevExpress.Drawing.DXFont("Calibri", 7F);
            this.xrTableCell27.Multiline = true;
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 4, 0, 0, 100F);
            this.xrTableCell27.StylePriority.UseBorders = false;
            this.xrTableCell27.StylePriority.UseFont = false;
            this.xrTableCell27.StylePriority.UsePadding = false;
            this.xrTableCell27.StylePriority.UseTextAlignment = false;
            this.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell27.TextFormatString = "{0:N2}";
            this.xrTableCell27.Weight = 0.036725335423596225D;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell28.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ToInt(Round([ROLL_WGT],0 ))")});
            this.xrTableCell28.Font = new DevExpress.Drawing.DXFont("Calibri", 7F);
            this.xrTableCell28.Multiline = true;
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 4, 0, 0, 100F);
            this.xrTableCell28.StylePriority.UseBorders = false;
            this.xrTableCell28.StylePriority.UseFont = false;
            this.xrTableCell28.StylePriority.UsePadding = false;
            this.xrTableCell28.StylePriority.UseTextAlignment = false;
            this.xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell28.Weight = 0.040725531928219212D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell29.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ToInt(Round([FabricCuttingBalance],0 ))")});
            this.xrTableCell29.Font = new DevExpress.Drawing.DXFont("Calibri", 7F);
            this.xrTableCell29.Multiline = true;
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 4, 0, 0, 100F);
            this.xrTableCell29.StylePriority.UseBorders = false;
            this.xrTableCell29.StylePriority.UseFont = false;
            this.xrTableCell29.StylePriority.UsePadding = false;
            this.xrTableCell29.StylePriority.UseTextAlignment = false;
            this.xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell29.Weight = 0.047225471300792334D;
            // 
            // xrTableCell30
            // 
            this.xrTableCell30.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell30.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ToInt(Round([RequiredShortNote],0 ))")});
            this.xrTableCell30.Font = new DevExpress.Drawing.DXFont("Calibri", 7F);
            this.xrTableCell30.Multiline = true;
            this.xrTableCell30.Name = "xrTableCell30";
            this.xrTableCell30.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 4, 0, 0, 100F);
            this.xrTableCell30.StylePriority.UseBorders = false;
            this.xrTableCell30.StylePriority.UseFont = false;
            this.xrTableCell30.StylePriority.UsePadding = false;
            this.xrTableCell30.StylePriority.UseTextAlignment = false;
            this.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell30.Weight = 0.086225794188229635D;
            // 
            // IR
            // 
            this.IR.Description = "Select IR/IB";
            this.IR.Name = "IR";
            dynamicListLookUpSettings1.DataMember = "Query";
            dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings1.DisplayMember = "GROUPING";
            dynamicListLookUpSettings1.FilterString = null;
            dynamicListLookUpSettings1.SortMember = null;
            dynamicListLookUpSettings1.ValueMember = "GROUPING";
            this.IR.ValueSourceSettings = dynamicListLookUpSettings1;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label1});
            this.ReportHeader.HeightF = 33.33333F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // label1
            // 
            this.label1.BorderColor = System.Drawing.Color.DimGray;
            this.label1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.label1.BorderWidth = 0.5F;
            this.label1.Font = new DevExpress.Drawing.DXFont("Calibri", 14F, DevExpress.Drawing.DXFontStyle.Bold);
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label1.Name = "label1";
            this.label1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.label1.SizeF = new System.Drawing.SizeF(1069F, 24.19433F);
            this.label1.StylePriority.UseBorderColor = false;
            this.label1.StylePriority.UseBorders = false;
            this.label1.StylePriority.UseBorderWidth = false;
            this.label1.StylePriority.UseFont = false;
            this.label1.StylePriority.UsePadding = false;
            this.label1.StylePriority.UseTextAlignment = false;
            this.label1.Text = "Cutting Details";
            this.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1});
            this.PageHeader.HeightF = 18.83333F;
            this.PageHeader.Name = "PageHeader";
            // 
            // table1
            // 
            this.table1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.table1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.table1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.table1.BorderWidth = 0.5F;
            this.table1.Font = new DevExpress.Drawing.DXFont("Calibri", 10F);
            this.table1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table1.Name = "table1";
            this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
            this.table1.SizeF = new System.Drawing.SizeF(1240.628F, 18.83333F);
            this.table1.StylePriority.UseBackColor = false;
            this.table1.StylePriority.UseBorderColor = false;
            this.table1.StylePriority.UseBorders = false;
            this.table1.StylePriority.UseBorderWidth = false;
            this.table1.StylePriority.UseFont = false;
            this.table1.StylePriority.UseTextAlignment = false;
            this.table1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // tableRow1
            // 
            this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell6,
            this.tableCell1,
            this.xrTableCell2,
            this.tableCell2,
            this.xrTableCell3,
            this.tableCell3,
            this.xrTableCell1,
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell12,
            this.xrTableCell13,
            this.xrTableCell14,
            this.xrTableCell15,
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell18});
            this.tableRow1.Name = "tableRow1";
            this.tableRow1.Weight = 1D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.BorderColor = System.Drawing.Color.DimGray;
            this.xrTableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell6.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseBorderColor = false;
            this.xrTableCell6.StylePriority.UseBorders = false;
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.Text = "Construction";
            this.xrTableCell6.Weight = 0.12026796482994338D;
            // 
            // tableCell1
            // 
            this.tableCell1.BorderColor = System.Drawing.Color.DimGray;
            this.tableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell1.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell1.Name = "tableCell1";
            this.tableCell1.StylePriority.UseBorderColor = false;
            this.tableCell1.StylePriority.UseBorders = false;
            this.tableCell1.StylePriority.UseFont = false;
            this.tableCell1.Text = "Color";
            this.tableCell1.Weight = 0.10614560526358381D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.BorderColor = System.Drawing.Color.DimGray;
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell2.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseBorderColor = false;
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.Text = "Finish Booking Qty (Kg)";
            this.xrTableCell2.Weight = 0.035284072127261257D;
            // 
            // tableCell2
            // 
            this.tableCell2.BorderColor = System.Drawing.Color.DimGray;
            this.tableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell2.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell2.Name = "tableCell2";
            this.tableCell2.StylePriority.UseBorderColor = false;
            this.tableCell2.StylePriority.UseBorders = false;
            this.tableCell2.StylePriority.UseFont = false;
            this.tableCell2.Text = "Order Qty (Pcs)";
            this.tableCell2.Weight = 0.032794231131593056D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.BorderColor = System.Drawing.Color.DimGray;
            this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell3.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseBorderColor = false;
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.Text = "Input Qty (3%)";
            this.xrTableCell3.Weight = 0.031228404679956807D;
            // 
            // tableCell3
            // 
            this.tableCell3.BorderColor = System.Drawing.Color.DimGray;
            this.tableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell3.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.tableCell3.Name = "tableCell3";
            this.tableCell3.StylePriority.UseBorderColor = false;
            this.tableCell3.StylePriority.UseBorders = false;
            this.tableCell3.StylePriority.UseFont = false;
            this.tableCell3.Text = "Cutting Qty (Pcs)";
            this.tableCell3.Weight = 0.034726191738277158D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BorderColor = System.Drawing.Color.DimGray;
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell1.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseBorderColor = false;
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.Text = "QC Pass Qty(Pcs)";
            this.xrTableCell1.Weight = 0.034176514732161919D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.BorderColor = System.Drawing.Color.DimGray;
            this.xrTableCell10.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell10.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell10.Multiline = true;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseBorderColor = false;
            this.xrTableCell10.StylePriority.UseBorders = false;
            this.xrTableCell10.StylePriority.UseFont = false;
            this.xrTableCell10.Text = "Reject Qty (Pcs)";
            this.xrTableCell10.Weight = 0.033077140590403988D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.BorderColor = System.Drawing.Color.DimGray;
            this.xrTableCell11.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell11.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell11.Multiline = true;
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StylePriority.UseBorderColor = false;
            this.xrTableCell11.StylePriority.UseBorders = false;
            this.xrTableCell11.StylePriority.UseFont = false;
            this.xrTableCell11.Text = "Replace Qty (Pcs)";
            this.xrTableCell11.Weight = 0.03527592913297474D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.BorderColor = System.Drawing.Color.DimGray;
            this.xrTableCell12.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell12.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell12.Multiline = true;
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.StylePriority.UseBorderColor = false;
            this.xrTableCell12.StylePriority.UseBorders = false;
            this.xrTableCell12.StylePriority.UseFont = false;
            this.xrTableCell12.Text = "Balance Qty (Pcs)";
            this.xrTableCell12.Weight = 0.0424215691762532D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.BorderColor = System.Drawing.Color.DimGray;
            this.xrTableCell13.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell13.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell13.Multiline = true;
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.StylePriority.UseBorderColor = false;
            this.xrTableCell13.StylePriority.UseBorders = false;
            this.xrTableCell13.StylePriority.UseFont = false;
            this.xrTableCell13.Text = "Actual Cons.";
            this.xrTableCell13.Weight = 0.035825606139089972D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.BorderColor = System.Drawing.Color.DimGray;
            this.xrTableCell14.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell14.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell14.Multiline = true;
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.StylePriority.UseBorderColor = false;
            this.xrTableCell14.StylePriority.UseBorders = false;
            this.xrTableCell14.StylePriority.UseFont = false;
            this.xrTableCell14.Text = "Required Fabric";
            this.xrTableCell14.Weight = 0.045249327528240138D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.BorderColor = System.Drawing.Color.DimGray;
            this.xrTableCell15.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell15.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell15.Multiline = true;
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.StylePriority.UseBorderColor = false;
            this.xrTableCell15.StylePriority.UseBorders = false;
            this.xrTableCell15.StylePriority.UseFont = false;
            this.xrTableCell15.Text = "Fabric Issue From Store";
            this.xrTableCell15.Weight = 0.040373311558982265D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.BorderColor = System.Drawing.Color.DimGray;
            this.xrTableCell16.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell16.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell16.Multiline = true;
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.StylePriority.UseBorderColor = false;
            this.xrTableCell16.StylePriority.UseBorders = false;
            this.xrTableCell16.StylePriority.UseFont = false;
            this.xrTableCell16.Text = "Fabric Used";
            this.xrTableCell16.Weight = 0.044770722575522282D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.BorderColor = System.Drawing.Color.DimGray;
            this.xrTableCell17.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell17.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell17.Multiline = true;
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.StylePriority.UseBorderColor = false;
            this.xrTableCell17.StylePriority.UseBorders = false;
            this.xrTableCell17.StylePriority.UseFont = false;
            this.xrTableCell17.Text = "Fabric Cutting Balance";
            this.xrTableCell17.Weight = 0.051916463266437993D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.BorderColor = System.Drawing.Color.DimGray;
            this.xrTableCell18.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell18.Font = new DevExpress.Drawing.DXFont("Calibri", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell18.Multiline = true;
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.StylePriority.UseBorderColor = false;
            this.xrTableCell18.StylePriority.UseBorders = false;
            this.xrTableCell18.StylePriority.UseFont = false;
            this.xrTableCell18.Text = "Required as Short Note";
            this.xrTableCell18.Weight = 0.094790786634767532D;
            // 
            // ReportFooter
            // 
            this.ReportFooter.HeightF = 0F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // InputQty3
            // 
            this.InputQty3.DataMember = "rpt_Cutting_Details";
            this.InputQty3.Expression = "[ORDER_QUANTITY]+ [ORDER_QUANTITY]*3/100";
            this.InputQty3.Name = "InputQty3";
            // 
            // BalanceQty
            // 
            this.BalanceQty.DataMember = "rpt_Cutting_Details";
            this.BalanceQty.Expression = "[InputQty3]-[QC_PASS_QTY]";
            this.BalanceQty.Name = "BalanceQty";
            // 
            // Actual_Cons
            // 
            this.Actual_Cons.DataMember = "Query_1";
            this.Actual_Cons.Name = "Actual_Cons";
            // 
            // ActualConsumption
            // 
            this.ActualConsumption.DataMember = "rpt_Cutting_Details";
            this.ActualConsumption.Expression = "[ROLL_WGT]/[QC_PASS_QTY]*12\n";
            this.ActualConsumption.Name = "ActualConsumption";
            // 
            // FabricCuttingBalance
            // 
            this.FabricCuttingBalance.DataMember = "rpt_Cutting_Details";
            this.FabricCuttingBalance.Expression = "[REQ_FIN_FAB]-[ROLL_WGT]";
            this.FabricCuttingBalance.Name = "FabricCuttingBalance";
            // 
            // RequiredShortNote
            // 
            this.RequiredShortNote.DataMember = "rpt_Cutting_Details";
            this.RequiredShortNote.Expression = "[RequiredFabric]-[FabricCuttingBalance]";
            this.RequiredShortNote.Name = "RequiredShortNote";
            // 
            // RequiredFabric
            // 
            this.RequiredFabric.DataMember = "rpt_Cutting_Details";
            this.RequiredFabric.Expression = "[BalanceQty]/12*[ActualConsumption]";
            this.RequiredFabric.Name = "RequiredFabric";
            // 
            // rptCuttingDetails
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.PageHeader,
            this.ReportFooter});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.InputQty3,
            this.BalanceQty,
            this.Actual_Cons,
            this.ActualConsumption,
            this.FabricCuttingBalance,
            this.RequiredShortNote,
            this.RequiredFabric});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "rpt_Cutting_Details";
            this.DataSource = this.sqlDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Landscape = true;
            this.Margins = new DevExpress.Drawing.DXMargins(13F, 18F, 7.5F, 14.33334F);
            this.PageHeight = 850;
            this.PageWidth = 1400;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Legal;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IR, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IR});
            this.Version = "23.2";
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.Parameters.Parameter IR;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.XRTable table1;
        private DevExpress.XtraReports.UI.XRTableRow tableRow1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell3;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell12;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell13;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell14;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell15;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell16;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell17;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell18;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell19;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell20;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell21;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell22;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell23;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell24;
        private DevExpress.XtraReports.UI.CalculatedField InputQty3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell25;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell26;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell27;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell28;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell29;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell30;
        private DevExpress.XtraReports.UI.CalculatedField BalanceQty;
        private DevExpress.XtraReports.UI.CalculatedField Actual_Cons;
        private DevExpress.XtraReports.UI.CalculatedField ActualConsumption;
        private DevExpress.XtraReports.UI.CalculatedField FabricCuttingBalance;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.CalculatedField RequiredShortNote;
        private DevExpress.XtraReports.UI.CalculatedField RequiredFabric;
    }
}
