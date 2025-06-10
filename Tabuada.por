programa {
  funcao inicio() {
  
inteiro numero, contador, resultado

escreva("Digite um número para ver a sua tabuada: ")
leia(numero)

limpa()

para(contador = 1;contador <= 10; contador++){
  resultado = numero * contador
  escreva(numero, "x", contador," = ", resultado,"\n")
}


  }
}
