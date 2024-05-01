using System.ComponentModel.DataAnnotations;

namespace MrjSite.Model
{
    public class MessageViewModel
    {
        [Required(ErrorMessage ="Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Text { get; set; }
    }
}
