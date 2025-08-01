// CRUD (Create, Read, Update, Delete)

// MENU DE SISTEMA
let prompt = require("prompt-sync")()

let nome = ""
let idade = 0
let ativo = false

main()

function main() {

    console.clear() // Limpa o console antes de escrever a mensagem

    console.log("---- SISTEMA DO RAFAEL ----\n")
    console.log("1) Cadastrar")
    console.log("2) Listar Usuários")
    console.log("3) Sair do sistema\n")
    let opcao = prompt("Digite uma opção: ")

    if (opcao == "1") {
        cadastro()
        main()
    } else if (opcao == "2") {
        listar()
    } else if (opcao == "3") {
        return
    } else {
        console.log("Opção inválida!")
        setTimeout(() => { //Ativa um delay entre uma função e outra
            main()
        }, 1500); // tempo deve ser definido em milisegundos
    }

}

function cadastro() {
    console.log("\n---- CADASTRO ----")
    nome = prompt("Digite o seu nome: ")
    idade = parseInt(prompt("Digite a sua idade: "))
    ativo = true
}

function listar() {
    
    let usuario_ativo

    if (ativo) { // não preciso colocar == true pq o if já verifica isso
        usuario_ativo = "SIM"
    } else {
        usuario_ativo = "NÃO"
    }

    if (nome == "") {
        console.log("Não existem usuários cadastrados")
        setTimeout(() => { //Ativa um delay entre uma função e outra
            main()
        }, 1500);
    } else if (nome != "") {
        console.log("\n---- LISTA DE USUÁRIOS ----")
        console.log(`1. Nome: [${nome}] | Idade: [${idade}] | Ativo: [${usuario_ativo}]`)
    }
}

