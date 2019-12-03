using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Configuration
    {
        List<ItemValue> listConfig = new List<ItemValue>();

        public void SetConfig(String item, String value)
        {
            ItemValue iv = new ItemValue();
            iv.SetValue(this, item, value);
        }

        public String GetConfig(String item)
        {
            foreach(ItemValue iv in listConfig)
            {
                if (iv.GetItem() == item)
                    return iv.GetValue();
            }
            return "";
        }
        private class ItemValue
        {
            private String item;
            private String value;

            public void SetValue(Configuration config, String item, String value)
            {
                this.item = item;
                this.value = value;

                bool found = false;
                for(int i =0; i< config.listConfig.Count; i++)
                {
                    if(config.listConfig[i].item == item)
                    {
                        config.listConfig[i] = this;
                        found = true;
                        break;
                    }
                }
                if(found == false)
                {
                    config.listConfig.Add(this);
                }
            }
            public String GetItem()
            {
                return item;
            }
            public String GetValue()
            {
                return value;
            }
        }
    }
}
