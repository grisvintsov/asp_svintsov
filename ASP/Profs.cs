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
    
    public partial class Profs
    {
        public Profs()
        {
            this.Characters = new HashSet<Characters>();
        }
    
        public int prof_id { get; set; }
        public string prof_n { get; set; }
        public string prof_inf { get; set; }
    
        public virtual ICollection<Characters> Characters { get; set; }
    }
}
