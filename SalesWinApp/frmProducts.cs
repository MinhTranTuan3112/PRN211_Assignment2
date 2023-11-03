using BusinessObject.Models;
using DataAccess.Repository;
namespace SalesWinApp
{
    public partial class frmProducts : Form
    {
        //Fields
        private readonly IProductRepository productRepository = new ProductRepository();
        private readonly IOrderRepository orderRepository = new OrderRepository();
        private readonly IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        private BindingSource source;
        private FilterProductData FilterData = new FilterProductData();
        private Order CurrentOrder = null;
        private List<OrderDetail> OrderDetailsList = new List<OrderDetail>();
        private decimal TotalPrice = decimal.Zero;

        int ProductId
        {
            get => Convert.ToInt32(numProductId.Value);
            set => numProductId.Value = value;
        }

        int CategoryId
        {
            get => Convert.ToInt32(txtCategoryId.Text);
            set => txtCategoryId.Text = value.ToString();
        }

        string productName
        {
            get => txtProductName.Text;
            set => txtProductName.Text = value;
        }

        string Weight
        {
            get => txtWeight.Text;
            set => txtWeight.Text = value;
        }

        decimal UnitPrice
        {
            get => Convert.ToDecimal(txtUnitPrice.Text);
            set => txtUnitPrice.Text = value.ToString();
        }

        int UnitsInStock
        {
            get => Convert.ToInt32(txtUnitsInStock.Text);
            set => txtUnitsInStock.Text = value.ToString();
        }

        public bool IsAdmin { get; set; } = false;

        //Constructors
        public frmProducts(bool isAdmin)
        {
            this.IsAdmin = isAdmin;
            InitializeComponent();
            Authentication();
            RaiseEvent();
        }

        private void Authentication()
        {
            if (IsAdmin == true)
            {
                gbOrder.Visible = false;
            }
            else
            {
                gbOrder.Visible = true;
                btnCreate.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
        }

        private void RaiseEvent()
        {
            this.Load += frmProducts_Load;
            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
            if (IsAdmin == true)
            {
                dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;

            }
            btnCreate.Click += btnCreate_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnOrder.Click += btnOrder_Click;

            //Search Events
            btnClear.Click += btnClear_Click;
            txtKeyword.TextChanged += txtKeyword_TextChanged;
            txtMinPrice.TextChanged += txtMinPrice_TextChanged;
            txtMaxPrice.TextChanged += txtMaxPrice_TextChanged;
            txtMinUnit.TextChanged += txtMinUnit_TextChanged;
            txtMaxUnit.TextChanged += txtMaxUnit_TextChanged;

            btnRemoveOrderedProduct.Click += btnRemoveOrderedProduct_Click;
            btnSubmitOrder.Click += btnSubmitOrder_Click;
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Submit this order?", "Submit order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SubmitOrder();
            }
        }

        private void SubmitOrder()
        {
            try
            {
                if (OrderDetailsList.Count == 0)
                {
                    throw new Exception("There is no product");
                }
                CurrentOrder.OrderDetails = OrderDetailsList;
                orderDetailRepository.AddOrderDetailsList(OrderDetailsList);
                CurrentOrder.Freight = TotalPrice;
                orderRepository.UpdateOrder(CurrentOrder);
                MessageBox.Show("Submitted this order!");
                CurrentOrder = null;
                OrderDetailsList.Clear();
                txtTotalPrice.Text = "0";
                TotalPrice = decimal.Zero;
                LoadOrderDetailsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Submit Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRemoveOrderedProduct_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Remove this product from order list?", "Remove ordered product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                RemoveOrderedProduct();
            }
        }



