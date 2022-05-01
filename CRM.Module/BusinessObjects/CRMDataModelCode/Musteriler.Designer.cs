﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;

namespace CRM.Module.BusinessObjects.Database
{
    [XafDisplayName("Müşteriler")]
    [Persistent(@"tbl_musteriler")]
    public partial class Musteriler : XPLiteObject
    {
        int fid;
        [Key(true)]
        [VisibleInListView(false)]
        [VisibleInDetailView(false)]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>(nameof(id), ref fid, value); }
        }
        string fmusteri_adi;
        [Size(50)]
        [XafDisplayName("Müşteri Adı")]
        public string musteri_adi
        {
            get { return fmusteri_adi; }
            set { SetPropertyValue<string>(nameof(musteri_adi), ref fmusteri_adi, value); }
        }
        string fmusteri_adresi;
        [Size(50)]
        [XafDisplayName("Müşteri Adresi")]
        public string musteri_adresi
        {
            get { return fmusteri_adresi; }
            set { SetPropertyValue<string>(nameof(musteri_adresi), ref fmusteri_adresi, value); }
        }
        string fmusteri_tel;
        [Size(10)]
        [XafDisplayName("Müşteri Telefonu")]
        public string musteri_tel
        {
            get { return fmusteri_tel; }
            set { SetPropertyValue<string>(nameof(musteri_tel), ref fmusteri_tel, value); }
        }
    }

}
