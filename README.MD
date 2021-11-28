# TRAINER Para o jogo RESIDENT EVIL 4

## Versão
- Ultimate HD (STEAM)

## Tecnologias 

- C# (Windows Form Application)
- Visual Studio
- Memory.dll
- Cheat Engine

## CHEATS 

- Munição Infinita 
- Vida Infinita LEON
- Vida Máxima para LEON
- Alterar Velocidade do LEON
- Vida Infinita para ASHLEY (Sem efeito contra explosões)
- Desativar Colisão do Mapa
- LEON Invencível (Desativar a HIT BOX de dano) - (Sem efeito contra agarrões)
- Matar Inimigo com um tiro




### O que são Trainers ?

- Trainers são uma categoria de Hacks possibilitam a alteração do comportamento dos jogos através de endereços de memória armazenados no Sistema Operacional durante sua execução, esse é o tipo de Hack mais comum e conhecido entre os jogadores.

### O que é o Cheat Engine ?

- O Cheat Engine é a ferramenta mais famosas e utilizada pelos Modders, pois, ela possibilita que tenhamos acesso a todos os valores armazenados nos endereços de memória do Programa que está sendo executado. A importância do cheat engine no desenvolvimento dos trainers se dá ao fato da sua interface e informações completa do que está acontecendo ocorrendo no Jogo em cada ação feita pelo jogador.

- Dentre suas principais funcionalidades estão os scaneamentos dos valores nos endereços de memória, descobrir quem acessa o endereço, quem escreve/sobescreve o endereço e criar scripts personalizados utilizando a linguagem ASSEMBLY.

## Funcionalidades do Cheat Engine e Exemplos

#### Scaneamento de endereços - Scan Values

- Muito utilizado quando queremos ter acesso algum valor, por exemplo, o valor de quantos tiros está atualemnte no pente da pistola do LEON.

#### Quem escreve este endereço - What writes this address

- Utilizado quando há uma lógica onde tem incremento ou decremento de um determinado valor, utilizando o exemplo dado acima, quando damos um tiro, é decrementado o valor 1 do numero que está no pente da nossa arma, se desativarmos a lógica que decrementa o valor após tiro, o jogo não irá subtrair o valor, permitindo a munição infinita. 

#### Quem acessa este endereço - What access this address

- Geralmente quando há uma lógica que análisa determinada ação, por exemplo, quebrar a colisão do Mapa (Fazer o personagem atravessar as paredes e objetos), no Resident Evil 4 um endereço de memória (que verifica se o personagem está colidindo com algum objeto do mapa) acessa outro endereço que devolve um retorno de valor verdadeiro caso o LEON colida com algum objeto do mapa. se desativarmos o endereço que faz análise de colisão, o jogo fica incapaz de realizar a verificação, permitindo que o LEON atravesse os objetos.

