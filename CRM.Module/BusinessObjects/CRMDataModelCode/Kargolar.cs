using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;

namespace CRM.Module.BusinessObjects.Database
{
    [DefaultClassOptions]
    public partial class Kargolar
    {
        public Kargolar(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
