# JOGO DA ADIVINHAÇÃO

![](https://imgur.com/dUSDFy7.gif)


## INTRODUÇÃO

Simples e divertido, adivinhe o número de 1 a 20.

## FUNCIONALIDADES

- **Nível de dificuldade:** Permite o usuário a escolher a dificuldade entre fácil, normal e difícil;
- **Gerador de números aleatórios:** O programa gera automaticamente um novo número (entre 1 e 20) a cada nova tentativa.

## Como utilizar

1. Clone o repositório ou baixe o código fonte;
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz;
3. Utilize o comando abaico para restaurar as dependências do projeto.
```
dotnet restore
```
4. Em seguida, compile a solução utilizando o comando:
```
dotnet build --configuration Release
```
5. Para executar o projeto compilando em tempo real
```
dotnet run --project JogoDaAdivinhacao.ConsoleApp
```
6. Para executar o arquivo compilado, navegue até a pasta `./JogoDaAdivinhacao.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
```
JogoDaAdivinhacao.ConsoleApp.exe
```
## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.

