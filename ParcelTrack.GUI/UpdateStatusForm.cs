using ParcelTrack.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ParcelTrack.GUI
{
    public partial class UpdateStatusForm : Form
    {
        private readonly ParcelTracker _parcelTracker;
        private readonly TrackingManager _trackingManager;
        public UpdateStatusForm()
        {
            InitializeComponent();

            btnSearchUpdate.Click += btnSearchUpdate_Click;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            btnClearUpdate.Click += btnClearUpdate_Click;


            // Configure status dropdown
            cmbUpdateStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbUpdateStatus.DataSource =
                Enum.GetValues(typeof(ParcelStatus));

            // Current status should not be edited manually
            txtCurrentStatus.ReadOnly = true;
        }




        public UpdateStatusForm(
            ParcelTracker parcelTracker,
            TrackingManager trackingManager,
            bool embedded) : this(parcelTracker, trackingManager)

        {
            if (embedded)
            {
                FormBorderStyle = FormBorderStyle.None;
                TopLevel = false;
                Dock = DockStyle.Fill;

                // Hide standalone navigation panels if they exist on this form
                if (pnlSideBar != null) pnlSideBar.Visible = false;
                if (pnlHeader != null) pnlHeader.Visible = false;

                // Ensure the main layout panel of the update form stretches to fill the space
                // e.g., if you have a main table layout or panel holding your update controls:
                // pnlMainContent.Dock = DockStyle.Fill;
            }
        }


        private void UpdateParcelStatistics()
        {
            var parcels = _parcelTracker.Parcels;

            lblTotalParcel.Text = parcels.Count.ToString();

            lblTransitNumber.Text = parcels.Count(
                p => p.Status == ParcelStatus.InTransit).ToString();

            lblDeliveredNumber.Text = parcels.Count(
                p => p.Status == ParcelStatus.Delivered).ToString();

            lblCancelledNumber.Text = parcels.Count(
                p => p.Status == ParcelStatus.Cancelled).ToString();
        }


        private void btnSearchUpdate_Click(object sender, EventArgs e)
        {
            string trackingNumber = txtTrackingNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(trackingNumber))
            {
                MessageBox.Show("Please enter a tracking number.");
                return;
            }

            // Find parcel from the shared ParcelTracker
            Parcel parcel = _parcelTracker.FindParcel(trackingNumber);

            if (parcel == null)
            {
                MessageBox.Show(
                    "Parcel not found. Please check the tracking number.",
                    "Search Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Display current parcel status
            txtCurrentStatus.Text = parcel.Status.ToString();

            // Display parcel details
            lblSenderNameValue.Text = parcel.Sender.Name;
            lblRecipientNameValue.Text = parcel.Recipient.Name;
            lblWeightValue.Text = parcel.WeightKg.ToString("0.00") + " kg";

            // These details are not stored in the current Parcel class yet.
            lblDeliveryServiceValue.Text = parcel.DeliveryServiceName;

            lblRegisteredDateValue.Text =
                parcel.RegisteredDate.ToString("dd/MM/yyyy HH:mm");

            // Display tracking history
            dgvStatusUpdateHistory.Rows.Clear();

            foreach (TrackingEvent trackingEvent in parcel.TrackingHistory)
            {
                dgvStatusUpdateHistory.Rows.Add(
                    trackingEvent.Timestamp.ToString("dd/MM/yyyy HH:mm:ss"),
                    trackingEvent.Status.ToString(),
                    trackingEvent.Location,
                    trackingEvent.Description);
            }

            MessageBox.Show(
                "Parcel found successfully!",
                "Search Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            string trackingNumber = txtTrackingNumber.Text.Trim();

            Parcel parcel = _parcelTracker.FindParcel(trackingNumber);

            if (parcel == null)
            {
                MessageBox.Show("Please search for a valid parcel first.");
                return;
            }

            if (cmbUpdateStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a new parcel status.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter the current location.");
                return;
            }

            ParcelStatus newStatus =
                (ParcelStatus)cmbUpdateStatus.SelectedItem;

            if (newStatus == parcel.Status)
            {
                MessageBox.Show("This parcel already has that status.");
                return;
            }

            if (parcel.Status == ParcelStatus.Delivered ||
                parcel.Status == ParcelStatus.Cancelled)
            {
                MessageBox.Show(
                    "Delivered or cancelled parcels cannot be updated.");
                return;
            }

            TrackingEvent newEvent = new TrackingEvent(
                newStatus,
                txtLocation.Text.Trim(),
                txtRemarks.Text.Trim());

            _trackingManager.AddTrackingEvent(parcel, newEvent);
            UpdateParcelStatistics();

            txtCurrentStatus.Text = parcel.Status.ToString();

            dgvStatusUpdateHistory.Rows.Add(
                newEvent.Timestamp.ToString("dd/MM/yyyy HH:mm:ss"),
                newEvent.Status.ToString(),
                newEvent.Location,
                newEvent.Description);

            MessageBox.Show(
                "Parcel status updated successfully!",
                "Update Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


        private void btnClearUpdate_Click(object sender, EventArgs e)
        {
            txtTrackingNumber.Clear();
            txtCurrentStatus.Clear();

            cmbUpdateStatus.SelectedIndex = -1;

            txtLocation.Clear();
            txtRemarks.Clear();

            lblSenderNameValue.Text = "-";
            lblRecipientNameValue.Text = "-";
            lblWeightValue.Text = "-";
            lblDeliveryServiceValue.Text = "-";
            lblRegisteredDateValue.Text = "-";

            dgvStatusUpdateHistory.Rows.Clear();
        }


        public UpdateStatusForm(
            ParcelTracker parcelTracker,
            TrackingManager trackingManager)
            : this()
        {
            _parcelTracker = parcelTracker;
            _trackingManager = trackingManager;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvTrackingHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlStatusUpdateHistory_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void UpdateStatusForm_Load(object sender, EventArgs e)
        {

        }
    }
}
