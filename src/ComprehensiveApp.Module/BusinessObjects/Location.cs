﻿using System;
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
    public class Location : Address 
    { 
        public Location(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();

        }

        [Association("Resident-Location")]
        public XPCollection<Resident> ResidentLocation
        {
            get
            {
                return GetCollection<Resident>(nameof(ResidentLocation));
            }
        }
        
    }
}