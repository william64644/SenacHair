using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Transactions;

namespace HappySmile
{
    public class Cabeleireiro
    {
        //Definimos as propriedades da classe
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public List<Especialidade> especialidades { get; set; }
        //Criamos o método construtor para definirmos valores
        //padrão para as propriedades no momento da instância do objeto
        public Cabeleireiro()
        {
            id = 0;
            nome = string.Empty;
            email = string.Empty;
            especialidades = new List<Especialidade>();
        }
        //Instanciamos os objetos necessários para
        //a comunicação entre o objeto criado e o banco de dados
        AcessoBD acesso = new AcessoBD();
        DataTable dt = new DataTable();
        List<SqlParameter> lista = new List<SqlParameter>();
        string sql = string.Empty;
        public DataTable Consultar()
        {
            //definimos um bloco try/catch para garantir a execução
            //do fluxo fora do nosso ambiente
            try
            {
                //Limpamos a lista de parâmetros
                lista.Clear();
                //Definimos o comando SQL (SELECT)
                sql = "select id, nome, email \n";
                sql += "from tblDentista \n";
                
                if (id != 0)
                {
                    //Caso o ID esteja preenchido
                    //Definimos a consulta pela chave primária
                    sql += "where id = @id \n";
                    //adicionamos o parâmetro à lista de parâmetros
                    lista.Add(new SqlParameter("@id", id));
                }                
                else if (nome != string.Empty)
                {
                    //Caso o nome esteja preenchido
                    //Definimos a consulta por aproximação através do nome
                    sql += "where nome like @nome \n";
                    //adicionamos o parâmetro à lista de parâmetros
                    lista.Add(new SqlParameter("@nome", "%" + nome + "%"));
                }
                //Ordenamos o retorno pelo nome do dentista
                sql += "order by nome";
                //Solicitamos ao objeto acesso a execução da consulta
                //E o resultado é armazenado no nosso DataTable (dt)
                dt = acesso.ConsultarSQL(sql, lista);
                
                if (id != 0)
                {
                    //Caso a pesquisa tenha sido efetuada pelo Id do dentista
                    //o retorno será de apenas 1 registro
                    //Atribuímos os valores retornados a sua respectiva
                    //propriedade da classe
                    id = Convert.ToInt32(dt.Rows[0]["id"]);
                    nome = dt.Rows[0]["nome"].ToString();
                    email = dt.Rows[0]["email"].ToString();
                    //Fazemos a consulta das especialidades
                    //Atribuídas ao dentista
                    CarregarEspecialidades();
                }
                //Retornamos o DataTable com os dentistas retornados na consulta
                return dt;
            }
            catch (Exception ex)
            {
                //Caso ocorra algum erro fora do ambiente
                //Enviamos o erro para quem chamou o método
                throw new Exception(ex.Message);
            }
        }
        private void CarregarEspecialidades()
        {
            //definimos um bloco try/catch para garantir a execução
            //do fluxo fora do nosso ambiente
            try
            {
                //Limpamos a lista de parâmetros
                lista.Clear();
                //Definimos o comando SQL (SELECT)
                sql = "select esp.id, esp.especialidade \n";
                sql += "from tblDentistaEspecialidade de \n";
                sql += "inner join tblEspecialidade esp \n";
                sql += "on esp.id = de.idEspecialidade \n";
                //Fazemos s busca pelo Id do dentista
                sql += "where idDentista = @idDentista";                
                //adicionamos o parâmetro à lista de parâmetros
                lista.Add(new SqlParameter("@idDentista", id));
                //Solicitamos ao objeto acesso a execução da consulta
                //E o resultado é armazenado no nosso DataTable (dt)
                dt = acesso.ConsultarSQL(sql, lista);
                //Limpamos a lista de especialidades
                especialidades.Clear();
                //Percorremos cada linha do DataTable
                foreach (DataRow linha in dt.Rows)
                {
                    //Instanciamos um objeto para armazenarmos
                    //os dados da especialidade
                    Especialidade e = new Especialidade();
                    e.id = Convert.ToInt32(linha["id"]);
                    e.especialidade = linha["especialidade"].ToString();
                    //Adicionamos este objeto à lista de especialidades
                    especialidades.Add(e);
                }
            }
            catch (Exception ex)
            {
                //Caso ocorra algum erro fora do ambiente
                //Enviamos o erro para quem chamou o método
                throw new Exception(ex.Message);
            }
        }
        public void Gravar()
        {
            //definimos um bloco try/catch para garantir a execução
            //do fluxo fora do nosso ambiente
            try
            {
                //Criamos uma transação para controlar a atuação do banco de dados
                //em mais de 1 entidade
                using (TransactionScope transacao = new TransactionScope())
                {

                    //Limpamos a lista de parâmetros
                    lista.Clear();
                    
                    if (id == 0)
                    {
                        //Caso seja um registro novo
                        //Montamos o INSERT
                        sql = "insert into tblDentista \n";
                        sql += "(nome, email)\n";
                        sql += "values \n";
                        sql += "(@nome, @email);";
                        sql += "select @@identity";
                    }
                    else
                    {
                        //Caso seja um registro já existente
                        //Montamos o UPDATE
                        sql = "update tblDentista\n";
                        sql += "set \n";
                        sql += "nome = @nome, \n";
                        sql += "email = @email \n";
                        sql += "where id  = @id \n";
                        //Adicionamos separadamente o Id do dentista
                        lista.Add(new SqlParameter("@id", id));
                    }
                    //Adicionamos em conjunto o restante dos parâmetros SQL
                    lista.Add(new SqlParameter("@nome", nome));
                    lista.Add(new SqlParameter("@email", email));

                    if (id == 0)
                    {
                        //Caso seja um novo registro, solicitamos ao acesso
                        //a execução do comando INSERT, juntamente com o comando
                        //select @@identity para buscarmos o novo id gerado
                        id = Convert.ToInt32(acesso.ExecutarSQL(lista, sql));
                    }
                    else
                    {
                        //Caso seja um registro já existente,
                        //apenas efetuamos o UPDATE
                        acesso.ExecutarSQL(sql, lista);
                        //limpamos a lista de parâmetros
                        lista.Clear();
                        //Montamos o comando SQL para remover as especialidade
                        //Definidas anteriormente
                        sql = "delete from tblDentistaEspecialidade \n";
                        sql += "where idDentista = @idDentista";
                        //Adicionamos o id do dentista como parâmetro
                        lista.Add(new SqlParameter("@idDentista", id));
                        //Solicitamos ao acesso para executar o comando junto ao banco de dados
                        acesso.ExecutarSQL(sql, lista);
                    }
                    //Percorremos todas as especialidade
                    //individualmente para serem inseridas no banco de dados
                    foreach (Especialidade e in especialidades)
                    {
                        //Limpamos a lista de parâmetros
                        lista.Clear();
                        //Montamos o comando SQL
                        sql = "insert into tblDentistaEspecialidade \n";
                        sql += "(idDentista, idEspecialidade) \n";
                        sql += "values \n";
                        sql += "(@idDentista, @idEspecialidade)";
                        //Adicionamos à lista de parâmetros o id do dentista
                        //e a especialidade que ele atua
                        lista.Add(new SqlParameter("@idDentista", id));
                        lista.Add(new SqlParameter("@idEspecialidade", e.id));
                        //Solicitamos ao acesso para executar o INSERT junto ao banco de dados
                        acesso.ExecutarSQL(sql, lista);
                    }
                    //confirmamos a execução dos comandos e efetivamos 
                    //as alterações no banco de dados
                    transacao.Complete();
                }
            }
            catch (Exception ex)
            {
                //Caso ocorra algum erro fora do ambiente
                //Enviamos o erro para quem chamou o método
                throw new Exception(ex.Message);
            }
        }
    }
}
