programa {
  funcao inicio() {
  
const inteiro MAIORIDADE = 18

inteiro idade, anos

escreva("Digite a sua idade: ")
leia(idade)

anos = MAIORIDADE - idade

se(anos > 0){
    escreva("Falta(m) ", anos, " ano(s) para atingir a maioridade\n")
}
senao{
  escreva("Você já atingiu a maioridade!")
}

  }
}
