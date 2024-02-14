﻿using System;
namespace WebApi.Dtos.RequestDtos
{
	public class UsuarioFiltroParametroDto
	{

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int? Edad { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Telefono { get; set; }

        public int? IdPais { get; set; }

        public UsuarioFiltroParametroDto()
		{
		}
	}
}

