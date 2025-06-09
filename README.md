# EcoSafe

# Pedro Gomes - RM 553907
# Luiz Felipe Abreu - RM 555197
# Matheus Munuera - RM 557812


Descrição da Solução:

-	Descrição dos objetivos da solução idealizada:

Desenvolver uma plataforma digital para gerenciamento de abrigos temporários, com funcionalidades que permitam:<br>

 •	Controle da ocupação dos abrigos.
 
 •	Gestão eficiente de alimentos e doações.
 
 •	Cadastro e monitoramento da entrada e saída de pessoas.
 
 •	Relatórios em tempo real para apoiar decisões rápidas.
 
 
A solução busca modernizar o processo de resposta a desastres, trazendo mais agilidade e eficiência.

Objetivos da Solução Idealizada:<br>

 1.	Organizar e agilizar a gestão de abrigos temporários.
    
 3.	Garantir transparência no gerenciamento de ocupação e doações.
    
 5.	Reduzir o tempo de resposta em emergências.
    
 7.	Facilitar o acesso às informações via dispositivos móveis.
    
O impacto esperado inclui a redução de riscos, melhor assistência às vítimas e otimização de recursos públicos e privados.

________________________________________________________________________________________


Vídeo PITCH - https://youtu.be/0Efr--jnxt8


Vídeo da descrição - https://youtu.be/2GKzZkAWTeM

________________________________________________________________________________________

<h2>Acesso ao código</h2>

1. Execução Local
   
Para rodar o projeto localmente:

 git clone https://github.com/PedroHGGomes/EcoSafe.git<br>
 dotnet restore<br>
 dotnet ef database update  (verifice o .json para conectar com o seu banco de dados Oracle)<br>
 dotnet run<br>
 
2. URL de Acesso
Após rodar o projeto, acesse:

Aplicação Web (MVC - Razor Pages):
https://localhost:7117/

Documentação da API (Swagger):
https://localhost:7117/swagger

<h2>OBSERVAÇÃO</h2>

Todas as requisições API retornam status HTTP apropriados:

200 OK para sucesso

201 Created para criação

400 BadRequest para dados inválidos

404 NotFound para registros não encontrados

204 NoContent para deleções

<h2>🛠️ Funcionalidades Disponíveis</h2>


<h3>Web (MVC Razor)</h3>

Funcionalidade	Caminho

🏠 Página Inicial	/Home/Index

➕ Novo Abrigo	/Abrigo/Create

📋 Listar Abrigos	/Abrigo/Index


<h3>API RESTful</h3>

Método	Endpoint	Descrição

GET	/api/AbrigoApi	Lista todos os abrigos

GET	/api/AbrigoApi/{id}	Busca abrigo por ID

GET	/api/AbrigoApi/search?nome={nome}	Busca abrigo por nome

POST	/api/AbrigoApi	Cadastra um novo abrigo

PUT	/api/AbrigoApi/{id}	Atualiza um abrigo existente

DELETE	/api/AbrigoApi/{id}	Remove um abrigo

<h2>Exemplo de Requisição</h2>

POST /api/AbrigoApi
Content-Type: application/json

{
  "nome": "Abrigo Central",
  "endereco": "Rua das Flores, 123",
  "capacidade": 200,
  "ocupacao_Atual": 150
}

Reposta esperada:

201 Created
{
  "id_ABRIGO": 1,
  "nome": "Abrigo Central",
  "endereco": "Rua das Flores, 123",
  "capacidade": 200,
  "ocupacao_Atual": 150
}



<h2>Informações do código</h2>

- API REST que atenda a boas práticas de programação / arquitetura;
 
