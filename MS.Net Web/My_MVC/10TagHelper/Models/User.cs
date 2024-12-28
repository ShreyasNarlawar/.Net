namespace _10TagHelper.Models
{
    public enum Gender
    {
        Male,
        Female
    }
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender {  get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public long PhNo { get; set; }
        public string IsMarried { get; set; }
        public string Enquiry {  get; set; }
    }
}
