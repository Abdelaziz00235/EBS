using EBS.Entity.Entities;
namespace EBS.Business.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> BGetProductWithSubCategory_PurchaseOrder_Brand();
        List<Product> BGetProductCreatedByEmployee(int id);
        
        List<Product> BGetProductSearchKeyValueWithSubCategory(string? searchKeyValue);
        

        void BShowOnHome(int id);
        void BDontShowOnHome(int id);
        void BProductChangeStautsIsTrue(int id);
        void BProductChangeStautsIsFalse(int id);


        // Statistics

        //le nombre de produit le plus enciennement enregistrer dans le stock
        //le nombre de produit le plus nouvellement enregistrer dans le stock
        //le nombre de commande effectuer par jour

        //Nombre total de Categorie en stock
        int BSubCategoryCount();

        //quantite total de produit en stock
        int BProductQuantitySum();


    }
}
