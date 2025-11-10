using Microsoft.EntityFrameworkCore;
using System;
using BlazorCRUDArreglos.Modelos;

namespace BlazorCRUDArreglos.Modelos
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext>options) : base (options)
        {

        }
        public DbSet<BlazorCRUDArreglos.Modelos.Profesor> Profesor { get; set; } = default!;
        public DbSet<BlazorCRUDArreglos.Modelos.Ocupacion> Ocupacion { get; set; } = default!;
        public DbSet<BlazorCRUDArreglos.Modelos.Carrera> Carrera { get; set; } = default!;
        public DbSet<BlazorCRUDArreglos.Modelos.AFP> AFP { get; set; } = default!;
        public DbSet<BlazorCRUDArreglos.Modelos.ARS> ARS { get; set; } = default!;
        public DbSet<BlazorCRUDArreglos.Modelos.Estudiante> Estudiante { get; set; } = default!;
        public DbSet<BlazorCRUDArreglos.Modelos.Empleado> Empleado { get; set; } = default!;
        public DbSet<BlazorCRUDArreglos.Modelos.Nacionalidad> Nacionalidad { get; set; } = default!;
        public DbSet<BlazorCRUDArreglos.Modelos.Persona> Personas { get; set; } = default!;
        public DbSet<BlazorCRUDArreglos.Modelos.Religion> Religion { get; set; } = default!;
        public DbSet<BlazorCRUDArreglos.Modelos.Departamento> Departamentos { get; set; } = default!;
        public DbSet<BlazorCRUDArreglos.Modelos.Facultad> Facultades { get; set; } = default!;
        public DbSet<BlazorCRUDArreglos.Modelos.GradoAcademico> GradosAcademicos { get; set; } = default!;
    }
}
