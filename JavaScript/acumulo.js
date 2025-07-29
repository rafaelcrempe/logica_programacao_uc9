// Acumular valores em uma variável

let personagem = "Sônica"
let moedas = 0

console.log("Bem-vindo ao jogo")
console.log(personagem+": "+moedas+" moedas")

moedas = 1

console.log(personagem+": "+moedas+" moedas")

moedas++ // entende que a variável deve aumentar em 1
// moedas += 1    // += entende que não é pra substituir e sim somar
// moedas = moedas + 1 

console.log(personagem+": "+moedas+" moedas")

moedas++
moedas++
moedas += 5
moedas -= 2
moedas += 3

console.log(personagem+": "+moedas+" moedas")

moedas += 10
moedas = (moedas / 2)
moedas++ //checkpoint depois que pegou essas moedas

let checkpoint = moedas

moedas = (moedas * 2)

console.log(personagem+": "+moedas+" moedas")

console.log(personagem+" está morta!")

moedas = checkpoint

console.log(personagem+": "+moedas+" moedas")



