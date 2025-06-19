programa {

inclua biblioteca Matematica --> mat

  funcao inicio() {

real milha, km

escreva("Digite o número de milhas: ")
leia(milha)

km = milha * 0.6214
km = mat.arredondar(km,2)

escreva(milha," milha(s) equivalem a ", km, " kms.")
    
  }
}
