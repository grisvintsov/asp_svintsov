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
    
    public partial class Genders
    {
        public Genders()
        {
            this.Characters = new HashSet<Characters>();
        }
    
        public int gend_id { get; set; }
        public string gend_n { get; set; }
    
        public virtual ICollection<Characters> Characters { get; set; }
    }
}
