using System.Collections.Generic;

namespace CarWashManagement.Core.Database.SqlHandlers
{
    public interface ISqlHandler<T>
    {
        List<T> Load();
        void Save(List<T> items);
    }
}

