algoritmo "pg 36 ex D"
// Função :
// Autor :
// Data : 24/8/2020
// Seção de Declarações 
var
   distancia,tempo,velocidade, litros:real
inicio
// Seção de Comandos 
   Escreva("Qual o tempo gasto: ")
   Leia(tempo)

   Escreva("Qual a velocidade media: ")
   Leia(velocidade)
   
   distancia <- tempo * velocidade
   Escreva("A distancia é: ", distancia)
   
   litros <- distancia / 12
   Escreval(" LITROS USADOS: ", litros)
   
fimalgoritmo
