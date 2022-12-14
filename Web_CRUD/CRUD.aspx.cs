using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CRUD
{
    public partial class CRUD : System.Web.UI.Page
    {
        DataTable data = new DataTable();
        Connection conn = new Connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                conn.GetData();
            }
        }

        protected void GridShow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void Updated(object sender, GridViewUpdateEventArgs e)
        {
            TextBox ID= (TextBox)GridShow.Rows[e.RowIndex].Cells[0].Controls[0];
            TextBox Name = (TextBox)GridShow.Rows[e.RowIndex].Cells[1].Controls[0];
            TextBox Surname = (TextBox)GridShow.Rows[e.RowIndex].Cells[2].Controls[0];
            TextBox Email = (TextBox)GridShow.Rows[e.RowIndex].Cells[3].Controls[0];
            TextBox Job = (TextBox)GridShow.Rows[e.RowIndex].Cells[4].Controls[0];
            TextBox Position = (TextBox)GridShow.Rows[e.RowIndex].Cells[5].Controls[0];


            conn.Update(ID.Text, Name.Text, Surname.Text, Email.Text, Job.Text, Position.Text);
            GridShow.EditIndex = -1;
            GetData();
        }

        protected void Delete(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridShow.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[0].Text);
            conn.Delete(id);
            GetData();
        }

        protected void Edit(object sender, GridViewEditEventArgs e)
        {
            GridShow.EditIndex = e.NewEditIndex;
            GetData();
        }
        protected void cancel(object sender, GridViewCancelEditEventArgs e)
        {
            GridShow.EditIndex = -1;
            GetData();
        }

        protected void GetData()
        {
            conn.GetData().Fill(data);
            GridShow.DataSource = data;
            GridShow.DataBind();
        }
    }
}