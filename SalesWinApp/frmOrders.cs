using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmOrders : Form
    {
        //Fields
        private readonly IOrderRepository orderRepository = new OrderRepository();
        private readonly IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        public bool IsAdmin { get; set; } = false;

        public Member member;

        DateTime StartDate
        {
            get => Convert.ToDateTime(dtStartDate.Value);
            set => dtStartDate.Value = value;
        }

        DateTime EndDate
        {
            get => Convert.ToDateTime(dtEndDate.Value);
            set => dtEndDate.Value = value;
        }

        bool IsSort
        {
            get => cbSort.Checked;
            set => cbSort.Checked = value;
        }
        public frmOrders(bool isAdmin)
        {
            this.IsAdmin = isAdmin;
            InitializeComponent();
            Authentication();
            RaiseEvent();
        }

        private void Authentication()
        {
            if (IsAdmin == false)
            {
                cbSort.Visible = false;
            }
        }

        private void RaiseEvent()
        {
            StartDate = DateTime.Now;
            EndDate = DateTime.Now.AddDays(1);
            this.Load += frmOrders_Load;
            btnSearch.Click += btnSearch_Click;
            dgvOrders.CellContentDoubleClick += dgvOrders_CellContentDoubleClick;
        }

        private void dgvOrders_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedRow = dgvOrders.SelectedRows[0];
                    int OrderId = Convert.ToInt32(selectedRow.Cells["OrderId"].Value);
                    var orderDetailsList = orderDetailRepository.GetOrderDetailsListFromOrder(OrderId);
                    var detailsForm = new frmOrderDetails() { orderDetailsList = orderDetailsList };
                    detailsForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load Order Details error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (StartDate >= EndDate)
            {
                MessageBox.Show("Invalid date range", "Search orders error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SearchOrder();
        }

        private void SearchOrder()
        {
            //var member = MemberSession.member;
            //if (member is null)
            //{
            //    return;
            //}
            try
            {
                var orderList = IsAdmin switch
                {
                    true => orderRepository.GetAllOrders(IsSort, StartDate, EndDate),
                    false => orderRepository.GetOrdersByMemberID(member.MemberId, StartDate, EndDate)
                };
                LoadOrderListToView(orderList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            LoadIntialOrders();
        }

        private void LoadOrderListToView(List<Order> orderList)
        {
            if (orderList is null || orderList.Count == 0)
            {
                MessageBox.Show("No orders found!!", "Order History", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                dgvOrders.DataSource = null;
                if (IsAdmin == false)
                {
                    dgvOrders.DataSource = null;
                    dgvOrders.DataSource = orderList;
                    dgvOrders.Columns["OrderId"].Visible = false;
                    dgvOrders.Columns["MemberId"].Visible = false;
                    dgvOrders.Columns["RequiredDate"].Visible = false;
                    dgvOrders.Columns["ShippedDate"].Visible = false;
                    dgvOrders.Columns["Member"].Visible = false;
                    dgvOrders.Columns["OrderDetails"].Visible = false;
                    cbSort.Visible = false;
                }
                else
                {
                    var datasource = orderList.Select(order => new
                    {
                        OrderId = order.OrderId,
                        OrderDate = order.OrderDate,
                        MemberEmail = order.Member.Email,
                        Freight = order.Freight,
                    }).ToList();
                    if (cbSort.Checked)
                    {
                        datasource = datasource.OrderBy(order => order.Freight).ToList();
                    }
                    //dgvOrders.Columns["OrderDetails"].Visible = false;
                    dgvOrders.DataSource = null;
                    dgvOrders.DataSource = datasource;
                }

                //if (IsAdmin == false)
                //{
                //    dgvOrders.Columns["MemberId"].Visible = false;
                //    dgvOrders.Columns["MemberEmail"].Visible = false;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadIntialOrders()
        {
            var member = MemberSession.member;
            if (IsAdmin == false && member is null)
            {
                return;
            }
            var orderList = IsAdmin switch
            {
                true => orderRepository.GetAllOrders(),
                false => orderRepository.GetOrdersByMemberID(member.MemberId)
            };
            //var orderList = orderRepository.GetOrdersByMemberID(member.MemberId);
            LoadOrderListToView(orderList);
        }
    }
}
