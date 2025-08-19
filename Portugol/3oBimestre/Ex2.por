programa {
  funcao inicio() {
    inteiro livros, valor
    escreva("Quantos livros foram comprados? ")
    leia(livros)
    se(livros > 10)
      valor = livros * 8
    senao
      valor = livros * 12
    escreva("Você deve pagar R$", valor)
  }
}
