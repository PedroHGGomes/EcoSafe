# EcoSafe

# Pedro Gomes - RM 553907
# Luiz Felipe Abreu - RM 555197
# Matheus Munuera - RM 557812


Descrição da Solução:

-	Descrição dos objetivos da solução idealizada:

Desenvolver uma plataforma digital para gerenciamento de abrigos temporários, com funcionalidades que permitam:
 •	Controle da ocupação dos abrigos.
 •	Gestão eficiente de alimentos e doações.
 •	Cadastro e monitoramento da entrada e saída de pessoas.
 •	Relatórios em tempo real para apoiar decisões rápidas.
 
A solução busca modernizar o processo de resposta a desastres, trazendo mais agilidade e eficiência.

Objetivos da Solução Idealizada:

 1.	Organizar e agilizar a gestão de abrigos temporários.
 2.	Garantir transparência no gerenciamento de ocupação e doações.
 3.	Reduzir o tempo de resposta em emergências.
 4.	Facilitar o acesso às informações via dispositivos móveis.
    
O impacto esperado inclui a redução de riscos, melhor assistência às vítimas e otimização de recursos públicos e privados.

________________________________________________________________________________________


Vídeo PITCH - https://youtu.be/0Efr--jnxt8

________________________________________________________________________________________
Resumo do Código: <br>


- API REST que atenda a boas práticas de programação / arquitetura;
 
![image](https://github.com/user-attachments/assets/4db88b9a-a157-4a62-bbe1-dbc5520a4c52)


- Apresentar um CRUD pelo menos (GET (mais de 3 rotas e devidamente parametrizadas com QueryParams ou 
PathParams), POST, PUT, DELETE)
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

