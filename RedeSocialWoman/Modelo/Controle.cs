using RedeSocialWoman.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocialWoman.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar (string login,string senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }
        public String cadastrar(String email,String senha,String confSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.cadastrar(email, senha, confSenha);
            if(loginDao.tem)//mensagem que vai vir e de sucesso
            {
                this.tem = true;
            }
            
            
            return mensagem;
        }
    }



}
