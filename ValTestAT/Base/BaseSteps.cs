using ValTestAT.Config;

namespace ValTestAT.Base
{
	public class BaseSteps : Base
	{

		public virtual void NavigateToHome()
		{
			NavigateTo(Configurations.URL);
		}
	}
}
