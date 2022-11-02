using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Ionescu_Alex_Daniel_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public ICollection<Author>? Authors { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
