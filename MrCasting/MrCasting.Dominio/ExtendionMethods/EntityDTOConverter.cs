using MrCasting.Domain.Entities;
using MrCasting.Domain.DTO;
using MrCasting.Domain.ValueObject;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Text;

namespace MrCasting.Domain.ExtendionMethods
{
    public static class EntityDTOConverter
    {
        #region Metodos  Auxiliares

        private static string GetCPFFromPessoa(Pessoa pessoa)
        {
            if (pessoa.Cpf != null)
                return pessoa.Cpf.Codigo.ToString();
            else return null;
        }

        private static List<Tags> GetTagsFromDTO(List<TagsDTO> tags)
        {
            if (tags == null)
                return null;
            else
                return tags.Select(t => t.ToTags()).ToList();
        }

        private static EnderecoDTO GetEnderecoDTOFromEndereco(Endereco endereco)
        {
            if (endereco == null)
                return null;
            else
                return endereco.ToEnderecoDTO();
        }

        private static Endereco GetEnderecoFromEnderecoDTO(EnderecoDTO enderecoDTO)
        {
            if (enderecoDTO == null)
                return null;
            else
                return enderecoDTO.ToEndereco();
        }

        private static Pessoa GetPessoaFromDTO(PessoaDTO pessoaDTO)
        {
            if (pessoaDTO == null)
                return null;
            else
                return pessoaDTO.ToPessoa();
        }

        private static CaracteristicasFisicas GetCaracteristicaFisicaFromDTO(CaracteristicasFisicasDTO caracteristicaFisicaDTO)
        {
            if (caracteristicaFisicaDTO == null)
                return null;
            else
                return caracteristicaFisicaDTO.ToCaracteristicasFisicas();
        }

        private static Interesse GetInteresseFromDTO(InteresseDTO interessesDTO)
        {
            if (interessesDTO == null)
                return null;
            else
                return interessesDTO.ToInteresse();
        }

        private static Contato GetContatoFromContatoDTO(ContatoDTO contatoDTO)
        {
            if (contatoDTO == null)
                return null;
            else
                return contatoDTO.ToContato();
        }

        private static InteresseDTO GetDTOFromInteresses(Interesse interesse)
        {
            if (interesse == null)
                return null;
            else
                return interesse.ToInteresseDTO();
        }

        private static VideoDTO GetDTOFromVideo(VideoObj video)
        {
            if (video == null)
                return null;
            else
                return video.ToVideoDTO();
        }

        private static VideoObj GetVideoFromDTO(VideoDTO videoDTO)
        {
            if (videoDTO == null)
                return null;
            else
                return videoDTO.ToVideo();
        }

        private static FotoDTO GetDTOFromFoto(FotoObj foto)
        {
            if (foto == null)
                return null;
            else
                return foto.ToFotoDTO();
        }

        private static FotoObj GetFotoFromDTO(FotoDTO fotoDTO)
        {
            if (fotoDTO == null)
                return null;
            else
                return fotoDTO.ToFoto();
        }

        private static ScouterDTO GetDTOFromScouter(Scouter scouter)
        {
            if (scouter == null)
                return null;
            else
                return scouter.ToScouterDTO();
        }

        private static Scouter GetScouterFromDTO(ScouterDTO scouterDTO)
        {
            if (scouterDTO == null)
                return null;
            else
                return scouterDTO.ToScouter();
        }

        private static VagaDTO GetDTOFromVaga(Vaga vaga)
        {
            if (vaga == null)
                return null;
            else
                return vaga.ToVagaDTO();
        }

        private static Vaga GetVagaFromDTO(VagaDTO vagaDTO)
        {
            if (vagaDTO == null)
                return null;
            else
                return vagaDTO.ToVaga();
        }

        private static PropostaDTO GetDTOFromProposta(Proposta proposta)
        {
            if (proposta == null)
                return null;
            else
                return proposta.ToPropostaDTO();
        }

        private static Proposta GetPropostaFromDTO(PropostaDTO propostaDTO)
        {
            if (propostaDTO == null)
                return null;
            else
                return propostaDTO.ToProposta();
        }

