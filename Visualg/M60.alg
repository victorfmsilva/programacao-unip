algoritmo "M60"
// Função :
// Autor :
// Data : 21/9/2020
// Seção de Declarações 
var
   sexo, nome : Caractere
inicio
// Seção de Comandos
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
