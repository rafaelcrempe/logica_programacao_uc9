let prompt = require("prompt-sync")()

let pontos = 0

let opcao;



let telefonou = parseInt(prompt("Você telefonou para a vítima? (1) SIM ou (2) NÃO: "))

if(isNaN(telefonou) == true){
    console.log("Digite uma resposta válida: 1 ou 2")
    return
} else if(telefonou == 1) {
    pontos++
}

let local = parseInt(prompt("Você estava no local do crime? (1) SIM ou (2) NÃO: "))

if(isNaN(local) == true){
    console.log("Digite uma resposta válida: 1 ou 2")
    return
} else if (local == 1) {
    pontos++
}

let reside = parseInt(prompt("Você mora perto da vítima? (1) SIM ou (2) NÃO: "))

if(isNaN(reside) == true){
    console.log("Digite uma resposta válida: 1 ou 2")
    return
} else if (reside == 1) {
    pontos++
}

let divida = parseInt(prompt("Você devia dinheiro para a vítima? (1) SIM ou (2) NÃO: "))

if(isNaN(divida) == true){
    console.log("Digite uma resposta válida: 1 ou 2")
    return
} else if (divida == 1) {
    pontos++
}

let trabalho = parseInt(prompt("Você trabalhava com a vítima? (1) SIM ou (2) NÃO: "))

if(isNaN(trabalho) == true){
    console.log("Digite uma resposta válida: 1 ou 2")
    return
} else if (trabalho == 1) {
    pontos++
}


console.log("Classificação:")

if (pontos >= 5){
    console.log("- Assassino")
}else if (pontos >=3){
    console.log("- Cúmplice")
} else if (pontos >=2) {
    console.log("- Suspeito")
} else {
    console.log("- Inocente")
}

