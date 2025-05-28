programa {
  funcao inicio() {
    real a, b, soma, sub, mult, div

    escreva("Digite o primeiro número: ")
    leia(a)
    escreva("Digite o segundo número: ")
    leia(b) 

    soma = a + b 
    sub = a - b 
    mult = a * b
    div = a / b 

    escreva("\nA soma dos números é: ",soma)
    escreva("\nA subtração dos números é: ",sub)
    escreva("\nA multiplicação dos números é: ",mult)
    escreva("\nA divisão dos números é: ",div)
  }
}
