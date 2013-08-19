using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using NHibernate.Validator.Constraints;

namespace EStable
{
  [System.CodeDom.Compiler.GeneratedCode("NHibernateModelGenerator", "1.0.0.0")]
  public partial class TblStable
  {
    public virtual int StableId { get; set; }
    public virtual int StableTypeId { get; set; }
    public virtual int CountryCode { get; set; }
    [NotNull]
    [Length(Max=50)]
    public virtual string StableName { get; set; }
    [NotNull]
    [Length(Max=50)]
    public virtual string Trainer { get; set; }
    [NotNull]
    [Length(Max=50)]
    public virtual string LegalName { get; set; }
    public virtual string Address { get; set; }
    [Length(Max=20)]
    public virtual string Mobile { get; set; }
    [Length(Max=20)]
    public virtual string Phone { get; set; }
    [Length(Max=20)]
    public virtual string Fax { get; set; }
    [Length(Max=20)]
    public virtual string GstVatTaxNumber { get; set; }
    public virtual System.Nullable<double> GstRateCurrent { get; set; }
    public virtual System.Nullable<System.DateTime> GstEffectiveDate { get; set; }
    public virtual System.Nullable<double> GstRatePrevious { get; set; }
    public virtual int NextInvoice { get; set; }

    private IList<TblStableAnimal> _tblStableAnimals = new List<TblStableAnimal>();

    public virtual IList<TblStableAnimal> TblStableAnimals
    {
      get { return _tblStableAnimals; }
      set { _tblStableAnimals = value; }
    }

    private IList<TblStableChargeType> _tblStableChargeTypes = new List<TblStableChargeType>();

    public virtual IList<TblStableChargeType> TblStableChargeTypes
    {
      get { return _tblStableChargeTypes; }
      set { _tblStableChargeTypes = value; }
    }

    private IList<TblStableStandardCharge> _tblStableStandardCharges = new List<TblStableStandardCharge>();

    public virtual IList<TblStableStandardCharge> TblStableStandardCharges
    {
      get { return _tblStableStandardCharges; }
      set { _tblStableStandardCharges = value; }
    }

    private IList<TblStableUser> _tblStableUsers = new List<TblStableUser>();

    public virtual IList<TblStableUser> TblStableUsers
    {
      get { return _tblStableUsers; }
      set { _tblStableUsers = value; }
    }

    public virtual TblStableType StableType { get; set; }

    static partial void CustomizeMappingDocument(System.Xml.Linq.XDocument mappingDocument);

    internal static System.Xml.Linq.XDocument MappingXml
    {
      get
      {
        var mappingDocument = System.Xml.Linq.XDocument.Parse(@"<?xml version='1.0' encoding='utf-8' ?>
<hibernate-mapping xmlns='urn:nhibernate-mapping-2.2'
                   assembly='" + typeof(TblStable).Assembly.GetName().Name + @"'
                   namespace='EStable'
                   >
  <class name='TblStable'
         table='`tbl_stable`'
         >
    <id name='StableId'
        column='`Stable_ID`'
        >
      <generator class='hilo'>
        <param name='table'></param>
        <param name='column'></param>
        <param name='max_lo'>0</param>
      </generator>
    </id>
    <property name='StableTypeId'
              column='`Stable_Type_ID`'
              insert='false'
              update='false'
              />
    <property name='CountryCode'
              column='`Country_Code`'
              />
    <property name='StableName'
              column='`Stable_Name`'
              />
    <property name='Trainer'
              column='`Trainer`'
              />
    <property name='LegalName'
              column='`Legal_Name`'
              />
    <property name='Address'
              column='`Address`'
              />
    <property name='Mobile'
              column='`Mobile`'
              />
    <property name='Phone'
              column='`Phone`'
              />
    <property name='Fax'
              column='`Fax`'
              />
    <property name='GstVatTaxNumber'
              column='`GST_VAT_TAX_Number`'
              />
    <property name='GstRateCurrent'
              column='`GST_Rate_Current`'
              />
    <property name='GstEffectiveDate'
              column='`GST_Effective_Date`'
              />
    <property name='GstRatePrevious'
              column='`GST_Rate_Previous`'
              />
    <property name='NextInvoice'
              column='`Next_Invoice`'
              />
    <bag name='TblStableAnimals'
          inverse='true'
          >
      <key column='`Stable_ID`' />
      <one-to-many class='TblStableAnimal' />
    </bag>
    <bag name='TblStableChargeTypes'
          inverse='true'
          >
      <key column='`Stable_ID`' />
      <one-to-many class='TblStableChargeType' />
    </bag>
    <bag name='TblStableStandardCharges'
          inverse='true'
          >
      <key column='`Stable_ID`' />
      <one-to-many class='TblStableStandardCharge' />
    </bag>
    <bag name='TblStableUsers'
          inverse='true'
          >
      <key column='`Stable_ID`' />
      <one-to-many class='TblStableUser' />
    </bag>
    <many-to-one name='StableType' class='TblStableType' column='`Stable_Type_ID`' />
  </class>
</hibernate-mapping>");
        CustomizeMappingDocument(mappingDocument);
        return mappingDocument;
      }
    }
  }


}
