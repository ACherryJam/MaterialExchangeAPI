namespace MaterialExchangeAPI.Data.Repositories
{
    public interface IRepository<Model>
    {
        List<Model> Get();

        Task<List<Model>> GetAsync();

        Model? GetById(int id);

        Task<Model?> GetByIdAsync(int id);

        void Insert(Model model);

        void Update(Model model);

        void Delete(int id);

        void Save();

        Task SaveAsync();

        bool Exists(int id);
    }
}
