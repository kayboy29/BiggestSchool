using System.ComponentModel.DataAnnotations;

namespace BiggestSchool.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [required]
        [StringLength(255)]
        public string Name { get; set; }

    }
}