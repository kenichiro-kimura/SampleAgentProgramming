using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SampleAgentProgramming.Models;

namespace SampleAgentProgramming.Pages;

public class AdminDetailModel : PageModel
{
    public Administrator? Administrator { get; set; }

    public IActionResult OnGet(int id)
    {
        // Mock data - same as Admin page
        var administrators = new List<Administrator>
        {
            new Administrator
            {
                Id = 1,
                Name = "田中 太郎",
                Email = "tanaka.taro@example.com",
                Position = "システム管理者",
                Department = "情報システム部"
            },
            new Administrator
            {
                Id = 2,
                Name = "佐藤 花子",
                Email = "sato.hanako@example.com",
                Position = "セキュリティ管理者",
                Department = "情報セキュリティ部"
            },
            new Administrator
            {
                Id = 3,
                Name = "鈴木 次郎",
                Email = "suzuki.jiro@example.com",
                Position = "データベース管理者",
                Department = "データ管理部"
            }
        };

        Administrator = administrators.FirstOrDefault(a => a.Id == id);
        
        if (Administrator == null)
        {
            return NotFound();
        }

        return Page();
    }
}