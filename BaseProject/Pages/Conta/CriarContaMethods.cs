using System;
using ValTestAT.Base;

namespace ValTestAT
{
	partial class CriarConta : BasePage
	{
		

		public void SelecionarTipoHCP(string hcp)
		{
			string tipoHCP = hcp.Substring(hcp.IndexOf("(") + 1, 3);
			SelectDropDownValue(FindById(TipoHCP), tipoHCP);
		}

		public void SelecionarEstado(string uf)
		{
			SelectDropDownValue(FindById(UF), uf);
		}

		public void PreencherNumeroRegistro(string numeroRegistro)
		{
			EnterTextInto(FindById(NumeroRegistro), numeroRegistro);
		}

		public void PreencherRegistroNumeroAleatorio()
		{
			Random rdm = new Random();
			string numReg = rdm.Next(9999).ToString();
			PreencherNumeroRegistro(numReg);
		}

		public void PreencherCampoEmail(string email)
		{
			EnterTextInto(FindByXPath(CampoEmail), email);
		}

		public void PreencherEmailAleatorio()
		{
			string emailAleatorio = DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + "@server.com";
			PreencherCampoEmail(emailAleatorio);
		}

		public void AceitarTermosECondicoes()
		{
			Click(FindById(TermosCheckBox));
		}

		public void ClicarContinuar()
		{
			Click(FindById(BotaoContinuar));
		}

		public void PreencherNome(string nome)
		{
			EnterTextInto(FindById(CampoNome), nome);
		}

		public void PreencherSobreNome(string sobreNome)
		{
			EnterTextInto(FindById(CampoSobrenome), sobreNome);
		}

		public void PreencherCelular(string cel)
		{
			EnterTextInto(FindById(CampoCelular), cel);
		}

		public void PreencherAdcionarSenha(string senha)
		{
			EnterTextInto(FindById(CampoAdicionarSenha), senha);
		}

		public void PreencherRepetirSenha(string senha)
		{
			EnterTextInto(FindById(CampoRepetirSenha), senha);
		}

		public void VerificarMensagemSucesso(string msg)
		{
			CheckElementText(FindByXPath(MensagemSucesso), msg);
		}

		public void ClicarSim()
		{
			SelectRadioButton(FindById("sf-is-hcp"));
		}

		public void ValidarUsuario(string user)
		{
			ClicarSim();
			ClicarContinuar();
			string[] userInfo = user.Split(',');
			SelecionarTipoHCP(userInfo[0]);
			SelecionarEstado(userInfo[1]);
			PreencherNumeroRegistro(userInfo[2]);
			PreencherCampoEmail(userInfo[3]);
			AceitarTermosECondicoes();
			ClicarContinuar();
		}
	}
}