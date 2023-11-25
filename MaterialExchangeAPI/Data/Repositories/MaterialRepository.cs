using MaterialExchangeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MaterialExchangeAPI.Data.Repositories
{
    public interface IMaterialRepository : IRepository<Material> { }

    public class MaterialRepository : IMaterialRepository
    {
        private readonly DataContext _context;

        public MaterialRepository(DataContext context)
        {
            _context = context;
        }

        public List<Material> Get()
        {
            return _context.Materials.ToList();
        }

        public Task<List<Material>> GetAsync()
        {
            return _context.Materials.ToListAsync();
        }

        public Material? GetById(int id)
        {
            return _context.Materials.FirstOrDefault(material => material.Id == id);
        }

        public Task<Material?> GetByIdAsync(int id)
        {
            return _context.Materials.FirstOrDefaultAsync(material => material.Id == id);
        }

        public void Insert(Material material)
        {
            _context.Materials.Add(material);
        }

        public void Update(Material material)
        {
            _context.Materials.Update(material);
        }

        public void Delete(int id)
        {
            Material? material = _context.Materials.Find(id);

            if (material != null)
            {
                _context.Materials.Remove(material);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public bool Exists(int id)
        {
            return _context.Materials.Any(material => material.Id == id);
        }
    }
}
