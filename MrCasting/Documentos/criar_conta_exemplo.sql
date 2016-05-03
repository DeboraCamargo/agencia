/*
delete from Hobby
delete from Endereco
delete from conta
delete from Candidato
delete from Pessoa
delete from Contato
delete from LoginOAuth
*/
declare @LOGIN_ID int
declare @CONTATO_ID int
declare @PESSOA_ID int
declare @CANDIDATO_ID int 

insert into LoginOAuth(Email, Token, DtInclusao, DtAlteracao)
values('alexccamargo@gmail.com', 'CAAVdp8j0kssBAG0TbcPfHL2GOT5KRxQKfTDZAWD7OYmQWU4vXAaxysZBi2K9agmo53MNMZB2tQ75LqPrf3MeKMGyOqBFnItVaDZA1Rsd2uQYI1TrejYGDA0RZCGGi3uqJ1puysVXQVJienZBHZCNLioshVDpYZA0F9i4LiWGuQ5NNM7pUeXfRAjaZAdDPXgzQsOcZD', '2015-11-20 13:10:27.923', NULL)

SELECT @LOGIN_ID = SCOPE_IDENTITY()

insert into Contato(Email_EnderecoDeEmail, Telefone_Numero, Telefone_DDD, DtInclusao, DtAlteracao)
values('alexccamargo@gmail.com', 991400799, 11, '2015-11-20 13:10:27.937', NULL)
SELECT @CONTATO_ID = SCOPE_IDENTITY()

insert into Pessoa(Cpf_Codigo, DataNascimento, Sexo, Nome, SobreNome, FotoPerfil, DtInclusao, DtAlteracao, idContato)
values (31743357877, '1983-06-20', 1, 'alex','' , NULL, '2015-11-20 13:10:27.937', NULL, @CONTATO_ID)
SELECT @PESSOA_ID = SCOPE_IDENTITY()

insert into Candidato (OrientacaoSexual, DRT, NomeFantasia, SobrenomeFantasia, Profissao, Realise, Naturalidade, Nacionalidade, DtInclusao, DtAlteracao, IdCaracteristicaFisica, IdPessoa, IdInteresse)
values (0, NULL, 'Alex Artista', NULL, NULL, NULL, NULL, NULL, '2015-11-20 13:10:27.937', NULL, NULL, @PESSOA_ID, 2)
SELECT @CANDIDATO_ID = SCOPE_IDENTITY()

insert into conta(Tipo, DtInclusao, DtAlteracao, Candidato_Id, Login_Id, Scouter_Id)
values (0, '2015-11-20 13:10:27.937', NULL, @CANDIDATO_ID, @LOGIN_ID, NULL)
