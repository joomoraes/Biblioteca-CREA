# ![Markdown Here logo](https://raw.github.com/adam-p/markdown-here/master/src/common/images/icon48.png) Biblioteca CREA
Projeto criado para processo seletivo, usando arquitetura DDD com orientação a microserviços, documentado pelo [Swagger](https://swagger.io/) da plataform swashbuckle, a arquitetura DDD, é conhecida pela flexibilidade e baixo acoplamento

![ddd](https://miro.medium.com/max/641/1*qpHCIA7RDfW89KtSUXGJog.png)

### Arquitetura DDD - Domain Driven Design
**[Application](#Application)**<br>
**[CrossCutting](#CrossCutting)**<br>
**[Domain](#Domain)**<br>
**[Data](#Data)**<br>
**[Service](#Service)**<br>
**[Sobre](#Sobre)**<br>



### Swagger 
![swagger](https://miro.medium.com/max/690/1*3SjT2Dw7tiFFRoEIBbbKvQ.png)


## Application

A camada de aplicação, é a camada de que leva o Swagger, está brilhante ferramenta captura os endPoints presentes na controller e os distribui em uma magnifica documentação.
![automapper]()


### CrossCutting

A camada de referência cruzada, leva os mapeamentos das unidades Dtos e injeção de dependência.
![AutoMapper](https://miro.medium.com/max/700/1*VstWEsGPYwhDG2-KOBVrNQ.png)

### Domain

A camada de domínio é a responsável pela declaração e trabalho das entidades, em aspectos tanto de estrutura de interface, quanto no aspecto de entidades para mapeamento e dtos para gestão de dados e controle de acesso.
![Dtos](https://hangzone.com/wp-content/uploads/2019/04/Blog-DTOs.png)


### Data

A camada de data é a camada que o ORM, e mapeia o relacionamento da entidade e banco dedados
![sqlserver](https://www.iperiusbackup.net/wp-content/uploads/2016/05/1768.sql_logo.png)

### Service

A camada de serviço é a camada que cria as dependências que vão carregar o objeto ao e o devolve-lo ao longo da aplicação.
![service](https://thiagoborges.net.br/wp-content/uploads/2016/09/web_service.png)


### Sobre

**Note:** A aplicação está documentada com a ferramenta presente na biblioteca SwashBuclke, a biblioteca pode apresentar conflitos durante seu ambiente de produção ou debug, recomenda-se usar o Visual Studio mais recente e o NetFramework atualizado na mesma, a migração pode ser realizada na camada de Data, com o Power Shell do console da IDE com o seguinte comando presente no **Nuget Ef Core**  
```
   ef dotnet new migrations <nome migração>
   ef dotnet database update
   ```
   após realizar estes comando, rode a aplicação e deverá ver está tela **<br>
   ![telaApiCrea](https://github.com/joomoraes/Biblioteca-CREA/blob/mainMaster/readMD-images/img3.png?raw=true)**<br>
   Caso aparecer esta tela**<br>
   ![telaFalha](https://github.com/joomoraes/Biblioteca-CREA/blob/mainMaster/readMD-images/img1.png?raw=true)**<br>
   Reinstale o **swashbuckle**, e utilize os seguinte comandos na camada de **Application**
   ```
   dotnet build
   dotnet build --configuration Release
   dotnet restore -f 
   ```
   Tente novamente certificando-se que a aplicação está devidamento migrada para o banco de sua escolha.
   
   **Note**: Inicialmente foi criada uma tela UI, de acesso ao usuário, mas devido ao curto prazo, estipulou-se que não haveria tempo suficiente para realização de todos os testes 
   ![telaIndex](https://github.com/joomoraes/Biblioteca-CREA/blob/mainMaster/readMD-images/img2.png?raw=true)
   
   **Note** Existe uma versão de release-produção do projeto em um site [release](https://github.com/joomoraes/Biblioteca-CREA/blob/mainMaster/ApiBibliotecaCreaReleaseFonteIISDeploy.rar) pronto para ser instalado no IIS, com as devidas migrações sendo feitas no Visual Studio 
   
