using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Products_prj_AA1_
{
    public partial class ProductSelector : System.Web.UI.Page
    {
        public class Product
        {
            public string Name { get; set; }
            public string ImageUrl { get; set; }
            public decimal Price { get; set; }
        }

        private List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", ImageUrl = "images/Laptops.jpg", Price = 50000m }, 
            new Product { Name = "Smartphone", ImageUrl = "images/SmartPhone.jpg", Price = 20000m }, 
            new Product { Name = "Tablet", ImageUrl = "images/Tablet.jpg", Price = 30000m}, 
            new Product { Name = "Smartwatch", ImageUrl = "images/Smart watch.jpg", Price = 4000m } 
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                ddlProducts.DataSource = products;
                ddlProducts.DataTextField = "Name";
                ddlProducts.DataValueField = "Name";
                ddlProducts.DataBind();
            }
        }

        protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get selected product
            string selectedProduct = ddlProducts.SelectedValue;
            Product product = products.Find(p => p.Name == selectedProduct);
            if (product != null)
            {
                imgProduct.ImageUrl = product.ImageUrl; // Set image URL
                lblPrice.Text = "₹ " + product.Price.ToString("N2"); // Set price in INR with two decimal points
            }
        }

        protected void btnGetPrice_Click(object sender, EventArgs e)
        {
            // Display the price for the selected product
            string selectedProduct = ddlProducts.SelectedValue;
            Product product = products.Find(p => p.Name == selectedProduct);
            if (product != null)
            {
                lblPrice.Text = "Price: ₹ " + product.Price.ToString("N2"); // Show the price in INR
            }
        }
    }
}

