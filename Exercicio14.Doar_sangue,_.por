programa
{
	
	funcao inicio()
	{
	inteiro idade, peso
	caracter opcao

		escreva("\nQual sua idade? \n")
		leia(idade)
		se(idade < 19)
		{
			escreva("\n*********************************\n")
			escreva("\nInfelizmente, você não pode ser doador.\n")
			escreva("\n*********************************\n")
		}
		se(idade > 69)
		{
			escreva("\n*********************************\n")
			escreva("\nInfelizmente, você não pode ser doador.\n")
			escreva("\n*********************************\n")
		}

		escreva("\nQual seu peso?\n")
		leia(peso)
		se(peso < 50)
		{
			escreva("\n*********************************\n")
			escreva("\nInfelizmente, você não pode ser doador.\n")
			escreva("\n*********************************\n")
		}

		escreva("\nVocê fez alguma tatuagem no último ano (s ou n)?\n")
		leia(opcao)
		escolha (opcao)
		{
			caso 's':
			caso 'S':
				escreva("\n*********************************\n")
				escreva("\nInfelizmente, você não pode ser doador.\n")
				escreva("\n*********************************\n")
				pare
		}
		escreva("\nVocê ingeriu álcool nas últimas 12 horas (s ou n)?\n")
		leia(opcao)
		escolha (opcao)
		{
			caso 's':
			caso 'S':
				escreva("\n*********************************\n")
				escreva("\nInfelizmente, você não pode ser doador.\n")
				escreva("\n*********************************\n")
				pare
				
			caso 'n':
			caso 'N':
				escreva("\n*********************************\n")
				escreva("\nParabéns, você pode doar sangue. \n")
				escreva("\n*********************************\n")
				pare
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 477; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */
