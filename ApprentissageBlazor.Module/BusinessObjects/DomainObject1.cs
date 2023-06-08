using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace ApprentissageBlazor.Module.BusinessObjects
{
    [DefaultClassOptions]
    
    public class DomainObject1 : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public DomainObject1(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        private string _PersistentProperty;
        public string PersistentProperty
        {
            get { return _PersistentProperty; }
            set { SetPropertyValue(nameof(PersistentProperty), ref _PersistentProperty, value); }
        }

        private string _PersistentProperty2;
        public string PersistentProperty2
        {
            get { return _PersistentProperty2; }
            set { SetPropertyValue(nameof(PersistentProperty2), ref _PersistentProperty2, value); }
        }
    }
}