        private static HabilidadeDTO GetDTOFromHabilidade(Habilidade habilidade)
        {
            if (habilidade == null)
                return null;
            else
                return habilidade.ToHabilidadeDTO();
        }

        private static Habilidade GetHabilidadeFromDTO(HabilidadeDTO habilidadeDTO)
        {
            if (habilidadeDTO == null)
                return null;
            else
                return habilidadeDTO.ToHabilidade();
        }

        private static HobbyDTO GetDTOFromHobby(Hobby hobby)
        {
            if (hobby == null)
                return null;
            else
                return hobby.ToHobbyDTO();
        }

        private static Hobby GetHobbyFromDTO(HobbyDTO hobbyDTO)
        {
            if (hobbyDTO == null)
                return null;
            else
                return hobbyDTO.ToHobby();
        }


        private static CandidatoDTO GetDTOFromCandidato(Candidato candidato)
        {
            if (candidato == null)
                return null;
            else
                return candidato.ToCandidatoDTO();
        }

        private static Candidato GetCandidatoFromDTO(CandidatoDTO candidatoDTO)
        {
            if (candidatoDTO == null)
                return null;
            else
                return candidatoDTO.ToCandidato();
        }


        private static LoginOAuthDTO GetDTOFromLoginOAuth(LoginOAuth loginOAuth)
        {
            if (loginOAuth == null)
                return null;
            else
                return loginOAuth.ToLoginOAuthDTO();
        }

        private static LoginOAuth GetLoginOAuthFromDTO(LoginOAuthDTO loginOAuthDTO)
        {
            if (loginOAuthDTO == null)
                return null;
            else
                return loginOAuthDTO.ToLoginOAuth();
        }

        #endregion

        public static Pessoa ToPessoa(this PessoaDTO pessoaDTO)
        {
            Pessoa pessoa = new Pessoa(pessoaDTO.Nome, pessoaDTO.Sobrenome, pessoaDTO.DataNascimento, new Cpf(pessoaDTO.Cpf), pessoaDTO.Sexo, GetContatoFromContatoDTO(pessoaDTO.Contato))
            {
                Id = pessoaDTO.Id,
                Endereco = GetEnderecoFromEnderecoDTO(pessoaDTO.Endereco),
                //Login = pessoaDTO.Login,
                FotoPerfil = GetFotoPerfilFromPessoaDTO(pessoaDTO)
            };

            return pessoa;
        }

        public static PessoaDTO ToPessoaDTO(this Pessoa pessoa)
        {
            ContatoDTO contatoDTO = null;
            if (pessoa.Contato != null)
                contatoDTO = pessoa.Contato.ToContatoDTO();


            return new PessoaDTO()
            {
                Id = pessoa.Id,
                Cpf = GetCPFFromPessoa(pessoa),
                Nome = pessoa.Nome,
                Sobrenome = pessoa.SobreNome,
                DataNascimento = pessoa.DataNascimento,
                //Login = pessoa.Login,
                Endereco = GetEnderecoDTOFromEndereco(pessoa.Endereco),
                Contato = contatoDTO,
                Sexo = pessoa.Sexo,
                FotoPerfil = GetFotoPerfilFromPessoa(pessoa)
            };
        }

        private static string GetFotoPerfilFromPessoa(Pessoa pessoa)
        {
            if (pessoa.FotoPerfil != null)
                return Convert.ToBase64String(pessoa.FotoPerfil);
            else
                return null;
        }

        private static byte[] GetFotoPerfilFromPessoaDTO(PessoaDTO pessoaDTO)
        {
            if (pessoaDTO.FotoPerfil != null)
                return Convert.FromBase64String(pessoaDTO.FotoPerfil);
            else
                return null;
        }

