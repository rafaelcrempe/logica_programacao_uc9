let prompt = require("prompt-sync")()

// VETORES (ARRAYS): guardar vários dados em uma só variável

function exemplo() {
    let nomes = ["Rafael", "Gustavo", "Laranja"]
    console.log(`O usuário ${nomes[1]} toma suco de ${nomes[2]}`)

    nomes[1] = "Ricardo"
    console.log(`O usuário ${nomes[1]} toma suco de ${nomes[2]}`)

    nomes.push("Doce") // Adiciona um item no final do Array
    console.log(`O usuário ${nomes[1]} toma suco de ${nomes[2]} ${nomes[3]}`)
}

let lista_nomes = []

main()
function main() {
    console.clear()
    console.log("\n----- MENU PRINCIPAL -----\n")
    let opcao = prompt("Digite 1 para cadastrar, 2 para listar ou 3 para buscar: ")
    if (opcao == 1) {
        let nome = prompt("Digite o nome: ")
        lista_nomes.push(nome)
        main()
    } else if (opcao == 2) {

        for (let i = 0; i < lista_nomes.length; i++) {
            console.log(`${i + 1} -  ${lista_nomes[i]}`)
        }

    } else if (opcao == 3) {
        let posicao = prompt("Digite a posição do usuário que deseja buscar: ")

        if (lista_nomes.length >= posicao) {
            console.log(`O usuário na posição ${posicao} é: ${lista_nomes[posicao - 1]}`)
        } else {
            console.log("Não existe um usuário cadastrado nessa posição!")
        }

    }



}