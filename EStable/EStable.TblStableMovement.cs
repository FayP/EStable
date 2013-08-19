using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using NHibernate.Validator.Constraints;

namespace EStable
{
  [System.CodeDom.Compiler.GeneratedCode("NHibernateModelGenerator", "1.0.0.0")]
  public partial class TblStableMovement
  {
    public virtual int StableAnimalId { get; set; }
    public virtual int StableChargeTypeId { get; set; }
    public virtual System.DateTime FromDate { get; set; }

    public virtual TblStableAnimal StableAnimal { get; set; }

    public virtual TblStableChargeType StableChargeType { get; set; }

    public override bool Equals(object obj)
    {
      if (obj == null || obj.GetType() != GetType())
      {
        return false;
      }

      TblStableMovement other = (TblStableMovement)obj;
      if (other.StableAnimalId != StableAnimalId)
      {
        return false;
      }
      if (other.StableChargeTypeId != StableChargeTypeId)
      {
        return false;
      }
      if (other.FromDate != FromDate)
      {
        return false;
      }
      return true;
    }

    public override int GetHashCode()
    {
      int hashCode = 0;
      hashCode = 19 * hashCode + StableAnimalId.GetHashCode();
      hashCode = 19 * hashCode + StableChargeTypeId.GetHashCode();
      hashCode = 19 * hashCode + FromDate.GetHashCode();
      return hashCode;
    }

    static partial void CustomizeMappingDocument(System.Xml.Linq.XDocument mappingDocument);

    internal static System.Xml.Linq.XDocument MappingXml
    {
      get
      {
        var mappingDocument = System.Xml.Linq.XDocument.Parse(@"<?xml version='1.0' encoding='utf-8' ?>
<hibernate-mapping xmlns='urn:nhibernate-mapping-2.2'
                   assembly='" + typeof(TblStableMovement).Assembly.GetName().Name + @"'
                   namespace='EStable'
                   >
  <class name='TblStableMovement'
         table='`tbl_stable_movement`'
         >
    <composite-id>
      <key-property name='StableAnimalId'
                    column='`Stable_Animal_ID`'
                    />
      <key-property name='StableChargeTypeId'
                    column='`Stable_Charge_Type_ID`'
                    />
      <key-property name='FromDate'
                    column='`From_Date`'
                    />
    </composite-id>
    <many-to-one name='StableAnimal' class='TblStableAnimal' column='`Stable_Animal_ID`' />
    <many-to-one name='StableChargeType' class='TblStableChargeType' column='`Stable_Charge_Type_ID`' />
  </class>
</hibernate-mapping>");
        CustomizeMappingDocument(mappingDocument);
        return mappingDocument;
      }
    }
  }


}
