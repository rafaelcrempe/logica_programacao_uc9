programa {
  funcao inicio() {
    
  inteiro ano_atual, anos_bi, dias

  escreva("Digite o ano atual: ")
  leia(ano_atual)

  anos_bi = ano_atual / 4

  dias = (ano_atual - 1) * 365 + anos_bi

  escreva("Já se passaram ", dias, " dias desde 01/01/0001")

  }
}
