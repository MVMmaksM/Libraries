using DBWorkLibraries.Context;
using DBWorkLibraries.Entities;
using DBWorkTest.Entities.Configuring;
using Microsoft.EntityFrameworkCore;

namespace DBWorkLibraries.DBWork
{
    public class DataBaseWork
    {
        public string ConnectionString { get; }
        public DataBaseWork(string connectionString)
        {
            if (!string.IsNullOrWhiteSpace(connectionString))
            {
                ConnectionString = connectionString;
            }
            else
            {
                throw new Exception("ConnectionString IsNullOrWhiteSpace");
            }
        }
        public bool DataBaseCreated()
        {
            using (var appContext = new ApplicationContext(ConnectionString))
            {
                return appContext.Database.EnsureCreated();
            }
        }

        public int InsertDetail(ICollection<Detail> details)
        {
            if (details is not null)
            {
                using (var appContext = new ApplicationContext(ConnectionString))
                {
                    appContext.Detail.AddRange(details);
                    return appContext.SaveChanges();
                }
            }
            else
            {
                throw new Exception("Details is null");
            }
        }

        public int InsertMaterial(ICollection<Material> materials)
        {
            if (materials is not null)
            {
                using (var appContext = new ApplicationContext(ConnectionString))
                {
                    appContext.Material.AddRange(materials);
                    return appContext.SaveChanges();
                }
            }
            else
            {
                throw new Exception("Materials is null");
            }
        }

        public int InsertSheet(ICollection<Sheet> sheets)
        {
            if (sheets is not null)
            {
                using (var appContext = new ApplicationContext(ConnectionString))
                {
                    appContext.Sheet.AddRange(sheets);
                    return appContext.SaveChanges();
                }
            }
            else
            {
                throw new Exception("Sheets is null");
            }
        }

        public int InsertCuttingMap(ICollection<CuttingMap> cuttingMaps)
        {
            if (cuttingMaps is not null)
            {
                using (var appContext = new ApplicationContext(ConnectionString))
                {
                    appContext.CuttingMap.AddRange(cuttingMaps);
                    return appContext.SaveChanges();
                }
            }
            else
            {
                throw new Exception("CuttingMaps is null");
            }
        }

        public ICollection<Detail> SelectSqlFromDetail(string sqlQuery)
        {
            if (!string.IsNullOrWhiteSpace(sqlQuery))
            {
                using (var appContext = new ApplicationContext(ConnectionString))
                {
                    return appContext.Detail.FromSqlRaw(sqlQuery).ToList();
                }
            }
            else
            {
                throw new Exception("SqlQuery is null");
            }
        }

        public ICollection<Material> SelectSqlFromMaterial(string sqlQuery)
        {
            if (!string.IsNullOrWhiteSpace(sqlQuery))
            {
                using (var appContext = new ApplicationContext(ConnectionString))
                {
                    return appContext.Material.FromSqlRaw(sqlQuery).ToList();
                }
            }
            else
            {
                throw new Exception("SqlQuery is null");
            }
        }

        public ICollection<Sheet> SelectSqlFromSheet(string sqlQuery)
        {
            if (!string.IsNullOrWhiteSpace(sqlQuery))
            {
                using (var appContext = new ApplicationContext(ConnectionString))
                {
                    return appContext.Sheet.FromSqlRaw(sqlQuery).ToList();
                }
            }
            else
            {
                throw new Exception("SqlQuery is null");
            }
        }

        public int UpdateDetail(ICollection<Detail> updatedDetails)
        {
            if (updatedDetails is not null)
            {
                using (var appContext = new ApplicationContext(ConnectionString))
                {
                    appContext.Detail.UpdateRange(updatedDetails); // начинаем отслеживать измененные сущности
                    return appContext.SaveChanges(); // обеовляем в БД
                }
            }
            else
            {
                throw new Exception("Details is null");
            }
        }

        public int UpdateMaterial(ICollection<Material> updatedMaterials)
        {
            if (updatedMaterials is not null)
            {
                using (var appContext = new ApplicationContext(ConnectionString))
                {
                    appContext.Material.UpdateRange(updatedMaterials); // начинаем отслеживать измененные сущности
                    return appContext.SaveChanges(); // обеовляем в БД
                }
            }
            else
            {
                throw new Exception("Updated materials is null");
            }
        }

        public int UpdateSheet(ICollection<Sheet> updatedSheets)
        {
            if (updatedSheets is not null)
            {
                using (var appContext = new ApplicationContext(ConnectionString))
                {
                    appContext.Sheet.UpdateRange(updatedSheets); // начинаем отслеживать измененные сущности
                    return appContext.SaveChanges(); // обеовляем в БД
                }
            }
            else
            {
                throw new Exception("Updated sheets is null");
            }
        }

        public int UpdateCuttingMap(ICollection<CuttingMap> updatedCuttingMaps)
        {
            if (updatedCuttingMaps is not null)
            {
                using (var appContext = new ApplicationContext(ConnectionString))
                {
                    appContext.CuttingMap.UpdateRange(updatedCuttingMaps); // начинаем отслеживать измененные сущности
                    return appContext.SaveChanges(); // обеовляем в БД
                }
            }
            else
            {
                throw new Exception("Updated cutting maps is null");
            }
        }

        public int DeleteDetail(ICollection<Detail> deletedDetails) 
        {
            if (deletedDetails is not null)
            {
                using (var appContext = new ApplicationContext(ConnectionString))
                {
                    appContext.Detail.RemoveRange(deletedDetails);
                    return appContext.SaveChanges(); // обеовляем в БД
                }
            }
            else
            {
                throw new Exception("Updated sheets is null");
            }
        }
        //public ICollection<Detail> SearchDetail(Func<Detail, bool> predicate)
        //{
        //    using (var appContext = new ApplicationContext(ConnectionString))
        //    {
        //        IQueryable<Detail> a = appContext.Detail;
        //        var c = a.Where(predicate).ToList();                
        //        return c;
        //    }
        //}
    }
}
