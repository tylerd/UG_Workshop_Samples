using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.StorageClient;

namespace WpgNetUserGroup_Web.Models
{
    public class Meeting : TableServiceEntity
    {
        public Meeting()
        {
            PartitionKey = Guid.NewGuid().ToString();
            RowKey = string.Empty;
        }

        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
    }
}