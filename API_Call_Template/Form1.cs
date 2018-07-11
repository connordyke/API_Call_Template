using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API_Call_Template
{
    public partial class frmAPICall : Form
    {

        WebClient client = new WebClient();
        string jsonString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

            public frmAPICall()
        {
            InitializeComponent();
        }

        private void frmAPICall_Load(object sender, EventArgs e)
        {

        }

            private void btnNASA_Click(object sender, EventArgs e)
            {
                jsonString = client.DownloadString("https://api.nasa.gov/planetary/apod?api_key=YwNNIddOo87RYesGXGnMAQN8lv7Sd5mY2w20owsP&date=2018-07-09");
                var apod = Apod.FromJson(jsonString);

            picAPOD.Load(apod.Url);

            }
    }
}