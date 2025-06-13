programa {

inclua biblioteca Util --> util

  funcao inicio() {
    
inteiro vetor [60]

para (inteiro posicao = 0; posicao < 6; posicao++) {
  vetor[posicao] = util.sorteia(1,60)
}

escreva("Números sorteados:\n")

para(inteiro posicao = 0;posicao < 6;posicao++) {
  escreva("[",vetor[posicao], "] ")
}

  }
}
