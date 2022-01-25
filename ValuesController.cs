using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace webapi.Controllers
{
    [Route("api/")]
    
    public class ValuesController : ApiController 
    {
        // GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5

        //public String Get(int Amount,Decimal intrest)
        //{

        //    decimal Sampleintrest;
        //    if (HttpContext.Current.Request.QueryString["Amount"] != null)
        //        Amount = Convert.ToInt32(HttpContext.Current.Request.QueryString["Amount"]);
        //    if (HttpContext.Current.Request.QueryString["intrest"] != null)
        //        intrest = Convert.ToDecimal(HttpContext.Current.Request.QueryString["intrest"]);
        //    //decimal intrestdec = (intrest / 100);
        //   // int intrestin = Convert.ToInt32(intrestdec);
        //    Sampleintrest = (Amount * intrest);
        //    return "The calculated Sampleintrest is : "+ Sampleintrest+"";
        //}



        public String Get(int Amount, int intrest)
        {
            
            decimal Sampleintrest;
            if (HttpContext.Current.Request.QueryString["Amount"] != null)
                Amount = Convert.ToInt32(HttpContext.Current.Request.QueryString["Amount"]);
            if (HttpContext.Current.Request.QueryString["intrest"] != null)
                intrest = Convert.ToInt32(HttpContext.Current.Request.QueryString["intrest"]);
            decimal intrestdec = Convert.ToDecimal(intrest);
            decimal intdeci = (intrestdec / 100);

            // int intrestin = Convert.ToInt32(intrestdec);
            Sampleintrest = (Amount * intdeci);
            
            return "" + Sampleintrest + "" ;

        }


        static List<string> Employes = new List<string>()
        {
            "Employee 1",
            "Employee 2",
            "Employee 3",
            "Employee 4",
            "Employee 5",
            "Employee 6"
        };


        public IEnumerable<string> Get()
        {
            return Employes;
        }
        public string Get(int id)
        {
            return Employes[id];
        }

        //public string Get(int id)
        //{
        //    return "the Value Called by the web api is 1"+ id;
        //}

        // POST api/values
        public string Post([FromBody] int Amount, int intrest)
        {

            decimal Sampleintrest;
            if (HttpContext.Current.Request.QueryString["Amount"] != null)
                Amount = Convert.ToInt32(HttpContext.Current.Request.QueryString["Amount"]);
            if (HttpContext.Current.Request.QueryString["intrest"] != null)
                intrest = Convert.ToInt32(HttpContext.Current.Request.QueryString["intrest"]);
            decimal intrestdec = Convert.ToDecimal(intrest);
            decimal intdeci = (intrestdec / 100);

            // int intrestin = Convert.ToInt32(intrestdec);
            Sampleintrest = (Amount * intdeci);

            return "" + Sampleintrest + "";

        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
