//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace system_oceny.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tranzakcjas
    {
        public int TranzakcjaId { get; set; }
        public int Id { get; set; }
        public string login { get; set; }
        public System.DateTime data { get; set; }
    
        public virtual Firmas Firmas { get; set; }
        public virtual Uzytkowniks Uzytkowniks { get; set; }
    }
}