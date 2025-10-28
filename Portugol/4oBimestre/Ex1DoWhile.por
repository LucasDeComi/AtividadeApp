programa {
  funcao inicio() {
    inteiro num, result, I = 1
    escreva("Digite um número para descobrir sua tabuada: ")
    leia(num)
    faca{
    result = I * num
    escreva("\n", num," X ", I, " = ", result)
    I++ 
    } enquanto(I <= 10)
  }
}