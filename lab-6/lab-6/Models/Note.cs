//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab_6.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Note
    {
        public int noteId { get; set; }
        public string subj { get; set; }
        public int note1 { get; set; }
        public int studentId { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
