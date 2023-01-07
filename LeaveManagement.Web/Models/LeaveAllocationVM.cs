using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace LeaveManagement.Web.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }



        [Display(Name = "Number Of Days")]
        [Required]
        [Range(0, 50, ErrorMessage = "Please enter a valid NumberOfDays")]
        public int NumberOfDays { get; set; }


        [Required]
        [Display(Name = "Allocation Period")]
        public int Period { get; set; }



        public LeaveTypeVM LeaveType { get; set; }
    }
}
