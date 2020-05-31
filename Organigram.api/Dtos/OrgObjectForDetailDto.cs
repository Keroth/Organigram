using Organigram.api.Models;

namespace Organigram.api.Dtos
{
    public class OrgObjectForDetailDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Type { get; set; }
        public OrgObject Parent { get; set; }
        public string Purpose { get; set; }
        public string Domains { get; set; }
        public string Accountabilities { get; set; }
        public string Assignee { get; set; }
    }
}