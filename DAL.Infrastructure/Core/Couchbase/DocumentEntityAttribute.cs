using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Infrastructure.Core.Couchbase
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DocumentEntityAttribute : Attribute
    {
    }
}
