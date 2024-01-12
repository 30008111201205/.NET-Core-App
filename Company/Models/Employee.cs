using Company;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Phone { get; set; }
        [Required]
        public string? Address { get; set; }

        public string? Description { get; set; }
        
        [NotMapped]
        public IFormFile ?FormFile { get; set; }
        public byte[]? ImageBytes { get; set; }
        
        [NotMapped]
        public string? Image
        {
            get
            {
                if (ImageBytes != null)
                {
                    string base64String = Convert.ToBase64String(ImageBytes, 0, ImageBytes.Length);
                    return "data:image/jpg;base64," + base64String;
                }
                else { return string.Empty; }
            }
        }


        [ForeignKey("Department")]
        [DisplayName("Department Name")]
        [DefaultValue(1)]
        public int Dept_id {  get; set; }
        
        public virtual Department ?Department { get; set;}
        
    }
}
