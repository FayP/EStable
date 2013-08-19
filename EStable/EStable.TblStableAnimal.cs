using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using NHibernate.Validator.Constraints;

namespace EStable
{
  [System.CodeDom.Compiler.GeneratedCode("NHibernateModelGenerator", "1.0.0.0")]
  public partial class TblStableAnimal
  {
    public virtual int StableAnimalId { get; set; }
    public virtual int StableId { get; set; }
    [Length(Max=50)]
    public virtual string StableName { get; set; }
    [Length(Max=50)]
    public virtual string RacingName { get; set; }
    [NotNull]
    [Length(Max=50)]
    public virtual string Sire { get; set; }
    [NotNull]
    [Length(Max=50)]
    public virtual string Dam { get; set; }
    [Length(Max=50)]
    public virtual string Gender { get; set; }
    public virtual System.Nullable<System.DateTime> Dob { get; set; }
    [Length(Max=50)]
    public virtual string Colour { get; set; }
    [Length(Max=50)]
    public virtual string Markings { get; set; }

    private IList<TblOwnership> _tblOwnerships = new List<TblOwnership>();

    public virtual IList<TblOwnership> TblOwnerships
    {
      get { return _tblOwnerships; }
      set { _tblOwnerships = value; }
    }

    private IList<TblStableAnimalChargeNote> _tblStableAnimalChargeNotes = new List<TblStableAnimalChargeNote>();

    public virtual IList<TblStableAnimalChargeNote> TblStableAnimalChargeNotes
    {
      get { return _tblStableAnimalChargeNotes; }
      set { _tblStableAnimalChargeNotes = value; }
    }

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
                   assembly='" + typeof(TblStableAnimal).Assembly.GetName().Name + @"'
                   namespace='EStable'
                   >
  <class name='TblStableAnimal'
         table='`tbl_stable_animal`'
         >
    <id name='StableAnimalId'
        column='`Stable_Animal_ID`'
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
    <property name='StableName'
              column='`Stable_Name`'
              />
    <property name='RacingName'
              column='`Racing_Name`'
              />
    <property name='Sire'
              column='`Sire`'
              />
    <property name='Dam'
              column='`Dam`'
              />
    <property name='Gender'
              column='`Gender`'
              />
    <property name='Dob'
              column='`DOB`'
              />
    <property name='Colour'
              column='`Colour`'
              />
    <property name='Markings'
              column='`Markings`'
              />
    <bag name='TblOwnerships'
          inverse='true'
          >
      <key column='`Stable_Animal_ID`' />
      <one-to-many class='TblOwnership' />
    </bag>
    <bag name='TblStableAnimalChargeNotes'
          inverse='true'
          >
      <key column='`Stable_Animal_ID`' />
      <one-to-many class='TblStableAnimalChargeNote' />
    </bag>
    <bag name='TblStableMovements'
          inverse='true'
          >
      <key column='`Stable_Animal_ID`' />
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
