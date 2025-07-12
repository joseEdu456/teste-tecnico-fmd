# teste-tecnico-fmd

Este projeto foi feito para servir como teste de conhecimento na vaga de .NET na agência F&MD, a API realiza um CRUD simples de palestras e participantes, onde cada participante pode estar inscrito em uma palestra apenas e uma palestra pode ter vários participantes. API também recebe informações de uma  API externa de jogos trivia, tranzendo uma pergunta e sua resposta correta.

## 🚀 Instalação e Uso

- É necessário ter o [.NET 8.0 instalado](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0)
- É necessário o uso do SQL Server para o banco de dados
- Recomendo o uso do Visual Studio para rodar a aplicação

### 🔄 Como rodar a aplicação

Primeiro clone o repositório do github
```bash
git clone https://github.com/joseEdu456/teste-tecnico-fmd.git
```
No arquivo appsettings.json, na seção de conexão com o banco altere a conection string TesteTecnicoFmd para a seguinte:

```bash
"Data source=SeuLocalHost; Initial Catalog=TesteTecnicoFmd; Integrated Security=true; TrustServerCertificate=True"
```
Após isso abra o NugetPackage Console e rode os seguinte comando para criar e aplicar as migrations no banco de dados
```bash
Add-Migration PrimeiraMigracao -Context ApplicationDbContext -o Persistence/Migrations
Update-Database -Context ApplicationDbContext
```
Por fim, basta iniciar a aplicação que então o Swagger será aberto automaticante, sendo possivel visualizar todos os endpoint da API
