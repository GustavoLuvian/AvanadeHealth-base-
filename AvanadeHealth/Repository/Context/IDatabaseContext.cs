using Microsoft.EntityFrameworkCore;

namespace AvanadeHealth.Repository.Context
{
    public interface IDatabaseContext
    {
        DbSet<Agendamento> AGENDAMENTO { get; set; }
    }
}