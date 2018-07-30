﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Banco.Aceitacao.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ContaCorrenteFeature : Xunit.IClassFixture<ContaCorrenteFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "ContaFeature.feature"
#line hidden
        
        public ContaCorrenteFeature(ContaCorrenteFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Conta Corrente", "\tUma conta corrente passando por diversas\r\n\toperacoes e validando seus comportame" +
                    "ntos", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Deposito em conta")]
        [Xunit.TraitAttribute("FeatureTitle", "Conta Corrente")]
        [Xunit.TraitAttribute("Description", "Deposito em conta")]
        [Xunit.TraitAttribute("Category", "TesteAceitacaoContaCorrente")]
        public virtual void DepositoEmConta()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deposito em conta", new string[] {
                        "TesteAceitacaoContaCorrente"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("que uma conta esteja ativa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 9
 testRunner.And("que esteja sem saldo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Valor"});
            table1.AddRow(new string[] {
                        "500"});
#line 10
 testRunner.When("For realizado o deposito de um valor", ((string)(null)), table1, "Quando ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "SaldoDisponivel"});
            table2.AddRow(new string[] {
                        "500"});
#line 13
 testRunner.Then("O saldo disponivel deve o mesmo que o depositado", ((string)(null)), table2, "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ContaCorrenteFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ContaCorrenteFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion