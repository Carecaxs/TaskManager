using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace TaskManager.Models

{
    [Table("USERS")]
    public class USERS
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Passwordd { get; set; }
        public string Email { get; set; }
    
    }
}
