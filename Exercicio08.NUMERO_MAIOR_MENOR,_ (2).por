programa
{
	
	funcao inicio()
	{
		inteiro num1, num2, num3

		escreva("\nInforme o primeiro número: \n")
		leia(num1)
		escreva("\nInforme o segundo número: \n")
		leia(num2)
		escreva("\nInforme o terceiro número: \n")
		leia(num3)

				escreva("\n***************************************\n")
		escreva("\nJÁ SEI A RESPOSTA.\n")


		se(num1 > num2 e num1 > num3){
			escreva("\nO maior número digitado é: ",num1 ,"\n")
		}
		senao se(num2>num1 e num2 > num3){
			escreva("\nO maior número digitado é: ",num2 ,"\n")
		}
		senao se(num3>num1 e num3 > num2){
			escreva("\nO maior número digitado é: ",num3 ,"\n")
		}
		se(num1 < num2 e num1 < num3){
			escreva("\nO menor número digitado é: ",num1 ,"\n")
		}
		senao se(num2 < num1 e num2 < num3){
			escreva("\nO maior número digitado é: ",num2 ,"\n")
		}
		senao se(num3<num1 e num3 < num2){
			escreva("\nO maior número digitado é: ",num3 ,"\n")
		}
		

		

			
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 918; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */