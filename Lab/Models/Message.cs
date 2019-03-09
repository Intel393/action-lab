using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab.Models
{

    public class CreateMessageDto
    {
        [Required]
        public string Content { get; set; }
    }
    
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MessageId { get; set; }
        
        [Timestamp]
        public DateTime CreatedAt { get; set; }
        
        [Required]
        public string Content { get; set; }
    }
}