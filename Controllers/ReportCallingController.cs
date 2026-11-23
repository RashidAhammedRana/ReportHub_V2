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
}