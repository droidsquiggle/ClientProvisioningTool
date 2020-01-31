using System.Collections.Generic;
using System.Threading.Tasks;
using ClientProvisioningTool.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientProvisioningTool.API.Data
{
    public class ValuesRepository : IValuesRepository
    {
        private readonly DataContext _context;

        public ValuesRepository(DataContext context)
        {
            this._context = context;
        }

        public async Task<Value> GetValue(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(v => v.Id == id);

            if(value == null)
                return null;
   

            return value;
        }

        public async Task<IEnumerable<Value>> GetValues()
        {
            var values = await _context.Values.ToListAsync();
            
            return values;
        }
    }
}