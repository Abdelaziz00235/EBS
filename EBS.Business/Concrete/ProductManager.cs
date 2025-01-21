using EBS.Business.Abstract;
using EBS.DataAccess.Abstract;
using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.Business.Concrete
{
    public class ProductManager : GenericManager<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductManager(IRepository<Product> _repository, IProductRepository productRepository) : base(_repository)
        {
            _productRepository = productRepository;
        }

        

        public List<Product> BGetProductCreatedByEmployee(int id)
        {
            return _productRepository.GetProductCreatedByEmployee(id);
        }

        public List<Product> BGetProductWithSubCategory_PurchaseOrder_Brand()
        {
           return _productRepository.GetProductWithSubCategory_PurchaseOrder_Brand();
        }

        public void BDontShowOnHome(int id)
        {
        _productRepository.DontShowOnHome(id);
        }
        public void BShowOnHome(int id)
        {
            _productRepository.ShowOnHome(id);
        }
        public void BProductChangeStautsIsTrue(int id)
        {
            _productRepository.ProductChangeStautsIsTrue(id);
        }
         public void BProductChangeStautsIsFalse(int id)
        {
            _productRepository.ProductChangeStautsIsFalse(id);
        }


        //================= Statistique =================

        //Nombre total de Categorie en stock
        public int BSubCategoryCount()
        {
            return _productRepository.GetSubCategoryCount();
        }

        //Nombre total de produit en stock
        public int BProductQuantitySum()
        {
            return _productRepository.ProductQuantitySum();
        }

        public List<Product> BGetProductSearchKeyValueWithSubCategory(string? searchKeyValue)
        {
            return _productRepository.GetProductSearchKeyValueWithSubCategory(searchKeyValue);
        }

       
    }
}
