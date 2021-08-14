using System;
using System.Threading.Tasks;

namespace FluentFlow.Sample
{
    // (Given) some context
    // (When) some action is carried out
    // (Then) a particular set of observable consequences should obtain

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Context
                .With(x => { })
                
                .Given("Verifica se a requisição é válida")
                .When(ValidateRequest)
                .Then("")
                .OnError("")
                .Execute()

                .Given("Verifica se o E-mail já está cadastrado")
                .When("")
                .Then("")
                .OnError("")
                .Execute()
                
                .Given("Gera as entidades")
                .When("")
                .Then("")
                .OnError("")
                .Execute()
                
                .Given("Persiste os dados do usuário")
                .When("")
                .Then("")
                .OnError("")
                .Execute()
                
                .Given("Persiste os dados do aluno")
                .When("")
                .Then("")
                .OnError("")
                .Execute()
                
                .Given("Gera um código de ativação")
                .When("")
                .Then("")
                .OnError("")
                .Execute()
                
                .Given("Envia o código por E-mail")
                .When("")
                .Then("")
                .OnError("")
                .Execute()
                
                .Given("Notifica marketing sobre a nova conta")
                .When("")
                .Then("")
                .OnError("")
                .Execute()
                
                .Given("Retorna resposta de boas vindas")
                .When("")
                .Then("")
                .OnError("")
                .Execute();
        }

        private void ValidateRequest(string text, bool result)
        {
            
        }

        public class ContextConfiguration {}

        public class Context : IContext, IGiven, IWhen, IThen, IExecute, IError
        {
            private Context()
            {
            }
            
            public static IContext With(Action<ContextConfiguration> configuration)
            {
                return new Context();
            }
            
            public IContext Append(Context context)
            {
                return this;
            }

            public IGiven Given(string action)
            {
                return this;
            }

            public IWhen When<TSuccess, TError>(Action<TSuccess, TError> action)
            {
                return this;
            }

            public IThen Then(string name)
            {
                return this;
            }

            public IExecute Execute()
            {
                return this;
            }

            public IError OnError(string action)
            {
                return this;
            }
        }

        public interface IContext
        {
            public IContext Append(Context context);
            public IGiven Given(string name);
        }

        public interface IGiven
        {
            public IWhen When<TSuccess, TError>(Action<TSuccess, TError> action);
        }

        public interface IWhen
        {
            public IThen Then(string name);
        }

        public interface IThen
        {
            public IError OnError(string error);
        }

        public interface IError
        {
            public IExecute Execute();
        }

        public interface IExecute
        {
            public IContext Append(Context context);
            public IGiven Given(string name);
        }
    }
}