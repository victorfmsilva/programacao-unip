algoritmo "pg 36 ex D"
// Fun��o :
// Autor :
// Data : 24/8/2020
// Se��o de Declara��es 
var
   distancia,tempo,velocidade, litros:real
inicio
// Se��o de Comandos 
   Escreva("Qual o tempo gasto: ")
   Leia(tempo)

   Escreva("Qual a velocidade media: ")
   Leia(velocidade)
   
   distancia <- tempo * velocidade
   Escreva("A distancia �: ", distancia)
   
   litros <- distancia / 12
   Escreval(" LITROS USADOS: ", litros)
   
fimalgoritmo
