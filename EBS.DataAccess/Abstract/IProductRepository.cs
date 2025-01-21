using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.DataAccess.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        List<Product> GetProductWithSubCategory_PurchaseOrder_Brand();
        List<Product> GetProductCreatedByEmployee(int id);
        List<Product> GetProductSearchKeyValueWithSubCategory(string? searchKeyValue);


        void ShowOnHome(int id);
        void DontShowOnHome(int id);
        void ProductChangeStautsIsTrue(int id);
        void ProductChangeStautsIsFalse(int id);
        


        //================= Statistique =================

        //Nombre total de Categorie en stock
        int GetSubCategoryCount();

        //Nombre total de produit en stock
        int ProductQuantitySum();


    }
}
