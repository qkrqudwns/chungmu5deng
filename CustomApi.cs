using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signDrivenMenu
{
    public class CustomApi
    {
        protected String mKey = null;
        protected String mEngineId = null;

        public void setKey(String key)
        {
            mKey = key;
        }

        public void setEngineId(String engineId)
        {
            mEngineId = engineId;
        }
    }
}
