using FluentValidation;
using System;

namespace Pontuacao_Basquete_Business.Validations { 
    public class PartidaValidation : AbstractValidator<Partida>
    {
        public PartidaValidation()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;
            RuleFor(Partida => Partida.Pontos).GreaterThan(0).WithMessage("Você não pode ter marcado pontuação negativa");
            RuleFor(Partida => Partida.Dia).LessThan(DateTime.Now).WithMessage("Você não pode cadastrar registros de partidas do futuro");

        }
    }
}