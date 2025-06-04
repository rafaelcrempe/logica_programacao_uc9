programa {

inclua biblioteca Matematica --> mat

  funcao inicio() {
    
real lado, area, dobro_area

escreva("Digite o valor do lado do quadrado: ")
leia(lado)

area = mat.potencia(lado,2)
dobro_area = (area * 2)

escreva("A área do quadrado é ", area, "m² e o dobro de sua área é ", dobro_area, "m²" )



  }
}
