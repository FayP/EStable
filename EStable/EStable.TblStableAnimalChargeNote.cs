using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using NHibernate.Validator.Constraints;

namespace EStable
{
  [System.CodeDom.Compiler.GeneratedCode("NHibernateModelGenerator", "1.0.0.0")]
  public partial class TblStableAnimalChargeNote
  {
    public virtual int StableAnimalChargeNoteId { get; set; }
    public virtual int StableAnimalId { get; set; }
    public virtual System.DateTime EventDate { get; set; }
    [NotNull]
    [Length(Max=50)]
    public virtual string ChargeDescription { get; set; }
    public virtual System.Nullable<decimal> Value { get; set; }

    public virtual TblStableAnimal StableAnimal { get; set; }

    static partial void CustomizeMappingDocument(System.Xml.Linq.XDocument mappingDocument);

    internal static System.Xml.Linq.XDocument MappingXml
    {
      get
      {
        var mappingDocument = System.Xml.Linq.XDocument.Parse(@"<?xml version='1.0' encoding='utf-8' ?>
<hibernate-mapping xmlns='urn:nhibernate-mapping-2.2'
                   assembly='" + typeof(TblStableAnimalChargeNote).Assembly.GetName().Name + @"'
                   namespace='EStable'
                   >
  <class name='TblStableAnimalChargeNote'
         table='`tbl_stable_animal_charge_note`'
         >
    <id name='StableAnimalChargeNoteId'
        column='`Stable_Animal_Charge_Note_ID`'
        >
      <generator class='hilo'>
        <param name='table'></param>
        <param name='column'></param>
        <param name='max_lo'>0</param>
      </generator>
    </id>
    <property name='StableAnimalId'
              column='`Stable_Animal_ID`'
              insert='false'
              update='false'
              />
    <property name='EventDate'
              column='`Event_Date`'
              />
    <property name='ChargeDescription'
              column='`Charge_Description`'
              />
    <property name='Value'
              column='`Value`'
              />
    <many-to-one name='StableAnimal' class='TblStableAnimal' column='`Stable_Animal_ID`' />
  </class>
</hibernate-mapping>");
        CustomizeMappingDocument(mappingDocument);
        return mappingDocument;
      }
    }
  }


}
