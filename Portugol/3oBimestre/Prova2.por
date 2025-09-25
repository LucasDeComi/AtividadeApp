programa {
  funcao inicio() {
    inteiro cod
    real preco, desconto, total
    escreva("Digite o código da sua região: ")
    leia(cod)
    escreva("Digite o preço do produto: ")
    leia(preco)
    escolha(cod) {
      caso 1:
        desconto = 5 / 100
        pare
      caso 2:
        desconto = 15 / 100
        pare
      caso 3:
        desconto = 7 / 100
        pare
      caso 4:
        desconto = 12 / 100
        pare
      caso 5:
        desconto = 20 / 100
        pare
      caso contrario:
        escreva("O produto é importado e não possui desconto.", "\n")
        desconto = 0
        pare
    }
    total = preco * desconto
    escreva("O valor do desconto é de R$", total)
  }
}
