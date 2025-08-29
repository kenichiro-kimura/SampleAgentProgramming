namespace SampleAgentProgramming.Models;

public class FamilyMember
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Relationship { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    
    public string MaskedEmail
    {
        get
        {
            if (string.IsNullOrEmpty(Email) || !Email.Contains('@'))
                return Email;
            
            var parts = Email.Split('@');
            var localPart = parts[0];
            var domain = parts[1];
            
            if (localPart.Length <= 2)
                return $"{localPart[0]}***@{domain}";
            
            return $"{localPart[0]}***{localPart[^1]}@{domain}";
        }
    }
}