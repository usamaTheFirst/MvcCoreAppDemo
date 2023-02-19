using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCoreApp.Models
{

    public enum ApprovalStatus
    {
        New , Pending, Review, Rejected, Approved
    }
    public enum SubmissionStatus
    {
        Draft, Submitted
    }

    [Table("ChangeRequests")]
    public class ChangeRequest
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Category { get; set; }
        [Required]
        public String WhatIsTheChange { get; set; }
        [Required]

        public String SubCategory { get; set; }
        [Required]
        public String Priority { get; set; }
        [Required]

        public String  Location { get; set; }
        [Required]
        public DateTime ExpectedChange { get; set; }
        [Required]
        public String TeamDependency { get; set; }

        public String Justification { get; set; }
        public String Impact { get; set; }
        public String RollBackStrategy { get; set; }
        [NotMapped]
        
        public IFormFile[]? Attachments { get; set; }
        public ApprovalStatus Status { get; set; } = ApprovalStatus.New;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public SubmissionStatus SubmissionStatus { get; set; }


    }
}
