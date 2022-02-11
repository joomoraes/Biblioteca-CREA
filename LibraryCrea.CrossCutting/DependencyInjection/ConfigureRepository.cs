using LibraryCrea.Data.Context;
using LibraryCrea.Data.Implementations;
using LibraryCrea.Data.Repository;
using LibraryCrea.Domain.Interface.Service;
using LibraryCrea.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCrea.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<ICadastroCategoriaRepository, CadastroCategoriaImplementation>();
            serviceCollection.AddScoped<ICadastroLivroRepository, CadastroLivroImplementation>();
            serviceCollection.AddScoped<IMovimentacaoRepository, MovimentacaoImplementation>();
            serviceCollection.AddScoped<IPessoaRepository, PessoaImplementations>();

            serviceCollection.AddDbContext<MyContext>(
                options => options.UseSqlServer(@"Data Source=10.0.0.2;Initial Catalog=SBOTeste;User ID=sa;Password=lbr@2016")

                 );
        }
    }
}
