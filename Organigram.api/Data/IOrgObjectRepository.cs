
using System.Collections.Generic;
using System.Threading.Tasks;
using Organigram.api.Dtos;
using Organigram.api.Models;


namespace Organigram.api.Data
{
    public interface IOrgObjectRepository
    {
         Task<IEnumerable<OrgObject>> GetFullList();
         Task<IEnumerable<OrgObject>> GetListFrom(int id);
         Task<OrgObject> GetDetail(int id);
         OrgObject Create(OrgObject item);
         OrgObject Update(OrgObjectForDetailDto item);
         Task<OrgObject> Delete(int id);
    }
}