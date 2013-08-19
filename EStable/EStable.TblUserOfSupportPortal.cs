using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using NHibernate.Validator.Constraints;

namespace EStable
{
  [System.CodeDom.Compiler.GeneratedCode("NHibernateModelGenerator", "1.0.0.0")]
  public partial class TblUserOfSupportPortal
  {
    public virtual int SupportUserId { get; set; }
    [NotNull]
    [Length(Max=50)]
    public virtual string SupportUserEmail { get; set; }
    [NotNull]
    [Length(Max=20)]
    public virtual string SupportPasswrd { get; set; }
    public virtual sbyte ActiveInd { get; set; }
    public virtual sbyte ForcePwChange { get; set; }

    static partial void CustomizeMappingDocument(System.Xml.Linq.XDocument mappingDocument);

    internal static System.Xml.Linq.XDocument MappingXml
    {
      get
      {
        var mappingDocument = System.Xml.Linq.XDocument.Parse(@"<?xml version='1.0' encoding='utf-8' ?>
<hibernate-mapping xmlns='urn:nhibernate-mapping-2.2'
                   assembly='" + typeof(TblUserOfSupportPortal).Assembly.GetName().Name + @"'
                   namespace='EStable'
                   >
  <class name='TblUserOfSupportPortal'
         table='`tbl_user_of_support_portal`'
         >
    <id name='SupportUserId'
        column='`Support_User_ID`'
        >
      <generator class='hilo'>
        <param name='table'></param>
        <param name='column'></param>
        <param name='max_lo'>0</param>
      </generator>
    </id>
    <property name='SupportUserEmail'
              column='`Support_User_Email`'
              />
    <property name='SupportPasswrd'
              column='`Support_Passwrd`'
              />
    <property name='ActiveInd'
              column='`Active_Ind`'
              />
    <property name='ForcePwChange'
              column='`Force_PW_Change`'
              />
  </class>
</hibernate-mapping>");
        CustomizeMappingDocument(mappingDocument);
        return mappingDocument;
      }
    }
  }


}
