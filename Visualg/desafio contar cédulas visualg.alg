algoritmo "desafio Algoritmo contar cédulas"
// Função :
// Autor :
// Data : 31/8/2020
// Seção de Declarações 
var
   v : inteiro
   n100, n50, n20, n10, n5, n2, n1, resto : inteiro
inicio
// Seção de Comandos 
   Escreva("Valor de saque: ")
   Leia(v)
   n100 <- v div 100
   resto <- resto mod 100
   
   n50 <- resto div 50
   resto <- resto mod 50
   
   n20 <- resto div 20
   resto <- resto mod 20
   
   n10 <- resto div 10
   resto <- resto mod 10
   
   n5 <- resto div 5
   resto <- resto mod 5
   
   n2 <- resto div 2
   resto <- resto mod 2
   
   n1 <- resto div 1
   resto <- resto mod 1
   
   Escreva(v, n100, n50, n20, n10, n5, n2, n1)
   
fimalgoritmo
