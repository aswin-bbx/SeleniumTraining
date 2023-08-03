using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Client.Model
{
    public class EarningModel
    {
        [Required]
        public String Name { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public String Address { get; set; }
        [Required]
        public String PhoneNumber { get; set; }
    }
}
