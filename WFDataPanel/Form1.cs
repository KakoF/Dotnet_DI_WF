using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFDataPanel
{
    public partial class Form1 : Form
    {
        private readonly ICustomerService _service;
        public Form1(ICustomerService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                //*_logger.LogInformation("Form1 {BusinessLayerEvent} at {dateTime}", "Started", DateTime.UtcNow);

                // Perform Business Logic here 
                //_business.PerformBusiness();

                MessageBox.Show("Hello .NET Core 3.0 . This is First Forms app in .NET Core");

                //_logger.LogInformation("Form1 {BusinessLayerEvent} at {dateTime}", "Ended", DateTime.UtcNow);

            }
            catch (Exception ex)
            {
                //Log technical exception 
                //_logger.LogError(ex.Message);
                //Return exception repsponse here
                throw;

            }

        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            var teste = await _service.ReadAsync();
        }
    }
}