﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RestaurantEntities : DbContext
    {
        public RestaurantEntities()
            : base("name=RestaurantEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Allergen> Allergens { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Menu_Product> Menu_Product { get; set; }
        public virtual DbSet<Order_Product> Order_Product { get; set; }
    
        public virtual ObjectResult<string> GetAllergensFromMenus(string menuName)
        {
            var menuNameParameter = menuName != null ?
                new ObjectParameter("MenuName", menuName) :
                new ObjectParameter("MenuName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetAllergensFromMenus", menuNameParameter);
        }
    
        public virtual ObjectResult<string> GetAllergensFromProduct(string productName)
        {
            var productNameParameter = productName != null ?
                new ObjectParameter("ProductName", productName) :
                new ObjectParameter("ProductName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetAllergensFromProduct", productNameParameter);
        }
    
        public virtual ObjectResult<GetMenusByAllergen_Result> GetMenusByAllergen(string allergenName)
        {
            var allergenNameParameter = allergenName != null ?
                new ObjectParameter("AllergenName", allergenName) :
                new ObjectParameter("AllergenName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetMenusByAllergen_Result>("GetMenusByAllergen", allergenNameParameter);
        }
    
        public virtual ObjectResult<GetMenusWithoutSpecificAllergen_Result> GetMenusWithoutSpecificAllergen(string allergenName)
        {
            var allergenNameParameter = allergenName != null ?
                new ObjectParameter("AllergenName", allergenName) :
                new ObjectParameter("AllergenName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetMenusWithoutSpecificAllergen_Result>("GetMenusWithoutSpecificAllergen", allergenNameParameter);
        }
    
        public virtual ObjectResult<Nullable<double>> GetPriceFromProductsForMenu(string menuName)
        {
            var menuNameParameter = menuName != null ?
                new ObjectParameter("MenuName", menuName) :
                new ObjectParameter("MenuName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<double>>("GetPriceFromProductsForMenu", menuNameParameter);
        }
    
        public virtual ObjectResult<GetProductsByAllergen_Result> GetProductsByAllergen(string allergenName)
        {
            var allergenNameParameter = allergenName != null ?
                new ObjectParameter("AllergenName", allergenName) :
                new ObjectParameter("AllergenName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetProductsByAllergen_Result>("GetProductsByAllergen", allergenNameParameter);
        }
    
        public virtual ObjectResult<GetProductsWithoutSpecificAllergen_Result> GetProductsWithoutSpecificAllergen(string allergenName)
        {
            var allergenNameParameter = allergenName != null ?
                new ObjectParameter("AllergenName", allergenName) :
                new ObjectParameter("AllergenName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetProductsWithoutSpecificAllergen_Result>("GetProductsWithoutSpecificAllergen", allergenNameParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetQuantityFromProductsForMenu(string menuName)
        {
            var menuNameParameter = menuName != null ?
                new ObjectParameter("MenuName", menuName) :
                new ObjectParameter("MenuName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetQuantityFromProductsForMenu", menuNameParameter);
        }
    }
}
