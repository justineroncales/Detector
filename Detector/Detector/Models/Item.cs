using System;
using System.Collections.Generic;

namespace Detector.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
    }
    public class UsersDetails
    {
        public string PASSWORD { get; set; }
        public string EMAIL { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public double LATITUDE { get; set; }
        public double LONGITUDE { get; set; }
        public string ID { get; set; }

        private string _MESSAGE;
        public string MESSAGE
        {
            get { return _MESSAGE; }
            set { _MESSAGE = value; }
        }

        private string _USERNAME;
        public string USERNAME
        {
            get { return _USERNAME; }
            set { _USERNAME = value; }
        }
    }
}