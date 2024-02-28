using System.ComponentModel.DataAnnotations;

namespace AzureApiProject.Models
{
    public class EmployeeEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
       public string Email { get; set; }
        public string Phone { get; set; }   
    }
}
