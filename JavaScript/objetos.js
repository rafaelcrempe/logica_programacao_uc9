let prompt = require("prompt-sync")()

// Um objeto pode conter dadods de texto, números, arrays e outros objetos

function exemplo() {
    let usuario = {
        nome: "Rafael",
        idade: 30,
        telefones: ["987456541", "1234567890"],
        endereco: {
            rua: "Episcopal",
            numero: "700",
            bairro: "Centro"
        }
    }

    console.log(`O usuário ${usuario.nome} tem ${usuario.idade} anos e seus telefones são ${usuario.telefones[0]} e ${usuario.telefones[1]}`)
    console.log(usuario.endereco.bairro)
}



let produtos = [
    {
        nome: "Taça",
        preco: 25.9,
        descricao: "Feito para colocar líquidos dentro"
    },
    {
        nome: "Copo",
        preco: 25.9,
        descricao: "Feito para colocar líquidos dentro"
    },
    {
        nome: "Caneca",
        preco: 25.9,
        descricao: "Feito para colocar líquidos dentro"
    }
]

console.log(`Nome: ${produtos[0].nome}\nPreço: ${produtos[0].preco}`)