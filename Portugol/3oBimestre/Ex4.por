programa {
  funcao inicio() {
    inteiro codigo
    escreva("Digite o código do lanche: ")
    leia(codigo)
    escolha(codigo) {
      caso 100:
        escreva("Lanche: Cachorro Quente", "\n", "Preço Unitário: R$25,00")
        pare
      caso 101:
        escreva("Lanche: Bauru", "\n", "Preço Unitário: R$15,00")
        pare
      caso 102:
        escreva("Lanche: X-Burguer", "\n", "Preço Unitário: R$35,00")
        pare
      caso 103:
        escreva("Lanche: Triplo X-Burguer", "\n", "Preço Unitário: R$47,00")
        pare
      caso contrario:
        escreva("Lanche Inexistente", "\n", "Lanches Disponíveis: 100, 101, 102, 103")
    }
  }
}