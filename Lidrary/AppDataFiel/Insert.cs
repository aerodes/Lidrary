//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lidrary.AppDataFiel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Insert
    {
        public int id_insert { get; set; }
        public int id_reader { get; set; }
        public int id_book { get; set; }
        public System.DateTime date_of_issue { get; set; }
        public System.DateTime return_date { get; set; }
        public Nullable<System.DateTime> actual_date { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Reader Reader { get; set; }
    }
}
