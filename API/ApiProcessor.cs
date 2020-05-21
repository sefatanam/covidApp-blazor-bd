using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CovidStatistics.Models
{
    public class ApiProcessor
    {
        public async Task<List<CovidInfo>> LoadAllCountriesData()
        {


            try
            {
                string url = "https://disease.sh/v2/countries?yesterday=false";
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {

                    if (response.IsSuccessStatusCode)
                    {
                        var data = await response.Content.ReadAsAsync<List<CovidInfo>>();
                        await Task.Delay(200);
                        return data;

                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }

        }


        public async Task<CovidInfo> BangladeshData()
        {


            try
            {
                
                string url = "https://disease.sh/v2/countries?yesterday=false";
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {

                    if (response.IsSuccessStatusCode)
                    {
                        var data = await response.Content.ReadAsAsync<List<CovidInfo>>();
                        await Task.Delay(200);
                        var bddata = data.Where(c => c.Country.ToLower() == "bangladesh").FirstOrDefault();
                        return bddata;

                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }

        }



        public async Task<WorldWideInfo> WorldWideAffected()
        {


            try
            {
                
                string url = "https://disease.sh/v2/all?yesterday=true&allowNull=false";
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {

                    if (response.IsSuccessStatusCode)
                    {
                        var data = await response.Content.ReadAsAsync<WorldWideInfo>();
                        await Task.Delay(200);
                        return data;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
