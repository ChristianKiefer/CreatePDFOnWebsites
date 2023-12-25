namespace CreatePDFOnWeb.Models
{
    public class Member
    {
        public string Firstname { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public int PLZ { get; set; } 
        public string City { get; set; } = string.Empty;    
    }
}
