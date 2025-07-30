// Permitir um input do usuário em JS

// npm i prompt-sync // instala o prompt sync

let prompt = require("prompt-sync")()
let moment = require('moment');


function atividadeNome() {
    let nome = prompt("Digite o seu nome: ")
    let sobrenome = prompt("Digite o seu sobrenome: ")
    let nome_completo = nome + " " + sobrenome

    console.log("Seja bem vindo(a), " + nome_completo)
}


function atividadeIdade() {

    let idade = parseInt(prompt("Digite a sua idade: "))
    let idade_futura = idade + 5

    console.log("Daqui a 5 anos você terá: "+idade_futura+" anos")

}


// atividadeNascimento()
// atividadeSoma()
// atividadeMetros()
// atividadeMedia()
// atividadeTabuada()

function atividadeNascimento() {
    let nascimento = parseInt(prompt("Digite o ano do seu nascimento: "))
    let idade_atual = 2025 - nascimento

    console.log(`Você tem ${idade_atual} anos`)

}

function atividadeSoma(){
    
    let num1 = parseFloat(prompt("Digite o primeiro número: "))
    let num2 = parseFloat(prompt("Digite o segundo número: "))

    let soma = num1 + num2

    console.log(`A soma de ${num1} e ${num2} é igual a ${soma}`)
}

function atividadeMetros() {
    
    let metros = parseFloat(prompt("Digite a distância em metros: "))
    let km = metros / 1000
    
    console.log(`${metros} metro(s) equivalem à ${km} kilômetro(s).`)
}

function atividadeMedia(){
    
    let nota1 = parseFloat(prompt("Digite a primeira nota: "))
    let nota2 = parseFloat(prompt("Digite a segunda nota: "))

    let media = (nota1 + nota2) / 2

    console.log(`A média do aluno é ${media}`)
}

function atividadeTabuada(){
    let tabuada = parseInt(prompt("Digite um número para exibir a tabuada: "))
    let x2 = (tabuada * 2)
    let x3 = (tabuada * 3)
    let x4 = (tabuada * 4)
    let x5 = (tabuada * 5)
    let x6 = (tabuada * 6)
    let x7 = (tabuada * 7)
    let x8 = (tabuada * 8)
    let x9 = (tabuada * 9)
    let x10 = (tabuada * 10)

    
    console.log(`\n${tabuada}x1 = ${tabuada}`)
    console.log(`${tabuada}x2 = ${x2}`)
    console.log(`${tabuada}x3 = ${x3}`)
    console.log(`${tabuada}x4 = ${x4}`)
    console.log(`${tabuada}x6 = ${x5}`)
    console.log(`${tabuada}x7 = ${x6}`)
    console.log(`${tabuada}x8 = ${x7}`)
    console.log(`${tabuada}x9 = ${x8}`)
    console.log(`${tabuada}x10 = ${x9}`)
    console.log(`${tabuada}x10 = ${x10}`)
}

// ------------ MODO HARD ------------ 


mostrarDataPadrao()
mostrarDataAntiga()
mostrarDataBrasil()
mostrarMesesAtras()

function mostrarDataPadrao(){
    
    let data_padrão = moment().format('LLLL');
    console.log(data_padrão)
}

function mostrarDataAntiga() {
    
    let data_antiga = moment().subtract(7, 'days').calendar();
    console.log(data_antiga)
}

function mostrarDataBrasil() {

    moment.locale('pt-br')
    let data_atual = moment().format('LL')
    console.log(data_atual)

}

function mostrarMesesAtras() {
    moment.locale('pt-br')
    let meses_atras = moment().subtract(2, 'months').calendar()
    console.log(meses_atras)
}