using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Organigram.api.Models
{
    public class OrgObject
    {
        //  Header section
        public int Id { get; set; }
        [Required]
        public User CreatedBy { get; set; }
        [Required]
        public User ChangedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ChangedAt { get; set; }


        // Data section
        [Required]
        public string Title { get; set; }
        public Object Parent { get; set; }
        public int? ParentId { get; set; }
        public ICollection<OrgObject> Children { get; set; }
        [Required]
        public int Type { get; set; }
        public string Purpose { get; set; }
        public string Domains { get; set; }
        public string Accountabilities { get; set; }
        public string Assignee { get; set; }
        
    }
}