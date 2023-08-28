using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CST_350_Milestone.Models
{
    public class RegisterModel
    {
       
        [Required]
        [DisplayName("First Name")]
        [StringLength(20, MinimumLength = 4)]
        public string Firstname { get; set; }

        [Required]
        [DisplayName("Last Name")]
        [StringLength(20, MinimumLength = 4)]
        public string Lastname { get; set; }

        [Required]
        [DisplayName("Sex")]
        [StringLength(7, MinimumLength = 4)]
        public string Sex { get; set; }

        [Required]
        [DisplayName("Age")]
        [StringLength(3, MinimumLength = 1)]
        public int Age { get; set; }

        [Required]
        [DisplayName("State")]
        [StringLength(2, MinimumLength = 2)]
        public string State { get; set; }

        [Required]
        [DisplayName("Street")]
        public string Street { get; set; }

        [Required]
        [DisplayName("City")]
        public string City { get; set; }

        [Required]
        [DisplayName("ZIP Code")]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid ZIP code format.")]
        public int ZIPCode { get; set; }

        [Required]
        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Username")]
        [StringLength(20, MinimumLength = 4)]
        public string Username { get; set; }

        [Required]
        [DisplayName("Password")]
        [StringLength(20, MinimumLength = 4)]
        public string Password { get; set; }


        public RegisterModel(string firstName, string lastName, string sex, int age, string state, string street, string city, int zipCode, string email, string username, string password)
        {
            this.Firstname = firstName;
            this.Lastname = lastName;
            Sex = sex;
            Age = age;
            State = state;
            Street = street;
            Street = street;
            City = city;
            ZIPCode = zipCode;
            Email = email;
            Username = username;
            Password = password;
        }

        public RegisterModel()
        {

        }

    }
}
