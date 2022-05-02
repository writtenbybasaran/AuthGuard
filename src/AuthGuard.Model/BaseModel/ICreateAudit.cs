using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthGuard.Model.BaseModel
{
    public interface ICreateAudit
    {
        DateTime CreatedDate { get { return DateTime.Now; } set { } }
    }
}
