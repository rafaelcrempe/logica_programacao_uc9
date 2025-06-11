programa {
  funcao inicio() {

inteiro numero = 0,aux = 0

escreva("Digite um número para saber se ele é primo: ")
leia(numero)

se(numero < 1){
  escreva("Este número não é válido. Digite um número inteiro, positivo e maior que 0!")
} senao {

  para(inteiro i = 1; i <= numero; i++){
    real resto = numero % i
    se(resto == 0){

      aux++
    }

}

se(aux == 2){
  escreva("O número é primo!")
} senao {
  escreva("O número não é primo!")
}

}
  }
}
