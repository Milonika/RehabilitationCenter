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
    
    public partial class HistoryClient
    {
        public int IDClient { get; set; }
        public int IDEvent { get; set; }
        public System.DateTime DateStart { get; set; }
        public System.DateTime DateEnd { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Events Events { get; set; }
    }
}