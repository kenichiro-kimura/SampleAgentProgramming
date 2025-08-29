namespace SampleAgentProgramming.Models
{
    public class Administrator
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;

        public string MaskedEmail
        {
            get
            {
                if (string.IsNullOrEmpty(Email))
                    return string.Empty;

                var parts = Email.Split('@');
                if (parts.Length != 2)
                    return Email;

                var localPart = parts[0];
                var domain = parts[1];

                if (localPart.Length <= 2)
                    return $"{localPart[0]}***@{domain}";

                return $"{localPart[0]}***{localPart[^1]}@{domain}";
            }
        }
    }
}