        public static Candidato ToCandidato(this CandidatoDTO candidatoDTO)
        {
            Candidato candidato = new Candidato(GetPessoaFromDTO(candidatoDTO.DadosPessoais), candidatoDTO.NomeFantasia, GetInteresseFromDTO(candidatoDTO.Interesse))
            {
                SobrenomeFantasia =  candidatoDTO.SobrenomeFantasia,
                Id = candidatoDTO.Id,
                Nacionalidade = candidatoDTO.Nacionalidade,
                Naturalidade = candidatoDTO.Naturalidade,
                DRT = candidatoDTO.DRT,
                OrientacaoSexual = candidatoDTO.OrientacaoSexual,
                Profissao = candidatoDTO.Profissao,
                Realise = candidatoDTO.Realise,
                CaracteristicaFisica = GetCaracteristicaFisicaFromDTO(candidatoDTO.CaracteristicaFisica),
                Tags = GetTagsFromDTO(candidatoDTO.Tags),

                //Os metodos GET sempre retornam um tipo dTo e não uma lista, não parece fazer muito sentido retornar uma lista de dto
                //AlbumVideos = GetVideoFromDTO(candidatoDTO.AlbumVideos),
                //AlbumFotos = GetFotoFromDTO(candidatoDTO.AlbumFotos),
                //Hobby = GetHobbyFromDTO(candidatoDTO.Hobby),
                //Habilidade = GetHabilidadeFromDTO(candidatoDTO.Habilitade),

            };

            return candidato;
        }

        public static CandidatoDTO ToCandidatoDTO(this Candidato candidato)
        {
            PessoaDTO pessoaDTO = null;
            if (candidato.DadosPessoais != null)
                pessoaDTO = candidato.DadosPessoais.ToPessoaDTO();

            CaracteristicasFisicasDTO caracteristicasFisicasDTO = null;
            if (candidato.CaracteristicaFisica != null)
                caracteristicasFisicasDTO = candidato.CaracteristicaFisica.ToCaracteristicasFisicasDTO();

            List<HabilidadeDTO> habilidadeDTO = null;
            if (candidato.Habilidade != null)
                habilidadeDTO = candidato.Habilidade.Select(h => h.ToHabilidadeDTO()).ToList();

            List<HobbyDTO> hobbyDTO = null;
            if (candidato.Hobby != null)
                hobbyDTO = candidato.Hobby.Select(h => h.ToHobbyDTO()).ToList();

            List<TagsDTO> tagDTO = null;
            if (candidato.Tags != null)
                tagDTO = candidato.Tags.Select(t => t.ToTagsDTO()).ToList();

            return new CandidatoDTO()
            {
                DadosPessoais = pessoaDTO,
                Id = candidato.Id,
                NomeFantasia = candidato.NomeFantasia,
                Profissao = candidato.Profissao,
                Realise = candidato.Realise,
                OrientacaoSexual = candidato.OrientacaoSexual,
                CaracteristicaFisica = caracteristicasFisicasDTO,
                DRT = candidato.DRT,
                SobrenomeFantasia = candidato.SobrenomeFantasia,
                Habilitade = habilidadeDTO,
                Hobby = hobbyDTO,
                Tags = tagDTO,
                Interesse = GetDTOFromInteresses(candidato.Interesse),
                Nacionalidade = candidato.Nacionalidade,
                Naturalidade = candidato.Naturalidade,
            };
        }

        public static Interesse ToInteresse(this InteresseDTO interesseDTO)
        {
            return new Interesse()
            {
                Id = interesseDTO.Id,
                Ator = interesseDTO.Ator,
                Evento = interesseDTO.Evento,
                Figurante = interesseDTO.Figurante,
                Modelo = interesseDTO.Modelo,
                ModeloPlusSize = interesseDTO.ModeloPlusSize,
                Mirin = interesseDTO.Mirim,
                Outros = interesseDTO.Outros
            };
        }

        public static InteresseDTO ToInteresseDTO(this Interesse interesse)
        {
            return new InteresseDTO()
            {
                Id = interesse.Id,
                Ator = interesse.Ator,
                Evento = interesse.Evento,
                Figurante = interesse.Figurante,
                Modelo = interesse.Modelo,
                ModeloPlusSize = interesse.ModeloPlusSize,
                Mirim = interesse.Mirin,
                Outros = interesse.Outros

            };
        }

