using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using NHibernate.Validator.Constraints;

namespace EStable
{
  [System.CodeDom.Compiler.GeneratedCode("NHibernateModelGenerator", "1.0.0.0")]
  public partial class TblStableStandardCharge
  {
    public virtual int StableStandardChargeId { get; set; }
    public virtual int StableId { get; set; }
    [NotNull]
    [Length(Max=50)]
    public virtual string Description { get; set; }
    public virtual decimal Value { get; set; }

    public virtual TblStable Stable { get; set; }

    static partial void CustomizeMappingDocument(System.Xml.Linq.XDocument mappingDocument);

    internal static System.Xml.Linq.XDocument MappingXml
    {
      get
      {
        var mappingDocument = System.Xml.Linq.XDocument.Parse(@"<?xml version='1.0' encoding='utf-8' ?>
<hibernate-mapping xmlns='urn:nhibernate-mapping-2.2'
                   assembly='" + typeof(TblStableStandardCharge).Assembly.GetName().Name + @"'
                   namespace='EStable'
                   >
  <class name='TblStableStandardCharge'
         table='`tbl_stable_standard_charge`'
         >
    <id name='StableStandardChargeId'
        column='`Stable_Standard_Charge_ID`'
        >
      <generator class='hilo'>
        <param name='table'></param>
        <param name='column'></param>
        <param name='max_lo'>0</param>
      </generator>
    </id>
    <property name='StableId'
              column='`Stable_ID`'
              insert='false'
              update='false'
              />
    <property name='Description'
              column='`Description`'
              />
    <property name='Value'
              column='`Value`'
              />
    <many-to-one name='Stable' class='TblStable' column='`Stable_ID`' />
  </class>
</hibernate-mapping>");
        CustomizeMappingDocument(mappingDocument);
        return mappingDocument;
      }
    }
  }


}
