using Organigram.api.Models;

namespace Organigram.api.Dtos
{
    public class ObjectForDetailDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Type { get; set; }
        public Object Parent { get; set; }
        public string Purpose { get; set; }
        public string Domains { get; set; }
        public string Accountabilities { get; set; }
        public string Assignee { get; set; }
    }
}