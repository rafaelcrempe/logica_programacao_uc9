programa {

      inclua biblioteca Matematica  --> mat

  funcao inicio() {

    real valor, raiz_quadrada, raiz_cubica
  
  escreva("Digite um número: ")
  leia(valor)

  raiz_quadrada = mat.raiz(valor, 2.0)
  raiz_cubica = mat.raiz(valor, 3.0)
  escreva("\nA raiz quadrada de ", valor, " é: ", raiz_quadrada)
  escreva("\nA raiz cúbica de ", valor, " é: ", raiz_cubica)
  }
}
