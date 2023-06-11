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
    public class DashboardFilter_Details : BaseObject
    { 
        public DashboardFilter_Details(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }


        string type;
        BinaryOperatorType operatorType;
        string champsName;
        DashBordFilters dashBord;

        [Association("DashBordFilters-Details")]
        public DashBordFilters DashBord
        {
            get => dashBord;
            set => SetPropertyValue(nameof(DashBord), ref dashBord, value);
        }


        public string ChampsName
        {
            get => champsName;
            set => SetPropertyValue(nameof(ChampsName), ref champsName, value);
        }


        public BinaryOperatorType OperatorType
        {
            get => operatorType;
            set => SetPropertyValue(nameof(OperatorType), ref operatorType, value);
        }


        
        public string Type
        {
            get => type;
            set => SetPropertyValue(nameof(Type), ref type, value);
        }


    }
}