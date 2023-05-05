programa  
{
	funcao inicio ()
	{ 	
		caracter letra
		
		escreva("Informe uma letra: ")
		leia(letra)

		se 
		(
			
			letra == 'a' ou letra == 'e' ou letra == 'i' ou letra == 'o' ou letra == 'u'			
		)
		{ 
			escreva("\n", letra, " é vogal\n") 
		}
		senao
		{
			escreva("\n", letra, " é consoante\n") 
		}	
			
		escreva("\nInforme uma letra: ")
		leia(letra)

		se 
		(
			
			letra == 'a' ou letra == 'e' ou letra == 'i' ou letra == 'o' ou letra == 'u'			
		)
		{ 
			escreva("\n", letra, " é vogal\n") 
		}
		senao
		{
			escreva("\n", letra, " é consoante\n") 
		}		

		
	} 
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 330; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */