using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVCClinica.Data;
using MVCClinica.Models;

namespace MVCClinica.Admin
{
    public class AdmMedico
    {
        private static ClinicaDbContext context = new ClinicaDbContext();

        public static List<Medico> Listar()
        {
            return context.Medicos.ToList();
        }

        public static Medico Listar(int id)
        {
            return context.Medicos.Find(id);
        }

        public static Medico Buscar(int id)
        {
            Medico medico = context.Medicos.Find(id);
            context.Entry(medico).State = EntityState.Detached;
            return medico;
        }

        public static void Cargar(Medico medico)
        {
            context.Medicos.Add(medico);
            context.SaveChanges();
        }

        public static void Modificar(Medico medico)
        {
            context.Medicos.Attach(medico);
            context.SaveChanges();
        }

        public static void Eliminar(Medico medico)
        {
            context.Medicos.Remove(medico);
            context.SaveChanges();
        }

        public static List<Medico> ListarEspecialidad(string especialidad)
        {
            List<Medico> medicosEspecialidad = (from o in context.Medicos
                                                where o.Especialidad == especialidad
                                                select o).ToList();
            return medicosEspecialidad;
        }
    }
}