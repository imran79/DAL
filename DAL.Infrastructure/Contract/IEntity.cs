using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Infrastructure
{
    public interface IEntity
    {
        int Id { get; set; }
        bool IsArchived { get; set; }
        bool IsDeleted { get; set; }
    }
}
