using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using ReportHub_V2.Data;
using ReportHub_V2.Models;

public class ReportCallingController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;
    public ReportCallingController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    [HttpGet]
    private async Task<bool> HasViewPermission(int menuId)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        return await (
            from up in _context.TblUserPermission
            join pa in _context.TblPermissionAction
                on up.ActionId equals pa.ActionId
            where up.UserId == userId
                  && up.MenuId == menuId
                  && up.IsAllowed
                  && pa.ActionName == "View"
            select up
        ).AnyAsync();
    }



    [HttpGet]
    public async Task<IActionResult> YarnAllocationReport(int menuId,string reportName = "rptYarnAllocation")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";

            var reportType = Type.GetType(rptPath);

            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }

            var report = (XtraReport)Activator.CreateInstance(reportType);

            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> DyeingProductionReport(int menuId, string reportName = "rptDyeingProduction")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> DyeingKpiReport(int menuId, string reportName = "rptDyeingKPI")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> DyeingProductionWcReport(int menuId, string reportName = "rptDyeing_Production_WC")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> DyeingCostDetailsReport(int menuId, string reportName = "rptDyeingCost")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> DyeingFinishingBillReport(int menuId, string reportName = "rptDyeingBill")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> DyeingVsShortNoteReport(int menuId, string reportName = "rpt_Dyeing_vs_ShortNote")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> FinishFabricReport(int menuId, string reportName = "rptFinishFabStock")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> BatchFollowUpReport(int menuId, string reportName = "rptBatchFollowUp")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> ShortNoteAnalysisReport(int menuId, string reportName = "rptShortNote_Tools")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> FinishFabricClosingStockReport(int menuId, string reportName = "rptFinish_Fabric_Closing_Stock")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> LeftOverPackingListReport(int menuId, string reportName = "rptLeftOverPackingList")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> TrimsBatchDetailsReport(int menuId, string reportName = "rptTrimsBatchReport")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> RejectFabricPackingListReport(int menuId, string reportName = "rptRejectFabricPackingList")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> DateWiseShortNoteAnalysisReport(int menuId, string reportName = "rptShortNoteAnalysis1")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> ImportFabricClosingStockReport(int menuId, string reportName = "rptImportFabricClosingStock")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> WoFollowUpReport(int menuId, string reportName = "rptWorkOrderFOllowup_Tex")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> GreyTransferFollowUpReport(int menuId, string reportName = "rptGreyTransferFollowUp")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> DailyShipmentStatusReport(int menuId, string reportName = "rptShipment")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> LotWiseYarnAgingReport(int menuId, string reportName = "rptYarnAging")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> SewingInputOutputReport(int menuId, string reportName = "rptSewingWIP")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> DailySewingInputOutputPieceRateReport(int menuId, string reportName = "rptDailySewingProduction")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> LineWiseSewingInputOutputReport(int menuId, string reportName = "rptLineWiseWIP")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> SewingDhuReport(int menuId, string reportName = "rptFinalDHU")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> GatePassOutReport(int menuId, string reportName = "rptGatePass_Out")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> FinishFabricStockSampleReport(int menuId, string reportName = "rptFinishFabricStock_Sample")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> GarmentsIssueFromPrintReport(int menuId, string reportName = "rptPrintReceiveChallan")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> OrderWiseClosingReport(int menuId, string reportName = "rpt_Order_Wise_Closing")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> DailyYarnReceiveStatusReport(int menuId, string reportName = "rptDailyYarnReceive")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> ProgramClosingReport(int menuId, string reportName = "rptProgram_Closing")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> TopTenGeneralItemIssueReport(int menuId, string reportName = "rpt_Top_Ten_General_Item_Issue")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> GeneralItemIssueDetailsReport(int menuId, string reportName = "rptGeneral_Item_Issue")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> DNCPerformanceAnalysisReport(int menuId, string reportName = "rptDNC_Performance")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> CostAnalysisReport(int menuId, string reportName = "rptJobWiseCostAnalysis")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> DateWiseCostAnalysisSummaryReport(int menuId, string reportName = "rptDateWiseCostAnalysis")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> DateWiseKnittingProductionReport(int menuId, string reportName = "rptDateWiseKnittingProduction")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> DateWiseYarnTransactionReport(int menuId, string reportName = "rptDateWiseYarnTransaction")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> CutToShipReport(int menuId, string reportName = "rptCut_To_Ship")
    {
        if (!await HasViewPermission(menuId))
        {
            return Forbid();
        }

        try
        {
            var rptPath = $"ReportHub_V2.Reports.{reportName}";
            var reportType = Type.GetType(rptPath);
            if (reportType == null)
            {
                return NotFound($"Report '{reportName}' not found.");
            }
            var report = (XtraReport)Activator.CreateInstance(reportType);
            return View(report);
        }
        catch (Exception ex)
        {
            return Content(ex.InnerException?.Message ?? ex.Message);
        }
    }
}