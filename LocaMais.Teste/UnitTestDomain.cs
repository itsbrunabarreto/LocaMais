using LocaMais.Domain.Entities;
using System.Diagnostics;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace LocaMais.Teste
{
    [TestClass]
    public class UnitTestDomain
    {
        [TestMethod]
        public void TestCidade()
        {
            Cidade cidade = new Cidade(1, "Birigui", "SP");

            Debug.WriteLine(JsonSerializer.Serialize(cidade));

            Assert.AreEqual(cidade.Nome, "Birigui");
            Assert.AreEqual(cidade.Estado, "SP");
        }

        [TestMethod]
        public void TestUsuario()
        {
            DateTime dataCadastro = new DateTime(2024, 10, 20);
            DateTime dataLogin = new DateTime(2024, 10, 22);

            Usuario usuario = new Usuario(1, "Bruna", "be2505", "brunabarreto", "brunasantosut@gmail.com", dataCadastro, dataLogin, true);

            Debug.WriteLine(JsonSerializer.Serialize(usuario));

            Assert.AreEqual(usuario.Nome, "Bruna");
            Assert.AreEqual(usuario.Senha, "be2505");
            Assert.AreEqual(usuario.Login, "brunabarreto");
            Assert.AreEqual(usuario.Email, "brunasantosut@gmail.com");
            Assert.AreEqual(usuario.DataCadastro, dataCadastro);
            Assert.AreEqual(usuario.DataLogin, dataLogin);
            Assert.IsTrue(usuario.Status);

        }

        [TestMethod]
        public void TestTipoImovel()
        {
            TipoImovel tipoImovel = new TipoImovel(1, "Apartamento");

            Debug.WriteLine(JsonSerializer.Serialize(tipoImovel));

            Assert.AreEqual(tipoImovel.Nome, "Apartamento");
        }

        [TestMethod]
        public void TestProprietario()
        {
            Cidade cidade = new Cidade(1, "Birigui", "SP");

            Proprietario proprietario = new Proprietario(1, "Bruna", "1899745698", "Rua Wilson Troncoso,589", "Floresta", "4789975158", "brunasantos@gmail.com", cidade);
            Debug.WriteLine(JsonSerializer.Serialize(proprietario));

            Assert.AreEqual(proprietario.Nome, "Bruna");
            Assert.AreEqual(proprietario.Telefone, "1899745698");
            Assert.AreEqual(proprietario.Endereco, "Rua Wilson Troncoso,589");
            Assert.AreEqual(proprietario.Bairro, "Floresta");
            Assert.AreEqual(proprietario.Cpf, "4789975158");
            Assert.AreEqual(proprietario.Email, "brunasantos@gmail.com");
        }

        [TestMethod]
        public void TestInquilino()
        {
            Cidade cidade = new Cidade(1, "Birigui", "SP");

            Inquilino inquilino = new Inquilino(1, "Luciana", "14587914648", "18997456987", "Rua Mendes Troncoso,58", "Toselar", "lucianasantos@gmail.com", cidade);
            Debug.WriteLine(JsonSerializer.Serialize(inquilino));

            Assert.AreEqual(inquilino.Nome, "Luciana");
            Assert.AreEqual(inquilino.Cpf, "14587914648");
            Assert.AreEqual(inquilino.Telefone, "18997456987");
            Assert.AreEqual(inquilino.Endereco, "Rua Mendes Troncoso,58");
            Assert.AreEqual(inquilino.Bairro, "Toselar");
            Assert.AreEqual(inquilino.Email, "lucianasantos@gmail.com");
        }

        [TestMethod]

        public void TestImovel()
        {
            var imovel = new Imovel();
            var proprietario = new Proprietario();
            var tipoImovel = new TipoImovel();
            var cidade = new Cidade();

            tipoImovel.Nome = "Apartamento";
            proprietario.Nome = "Bruna";
            cidade.Nome = "Birigui";

            imovel.Nome = "Apartamento Patrimonio Silvares";
            imovel.Endereco = "Rua Angelo Folini, 896";
            imovel.PrecoAluguel = 600;
            imovel.Disponivel = true;
            imovel.Proprietario = proprietario;
            imovel.TipoImovel = tipoImovel; 
            imovel.Cidade = cidade;

            Console.WriteLine(JsonSerializer.Serialize(imovel));
            Assert.AreEqual(imovel.Nome, "Apartamento Patrimonio Silvares");
            Assert.AreEqual(imovel.Endereco, "Rua Angelo Folini, 896");
            Assert.AreEqual(imovel.PrecoAluguel, 600);
            Assert.AreEqual(imovel.Disponivel, true);
            Assert.AreEqual(imovel.Proprietario, proprietario);
            Assert.AreEqual(imovel.TipoImovel, tipoImovel);
            Assert.AreEqual(imovel.Cidade, cidade);

        }

        [TestMethod]

        public void Contrato()
        {
            DateTime dataFim = new DateTime(2026, 10, 22); 
            
            var contrato = new Contrato();
            var imovel = new Imovel();
            var inquilino = new Inquilino();
            var proprietario = new Proprietario();

            imovel.Nome = "Apartamento Patrimonio Silvares";
            imovel.Endereco = "Rua Angelo Folini, 896";
            imovel.PrecoAluguel = 600;

            inquilino.Nome = "Luciana";
            inquilino.Endereco = "Rua Wilson Troncoso, 589";
            inquilino.Email = "lucianapaulina@gmail.com";
            inquilino.Cpf = "14587914648";

            proprietario.Nome = "Bruna";
            proprietario.Cpf = "4789975158";
            proprietario.Endereco = "Rua Mendes Troncoso,58";

            contrato.DataInicio = DateTime.Today;
            contrato.DataFim = dataFim;
            contrato.ValorAluguel = 600;
            contrato.Inquilino = inquilino;
            contrato.Proprietario = proprietario;
            contrato.Imovel = imovel;

            Console.WriteLine(JsonSerializer.Serialize(contrato));
            Assert.AreEqual(contrato.DataInicio, DateTime.Today);
            Assert.AreEqual(contrato.DataFim, dataFim);
            Assert.AreEqual(contrato.ValorAluguel, 600);
            Assert.AreEqual(contrato.Inquilino, inquilino);
            Assert.AreEqual(contrato.Proprietario, proprietario);
            Assert.AreEqual(contrato.Imovel, imovel);
        }
    }
}