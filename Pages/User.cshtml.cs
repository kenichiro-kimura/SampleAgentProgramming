using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace SampleAgentProgramming.Pages
{
    public class UserModel : PageModel
    {
        public List<User> Users { get; set; }
        public void OnGet()
        {
            Users = new List<User>
            {
                new User { Id = 1, Name = "山田 太郎", Company = "サンプル株式会社", Email = "taro.yamada@example.com" },
                new User { Id = 2, Name = "佐藤 花子", Company = "テスト有限会社", Email = "hanako.sato@example.com" },
                new User { Id = 3, Name = "鈴木 次郎", Company = "デモ合同会社", Email = "jiro.suzuki@example.com" }
            };
        }
    }
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string MaskedEmail => Email != null && Email.Contains("@") ? Email.Substring(0, 2) + "***" + Email.Substring(Email.IndexOf("@")) : Email;
    }
}
