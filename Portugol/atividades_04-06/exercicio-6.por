programa {
  funcao inicio() {

real valor_hora, horas_trabalhadas, total_mes

escreva("Digite o valor recebido por cada hora de trabalho: ")
leia(valor_hora)

escreva("Quantas horas você trabalhou neste mês? ")
leia(horas_trabalhadas)

total_mes = (valor_hora * horas_trabalhadas)

escreva("Neste mês, você receberá ", total_mes, "R$ por um total de ", horas_trabalhadas, " horas trabalhadas.")


  }
}
