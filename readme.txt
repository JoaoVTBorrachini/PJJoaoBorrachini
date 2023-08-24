1- Cria uma pasta destinada ao projeto.
2- Dentro desta pasta abra o CMD.
3- No cmd digite o seguinte comando - dotnet new mvc --no-https --output PJJoaoBorrachini
4- No mesmo cmd digite CD e o nome da pasta "PJJoaoBorrachini"
5- E vamos baixar as extensões necessarias com os seguintes comandos: 
	dotnet add package Microsoft.EntityFrameworkCore
	dotnet add package Microsoft.EntityFrameworkCore.Design
	dotnet add package Microsoft.EntityFrameworkCore.SqlServer
6- Adicionados os novos pacotes, podemos abrir o projeto no VISUAL ESTUDIO 2022
7- Dentro do projeto vamos criar uma pasta chamada "data"
	Clique em "Adicionar" e "Nova Pasta" criar com o nome "data"
8- Dentro da pasta vamos criar o AppDbContext.cs -> 
	Botão direito na pasta "data"
	Clique em "Adicionar" e "Novo item..." criar com o nome "AppDbContext.cs"
9- Vamos criar as classes no Models, seguindo o modelo a cima, criar com os nomes "AppUser" e "Psicologo".
10- Dentro dos arquivos "AppUser" e "Psicologo", vamos criar suas caracteristicas como: nome, altura, raça...
11- Criado vamos "puxar" eles para usar no "program" - using PJJoaoBorrachini.Data;
						     using PJJoaoBorrachini.Models;
12- E também configurar o serviço de indentificação de usuario, o login