//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shop_Project_API.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class good_price
    {
        public int id_good_price { get; set; }
        public int article_number { get; set; }
        public decimal price { get; set; }
        public System.DateTime change_date { get; set; }

        [JsonIgnore]
        public virtual good good { get; set; }
    }
}