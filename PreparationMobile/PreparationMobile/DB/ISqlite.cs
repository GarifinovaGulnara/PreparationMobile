using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationMobile.DB
{
    public interface ISqlite
    {
        string GetGatabasePath(string filename);
    }
}
