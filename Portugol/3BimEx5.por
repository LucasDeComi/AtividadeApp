programa {
  funcao inicio() {
    real altura, peso, imc
    escreva("Digite a sua altura em metros: ")
    leia(altura)
    escreva("Digite o seu peso em quilos: ")
    leia(peso)
    imc = peso / altura * altura
    escreva("O seu IMC é igual a ", imc, "\n", "Classificação: ")
    se(imc < 17) {
      escreva("Magreza Severa")
    }
    senao se(imc < 18.5) {
      escreva("Magreza Leve")
    }
    senao se(imc < 25) {
      escreva("Peso Normal")
    }
    senao se(imc < 30) {
      escreva("Sobrepeso")
    }
    senao se(imc < 35) {
      escreva("Obesidade Classe I")
    }
    senao se(imc < 40) {
      escreva("Obesidade Classe II")
    }
    senao {
      escreva("Obesidade Classe III")
    }
  }
}
