using System.Collections.Generic;
using System.Threading.Tasks;
using ClientProvisioningTool.API.Models;

namespace ClientProvisioningTool.API.Data
{
    public interface IValuesRepository
    {
         Task<Value> GetValue(int id);

         Task<IEnumerable<Value>> GetValues();
         
    }
}