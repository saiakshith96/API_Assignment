using API_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API_Assignment.APIHandlerManager
{
    public class APIHandler
    {
        // Obtaining the API key is easy. The same key should be usable across the entire
        // data.gov developer network, i.e. all data sources on data.gov.
        // https://www.nps.gov/subjects/developer/get-started.htm

        static string BASE_URL = "https://api.nal.usda.gov/fdc/v1/";
        static string API_KEY = "MABtHchD2Baau8HF2j1sbGJbEiUYGBUrfMNWiRmk"; //Add your API key here inside ""

        HttpClient httpClient;

        /// <summary>
        ///  Constructor to initialize the connection to the data source
        /// </summary>
        public APIHandler()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// Method to receive data from API end point as a collection of objects
        /// 
        /// JsonConvert parses the JSON string into classes
        /// </summary>
        /// <returns></returns>
        public Mymodel GetModel()
        {
            string NATIONAL_PARK_API_PATH = BASE_URL + "/333476?";
            string parksData = "";

            Mymodel parks = null;

            httpClient.BaseAddress = new Uri(NATIONAL_PARK_API_PATH);

            // It can take a few requests to get back a prompt response, if the API has not received
            //  calls in the recent past and the server has put the service on hibernation
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(NATIONAL_PARK_API_PATH).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    parksData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!parksData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    parks = JsonConvert.DeserializeObject<Mymodel>(parksData);

                }
            }


            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return parks;
        }
        public Mymodel GetModel4()
        {
            string NATIONAL_PARK_API_PATH = BASE_URL + "/341292?";
            string parksData = "";

            Mymodel parks = null;

            httpClient.BaseAddress = new Uri(NATIONAL_PARK_API_PATH);

            // It can take a few requests to get back a prompt response, if the API has not received
            //  calls in the recent past and the server has put the service on hibernation
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(NATIONAL_PARK_API_PATH).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    parksData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!parksData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    parks = JsonConvert.DeserializeObject<Mymodel>(parksData);

                }
            }


            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return parks;
        }

        public Mymodel GetModel1()
        {
            string NATIONAL_PARK_API_PATH = BASE_URL + "/323121?";
            string parksData = "";

            Mymodel parks = null;

            httpClient.BaseAddress = new Uri(NATIONAL_PARK_API_PATH);

            // It can take a few requests to get back a prompt response, if the API has not received
            //  calls in the recent past and the server has put the service on hibernation
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(NATIONAL_PARK_API_PATH).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    parksData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!parksData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    parks = JsonConvert.DeserializeObject<Mymodel>(parksData);

                }
            }


            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return parks;
        }

        public Mymodel GetModel2()
        {
            string NATIONAL_PARK_API_PATH = BASE_URL + "/335061?";
            string parksData = "";

            Mymodel parks = null;

            httpClient.BaseAddress = new Uri(NATIONAL_PARK_API_PATH);

            // It can take a few requests to get back a prompt response, if the API has not received
            //  calls in the recent past and the server has put the service on hibernation
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(NATIONAL_PARK_API_PATH).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    parksData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!parksData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    parks = JsonConvert.DeserializeObject<Mymodel>(parksData);

                }
            }


            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return parks;
        }

        public Mymodel GetModel5()
        {
            string NATIONAL_PARK_API_PATH = BASE_URL + "/341308? ";
            string parksData = "";

            Mymodel parks = null;

            httpClient.BaseAddress = new Uri(NATIONAL_PARK_API_PATH);

            // It can take a few requests to get back a prompt response, if the API has not received
            //  calls in the recent past and the server has put the service on hibernation
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(NATIONAL_PARK_API_PATH).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    parksData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!parksData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    parks = JsonConvert.DeserializeObject<Mymodel>(parksData);

                }
            }


            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return parks;
        }
        public Mymodel GetModel6()
        {
            string NATIONAL_PARK_API_PATH = BASE_URL + "/337341?";
            string parksData = "";

            Mymodel parks = null;

            httpClient.BaseAddress = new Uri(NATIONAL_PARK_API_PATH);

            // It can take a few requests to get back a prompt response, if the API has not received
            //  calls in the recent past and the server has put the service on hibernation
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(NATIONAL_PARK_API_PATH).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    parksData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!parksData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    parks = JsonConvert.DeserializeObject<Mymodel>(parksData);

                }
            }


            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return parks;
        }

        public Mymodel GetModel3()
        {
            string NATIONAL_PARK_API_PATH = BASE_URL + "/335259?";
            string parksData = "";

            Mymodel parks = null;

            httpClient.BaseAddress = new Uri(NATIONAL_PARK_API_PATH);

            // It can take a few requests to get back a prompt response, if the API has not received
            //  calls in the recent past and the server has put the service on hibernation
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(NATIONAL_PARK_API_PATH).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    parksData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!parksData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    parks = JsonConvert.DeserializeObject<Mymodel>(parksData);

                }
            }


            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return parks;
        }
    }
}
