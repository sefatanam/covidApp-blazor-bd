using CovidStatistics.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CovidStatistics.Data
{
    public class ApiServices
    {
        

        public ApiServices()
        {
            ApiHelper.InitializedClient();
        }

        public async Task<List<CovidInfo>> CovidInfoData()
        {
            try
            {
                ApiProcessor ApiProcessor = new ApiProcessor();
                return await ApiProcessor.LoadAllCountriesData();
            }
            catch (Exception)
            {
                return null;
            }



        }

        public async Task<CovidInfo> BanglaCovidInfoData()
        {
            try
            {
                ApiProcessor ApiProcessor = new ApiProcessor();
                return await ApiProcessor.BangladeshData();
            }
            catch (Exception)
            {
                return null;
            }



        }

        public async Task<WorldWideInfo> AroundTheWorld()
        {
            try
            {
                ApiProcessor ApiProcessor = new ApiProcessor();
                return await ApiProcessor.WorldWideAffected();
            }
            catch (Exception)
            {
                return null;
            }



        }
    }
}