        public static Hobby ToHobby(this HobbyDTO hobbyDTO)
        {
            return new Hobby(hobbyDTO.NomeHobby)
            {
                IdCandidato = hobbyDTO.IdCandidato,
                Id = hobbyDTO.Id

            };
        }

        public static HobbyDTO ToHobbyDTO(this Hobby hobby)
        {
            return new HobbyDTO()
            {
                NomeHobby = hobby.NomeHobby,
                IdCandidato = hobby.IdCandidato,
                Id = hobby.Id
            };
        }

        public static Tags ToTags(this TagsDTO TagsDTO)
        {
            return new Tags(TagsDTO.Tag);
        }

        public static TagsDTO ToTagsDTO(this Tags tags)
        {
            return new TagsDTO()
            {
                Tag = tags.Tag,
            };
        }

        public static Habilidade ToHabilidade(this HabilidadeDTO habilidadeDTO)
        {
            return new Habilidade(habilidadeDTO.NomeHabilidade)
            {
                IdCandidato = habilidadeDTO.IdCandidato,
                Id = habilidadeDTO.Id
            };
        }

        public static HabilidadeDTO ToHabilidadeDTO(this Habilidade habilidade)
        {
            return new HabilidadeDTO()
            {
                NomeHabilidade = habilidade.NomeHabilidade,
                IdCandidato = habilidade.IdCandidato,
                Id = habilidade.Id
            };
        }

        public static EnderecoDTO ToEnderecoDTO(this Endereco endereco)
        {
            EnderecoDTO dto = new EnderecoDTO()
            {
                Id = endereco.Id,
                Bairro = endereco.Bairro,
                Cidade = endereco.Cidade,
                Complemento = endereco.Complemento,
                Logradouro = endereco.Logradouro,
                Numero = endereco.Numero,
                Uf = endereco.Uf,
            };
            if (endereco.Cep != null)
                dto.Cep = endereco.Cep.GetCepFormatado();
            return dto;

        }

        public static Endereco ToEndereco(this EnderecoDTO enderecoDTO)
        {

            Endereco endereco = new Endereco(enderecoDTO.Cidade, enderecoDTO.Uf)
            {
                Id = enderecoDTO.Id,
                Bairro = enderecoDTO.Bairro,
                Cep = new Cep(enderecoDTO.Cep),
                Complemento = enderecoDTO.Complemento,
                Logradouro = enderecoDTO.Logradouro,
                Numero = enderecoDTO.Numero,
            };

            if (!string.IsNullOrEmpty(enderecoDTO.Cep))
                endereco.Cep = new Cep(enderecoDTO.Cep);
            return endereco;
        }

        public static ContatoDTO ToContatoDTO(this Contato contato)
        {
            return new ContatoDTO()
            {
                Email = contato.Email.EnderecoDeEmail,
                Telefone = contato.Telefone.DDD+contato.Telefone.Numero,
                //DDD = contato.Telefone.DDD
            };
        }

        public static Contato ToContato(this ContatoDTO contatoDTO)
        {
            return new Contato(new Email(contatoDTO.Email), new Telefone(contatoDTO.Telefone));
        }

        public static CaracteristicasFisicas ToCaracteristicasFisicas(this CaracteristicasFisicasDTO caracteristicasFisicasDTO)
        {
            CaracteristicasFisicas carac = new CaracteristicasFisicas();


            carac.Altura = caracteristicasFisicasDTO.Altura;
            carac.Busto = caracteristicasFisicasDTO.Busto;
            carac.ComprimentoCabelo = caracteristicasFisicasDTO.ComprimentoCabelo;
            carac.Camisa = caracteristicasFisicasDTO.Camisa;
            carac.CorOlhos = caracteristicasFisicasDTO.CorOlhos;
            carac.CorPele = caracteristicasFisicasDTO.CorPele;
            carac.Cintura = caracteristicasFisicasDTO.Cintura;
            carac.Descendencia = caracteristicasFisicasDTO.Descendencia;
            carac.Etnia = caracteristicasFisicasDTO.Etnia;
            carac.Id = caracteristicasFisicasDTO.Id;
            carac.Manequim = caracteristicasFisicasDTO.Manequim;
            carac.Peso = caracteristicasFisicasDTO.Peso;
            carac.Quadril = caracteristicasFisicasDTO.Quadril;
            carac.Sapato = caracteristicasFisicasDTO.Sapato;
            carac.Sapato = caracteristicasFisicasDTO.Sapato;
            carac.Terno = caracteristicasFisicasDTO.Terno;
            carac.TipoCabelo = caracteristicasFisicasDTO.TipoCabelo;
            carac.TipoFisico = caracteristicasFisicasDTO.TipoFisico;
            carac.Torax = caracteristicasFisicasDTO.Torax;

            return carac;
        }

