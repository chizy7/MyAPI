using System;
namespace MyApi.Models
{
    public class Email
    {
        public int EmailId { get; set; }
        public string EmailAddress { get; set; }
        public bool IsSubscribed { get; set; }
    }
}