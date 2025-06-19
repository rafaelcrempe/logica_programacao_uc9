programa {

inclua biblioteca Matematica --> mat 

  funcao inicio() {
    
real peso, altura, imc

escreva("Digite o seu peso: ")
leia(peso)
escreva("Digite a sua altura: ")
leia(altura)

imc = peso / mat.potencia(altura,2.0)
imc = mat.arredondar(imc,1)

se(imc < 18.5){
  escreva("Seu IMC é: ", imc ,"\nVocê está abaixo do peso!")
} senao se (imc >= 18.5 e imc <= 24.9){
  escreva("Seu IMC é: ", imc ,"\nVocê está no peso normal!")
} senao se (imc >= 25 e imc <= 29.9){
  escreva("Seu IMC é: ", imc ,"\nVocê está em sobrepeso!")
} senao se (imc >= 30 e imc <= 34.9){
  escreva("Seu IMC é: ", imc ,"\nVocê está em Obesidade Grau 1!")
} senao se (imc >= 35 e imc <= 39.9){
  escreva("Seu IMC é: ", imc ,"\nVocê está em Obesidade Grau 2!")
} senao {
  escreva("Seu IMC é: ", imc ,"\nVocê está em Obesidade Grau 3!")
}
  }
}
