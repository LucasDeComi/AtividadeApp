programa {
  funcao inicio() {
    cadeia nome
    caracter sexo 
    inteiro idade 
    real salario, renda
    escreva("Qual seu nome? ")
    leia(nome)
    escreva("Qual sua idade? ")
    leia(idade)
    escreva("Qual seu sexo? (M/F) ")
    leia(sexo)
    escreva("Qual seu salário fixo? ")
    leia(salario)
    se(sexo == "M" ou sexo == "m"){
      se(idade >= 30)
        renda = salario + 100
      senao
        renda = salario + 50
    }
    senao se(sexo == "F" ou sexo == "f"){
      se(idade >= 30)
        renda = salario + 250
      senao
        renda = salario + 150
    }
    escreva(nome, ", a sua renda total é de R$", renda)
  }
}
