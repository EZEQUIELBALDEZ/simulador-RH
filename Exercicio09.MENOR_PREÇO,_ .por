programa
{
	
	funcao inicio()
	{
		caracter produto
		real valor1, valor2, valor3
		
		escreva("usuario me informe o nome do primeiro produto? ")
		leia(produto) 
		escreva("me diqga agora o valor dele: ")
		leia(valor1)

		escreva("\n—-------------------------------------------------------------------------\n")
		escreva("usuario me informe o nome do segundo produto? ")
		leia(produto) 
		escreva("me diqga agora o valor dele: ")
		leia(valor2)

		escreva("\n—-------------------------------------------------------------------------\n")
		escreva("usuario me informe o nome do terceiro produto? ")
		leia(produto) 
		escreva("me diqga agora o valor dele: ")
		leia(valor3)

		
		se(valor1 < valor2)
		{
			se(valor1 < valor3)
			escreva("\n=========================================\n")
			escreva("\nTe recomendo comprar ",valor1,"\n")
			escreva("\n=========================================\n")
		}
		senao se(valor2 < valor1)
		{
			se(valor2 < valor3)
			escreva("\n=========================================\n")
			escreva("\nTe recomendo comprar ",valor2,"\n")
			escreva("\n=========================================\n")
		}
		se(valor3 < valor1)
		{
			se(valor3 < valor2)
			escreva("\n=========================================\n")
			escreva("\nTe recomendo comprar ",valor3,"\n")
			escreva("\n=========================================\n")	

				
		}
			
	}
}

		
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 707; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */
