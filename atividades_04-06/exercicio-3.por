programa {

inclua biblioteca Matematica --> mat

  funcao inicio() {

inteiro num1, num2, soma

escreva("Digite o primeiro número: ")
leia(num1)

escreva("Digite o segundo número: ")
leia(num2)

soma = mat.potencia(num1,2) + mat.potencia(num2,2)

escreva("A soma do quadrado dos dois números é: ", soma)
  }
}
