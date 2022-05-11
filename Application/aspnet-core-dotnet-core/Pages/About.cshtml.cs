using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;

namespace aspnet_core_dotnet_core.Pages
{
    public class AboutModel : PageModel
    {

        public string Message { get; set; }

        public async Task OnGetAsync()
        {

            string baseUrl = "https://raw.githubusercontent.com/aspsnippets/test/master/Customers.json";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                    {
                        using (HttpContent content = res.Content)
                        {
                            var data = await content.ReadAsStringAsync();
                            if (content != null)
                            {
                                Console.WriteLine(data);
                                Message = data;
                            }
                            else
                            {
                                Message = "";
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception Hit------------");
                Console.WriteLine(exception);
            }
        }

    }
}

