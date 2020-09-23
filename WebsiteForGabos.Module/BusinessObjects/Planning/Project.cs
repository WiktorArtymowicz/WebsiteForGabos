using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebsiteForGabos.Module.BusinessObjects.Planning
{
    [NavigationItem("Planning")]
    public class Project : BaseObject
    {
        private string _name = string.Empty;
        private Person _manager = null;
        private string _description = string.Empty;

        public Project(Session session) : base(session)
        {

        }

        public string Name { get => _name; set => SetPropertyValue(nameof(Name), ref _name, value); }
        public Person Manager { get => _manager; set => SetPropertyValue(nameof(Manager), ref _manager, value); }
        [Size(SizeAttribute.Unlimited)]
        public string Description { get => _description; set => SetPropertyValue(nameof(Description), ref _description, value); }
        [Association, Aggregated]
        public XPCollection<ProjectTask> Tasks { get => GetCollection<ProjectTask>(nameof(Tasks)); }
    }
}
