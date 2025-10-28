programa {
  funcao inicio() {
    inteiro I = 10
    real result
    escreva("°C | °F\n")
    enquanto(I <= 100)
    {
    result = (I * 1.8) + 32
    escreva(I, " | ", result, "\n")
    I += 10
    }  
  }
}
