using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportHub_V2.Reports
{
    public partial class rpt_Closing_Order_Details : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_Closing_Order_Details()
        {
            InitializeComponent();
        }

        private XRTableCell xrTableCell1;
        private XRTableCell xrTableCell2;
        private ReportFooterBand ReportFooter;
        private XRTable xrTable1;
        private XRTableRow xrTableRow1;
        private XRTableCell xrTableCell3;
        private XRTableCell xrTableCell4;
        private XRTableCell xrTableCell5;
        private XRTableCell xrTableCell6;
        private XRTableCell xrTableCell7;
        private XRTableCell xrTableCell8;
        private XRTableCell xrTableCell9;
        private XRTableCell xrTableCell10;
        private XRTableCell xrTableCell11;
        private XRTableCell xrTableCell12;
        private CalculatedField ShipOutPercent;
        private CalculatedField ShortOrExcess;
        private DevExpress.XtraReports.Parameters.Parameter IRIB;
    }
}
