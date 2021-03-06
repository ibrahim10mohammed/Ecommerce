using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetPRoductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetPRoductsAsync();
    }
}
