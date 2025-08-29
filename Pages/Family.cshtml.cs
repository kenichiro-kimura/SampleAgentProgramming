using Microsoft.AspNetCore.Mvc.RazorPages;
using SampleAgentProgramming.Models;

namespace SampleAgentProgramming.Pages;

public class FamilyModel : PageModel
{
    private readonly ILogger<FamilyModel> _logger;

    public FamilyModel(ILogger<FamilyModel> logger)
    {
        _logger = logger;
    }

    public List<FamilyMember> FamilyMembers { get; set; } = new();

    public void OnGet()
    {
        FamilyMembers = new List<FamilyMember>
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
    }
}