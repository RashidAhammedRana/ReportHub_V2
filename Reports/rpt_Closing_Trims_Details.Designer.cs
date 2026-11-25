using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportHub_V2.Reports
{
    public partial class rpt_Closing_Trims_Details : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_Closing_Trims_Details()
        {
            InitializeComponent();
        }
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
        private XRTableCell xrTableCell1;
        private XRTableCell xrTableCell2;
        private XRTableCell xrTableCell13;
        private XRTableCell xrTableCell14;
        private CalculatedField LeftOver;
        private CalculatedField ReceivedBalance;
        private DevExpress.XtraReports.Parameters.Parameter IRIB;
    }
}
