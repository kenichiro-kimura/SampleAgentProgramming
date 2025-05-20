namespace SampleAgentProgramming.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string MaskedEmail => Email != null && Email.Contains("@") ? Email.Substring(0, 2) + "***" + Email.Substring(Email.IndexOf("@")) : Email;
    }
}
