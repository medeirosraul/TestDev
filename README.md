# TestDev
Aplicação demonstrativa de cadastro básico de cliente.

## Requisitos
#### Esta aplicação contem os seguintes requisitos

● Os cadastros devem conter os seguintes campos:   
 
Pessoa física:   ● CPF    ● Data de nascimento   ● Nome    ● Sobrenome (15 caracteres)   ● CEP (8 caracteres)   ● Logradouro    ● Número   ● Complemento   ● Bairro   ● Cidade   ● UF (8 caracteres)   
   
Pessoa jurídica:   ● CNPJ   ● Razão social   ● Nome fantasia   ● CEP   ● Logradouro   ● Número   ● Complemento   ● Bairro   ● Cidade   ● UF   

#### As seguintes restrições devem ser respeitadas:
   
● Todos os campos devem ser de preenchimento obrigatório, exceto o campo complemento.   
● Colocar a máscara de formatação nos campos CPF e CNPJ.   
● A idade permitida para cadastro de uma pessoa física deverá ser no mínimo de 19 anos.   
● A tela para o cadastro deverá ser única.    
● Porém, quando selecionado pessoa física deverão ser exibidos somente os campos relacionados à pessoa física, e quando selecionado pessoa jurídica deverão ser exibidos somente os campos de pessoa jurídica.    

## Atributos técnicos
- Feito em ASP.NET Core MVC
- Simulação de banco de dados na memória
- Validação em cliente e servidor
- Aproximadamente 4 horas totais de desenvolvimento
