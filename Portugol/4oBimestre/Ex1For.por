programa {
  funcao inicio() {
    inteiro num, result, I
    escreva("Digite um número para descobrir sua tabuada: ")
    leia(num)
    para(I = 1; I <= 10; I++){
    result = I * num
    escreva("\n", num," X ", I, " = ", result) 
    } 
    
  }
}