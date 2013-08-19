using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using NHibernate.Validator.Constraints;

namespace EStable
{
  [System.CodeDom.Compiler.GeneratedCode("NHibernateModelGenerator", "1.0.0.0")]
  public partial class TblStableType
  {
    public virtual int StableTypeId { get; set; }
    [NotNull]
    [Length(Max=50)]
    public virtual string Description { get; set; }

    private IList<TblStable> _tblStables = new List<TblStable>();

    public virtual IList<TblStable> TblStables
    {
      get { return _tblStables; }
      set { _tblStables = value; }
    }

    private IList<TblStableTypeTranslation> _tblStableTypeTranslations = new List<TblStableTypeTranslation>();

    public virtual IList<TblStableTypeTranslation> TblStableTypeTranslations
    {
      get { return _tblStableTypeTranslations; }
      set { _tblStableTypeTranslations = value; }
    }

    static partial void CustomizeMappingDocument(System.Xml.Linq.XDocument mappingDocument);

    internal static System.Xml.Linq.XDocument MappingXml
    {
      get
      {
        var mappingDocument = System.Xml.Linq.XDocument.Parse(@"<?xml version='1.0' encoding='utf-8' ?>
<hibernate-mapping xmlns='urn:nhibernate-mapping-2.2'
                   assembly='" + typeof(TblStableType).Assembly.GetName().Name + @"'
                   namespace='EStable'
                   >
  <class name='TblStableType'
         table='`tbl_stable_type`'
         >
    <id name='StableTypeId'
        column='`Stable_Type_ID`'
        >
      <generator class='hilo'>
        <param name='table'></param>
        <param name='column'></param>
        <param name='max_lo'>0</param>
      </generator>
    </id>
    <property name='Description'
              column='`Description`'
              />
    <bag name='TblStables'
          inverse='true'
          >
      <key column='`Stable_Type_ID`' />
      <one-to-many class='TblStable' />
    </bag>
    <bag name='TblStableTypeTranslations'
          inverse='true'
          >
      <key column='`Stable_Type_ID`' />
      <one-to-many class='TblStableTypeTranslation' />
    </bag>
  </class>
</hibernate-mapping>");
        CustomizeMappingDocument(mappingDocument);
        return mappingDocument;
      }
    }
  }


}
