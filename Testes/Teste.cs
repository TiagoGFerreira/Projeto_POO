using Dados;
using Excecoes;
using Objetos;
using Regras;

namespace Testes
{
    [TestClass]
    public class Teste
    {
        private string NomeFicheiro = "ficheiro.bin";
        private Pessoa Pessoa1 = null!;
        private Paciente Paciente1 = null!;


        [TestInitialize]
        public void Setup()
        {
            Pessoa1 = new Pessoa("Tiago", new DateTime(2004, 08, 19), "Feminino");
            Paciente1 = new Paciente(234135678, Pessoa1);
        }


        [TestMethod]
        public void TesteGuardarPacientes()
        {

            Pessoa pessoa = Pessoa1;
            Pessoa pessoa1 = new Pessoa("Joao", new DateTime(2001, 03, 24), "Masculino");

            Paciente paciente1 = Paciente1;
            Paciente paciente2 = new Paciente(873918291, pessoa);

            Pacientes.AdicionarPaciente(paciente1);

            Pacientes.AdicionarPaciente(paciente2);

            bool resultado = Pacientes.GuardarPacientes(NomeFicheiro);

            
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TesteMedicoExiste()
        {

            Medico medico1 = new Medico(Pessoa1,EspecialidadeMedica.Oncologia);
            Medico medico2 = new Medico(Pessoa1, EspecialidadeMedica.Oncologia);

            RegrasHospital.AdicionarMedico(medico1);

            Assert.ThrowsException<ExisteException>(() =>
            {
                 RegrasHospital.AdicionarMedico(medico2);
            });
        }

        [TestMethod]
        public void TesteRemoverPacienteInexistente()
        {
            Paciente paciente = Paciente1;

            bool resultado = RegrasHospital.RemoverPaciente(paciente);

            Assert.IsFalse(resultado);
        }



    }
}