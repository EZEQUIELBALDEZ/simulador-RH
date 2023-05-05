programa
{
	
	funcao inicio()
	{
		cadeia nome, sexo
		escreva("Qual seu nome? ")
		leia(nome)
		escreva("Qual seu sexo? ")
		leia(sexo)

		se(sexo == "m")
		{
			escreva("Bom dia, senhor: " + nome)
		}
		senao se(sexo == "f")
		{
			escreva("Bom dia, senhora: " + nome)
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 202; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */