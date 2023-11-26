using MaterialExchangeAPI.Data.Repositories;
using MaterialExchangeAPI.Models;

namespace MaterialExchangeAPI.Jobs
{
    public class UpdateMaterialPriceJob
    {
        private readonly IMaterialRepository _repository;

        public UpdateMaterialPriceJob(IMaterialRepository repository)
        {
            _repository = repository;
        }

        public void Execute()
        {
            List<Material> materials = _repository.Get();

            Random random = new Random();
            foreach (Material material in materials)
            {
                // Cap lower bound if price is less than 100
                decimal lower_bound = Math.Max(-material.Price + 1, -100);
                decimal range = 100 - lower_bound;

                decimal diff = lower_bound + new decimal(random.NextDouble()) * range;
                material.Price += diff;

                _repository.Update(material);
            }

            _repository.Save();
        }
    }
}
