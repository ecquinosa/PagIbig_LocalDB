using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace PagibigDBLocal
{
    public partial class Query : Form
    {
        public Query()
        {
            InitializeComponent();
        }

        private void Query_Load(object sender, EventArgs e)
        {
            GetConfig();
        }

        private void Search()
        {
            //DAL.MsSql dal = new DAL.MsSql();
        }

        private void GetConfig()
        {
            string envFile = string.Concat(Application.StartupPath,"\\","env.json");
            string data = System.IO.File.ReadAllText(envFile);
            string server = "";
            string database = "";
            string user = "";
            string password = "";

            string serverKeyword = @"""Server"":";
            string databaseKeyword = @"""Database"":";
            string userKeyword = @"""UID"":";
            string passwordKeyword = @"""PWD"":";

            int serverStartIndex = data.IndexOf(serverKeyword);
            int serverEndIndex = data.IndexOf(",", serverStartIndex);
            int databaseStartIndex = data.IndexOf(databaseKeyword);
            int databaseEndIndex = data.IndexOf(",", databaseStartIndex);
            int userStartIndex = data.IndexOf(userKeyword);
            int userEndIndex = data.IndexOf(",", userStartIndex);
            int passwordStartIndex = data.IndexOf(passwordKeyword);
            int passwordEndIndex = data.IndexOf(",", passwordStartIndex);

            if (serverStartIndex != -1) server = data.Substring(serverStartIndex + serverKeyword.Length, (serverEndIndex - serverStartIndex) - serverKeyword.Length).Replace(@"""", "");
           
        }
    }
}
