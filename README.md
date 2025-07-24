# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
## Solução

Para resolver o desafio, foi implementado um sistema console em .NET seguindo os princípios da programação orientada a objetos. A solução contém:

- **Classe abstrata Smartphone:** Serve como modelo base para os celulares, contendo propriedades comuns (Número, Modelo, IMEI, Memória) e métodos como Ligar, ReceberLigacao e o método abstrato InstalarAplicativo.
- **Classes derivadas Nokia e Iphone:** Ambas herdam de Smartphone e implementam de forma específica o método InstalarAplicativo, simulando o comportamento de instalação de aplicativos em cada tipo de aparelho.
- **Testes no Program.cs:** Foram criadas instâncias das classes Nokia e Iphone, testando os métodos implementados para garantir o funcionamento correto do sistema.

Dessa forma, o projeto demonstra o uso de herança, abstração e polimorfismo, promovendo o reuso de código e a flexibilidade para diferentes comportamentos conforme o modelo do celular.

O codigo foi testado com succeso implementando detalhes pessoais 