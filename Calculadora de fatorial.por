programa {

  funcao inicio() {

    inteiro numero, contador, resultado, fatorial = 1

  
      escreva("Digite um número para saber o fatorial: ")
      leia(numero)

      para(contador = 2 ; contador <= numero; contador++){

          fatorial = fatorial * contador 
        }
    
     escreva("\nO fatorial de ", numero," é " ,fatorial, "\n")
     


    
  }
}
