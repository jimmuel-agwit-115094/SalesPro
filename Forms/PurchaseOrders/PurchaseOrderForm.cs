using Microsoft.EntityFrameworkCore.Internal;
using POS_Generic.Helpers;
using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.PurchaseOrders
{
    public partial class PurchaseOrderForm : Form
    {
        private readonly DatabaseContext _context;
        private readonly PurchaseOrderService _service;
        private DateTime _curDate;
        public PurchaseOrderForm()
        {
            _context = new DatabaseContext();
            _service = new PurchaseOrderService(_context);
            InitializeComponent();
        }

        private async void new_btn_Click(object sender, EventArgs e)
        {
            var pos = await _service.GetAllPurchaseOrders();
            // Check if there are no purchase orders or none with a "Created" status
            if (!pos.Any() || !pos.Any(s => s.ProcessStatus == ProcessStatus.Created))
            {
                await SavePurchaseOrder();
            }
            PurchaseOrderDetailsForm form = new PurchaseOrderDetailsForm();
            form.ShowDialog();
        }

        private async Task SavePurchaseOrder()
        {
            try
            {
                var po = new PurchaseOrderModel
                {
                    SupplierId = 0,
                    UserId = UserSession.Session_UserId,
                    DateCreated = _curDate.Date,
                    DueDate = _curDate.Date.AddDays(30),
                    CreditTerms = 30,
                    PoTotal = 0,
                    ProcessStatus = ProcessStatus.Created,
                    PaymentStatus = PaymentStatus.Unpaid,
                    CancellationReason = string.Empty,
                    Remarks = string.Empty
                };
                await _service.SavePurchaseOrder(po);
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error saving PO {ex.Message}");
                throw;
            }
        }

        private async void PurchaseOrderForm_Load(object sender, EventArgs e)
        {
            _curDate = await ClockHelper.GetServerDateTime();
        }
    }
}
