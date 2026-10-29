
# DIO - Trilha .NET - Fundamentos

**Plataforma:**  [DIO.me](https://www.dio.me/)

## Descrição

Documentação referente ao desafio de código da trilha .NET - Fundamentos, que consiste no desenvolvimento de um sistema de estacionamento utilizando C# e .NET.

O sistema permite cadastrar veículos, removê-los mediante consulta da placa e listar os veículos estacionados.

## Classe principal: `Estacionamento`

**Atributos:**

-   `PrecoInicial`: `decimal` — valor inicial cobrado pelo estacionamento.
    
-   `PrecoPorHora`: `decimal` — valor cobrado por hora de permanência.
    
-   `Veiculos`: `List<string>` — coleção de placas dos veículos estacionados.
    

**Métodos:**

-   `AdicionarVeiculo(placa: string)` — adiciona um veículo à lista.
    
-   `RemoverVeiculo(placa: string)` — remove um veículo e calcula o valor a ser pago.
    
-   `ListarVeiculos()` — exibe os veículos atualmente estacionados.
    

## Tecnologias utilizadas

-   C#
    
-   .NET
    
-   Programação Orientada a Objetos (POO)
    
-   Coleções genéricas (`List<string>`)
    

## Objetivo de aprendizagem

Praticar os fundamentos de C#, incluindo classes, propriedades, métodos, tipos de dados, coleções e manipulação de dados por meio de um programa de console.