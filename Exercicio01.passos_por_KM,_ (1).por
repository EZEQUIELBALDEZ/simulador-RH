programa
{
	
	funcao inicio()
	{
		real  passo, distancia
		const real METRO_POR_PASSO = 0.82
		
		escreva("Qual a distância em km? \n")
		leia(distancia)         
	
		passo = distancia /( METRO_POR_PASSO / 1000)
		escreva("\nquantidade de passos: ", passo)
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 135; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */
