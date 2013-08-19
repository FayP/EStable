using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using NHibernate.Validator.Constraints;

namespace EStable
{
  [System.CodeDom.Compiler.GeneratedCode("NHibernateModelGenerator", "1.0.0.0")]
  public partial class TblOwnership
  {
    public virtual int OwnerId { get; set; }
    public virtual int StableAnimalId { get; set; }
    public virtual double PcentOwned { get; set; }
    public virtual sbyte InvoiceInd { get; set; }
    public virtual string Comment { get; set; }

    public virtual TblOwner Owner { get; set; }

    public virtual TblStableAnimal StableAnimal { get; set; }

    public override bool Equals(object obj)
    {
      if (obj == null || obj.GetType() != GetType())
      {
        return false;
      }

      TblOwnership other = (TblOwnership)obj;
      if (other.OwnerId != OwnerId)
      {
        return false;
      }
      if (other.StableAnimalId != StableAnimalId)
      {
        return false;
      }
      return true;
    }

    public override int GetHashCode()
    {
      int hashCode = 0;
      hashCode = 19 * hashCode + OwnerId.GetHashCode();
      hashCode = 19 * hashCode + StableAnimalId.GetHashCode();
      return hashCode;
    }

    static partial void CustomizeMappingDocument(System.Xml.Linq.XDocument mappingDocument);

    internal static System.Xml.Linq.XDocument MappingXml
    {
      get
      {
        var mappingDocument = System.Xml.Linq.XDocument.Parse(@"<?xml version='1.0' encoding='utf-8' ?>
<hibernate-mapping xmlns='urn:nhibernate-mapping-2.2'
                   assembly='" + typeof(TblOwnership).Assembly.GetName().Name + @"'
                   namespace='EStable'
                   >
  <class name='TblOwnership'
         table='`tbl_ownership`'
         >
    <composite-id>
      <key-property name='OwnerId'
                    column='`Owner_ID`'
                    />
      <key-property name='StableAnimalId'
                    column='`Stable_Animal_ID`'
                    />
    </composite-id>
    <property name='PcentOwned'
              column='`Pcent_Owned`'
              />
    <property name='InvoiceInd'
              column='`Invoice_Ind`'
              />
    <property name='Comment'
              column='`Comment`'
              />
    <many-to-one name='Owner' class='TblOwner' column='`Owner_ID`' />
    <many-to-one name='StableAnimal' class='TblStableAnimal' column='`Stable_Animal_ID`' />
  </class>
</hibernate-mapping>");
        CustomizeMappingDocument(mappingDocument);
        return mappingDocument;
      }
    }
  }


}
