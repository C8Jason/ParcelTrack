using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcelTrack.Library;


namespace ParcelTrack.GUI
{
    public partial class MainForm : Form
    {
        private readonly ParcelTracker _parcelTracker =
            new ParcelTracker();

        private readonly TrackingManager _trackingManager =
            new TrackingManager();

        public event Action ParcelStatusChanged;

        private readonly ShippingCalculator _shippingCalculator =
            new ShippingCalculator();
        private UpdateStatusForm _updateStatusPage;

        private Panel _dashboardPage;

        



        private readonly ParcelStorage _parcelStorage =
    new ParcelStorage();
        public MainForm()
        {
            InitializeComponent();
            InitializePageNavigation();
            SetupDeliveryServices();
            SetupCalculatorServices();

            btnSearchParcel.Click += btnSearchParcel_Click;
            btnCalculateFee.Click += btnCalculateFee_Click;

            LoadSavedParcels();

            UpdateDashboardStatistics();

        }



        private void InitializePageNavigation()
        {
            // Create the Dashboard page
            _dashboardPage = new Panel();
            _dashboardPage.Dock = DockStyle.Fill;
            _dashboardPage.BackColor = Color.White;

            // Keep Register page separate
            pnlRegisterPage.Visible = false;
            pnlRegisterPage.Dock = DockStyle.Fill;

            // Collect dashboard controls, excluding Register page
            List<Control> dashboardControls =
                pnlPageContent.Controls
                .Cast<Control>()
                .Where(control => control != pnlRegisterPage)
                .ToList();

            // Move dashboard controls into Dashboard container
            foreach (Control control in dashboardControls)
            {
                pnlPageContent.Controls.Remove(control);
                _dashboardPage.Controls.Add(control);
            }

            // Add both pages to the main content area
            pnlPageContent.Controls.Add(_dashboardPage);
            pnlPageContent.Controls.Add(pnlRegisterPage);

            // Start with Dashboard
            _dashboardPage.Visible = true;
            _dashboardPage.BringToFront();
        }



        private void LoadSavedParcels()
        {
            List<Parcel> savedParcels = _parcelStorage.Load();

            foreach (Parcel parcel in savedParcels)
            {
                _parcelTracker.RegisterParcel(parcel);

                dgvParcels.Rows.Add(
                    parcel.TrackingNumber,
                    parcel.Sender.Name,
                    parcel.Recipient.Name,
                    parcel.Sender.Address,
                    parcel.Recipient.Address,
                    parcel.WeightKg,
                    parcel.DeliveryServiceName,
                    parcel.Status.ToString());
            }

            UpdateDashboardStatistics();
        }



        private void UpdateDashboardStatistics()
        {
            int total = _parcelTracker.Parcels.Count;

            int inTransit = _parcelTracker.Parcels.Count(
                p =>p.Status == ParcelStatus.PickedUp ||
                p.Status == ParcelStatus.InTransit ||
                p.Status == ParcelStatus.OutForDelivery);

            int delivered = _parcelTracker.Parcels.Count(
                p => p.Status == ParcelStatus.Delivered);

            int cancelled = _parcelTracker.Parcels.Count(
                p => p.Status == ParcelStatus.Cancelled);

            lblTotalParcels.Text = total.ToString();
            lblInTransit.Text = inTransit.ToString();
            lblDelivered.Text = delivered.ToString();
            lblCancelled.Text = cancelled.ToString();
        }
        private void SetupCalculatorServices()
        {
            cmbCalcService.Items.Clear();

            cmbCalcService.DisplayMember = "ServiceName";

            cmbCalcService.Items.Add(
                new DeliveryService("Standard", 5.00, 2.00));

            cmbCalcService.Items.Add(
                new DeliveryService("Express", 8.00, 3.00));

            cmbCalcService.Items.Add(
                new DeliveryService("Premium", 12.00, 4.00));

            cmbCalcService.SelectedIndex = 0;
        }


