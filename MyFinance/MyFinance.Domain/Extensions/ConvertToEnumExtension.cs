using MyFinance.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFinance.Domain.Extensions
{
    public static class ConvertToEnumExtension
    {

        public static string ConvertToEnum(int typeAccount) 
        {
            
            string stringValue = Enum.GetName(typeof(AccountTypeEnum), typeAccount);
            return stringValue;
        }
    }
}
