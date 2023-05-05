programa
{
	
	funcao inicio()
	{
		inteiro valor_percorre, valor_atual, distancia_KM, soma

		
		escreva("\nQuantos quilômetros o carro percorre por litro? \n ")
		leia(valor_percorre)

		escreva("\nQuantos litros tem no carro atualmente? \n")
		leia(valor_atual)

		soma = valor_percorre * valor_atual
			

 		escreva("\nQual distância (em Km) você deseja percorrer? \n")
 		leia(distancia_KM)
		
		soma = soma - distancia_KM
	
		
		se( soma <= 0 )
		{
			escreva("\n====================================================\n")
			escreva("\nVocê precisa abastecer os ",soma," litros que faltam\n")
			escreva("\n====================================================\n")
		}
		senao 
		{
			escreva("\n====================================================\n")
			escreva("\nVocê não precisa abastecer.\n")
			escreva("\n====================================================\n")
		}

	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 97; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */