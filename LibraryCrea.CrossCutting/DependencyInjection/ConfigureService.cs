using LibraryCrea.Domain.Interface.Service.CadastroLivro;
using LibraryCrea.Domain.Interface.Service.Movimentacao;
using LibraryCrea.Domain.Interface.Service.Pessoa;
using LibraryCrea.Domain.Models;
using LibraryCrea.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependencieService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ICadastroCategoriaService, CadastroCategoriaService>();
            serviceCollection.AddTransient<ICadastroLivroService, CadastroLivroService>();
            serviceCollection.AddTransient<IMovimentacaoService, MovimentacaoService>();
            serviceCollection.AddTransient<IPessoaService, PessoaService>();
        }
    }
}
