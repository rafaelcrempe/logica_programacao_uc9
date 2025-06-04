programa {
  funcao inicio() {
    
inteiro reprov_turmaD, reprov_turmaC, num_turmaD, num_turmaC, porcentagem_reprovados
const inteiro turmaC = 60
const inteiro turmaD = 20    
const inteiro total_turmas = 80

escreva("Qual a porcentagem de alunos reprovados na Turma C?: ")
leia(reprov_turmaC)

escreva("Qual a porcentagem de alunos reprovados na Turma D?: ")
leia(reprov_turmaD)


num_turmaD = ((reprov_turmaD / 100) * turmaD)
num_turmaC = ((reprov_turmaC / 100) * turmaC)

escreva(num_turmaC," alunos foram reprovados na Turma C.\n")
escreva(num_turmaD," alunos foram reprovados na Turma D.\n")

porcentagem_reprovados = ((num_turmaD + num_turmaC) * 100) / total_turmas

escreva(porcentagem_reprovados,"% dos alunos entre todas as turmas foram reprovados.")

  }
}
