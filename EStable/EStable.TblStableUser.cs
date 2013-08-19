using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using NHibernate.Validator.Constraints;

namespace EStable
{
  [System.CodeDom.Compiler.GeneratedCode("NHibernateModelGenerator", "1.0.0.0")]
  public partial class TblStableUser
  {
    public virtual int UserId { get; set; }
    public virtual int StableId { get; set; }
    public virtual System.Nullable<System.DateTime> InviteExpires { get; set; }
    public virtual sbyte ActiveInd { get; set; }

    public virtual TblStable Stable { get; set; }

    public virtual TblUserOfStablePortal User { get; set; }

    public override bool Equals(object obj)
    {
      if (obj == null || obj.GetType() != GetType())
      {
        return false;
      }

      TblStableUser other = (TblStableUser)obj;
      if (other.UserId != UserId)
      {
        return false;
      }
      if (other.StableId != StableId)
      {
        return false;
      }
      return true;
    }

    public override int GetHashCode()
    {
      int hashCode = 0;
      hashCode = 19 * hashCode + UserId.GetHashCode();
      hashCode = 19 * hashCode + StableId.GetHashCode();
      return hashCode;
    }

    static partial void CustomizeMappingDocument(System.Xml.Linq.XDocument mappingDocument);

    internal static System.Xml.Linq.XDocument MappingXml
    {
      get
      {
        var mappingDocument = System.Xml.Linq.XDocument.Parse(@"<?xml version='1.0' encoding='utf-8' ?>
<hibernate-mapping xmlns='urn:nhibernate-mapping-2.2'
                   assembly='" + typeof(TblStableUser).Assembly.GetName().Name + @"'
                   namespace='EStable'
                   >
  <class name='TblStableUser'
         table='`tbl_stable_user`'
         >
    <composite-id>
      <key-property name='UserId'
                    column='`User_ID`'
                    />
      <key-property name='StableId'
                    column='`Stable_ID`'
                    />
    </composite-id>
    <property name='InviteExpires'
              column='`Invite_Expires`'
              />
    <property name='ActiveInd'
              column='`Active_Ind`'
              />
    <many-to-one name='Stable' class='TblStable' column='`Stable_ID`' />
    <many-to-one name='User' class='TblUserOfStablePortal' column='`User_ID`' />
  </class>
</hibernate-mapping>");
        CustomizeMappingDocument(mappingDocument);
        return mappingDocument;
      }
    }
  }


}
