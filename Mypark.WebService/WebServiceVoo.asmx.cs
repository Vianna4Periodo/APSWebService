using MyPark.Model.DataBase;
using MyPark.Model.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Mypark.WebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://gerenciavoos.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        // -- Voos

        [WebMethod]
        public List<Voo> ConsultarVoos()
        {
            return DbFactory.Instance.VooRepository.FindAll().ToList();
        }

        [WebMethod]
        public Voo CadastroVoo(Voo voo)
        {
            voo = DbFactory.Instance.VooRepository.Save(voo);
            return voo;
        }

        [WebMethod]
        public Voo AtualizarVoo(Voo voo)
        {
            var t = DbFactory.Instance.VooRepository.SaveOrUpdate(voo);

            if (voo == null)
            {
                t.Aeronave = voo.Aeronave;
                t.Numero = voo.Numero;
                t.Hora = voo.Hora;
                t.Destino = voo.Destino;
                t.QtdAssentos = voo.QtdAssentos;
                t.Preco = voo.Preco;
            }
            else {
                t = DbFactory.Instance.VooRepository.Save(t);
            }

            return t;
        }

        // -- Passagens

        [WebMethod]
        public bool ComprarBilhete(int NumeroVoo, int QtdPassagens)
        {
            var voo = DbFactory.Instance.VooRepository.FindByNumero(NumeroVoo);

            if (voo == null)
                throw new Exception("Não foi possível comprar as passagens pois o voo não existe.");

            if (!voo.IsPossibleAddPassagem)
                throw new Exception("Não é possível comprar as passagens, pois não existem lugares disponíveis no voo.");

            if (QtdPassagens > voo.AssentosDisponiveis)
                throw new Exception("Não é possível comprar as passagens, pois restam somente " + voo.AssentosDisponiveis + " assentos disponíveis.");

            for (int i = 0; i < QtdPassagens; i++)
            {
                var passagem = new Passagem();
                passagem.Voo = voo;
                voo.Passagens.Add(passagem);
                DbFactory.Instance.VooRepository.SaveOrUpdate(voo);
            }

            return true;
        }

        [WebMethod]
        public List<Passagem> ConsultarBilhetes()
        {
            return DbFactory.Instance.PassagemRepository.FindAll().ToList();
        }

        [WebMethod]
        public bool DevolverBilhete(Guid id)
        {
            var passagem = DbFactory.Instance.PassagemRepository.FindFirstById(id);

            if (passagem == null)
                return false;

            DbFactory.Instance.PassagemRepository.Delete(passagem);

            return true;
        }

    }
}
