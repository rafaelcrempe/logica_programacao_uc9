let prompt = require("prompt-sync")()

let usuarios = [
    {nome: "rafael", senha: "123", admin: true},
    {nome: "gustavo", senha: "321", admin: false},
    {nome: "conrado", senha: "222", admin: false}
]

let usuario = null // cria uma variável nula

main()

function main(){
    console.log("*** SISTEMA DE LOGIN ***")
    let nome = prompt("Digite o seu nome: ")
    let senha = prompt("Digite a sua senha: ")

    autenticar(nome, senha)

    if (usuario.admin == true) {
        buscaTodos()
    } else {
        // buscaID(usuario.admin.id)
        console.log(usuario)
    }
}

function autenticar( nome,senha ){

    for(i = 0; i < usuarios.length; i++){
        if(usuarios[i].nome == nome && usuarios[i].senha == senha){
            usuario = usuarios[i]
            console.log(`Usuário [${usuario.nome}] autenticado com sucesso!`)
        }
    }

    if(usuario == null) {
        console.log("Usuário ou senha incorretos.")
    }

}
