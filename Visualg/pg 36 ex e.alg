algoritmo "pg 36 ex 8"
// Função :
// Autor :
// Data : 24/8/2020
// Seção de Declarações 
var
  valor_prestacao_normal, taxa, atraso:real
inicio
// Seção de Comandos 
   Escreva("Qual o valor da prestação: ")
   Leia(valor_prestacao_normal)
   
   Escreva("Qual o valor da taxa: ")
   Leia(taxa)
   
   Escreva("Qual o tempo de atraso ?")
   Leia(atraso)
   
   prestacao_a_pagar_juros <- valor_prestacao_normal + (valor_prestacao_normal * (taxa/100) * tempo)
   Escreva ("Valor a pagar: ",prestacao_a_pagar_juros)
fimalgoritmo
