using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMS.Forms.Abstraction
{
    public interface IEntityService<T>
    {
        public void Add(T entity);
        public void Remove(T entity);
        public List<T> Get();
        public void UpDate(T entity);    
        
    }
}
