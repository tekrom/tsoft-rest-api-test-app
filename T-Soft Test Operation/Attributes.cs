using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSoftRestApiTestApp
{
   public class Attributes
    {
        public class MethodTypeGet : Attribute
        {

        }

        public class MethodTypeGetWithByParam : Attribute
        {

        }

        public class MethodTypeSet : Attribute
        {

        }

        public class MethodTypeSetWithByParam : Attribute
        {

        }

        public class MethodTypeUpdate : Attribute
        {

        }

        public class MethodTypeUpdateWithByParam : Attribute
        {

        }

        public class MethodTypeDelete : Attribute
        {

        }

        public class MethodTypeDeleteWithByParam : Attribute
        {

        }

        public class UrlParamName : Attribute
        {
            public string s { get; set; }

            public UrlParamName(string ss)
            {
                s = ss;
            }
        }
    }
}
