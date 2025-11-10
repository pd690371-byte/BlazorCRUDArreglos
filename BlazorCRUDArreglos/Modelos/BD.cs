namespace BlazorCRUDArreglos.Modelos
{
    public class BD
    {
        public List<Persona>? Personas { get; set; }

        public List<Estudiante>? Estudiantes { get; set; }

        public List<Carrera>? Carreras { get; set; }

        public List<Nacionalidad>? Nacionalidades { get; set; }

        public List<Religion>? Religiones { get; set; }

        public List<Ocupacion>? Ocupaciones { get; set; }

        public List<Departamento>? Departamentos { get; set; }
        public List<AFP>? AFP { get; set; }
        public List<ARS>? ARS { get; set; }
        public List<Facultad>? Facultades { get; set; }
        public List<GradoAcademico>? GradosAcademicos { get; set; }

        //TODO: Agrega otro List<Clase>, List<Estudiante>, List<Profesor>...
    }
}
