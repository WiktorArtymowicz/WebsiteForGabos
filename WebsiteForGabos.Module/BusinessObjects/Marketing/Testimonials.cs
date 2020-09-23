using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebsiteForGabos.Module.BusinessObjects.Marketing
{
    [NavigationItem("Marketing")]
    public class Testimonials : BaseObject
    {
        private string _quote = string.Empty;
        private string _highlight = string.Empty;
        private DateTime _createdOn = DateTime.MinValue;
        private string _tags = string.Empty;
        private Customer _customer = null;

        public Testimonials(Session session) : base(session)
        {
            _createdOn = DateTime.Now;
        }
        [Size(DevExpress.ExpressApp.DC.FieldSizeAttribute.Unlimited)]
        public string Quote { get => _quote; set => SetPropertyValue(nameof(Quote), ref _quote, value); }
        public string Highlight { get => _highlight; set => SetPropertyValue(nameof(Highlight), ref _highlight, value); }
        [VisibleInListView(false)]
        public DateTime CreatedOn { get => _createdOn; set => SetPropertyValue(nameof(CreatedOn), ref _createdOn, value); }
        public string Tags { get => _tags; set => SetPropertyValue(nameof(Tags), ref _tags, value); }
        [Association("Customer-Testimonials")]
        public Customer Customer { get => _customer; set => SetPropertyValue(nameof(Customer), ref _customer, value); }
    }
}
