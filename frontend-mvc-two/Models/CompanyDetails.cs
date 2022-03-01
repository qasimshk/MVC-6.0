namespace frontend_mvc_two.Models
{
    public class CompanyDetails
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string PartialViewName => "_CompanyDetails";
    }
}
