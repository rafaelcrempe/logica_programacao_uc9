programa {
  funcao inicio() {
 
inteiro numero_alunos, turmaA, turmaB, turmaC, divisao, resto

escreva("Digite o número de alunos: ")
leia(numero_alunos)

divisao = numero_alunos / 3
resto = divisao % 3

turmaA = divisao
turmaB = divisao
turmaC = divisao

se(resto != 0){
  turmaA = turmaA + resto
}

escreva("\nAlunos na Turma A: ",turmaA)
escreva("\nAlunos na Turma B: ",turmaB)
escreva("\nAlunos na Turma C: ",turmaC)
  }
}
