namespace Organigram.api.Dtos
{
    public class OrgObjectForCreateDto
    {
        public string Title { get; set; }
        public int Type { get; set; }
        public int ParentId { get; set; }
        public string Purpose { get; set; }
        public string Domains { get; set; }
        public string Accountabilities { get; set; }
        public string Assignee { get; set; }
    }
}