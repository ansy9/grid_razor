using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System.ComponentModel;

namespace ApprentissageBlazor.Module.BusinessObjects
{
    [DefaultClassOptions]
    [DefaultProperty(nameof(FullName))]
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
        Classe classe;
        string fullName;
        string age;
        string number;
        DateTime birthDay;


        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set { SetPropertyValue(nameof(FirstName), ref _FirstName, value); }
        }

        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set { SetPropertyValue(nameof(LastName), ref _LastName, value); }
        }


        public string FullName
        {
            get => FirstName + " " + LastName;
        }

        public DateTime BirthDay
        {
            get => birthDay;
            set => SetPropertyValue(nameof(BirthDay), ref birthDay, value);
        }


        public string Age
        {
            get => (DateTime.Now.Year - BirthDay.Year).ToString();
        }


        public string PhoneNumber
        {
            get => number;
            set => SetPropertyValue(nameof(PhoneNumber), ref number, value);
        }


        
        [Association("Classe-DomainObjects")]
        public Classe Classe
        {
            get => classe;
            set => SetPropertyValue(nameof(Classe), ref classe, value);
        }


    }
}