let prompt = require("prompt-sync")()

let usuarios = [
    { nome: "Rafael", idade: 30, senha: "123456", farmacia: true },
    { nome: "Rose", idade: 32, senha: "123456", farmacia: true },
    { nome: "Conrado", idade: 30, senha: "123456", farmacia: false },
    { nome: "Eduardo", idade: 20, senha: "123456", farmacia: false }
]

let medicamentos = [
    { id: 1, nome: "dipirona", tipo: "gota", quantidade: 100 },
    { id: 2, nome: "loratadina", tipo: "comprimido", quantidade: 500 },
    { id: 3, nome: "omeprazol", tipo: "ampola", quantidade: 300 },
    { id: 4, nome: "amoxicilina", tipo: "capsula", quantidade: 500 },
    { id: 5, nome: "salbutamol", tipo: "solução", quantidade: 500 }
]

let usuario = null

main()

function main() {
    console.clear()
    console.log("*** LOGIN - FARMÁCIA UPA ***")
    let nome = prompt("Digite o seu usuário: ")
    let senha = prompt("Digite a sua senha: ")

    autenticar(nome, senha)

    if (usuario == null) {
        console.clear()
        console.log("Usuário ou senha incorretos.")
        setTimeout(() => {
            main()

        }, 1500);
        return
    }

    if (usuario.farmacia == true) {
        console.clear()
        console.log(`Usuário [${usuario.nome}] autenticado com sucesso!`)
        console.log("\nBem vindo ao Sistema da Farmácia")
        setTimeout(() => {
            principalFarmacia()
        }, 1500);
    } else {
        console.clear()
        console.log("Você não tem permissão para acessar esse sistema!")
        prompt("\nAperte ENTER para retornar para o menu inicial")
        main()

    }
}

function autenticar(nome, senha) {
    usuario = null;
    for (let i = 0; i < usuarios.length; i++) {
        if (usuarios[i].nome === nome && usuarios[i].senha === senha) {
            usuario = usuarios[i];
            return
        }
    }
}

function principalFarmacia() {
    console.clear()
    console.log("---- FARMÁCIA - UPA 24H ----\n")
    console.log("1) Listar medicamentos disponíveis")
    console.log("2) Cadastrar Novo Medicamento")
    console.log("3) Sair do sistema\n")
    let opcao = prompt("Digite uma opção: ")

    if (opcao == "1") {
        listarMedicamentos()
        return
    } else if (opcao == "2") {
        cadastrar()
    } else if (opcao == "3") {
        return
    } else {
        console.log("Opção inválida!")
        setTimeout(() => {
            principalFarmacia()
        }, 1500);
    }

}

function listarMedicamentos() {
    console.clear()
    for (let i = 0; i < medicamentos.length; i++) {
        console.log(`ID: [${medicamentos[i].id}] | Nome: ${medicamentos[i].nome} | Tipo: ${medicamentos[i].tipo} | Quantidade: ${medicamentos[i].quantidade}`)
    }

    let alteracao = prompt("Deseja 1) CADASTAR MEDICAMENTO ou 2) ALTERAR MEDICAMENTO?")

    if (alteracao == "1") {
        console.clear()
        cadastrarMedicamento()
    } else if (opcao == "2") {
        alterarMedicamento()
    }

}