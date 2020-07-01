using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace ComprehensiveApp.Module.BusinessObjects
{
    [DefaultClassOptions]
    
    public class Skill : BaseObject
    {
        public Skill(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }


        string jobTitle;
        string jobDescription;

        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string JobTitle
        {
            get => jobTitle;
            set => SetPropertyValue(nameof(JobTitle), ref jobTitle, value);
        }

        [Size(4096)]
        public string JobDescription
        {
            get => jobDescription;
            set => SetPropertyValue(nameof(JobDescription), ref jobDescription, value);
        }


        [Association("Resident-Skill")]
        public XPCollection<Resident> Residents
        {
            get
            {
                return GetCollection<Resident>(nameof(Residents));
            }
        }
    }
}