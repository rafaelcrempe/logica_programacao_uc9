programa {

inclua biblioteca Util --> util 

  funcao inicio() {

    const inteiro COL = 5
    const inteiro LIN = 10

    inteiro matriz[LIN][COL]

    para(inteiro linha = 0;linha < LIN;linha++){
      para(inteiro coluna = 0;coluna < COL;coluna++){

        matriz[linha][coluna] = util.sorteia(1,100)
        escreva("[",matriz[linha][coluna],"]")
      }

  escreva("\n")    
    }
    
  }
}
