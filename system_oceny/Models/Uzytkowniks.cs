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
    
    public partial class Uzytkowniks
    {
        public Uzytkowniks()
        {
            this.Ocenas = new HashSet<Ocenas>();
            this.Tranzakcjas = new HashSet<Tranzakcjas>();
        }
    
        public string login { get; set; }
        public int uprawnienia { get; set; }
        public string email { get; set; }
        public string telefon { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string adres { get; set; }
        public string kod_pocztowy { get; set; }
        public string miasto { get; set; }
        public string Password { get; set; }
    
        public virtual ICollection<Ocenas> Ocenas { get; set; }
        public virtual ICollection<Tranzakcjas> Tranzakcjas { get; set; }
    }
}
