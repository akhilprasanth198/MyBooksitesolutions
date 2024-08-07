using System.ComponentModel.DataAnnotations.Schema;

namespace MyBooksite.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int price { get; set; }

        public string language { get; set; }

        public int publishedyear { get; set; }
        public string subject { get; set; }

        [ForeignKey("Books")]
        public int authorid { get; set; }

        public virtual Author Authorentry { get; set; }

        public int age { get; set; }
    }
}
