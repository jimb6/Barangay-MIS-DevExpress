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
using System.Drawing;

namespace ComprehensiveApp.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Blotter : BaseObject
    { 
        public Blotter(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }



        Individual personToComplain;
        DateTime dateReported;
        Individual propertyName;
        string incidentSummary;
        DateTime dateOfIncident;



        public Individual Complainant
        {
            get => propertyName;
            set => SetPropertyValue(nameof(Complainant), ref propertyName, value);
        }

        
        public Individual PersonToComplainResident
        {
            get => personToComplain;
            set => SetPropertyValue(nameof(PersonToComplainResident), ref personToComplain, value);
        }


        [Size(8192)]
        public string IncidentSummary
        {
            get => incidentSummary;
            set => SetPropertyValue(nameof(IncidentSummary), ref incidentSummary, value);
        }

        public DateTime DateOfIncident
        {
            get => dateOfIncident;
            set => SetPropertyValue(nameof(DateOfIncident), ref dateOfIncident, value);
        }

        
        public DateTime DateReported
        {
            get => dateReported;
            set => SetPropertyValue(nameof(DateReported), ref dateReported, value);
        }


        [Association("Blotter-BlotterEvent")]
        public XPCollection<BlotterEvent> BlotterEvents
        {
            get
            {
                return GetCollection<BlotterEvent>(nameof(BlotterEvents));
            }
        }


        [Association("Resident-Blotter")]
        public XPCollection<Resident> People
        {
            get
            {
                return GetCollection<Resident>(nameof(People));
            }
        }

        [Association("Blotter-Individual")]
        public XPCollection<Individual> NonBarangayResidents
        {
            get
            {
                return GetCollection<Individual>(nameof(NonBarangayResidents));
            }
        }

    }
}