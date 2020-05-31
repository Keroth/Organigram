
using System.Collections.Generic;
using System.Threading.Tasks;
using Organigram.api.Models;


namespace Organigram.api.Data
{
    public interface IOrgObjectRepository
    {
         Task<IEnumerable<OrgObject>> GetFullList();
         Task<IEnumerable<OrgObject>> GetListFrom(int id);
         Task<OrgObject> GetDetail(int id);
         Task<OrgObject> Create(OrgObject item);
         Task<OrgObject> Update(OrgObject item);
    }
}