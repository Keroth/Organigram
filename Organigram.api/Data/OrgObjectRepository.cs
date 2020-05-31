using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Organigram.api.Models;

namespace Organigram.api.Data
{
    public class OrgObjectRepository : IOrgObjectRepository
    {
        private readonly DataContext _context;
        public OrgObjectRepository(DataContext context)
        {
            _context = context;
        }
        public Task<OrgObject> Create(OrgObject item)
        {
            item.CreatedAt = DateTime.Now;
        }

        public async Task<OrgObject> GetDetail(int id)
        {
            var item = await _context.Objects.Include(e => e.Children).FirstOrDefaultAsync(e => e.Id == id);
            return item;
        }

        public async Task<IEnumerable<OrgObject>> GetFullList()
        {
            var list = await _context.Objects.Include(e => e.Children).ToListAsync();
            return list.Where(e => e.ParentId == null);
        }

        public async Task<IEnumerable<OrgObject>> GetListFrom(int id)
        {
            var list = await _context.Objects.Include(e => e.Children).ToListAsync();
            return list.Where(e => e.Id == id);
        }

        public Task<OrgObject> Update(OrgObject item)
        {
            throw new System.NotImplementedException();
        }
    }
}