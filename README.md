1
a)Controller: responsável por receber requisições, processar a lógica de negócio (com auxílio dos models) e retornar uma resposta.
Model: representa os dados e regras de negócio da aplicação (ex.: classes que refletem tabelas do banco).
Herança de ControllerBase: ao criar um controller em ASP.NET Core, herdamos de ControllerBase para ter acesso a métodos e funcionalidades úteis, como Ok(), BadRequest(), NotFound(), além de suporte a roteamento e serialização automática de objetos em JSON.

b)Navegadores executam requisições GET diretamente pela barra de endereços, pois esse verbo é usado para recuperar recursos.
O POST exige envio de corpo (payload) com dados, o que não é possível apenas digitando a URL. Para testar POST, usamos ferramentas como Postman, Insomnia ou formulários HTML.

2
Verbos HTTP corretos:
a) Criar a aula → POST  
b) Remover um material → DELETE  
c) Listar disciplinas disponíveis → GET  
d) Listar alunos da disciplina → GET  
e) Atualizar um material → PUT (ou PATCH, se parcial)
f) Lançar uma nota → POST (se criar) ou PUT (se atualizar)

3
Ok() → 200: requisição bem-sucedida, retorna o recurso ou confirmação.
BadRequest() → 400: erro do cliente, geralmente dados inválidos ou mal formatados.
NotFound() → 404: recurso solicitado não existe.
Outros exemplos:
Unauthorized() → 401: usuário não autenticado.
Forbidden() → 403: usuário autenticado, mas sem permissão.

4
Exemplo: https://minhaapi.com.br/api/vendas

https:// → protocolo seguro de comunicação (HyperText Transfer Protocol Secure).
minhaapi.com.br → domínio da aplicação, identifica o servidor.
/api/vendas → rota/endereço dentro da aplicação que aponta para o recurso "vendas".