![image](https://github.com/user-attachments/assets/4db88b9a-a157-4a62-bbe1-dbc5520a4c52)


- Apresentar um CRUD pelo menos (GET (mais de 3 rotas e devidamente parametrizadas com QueryParams ou 
PathParams), POST, PUT, DELETE)<br>
GET:

![image](https://github.com/user-attachments/assets/5ac622da-5857-4d01-8a1b-d6252f57abb1)


POST:

![image](https://github.com/user-attachments/assets/f0636cfc-88e8-4db6-b741-9cda33619930)


PUT:

![image](https://github.com/user-attachments/assets/f3b14c9d-74a3-41eb-9d18-4129d0fe0b64)

![image](https://github.com/user-attachments/assets/13d8ce65-06e0-49a8-8698-c52ee5491bec)


DELETE:

![image](https://github.com/user-attachments/assets/a35d57f0-7287-4891-ba97-cc1087f172f5)




- Apresentar os retornos HTTP adequados para cada rota (ok, NotFound, BadRequest, NoContent, Created)
OK:

![image](https://github.com/user-attachments/assets/d9443e5e-c7ef-496b-9f56-bf48c988d4ff)


NotFound/BadRequest/No Content:

![image](https://github.com/user-attachments/assets/a7cd36b7-49e6-4f3e-8901-cb3c39a99137)

Created:

![image](https://github.com/user-attachments/assets/47ddbb92-2619-4bc1-a201-bf9958879e22)



 
- Integração do Banco de dados Oracle via EF Core, com utilização de migrations para criação das tabelas
 Alteração feita no .json:
 
![image](https://github.com/user-attachments/assets/650e5c4b-69c5-420e-9eb9-35db1420e1a0)


Criação nos modelos:

![image](https://github.com/user-attachments/assets/521cc096-e2d0-47f3-aa6d-19ef9e496799)


Conexão com Oracle no program.cs:

![image](https://github.com/user-attachments/assets/73c6c941-14f4-42bd-9519-a19ed8ab6ace)




- Open API Implementada seguindo os padrões para documentação das API's com interface gráfica (Swagger, 
Redoc ou Scalar)

Swagger AbrigoAPI:

![image](https://github.com/user-attachments/assets/880fd9c0-9714-4727-9e0b-ebf04a5642ad)


Swagger Alerta:

![image](https://github.com/user-attachments/assets/28d295a0-b502-488c-9429-8388b82d14dd)


Swagger AppUser:

![image](https://github.com/user-attachments/assets/66df6b2d-cf4a-40e9-9e48-da2070f23367)


Swagger LeituraSensor:

![image](https://github.com/user-attachments/assets/4199c353-615e-4b3b-9b49-f34c492074b4)

Swagger Sensor:

![image](https://github.com/user-attachments/assets/5947d44f-de3e-4402-9c3d-214fa788697a)



Schemas:

![image](https://github.com/user-attachments/assets/42b93970-ac0b-4e5c-8afe-93c10ccb5f3b)
![image](https://github.com/user-attachments/assets/b0c031e4-83a0-4f36-b0b3-64f848e043a5)

Configuração para um banco de dados relacional:

![image](https://github.com/user-attachments/assets/e947d00b-c839-4f92-ab27-2550e60108c5)

Relacionamento 1:N  :

1:ABRIGO - N:SENSORES

![image](https://github.com/user-attachments/assets/7c748925-2da2-4934-a911-1abc112133fa)

Página - Ecosafe:

Razor:

(Create.cshtml)

![image](https://github.com/user-attachments/assets/1c873245-25d7-4f91-a6af-1e58406684ed)

TagHelper:

(asp-for / asp-action / asp-controller)

![image](https://github.com/user-attachments/assets/91cc112a-1d02-44cd-aefd-eb7212dec6fb)


Home:

![image](https://github.com/user-attachments/assets/8bfe0132-0dbe-47cd-867e-0dad4bd2f5eb)

Cadastrar Abrigo:

![image](https://github.com/user-attachments/assets/665dfef2-36f3-46dc-9c50-a724d5130cc1)

Listar Abrigo:

![image](https://github.com/user-attachments/assets/de137829-4694-48db-bdfa-f6995d654c3d)

Política de Privacidade:

![image](https://github.com/user-attachments/assets/f1d8a482-dabb-4c0f-a0db-f153b40ca8b5)
