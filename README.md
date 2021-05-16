# CepValidate 💙
Backend da aplicação ASP.NET  de validação de CEP com dotNet5 e EF5 (DDD, TDD e SOLID)  

## O que essa aplicação faz ?

* Consome a API ViaCEP 
* Valida o CEP e as informações
* Persiste em uma base de dados os CEP's validados
* Retorna os CEP's da base para uso off-line(para base intranet ou local)

## Por que ela existe ?
É muito comum em aplicações precisarmos de um validador de CEP, essa aplicação
não só valida como retorna todos os dados para quem a consome como Rua, Cidade,
Estado, Bairro etc.

## Quem pode usar ?
Qualquer dev que queira um validador de CEP pronto, testado e confiável.

## Tecnologias

* ASP.NET 
* DotNET 5
* MVC
* Cors
* Swagger
* Testes unitários com MSTest

## Padrões e arquitetura

* SOLID (SOLID hoje, SOLID amanhã, SOLID para sempre)
* DDD (Aplicação orientada a dominio)
* TDD (Aplicação orientada a testes)
* CQRS (Separação de leitua e escrita)
* Notifications (Você nunca retornara um BadRequest sem saber o motivo)
* RepositoryPatterns (Repositorio é desacoplado do domínio)
* Domain CLR (Domínio não tem dependencias fora do dotnet)
* Dominio rico (o DB só serve de repos)

## Status 

* Em desenvolvimento...
