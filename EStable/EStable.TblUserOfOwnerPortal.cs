using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using NHibernate.Validator.Constraints;

namespace EStable
{
  [System.CodeDom.Compiler.GeneratedCode("NHibernateModelGenerator", "1.0.0.0")]
  public partial class TblUserOfOwnerPortal
  {
    public virtual int OwnerUserId { get; set; }
    [NotNull]
    [Length(Max=50)]
    public virtual string OwnerUserEmail { get; set; }
    [NotNull]
    [Length(Max=20)]
    public virtual string OwnerPassword { get; set; }
    public virtual System.Nullable<System.DateTime> InviteExpires { get; set; }
    public virtual sbyte ActiveInd { get; set; }
    public virtual sbyte ForcePwChange { get; set; }

    private IList<TblOwner> _tblOwners = new List<TblOwner>();

    public virtual IList<TblOwner> TblOwners
    {
      get { return _tblOwners; }
      set { _tblOwners = value; }
    }

    private IList<TblSyndicateMember> _tblSyndicateMembers = new List<TblSyndicateMember>();

    public virtual IList<TblSyndicateMember> TblSyndicateMembers
    {
      get { return _tblSyndicateMembers; }
      set { _tblSyndicateMembers = value; }
    }

    static partial void CustomizeMappingDocument(System.Xml.Linq.XDocument mappingDocument);

    internal static System.Xml.Linq.XDocument MappingXml
    {
      get
      {
        var mappingDocument = System.Xml.Linq.XDocument.Parse(@"<?xml version='1.0' encoding='utf-8' ?>
<hibernate-mapping xmlns='urn:nhibernate-mapping-2.2'
                   assembly='" + typeof(TblUserOfOwnerPortal).Assembly.GetName().Name + @"'
                   namespace='EStable'
                   >
  <class name='TblUserOfOwnerPortal'
         table='`tbl_user_of_owner_portal`'
         >
    <id name='OwnerUserId'
        column='`Owner_User_ID`'
        >
      <generator class='hilo'>
        <param name='table'></param>
        <param name='column'></param>
        <param name='max_lo'>0</param>
      </generator>
    </id>
    <property name='OwnerUserEmail'
              column='`Owner_User_Email`'
              />
    <property name='OwnerPassword'
              column='`Owner_Password`'
              />
    <property name='InviteExpires'
              column='`Invite_Expires`'
              />
    <property name='ActiveInd'
              column='`Active_Ind`'
              />
    <property name='ForcePwChange'
              column='`Force_PW_Change`'
              />
    <bag name='TblOwners'
          inverse='false'
          >
      <key column='`Owner_User_ID`' />
      <one-to-many class='TblOwner' />
    </bag>
    <bag name='TblSyndicateMembers'
          inverse='true'
          >
      <key column='`Owner_User_ID`' />
      <one-to-many class='TblSyndicateMember' />
    </bag>
  </class>
</hibernate-mapping>");
        CustomizeMappingDocument(mappingDocument);
        return mappingDocument;
      }
    }
  }


}
