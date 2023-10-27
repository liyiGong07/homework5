using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MvcCart.Models
{
    public class Cart
    {
        public int Id { get; set; }  //id

        [Required(ErrorMessage = "购物车id必填")]
        [Display(Name = "购物车id")]
        public int cart_id { get; set; }  //购物车id

        [Required(ErrorMessage = "商品id必填")]
        [Display(Name = "商品id")]
        public int product_id { get; set; }  //商品id

        [Display(Name = "商品名称")]
        public string? product_name { get; set; }//商品名称

        [Required(ErrorMessage = "商品数量必填")]
        [Display(Name = "商品数量")]
        public int product_num { get; set; }  //商品数量

        [Required(ErrorMessage = "商品价格必填")]
        [Display(Name = "商品价格")]
        public double product_price { get; set; }  //商品价格

        [Required(ErrorMessage = "用户id必填")]
        [Display(Name = "用户id")]
        public int user_id { get; set; } //用户id

        [Required(ErrorMessage = "创建时间必填")]
        [Display(Name = "创建时间")]
        public DateTime createtime { get; set; } //创建时间


    }
}
