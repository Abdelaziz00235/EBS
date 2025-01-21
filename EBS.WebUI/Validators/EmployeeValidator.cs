using EBS.WebUI.DTOs.EmployeeDtos;
using FluentValidation;

namespace EBS.WebUI.Validators
{
    public class EmployeeValidator : AbstractValidator<CreateEmployeeDto>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.FullName).NotEmpty().WithMessage("Vous devez saisire le nom et prenom de l'employee") ;
            RuleFor(x => x.FullName).MaximumLength(100).WithMessage("Nom et prenom de l'employee Maxi: 100 Caracter");

            RuleFor(x => x.DepartmentId).NotEmpty().WithMessage("Vous devez rattacher votre employee a un service ou Departement");
            RuleFor(x => x.AgenceId).NotEmpty().WithMessage("Vous devez rattacher votre employee a une agence");
        }
    }
}
