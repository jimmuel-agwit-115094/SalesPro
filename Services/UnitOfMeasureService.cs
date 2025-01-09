using Microsoft.EntityFrameworkCore;
using POS_Generic.Helpers;
using SalesPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPro.Services
{
    public class UnitOfMeasureService
    {
        public async Task<List<UnitOfMeasuresModel>> GetAllUnitOfMeasures()
        {
            using (var context = new DatabaseContext())
            {
                return await context.UnitOfMeasures.OrderBy(x => x.UnitName).ToListAsync();
            }
        }
    }
}
