programa {

inclua biblioteca Calendario --> cal 

  funcao inicio() {

inteiro diaNasc, mesNasc, anoNasc, idade
inteiro diaAtual = cal.dia_mes_atual()
inteiro mesAtual = cal.mes_atual()
inteiro anoAtual = cal.ano_atual()

escreva("Digite o dia do seu nascimento: ")
leia(diaNasc)

escreva("Digite o mês do seu nascimento: ")
leia(mesNasc)

escreva("Digite o ano do seu nascimento: ")
leia(anoNasc)

idade = anoAtual - anoNasc


se(mesAtual > mesNasc){
  escreva("Sua idade é: ", idade)
} senao se (mesAtual < mesNasc){
  escreva("Sua idade é: ", idade - 1)
} senao se (mesAtual == mesNasc e diaAtual <= diaNasc){
  escreva("Sua idade é: ", idade)
} senao {
  escreva("Sua idade é: ", idade - 1)
}

  }
}
