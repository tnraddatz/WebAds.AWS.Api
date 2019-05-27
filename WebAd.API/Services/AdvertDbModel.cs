using Amazon.DynamoDBv2.DataModel;
using System;
using WebAd.API.Models;

namespace WebAd.API.Services
{
    [DynamoDBTable("Advert")]
    public class AdvertDbModel
    {
        //Below > Additional Properties
        [DynamoDBHashKey]
        public string Id { get; set; }
        [DynamoDBProperty]
        public DateTime CreationDateTime { get; set; }
        [DynamoDBProperty]
        public AdvertStatus Status { get; set; }
        //Below > AdvertModel Properties
        [DynamoDBProperty]
        public string Title { get; set; }
        [DynamoDBProperty]
        public string Description { get; set; }
        [DynamoDBProperty]
        public double price { get; set; }
    }
}
