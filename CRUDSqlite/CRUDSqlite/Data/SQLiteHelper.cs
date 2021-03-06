using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using CRUDSqlite.Models;
using System.Threading.Tasks;

namespace CRUDSqlite.Data
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Alumno>().Wait();
        }

        public Task <int> SaveAlumnoAsync(Alumno alum)
        {
            if (alum.idAlumno != 0)
            {
                return db.UpdateAsync(alum);
            }
            else
            {
                return db.InsertAsync(alum);
            }
        }

        public Task<int> DeleteAlumnoAsync(Alumno alumno)
        {
            return db.DeleteAsync(alumno);
        }


        public Task<List<Alumno>> GetAlumnosAsync()
        {
            return db.Table<Alumno>().ToListAsync();
        }

        public Task<Alumno> GetAlumnoByIdAsync(int idAlumno)
        {
            return db.Table<Alumno>().Where(a => a.idAlumno == idAlumno).FirstOrDefaultAsync();
        }

    }
}
