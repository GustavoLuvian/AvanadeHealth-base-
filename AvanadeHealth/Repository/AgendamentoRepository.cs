using AvanadeHealth.Models;
using AvanadeHealth.Repository.Context;

namespace AvanadeHealth.Repository
{
    public class AgendamentoRepository
    {
        public readonly AvanadeHealthContext context;
        public AgendamentoRepository()
        {
            context = new AvanadeHealthContext();
        }

        public IList<Agendamento> List()
        {
            return context.Agendamentos.ToList();
        }
        
        public void Insert (Agendamento agendamento)
        {
            context.Agendamentos.Add(agendamento);
            context.SaveChanges();
        }
        
        public void Delete(int Id)
        {
            context.AGENDAMENTO.Remove(Check(Id));
            context.SaveChanges();
        }
    }
}

