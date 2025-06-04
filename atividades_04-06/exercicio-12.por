programa {
  funcao inicio() {

  real kg_alimentos, alimento_g, dias

  escreva("Digite quantos kg de alimento você recebeu: ")
  leia(kg_alimentos)
 
alimento_g = kg_alimentos * 1000

dias = alimento_g / 50

escreva("Com ", kg_alimentos, "kgs, você conseguirá se alimentar por ", dias, " dias")



  }
}
