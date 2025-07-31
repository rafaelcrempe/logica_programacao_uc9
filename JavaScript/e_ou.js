let prompt = require("prompt-sync")()

// Operador "E" e operador "OU" nas condições

// exemploPagamento()
// atividadeCNH()
// login()
atividadeFutebol()


function exemploPagamento() {

    let pagamento = prompt("Selecione uma opção (credito, debito, pix ou dinheiro):  ")

    if (pagamento == "credito") {
        console.log("Você selecionou o crédito")
    } else if (pagamento == "debito") {
        console.log("Você selecionou o débito")
    } else if (pagamento == "pix") {
        console.log("Você selecionou PIX")
    } else if (pagamento == "dinheiro") {
        console.log("Você selecionou o dinheiro")
    } else {
        console.log("FORMA DE PAGAMENTO INVÁLIDA")
    }

}


/* ATIVIDADE CNH

    Pergunte a idade de uma pessoa.
    Se ela tiver mais de 18 anos mostre "Você já pode tirar a CNH"
    Com menos de 18 anos mostre "Você ainda não tem idade para tirar CNH"
    Mas caso a pessoa tenha mais de 65 anos, mostre "Teste especial para renovar a CNH"
    Se a pessoa tiver mais de 120 anos, mostre "Idade inválida..."

*/

function atividadeCNH() {

    let idade = parseInt(prompt("Digite a sua idade: "))

    if (idade >= 18 && idade <= 65) {
        console.log("Você já pode tirar a CNH!")
    } else if (idade < 18) {
        console.log("Você ainda não tem idade para tirar CNH!")
    } else if (idade > 65 && idade < 120) {
        console.log("Teste especial para renovar a CNH")
    } else {
        console.log("Idade inválida")
    }
}

function login() {

    let usuario = prompt("Digite seu usuário: ")
    let senha = prompt("Digite a sua senha: ")

    if (usuario == "admin" && senha == "123") {
        console.log("Usuário logado")
    } else {
        console.log("Dados incorretos")
    }
}

function exemploResposta() {
    let resposta = prompt("Deseja cadastrar o débito automático? ")

    if (resposta == sim) {
        console.log("Débito cadastrado com sucesso!")
    } else {
        console.log("Não será cadastrado")
    }
}

function atividadeFutebol() {

    let time1 = prompt("Digite o nome do primeiro time: ")
    let time2 = prompt("Digite o nome do segundo time: ")
    let gols_time1 = parseInt(prompt(`Digite a quantidade de gols marcados por ${time1}: `))
    let gols_time2 = parseInt(prompt(`Digite a quantidade de gols marcados por ${time2}: `))


    console.log("---------- PLACAR ----------")
    console.log(`${time1} ${gols_time1} x ${gols_time2} ${time2}`)

    if (gols_time1 > gols_time2) {
        console.log(`TIME VENCEDOR: ${time1}`)
    } else if (gols_time2 > gols_time1) {
        console.log(`TIME VENCEDOR: ${time2}`)
    } else {
        console.log("EMPATE")
    }


}