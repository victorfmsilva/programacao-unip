algoritmo "C60"
// Função :
// Autor :
// Data : 14/9/2020
// Seção de Declarações 
var
nota1, nota2, nota3, nota4, me :real
inicio
// Seção de Comandos
   leia(nota1, nota2, nota3, nota4)
   me <- (nota1+nota2+nota3+nota4)/4
   se (me >= 5) entao
      escreval("Aprovado",me)
   senao
      escreval("Reprovado",me)
   fimse

fimalgoritmo
