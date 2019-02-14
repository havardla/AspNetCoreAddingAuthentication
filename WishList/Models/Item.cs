using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WishList.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Description { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
