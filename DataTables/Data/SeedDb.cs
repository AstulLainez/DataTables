using DataTables.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTables.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckUsuarioAsync();
        }

        private async Task CheckUsuarioAsync()
        {
            if (!_context.Usuarios.Any())
            {
                AddUsuario("Manuel", "Hernandez",20, "Usulutan ", "Estudiante",400);
                AddUsuario("Carlos", "Hernandez",23, "Usulutan ", "Estudiante",500);
                AddUsuario("Emanuel", "Lainez",30, "San Salvador", "Estudiante",300);
                AddUsuario("Rafa", "Turcios",40, "Santa Ana", "Estudiante",600);
                AddUsuario("Irvin", "Lopez",20, "Santa Tecla", "Estudiante",700);
                AddUsuario("Alfre", "Duran",25, "San Miguel ", "Estudiante",800);
                AddUsuario("Rojo", "Salgado",26, "Usulutan ", "Estudiante",300);
                AddUsuario("Edgar", "Orto",27, "Usulutan ", "Estudiante",300);
                AddUsuario("Luis", "Hernandez",28, "Usulutan ", "Estudiante",300);
                AddUsuario("Manuel", "Hernandez", 20, "Usulutan ", "Estudiante", 300);
                AddUsuario("Carlos", "Hernandez", 23, "Usulutan ", "Estudiante", 300);
                AddUsuario("Emanuel", "Lainez", 30, "San Salvador", "Estudiante", 300);
                AddUsuario("Rafa", "Turcios", 40, "Santa Ana", "Estudiante", 300);
                AddUsuario("Irvin", "Lopez", 20, "Santa Tecla", "Estudiante", 300);
                AddUsuario("Alfre", "Duran", 25, "San Miguel ", "Estudiante", 300);
                AddUsuario("Rojo", "Salgado", 26, "Usulutan ", "Estudiante", 300);
                AddUsuario("Edgar", "Orto", 27, "Usulutan ", "Estudiante", 300);
                AddUsuario("Luis", "Hernandez", 28, "Usulutan ", "Estudiante", 300);

                await _context.SaveChangesAsync();
            }
        }

        private void AddUsuario(string nombre, string apellido, int edad, string direccion, string profesion, double salario)
        {
            _context.Usuarios.Add(new Usuario
            {
                Nombre =nombre,
                Apellido=apellido,
                Edad=edad,
                Direccion=direccion,
                Profesion=profesion,
                Salario=salario
            });
        }
    }
}
