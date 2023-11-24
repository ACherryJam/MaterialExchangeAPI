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

        public Task<List<Seller>> Get()
        {
            return _context.Sellers.ToListAsync();
        }

        public Task<Seller?> GetById(int id)
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

        public async void Save()
        {
            await _context.SaveChangesAsync();
        }

        public bool Exists(int id)
        {
            return _context.Sellers.Any(seller => seller.Id == id);
        }
    }
}
