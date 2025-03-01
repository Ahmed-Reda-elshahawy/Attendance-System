using Attendance_System.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_System.PresentationLayer.UserControls
{
    public partial class InstructorDashboardControl : UserControl
    {
        private int insId;
        public InstructorDashboardControl(int insId)
        {
            InitializeComponent();
            this.insId = insId;
        }

        private void Instructor_dashboard_load(object sender, EventArgs e)
        {
            DataTable dt = InstructorBL.GetInstructorDashboardData(insId);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                lb_ins_name.Text = dr["IFullName"].ToString();
                lb_ins_email.Text = dr["email"].ToString();
                lb_ins_phone.Text = dr["Phone"].ToString();
                lb_ins_address.Text = dr["Address"].ToString();

                flp_cards.Controls.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    // Create a new panel to act as a card
                    Panel card = new Panel
                    {
                        Width = 75, // Static width
                        Height = 75, // Static height
                        BackColor = Color.LightSteelBlue, // Background color
                        //BorderStyle = BorderStyle.Fixed3D // Add border for styling
                    };

                    // Create a label to display the class name
                    Label label = new Label
                    {
                        Text = row["className"].ToString(), // Use className value
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill // Make label fill the card
                    };

                    // Add the label to the card (panel)
                    card.Controls.Add(label);

                    flp_cards.Controls.Add(card);
                }

            }
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
