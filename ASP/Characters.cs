//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    
    public partial class Characters
    {
        public Characters()
        {
            this.Bag = new HashSet<Bag>();
        }
    
        public int char_id { get; set; }
        public int acc_id { get; set; }
        public string char_n { get; set; }
        public int race_id { get; set; }
        public int prof_id { get; set; }
        public int gend_id { get; set; }
        public int stat_id { get; set; }
    
        public virtual Accounts Accounts { get; set; }
        public virtual ICollection<Bag> Bag { get; set; }
        public virtual Genders Genders { get; set; }
        public virtual Profs Profs { get; set; }
        public virtual Races Races { get; set; }
        public virtual Stats Stats { get; set; }
    }
}
