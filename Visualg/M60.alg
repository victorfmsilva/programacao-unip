algoritmo "M60"
// Fun��o :
// Autor :
// Data : 21/9/2020
// Se��o de Declara��es 
var
   sexo, nome : Caractere
inicio
// Se��o de Comandos
   leia(sexo, nome)
   se (sexo = "M ") ou (sexo = "m") entao
      escreval("Ilmo Sr.", nome)
   senao
        se (sexo = "F") ou (sexo = "f")
           escreval("Ilmo Sra.", nome)
        senao
             escreval("Sexo invalido")
        fimse
   fimse
   
fimalgoritmo
