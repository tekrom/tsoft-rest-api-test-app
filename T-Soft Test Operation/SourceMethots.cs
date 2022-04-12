using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TSoftRestApiTestApp
{
    public class SourceMethods
    {

        private OperationPart op;

        public SourceMethods()
        {
            op = new OperationPart();
        }

        #region Get


        #region Category

        [Attributes.MethodTypeGet]
        [Description("category/getCategories")]
        public Tuple<string, string, List<Parameters>> GetCategory(string methodName)
        {

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("limit", "10");
            dict.Add("orderby", "CreateDate DESC");

            return op.getData(methodName, dict, op.getToken(),"");
        }


        [Attributes.MethodTypeGet]
        [Description("category/getCategoryTree")]
        public Tuple<string, string, List<Parameters>> GetCategoryTree(string methodName)
        {

            Dictionary<string, string> dict = new Dictionary<string, string>();

            return op.getData(methodName, dict, op.getToken(),"");
        }

        #endregion


        #region Product

        [Attributes.MethodTypeGet]
        [Description("product/getProducts")]
        public Tuple<string, string, List<Parameters>> GetProducts(string methodName)
        {

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("limit", "10");
            dict.Add("orderby", "CreateDate DESC");

            return op.getData(methodName, dict, op.getToken(),"");
        }

        [Attributes.MethodTypeGet]
        [Description("filter/getFiltersByProductCode")]
        [Attributes.MethodTypeGetWithByParam]
        [Attributes.UrlParamName("ProductCode")]
        public Tuple<string, string, List<Parameters>> GetFiltersByProductCode(string methodName, string urlParam)
        {

            Dictionary<string, string> dict = new Dictionary<string, string>();

            /*
               var methodPath = this.GetType().GetMethod("GetCustomer").GetCustomAttributes<DescriptionAttribute>()
                   .FirstOrDefault().Description;
               if (string.IsNullOrEmpty(methodPath))
                   return;
                   */
            return op.getData(methodName, dict, op.getToken(), urlParam);
        }


        [Attributes.MethodTypeGet]
        [Description("product/getProductByCode")]
        [Attributes.MethodTypeGetWithByParam]
        [Attributes.UrlParamName("ProductCode")]
        public Tuple<string, string, List<Parameters>> GetProductsByCode(string methodName, string urlParam)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            return op.getData(methodName, dict, op.getToken(), urlParam);
        }

        #endregion


        #region Fundmovement

        [Attributes.MethodTypeGet]
        [Description("fundMovement/getFundMovements")]
        public Tuple<string, string, List<Parameters>> GetFundmovements(string methodName)
        {

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("limit", "10");
            dict.Add("orderby", "CreateDate ASC");
            dict.Add("FetchAdditionalCustomerData", "true");

            /*
               var methodPath = this.GetType().GetMethod("GetCustomer").GetCustomAttributes<DescriptionAttribute>()
                   .FirstOrDefault().Description;
               if (string.IsNullOrEmpty(methodPath))
                   return;
                   */
            return op.getData(methodName, dict, op.getToken(),"");
        }

        #endregion


        #region Order

        [Attributes.MethodTypeGet]
        [Description("order2/getOrders")]
        public Tuple<string, string, List<Parameters>> GetOrders(string methodName)
        {

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("limit", "10");
            dict.Add("orderby", "CreateDate ASC");

            /*
               var methodPath = this.GetType().GetMethod("GetCustomer").GetCustomAttributes<DescriptionAttribute>()
                   .FirstOrDefault().Description;
               if (string.IsNullOrEmpty(methodPath))
                   return;
                   */
            return op.getData(methodName, dict, op.getToken(),"");
        }



        [Attributes.MethodTypeGet]
        [Description("order2/getOrderDetails")]
        public Tuple<string, string, List<Parameters>> GetOrderDetails(string methodName)
        {

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("limit", "10");
            dict.Add("orderby", "CreateDate ASC");

            /*
               var methodPath = this.GetType().GetMethod("GetCustomer").GetCustomAttributes<DescriptionAttribute>()
                   .FirstOrDefault().Description;
               if (string.IsNullOrEmpty(methodPath))
                   return;
                   */
            return op.getData(methodName, dict, op.getToken(),"");
        }

        #endregion


        #region Customer

        [Attributes.MethodTypeGet]
        [Description("customer/getCustomers")]
        public Tuple<string, string, List<Parameters>> GetCustomers(string methodName)
        {

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("limit", "10");
            dict.Add("orderby", "CreateDate ASC");

            /*
               var methodPath = this.GetType().GetMethod("GetCustomer").GetCustomAttributes<DescriptionAttribute>()
                   .FirstOrDefault().Description;
               if (string.IsNullOrEmpty(methodPath))
                   return;
                   */
            return op.getData(methodName, dict, op.getToken(),"");
        }

        #endregion


        #region SubProduct

        [Attributes.MethodTypeGet]
        [Description("subProduct/getSubProducts")]
        public Tuple<string, string, List<Parameters>> GetSubProducts(string methodName)
        {

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("limit", "10");
            dict.Add("orderby", "CreateDate ASC");

            /*
               var methodPath = this.GetType().GetMethod("GetCustomer").GetCustomAttributes<DescriptionAttribute>()
                   .FirstOrDefault().Description;
               if (string.IsNullOrEmpty(methodPath))
                   return;
                   */
            return op.getData(methodName, dict, op.getToken(), "");
        }

        #endregion


        #region Filters

        [Attributes.MethodTypeGet]
        [Description("filter/get")]
        public Tuple<string, string, List<Parameters>> GetFilter(string methodName)
        {

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("limit", "10");
            dict.Add("FetchOptions", "true");

            /*
               var methodPath = this.GetType().GetMethod("GetCustomer").GetCustomAttributes<DescriptionAttribute>()
                   .FirstOrDefault().Description;
               if (string.IsNullOrEmpty(methodPath))
                   return;
                   */
            return op.getData(methodName, dict, op.getToken(), "");
        }

        #endregion

        
        #endregion


        #region Set

        #region Product

        [Attributes.MethodTypeSet]
        [Description("product/setProducts")]
        public void SetProduct(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }



        [Attributes.MethodTypeSet]
        [Description("product/setProductLanguage")]
        public void SetProductLanguage(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        [Attributes.MethodTypeSet]
        [Description("product/setProductsStatus")]
        public void SetProductStatus(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        [Attributes.MethodTypeSet]
        [Description("product/addImageFromFile")]
        public void AddProductImage(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        

        #endregion

        #region SubProducts

        [Attributes.MethodTypeSet]
        [Description("subProduct/setSubProducts")]
        public void SetSubProduct(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        [Attributes.MethodTypeSet]
        [Description("subProduct/setPropertyLanguages")]
        public void SetSubProductPropertyLanguage(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        [Attributes.MethodTypeSet]
        [Description("subProduct/addImageFromFile")]
        public void AddSubProductImage(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters.Then select the image file and send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region Customer

        [Attributes.MethodTypeSet]
        [Description("customer/setCustomers")]
        public void SetCustomer(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        [Attributes.MethodTypeSet]
        [Description("customer/setCustomerGroups")]
        public void SetCustomerGroups(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region Categories

        [Attributes.MethodTypeSet]
        [Description("category/setCategories")]
        public void SetCategories(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        [Attributes.MethodTypeSet]
        [Description("category/setCategoryLanguage")]
        public void SetCategoryLanguage(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region Filter

        [Attributes.MethodTypeSet]
        [Description("filter/setGroup")]
        public void SetFilterGroup(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        [Attributes.MethodTypeSet]
        [Description("filter/setOption")]
        public void SetFilterOption(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        [Attributes.MethodTypeSet]
        [Description("filter/setFilterValues")]
        public void SetFilterValues(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region FundMovements

        [Attributes.MethodTypeSet]
        [Description("fundMovement/setFundMovements")]
        public void SetFundmovements(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #endregion


        #region Update


        #region Product

        [Attributes.MethodTypeUpdate]
        [Description("product/updateProducts")]
        public void UpdateProduct(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        [Attributes.MethodTypeUpdate]
        [Description("product/updateFlexiblePrice")]
        public void UpdateProductFlexiblePrice(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        [Attributes.MethodTypeUpdate]
        [Description("product/updateProductAsOnSale")]
        public void UpdateProductAsOnSale(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        [Attributes.MethodTypeUpdate]
        [Description("product/updateCustomerGroupPrice")]
        public void UpdateProductCustomerGroupPrice(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        [Attributes.MethodTypeUpdate]
        [Description("product/updatePrice")]
        public void UpdateProductPrice(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region Subproduct

        [Attributes.MethodTypeUpdate]
        [Description("subProduct/updateStock")]  
        public void UpdateSubProductStock(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        [Attributes.MethodTypeUpdate]
        [Description("subProduct/updatePrice")]
        public void UpdateSubProductPrice(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region Customer

        [Attributes.MethodTypeUpdate]
        [Description("customer/updateCustomers")]
        public void UpdateCustomer(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #endregion


        #region Delete


        #region Product

        [Attributes.MethodTypeDelete]
        [Description("product/deleteProducts")]
        public void DeleteProduct(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        [Attributes.MethodTypeDelete]
        [Description("product/deleteProductImages")]
        public void DeleteProductImages(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region SubProduct

        [Attributes.MethodTypeDelete]
        [Description("subProduct/deleteSubProducts")]
        public void DeleteSubProducts(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region Setting

        [Attributes.MethodTypeSet]
        [Description("setting/deleteCache")]
        public void DeleteCache(string methodName)
        {
            MessageBox.Show("Enter the json pattern and other post parameters. Then send the data.", "Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion


        #endregion

    }

}
