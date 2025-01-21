using AutoMapper;
using EBS.Business.Abstract;
using EBS.DTO.DTOs.ProductDtos;
using EBS.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EBS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(IProductService _productService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() 
        {
            var values = _productService.BGetProductWithSubCategory_PurchaseOrder_Brand();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _productService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productService.TDelete(id);
            return Ok("Suppression effectuer");
        }
        [HttpPost]
        public IActionResult Create(CreateProductDto createProductDto)
        {
            var newValue = _mapper.Map<Product>(createProductDto);
            _productService.TCreate(newValue);
            return Ok("Ajout effectuer");
        }
        [HttpPut]
        public IActionResult Update(UpdateProductDto updateProductDto)
        {
            var value = _mapper.Map<Product>(updateProductDto);
            _productService.TUpdate(value);
            return Ok("Mise a jour effectuer");
        }

        

        [HttpGet("ShowOnHome/{id}")]
        public IActionResult ShowOnHome(int id)
        {
            _productService.BShowOnHome(id);
            return Ok("Afficher a la page index");
        }
        [HttpGet("DontShowOnHome/{id}")]
        public IActionResult DontShowOnHome(int id)
        {
            _productService.BDontShowOnHome(id);
            return Ok("Ne pas Afficher a la page index");
        }

        [HttpGet("GetActiveProducts")]
        public IActionResult GetActiveProducts()
        {
            var values = _productService.TGetFilteredList(x=>x.Review == true);
            return Ok(values);
        }

        [HttpGet("GetProductCreatedByEmployee/{id}")]
        public IActionResult GetProductCreatedByEmployee(int id)
        {
            var values = _productService.BGetProductCreatedByEmployee(id);
            return Ok(values);
        }


        //Recherche au niveau de HomeBannerComponent  Home index 

        //Nombre total de Categorie en stock
        [HttpGet("SubCategoryCount")]
        public IActionResult SubCategoryCount()
        {
            var values = _productService.BSubCategoryCount();
            return Ok(values);
        }

        //quantite total de produit en stock
         
        [HttpGet("ProductQuantitySum")]
        public IActionResult ProductQuantitySum()
        {
            var values = _productService.BProductQuantitySum();
            return Ok(values);
        }

        // Rechercher un produit par nom,sous-categorie
        [HttpGet("GetProductSearchKeyValueWithSubCategory")]
        public IActionResult GetProductSearchKeyValueWithSubCategory(string? searchKeyValue)
        { 
            var values = _productService.BGetProductSearchKeyValueWithSubCategory(searchKeyValue);
            return Ok(values);             
        }

        [HttpGet("ProductChangeStautsIsTrue/{id}")]
        public IActionResult ProductChangeStautsIsTrue(int id)
        {
            _productService.BProductChangeStautsIsTrue(id);
            return Ok("Vous avew ACTIVER avec success");
        }

        [HttpGet("ProductChangeStautsIsFalse/{id}")]
        public IActionResult ProductChangeStautsIsFalse(int id)
        {
            _productService.BProductChangeStautsIsFalse(id);
            return Ok("Vous avew DESACTIVER avec success");
        }


    }
}
