﻿using Microsoft.Data.SqlClient;

namespace IGL.Infrastructure.Repository.SqlHelper
{
    public static class ReaderExtension
    {
        public static T DefaultIfNull<T>(this SqlDataReader reader, string entityPropName)
        {
            if (!reader.IsDBNull(reader.GetOrdinal(entityPropName)))
                return (T)reader.GetValue(reader.GetOrdinal(entityPropName));
            return default(T);
        }
    }
}
