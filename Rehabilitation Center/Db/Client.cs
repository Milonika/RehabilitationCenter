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
    
    public partial class Client
    {
        public Client()
        {
            this.Auth = new HashSet<Auth>();
            this.health = new HashSet<health>();
            this.HistoryClient = new HashSet<HistoryClient>();
            this.Therapy = new HashSet<Therapy>();
        }
    
        public int IDClient { get; set; }
        public string FName { get; set; }
        public string Name { get; set; }
        public string LName { get; set; }
        public string Pasport { get; set; }
        public string Polis { get; set; }
        public string SNILS { get; set; }
        public string Phone { get; set; }
        public byte[] Photo { get; set; }
        public int Age { get; set; }
        public Nullable<int> IDAuth { get; set; }
    
        public virtual ICollection<Auth> Auth { get; set; }
        public virtual Photo Photo1 { get; set; }
        public virtual ICollection<health> health { get; set; }
        public virtual ICollection<HistoryClient> HistoryClient { get; set; }
        public virtual ICollection<Therapy> Therapy { get; set; }
        public virtual Auth Auth1 { get; set; }
    }
}