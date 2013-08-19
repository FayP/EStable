using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using NHibernate.Validator.Constraints;

namespace EStable
{
  [System.CodeDom.Compiler.GeneratedCode("NHibernateModelGenerator", "1.0.0.0")]
  public partial class TblOwner
  {
    public virtual int OwnerId { get; set; }
    [NotNull]
    [Length(Max=50)]
    public virtual string OwnerName { get; set; }
    [NotNull]
    [Length(Max=50)]
    public virtual string OwnerEmail { get; set; }
    public virtual System.Nullable<int> OwnerUserId { get; set; }
    public virtual System.Nullable<sbyte> SyndicatePersonInd { get; set; }
    [Length(Max=30)]
    public virtual string SyndicateName { get; set; }
    [NotNull]
    public virtual string Address { get; set; }
    [Length(Max=20)]
    public virtual string PhoneDaytime { get; set; }
    [Length(Max=20)]
    public virtual string PhoneNighttime { get; set; }
    [Length(Max=20)]
    public virtual string Mobile { get; set; }
    public virtual string InternalComments { get; set; }

    private IList<TblOwnership> _tblOwnerships = new List<TblOwnership>();

    public virtual IList<TblOwnership> TblOwnerships
    {
      get { return _tblOwnerships; }
      set { _tblOwnerships = value; }
    }

    private IList<TblSyndicateMember> _tblSyndicateMembers = new List<TblSyndicateMember>();

    public virtual IList<TblSyndicateMember> TblSyndicateMembers
    {
      get { return _tblSyndicateMembers; }
      set { _tblSyndicateMembers = value; }
    }

    public virtual TblUserOfOwnerPortal OwnerUser { get; set; }

    static partial void CustomizeMappingDocument(System.Xml.Linq.XDocument mappingDocument);

    internal static System.Xml.Linq.XDocument MappingXml
    {
      get
      {
        var mappingDocument = System.Xml.Linq.XDocument.Parse(@"<?xml version='1.0' encoding='utf-8' ?>
<hibernate-mapping xmlns='urn:nhibernate-mapping-2.2'
                   assembly='" + typeof(TblOwner).Assembly.GetName().Name + @"'
                   namespace='EStable'
                   >
  <class name='TblOwner'
         table='`tbl_owner`'
         >
    <id name='OwnerId'
        column='`Owner_ID`'
        >
      <generator class='hilo'>
        <param name='table'></param>
        <param name='column'></param>
        <param name='max_lo'>0</param>
      </generator>
    </id>
    <property name='OwnerName'
              column='`Owner_Name`'
              />
    <property name='OwnerEmail'
              column='`Owner_Email`'
              />
    <property name='OwnerUserId'
              column='`Owner_User_ID`'
              insert='false'
              update='false'
              />
    <property name='SyndicatePersonInd'
              column='`Syndicate_Person_Ind`'
              />
    <property name='SyndicateName'
              column='`Syndicate_Name`'
              />
    <property name='Address'
              column='`Address`'
              />
    <property name='PhoneDaytime'
              column='`Phone_Daytime`'
              />
    <property name='PhoneNighttime'
              column='`Phone_Nighttime`'
              />
    <property name='Mobile'
              column='`Mobile`'
              />
    <property name='InternalComments'
              column='`Internal_Comments`'
              />
    <bag name='TblOwnerships'
          inverse='true'
          >
      <key column='`Owner_ID`' />
      <one-to-many class='TblOwnership' />
    </bag>
    <bag name='TblSyndicateMembers'
          inverse='true'
          >
      <key column='`Owner_ID`' />
      <one-to-many class='TblSyndicateMember' />
    </bag>
    <many-to-one name='OwnerUser' class='TblUserOfOwnerPortal' column='`Owner_User_ID`' />
  </class>
</hibernate-mapping>");
        CustomizeMappingDocument(mappingDocument);
        return mappingDocument;
      }
    }
  }


}
