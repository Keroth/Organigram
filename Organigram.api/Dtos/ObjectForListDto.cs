using Organigram.api.Models;

namespace Organigram.api.Dtos
{
    public class ObjectForListDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Type { get; set; }
        public Object Parent { get; set; }

    }
}