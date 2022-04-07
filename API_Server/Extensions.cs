using API_Server.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public static class Extensions
{
    public static bool SaveChangesEx(this AppDbContext context)
    {
        try
        {
            context.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }
}