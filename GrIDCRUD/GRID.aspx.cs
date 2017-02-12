using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GrIDCRUD
{
    public partial class GRID : System.Web.UI.Page
    {
        static int x;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                x = 1;
                bindData();
            }
        }

        private void bindData()
        {
            Employee db = new GrIDCRUD.Employee();
            Repeater1.DataSource = db.Employments.ToList();
            Repeater1.DataBind();
        }
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            //set textboxes
            TextBox EmploymentId = (TextBox)e.Item.FindControl("txtEmploymentId");
            TextBox FirstName = (TextBox)e.Item.FindControl("txtFirstName");
            TextBox LastName = (TextBox)e.Item.FindControl("txtLastName");
            TextBox Salary = (TextBox)e.Item.FindControl("txtSalary");
            TextBox Address = (TextBox)e.Item.FindControl("txtAddress");
            TextBox PhoneNo = (TextBox)e.Item.FindControl("txtPhoneNo");
            //Set LinkButton
            LinkButton Select = (LinkButton)e.Item.FindControl("btnSelect");
            LinkButton Update = (LinkButton)e.Item.FindControl("btnUpdate");
            LinkButton Delete = (LinkButton)e.Item.FindControl("btnDelete");


            RequiredFieldValidator  vFirstName = (RequiredFieldValidator)e.Item.FindControl("RequiredFieldValidator1");
            RequiredFieldValidator vLastName = (RequiredFieldValidator)e.Item.FindControl("RequiredFieldValidator2");
            RequiredFieldValidator vSalary = (RequiredFieldValidator)e.Item.FindControl("RequiredFieldValidator3");
            RequiredFieldValidator vAddress = (RequiredFieldValidator)e.Item.FindControl("RequiredFieldValidator4");
            RequiredFieldValidator vPhoneNo = (RequiredFieldValidator)e.Item.FindControl("RequiredFieldValidator5");

            if (e.CommandName == "Select")
            {
                // EmploymentId.ReadOnly = false;
                FirstName.ReadOnly = false;
                LastName.ReadOnly = false;
                Salary.ReadOnly = false;
                Address.ReadOnly = false;
                PhoneNo.ReadOnly = false;

                Select.Visible = false;
                Update.Visible = true;
                Delete.Visible = true;

                // EmploymentId.BackColor = System.Drawing.Color.Yellow;
                FirstName.BackColor = System.Drawing.Color.Yellow;
                LastName.BackColor = System.Drawing.Color.Yellow;
                Salary.BackColor = System.Drawing.Color.Yellow;
                Address.BackColor = System.Drawing.Color.Yellow;
                PhoneNo.BackColor = System.Drawing.Color.Yellow;
            }
            if (e.CommandName == "Update" || e.CommandName == "Delete")
            {
                int id = Convert.ToInt32(EmploymentId.Text);
                if (e.CommandName == "Update")
                {
                    //Update.CausesValidation = true;
                    //Update.ValidationGroup = "Update";
                    //vFirstName.ValidationGroup = "Update";
                    //vLastName.ValidationGroup = "Update";
                    //vAddress.ValidationGroup = "Update";
                    //vSalary.ValidationGroup = "Update";
                    //vPhoneNo.ValidationGroup = "Update";




                    using (var db = new Employee())
                    {

                        var emp = db.Employments.SingleOrDefault(b => b.EmploymentId == id);
                        if (emp != null)
                        {
                            emp.FirstName = FirstName.Text;
                            emp.LastName = LastName.Text;
                            emp.Salary =Convert.ToInt32(Salary.Text);
                            emp.Address = Address.Text;
                            emp.PhoneNo = PhoneNo.Text;
                            db.SaveChanges();
                             bindData();
                        }
                    }

                }

                if (e.CommandName == "Delete")
                {
                    using (var db = new Employee())
                    {
                         var emp = db.Employments.SingleOrDefault(b => b.EmploymentId == id);
                        db.Employments.Remove(emp);
                        db.SaveChanges();
                        bindData();
                    }
                }


                FirstName.ReadOnly = true;
                LastName.ReadOnly = true;
                Salary.ReadOnly = true;
                Address.ReadOnly = true;
                PhoneNo.ReadOnly = true;

                Select.Visible = true;
                Update.Visible = false;
                Delete.Visible = false;

                FirstName.BackColor = System.Drawing.Color.White;
                LastName.BackColor = System.Drawing.Color.White;
                Salary.BackColor = System.Drawing.Color.White;
                Address.BackColor = System.Drawing.Color.White;
                PhoneNo.BackColor = System.Drawing.Color.White;
            }
            //For adding new record from footer template
            if(e.CommandName=="Add" || e.CommandName=="Save")
            {
                TextBox fEmploymentId = (TextBox)e.Item.FindControl("ftxtEmploymentId");
                TextBox fFirstName = (TextBox)e.Item.FindControl("ftxtFirstName");
                TextBox fLastName = (TextBox)e.Item.FindControl("ftxtLastName");
                TextBox fSalary = (TextBox)e.Item.FindControl("ftxtSalary");
                TextBox fAddress = (TextBox)e.Item.FindControl("ftxtAddress");
                TextBox fPhoneNo = (TextBox)e.Item.FindControl("ftxtPhoneNo");
                //Set LinkButton
                LinkButton fAdd = (LinkButton)e.Item.FindControl("fbtnAdd");
                LinkButton fSave = (LinkButton)e.Item.FindControl("fbtnSave");
                if(e.CommandName=="Add")
                {
                    fFirstName.Visible = true;
                    fLastName.Visible = true;
                    fAddress.Visible = true;
                    fSalary.Visible = true;
                    fPhoneNo.Visible = true;
                    fSave.Visible = true;
                    fAdd.Visible = false;
                }
                if (e.CommandName == "Save")
                {

                    using (var db = new Employee())
                    {

                        Employment emp = new GrIDCRUD.Employment();
                            emp.FirstName = fFirstName.Text;
                            emp.LastName = fLastName.Text;
                            emp.Salary = Convert.ToInt32(fSalary.Text);
                            emp.Address = fAddress.Text;
                            emp.PhoneNo = fPhoneNo.Text;
                        db.Employments.Add(emp);
                            db.SaveChanges();
                            bindData();
                        
                    }
                    fFirstName.Visible = false;
                    fLastName.Visible = false;
                    fAddress.Visible = false;
                    fSalary.Visible = false;
                    fPhoneNo.Visible = false;
                    fSave.Visible = false;
                    fAdd.Visible = true;
                }


                //RequiredFieldValidator fvFirstName = (RequiredFieldValidator)e.Item.FindControl("fRequiredFieldValidator1");
                //RequiredFieldValidator fvLastName = (RequiredFieldValidator)e.Item.FindControl("fRequiredFieldValidator2");
                //RequiredFieldValidator fvSalary = (RequiredFieldValidator)e.Item.FindControl("fRequiredFieldValidator3");
                //RequiredFieldValidator fvAddress = (RequiredFieldValidator)e.Item.FindControl("fRequiredFieldValidator4");
                //RequiredFieldValidator fvPhoneNo = (RequiredFieldValidator)e.Item.FindControl("fRequiredFieldValidator5");

            }
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                              

                LinkButton Select = (LinkButton)e.Item.FindControl("btnSelect");
                LinkButton Update = (LinkButton)e.Item.FindControl("btnUpdate");
                LinkButton Delete = (LinkButton)e.Item.FindControl("btnDelete");


                RequiredFieldValidator vFirstName = (RequiredFieldValidator)e.Item.FindControl("RequiredFieldValidator1");
                RequiredFieldValidator vLastName = (RequiredFieldValidator)e.Item.FindControl("RequiredFieldValidator2");
                RequiredFieldValidator vSalary = (RequiredFieldValidator)e.Item.FindControl("RequiredFieldValidator3");
                RequiredFieldValidator vAddress = (RequiredFieldValidator)e.Item.FindControl("RequiredFieldValidator4");
                RequiredFieldValidator vPhoneNo = (RequiredFieldValidator)e.Item.FindControl("RequiredFieldValidator5");
               
                Update.CausesValidation = true;
                string groupname= "Update" + x.ToString();
                Update.ValidationGroup = groupname;
                vFirstName.ValidationGroup = groupname;
                vLastName.ValidationGroup = groupname;
                vAddress.ValidationGroup = groupname;
                vSalary.ValidationGroup = groupname;
                vPhoneNo.ValidationGroup = groupname;
                x = x + 1;
            }
        }
    }
}