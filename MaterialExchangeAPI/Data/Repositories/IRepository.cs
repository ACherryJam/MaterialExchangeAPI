namespace MaterialExchangeAPI.Data.Repositories
{
    public interface IRepository<Model>
    {
        Task<List<Model>> Get();

        Task<Model?> GetById(int id);

        void Insert(Model model);

        void Update(Model model);

        void Delete(int id);

        Task Save();

        bool Exists(int id);
    }
}
