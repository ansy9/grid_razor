using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using DevExpress.XtraSpreadsheet.Import.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ApprentissageBlazor.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Classe : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Classe(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string className;

        [Size(25)]
        public string ClassName
        {
            get => className;
            set => SetPropertyValue(nameof(ClassName), ref className, value);
        }

        [Association("Classe-DomainObjects")]
        public XPCollection<DomainObject1> DomainObjects
        {
            get
            {
                return GetCollection<DomainObject1>(nameof(DomainObjects));
            }
        }
    }
}