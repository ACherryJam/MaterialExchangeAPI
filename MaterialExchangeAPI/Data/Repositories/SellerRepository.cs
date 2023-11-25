using MaterialExchangeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MaterialExchangeAPI.Data.Repositories
{
    public interface ISellerRepository : IRepository<Seller> { }

    public class SellerRepository : ISellerRepository
    {
        private readonly DataContext _context;

        public SellerRepository(DataContext context)
        {
            _context = context;
        }

        public List<Seller> Get()
        {
            return _context.Sellers.ToList();
        }

        public Task<List<Seller>> GetAsync()
        {
            return _context.Sellers.ToListAsync();
        }

        public Seller? GetById(int id)
        {
            return _context.Sellers.FirstOrDefault(seller => seller.Id == id);
        }

        public Task<Seller?> GetByIdAsync(int id)
        {
            return _context.Sellers.FirstOrDefaultAsync(seller => seller.Id == id);
        }

        public void Insert(Seller seller)
        {
            _context.Sellers.Add(seller);
        }

        public void Update(Seller seller)
        {
            _context.Sellers.Update(seller);
        }

        public void Delete(int id)
        {
            Seller? seller = _context.Sellers.Find(id);

            if (seller != null)
            {
                _context.Sellers.Remove(seller);
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
            return _context.Sellers.Any(seller => seller.Id == id);
        }
    }
}
