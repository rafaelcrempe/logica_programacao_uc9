programa {


  funcao inicio() {

    const inteiro COL = 3
    const inteiro LIN = 4
    real matriz[LIN][COL]
    real coluna_desejada
    real linha_desejada 

    para(inteiro linha = 0;linha < LIN;linha++)
    {
      para(inteiro coluna = 0;coluna < COL;coluna++)
      {

        escreva("Digite o valor da linha ", linha," e da coluna ",coluna," : ")
        leia(matriz[linha][coluna])

      }      

          escreva("\n")

    }
        para(inteiro linha = 0;linha < LIN;linha++)
    {
      para(inteiro coluna = 0;coluna < COL;coluna++)
      {
          escreva("[",matriz[linha][coluna],"]")
      

      }      

          escreva("\n")

         
    }

    escreva("Digite a linha desejada: ")
    leia(linha_desejada)

    escreva("Digite a coluna desejada: ")
    leia(coluna_desejada)

    escreva("\n", matriz[linha_desejada][coluna_desejada])    
     

          escreva("\n")

         
    }    
    
  }
}
