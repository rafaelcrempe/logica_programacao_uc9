let salsicha = 3.5
let pure = 2.15
let salada = 1.90

let pao  = 0.9
let batata_palha = 0.50
let catchup = 0.10
let maionese = 0.15
let fixos = pao + batata_palha + catchup + maionese

let dog_simples = salsicha + pure + fixos
let dog_duplo = (salsicha * 2) + pure + salada + fixos 
let dog_especial = (salsicha * 3) + (pure * 2) + salada + fixos

console.log("Cardápio:\nDog Simples: RS$ "+dog_simples.toFixed(2)+"\nDog Duplo: R$: "+dog_duplo.toFixed(2)+"\nDog Especial: R$ "+dog_especial.toFixed(2))


