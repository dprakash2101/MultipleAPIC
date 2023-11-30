using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Multipleapi
{
    public class Multipleapi
    {
        public void contact()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost:7027";
            var apiInstance = new ContactApi(config);

            try
            {
                List<Contact> result = apiInstance.ContactGet();
                for(int i=0; i<result.Count; i++)
                {
                    Console.WriteLine(result[i]);
                }
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ContactApi.ContactGet: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
        public void Employee()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost:7044";
            var apiInstance = new EmployeeApi(config);

            try
            {
                List<Employee> result = apiInstance.EmployeeGet();
                for (int i = 0; i < result.Count; i++)
                {
                    Console.WriteLine(result[i]);
                }
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling EmployeeApi.EmployeeGet: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);

            }
        }
        public static void Main()
        {
            Multipleapi mul = new Multipleapi();
            
            mul.contact();
            mul.Employee();


            

        }
    }
}