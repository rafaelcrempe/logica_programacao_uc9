let prompt = require("prompt-sync")()



function name() {

    let nome = prompt("Digite o seu nome: ")

    if (nome.length < 3) {
        console.log("Nome inválido")
        name()
        return
    }
}


function idade() {
    let _idade = parseInt(prompt("Digite a sua idade: "))

    if (_idade > 100) {
        console.log("Idade inválida!")
        idade()
        return
    } else if (_idade < 18) {
        console.log("Você é menor de idade e não pode se cadastar nesse sistema!")
        return
    }
}

function cpf() {

    let _cpf = prompt("Digite o seu CPF: ")
    _cpf = _cpf.replaceAll("-", "")
    _cpf.replaceAll(".", "")

    if (_cpf.length != 11) {
        console.log("CPF inválido")
        cpf()
        return
    }
}


function email() {
    let _email = prompt("Digite o seu email: ")

    if (_email.includes("@") == false || _email.includes(".") == false || _email.length < 10) {
        console.log("Email inválido")
        email()
        return
    }
}

function senha() {
    let _senha = prompt("Digite a sua senha (mínimo de 6 caracteres): ")

    if (_senha.length < 6) {
        console.log("Senha inválida. Mínimo de 6 caracteres!")
        senha()
        return
    }
    
    let confirma_senha = prompt("Digite a sua senha novamente: ")

    if(_senha != confirma_senha) {
        console.log("As senhas não coincidem")
        senha()
        return
    }


}


name()
idade()
cpf()
email()
senha()
console.log("\nUsuário cadastrado com sucesso!")

