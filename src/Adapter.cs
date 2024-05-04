using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdapterPattern
{
    internal class Adapter : LegacyEmployeeManager, INewEmployeeManager
    {
        //Use this adapter class in dependency injection as concrete implementation for INewEmployeeManager
        public new string GetAllEmployees()
        {
            var result = base.GetAllEmployees();
            string jsonString = JsonConvert.SerializeXmlNode(new XmlDocument { InnerXml = result }, Newtonsoft.Json.Formatting.Indented);
            return jsonString;
        }
    }
}
