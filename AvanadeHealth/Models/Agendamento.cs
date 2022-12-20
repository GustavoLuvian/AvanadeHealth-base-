using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvanadeHealth.Models;

public class Agendamento
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Required(ErrorMessage = "A identificação do agendamento é obrigatória")]
    public double IdAgendamento { get; set; }
    [Required(ErrorMessage = "O nome do hospital é obrigatório")]
    [StringLength(50, ErrorMessage = "O nome do hospital deve ter no máximo 50 caracteres")]
    [Display(Name = "Nome do Hospital")]
    public double IdHospital { get; set; }
    [Required(ErrorMessage = "A especialidade é obrigatória")]
    [Display(Name = "Especialidade")]   
    public string idEspecialidade { get; set; }

    [Required(ErrorMessage = "O profissional é obrigatório")]
    [Display(Name = "Profissional")]
    public double idProfissional { get; set; }

    [Required(ErrorMessage = "A identificação de Beneficiário é obrigatória")]
    [Display(Name = "Beneficiário")]
    public double idBeneficiario { get; set; }

    [Required(ErrorMessage = "A data e hora do agendamento é obrigatória")]
    [Display(Name = "Data e Hora do Agendamento")]
    public double DataHoraAgendamento { get; set; }
    
}