using System;

namespace TeduShop.Model.Models
{
    public interface IAuditable
    {
        DateTime? CreateDate { set; get; }
        string CreateBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdatedBy { set; get; }
        string MetaKeyWord { set; get; }
        string MetaDescription { set; get; }
        bool Status { set; get; }
    }
}