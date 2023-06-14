using ApprentissageBlazor.Module.BusinessObjects;
using DevExpress.ExpressApp.Blazor.Editors.Adapters;
using DevExpress.ExpressApp;
using Microsoft.AspNetCore.Components;
using DevExpress.ExpressApp.Editors;
using DevExpress.Xpo;

namespace ApprentissageBlazor.Blazor.Server.MesPages.GridCrossObjects
{    
    public class GridFilterCrossObjectsAdapter : IComponentAdapter, IComplexControl
    {
        private XafApplication application;
        private RenderFragment component;
        public RenderFragment ComponentContent
        {
            get
            {
                if (component == null)
                {
                    IObjectSpace ObjSpace = this.application.CreateObjectSpace(typeof(DomainObject1));


                    IList<DomainObject1> objectToShowFullName = ObjSpace.GetObjects<DomainObject1>();
                    IEnumerable<DomainObject1> domainObjectsFullName = objectToShowFullName.AsEnumerable();

                    IList<Classe> objectToShowClassName = ObjSpace.GetObjects<Classe>();
                    IEnumerable<Classe> domainObjectClassName = objectToShowClassName.AsEnumerable();

                    IList<DomainObject1> objectToShowFirstNameStart = ObjSpace.GetObjects<DomainObject1>();
                    IEnumerable<DomainObject1> domainObjectsFirstNameStart = objectToShowFirstNameStart.AsEnumerable();

                    IList<DomainObject1> objectToShowFirstNameEnd = ObjSpace.GetObjects<DomainObject1>();
                    IEnumerable<DomainObject1> domainObjectsFirstNameEnd = objectToShowFirstNameStart.AsEnumerable();

                     
                    component = builder => {
                        builder.OpenComponent<GridFilterCrossObjects>(0);
                        builder.AddAttribute(1, nameof(GridFilterCrossObjects.DomaineObjsFullName), domainObjectsFullName);
                        builder.AddAttribute(2, nameof(GridFilterCrossObjects.DomaineObjsClassName), domainObjectClassName);
                        builder.AddAttribute(3, nameof(GridFilterCrossObjects.DomaineObjsFirstNameStart), domainObjectsFirstNameStart);
                        builder.AddAttribute(3, nameof(GridFilterCrossObjects.DomaineObjsFirstNameEnd), domainObjectsFirstNameEnd);
                        builder.AddAttribute(4, nameof(GridFilterCrossObjects.objectSpaceDomainObjects), ObjSpace);

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
