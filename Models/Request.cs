//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Autocentre.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        public int RequestId { get; set; }
        public int ClientId { get; set; }
        public int CarId { get; set; }
        public Nullable<int> Total_Cost { get; set; }
        public string Notes { get; set; }
    
        public virtual Car Car { get; set; }
        public virtual Client Client { get; set; }
    }
}
