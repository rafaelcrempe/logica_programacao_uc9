let prompt = require("prompt-sync")()

let usuarios = [
    {
        id: 1,
        nome: "Chaves",
        idade: 8
    },
    {
        id: 2,
        nome: "Quico",
        idade: 10
    },
    {
        id: 3,
        nome: "Seu Madruga",
        idade: 44
    },
    {
        id: 4,
        nome: "Chiquinha",
        idade: 8
    },
    {
        id: 5,
        nome: "Nhonho",
        idade: 9
    },
    {
        id: 6,
        nome: "Bruxa do 71",
        idade: 300
    }
]

main()
function main() {

    console.clear()

    console.log("\n----- MENU PRINCIPAL -----\n")
    console.log("1. Listar Todos")
    console.log("2. Buscar por nome\n")
    let opcao = prompt("Digite uma opção: ")

    if (opcao == "1") {
        console.clear()
        let ordem = prompt("Digite 1 para ORDEM CRESCENTE ou 2 para ORDEM DECRESCENTE: ")
        if (ordem == "1") {
            ordemCrescente()
        } else if (ordem == "2") {
            ordemDecrescente()
        } else {
            console.log("Opção inválida")
            setTimeout(() => {
                main()
            }, 1500);
        }


    } else if (opcao == "2") {
        buscarNome()
    }

}

function ordemCrescente() {
    for (let i = 0; i < usuarios.length; i++) {
        console.log(`ID: [${usuarios[i].id}] | Nome: ${usuarios[i].nome} | Idade: ${usuarios[i].idade}`)
    }
    prompt("Aperte ENTER para continuar")
    main()
}

function ordemDecrescente() {
    for (let i = usuarios.length - 1; i >= 0; i--) {
        console.log(`ID: [${usuarios[i].id}] | Nome: ${usuarios[i].nome} | Idade: ${usuarios[i].idade}`)
    }
    prompt("Aperte ENTER para continuar")
    main()
}

function buscarNome() {
    console.clear()

    let busca = prompt("Digite um nome para busca: ")
    busca = busca.toLowerCase()
    let usuarioEncontrado = []

    for (let i = 0; i < usuarios.length; i++) {
        if (usuarios[i].nome.toLowerCase().includes(busca)) {
            usuarioEncontrado.push(usuarios[i])
        }
    }

    if (usuarioEncontrado.length != 0) {
        for (let i = 0; i < usuarioEncontrado.length; i++) {
            console.log(`ID: [${usuarioEncontrado[i].id}] | Nome: ${usuarioEncontrado[i].nome} | Idade: ${usuarioEncontrado[i].idade}`)
        }
    } else {
        console.log("Usuário não encontrado!")
        return
    }
    prompt("\nAperte ENTER para continuar")
    main()

}