using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using NHibernate.Validator.Constraints;

namespace EStable
{
  [System.CodeDom.Compiler.GeneratedCode("NHibernateModelGenerator", "1.0.0.0")]
  public partial class TblUserOfStablePortal
  {
    public virtual int UserId { get; set; }
    [NotNull]
    [Length(Max=50)]
    public virtual string UserEmail { get; set; }
    public virtual int Passwrd { get; set; }
    public virtual sbyte ActiveInd { get; set; }
    public virtual sbyte ForcePwChange { get; set; }

    private IList<TblStableUser> _tblStableUsers = new List<TblStableUser>();

    public virtual IList<TblStableUser> TblStableUsers
    {
      get { return _tblStableUsers; }
      set { _tblStableUsers = value; }
    }

    static partial void CustomizeMappingDocument(System.Xml.Linq.XDocument mappingDocument);

    internal static System.Xml.Linq.XDocument MappingXml
    {
      get
      {
        var mappingDocument = System.Xml.Linq.XDocument.Parse(@"<?xml version='1.0' encoding='utf-8' ?>
<hibernate-mapping xmlns='urn:nhibernate-mapping-2.2'
                   assembly='" + typeof(TblUserOfStablePortal).Assembly.GetName().Name + @"'
                   namespace='EStable'
                   >
  <class name='TblUserOfStablePortal'
         table='`tbl_user_of_stable_portal`'
         >
    <id name='UserId'
        column='`User_ID`'
        >
      <generator class='hilo'>
        <param name='table'></param>
        <param name='column'></param>
        <param name='max_lo'>0</param>
      </generator>
    </id>
    <property name='UserEmail'
              column='`User_Email`'
              />
    <property name='Passwrd'
              column='`Passwrd`'
              />
    <property name='ActiveInd'
              column='`Active_Ind`'
              />
    <property name='ForcePwChange'
              column='`Force_PW_Change`'
              />
    <bag name='TblStableUsers'
          inverse='true'
          >
      <key column='`User_ID`' />
      <one-to-many class='TblStableUser' />
    </bag>
  </class>
</hibernate-mapping>");
        CustomizeMappingDocument(mappingDocument);
        return mappingDocument;
      }
    }
  }


}
