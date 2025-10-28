programa {
  funcao inicio() {
    inteiro comodo, I
		real largura, comprimento, areaComodo, areaTotal = 0

		escreva("Quantos cômodos tem a residência? ")
		leia(comodo)

		para (I = 1; I <= comodo; I++)
    {
			escreva("Cômodo ", I, "\n")
			escreva("Informe a largura (em metros): \n")
			leia(largura)
			escreva("Informe o comprimento (em metros): ")
			leia(comprimento)

			areaComodo = largura * comprimento
			escreva("Área do cômodo ", I, ": ", areaComodo, " m²\n")
      areaTotal += areaComodo
		} 
	   	escreva("Área total da residência: ", areaTotal, " m²")

  }
}