        private void txtMaxUnit_TextChanged(object sender, EventArgs e)
        {
            int MaxUnit = -1;
            if (int.TryParse(txtMaxUnit.Text, out MaxUnit))
            {
                FilterData.MaxUnit = MaxUnit;
                LoadProductList();
            }
            else
            {
                MessageBox.Show("Invalid Max Unit", "Unit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMinUnit_TextChanged(object sender, EventArgs e)
        {
            int MinUnit = -1;
            if (int.TryParse(txtMinUnit.Text, out MinUnit))
            {
                FilterData.MinUnit = MinUnit;
                LoadProductList();
            }
            else
            {
                MessageBox.Show("Invalid Min Unit", "Unit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Reset the filter data?", "Reset filter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ResetFilter();
                LoadProductList();
                MessageBox.Show("Reset filter success!");
            }
        }

        private void ResetFilter()
        {
            FilterData.Reset();
        }

        private void txtMaxPrice_TextChanged(object sender, EventArgs e)
        {
            decimal MaxPrice = decimal.MinValue;
            if (decimal.TryParse(txtMaxPrice.Text, out MaxPrice))
            {
                FilterData.MaxPrice = MaxPrice;
                LoadProductList();
            }
            else
            {
                MessageBox.Show("Invalid Max Price", "Unit Price Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMinPrice_TextChanged(object sender, EventArgs e)
        {
            decimal MinPrice = decimal.MinValue;
            if (decimal.TryParse(txtMinPrice.Text, out MinPrice))
            {
                FilterData.MinPrice = MinPrice;
                LoadProductList();
            }
            else
            {
                MessageBox.Show("Invalid Min Price", "Unit Price Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            FilterData.Keyword = txtKeyword.Text;
            LoadProductList();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Order this product?", "Order product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (Convert.ToInt32(numQuantity.Value) <= 0)
                    {
                        throw new Exception("Invalid product quantity!");
                    }
                    AddProductToCart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Order Product Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RemoveOrderedProduct()
        {
            if (dgvOrderProducts.SelectedRows.Count <= 0)
            {
                MessageBox.Show("There is no products to remove", "Remove order product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                var selectedRow = dgvOrderProducts.SelectedRows[0];
                int ProductId = Convert.ToInt32(selectedRow.Cells["ProductId"].Value);

                orderDetailRepository.RemoveByIds(CurrentOrder.OrderId, ProductId);
                LoadOrderDetailsList();
                UpdateTotalPrice();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove order product error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOrderDetailsList()
        {
            if (OrderDetailsList.Count == 0)
            {
                MessageBox.Show("No products in cart found!", "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvOrderProducts.Rows.Clear();
                return;
            }
            try
            {
                var datasource = OrderDetailsList.Select(orderdetails => new
                {
                    ProductId = orderdetails.ProductId,
                    OrderDate = orderdetails.Order.OrderDate,
                    ProductName = orderdetails.Product.ProductName,
                    Quantity = orderdetails.Quantity,
                    UnitPrice = orderdetails.UnitPrice,
                    Discount = orderdetails.Discount
                }).ToList();

                dgvOrderProducts.DataSource = null;
                dgvOrderProducts.DataSource = datasource;
                dgvOrderProducts.Columns["ProductId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Ordered Product Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProductToCart()
        {
            try
            {
                var member = MemberSession.member;
                var product = GetCurrentProductRow();
                int quantity = Convert.ToInt32(numQuantity.Value);
                if (CurrentOrder is null)
                {
                    CurrentOrder = orderRepository.AddNewOrder(new Order
                    {
                        MemberId = member.MemberId,
                        OrderDate = DateTime.Now,
                        Freight = 0
                    });
                }

                OrderDetailsList.Add(new OrderDetail
                {
                    OrderId = CurrentOrder.OrderId,
                    ProductId = product.ProductId,
                    Product = product,
                    Order = CurrentOrder,
                    Quantity = quantity,
                    UnitPrice = UnitPrice,
                    Discount = 0
                });
                LoadOrderDetailsList();
                UpdateTotalPrice();
                MessageBox.Show("Added this product to order list!!", "Order Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Product to cart error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTotalPrice()
        {
            foreach (var orderDetail in OrderDetailsList)
            {
                TotalPrice += orderDetail.Quantity * orderDetail.UnitPrice;
            }
            txtTotalPrice.Text = string.Format("{0:F0}", TotalPrice);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var product = GetCurrentProductRow();
            var result = MessageBox.Show("Delete this product?", "Delete product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                productRepository.DeleteProduct(product);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var DetailsForm = new frmProductDetails()
            {
                IsEdit = false
            };
            if (DetailsForm.ShowDialog() == DialogResult.OK)
            {
                ClearText();
                LoadProductList();
            }
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateProduct();
        }

        private void UpdateProduct()
        {
            var product = GetCurrentProductRow();
            var DetailsForm = new frmProductDetails()
            {
                product = product,
                IsEdit = true
            };
            if (DetailsForm.ShowDialog() == DialogResult.OK)
            {
                ClearText();
                LoadProductList();
            }
        }

        private Product GetCurrentProductRow()
        {
            Product product = null;
            if (dgvProducts.SelectedRows.Count > 0)
            {
                var selectedRow = dgvProducts.SelectedRows[0];
                int ProductId = Convert.ToInt32(selectedRow.Cells["ProductId"].Value);
                int CategoryId = Convert.ToInt32(selectedRow.Cells["CategoryId"].Value);
                string ProductName = selectedRow.Cells["ProductName"].Value.ToString();
                string Weight = selectedRow.Cells["Weight"].Value.ToString();
                decimal UnitPrice = Convert.ToDecimal(selectedRow.Cells["UnitPrice"].Value);
                int UnitsInStock = Convert.ToInt32(selectedRow.Cells["UnitsInStock"].Value);

                product = new Product
                {
                    ProductId = ProductId,
                    CategoryId = CategoryId,
                    ProductName = ProductName,
                    Weight = Weight,
                    UnitPrice = UnitPrice,
                    UnitsInStock = UnitsInStock
                };
            }
            return product;
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            var product = GetCurrentProductRow();
            UpdateProductToTextBoxes(product);
        }

        private void UpdateProductToTextBoxes(Product product)
        {
            if (product is null)
            {
                return;
            }
            ProductId = product.ProductId;
            CategoryId = product.CategoryId;
            productName = product.ProductName;
            Weight = product.Weight;
            UnitPrice = product.UnitPrice;
            UnitsInStock = product.UnitsInStock;
        }

        private void ClearText()
        {
            numProductId.Value = 0;
            txtCategoryId.Clear();
            txtProductName.Clear();
            txtWeight.Clear();
            txtUnitPrice.Clear();
            txtUnitsInStock.Clear();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadProductList();
        }

        private void LoadProductList()
        {
            var ProductList = productRepository.GetProductList(FilterData);
            if (ProductList is null || ProductList.Count == 0)
            {
                return;
            }
            source = new BindingSource();
            source.DataSource = null;
            source.DataSource = ProductList;

            numProductId.DataBindings.Clear();
            txtCategoryId.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtWeight.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();
            txtUnitsInStock.DataBindings.Clear();

            numProductId.DataBindings.Add("Value", source, "ProductId");
            txtCategoryId.DataBindings.Add("Text", source, "CategoryId");
            txtProductName.DataBindings.Add("Text", source, "ProductName");
            txtWeight.DataBindings.Add("Text", source, "Weight");
            txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
            txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");

            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.Columns.Add("ProductId", "ProductId");
            dgvProducts.Columns.Add("CategoryId", "CategoryId");
            dgvProducts.Columns.Add("ProductName", "ProductName");
            dgvProducts.Columns.Add("Weight", "Weight");
            dgvProducts.Columns.Add("UnitPrice", "UnitPrice");
            dgvProducts.Columns.Add("UnitsInStock", "UnitsInStock");

            dgvProducts.Columns["ProductId"].DataPropertyName = "ProductId";
            dgvProducts.Columns["CategoryId"].DataPropertyName = "CategoryId";
            dgvProducts.Columns["ProductName"].DataPropertyName = "ProductName";
            dgvProducts.Columns["Weight"].DataPropertyName = "Weight";
            dgvProducts.Columns["UnitPrice"].DataPropertyName = "UnitPrice";
            dgvProducts.Columns["UnitsInStock"].DataPropertyName = "UnitsInStock";
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = ProductList;
        }
    }
}
