programa
{
	
	funcao inicio()
	{
		inteiro peso, altura, imc

	
		escreva("\nQual seu peso? \n")
		leia(peso)

		escreva("\nQual sua altura? \n")
		leia(altura)

		imc = peso / (altura*altura)

		escreva("\nIMC = ",imc,"\n")

		se (imc < 17)
		{
			 escreva("\n Muito abaixo do peso\n")   
		}  
		senao se(imc >= 17 e imc<18){
        		escreva("\nAbaixo do peso\n")  
		}
		senao se(imc >= 18 e imc<24){
        		escreva("\nPeso normal\n")
		}
		senao se(imc >= 25 e imc<29){
          	escreva("\nAcima do peso\n")     
		}
		senao se(imc >= 30 e imc<=34){
           	escreva("\nObesidade | \n")
		}
		senao se(imc >= 35 e imc<=39){
           	escreva("\nObesidade || (severa) \n")
		}
		se(imc > 40){
           	 escreva("\n Obesidade ||| (mórbida) \n")
		}


		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 773; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */