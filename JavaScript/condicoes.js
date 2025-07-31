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

// atividadePeixe()
// atividadePositivoNegativo()
// compraCreditoDebito()
// validarCPF()
// somaAcrescimo()
// ordemCrescente()

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

// Pergunte um número para o usuário e mostre se o número é positivo ou negativo

function atividadePositivoNegativo () {

    let numero = parseFloat(prompt("Digite um número: "))

    if(numero < 0) {
        console.log(`O número ${numero} é negativo`)
    } else {
        console.log(`O número ${numero} é positivo`)
    }

}

/* Pergunte o valor da compra para o usuário e pergunte se a compra será no crédito ou no débito.
   Compras no crédito tem um acréscimo de 5% no valor da compra enquanto débito tem 10% de desconto*/

function compraCreditoDebito(){
    
    let valor_compra = parseFloat(prompt("Digite o valor da compra: "))
    let forma_pagamento = prompt("A compra será no  (1) Crédito ou (2) Débito? ")


    if (forma_pagamento == "2") {
        console.log(`O total da compra é: R$ ${valor_compra - (valor_compra * 0.1)}`)
    } else if (forma_pagamento == "1") {
        console.log(`O total da compra é: R$ ${valor_compra * 1.05}`)
     } else {
        console.log("A forma de pagamento é inválida")
     }
   }

// Peça para o usuário digitar o CPF sem pontuações. Valide o CPF e mostre se a pessoa digitou corretamente ou se está inválido

function validarCPF() {
    let cpf = prompt("Digite o seu CPF (apenas números): ")

    if (cpf.length < 11 || cpf.length > 11) {
        console.log("CPF Inválido. Deve conter 11 números!")
    } else {
        console.log("CPF válido. Obrigado!")
    }
}

// Pergunte dois números para o usuário e mostre a soma deles, acrescentando +10 se for maior do que 50 e subtraindo 20 se for menor

function somaAcrescimo() {
    let num1 = parseFloat(prompt("Digite o primeiro número: "))
    let num2 = parseFloat(prompt("Digite o segundo número: "))
    let soma = num1 + num2
    
    if (soma > 50) {
        console.log(`O valor da soma de ${num1} e ${num2} é: ${soma + 10} (acréscimo de 10)`)
    } else {
            console.log(`O valor da soma de ${num1} e ${num2} é: ${soma -20} (subtrai 20)`)
    }
}

function ordemCrescente() {
    let numero1 = parseFloat(prompt("Digite o primeiro número: "))
    let numero2 = parseFloat(prompt("Digite o segundo número: "))

    if(numero1 < numero2) {
        console.log(`Ordem crescente: ${numero1}, ${numero2}`)
    } else {
        console.log(`Ordem crescente: ${numero2}, ${numero1}`)
    }
}