        public static CaracteristicasFisicasDTO ToCaracteristicasFisicasDTO(this CaracteristicasFisicas caracteristicasFisicas)
        {
            return new CaracteristicasFisicasDTO()
            {
                Altura = caracteristicasFisicas.Altura,
                Busto = caracteristicasFisicas.Busto,
                Camisa = caracteristicasFisicas.Camisa,
                Cintura = caracteristicasFisicas.Cintura,
                ComprimentoCabelo = caracteristicasFisicas.ComprimentoCabelo,
                CorPele = caracteristicasFisicas.CorPele,
                Descendencia = caracteristicasFisicas.Descendencia,
                CorOlhos = caracteristicasFisicas.CorOlhos,
                Etnia = caracteristicasFisicas.Etnia,
                Manequim = caracteristicasFisicas.Manequim,
                Peso = caracteristicasFisicas.Peso,
                Quadril = caracteristicasFisicas.Quadril,
                Sapato = caracteristicasFisicas.Sapato,
                Terno = caracteristicasFisicas.Terno,
                TipoCabelo = caracteristicasFisicas.TipoCabelo,
                Torax = caracteristicasFisicas.Torax,
                TipoFisico = caracteristicasFisicas.TipoFisico,
                Id = caracteristicasFisicas.Id
            };
        }

        public static VideoObj ToVideo(this VideoDTO videoDTO)
        {
            return new VideoObj()
            {
                IdCandidato = videoDTO.IdCandidato,
                Id = videoDTO.Id

            };
        }

        public static VideoDTO ToVideoDTO(this VideoObj video)
        {
            return new VideoDTO()
            {
                DataCriacao = video.DataCriacao,
                IdCandidato = video.IdCandidato,
                Video = video.Video,
                Id = video.Id,
                NomeVideo = video.NomeVideo

            };
        }

        public static FotoObj ToFoto(this FotoDTO fotoDTO)
        {
            return new FotoObj()
            {
                IdCandidato = fotoDTO.IdCandidato,
                Id = fotoDTO.Id,
                Foto = Convert.FromBase64String(fotoDTO.Foto),
                NomeFoto = fotoDTO.NomeFoto,
                DataCriacao = fotoDTO.DataCriacao

            };
        }

        public static FotoDTO ToFotoDTO(this FotoObj foto)
        {
            return new FotoDTO()
            {

                DataCriacao = foto.DataCriacao,
                Foto = Convert.ToBase64String(foto.Foto),
                Id = foto.Id,
                IdCandidato = foto.IdCandidato,
                NomeFoto = foto.NomeFoto

            };
        }

        public static Scouter ToScouter(this ScouterDTO scouterDTO)
        {
            return new Scouter(scouterDTO.Id, GetPessoaFromDTO(scouterDTO.dadosPessoaisScouter), scouterDTO.Cnpj)
            {
                Agencia = scouterDTO.Agencia,

            };
        }

        public static ScouterDTO ToScouterDTO(this Scouter scouter)
        {

            PessoaDTO pessoaDTO = null;
            if (scouter.DadosPessoais != null)
                pessoaDTO = scouter.DadosPessoais.ToPessoaDTO();

            return new ScouterDTO()
            {
                dadosPessoaisScouter = pessoaDTO,
                Agencia = scouter.Agencia,
                Cnpj = scouter.Cnpj,
                Id = scouter.Id

            };
        }

