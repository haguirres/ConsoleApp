//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School.Entities.EF6
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inscription
    {
        public int StudentId { get; set; }
        public string SchoolId { get; set; }
        public System.DateTime InscriptionDate { get; set; }
    
        public virtual School School { get; set; }
        public virtual Student Student { get; set; }
    }
}
