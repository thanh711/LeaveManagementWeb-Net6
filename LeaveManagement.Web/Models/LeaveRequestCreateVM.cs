using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace LeaveManagement.Web.Models
{
    public class LeaveRequestCreateVM:IValidatableObject
    {
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required]
        [Display(Name ="Leave Type")]
        public int LeaveTypeId { get; set; }
        public SelectList LeaveTypes { get; set; }
        public string RequestComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(StartDate> EndDate)
            {
                yield return new ValidationResult("The StartDate must be before EndDate", new[] { nameof(StartDate),nameof(EndDate) });
            }
        }
    }
}
