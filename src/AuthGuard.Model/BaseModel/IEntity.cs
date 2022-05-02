using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthGuard.Model.BaseModel
{
    public interface IEntity<T> where T : struct
    {
        T Id { get; set; }
    }
}
