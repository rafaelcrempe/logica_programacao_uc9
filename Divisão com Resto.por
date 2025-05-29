programa {
  funcao inicio() {
    
    inteiro metade_inteira, resto, valor

    escreva("Digite um valor: ")
    leia(valor)

    metade_inteira = valor / 2
    resto = valor % 3

    escreva("\nA metade inteira de ", valor," é: ", metade_inteira)
    escreva("\nO resto da divisão de ",valor," por 3 é: ", resto)
  }
}
