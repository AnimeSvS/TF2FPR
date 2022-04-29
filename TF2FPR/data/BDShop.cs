using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

//Librerias de SQLite
using SQLite;
using TF2FPR.model;

namespace TF2FPR.data
{
    public class BDShop
    {
        private readonly SQLiteAsyncConnection db;
        public BDShop(string dbPath)
        {
            //CREA UNA CONEXION ASINCRONA DE BUSQUEDA Y EXTRAE LA RUTA DE LA BASE DE DATOS
            db = new SQLiteAsyncConnection(dbPath);
            //CREA LA TABLA BASADO EN LA ESTRUCTURA DE SHOPMODEL
            db.CreateTableAsync<UserModel>();
            db.CreateTableAsync<ShopModel>();
        }

        ///USUSARIOS
        //CREARA O INSERTARA EL OBJETO Y DEVOLVERA UN VALAOR ENTERO DE LAS FILAS AGREGADAS
        public Task<int> CreateUsuario(UserModel userModel)
        {
            return db.InsertAsync(userModel);
            //---------------------------------------------------------------------------------
        }
        //LEERA LOS DATOS DE LA TABLA Y LO DEVOLVERA A UNA INTERFAZ DONDE SE PUEDA CONSULTAR
        public Task<List<UserModel>> ReadUsuario()
        {
            return db.Table<UserModel>().ToListAsync();
            //---------------------------------------------------------------------------------
        }
        //ACTUALIZARA LA BASE DE DATOS EN FUNCION DEL OBJETO QUE SE LE PASO
        public Task<int> UpdateUsuario(UserModel userModel)
        {
            return db.UpdateAsync(userModel);
            //---------------------------------------------------------------------------------
        }
        //ELIMINA AL OBJETO QUE SE PASO Y RETORNA LAS FILAS ELIMINADAS
        public Task<int> DeleteAgenda(UserModel userModel)
        {
            return db.DeleteAsync(userModel);
            //---------------------------------------------------------------------------------
        }
        //BUSCA CADA USUARIO POR EL NOMBRE
        public Task<List<UserModel>> Search(string search)
        {
            return db.Table<UserModel>().Where(p => p.NombreApellido.StartsWith(search)).ToListAsync();
        }


        ///PRODUCTOS
         //CREARA O INSERTARA EL OBJETO Y DEVOLVERA UN VALAOR ENTERO DE LAS FILAS AGREGADAS
        public Task<int> CreateProducto(ShopModel shopModel)
        {
            return db.InsertAsync(shopModel);
            //---------------------------------------------------------------------------------
        }
        //LEERA LOS DATOS DE LA TABLA Y LO DEVOLVERA A UNA INTERFAZ DONDE SE PUEDA CONSULTAR
        public Task<List<ShopModel>> ReadProducto()
        {
            return db.Table<ShopModel>().ToListAsync();
            //---------------------------------------------------------------------------------
        }
        //ACTUALIZARA LA BASE DE DATOS EN FUNCION DEL OBJETO QUE SE LE PASO
        public Task<int> UpdateProducto(ShopModel shopModel)
        {
            return db.UpdateAsync(shopModel);
            //---------------------------------------------------------------------------------
        }
        //ELIMINA AL OBJETO QUE SE PASO Y RETORNA LAS FILAS ELIMINADAS
        public Task<int> DeleteProducto(ShopModel shopModel)
        {
            return db.DeleteAsync(shopModel);
            //---------------------------------------------------------------------------------
        }
        //BUSCA CADA USUARIO POR EL NOMBRE
        public Task<List<ShopModel>> SearchProducto(string searchP)
        {
            return db.Table<ShopModel>().Where(p => p.NombreP.StartsWith(searchP)).ToListAsync();
        }


    }
}
    