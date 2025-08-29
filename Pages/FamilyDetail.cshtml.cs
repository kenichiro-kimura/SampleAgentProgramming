using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SampleAgentProgramming.Models;

namespace SampleAgentProgramming.Pages;

public class FamilyDetailModel : PageModel
{
    private readonly ILogger<FamilyDetailModel> _logger;

    public FamilyDetailModel(ILogger<FamilyDetailModel> logger)
    {
        _logger = logger;
    }

    public FamilyMember? FamilyMember { get; set; }

    public IActionResult OnGet(int id)
    {
        // サンプルデータ - 実際のアプリケーションではデータベースから取得
        var familyMembers = new List<FamilyMember>
        {
            new FamilyMember
            {
                Id = 1,
                Name = "田中 太郎",
                Relationship = "父",
                Email = "tarou.tanaka@example.com"
            },
            new FamilyMember
            {
                Id = 2,
                Name = "田中 花子",
                Relationship = "母",
                Email = "hanako.tanaka@example.com"
            },
            new FamilyMember
            {
                Id = 3,
                Name = "田中 次郎",
                Relationship = "息子",
                Email = "jirou.tanaka@example.com"
            }
        };

        FamilyMember = familyMembers.FirstOrDefault(m => m.Id == id);

        if (FamilyMember == null)
        {
            return NotFound();
        }

        return Page();
    }
}