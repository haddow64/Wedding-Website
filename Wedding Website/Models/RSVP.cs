//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wedding_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class RSVP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RSVP()
        {
            this.AdditionalRSVPs = new HashSet<AdditionalRSVP>();
        }
    
        public int RSVPId { get; set; }

        [Required(ErrorMessage = "You dont seem to have filled in your first name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "You dont seem to have filled in your surname")]
        public string Surname { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public Nullable<System.DateTime> CreatedDate { get; set; }

        [Required]
        public string Response { get; set; }

        [Required]
        [Display(Name = "Adult or Child")]
        public string Adult { get; set; }

        [Required]
        [Display(Name = "Starter Choice")]
        public string StarterChoice { get; set; }

        [Required]
        [Display(Name = "Dieatry Requirements")]
        public string DieatryRequirements { get; set; }

        [MaxLength(2500)]
        [Display(Name = "Details")]
        public string DietaryRequirementsDetails { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdditionalRSVP> AdditionalRSVPs { get; set; }
    }
}
