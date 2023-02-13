using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

public class LibroBLL {
   private Contexto _contexto;

   public LibroBLL(Contexto contexto) {
      _contexto = contexto;
   }

   public bool Existe(int libroId) {
      return _contexto.libro.Any(o => o.LibroId == libroId);
   }
   public bool Insertar(Libro libro) {
      _contexto.libro.Add(libro);
      return _contexto.SaveChanges() > 0;
   }

   public bool Modificar(Libro libro) {
      _contexto.Entry(libro).State = EntityState.Modified;
      return _contexto.SaveChanges() > 0;
   }

   public bool Guardar(Libro libro) {
      if (!Existe(libro.LibroId))
         return this.Insertar(libro);
      else
         return this.Modificar(libro);
   }

   public Libro ? Buscar(int libroid) {
      return _contexto.libro
         .Where(o => o.LibroId == libroid)
         .AsNoTracking()
         .SingleOrDefault();
   }

   public List <Libro> LibroList() {
      return _contexto.libro.ToList();
   }
   
}



