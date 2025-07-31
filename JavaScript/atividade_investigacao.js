let prompt = require("prompt-sync")()

let pontos = 0

let telefonou = parseInt(prompt("Você telefonou para a vítima? (1) SIM ou (2) NÃO: "))

if(telefonou == 1) {
    pontos++
}

let local = parseInt(prompt("Você estava no local do crime? (1) SIM ou (2) NÃO: "))

if (local == 1) {
    pontos++
}

let reside = parseInt(prompt("Você mora perto da vítima? (1) SIM ou (2) NÃO: "))

if (reside == 1) {
    pontos++
}

let divida = parseInt(prompt("Você devia dinheiro para a vítima? (1) SIM ou (2) NÃO: "))

if (divida == 1) {
    pontos++
}

let trabalho = parseInt(prompt("Você trabalhava com a vítima? (1) SIM ou (2) NÃO: "))

if (trabalho == 1) {
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