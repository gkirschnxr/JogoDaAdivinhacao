# JOGO DA ADIVINHA��O

![](https://imgur.com/dUSDFy7.gif)


## INTRODU��O

Simples e divertido, adivinhe o n�mero de 1 a 20.

## FUNCIONALIDADES

- **N�vel de dificuldade:** Permite o usu�rio a escolher a dificuldade entre f�cil, normal e dif�cil;
- **Gerador de n�meros aleat�rios:** O programa gera automaticamente um novo n�mero (entre 1 e 20) a cada nova tentativa.

## Como utilizar

1. Clone o reposit�rio ou baixe o c�digo fonte;
2. Abra o terminal ou o prompt de comando e navegue at� a pasta raiz;
3. Utilize o comando abaico para restaurar as depend�ncias do projeto.
```
dotnet restore
```
4. Em seguida, compile a solu��o utilizando o comando:
```
dotnet build --configuration Release
```
5. Para executar o projeto compilando em tempo real
```
dotnet run --project JogoDaAdivinhacao.ConsoleApp
```
6. Para executar o arquivo compilado, navegue at� a pasta `./JogoDaAdivinhacao.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
```
JogoDaAdivinhacao.ConsoleApp.exe
```
## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.

