using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using NHibernate.Validator.Constraints;

namespace EStable
{

  /// <summary>
  /// Provides a NHibernate configuration object containing mappings for this model.
  /// </summary>
  public static class ConfigurationHelper
  {
    /// <summary>
    /// Creates a NHibernate configuration object containing mappings for this model.
    /// </summary>
    /// <returns>A NHibernate configuration object containing mappings for this model.</returns>
    public static Configuration CreateConfiguration()
    {
      var configuration = new Configuration();
      configuration.Configure();
      ApplyConfiguration(configuration);
      return configuration;
    }

    /// <summary>
    /// Adds mappings for this model to a NHibernate configuration object.
    /// </summary>
    /// <param name="configuration">A NHibernate configuration object to which to add mappings for this model.</param>
    public static void ApplyConfiguration(Configuration configuration)
    {
      configuration.AddXml(ModelMappingXml.ToString());
      configuration.AddXml(TblOwner.MappingXml.ToString());
      configuration.AddXml(TblUserOfSupportPortal.MappingXml.ToString());
      configuration.AddXml(TblOwnership.MappingXml.ToString());
      configuration.AddXml(TblStable.MappingXml.ToString());
      configuration.AddXml(TblStableAnimal.MappingXml.ToString());
      configuration.AddXml(TblStableAnimalChargeNote.MappingXml.ToString());
      configuration.AddXml(TblStableChargeType.MappingXml.ToString());
      configuration.AddXml(TblStableMovement.MappingXml.ToString());
      configuration.AddXml(TblStableStandardCharge.MappingXml.ToString());
      configuration.AddXml(TblStableType.MappingXml.ToString());
      configuration.AddXml(TblStableTypeTranslation.MappingXml.ToString());
      configuration.AddXml(TblStableUser.MappingXml.ToString());
      configuration.AddXml(TblSyndicateMember.MappingXml.ToString());
      configuration.AddXml(TblUserOfOwnerPortal.MappingXml.ToString());
      configuration.AddXml(TblUserOfStablePortal.MappingXml.ToString());
      configuration.AddAssembly(typeof(ConfigurationHelper).Assembly);
    }

    /// <summary>
    /// Provides global mappings not associated with a specific entity.
    /// </summary>
    public static System.Xml.Linq.XDocument ModelMappingXml
    {
      get
      {
        var mappingDocument = System.Xml.Linq.XDocument.Parse(@"<?xml version='1.0' encoding='utf-8' ?>
<hibernate-mapping xmlns='urn:nhibernate-mapping-2.2'
                   assembly='" + typeof(ConfigurationHelper).Assembly.GetName().Name + @"'
                   namespace='EStable'
                   >
</hibernate-mapping>");
        return mappingDocument;
      }
    }
  }
}
