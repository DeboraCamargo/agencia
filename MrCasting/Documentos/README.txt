Installar WebEssential

Usuario BD: projetoaguia118
senha: 4A1dOT7Q5D

auditoria: soo6k7bwwv
-- Criar banco de teste
C:\Program Files\Microsoft SQL Server\110\Tools\Binn\SqlLocalDB.exe create "MrCasting" 11.0 -s

Pontos para mudar ao adicionar uma entidade:

Projeto Data
- Criar a configuracao da Entidade no EntityConfig
- Adicionar a configuração criada no Context
- Atualizar o migration com o comando 
- Update-Migration "Nome da versao atual"
- Adicionar um Repositorio para a Entidade criada

Projeto Application

- Criar um EntidadeService e criar os metodos de servico desta entidade

Migration para script

Update-Database -Script -SourceMigration:0

OAuth2.0 google

Id do cliente = 127206936686-sk65fs3g4pkeqefpv5hk37bk3s3c15ig.apps.googleusercontent.com 
Chave secreta = _nDbK0D_iR-W1HFkOqFEryGi 

