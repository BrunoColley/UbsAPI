using UBSAPI.Models;

namespace UBSAPI.Services
{
    public class MedicoService
    {
        MedicoModel Medico1 = new()
        {
            Crm = "1",
            Nome = "Dra. Ana",
            Especialidade = "Clínica geral"
        };

        MedicoModel Medico2 = new()
        {
            Crm = "2",
            Nome = "Dr. João",
            Especialidade = "Cardiologista"
        };

        private static List<MedicoModel> _ListaMedicos = new List<MedicoModel> { 

        //Validação se o CRM do Médico Existe
        new MedicoModel {
            Crm = "2101PE",
        Nome = "Dra. Ana",
        Telefone = "81977742345",
        Especialidade = "Clínica geral"},
        new MedicoModel {
            Crm = "2304PE",
        Nome = "Dr. João",
        Especialidade = "Cardiologista" }
    };
}
}
