﻿using Newtonsoft.Json;

namespace Simply.Property.SqlServer
{
    internal interface IQueryBuilder<T>
    {
        string GetTable();
        JsonSerializerSettings JsonSettingsForInsert();
        JsonSerializerSettings JsonSettingsForUpdate();
        JsonSerializerSettings JsonSettingsForUpdate(string[] properties);
        JsonSerializerSettings JsonSettingsForDelete();
        JsonSerializerSettings JsonSettingsForDelete(string[] properties);
        string BuildCreateTable();
        string BuildTruncateTable();
        string BuildDropTable();
        string BuildCreateNonClusteredIndexs();
        string BuildInsert();
        string BuildUpdate();
        string BuildUpdate(string[] update);
        string BuildDelete();
        string BuildDelete(string[] delete);

        //string BuildInsert(T value);
        //string BuildUpdate(T value);
        //string BuildUpdate(T value, string[] update);
        //string BuildDelete(T value);
        //string BuildDelete(T value, string[] where);
    }
}
