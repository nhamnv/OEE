using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    [Table("Data_Menu")]
    public class Data_Menu
    {
        [Key]
        public int MenuID {  get; set; }

        [Required]
        public string? Name { get; set; }
        public int? ParentID { get; set; }
        public int? OrderNo { get; set; }
        public bool? IsShowMenu { get; set; }
        public string? Url { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }



        // Addination
        public Data_Menu? ParentMenu { get; set; }

        public ICollection<Data_Menu> ChildMenus { get; set; } = new List<Data_Menu>();
    }
}
