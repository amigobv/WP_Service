namespace WP.Service.Models
{
    public class User : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Milestone[] Tasks { get; set; }
    }
}