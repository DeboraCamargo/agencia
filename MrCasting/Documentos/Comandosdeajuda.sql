select * from Pessoa
select * from Candidato
select * from Contato
select * from Endereco
select * from CaracteristicasFisicas


insert into Pessoa values(33550028873,'1989-01-07', 'Debora camargo','logindebora',newid(),NEWID(),GETDATE(),null, 1,null)
insert into Contato values('test@teste.com','985424740','011',GETDATE(),null)
insert into Candidato values('debmania','varredor',null, GETDATE(),null,4)


insert into Pessoa values(33550028873,'1989-01-07', 'Debora camargo','logindebora',newid(),NEWID(),GETDATE(),null, 1,null)
insert into Contato values('test@teste.com','985424740','011',GETDATE(),null)
insert into Candidato values('debmania','varredor',null, GETDATE(),null,4)


Update Pessoa set Senha = NEWID()

drop table Pessoa
drop table Contato
drop table Endereco
drop table Candidato
drop table CaracteristicasFisicas


delete from __MigrationHistory





-- INSERINDO

select * from contato 

select * from Pessoa

select * from Candidato

insert into contato (Email_EnderecoDeEmail,Telefone_DDD,Telefone_Numero,DtInclusao)
values('alex@gmail.com','11','991400799',GETDATE())

insert  into pessoa (CPF_Codigo, DataNascimento, Nome, SobreNome, DtInclusao, sexo, TokenAlteracaoDeSenha, idContato)
values(31743357877, '1983-06-20', 'Alex', 'Camargo',GETDATE(), 2, newid(), 2)

insert into Candidato (DtInclusao, IdPessoa, NomeFantasia, SobrenomeFantasia, Profissao, Naturalidade, Nacionalidade)
values (GETDATE(), 5, 'Alex', '', '', '', '')

update Candidato set OrientacaoSexual = 0 where id = 5
update Candidato set DRT = 'DRT10' where id = 5

