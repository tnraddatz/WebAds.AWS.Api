using System;
using System.Collections.Generic;
using System.Text;

namespace WebAd.API.Models
{
    public class ConfirmAdvertModel
    {
        public string Id { get; set; }
        public string FilePath { get; set; }
        public AdvertStatus Status { get; set; }
    }
}
