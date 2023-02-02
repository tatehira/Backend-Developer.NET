Execptions = excessão
*********************
	- Ou seja, Exception, é algo que não ta planejado para acontecer

try - catch
***********
	-try = tente
	-catch = Se der errado


Disparando Exessões
*******************
	if (string.IsNullOrEmpty(texto)) //Nulo ou vazia
		throw new Exception("O texto não pode ser nulo")

Custom Exceptions
*****************
	- Pode criar seus exceptions personalizado@

Finally
*******
	- Quando a execução chega ao fim
	finally
	{
		argumento
	}