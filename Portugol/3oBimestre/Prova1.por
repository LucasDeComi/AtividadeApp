programa {
  funcao inicio() {
    inteiro id
    real nota1, nota2, nota3, ME, MA
    cadeia msg
    caracter conceito
    escreva("Qual o seu número? ")
    leia(id)
    escreva("Qual foi a sua primeira nota? ")
    leia(nota1)
    escreva("Qual foi a sua segunda nota? ")
    leia(nota2)
    escreva("Qual foi a sua terceira nota? ")
    leia(nota3)
    escreva("Qual foi a média dos seus exercícios? ")
    leia(ME)
    MA = (nota1 + nota2 * 2 + nota3 * 3 + ME) / 7
    se(MA >= 9) {
      conceito = 'A'
      msg = "Aprovado"
    }
    senao se(MA >= 7.5) {
      conceito = 'B'
      msg = "Aprovado"
    } 
    senao se(MA >= 6) {
      conceito = 'C'
      msg = "Aprovado"
    }
    senao se(MA >= 4) {
      conceito = 'D'
      msg = "Reprovado"
    }
    senao {
      conceito = 'E'
      msg = "Reprovado"
    }
    escreva("Aluno: ", id, "\n")
    escreva("Nota 1: ", nota1, "\n")
    escreva("Nota 2: ", nota2, "\n")
    escreva("Nota 3: ", nota3, "\n")
    escreva("Média dos Exercícios: ", ME, "\n")
    escreva("Média de Aproveitamento: ", MA, "\n")
    escreva("Conceito: ", conceito, "\n")
    escreva("Você foi ", msg)
  }
}
