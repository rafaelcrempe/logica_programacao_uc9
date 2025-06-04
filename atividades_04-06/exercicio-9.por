programa {

inclua biblioteca Matematica --> mat

  funcao inicio() {
    
real salario, reajuste

escreva("Digite o seu salário: ")
leia(salario)

reajuste = salario * 1.15
reajuste = mat.arredondar(reajuste,2)

escreva("O seu salário, com reajuste de 15%, é: R$", reajuste)



  }
}
