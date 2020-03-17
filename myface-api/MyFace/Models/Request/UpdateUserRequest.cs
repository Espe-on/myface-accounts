using System.ComponentModel.DataAnnotations;

namespace MyFace.Models.Request
{
    public class UpdateUserRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string ProfileImageUrl { get; set; }
        public string CoverImageUrl { get; set; }
        [Required(ErrorMessage = "Password does not match rules")]
        [MinLength(12)]
        [StringLength(64)]
        public string RawPassword { get; set; }
    }
}