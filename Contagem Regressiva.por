programa {

inclua biblioteca Util

  funcao inicio() {
    
inteiro contador = 15

enquanto(contador < 0){

limpa()
escreva("\nDetonação em: ",contador,"s.")  

contador = contador - 1

Util.aguarde(1000)
}

limpa()
escreva("Boom!\n")


  }
}
