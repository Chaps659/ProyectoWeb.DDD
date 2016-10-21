using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.DDD.MVC.ViewModel;
using WebApplication.Dominio.Entidades;

namespace WebApplication.DDD.MVC.AutoMapper
{
    public class DomainToVewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<AlumnoViewModel, Alumno>();

        }
}