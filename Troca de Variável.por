programa {
  funcao inicio() {
    
    inteiro a, b, aux

    escreva("Informe o valor da variável a: ")
    leia(a)

    escreva("Informe o valor da variável b: ")
    leia(b)

    escreva("Variáveis antes da troca: A = ",a, " B = ", b)

    aux = a 
    a = b 
    b = aux

    escreva("\nVariáveis depois da troca: A = ",a, " B = ", aux)
  }
}
