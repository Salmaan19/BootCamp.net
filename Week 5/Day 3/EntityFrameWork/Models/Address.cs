using System.ComponentModel.DataAnnotations;

namespace EntityFrameWork.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string city { get; set; }

        public string country { get; set; }

        public string state { get; set; }



    }
}
