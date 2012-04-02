using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.StorageClient;
using Microsoft.WindowsAzure;
using WpgNetUserGroup_Web.Models;

namespace WpgNetUserGroup_Web.Data
{
    public class DataContext
    {
        private TableServiceContext _tableServiceContext;

        public DataContext()
        {
            var account = CloudStorageAccount.FromConfigurationSetting("DataContext");

            _tableServiceContext = account.CreateCloudTableClient().GetDataServiceContext();
        }

        public void AddMeeting(Meeting meeting)
        {
            _tableServiceContext.AddObject("Meetings", meeting);
        }

        public IQueryable<Meeting> Meetings
        {
            get{
                return _tableServiceContext.CreateQuery<Meeting>("Meetings");
            }
        }

        internal void SaveChanges()
        {
            _tableServiceContext.SaveChanges();
        }
    }
}