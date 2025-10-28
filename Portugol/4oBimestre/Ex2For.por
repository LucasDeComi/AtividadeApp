programa {
  funcao inicio() {
    inteiro I
    real result
    escreva("°C | °F\n")
    para(I = 10; I <= 100; I += 10)
    {
    result = (I * 1.8) + 32
    escreva(I, " | ", result, "\n")
    }  
  }
}