﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace Vault.Data.Models
{

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
  public partial class id
  {

    private string extensionField;

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
  public partial class addr
  {

    private string streetAddressLineField;

    private string cityField;

    private string stateField;

    private string postalCodeField;

    private string countryField;

    private string useField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string streetAddressLine
    {
      get
      {
        return this.streetAddressLineField;
      }
      set
      {
        this.streetAddressLineField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string city
    {
      get
      {
        return this.cityField;
      }
      set
      {
        this.cityField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string state
    {
      get
      {
        return this.stateField;
      }
      set
      {
        this.stateField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string postalCode
    {
      get
      {
        return this.postalCodeField;
      }
      set
      {
        this.postalCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string country
    {
      get
      {
        return this.countryField;
      }
      set
      {
        this.countryField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string use
    {
      get
      {
        return this.useField;
      }
      set
      {
        this.useField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
  public partial class telecom
  {

    private string valueField;

    private string useField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string use
    {
      get
      {
        return this.useField;
      }
      set
      {
        this.useField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
  public partial class recordTarget
  {

    private object[] itemsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("addr", typeof(addr))]
    [System.Xml.Serialization.XmlElementAttribute("id", typeof(id))]
    [System.Xml.Serialization.XmlElementAttribute("patientRole", typeof(recordTargetPatientRole), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("telecom", typeof(telecom))]
    public object[] Items
    {
      get
      {
        return this.itemsField;
      }
      set
      {
        this.itemsField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class recordTargetPatientRole
  {

    private id[] idField;

    private addr[] addrField;

    private telecom[] telecomField;

    private recordTargetPatientRolePatient[] patientField;

    private recordTargetPatientRoleProviderOrganization[] providerOrganizationField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("id")]
    public id[] id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("addr")]
    public addr[] addr
    {
      get
      {
        return this.addrField;
      }
      set
      {
        this.addrField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("telecom")]
    public telecom[] telecom
    {
      get
      {
        return this.telecomField;
      }
      set
      {
        this.telecomField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("patient", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public recordTargetPatientRolePatient[] patient
    {
      get
      {
        return this.patientField;
      }
      set
      {
        this.patientField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("providerOrganization", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public recordTargetPatientRoleProviderOrganization[] providerOrganization
    {
      get
      {
        return this.providerOrganizationField;
      }
      set
      {
        this.providerOrganizationField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class recordTargetPatientRolePatient
  {

    private recordTargetPatientRolePatientName[] nameField;

    private recordTargetPatientRolePatientAdministrativeGenderCode[] administrativeGenderCodeField;

    private recordTargetPatientRolePatientBirthTime[] birthTimeField;

    private recordTargetPatientRolePatientRaceCode[] raceCodeField;

    private recordTargetPatientRolePatientEthnicGroupCode[] ethnicGroupCodeField;

    private recordTargetPatientRolePatientLanguageCommunication[] languageCommunicationField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("name", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public recordTargetPatientRolePatientName[] name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("administrativeGenderCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public recordTargetPatientRolePatientAdministrativeGenderCode[] administrativeGenderCode
    {
      get
      {
        return this.administrativeGenderCodeField;
      }
      set
      {
        this.administrativeGenderCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("birthTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public recordTargetPatientRolePatientBirthTime[] birthTime
    {
      get
      {
        return this.birthTimeField;
      }
      set
      {
        this.birthTimeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("raceCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public recordTargetPatientRolePatientRaceCode[] raceCode
    {
      get
      {
        return this.raceCodeField;
      }
      set
      {
        this.raceCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ethnicGroupCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public recordTargetPatientRolePatientEthnicGroupCode[] ethnicGroupCode
    {
      get
      {
        return this.ethnicGroupCodeField;
      }
      set
      {
        this.ethnicGroupCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("languageCommunication", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public recordTargetPatientRolePatientLanguageCommunication[] languageCommunication
    {
      get
      {
        return this.languageCommunicationField;
      }
      set
      {
        this.languageCommunicationField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class recordTargetPatientRolePatientName
  {

    private string familyField;

    private string givenField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string family
    {
      get
      {
        return this.familyField;
      }
      set
      {
        this.familyField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string given
    {
      get
      {
        return this.givenField;
      }
      set
      {
        this.givenField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class recordTargetPatientRolePatientAdministrativeGenderCode
  {

    private string codeField;

    private string codeSystemField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class recordTargetPatientRolePatientBirthTime
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class recordTargetPatientRolePatientRaceCode
  {

    private string codeSystemField;

    private string codeField;

    private string displayNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class recordTargetPatientRolePatientEthnicGroupCode
  {

    private string codeSystemField;

    private string codeField;

    private string displayNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class recordTargetPatientRolePatientLanguageCommunication
  {

    private recordTargetPatientRolePatientLanguageCommunicationTemplateId[] templateIdField;

    private recordTargetPatientRolePatientLanguageCommunicationLanguageCode[] languageCodeField;

    private recordTargetPatientRolePatientLanguageCommunicationPreferenceInd[] preferenceIndField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("templateId", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public recordTargetPatientRolePatientLanguageCommunicationTemplateId[] templateId
    {
      get
      {
        return this.templateIdField;
      }
      set
      {
        this.templateIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("languageCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public recordTargetPatientRolePatientLanguageCommunicationLanguageCode[] languageCode
    {
      get
      {
        return this.languageCodeField;
      }
      set
      {
        this.languageCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("preferenceInd", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public recordTargetPatientRolePatientLanguageCommunicationPreferenceInd[] preferenceInd
    {
      get
      {
        return this.preferenceIndField;
      }
      set
      {
        this.preferenceIndField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class recordTargetPatientRolePatientLanguageCommunicationTemplateId
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class recordTargetPatientRolePatientLanguageCommunicationLanguageCode
  {

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class recordTargetPatientRolePatientLanguageCommunicationPreferenceInd
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public partial class recordTargetPatientRoleProviderOrganization
  {

    private string nameField;

    private id[] idField;

    private telecom[] telecomField;

    private addr[] addrField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("id")]
    public id[] id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("telecom")]
    public telecom[] telecom
    {
      get
      {
        return this.telecomField;
      }
      set
      {
        this.telecomField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("addr")]
    public addr[] addr
    {
      get
      {
        return this.addrField;
      }
      set
      {
        this.addrField = value;
      }
    }
  }
}