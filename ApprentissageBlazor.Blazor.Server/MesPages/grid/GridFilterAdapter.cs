using ApprentissageBlazor.Module.BusinessObjects;
using DevExpress.ExpressApp.Blazor.Editors.Adapters;
using DevExpress.ExpressApp;
using Microsoft.AspNetCore.Components;
using DevExpress.ExpressApp.Editors;

namespace ApprentissageBlazor.Blazor.Server.MesPages.grid
{
    
    public class GridFilterAdapter : IComponentAdapter, IComplexControl
    {
        private XafApplication application;
        private RenderFragment component;
        public RenderFragment ComponentContent
        {
            get
            {
                if (component == null)
                {
                    
                    IObjectSpace ObjSpaceFirstName = this.application.CreateObjectSpace(typeof(DomainObject1));
                    IList<DomainObject1> objectToShowFirstName = ObjSpaceFirstName.GetObjects<DomainObject1>();
                    IEnumerable<DomainObject1> domainObjectsFirstName = objectToShowFirstName.AsEnumerable();

                    IObjectSpace ObjSpaceLastName = this.application.CreateObjectSpace(typeof(DomainObject1));
                    IList<DomainObject1> objectToShowLastName = ObjSpaceLastName.GetObjects<DomainObject1>();
                    IEnumerable<DomainObject1> domainObjectsLastName = objectToShowLastName.AsEnumerable();


                    ObjSpaceFirstName.CommitChanges();
                    ObjSpaceLastName.CommitChanges();

                    component = builder => {
                        builder.OpenComponent<GridFilter>(0);
                        builder.AddAttribute(1, nameof(GridFilter.DomaineObjsFirstName), domainObjectsFirstName);
                        builder.AddAttribute(2, nameof(GridFilter.DomaineObjsLastName), domainObjectsLastName);
                        builder.AddAttribute(3, nameof(GridFilter.Data), objectToShowLastName);

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
