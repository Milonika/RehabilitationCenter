//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rehabilitation_Center.Db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Therapy
    {
        public Therapy()
        {
            this.Client = new HashSet<Client>();
        }
    
        public int IDTherapy { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    
        public virtual ICollection<Client> Client { get; set; }
    }
}
