using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using NHibernate.Validator.Constraints;

namespace EStable
{
  [System.CodeDom.Compiler.GeneratedCode("NHibernateModelGenerator", "1.0.0.0")]
  public partial class TblStableChargeType
  {
    public virtual int StableChargeTypeId { get; set; }
    public virtual int StableId { get; set; }
    [NotNull]
    [Length(Max=50)]
    public virtual string ChargeType { get; set; }
    public virtual char InOutOfStable { get; set; }
    public virtual System.Nullable<decimal> ChargeRate { get; set; }
    [NotNull]
    [Length(Max=10)]
    public virtual string ChargingUnit { get; set; }

    private IList<TblStableMovement> _tblStableMovements = new List<TblStableMovement>();

    public virtual IList<TblStableMovement> TblStableMovements
    {
      get { return _tblStableMovements; }
      set { _tblStableMovements = value; }
    }

    public virtual TblStable Stable { get; set; }

    static partial void CustomizeMappingDocument(System.Xml.Linq.XDocument mappingDocument);

    internal static System.Xml.Linq.XDocument MappingXml
    {
      get
      {
        var mappingDocument = System.Xml.Linq.XDocument.Parse(@"<?xml version='1.0' encoding='utf-8' ?>
<hibernate-mapping xmlns='urn:nhibernate-mapping-2.2'
                   assembly='" + typeof(TblStableChargeType).Assembly.GetName().Name + @"'
                   namespace='EStable'
                   >
  <class name='TblStableChargeType'
         table='`tbl_stable_charge_type`'
         >
    <id name='StableChargeTypeId'
        column='`Stable_Charge_Type_ID`'
        >
      <generator class='hilo'>
        <param name='table'></param>
        <param name='column'></param>
        <param name='max_lo'>0</param>
      </generator>
    </id>
    <property name='StableId'
              column='`Stable_ID`'
              insert='false'
              update='false'
              />
    <property name='ChargeType'
              column='`Charge_Type`'
              />
    <property name='InOutOfStable'
              column='`In_Out_of_Stable`'
              />
    <property name='ChargeRate'
              column='`Charge_Rate`'
              />
    <property name='ChargingUnit'
              column='`Charging_Unit`'
              />
    <bag name='TblStableMovements'
          inverse='true'
          >
      <key column='`Stable_Charge_Type_ID`' />
      <one-to-many class='TblStableMovement' />
    </bag>
    <many-to-one name='Stable' class='TblStable' column='`Stable_ID`' />
  </class>
</hibernate-mapping>");
        CustomizeMappingDocument(mappingDocument);
        return mappingDocument;
      }
    }
  }


}
