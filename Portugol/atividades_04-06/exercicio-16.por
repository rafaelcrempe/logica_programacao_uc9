programa {
  funcao inicio() {
    
inteiro numero, milhar, centena, dezena, unidade

escreva("Digite um número inteiro: ")
leia(numero)

milhar = (numero / 1000) % 10
centena = (numero / 100) % 10
dezena = (numero / 10) % 10
unidade = numero % 10

escreva("\nDecomposição do número: ", numero)
escreva("\nMilhar: ",milhar)
escreva("\nCentena: ",centena)
escreva("\nDezena: ",dezena)
escreva("\nUnidade: ",unidade)

  }
}
