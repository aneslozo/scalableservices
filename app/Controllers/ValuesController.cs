using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private static IEnumerable<string> _values = new string[] { "irfan", "muhamed", "tarik" };
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {   
            Console.WriteLine($"Get called, reponse: { string.Join(",", _values) }");
            return  _values;
        }

        // GET api/values/5
        [HttpGet("search/{val}")]
        public IEnumerable<string> GetValues(string val)
        {
            return _values.Where(a=> a.Contains(val)) ;
        }

        [HttpGet("add/{val}")]
        public IEnumerable<string> AddValue(string val)
        {
           _values = _values.Append(val);
           return _values;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
