using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1_Q2.Models.Repository
{
    public interface IMovieRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int Id);
        void Create(T movie);
        void Update(T movie);
        void Delete(int Id);
        void Save();
    }
}