        public static Vaga ToVaga(this VagaDTO vagaDTO)
        {
            return new Vaga(vagaDTO.Id, vagaDTO.TituloVaga, GetScouterFromDTO(vagaDTO.ProprietarioVaga))
            {
                DescricaoVaga = vagaDTO.DescricaoVaga,
                Status = vagaDTO.Status

            };
        }

        public static VagaDTO ToVagaDTO(this Vaga vaga)
        {
            ScouterDTO scouterDTO = null;
            if (vaga.ProprietarioVaga != null)
                scouterDTO = vaga.ProprietarioVaga.ToScouterDTO();
            return new VagaDTO()
            {
                DescricaoVaga = vaga.DescricaoVaga,
                ProprietarioVaga = scouterDTO,
                TituloVaga = vaga.TituloVaga,
                Id = vaga.Id,
                Status =vaga.Status

            };
        }

        public static Proposta ToProposta(this PropostaDTO propostaDTO)
        {
            return new Proposta(GetVagaFromDTO(propostaDTO.vaga), propostaDTO.DataExpiraProposta, propostaDTO.DataEntrevista)
            {
                Cache = propostaDTO.Cache,
                DataEntrevista = propostaDTO.DataEntrevista,
                DataExpiraProposta = propostaDTO.DataExpiraProposta,
                DataFimJob = propostaDTO.DataFimJob,
                DataIncioJob = propostaDTO.DataIncioJob,
                DetalhesProposta = propostaDTO.DetalhesProposta,
                Id = propostaDTO.id,
                NaoTemFinalDataDefinida = propostaDTO.NaoTemFinalDataDefinida,
                Status = propostaDTO.Status

            };
        }

        public static PropostaDTO ToPropostaDTO(this Proposta proposta)
        {
            VagaDTO vagaDTO = null;
            if (proposta.Vaga != null)
                vagaDTO = proposta.Vaga.ToVagaDTO();

            return new PropostaDTO()
            {
                vaga = vagaDTO,
                NaoTemFinalDataDefinida = proposta.NaoTemFinalDataDefinida,
                Cache = proposta.Cache,
                DataEntrevista = proposta.DataEntrevista,
                DataExpiraProposta = proposta.DataExpiraProposta,
                DataFimJob = proposta.DataFimJob,
                DataIncioJob = proposta.DataIncioJob,
                DetalhesProposta = proposta.DetalhesProposta,
                id = proposta.Id,
                Status = proposta.Status
            };
        }

        public static LoginOAuthDTO ToLoginOAuthDTO(this LoginOAuth login)
        {
            return new LoginOAuthDTO()
            {
                Email = login.Email,
                Token = login.Token,
                Id = login.Id
            };
        }

        public static LoginOAuth ToLoginOAuth(this LoginOAuthDTO login)
        {
            return new LoginOAuth(login.Email)
            {
                Token = login.Token,
                Id = login.Id
            };
        }

        public static Conta ToConta(this ContaDTO contaDTO)
        {
            Conta conta = null;
            if (contaDTO.Tipo == Enuns.TipoConta.Candidato)
            {
                conta = new Conta(GetLoginOAuthFromDTO(contaDTO.Login), GetCandidatoFromDTO(contaDTO.Candidato));
            }
            else
            {
                conta = new Conta(GetLoginOAuthFromDTO(contaDTO.Login), GetScouterFromDTO(contaDTO.Scouter));
            }

            return conta;
        }

        public static ContaDTO ToContaDTO(this Conta conta)
        {
            ContaDTO contaDTO = null;
            if (conta.Tipo == Enuns.TipoConta.Candidato)
            {
                contaDTO = new ContaDTO()
                {
                    Login = GetDTOFromLoginOAuth(conta.Login),
                    Candidato = GetDTOFromCandidato(conta.Candidato)
                };
            }
            else
            {
                contaDTO = new ContaDTO()
                {
                    Login = GetDTOFromLoginOAuth(conta.Login),
                    Scouter = GetDTOFromScouter(conta.Scouter)
                };
            }

            return contaDTO;
        }

    }
}
