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
    public class Individual : Person
    { 
        public Individual(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
           
        }

        [Association("Blotter-Individual")]
        public XPCollection<Blotter> Blotters
        {
            get
            {
                return GetCollection<Blotter>(nameof(Blotters));
            }
        }

    }
}