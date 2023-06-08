using ApprentissageBlazor.Module.BusinessObjects;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Blazor.Editors.Adapters;
using DevExpress.ExpressApp.Editors;
using Microsoft.AspNetCore.Components;

namespace ApprentissageBlazor.Blazor.Server.MesPages
{
    public class WelcomeComponentAdapter : IComponentAdapter, IComplexControl
    {
        private XafApplication application;
        private RenderFragment component;
        public RenderFragment ComponentContent
        {
            get
            {
                if (component == null)
                {
                    

                    IObjectSpace newObjectSpace = this.application.CreateObjectSpace(typeof(DomainObject1));
                    IList<DomainObject1> objectToShow = newObjectSpace.GetObjects<DomainObject1>( );
                    IEnumerable<DomainObject1> domainObject1s = objectToShow.AsEnumerable();

                    //objectToShow.PersistentProperty = "Alla";
                    newObjectSpace.CommitChanges();

                    component = builder => {
                        builder.OpenComponent<WelcomeComponent>(0);
                        builder.AddAttribute(1, nameof(WelcomeComponent.DomaineObjs), domainObject1s);
                        builder.CloseComponent();
                    };
                }
                return component;
            }
        }






        public void Refresh() { }
        public void Setup(IObjectSpace objectSpace, XafApplication application)
        {
            this.application = application;
        }
        public object GetValue()
        {
            return null;
        }
        public void SetValue(object value) { }
        public event EventHandler ValueChanged;
    }
}
