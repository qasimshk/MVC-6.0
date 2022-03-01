namespace frontend_mvc_two.Models
{
    public class PersonDetails
    {
        public string Name { get; set; } = "DEMO";
        public int Age { get; set; } = 0;
        public string PartialViewName => "_PersonDetails";
    }
}
