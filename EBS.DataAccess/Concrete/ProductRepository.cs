using EBS.DataAccess.Abstract;
using EBS.DataAccess.Context;
using EBS.DataAccess.Repositories;
using EBS.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace EBS.DataAccess.Concrete
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _AppDbcontext;
        public ProductRepository(ApplicationDbContext _context) : base(_context)
        {
           _AppDbcontext = _context;
        }
        public List<Product> GetProductWithSubCategory_PurchaseOrder_Brand()
        {
           return _AppDbcontext.Products.Include(s => s.subCategory ).Include(p => p.purchaseOrder).Include(b => b.brand).ToList();
        }

        public void ShowOnHome(int id)
        {
            var value = _AppDbcontext.Products.Find(id);
            if (value!=null)
            {
                value.Review = true;
            }
            _AppDbcontext.SaveChanges();
        }

        public void DontShowOnHome(int id)
        {
            var value = _AppDbcontext.Products.Find(id);
            if (value != null)
            {
                value.Review = false;
            }
            _AppDbcontext.SaveChanges();
        }

        public void ProductChangeStautsIsTrue(int id)
        {
            var value = _AppDbcontext.Products.Find(id);
            if (value != null)
            {
                value.IsActived = true;
            }
            _AppDbcontext.SaveChanges();
        }
        public void ProductChangeStautsIsFalse(int id)
        {
            var value = _AppDbcontext.Products.Find(id);
            if (value != null)
            {
                value.IsActived = false;
            }
            _AppDbcontext.SaveChanges();
        }

        public List<Product> GetProductCreatedByEmployee(int id)
        {
            return _AppDbcontext.Products.Where(x => x.CreatedById ==id).ToList();
        }

        //Nombre total de Categorie en stock

        public int GetSubCategoryCount()
        {
            return _AppDbcontext.Products.Include(s => s.subCategory).GroupBy(s=>s.SubCategoryId).Count();
        }

        //Nombre total de produit en stock
        public int ProductQuantitySum()
        {
            return _AppDbcontext.Products.Sum(s => s.Quantity);
        }
        //Rechercher un produit par son nom/Sous-Categorie a partire de la page index
        public List<Product> GetProductSearchKeyValueWithSubCategory(string? searchKeyValue)
        {
            if (searchKeyValue != null)
            {
                return _AppDbcontext.Products.Where(x => x.Name.Contains(searchKeyValue) && x.Review == true).ToList();
            }
            else
            {
                return _AppDbcontext.Products.ToList();
            } 
            
            
        }

        
    }
}
