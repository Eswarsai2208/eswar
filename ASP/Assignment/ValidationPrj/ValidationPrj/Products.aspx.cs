using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationPrj
{
    public partial class Products : System.Web.UI.Page
    {
        Dictionary<string, (string ImageUrl, decimal Price)> products = new Dictionary<string, (string, decimal)>
        {
            {"Perfumes",("~/images/Perfumes.jpg", 50m) },
            {"Wallets",("~/images/Wallets.jpg", 14m) },
            {"Watches",("~/images/Watches.jpg", 100m) }
        };
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                foreach(var product in products.Keys)
                {
                    ddlProducts.Items.Add(product);
                }
            }

        }
        protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProduct = ddlProducts.SelectedItem.Text;
            if(products.ContainsKey(selectedProduct))
            {
                imgProduct.ImageUrl = products[selectedProduct].ImageUrl;
            }
        }
        protected void btnGetPrice_Click(object sender, EventArgs e)
        {
            string selectedProduct = ddlProducts.SelectedItem.Text;
            if(products.ContainsKey(selectedProduct))
            {
                lblPrice.Text = "Price $" + products[selectedProduct].Price.ToString();
            }
        }
    }
}