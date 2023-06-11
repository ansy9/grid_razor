using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ApprentissageBlazor.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class DashBordFilters : BaseObject
    { 
        public DashBordFilters(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }


        string dashBorad_Object;
        string dashborad_Number;

        public string Dashborad_Number
        {
            get => dashborad_Number;
            set => SetPropertyValue(nameof(Dashborad_Number), ref dashborad_Number, value);
        }

        
        public string DashBorad_Object
        {
            get => dashBorad_Object;
            set => SetPropertyValue(nameof(DashBorad_Object), ref dashBorad_Object, value);
        }

        [Association("DashBordFilters-Details")]
        public XPCollection<DashboardFilter_Details> Details
        {
            get
            {
                return GetCollection<DashboardFilter_Details>(nameof(Details));
            }
        }
    }
}