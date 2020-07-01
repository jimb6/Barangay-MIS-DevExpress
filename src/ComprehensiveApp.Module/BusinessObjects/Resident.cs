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
using ComprehensiveApp.Module.CustomProperties;

namespace ComprehensiveApp.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Resident : Person
    { 
        public Resident(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }


        string highestEducationalAttainment;
        Gender gender;
        string nationality;
        string religion;
        CivilStatus civilStatus;
        TitleOfCourtesy titleOfCourtesy;
        string occupation;
        BloodType typeOfBlood;
        string propertyName;
        int age;
        Address birthPlace;
        

        public TitleOfCourtesy TitleOfCourtesy
        {
            get => titleOfCourtesy;
            set => SetPropertyValue(nameof(TitleOfCourtesy), ref titleOfCourtesy, value);
        }

        public Address BirthPlace
        {
            get => birthPlace;
            set => SetPropertyValue(nameof(BirthPlace), ref birthPlace, value);
        }



        public Gender Gender
        {
            get => gender;
            set => SetPropertyValue(nameof(Gender), ref gender, value);
        }

        public int Age
        {
            get => age;
            set => SetPropertyValue(nameof(Age), ref age, value);
        }


        public BloodType TypeOfBlood
        {
            get { return typeOfBlood; }
            set
            {
                SetPropertyValue(nameof(TypeOfBlood), ref typeOfBlood, value);
            }
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Occupation
        {
            get => occupation;
            set => SetPropertyValue(nameof(Occupation), ref occupation, value);
        }



        public CivilStatus CivilStatus
        {
            get => civilStatus;
            set => SetPropertyValue(nameof(CivilStatus), ref civilStatus, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Religion
        {
            get => religion;
            set => SetPropertyValue(nameof(Religion), ref religion, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Nationality
        {
            get => nationality;
            set => SetPropertyValue(nameof(Nationality), ref nationality, value);
        }


        [Association("Resident-Skill")]
        public XPCollection<Skill> Skills
        {
            get
            {
                return GetCollection<Skill>(nameof(Skills));
            }
        }


        [Association("Resident-Location")]
        public XPCollection<Location> FormerAdresses
        {
            get
            {
                return GetCollection<Location>(nameof(FormerAdresses));
            }
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string HighestEducationalAttainment
        {
            get => highestEducationalAttainment;
            set => SetPropertyValue(nameof(HighestEducationalAttainment), ref highestEducationalAttainment, value);
        }

        [Association("Resident-HouseHold")]
        public XPCollection<HouseHold> HouseHolds
        {
            get
            {
                return GetCollection<HouseHold>(nameof(HouseHolds));
            }
        }

        [Association("HouseHold-Resident")]
        public XPCollection<HouseHold> Relations
        {
            get
            {
                return GetCollection<HouseHold>(nameof(Relations));
            }
        }

        [Association("Resident-Blotter")]
        public XPCollection<Blotter> BlotterRecords
        {
            get
            {
                return GetCollection<Blotter>(nameof(BlotterRecords));
            }
        }

    }
}