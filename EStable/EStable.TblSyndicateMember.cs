using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using NHibernate.Validator.Constraints;

namespace EStable
{
  [System.CodeDom.Compiler.GeneratedCode("NHibernateModelGenerator", "1.0.0.0")]
  public partial class TblSyndicateMember
  {
    public virtual int SyndicateMemberId { get; set; }
    public virtual int OwnerId { get; set; }
    public virtual int OwnerUserId { get; set; }
    [NotNull]
    [Length(Max=50)]
    public virtual string Name { get; set; }
    [NotNull]
    [Length(Max=50)]
    public virtual string SyndicateMemberEmail { get; set; }
    [Length(Max=20)]
    public virtual string PhoneDaytime { get; set; }
    [Length(Max=20)]
    public virtual string Mobile { get; set; }
    [Length(Max=20)]
    public virtual string PhoneNighttime { get; set; }
    public virtual string Address { get; set; }

    public virtual TblOwner Owner { get; set; }

    public virtual TblUserOfOwnerPortal OwnerUser { get; set; }

    static partial void CustomizeMappingDocument(System.Xml.Linq.XDocument mappingDocument);

    internal static System.Xml.Linq.XDocument MappingXml
    {
      get
      {
        var mappingDocument = System.Xml.Linq.XDocument.Parse(@"<?xml version='1.0' encoding='utf-8' ?>
<hibernate-mapping xmlns='urn:nhibernate-mapping-2.2'
                   assembly='" + typeof(TblSyndicateMember).Assembly.GetName().Name + @"'
                   namespace='EStable'
                   >
  <class name='TblSyndicateMember'
         table='`tbl_syndicate_member`'
         >
    <id name='SyndicateMemberId'
        column='`Syndicate_Member_ID`'
        >
      <generator class='hilo'>
        <param name='table'></param>
        <param name='column'></param>
        <param name='max_lo'>0</param>
      </generator>
    </id>
    <property name='OwnerId'
              column='`Owner_ID`'
              insert='false'
              update='false'
              />
    <property name='OwnerUserId'
              column='`Owner_User_ID`'
              insert='false'
              update='false'
              />
    <property name='Name'
              column='`Name`'
              />
    <property name='SyndicateMemberEmail'
              column='`Syndicate_Member_Email`'
              />
    <property name='PhoneDaytime'
              column='`Phone_Daytime`'
              />
    <property name='Mobile'
              column='`Mobile`'
              />
    <property name='PhoneNighttime'
              column='`Phone_Nighttime`'
              />
    <property name='Address'
              column='`Address`'
              />
    <many-to-one name='Owner' class='TblOwner' column='`Owner_ID`' />
    <many-to-one name='OwnerUser' class='TblUserOfOwnerPortal' column='`Owner_User_ID`' />
  </class>
</hibernate-mapping>");
        CustomizeMappingDocument(mappingDocument);
        return mappingDocument;
      }
    }
  }


}
