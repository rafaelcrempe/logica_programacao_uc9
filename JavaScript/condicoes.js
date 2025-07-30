// Condições simples

let prompt = require("prompt-sync")()


function exemploIdade() {
    let idade = parseInt(prompt("Digite a sua idade: "))

    if (idade >= 18) {
        console.log("Você é maior de idade")
    } else {
        console.log("Você é menor de idade")
    }
}

function exemploSenha() {
    let senha = prompt("Digite a senha do sistema: ")

    if (senha == "admin") {
        console.log("Acesso autorizado!")
    } else {
        console.log("Senha incorreta!")
    }
}

/*  Crie um sistema que calcule o valor de venda de peixes de acordo com os kilos 
    Cada kilo de peixe custa R$ 50,00

    Se, por acaso, houver mais do que 100 kilos de peixe, o kilo passa a custar R$ 55,90

    Mostre o valor final da venda
*/

atividadePeixe()
function atividadePeixe() {
    let kg = parseFloat(prompt("Digite quantos kilos de peixe você deseja comprar: "))
    let preco1 = kg * 50
    let preco2 = kg * 55.9

    if (kg < 100) {
        console.log(`Preço total: R$ ${preco1}`)
    } else {
        console.log(`Preço total: R$ ${preco2}`)
    }
}
