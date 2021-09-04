using PlatformService.Models;
using System.Collections.Generic;

namespace PlatformService.Data
{
    public class PlaformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;

        public PlaformRepo( AppDbContext context)
        {
            _context = context;
        }
        public void CreatePlatform(Platform platform)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            throw new System.NotImplementedException();
        }

        public Platform GetPlatformById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}