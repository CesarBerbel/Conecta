using TechTalk.SpecFlow;
using ValTestAT;
using ValTestAT.Base;

namespace BaseProject.Steps
{
	[Binding]
    public class CampanhasSteps : BaseSteps
    {
        [When(@"eu acesso a campanha ""(.*)""")]
        public void QuandoEuAcessoACampanha(string url)
        {  
			GetInstance<CampanhaPage>().AcessarCampanha(url);
		}
    }
}