programa {

inclua biblioteca Util --> util

  funcao inicio() {
    inteiro numero_jogos

    escreva("Digite a quantidade de jogos desejada: ")
    leia(numero_jogos)

    const inteiro JOGO = numero_jogos
    const inteiro NUMEROS = 6
    inteiro matriz[JOGO][NUMEROS]

  para(inteiro linha = 0;linha < JOGO;linha++)
  {
    para(inteiro coluna = 0;coluna < NUMEROS;coluna++){
      matriz[linha][coluna] = util.sorteia(1,60)
    escreva("[", matriz[linha][coluna],"]")

    }

    escreva("\n")
  }

  }
}
