using EntityFramework.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class ModelDefinedFunctions
    {
        [ModelDefinedFunction(nameof(FormatName), "DataAccess",
            @"[Person].[FirstName] + N' ' + [Person].[LastName]")]
        public static string FormatName(this Person person) =>
            $"{person.FirstName} {person.LastName}";
    }
}
