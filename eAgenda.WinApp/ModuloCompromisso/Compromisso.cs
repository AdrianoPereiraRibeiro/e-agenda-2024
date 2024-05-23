using eAgenda.ConsoleApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class Compromisso:EntidadeBase
    {
        
        public string Assunto { get; set; }
        public string Local { get; set; }
        public string Data { get; set; }
        public string Inicio { get; set; }
        public string Termino { get; set; }

        public Contato Contato { get; set; }
        public string Localizacao { get; set; }

        public Compromisso(string assunto, string local, string data, string inicio, string termino, Contato contato,  string localizacao)
        {
            Assunto = assunto;
            Local = local;
            Data = data;
            Inicio = inicio;
            Termino = termino;
            Contato = contato;
            Localizacao = localizacao;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Assunto.Trim()))
                erros.Add("O campo \"assunto\" é obrigatório");

            if (string.IsNullOrEmpty(Local.Trim()))
                erros.Add("O campo \"local\" é obrigatório");

            if (string.IsNullOrEmpty(Data.Trim()))
                erros.Add("O campo \"data\" é obrigatório");

            if (string.IsNullOrEmpty(Inicio.Trim()))
                erros.Add("O campo \"inicio\" é obrigatório");

            if (string.IsNullOrEmpty(Termino.Trim()))
                erros.Add("O campo \"termino\" é obrigatório");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Compromisso atualizado = (Compromisso)novoRegistro;

            Assunto = atualizado.Assunto;
            Local = atualizado.Local;
            Data = atualizado.Data;
            Inicio = atualizado.Inicio;
            Termino = atualizado.Termino;
            Contato = atualizado.Contato;
            Localizacao = atualizado.Localizacao;


        }

        public override string ToString()
        {
            return $"Id: {Id}, Assunto: {Assunto}, Local: {Local}, Localização: {Localizacao}, Data: {Data} Inicio: {Inicio}, Término: {Termino}, Contato: {Contato}";
        }
    }
}
