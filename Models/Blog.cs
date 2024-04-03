using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloggingWebApp.Models
{
    public class Blog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Title {  get; set; }

        public string Content { get; set; }

        public string Author {  get; set; }

        public string CateId { get; set; }

        public Category Category { get; set; }
    }
}
