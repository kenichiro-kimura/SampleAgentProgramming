using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace SampleAgentProgramming.Pages
{
    public class UserDetailModel : PageModel
    {
        public User User { get; set; }
        public void OnGet(int id)
        {
            var users = new List<User>
            {
                new User { Id = 1, Name = "山田 太郎", Company = "サンプル株式会社", Email = "taro.yamada@example.com" },
                new User { Id = 2, Name = "佐藤 花子", Company = "テスト有限会社", Email = "hanako.sato@example.com" },
                new User { Id = 3, Name = "鈴木 次郎", Company = "デモ合同会社", Email = "jiro.suzuki@example.com" }
            };
            User = users.FirstOrDefault(u => u.Id == id);
        }
    }
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
    }
}