        private void btnCalculateFee_Click(object sender, EventArgs e)
        {
            // 1. Validate weight
            if (!double.TryParse(txtCalcWeight.Text, out double weight) ||
                weight <= 0 ||
                double.IsNaN(weight) ||
                double.IsInfinity(weight))
            {
                MessageBox.Show(
                    "Please enter a valid positive parcel weight.",
                    "Invalid Weight",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // 2. Get selected delivery service
            DeliveryService service =
                cmbCalcService.SelectedItem as DeliveryService;

            if (service == null)
            {
                MessageBox.Show("Please select a delivery service.");
                return;
            }

            // 3. Calculate shipping fee
            double fee = _shippingCalculator.CalculateFee(
                weight,
                service);

            // 4. Display result
            lblEstimatedFee.Text = "RM " + fee.ToString("0.00");
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdateStatus_Click(sender, e);
        }

        private void btnSearchParcel_Click(object sender, EventArgs e)
        {
            // 1. Get tracking number
            string trackingNumber =
                txtSearchTrackingNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(trackingNumber))
            {
                MessageBox.Show(
                    "Please enter a tracking number.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // 2. Find parcel
            Parcel parcel = _parcelTracker.FindParcel(trackingNumber);

            if (parcel == null)
            {
                dgvTrackingHistory.Rows.Clear();

                MessageBox.Show(
                    "Parcel not found. Please check the tracking number.",
                    "Search Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            // 3. Clear previous tracking history
            dgvTrackingHistory.Rows.Clear();

            // 4. Retrieve tracking history
            var history =
                _parcelTracker.GetTrackingHistory(trackingNumber);

            // 5. Display tracking events
            foreach (TrackingEvent trackingEvent in history)
            {
                dgvTrackingHistory.Rows.Add(
                    trackingEvent.Timestamp.ToString("dd/MM/yyyy HH:mm:ss"),
                    trackingEvent.Status.ToString(),
                    trackingEvent.Location,
                    trackingEvent.Description);
            }

        }

        private void SetupDeliveryServices()

        {
            cmbDeliveryService.Items.Clear();

            cmbDeliveryService.DisplayMember = "ServiceName";

            cmbDeliveryService.Items.Add(
                new DeliveryService("Standard", 5.00, 2.00));

            cmbDeliveryService.Items.Add(
                new DeliveryService("Express", 8.00, 3.00));

            cmbDeliveryService.Items.Add(
                new DeliveryService("Premium", 12.00, 4.00));

            cmbDeliveryService.SelectedIndex = 0;

            
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Hide all Dashboard panels
            foreach (Control control in pnlPageContent.Controls)
            {
                if (control != pnlRegisterPage)
                    control.Visible = false;
            }

            // Show Register Parcel page
            pnlRegisterPage.Visible = true;
            pnlRegisterPage.BringToFront();
        }   


        private void btnRegisterParcel_Click(object sender, EventArgs e)
        {
            // 1. Get input values
            // Generate tracking number automatically
            string trackingNumber = GenerateTrackingNumber();

            // Display tracking number in the read-only textbox
            txtTrackingNumber.Text = trackingNumber;
            string senderName = txtSenderName.Text.Trim();
            string senderPhone = txtSenderPhone.Text.Trim();
            string senderAddress = txtSenderAddress.Text.Trim();

            string recipientName = txtRecipientName.Text.Trim();
            string recipientPhone = txtRecipientPhone.Text.Trim();
            string recipientAddress = txtRecipientAddress.Text.Trim();

            // 2. Validate required fields
            if (string.IsNullOrWhiteSpace(trackingNumber) ||
                string.IsNullOrWhiteSpace(senderName) ||
                string.IsNullOrWhiteSpace(senderPhone) ||
                string.IsNullOrWhiteSpace(senderAddress) ||
                string.IsNullOrWhiteSpace(recipientName) ||
                string.IsNullOrWhiteSpace(recipientPhone) ||
                string.IsNullOrWhiteSpace(recipientAddress) ||
                string.IsNullOrWhiteSpace(txtWeight.Text))
            {
                MessageBox.Show(
                    "Please complete all required fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // 3. Validate weight
            if (!double.TryParse(txtWeight.Text.Trim(), out double weight) ||
                weight <= 0 ||
                double.IsNaN(weight) ||
                double.IsInfinity(weight))
            {
                MessageBox.Show("Please enter a valid positive weight.");
                return;
            }

            // 4. Check delivery service
            DeliveryService service =
                cmbDeliveryService.SelectedItem as DeliveryService;

            if (service == null)
            {
                if (service == null)
                {
                    MessageBox.Show("Please select a delivery service.");
                    return;
                }
                return;
            }

            // 5. Check duplicate tracking number
            if (_parcelTracker.FindParcel(trackingNumber) != null)
            {
                MessageBox.Show(
                    "This tracking number already exists.",
                    "Duplicate Tracking Number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 6. Create Contact objects
                Contact senderContact = new Contact(
                    senderName,
                    senderPhone,
                    senderAddress);

                Contact recipientContact = new Contact(
                    recipientName,
                    recipientPhone,
                    recipientAddress);

                // 7. Create Parcel
                Parcel parcel = new Parcel(
                    trackingNumber,
                    weight,
                    senderContact,
                    recipientContact,
                    service.ServiceName);

                // 8. Register parcel
                _parcelTracker.RegisterParcel(parcel);

                // 9. Create initial tracking event
                TrackingEvent initialEvent = new TrackingEvent(
                    parcel.Status,
                    parcel.Sender.Address,
                    "Parcel registered successfully."
                );

                // 10. Add event to tracking history
                _trackingManager.AddTrackingEvent(parcel, initialEvent);

                ParcelStatusChanged?.Invoke();

                // 11. Save parcel data
                _parcelStorage.Save(_parcelTracker.Parcels);

                // Check the saved JSON file
                string savedJson = System.IO.File.ReadAllText(
                    System.IO.Path.Combine(
                        AppDomain.CurrentDomain.BaseDirectory,
                        "parcels.json"));



                // 10. Update Parcel Records table
                dgvParcels.Rows.Add(
                    parcel.TrackingNumber,
                    parcel.Sender.Name,
                    parcel.Recipient.Name,
                    parcel.Sender.Address,
                    parcel.Recipient.Address,
                    parcel.WeightKg,
                    parcel.DeliveryServiceName,
                    parcel.Status.ToString());

                // 11. Refresh dashboard statistics
                UpdateDashboardStatistics();

                MessageBox.Show(
                    "Parcel registered successfully!",
                    "Registration Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // 12. Clear registration fields
                txtTrackingNumber.Clear();
                txtSenderName.Clear();
                txtSenderPhone.Clear();
                txtSenderAddress.Clear();
                txtRecipientName.Clear();
                txtRecipientPhone.Clear();
                txtRecipientAddress.Clear();
                txtWeight.Clear();

                cmbDeliveryService.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Registration Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void OpenUpdateStatusForm(object sender, EventArgs e)
        {
            UpdateStatusForm updateForm =
                new UpdateStatusForm(
                    _parcelTracker,
                    _trackingManager);

            updateForm.ShowDialog();
            _parcelStorage.Save(_parcelTracker.Parcels);
        }

        private string GenerateTrackingNumber()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();

            string trackingNumber;

            do
            {
                trackingNumber = "PT" +
                    new string(Enumerable.Range(0, 10)
                    .Select(x => chars[random.Next(chars.Length)])
                    .ToArray());
            }
            while (_parcelTracker.FindParcel(trackingNumber) != null);

            return trackingNumber;
        }

        private void dgvParcels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header clicks
            if (e.RowIndex < 0 || e.ColumnIndex != 0)
                return;

            string trackingNumber =
                dgvParcels.Rows[e.RowIndex].Cells[0].Value?.ToString();

            if (!string.IsNullOrWhiteSpace(trackingNumber))
            {
                Clipboard.SetText(trackingNumber);

                MessageBox.Show(
                    "Tracking number copied!\n\n" + trackingNumber,
                    "Copied Successfully",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnClearAllParcels_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete ALL parcels?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Clear all parcels from memory
                _parcelTracker.ClearAllParcels();

                // Clear Parcel Records table
                dgvParcels.Rows.Clear();

                // Clear Tracking History table
                dgvTrackingHistory.Rows.Clear();

                // Clear saved JSON data
                _parcelStorage.Save(_parcelTracker.Parcels);

                // Refresh Dashboard statistics
                UpdateDashboardStatistics();

                MessageBox.Show(
                    "All parcels have been deleted successfully!",
                    "Deletion Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        public void RefreshParcelRecords()
        {
            foreach (DataGridViewRow row in dgvParcels.Rows)
            {
                if (row.IsNewRow) continue;

                string trackingNumber =
                    row.Cells[0].Value?.ToString();

                Parcel parcel = _parcelTracker.FindParcel(trackingNumber);

                if (parcel != null)
                {
                    row.Cells[7].Value = parcel.Status.ToString();
                }
            }

            UpdateDashboardStatistics();

            _parcelStorage.Save(_parcelTracker.Parcels);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void label1_Click_5(object sender, EventArgs e)
        {

        }

        private void label1_Click_6(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pnlRegister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtSenderAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRecipientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblParcelRecords_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_7(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblRegisterNewParcel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }






        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            // 1. Hide the dashboard container page
            if (_dashboardPage != null)
            {
                _dashboardPage.Visible = false;
            }

            // 2. Hide the top statistics panels if they are outside pnlPageContent
            pnlTotal.Visible = false;
            pnlInTransit.Visible = false;
            pnlDelivered.Visible = false;
            pnlCancelled.Visible = false;

            // 3. Create Update Status page only once
            if (_updateStatusPage == null || _updateStatusPage.IsDisposed)
            {
                _updateStatusPage = new UpdateStatusForm(
                    _parcelTracker,
                    _trackingManager,
                    true); // 'true' triggers embedded mode

                _updateStatusPage.ParcelStatusChanged += RefreshParcelRecords;

                _updateStatusPage.TopLevel = false;
                _updateStatusPage.FormBorderStyle = FormBorderStyle.None;
                _updateStatusPage.Dock = DockStyle.Fill; // Fills pnlPageContent completely

                pnlPageContent.Controls.Add(_updateStatusPage);
            }

            _updateStatusPage.Visible = true;
            _updateStatusPage.BringToFront();
        }









        private void btnDoashboard_Click(object sender, EventArgs e)
        {
            // Hide Update Status page
            if (_updateStatusPage != null)
            {
                _updateStatusPage.Hide();
            }

            // Hide Register Parcel page
            pnlRegisterPage.Visible = false;

            // Show Dashboard controls only
            foreach (Control control in pnlPageContent.Controls)
            {
                if (control == pnlRegisterPage ||
                    control == _updateStatusPage)
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }
            }

            pnlTotal.Visible = true;
            pnlInTransit.Visible = true;
            pnlDelivered.Visible = true;
            pnlCancelled.Visible = true;
            UpdateDashboardStatistics();

            pnlPageContent.Refresh();
        }





        private void pnlPageContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCalcWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCalcService_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchTrackingNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlEstimateFees_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
