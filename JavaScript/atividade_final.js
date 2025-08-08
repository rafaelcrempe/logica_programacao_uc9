
/* O sistema foi criado para administrar o setor de farmácia de uma UPA (Unidade de Pronto Atendimento). Nele você pode listar e 
cadastrar novos medicamentos, além de alterar a quantidade de medicamentos disponíveis na unidade. 
Por padrão, a senha de todos os usuários é 123456, mas nem todos possuem permissão para acessar esse setor.
Os usuários disponíveis são Rose, Rafael, Conrado e Eduardo*/




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
        cadastrarMedicamento()
    } else if (opcao == "3") {
        main()
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
    
    let alteracao = prompt("\nDeseja 1) CADASTAR MEDICAMENTO, 2) ALTERAR QUANTIDADE ou 3) SAIR? ")

    if (alteracao == "1") {
        console.clear()
        cadastrarMedicamento()
    } else if (alteracao == "2") {
        alterarMedicamento()

    } else if (alteracao == "3") {
        console.clear()
        principalFarmacia()
    } else {
        console.clear()
        console.log("Opção inválida!")
        setTimeout(() => {
            listarMedicamentos()            
        }, 1500);
    }

}

function cadastrarMedicamento() {
    console.clear()
    
    let nome = prompt("Digite o nome do medicamento: ").toLowerCase()

    if (nome == "") {
        console.log("O nome não pode ficar em branco!")
        prompt("Aperte ENTER para retornar")
        cadastrarMedicamento()
    }


    let cadastrado = false
    
    for (let i = 0; i < medicamentos.length; i++) {
        if (medicamentos[i].nome.toLowerCase() === nome.toLowerCase()) {
            cadastrado = true
            console.clear()
            console.log("Medicamento já cadastrado")
            setTimeout(() => {
                principalFarmacia()
            }, 1500);
            return
        }

    }

    let tipo = prompt("Digite o tipo do medicamento: ").toLowerCase()
   if (tipo == "") {
        console.log("O tipo não pode ficar em branco!")
        prompt("Aperte ENTER para retornar")
        cadastrarMedicamento()
    }

    let quantidade = parseInt(prompt("Digite a quantidade disponível do medicamento: "))

    if (quantidade <= 0) {
        console.log("Não é possível cadastrar um medicamento indisponível")
        setTimeout(() => {
            principalFarmacia()            
        }, 1500);
        return

    }

    medicamentos.push({ nome: nome, tipo: tipo, quantidade: quantidade, id: medicamentos.length + 1 })

    console.log("Medicamento cadastrado com sucesso!")

    setTimeout(() => {
        listarMedicamentos()
    }, 1500);


}

function alterarMedicamento() {

    let posicao = prompt("Digite o ID do medicamento que deseja alterar: ")

    console.clear()

    if (medicamentos.length >= posicao) {
        console.log(`Medicamento selecionado: ${medicamentos[posicao - 1].nome}`)
        alterar(posicao - 1)
    } else {
        console.log("Não existe um medicamento cadastrado nessa posição!")
    }

    function alterar(indice) {
        let nova_quantidade = prompt("Digite a nova quantidade de medicamento: ")
        medicamentos[indice].quantidade = nova_quantidade
        console.log("Quantidade alterada com sucesso!")
        setTimeout(() => {
            principalFarmacia()
        }, 1500);
    }
}