using System;

namespace Organigram.api.Models
{
    public class Object
    {
        //  Header section
        public int Id { get; set; }
        public User CreatedBy { get; set; }
        public User ChangedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ChangedAt { get; set; }


        // Data section
        public string Title { get; set; }
        public Object Parent { get; set; }
        public int ParentId { get; set; }
        public int Type { get; set; }
        public string Purpose { get; set; }
        public string Domains { get; set; }
        public string Accountabilities { get; set; }
        public string Assignee { get; set; }
        
    }
}