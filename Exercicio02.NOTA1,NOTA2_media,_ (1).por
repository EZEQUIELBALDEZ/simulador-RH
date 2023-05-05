programa
{
	
	funcao inicio()
	{

		real nota1, nota2, media

		


		escreva("\nQual sua primeira nota? \n")
		leia(nota1)

		escreva("\nQual sua segunda nota? \n")
		leia(nota2)

		media = (nota1 + nota2) / 2

		escreva("\nSua média foi ", media ,"\n")



		se(media < 6)
		{
			escreva("\n---------------------------\n")
			escreva("\nvocê foi Reprovado.\n")
			escreva("\n---------------------------\n")
		}
		senao
		{
			escreva("\n----------------------------\n")
			escreva("\nParabéns você foi aprovado.\n")
			escreva("\n----------------------------\n")
		}

		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 210; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */