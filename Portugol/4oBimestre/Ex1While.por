programa {
  funcao inicio() {
    inteiro num, result, I = 1
    escreva("Digite um número para descobrir sua tabuada: ")
    leia(num)
    enquanto(I <= 10){
    result = I * num
    escreva("\n", num," X ", I, " = ", result)
    I++ 
    } 
  }
}