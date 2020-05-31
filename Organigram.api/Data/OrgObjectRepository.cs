using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Organigram.api.Dtos;
using Organigram.api.Models;

namespace Organigram.api.Data
{
    public class OrgObjectRepository : IOrgObjectRepository
    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public OrgObjectRepository(DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
        }
        public OrgObject Create(OrgObject item)
        {
            User user = _context.Users.FirstOrDefault(e => e.Id == 1);
            item.CreatedAt = DateTime.Now;
            item.CreatedBy = user;
            item.ChangedAt = DateTime.Now;
            item.ChangedBy = user;
            _context.Objects.Add(item);
            _context.SaveChanges();
            return item;
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

        public OrgObject Update(OrgObjectForDetailDto item)
        {
            User user = _context.Users.FirstOrDefault(e => e.Id == 1); //_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

            OrgObject itemOld = _context.Objects.FirstOrDefault(e => e.Id == item.Id);
            itemOld.Title = item.Title;
            itemOld.Type = item.Type;
            itemOld.Purpose = item.Purpose;
            itemOld.Domains = item.Domains;
            itemOld.Accountabilities = item.Accountabilities;
            itemOld.Assignee = item.Assignee;
            itemOld.ChangedAt = DateTime.Now;
            itemOld.ChangedBy = user;
            _context.Objects.Update(itemOld);
            _context.SaveChanges();
            return itemOld;
        }
    }
}