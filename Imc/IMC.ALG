Algoritmo "semnome"

Var
altura, peso, imc: real

Inicio

Escreva ("Digite o seu peso: ")
leia (peso)

Escreva ("Digite sua altura: ")
leia (altura)

imc:= peso/(altura*altura)

Escreval ("Seu imc ?: ", imc)

se (imc <= 18.5) entao
escreval ("Voc? est? abaixo do peso")

senao
se (imc <= 24.9) entao
escreval ("Voc? est? no peso ideal")

senao
se (imc <= 29.9) entao
escreval ("Voc? est? levemente acima do peso")

senao
se (imc <= 34.9) entao
escreval ("Voc? tem obesidade de grau 1")

senao
se (imc <= 39.9) entao
escreval ("Voc? tem obesidade de grau 2")
 
senao
se (imc > 40) entao
escreval ("Voc? tem obesidade de grau 3")

fimse
FIMSE
fimse
fimse
fimse

Fimalgoritmo
