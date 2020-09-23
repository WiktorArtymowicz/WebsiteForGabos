using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace WebsiteForGabos.Module.BusinessObjects.Marketing
{
    [NavigationItem("Marketing")]
    public class Customer : BaseObject
    {
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private string _email = string.Empty;
        private string _company = string.Empty;
        private string _occupation = string.Empty;
        private string _fullName = string.Empty;
        private byte[] _photo = null;

        public Customer(Session session) : base(session) 
        { 

        }

        public string FirstName { get => _firstName; set => SetPropertyValue(nameof(FirstName), ref _firstName, value); }
        public string LastName { get => _lastName; set => SetPropertyValue(nameof(LastName), ref _lastName, value); }
        public string Email { get => _email; set => SetPropertyValue(nameof(Email), ref _email, value); }
        public string Company { get => _company; set => SetPropertyValue(nameof(Company), ref _company, value); }
        public string Occupation { get => _occupation; set => SetPropertyValue(nameof(Occupation), ref _occupation, value); }
        public string FullName
        {
            get
            {
                string namePart = string.Format("{0} {1}", _firstName, _lastName);
                return _company != null ? string.Format("{0} {1}", namePart, _company) : namePart;
            }
        }
        [ImageEditor(ListViewImageEditorCustomHeight = 75, DetailViewImageEditorFixedHeight = 150)]
        public byte[] Photo { get => _photo; set => SetPropertyValue(nameof(Photo), ref _photo, value); }

        [Association("Customer-Testimonials")]
        public XPCollection<Testimonials> Testimonials { get => GetCollection<Testimonials>(nameof(Testimonials)); }
    }
}
