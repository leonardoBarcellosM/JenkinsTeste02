Feature: TesteSimples
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@AcessPage
Scenario: Access Page
	Given Access to page "http://homologacao.fundacred.org.br/estudante-web/#/"	
	Then Page loaded with sucess
