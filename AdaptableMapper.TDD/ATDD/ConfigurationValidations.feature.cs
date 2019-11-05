// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AdaptableMapper.TDD.ATDD
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ConfigurationValidationsFeature : Xunit.IClassFixture<ConfigurationValidationsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "ConfigurationValidations.feature"
#line hidden
        
        public ConfigurationValidationsFeature(ConfigurationValidationsFeature.FixtureData fixtureData, InternalSpecFlow.XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ConfigurationValidations", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Empty argument mappingConfiguration")]
        [Xunit.TraitAttribute("FeatureTitle", "ConfigurationValidations")]
        [Xunit.TraitAttribute("Description", "Empty argument mappingConfiguration")]
        public virtual void EmptyArgumentMappingConfiguration()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Empty argument mappingConfiguration", null, ((string[])(null)));
#line 3
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
 testRunner.Given("I create a mappingconfiguration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 5
 testRunner.When("I run Map with a null parameter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Type",
                            "Message"});
                table1.AddRow(new string[] {
                            "error",
                            "TREE#1; Argument cannot be null for MappingConfiguration.Map(string); objects:[]"});
#line 6
 testRunner.Then("the result should contain the following errors", ((string)(null)), table1, "Then ");
#line hidden
#line 9
 testRunner.Then("result should be null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Empty contextFactory mappingConfiguration")]
        [Xunit.TraitAttribute("FeatureTitle", "ConfigurationValidations")]
        [Xunit.TraitAttribute("Description", "Empty contextFactory mappingConfiguration")]
        public virtual void EmptyContextFactoryMappingConfiguration()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Empty contextFactory mappingConfiguration", null, ((string[])(null)));
#line 11
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 12
 testRunner.Given("I create a mappingconfiguration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 13
 testRunner.When("I run Map with a string parameter \'test\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Type",
                            "Message"});
                table2.AddRow(new string[] {
                            "error",
                            "TREE#2; ContextFactory cannot be null; objects:[]"});
                table2.AddRow(new string[] {
                            "error",
                            "TREE#5; MappingScope cannot be null; objects:[]"});
                table2.AddRow(new string[] {
                            "error",
                            "TREE#6; ObjectConverter cannot be null; objects:[]"});
#line 14
 testRunner.Then("the result should contain the following errors", ((string)(null)), table2, "Then ");
#line hidden
#line 19
 testRunner.Then("result should be null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Empty scoperoot empty factory nullconverter mappingConfiguration")]
        [Xunit.TraitAttribute("FeatureTitle", "ConfigurationValidations")]
        [Xunit.TraitAttribute("Description", "Empty scoperoot empty factory nullconverter mappingConfiguration")]
        public virtual void EmptyScoperootEmptyFactoryNullconverterMappingConfiguration()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Empty scoperoot empty factory nullconverter mappingConfiguration", null, ((string[])(null)));
