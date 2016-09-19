using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //tu dong tang
        public int ID { set; get; }

        [Required]
        [MaxLength(256) ]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerAddress { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerEmail { set; get; }

        [Required]
        [MaxLength(50)]
        public string CustomerMobile { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerMessage { set; get; }

        [MaxLength(256)]
        public string PaymentMethod { set; get; }

        [Required]
        public DateTime CreateDate { set; get; }
        public string CreateBy { set; get; }
        public string PaymentStatus { set; get; }
        public bool status { set; get; }

        public virtual IEquatable<OrderDetail> OrderDetails { set; get; }


    }
}