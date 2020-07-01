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
    public class HouseHold : BaseObject, IMapsMarker
    { 
        public HouseHold(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }


        string houseCode;
         Resident houseOwner;

        public Resident HouseOwner
        {
            get => houseOwner;
            set => SetPropertyValue(nameof(HouseOwner), ref houseOwner, value);
        }

        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string HouseCode
        {
            get => houseCode;
            set => SetPropertyValue(nameof(HouseCode), ref houseCode, value);
        }


        [Association("HouseHold-Resident")]
        public XPCollection<Resident> HouseMembers
        {
            get
            {
                return GetCollection<Resident>(nameof(HouseMembers));
            }
        }

        [Association("Resident-HouseHold")]
        public XPCollection<Resident> Residents
        {
            get
            {
                return GetCollection<Resident>(nameof(Residents));
            }
        }

        public string Title { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}