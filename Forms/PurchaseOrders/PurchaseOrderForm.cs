using Microsoft.EntityFrameworkCore.Internal;
using POS_Generic.Helpers;
using SalesPro.Constants;
using SalesPro.Enums;
using SalesPro.Helpers;
using SalesPro.Models;
using SalesPro.Properties;
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
            var purchaseOrders = await _service.GetAllPurchaseOrders();
            var existingPO = purchaseOrders.FirstOrDefault(po => po.ProcessStatus == ProcessStatus.Created);

            if (existingPO == null || MessageHandler.ShowQuestion($"An existing Purchase Order has already been created.\n {Resources.ConfirmNew}", FormConstants.PurchaseOrder))
            {
                var savedPO = await SavePurchaseOrder();
                var form = new PurchaseOrderDetailsForm { _poId = savedPO };
                form.ShowDialog();
            }
        }

        private async Task<int> SavePurchaseOrder()
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
                return po.PurchaseOrderId;
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
