programa {
  funcao inicio() {

real odometro_inicio, odometro_final, km_andados, litros_gastos, valor_gasto, valor_recebido, lucro_diario, km_por_litro
const real preco_gasolina = 2.50
    
escreva("Digite quantos km estão marcados no odômetro no início do dia: ")
leia(odometro_inicio)

escreva("\nDigite quantos km estão marcados no odômetro no final do dia: ")
leia(odometro_final)

km_andados = odometro_final - odometro_inicio

escreva("\nDigite quantos litros de gasolina foram gastos: ")
leia(litros_gastos)

escreva("\nDigite quanto dinheiro foi recebido dos passageiros (em reais): ")
leia(valor_recebido)

valor_gasto = litros_gastos * preco_gasolina
lucro_diario = valor_recebido - valor_gasto
km_por_litro = km_andados / litros_gastos

escreva("\nA média de consumo (km/l) é ", km_por_litro, "km/L e o lucro diário foi de: ",lucro_diario,"R$.")
  }
}
