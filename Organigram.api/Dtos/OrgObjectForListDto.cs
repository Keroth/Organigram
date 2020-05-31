using System.Collections.Generic;
using Organigram.api.Models;

namespace Organigram.api.Dtos
{
    public class OrgObjectForListDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Type { get; set; }
        public OrgObject Parent { get; set; }
        public ICollection<OrgObject> Children { get; set; }


    }
}