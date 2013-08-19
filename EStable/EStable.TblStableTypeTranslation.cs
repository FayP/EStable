using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using NHibernate.Validator.Constraints;

namespace EStable
{
  [System.CodeDom.Compiler.GeneratedCode("NHibernateModelGenerator", "1.0.0.0")]
  public partial class TblStableTypeTranslation
  {
    public virtual int TranslationId { get; set; }
    public virtual int StableTypeId { get; set; }
    [NotNull]
    [Length(Max=30)]
    public virtual string StandardWord { get; set; }
    [NotNull]
    [Length(Max=30)]
    public virtual string TranslatedTo { get; set; }

    public virtual TblStableType StableType { get; set; }

    static partial void CustomizeMappingDocument(System.Xml.Linq.XDocument mappingDocument);

    internal static System.Xml.Linq.XDocument MappingXml
    {
      get
      {
        var mappingDocument = System.Xml.Linq.XDocument.Parse(@"<?xml version='1.0' encoding='utf-8' ?>
<hibernate-mapping xmlns='urn:nhibernate-mapping-2.2'
                   assembly='" + typeof(TblStableTypeTranslation).Assembly.GetName().Name + @"'
                   namespace='EStable'
                   >
  <class name='TblStableTypeTranslation'
         table='`tbl_stable_type_translations`'
         >
    <id name='TranslationId'
        column='`Translation_ID`'
        >
      <generator class='hilo'>
        <param name='table'></param>
        <param name='column'></param>
        <param name='max_lo'>0</param>
      </generator>
    </id>
    <property name='StableTypeId'
              column='`Stable_Type_ID`'
              insert='false'
              update='false'
              />
    <property name='StandardWord'
              column='`Standard_Word`'
              />
    <property name='TranslatedTo'
              column='`Translated_To`'
              />
    <many-to-one name='StableType' class='TblStableType' column='`Stable_Type_ID`' />
  </class>
</hibernate-mapping>");
        CustomizeMappingDocument(mappingDocument);
        return mappingDocument;
      }
    }
  }


}
