programa {
  funcao inicio() {
    inteiro publico
    real popular, geral, arquibancada, cadeira, rdp, rdg, rda, rdc, rendaTotal
    escreva("Insira o público total do jogo: ")
    leia(publico)
    popular = publico * 0.1
    geral = publico * 0.5
    arquibancada = publico * 0.3
    cadeira = publico * 0.1
    rdp = 0
    rdg = 0
    rda = 0
    rdc = 0
    se (popular > 0)
    {
      rdp = popular * 5
    }
    se (geral > 0)
    {
      rdg = geral * 10
    }
    se (arquibancada > 0)
    {
      rda = arquibancada * 20
    }
    se (cadeira > 0)
    {
      rdc = cadeira * 30
    }
    rendaTotal = rdp + rdg + rda + rdc
    escreva("A renda total do jogo foi de R$", rendaTotal)
  }
}