#line 21
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 22
 testRunner.Given("I create a mappingconfiguration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 23
 testRunner.Given("I add a contextFactory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 24
 testRunner.Given("I add a MappingScopeRoot with an empty list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 25
 testRunner.Given("I add a NullObjectConverter for mappingConfiguration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 26
 testRunner.When("I run Map with a string parameter \'test\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Type",
                            "Message"});
                table3.AddRow(new string[] {
                            "error",
                            "TREE#3; ObjectConverter cannot be null; objects:[]"});
                table3.AddRow(new string[] {
                            "error",
                            "TREE#4; TargetInstantiator cannot be null; objects:[]"});
#line 27
 testRunner.Then("the result should contain the following errors", ((string)(null)), table3, "Then ");
#line hidden
#line 31
 testRunner.Then("result should be null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Empty scoperoot model to xml mappingConfiguration input empty string")]
        [Xunit.TraitAttribute("FeatureTitle", "ConfigurationValidations")]
        [Xunit.TraitAttribute("Description", "Empty scoperoot model to xml mappingConfiguration input empty string")]
        public virtual void EmptyScoperootModelToXmlMappingConfigurationInputEmptyString()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Empty scoperoot model to xml mappingConfiguration input empty string", null, ((string[])(null)));
#line 33
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 34
 testRunner.Given("I create a mappingconfiguration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 35
 testRunner.Given("I add a contextFactory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 36
 testRunner.Given("I add a ModelObjectConverter to the contextFactory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 37
 testRunner.Given("I add a \'Xml\' TargetInitiator with an empty string to the contextFactory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 38
 testRunner.Given("I add a MappingScopeRoot with an empty list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 39
 testRunner.Given("I add a XElementToStringObjectConverter for mappingConfiguration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 40
 testRunner.When("I run Map with a string parameter \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Type",
                            "Message"});
                table4.AddRow(new string[] {
                            "error",
                            "XML#6; Template is not valid Xml; objects:[\"XmlException\",\"Root element is missin" +
                                "g.\"]"});
                table4.AddRow(new string[] {
                            "error",
                            "MODEL#17; source is not of expected type Model; objects:[\"\"]"});
#line 41
 testRunner.Then("the result should contain the following errors", ((string)(null)), table4, "Then ");
#line hidden
#line 45
 testRunner.Then("result should be a \'<nullObject />\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Empty scoperoot json to model mappingConfiguration input empty string")]
        [Xunit.TraitAttribute("FeatureTitle", "ConfigurationValidations")]
        [Xunit.TraitAttribute("Description", "Empty scoperoot json to model mappingConfiguration input empty string")]
        public virtual void EmptyScoperootJsonToModelMappingConfigurationInputEmptyString()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Empty scoperoot json to model mappingConfiguration input empty string", null, ((string[])(null)));
#line 47
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 48
 testRunner.Given("I create a mappingconfiguration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 49
 testRunner.Given("I add a contextFactory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 50
 testRunner.Given("I add a JsonObjectConverter to the contextFactory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 51
 testRunner.Given("I add a \'Model\' TargetInitiator with an empty string to the contextFactory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 52
 testRunner.Given("I add a MappingScopeRoot with an empty list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 53
 testRunner.Given("I add a ModelToStringObjectConverter for mappingConfiguration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 54
 testRunner.When("I run Map with a string parameter \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "Type",
                            "Message"});
                table5.AddRow(new string[] {
                            "error",
                            "JSON#13; Source could not be parsed to JToken; objects:[\"\",\"JsonReaderException\"," +
                                "\"Error reading JToken from JsonReader. Path \'\', line 0, position 0.\"]"});
                table5.AddRow(new string[] {
                            "error",
                            "MODEL#24; assembly and typename could not be instantiated; objects:[\"\",\"\",\"Argume" +
                                "ntException\",\"String cannot have zero length.\"]"});
#line 55
 testRunner.Then("the result should contain the following errors", ((string)(null)), table5, "Then ");
#line hidden
#line 59
 testRunner.Then("result should be a \'{}\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Empty scoperoot xml to json mappingConfiguration input empty string")]
        [Xunit.TraitAttribute("FeatureTitle", "ConfigurationValidations")]
        [Xunit.TraitAttribute("Description", "Empty scoperoot xml to json mappingConfiguration input empty string")]
        public virtual void EmptyScoperootXmlToJsonMappingConfigurationInputEmptyString()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Empty scoperoot xml to json mappingConfiguration input empty string", null, ((string[])(null)));
#line 61
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 62
 testRunner.Given("I create a mappingconfiguration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 63
 testRunner.Given("I add a contextFactory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 64
 testRunner.Given("I add a XmlObjectConverter to the contextFactory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 65
 testRunner.Given("I add a \'Json\' TargetInitiator with an empty string to the contextFactory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 66
 testRunner.Given("I add a MappingScopeRoot with an empty list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 67
 testRunner.Given("I add a JtokenToStringObjectConverter for mappingConfiguration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 68
 testRunner.When("I run Map with a string parameter \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "Type",
                            "Message"});
                table6.AddRow(new string[] {
                            "error",
                            "XML#19; input could not be parsed to XElement; objects:[\"\",\"XmlException\",\"Root e" +
                                "lement is missing.\"]"});
                table6.AddRow(new string[] {
                            "error",
                            "JSON#20; Template could not be parsed to JToken; objects:[\"JsonReaderException\",\"" +
                                "Error reading JToken from JsonReader. Path \'\', line 0, position 0.\"]"});
#line 69
 testRunner.Then("the result should contain the following errors", ((string)(null)), table6, "Then ");
#line hidden
#line 73
 testRunner.Then("result should be a \'{}\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Empty scope xml to json mappingConfiguration input empty string")]
        [Xunit.TraitAttribute("FeatureTitle", "ConfigurationValidations")]
        [Xunit.TraitAttribute("Description", "Empty scope xml to json mappingConfiguration input empty string")]
        public virtual void EmptyScopeXmlToJsonMappingConfigurationInputEmptyString()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Empty scope xml to json mappingConfiguration input empty string", null, ((string[])(null)));
#line 75
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 76
 testRunner.Given("I create a mappingconfiguration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 77
 testRunner.Given("I add a contextFactory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 78
 testRunner.Given("I add a XmlObjectConverter to the contextFactory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 79
 testRunner.Given("I add a \'Json\' TargetInitiator with an empty string to the contextFactory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 80
 testRunner.Given("I add a MappingScopeRoot with an empty list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 81
 testRunner.Given("I add a Scope to the MappingScopeRoot list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 82
 testRunner.Given("I add a JtokenToStringObjectConverter for mappingConfiguration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 83
 testRunner.When("I run Map with a string parameter \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "Type",
                            "Message"});
                table7.AddRow(new string[] {
                            "error",
                            "XML#19; input could not be parsed to XElement; objects:[\"\",\"XmlException\",\"Root e" +
                                "lement is missing.\"]"});
                table7.AddRow(new string[] {
                            "error",
                            "JSON#20; Template could not be parsed to JToken; objects:[\"JsonReaderException\",\"" +
                                "Error reading JToken from JsonReader. Path \'\', line 0, position 0.\"]"});
#line 84
 testRunner.Then("the result should contain the following errors", ((string)(null)), table7, "Then ");
#line hidden
#line 88
 testRunner.Then("result should be a \'{}\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ConfigurationValidationsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ConfigurationValidationsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
