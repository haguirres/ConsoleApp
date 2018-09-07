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
    
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            this.Grade = new HashSet<Grade>();
        }
    
        public string CourseId { get; set; }
        public int SignaturesId { get; set; }
        public string SchoolId { get; set; }
        public int TeacherId { get; set; }
        public Nullable<int> MinToPass { get; set; }
        public int Year { get; set; }
        public Nullable<int> Credits { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public int ScheduleId { get; set; }
    
        public virtual Schedule Schedule { get; set; }
        public virtual School School { get; set; }
        public virtual Signatures Signatures { get; set; }
        public virtual Teacher Teacher { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grade> Grade { get; set; }
    }
}
