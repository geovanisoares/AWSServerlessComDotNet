# dotnet-exemplo-aws-serverless

Este é um projeto de exemplo que demonstra como criar uma aplicação serverless usando o AWS Lambda e o framework .NET Core. Ele fornece uma estrutura básica para construir e implantar uma função Lambda na AWS.

### Pré-requisitos:

Antes de executar este projeto, verifique se você tem os seguintes pré-requisitos:

- SDK do .NET 6 (ou superior)
- Uma conta na AWS com permissões para criar recursos Lambda e acessar outros serviços necessários (como o Amazon API Gateway e o Amazon DynamoDB)

### Configuração

Siga as etapas abaixo para configurar e executar o projeto:

Clone este repositório em sua máquina local:

~~~bash
git clone https://github.com/geovanisoares/dotnet-exemplo-aws-serverless.git
~~~

Acesse o diretório do projeto:

~~~bash
cd dotnet-exemplo-aws-serverless
~~~

Abra o arquivo aws-lambda-tools-defaults.json e atualize as configurações conforme necessário. Em particular, verifique as configurações relacionadas à região da AWS, nome do bucket S3 e nome da função Lambda.

No terminal, execute o seguinte comando para publicar a função Lambda na AWS:

~~~python
dotnet lambda deploy-serverless
~~~

Depois que a implantação for concluída com sucesso, você receberá informações sobre a função Lambda implantada, incluindo o ARN (Amazon Resource Name).

Agora você pode testar sua função Lambda usando um cliente HTTP ou o console da AWS.

### Endpoints

A função Lambda expõe os seguintes endpoints:

- GET /api/hello: Retorna uma mensagem de saudação.
- GET /api/time: Retorna a hora atual.

Você pode usar o Amazon API Gateway para criar uma API RESTful que faz a ponte entre os endpoints HTTP e a função Lambda.

### Contribuindo

Se você quiser contribuir para este projeto, siga estas etapas:

- Fork este repositório.
- Crie uma nova branch: git checkout -b minha-nova-feature
- Faça suas alterações e confira se tudo está funcionando corretamente.
- Envie suas alterações: git commit -m 'Adicionando nova feature'
- Envie a branch: git push origin minha-nova-feature
- Abra um Pull Request.

### Contato:

Se você tiver alguma dúvida ou sugestão, sinta-se à vontade para entrar em contato comigo através do email servico.websoares@gmail.com
