using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DevExpress.Persistent.Validation;

namespace WebsiteForGabos.Module.BusinessObjects.Planning
{
    [NavigationItem("Planning")]
    [RuleCriteria("EndDate >= StartDate",
    CustomMessageTemplate = "Start Date must be less than End Date")]
    public class ProjectTask : BaseObject
    {
        private string _subject = string.Empty;
        private ProjectTaskStatus _projectTaskStatus = 0;
        private Person _assignedTo = null;
        private DateTime _startDate = DateTime.MinValue;
        private DateTime _endDate = DateTime.Today;
        private string _notes = string.Empty;
        private Project _project = null;

        public ProjectTask(Session session) : base(session) 
        { 

        }

        [Size(255)]
        public string Subject { get => _subject; set => SetPropertyValue(nameof(Subject), ref _subject, value); }
        public ProjectTaskStatus ProjectTaskStatus { get => _projectTaskStatus; set => SetPropertyValue(nameof(ProjectTaskStatus), ref _projectTaskStatus, value); }
        public Person AssignedTo { get => _assignedTo; set => SetPropertyValue(nameof(AssignedTo), ref _assignedTo, value); }
        public DateTime StartDate { get => _startDate; set => SetPropertyValue(nameof(StartDate), ref _startDate, value); }
        public DateTime EndDate { get => _endDate; set => SetPropertyValue(nameof(EndDate), ref _endDate, value); }
        [Size(SizeAttribute.Unlimited)]
        public string Notes { get => _notes; set => SetPropertyValue(nameof(Notes), ref _notes, value); }
        [Association]
        public Project Project { get => _project; set => _project = value; }
    }
}
