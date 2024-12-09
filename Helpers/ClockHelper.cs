using Microsoft.EntityFrameworkCore;
using POS_Generic.Helpers;
using SalesPro.Models.ModelHelpers;
using System;
using System.Threading.Tasks;

namespace SalesPro.Helpers
{

    public class ClockHelper : DbContext
    {
        /// <summary>
        /// Gets the server date and time
        /// 
        public static async Task<DateTime> GetServerDateTime()
        {
            using (var context = new DatabaseContext())
            {
                try
                {
                    var result = await context.Set<ServerDateTimeModel>()
                                .FromSqlRaw("SELECT NOW() AS CurrentDateTime")
                                .FirstOrDefaultAsync();

                    if (result != null)
                    {
                        DateTime serverDateTime = result.CurrentDateTime;
                        // Use serverDateTime as needed
                        return serverDateTime;
                    }
                    else
                    {
                        throw new InvalidOperationException("Query did not return a valid result for server date and time.");
                    }
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Failed to retrieve server date and time. Check the database connection and query.", ex);
                }
            }
        }

    }

   
}
