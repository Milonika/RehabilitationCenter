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
    
    public partial class health
    {
        public health()
        {
            this.Dependece = new HashSet<Dependece>();
        }
    
        public int IDHealth { get; set; }
        public Nullable<int> Height { get; set; }
        public Nullable<int> Weight { get; set; }
        public string Pressure { get; set; }
        public string Saturation { get; set; }
        public string BloodType { get; set; }
        public int IDClient { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual ICollection<Dependece> Dependece { get; set; }
    }
}
