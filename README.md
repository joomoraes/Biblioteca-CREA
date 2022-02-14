# ![Markdown Here logo](https://raw.github.com/adam-p/markdown-here/master/src/common/images/icon48.png) Biblioteca CREA
Projeto criado para processo seletivo, usando arquitetura DDD com orientação a microserviços, documentado pelo [Swagger](https://swagger.io/) da plataform swashbuckle

### Arquitetura DDD - Domain Driven Design
**[Application](#Application)**<br>
**[CrossCutting](#CrossCutting)**<br>
**[Troubleshooting](#troubleshooting)**<br>
**[Compatibility](#compatibility)**<br>
**[Notes and Miscellaneous](#notes-and-miscellaneous)**<br>
**[Building the Extension Bundles](#building-the-extension-bundles)**<br>
**[Next Steps, Credits, Feedback, License](#next-steps)**<br>

## Application

![swagger](https://miro.medium.com/max/690/1*3SjT2Dw7tiFFRoEIBbbKvQ.png)

### Swagger 

A camada de aplicação, é a camada de que leva o Swagger, está brilhante ferramenta captura os endPoints presentes na controller e os distribui em uma magnifica documentação.
![]()


### CrossCutting

A camada de referência cruzada, leva os mapeamentos das unidades Dtos e injeção de dependência.
![AutoMapper](https://miro.medium.com/max/700/1*VstWEsGPYwhDG2-KOBVrNQ.png)
