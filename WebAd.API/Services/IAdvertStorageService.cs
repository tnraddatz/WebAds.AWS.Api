using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAd.API.Models;

namespace WebAd.API.Services
{
    public interface IAdvertStorageService
    {
        Task<string> Add(AdvertModel model);
        Task Confirm(ConfirmAdvertModel model);

        Task<bool> CheckHealthAsync();
    }
}
