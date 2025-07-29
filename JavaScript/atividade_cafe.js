let cliente1 = "Rafael"
let cliente2 = "Gustavo"

let idade1 = "30"
let idade2 = "20"

let quantidade_cafe1 = 187
let quantidade_cafe2 = 5

let cadastrado1 = "True"
let cadastrado2 = "False"

let preco_cafe = 3.50

console.log("Olá!\nBem-vindo ao sistema de usuários do Rafito Cafezito\nAbaixo estão as informações dos usuários cadastrados no sistema:\n\n")
console.log("---- Lista de Usuários:\n1 - Nome: "+cliente1+", idade: "+idade1+". É cliente? "+cadastrado1)
console.log("2 - Nome: "+cliente2+", idade: "+idade2+". É cliente? "+cadastrado2)

console.log("\n\n---- Quantidade de cafés:")
console.log("O Cliente "+cliente1+" já tomou "+quantidade_cafe1+" cafés!")
console.log("O Cliente "+cliente2+" já tomou "+quantidade_cafe2+" cafés!")

console.log("\n\n---- Soma dos cafés tomados:")
console.log("Juntos, os clientes "+cliente1+" e "+cliente2+" tomaram "+ (quantidade_cafe1 + quantidade_cafe2)+ " cafés!")

console.log("\n\n---- Quantos cafés faltam para chegar em 200?")
console.log("Faltam "+ (200 - quantidade_cafe1) + " cafés para "+cliente1)
console.log("Faltam "+ (200 - quantidade_cafe2) + " cafés para "+cliente2)

console.log("\n\n--------- ATIVIDADE EXTRA ---------\n\n")

let nova_quantidade1 = quantidade_cafe1 + 15
let nova_quantidade2 = quantidade_cafe2 + 3

let gasto_total1 = nova_quantidade1 * preco_cafe
let gasto_total2 = nova_quantidade2 * preco_cafe

console.log("Novas Vendas: "+cliente1+ " comprou 15 novos cafés e "+cliente2+" comprou mais 3. A nova quantidade de cafés é:")
console.log(cliente1+": "+ nova_quantidade1)
console.log(cliente2+": "+ nova_quantidade2)

console.log("\nAo todo, "+cliente1+" gastou R$ " + (nova_quantidade1 * preco_cafe)+" em café!")
console.log("Ao todo, "+cliente2+" gastou R$ " + (nova_quantidade2 * preco_cafe)+" em café!")

console.log("\nCaso tivesse aproveitado a promoção de 50% de desconto, "+cliente1+ " teria gasto apenas R$ "+(gasto_total1 * 0.5)+".")
console.log("Caso tivesse aproveitado a promoção de 50% de desconto, "+cliente2+ " teria gasto apenas R$ "+(gasto_total2 * 0.5)+".")