using DockerWebServer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using System.Net;
using System.Text;
using System.Diagnostics;
using System.Text.Json;

namespace DockerWebServer.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public class CustomContent : HttpContent
        {
            protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
            {
                throw new NotImplementedException();
            }

            protected override bool TryComputeLength(out long length)
            {
                throw new NotImplementedException();
            }
        };

        [HttpPost] // determine method type of end point attribute
        [ValidateAntiForgeryToken] // check to make sure Model is valid attribute
        [Route("Test/Test")] // determine route of endpoint attribute
        public async Task<IActionResult> TestForm(TestViewModel test) {
            if (ModelState.IsValid) { // check to make sure client sent proper information based off of the attributes added to TestViewModel

                Debug.WriteLine(JsonSerializer.Serialize(test)); // turn cSharp object into JSON

                var client = new HttpClient();
                
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header // or what to accept back

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, new Uri("http://WebService1/api/Test/validate"));

                request.Content = new StringContent(JsonSerializer.Serialize(test), Encoding.UTF8, "application/json");//CONTENT-TYPE header // or what to send
                var response = await client.SendAsync(request);
                if (response.StatusCode == HttpStatusCode.OK) { // make sure request returns 200 success code
                    string StringBody = await response.Content.ReadAsStringAsync();
                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.PropertyNameCaseInsensitive = true;
                    TestViewModel body = JsonSerializer.Deserialize<TestViewModel>(StringBody, options);

                    return Json(body);
                }
                return Json("bad request!");

            }
            return View("Index", test);
        }
        [HttpGet]
        [Route("Test/Test")]
        public async Task<IActionResult> TestForm()
        {
            return RedirectToAction("Index");
        }

    }
}
