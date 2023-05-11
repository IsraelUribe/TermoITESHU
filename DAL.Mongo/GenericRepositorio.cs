using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using COMMON.Entidades;
using COMMON.Interfaces;
using COMMON.Validadores;

namespace DAL.Mongo
{
    public class GenericRepositorio<T> : IGenericRepositorio<T> where T : Base
    {
        string cadenaConexion = @"";
        MongoClient mongoClient;
        IMongoDatabase db;
        BaseValidator<T> validator;
        protected IMongoCollection<T> Coleccion() => db.GetCollection<T>(typeof(T).Name);
        public GenericRepositorio(BaseValidator<T> validator)
        {
            Error = "";
            mongoClient = new MongoClient(cadenaConexion);
            db = mongoClient.GetDatabase("TermoITESHU.db");
            this.validator = validator;
        }
        public string Error { get; protected set; }

        public IEnumerable<T> Get
        {
            get
            {
                try
                {
                    Error = "";
                    return Coleccion().AsQueryable();
                }
                catch (Exception ex)
                {
                    Error = ex.Message;
                    return null;
                }
            }
            
        }

        public bool Delete(string id)
        {
            try
            {
                Error = "";
                return Coleccion().DeleteOne(id).DeletedCount > 0;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }
        }

        public T GetById(string id)
        {
            try
            {
                Error = "";
                return Query(e=>e.Id==id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                Error = ex.Message;;
                return null;
            }
        }

        public T Insert(T entity)
        {
            entity.Id = Guid.NewGuid().ToString();
            entity.FechaHora = DateTime.Now;
            entity.Habilitado = true;
            var validationResult = validator.Validate(entity);
            if (validationResult.IsValid)
            {
                try
                {
                    Error = "";
                    Coleccion().InsertOne(entity);
                    return entity;
                }
                catch(Exception ex)
                {
                    Error = ex.Message;
                    return null;
                }
            }
            else
            {
                Error = "Existen errores de validación";
                foreach(var item in validationResult.Errors)
                {
                    Error += item.ErrorMessage + ". ";
                }
                return null;
            }
        }

        public IEnumerable<T> Query(Expression<Func<T, bool>> predicado)
        {
            try
            {
                Error = "";
                return Coleccion().Find(predicado).ToEnumerable();
            }
            catch(Exception ex)
            {
                Error = ex.Message;
                return null;
            }
        }

        public T Update(T entity)
        {
            entity.FechaHora = DateTime.Now;
            entity.Habilitado = true;
            var validationResult = validator.Validate(entity);
            if (validationResult.IsValid)
            {
                try
                {
                    Error = "";
                    return Coleccion().ReplaceOne(e => e.Id == entity.Id, entity).ModifiedCount == 1 ? entity : null;
                }
                catch(Exception ex)
                {
                    Error = ex.Message;
                    return null;
                }
            }
            else
            {
                Error = "Existen errores de validación";
                foreach(var item in validationResult.Errors)
                {
                    Error += item.ErrorMessage + ". ";
                }
                return null;
            }
        }
    }
}
