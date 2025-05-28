programa {
  funcao inicio() {
    
    cadeia nome_completo
    cadeia logradouro
    inteiro numero
    cadeia cep
    cadeia cidade
    cadeia estado
    cadeia bairro

    escreva("Nome Completo: ")
    leia(nome_completo)
    escreva("Logradouro: ")
    leia(logradouro)
    escreva("Número: ")
    leia(numero)
    escreva("CEP: ")
    leia(cep)
    escreva("Cidade: ")
    leia(cidade)
    escreva("Estado: ")
    leia(estado)
    escreva("Bairro: ")
    leia(bairro)

    escreva("\n",nome_completo,"\n",logradouro,", ",numero,"\n",cep,"\n",cidade,", ",estado,"\n",bairro)
  }
}
