programa {

  inclua biblioteca Util --> x 

  funcao inicio() {

    inteiro lado, dados, resultado, contador, qtdtotal, soma = 0
    cadeia opcao
    
    limpa()
    faca
    {
      soma = 0
      escreva("Quantidade de lados:\n")
      leia(lado)

      escreva("Quantidade de dados a serem rolados:\n")
      leia(dados)

      limpa()
      
      
    
    para(contador = 1; contador <= dados; contador++){

      resultado = x.sorteia(1,lado)
      escreva("Dado ",contador, " : ",resultado,"\n")
      soma = resultado + soma

      
      
      

    }
      
      escreva(soma, "\n")


      escreva("Deseja rolar novamente?\n(S) SIM\n(N) NAO\n")
      leia(opcao)
      escreva("\n")

  }enquanto(opcao == 'S' ou opcao == 's')
    
  
    
    }
  }

