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
    
    public partial class Firmas
    {
        public Firmas()
        {
            this.Ocenas = new HashSet<Ocenas>();
            this.Tranzakcjas = new HashSet<Tranzakcjas>();
            this.Zdjecies = new HashSet<Zdjecies>();
        }
    
        public int Id { get; set; }
        public string Branza { get; set; }
        public string Nazwa { get; set; }
        public int NIP { get; set; }
        public string Opis { get; set; }
        public string email { get; set; }
        public string numer_telefonu { get; set; }
        public string adres { get; set; }
        public string kod_pocztowy { get; set; }
        public string miasto { get; set; }
        public float ocena { get; set; }
        public int ilosc_ocen { get; set; }
    
        public virtual ICollection<Ocenas> Ocenas { get; set; }
        public virtual ICollection<Tranzakcjas> Tranzakcjas { get; set; }
        public virtual ICollection<Zdjecies> Zdjecies { get; set; }
    }
}