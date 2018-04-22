using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace FlinFlon
{
    

    public class FrmWelcome: Form
    {
        

        /*SqlConnection myConnection = new SqlConnection("user id=username;" +
                                           "password=password;server=serverurl;" +
                                           "Trusted_Connection=yes;" +
                                           "database=database; " +
                                           "connection timeout=30");*/
        

        private Label welcome;
        private Label logIn;
        private Label empID;
        private TextBox empIDText;
        private Label empPass;
        private TextBox empPassText;
        private Button signIn;
        private Label error;
        private Panel agent;
        private CheckBox checkBox1;
        private Button LogOut;
        private Button changeUser;
        private Button newFlight;
        private Button resFlight;
        private Button changeClient;
        private Button print;
        private Button flightInfo;
        private Button clientInfo;
        private Button newBook;
        private WindowsFormsApp6.Database1DataSet database1DataSet;
        private BindingSource employeesBindingSource;
        private WindowsFormsApp6.Database1DataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private WindowsFormsApp6.Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BindingSource customersBindingSource;
        private WindowsFormsApp6.Database1DataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private IContainer components;

        public FrmWelcome()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.welcome = new System.Windows.Forms.Label();
            this.logIn = new System.Windows.Forms.Label();
            this.empID = new System.Windows.Forms.Label();
            this.empIDText = new System.Windows.Forms.TextBox();
            this.empPass = new System.Windows.Forms.Label();
            this.empPassText = new System.Windows.Forms.TextBox();
            this.signIn = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.agent = new System.Windows.Forms.Panel();
            this.changeUser = new System.Windows.Forms.Button();
            this.newFlight = new System.Windows.Forms.Button();
            this.resFlight = new System.Windows.Forms.Button();
            this.changeClient = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.flightInfo = new System.Windows.Forms.Button();
            this.clientInfo = new System.Windows.Forms.Button();
            this.newBook = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.database1DataSet = new WindowsFormsApp6.Database1DataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new WindowsFormsApp6.Database1DataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp6.Database1DataSetTableAdapters.TableAdapterManager();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new WindowsFormsApp6.Database1DataSetTableAdapters.CustomersTableAdapter();
            this.agent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(232, 46);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(377, 19);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome to Flin Flon Airlines Flight Manager!";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logIn
            // 
            this.logIn.AutoSize = true;
            this.logIn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn.Location = new System.Drawing.Point(225, 93);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(400, 19);
            this.logIn.TabIndex = 1;
            this.logIn.Text = "Please sign in using your employee information:";
            this.logIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empID
            // 
            this.empID.AutoSize = true;
            this.empID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empID.Location = new System.Drawing.Point(330, 121);
            this.empID.Name = "empID";
            this.empID.Size = new System.Drawing.Size(96, 17);
            this.empID.TabIndex = 2;
            this.empID.Text = "Employee ID";
            this.empID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empIDText
            // 
            this.empIDText.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIDText.Location = new System.Drawing.Point(333, 141);
            this.empIDText.Name = "empIDText";
            this.empIDText.Size = new System.Drawing.Size(150, 24);
            this.empIDText.TabIndex = 3;
            // 
            // empPass
            // 
            this.empPass.AutoSize = true;
            this.empPass.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPass.Location = new System.Drawing.Point(330, 176);
            this.empPass.Name = "empPass";
            this.empPass.Size = new System.Drawing.Size(75, 17);
            this.empPass.TabIndex = 4;
            this.empPass.Text = "Password";
            this.empPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empPassText
            // 
            this.empPassText.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPassText.Location = new System.Drawing.Point(333, 196);
            this.empPassText.Name = "empPassText";
            this.empPassText.PasswordChar = '*';
            this.empPassText.Size = new System.Drawing.Size(150, 24);
            this.empPassText.TabIndex = 5;
            // 
            // signIn
            // 
            this.signIn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn.Location = new System.Drawing.Point(360, 260);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(100, 37);
            this.signIn.TabIndex = 6;
            this.signIn.Text = "Sign In";
            this.signIn.Click += new System.EventHandler(this.signIn_Click_1);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(325, 232);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 7;
            this.error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // agent
            // 
            this.agent.Controls.Add(this.changeUser);
            this.agent.Controls.Add(this.newFlight);
            this.agent.Controls.Add(this.resFlight);
            this.agent.Controls.Add(this.changeClient);
            this.agent.Controls.Add(this.print);
            this.agent.Controls.Add(this.flightInfo);
            this.agent.Controls.Add(this.clientInfo);
            this.agent.Controls.Add(this.newBook);
            this.agent.Controls.Add(this.LogOut);
            this.agent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agent.Location = new System.Drawing.Point(0, 0);
            this.agent.Name = "agent";
            this.agent.Size = new System.Drawing.Size(832, 403);
            this.agent.TabIndex = 8;
            this.agent.Visible = false;
            // 
            // changeUser
            // 
            this.changeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeUser.Location = new System.Drawing.Point(650, 305);
            this.changeUser.Name = "changeUser";
            this.changeUser.Size = new System.Drawing.Size(100, 50);
            this.changeUser.TabIndex = 19;
            this.changeUser.Text = "Change Employee Information";
            this.changeUser.UseVisualStyleBackColor = true;
            this.changeUser.Visible = false;
            // 
            // newFlight
            // 
            this.newFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newFlight.Location = new System.Drawing.Point(650, 165);
            this.newFlight.Name = "newFlight";
            this.newFlight.Size = new System.Drawing.Size(100, 50);
            this.newFlight.TabIndex = 18;
            this.newFlight.Text = "Add New Flight";
            this.newFlight.UseVisualStyleBackColor = true;
            this.newFlight.Visible = false;
            // 
            // resFlight
            // 
            this.resFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resFlight.Location = new System.Drawing.Point(650, 95);
            this.resFlight.Name = "resFlight";
            this.resFlight.Size = new System.Drawing.Size(100, 50);
            this.resFlight.TabIndex = 16;
            this.resFlight.Text = "Reschedule Flight";
            this.resFlight.UseVisualStyleBackColor = true;
            this.resFlight.Visible = false;
            // 
            // changeClient
            // 
            this.changeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeClient.Location = new System.Drawing.Point(650, 235);
            this.changeClient.Name = "changeClient";
            this.changeClient.Size = new System.Drawing.Size(100, 50);
            this.changeClient.TabIndex = 17;
            this.changeClient.Text = "Change Client Information";
            this.changeClient.UseVisualStyleBackColor = true;
            this.changeClient.Visible = false;
            // 
            // print
            // 
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.Location = new System.Drawing.Point(650, 25);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(100, 50);
            this.print.TabIndex = 15;
            this.print.Text = "Print Boarding Pass";
            this.print.UseVisualStyleBackColor = true;
            // 
            // flightInfo
            // 
            this.flightInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightInfo.Location = new System.Drawing.Point(450, 25);
            this.flightInfo.Name = "flightInfo";
            this.flightInfo.Size = new System.Drawing.Size(100, 50);
            this.flightInfo.TabIndex = 14;
            this.flightInfo.Text = "Flight Information";
            this.flightInfo.UseVisualStyleBackColor = true;
            this.flightInfo.Click += new System.EventHandler(this.flightInfo_Click);
            // 
            // clientInfo
            // 
            this.clientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientInfo.Location = new System.Drawing.Point(250, 25);
            this.clientInfo.Name = "clientInfo";
            this.clientInfo.Size = new System.Drawing.Size(100, 50);
            this.clientInfo.TabIndex = 13;
            this.clientInfo.Text = "Client Information";
            this.clientInfo.UseVisualStyleBackColor = true;
            this.clientInfo.Click += new System.EventHandler(this.clientInfo_Click);
            // 
            // newBook
            // 
            this.newBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBook.Location = new System.Drawing.Point(50, 25);
            this.newBook.Name = "newBook";
            this.newBook.Size = new System.Drawing.Size(100, 50);
            this.newBook.TabIndex = 12;
            this.newBook.Text = "Create New Booking";
            this.newBook.UseVisualStyleBackColor = true;
            this.newBook.Click += new System.EventHandler(this.newBook_Click);
            // 
            // LogOut
            // 
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.Location = new System.Drawing.Point(661, 365);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(75, 23);
            this.LogOut.TabIndex = 11;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(466, 273);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Admin";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.database1DataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.FlightsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp6.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.database1DataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // FrmWelcome
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(832, 403);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.agent);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.logIn);
            this.Controls.Add(this.empID);
            this.Controls.Add(this.empIDText);
            this.Controls.Add(this.empPass);
            this.Controls.Add(this.empPassText);
            this.Controls.Add(this.signIn);
            this.Controls.Add(this.error);
            this.Name = "FrmWelcome";
            this.Text = "Flin Flon Airlines";
            this.agent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        static void Main()
        {
            Application.Run(new FrmWelcome());
        }




        private void signIn_Click_1(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                agent.Visible = true;
                resFlight.Visible = true;
                newFlight.Visible = true;
                changeClient.Visible = true;
                changeUser.Visible = true;

            }

            else if (checkBox1.Checked == false)
                agent.Visible = true;
            checkBox1.Visible = false;
        }


        private void LogOut_Click(object sender, EventArgs e)
        {
            agent.Visible = false;
            checkBox1.Visible = true;
        }

        private void newBook_Click(object sender, EventArgs e)
        {
            FrmNewBooking f = new FrmNewBooking();
            f.ShowDialog();
        }

        private void clientInfo_Click(object sender, EventArgs e)
        {
            FrmSearchClient f = new FrmSearchClient();
            f.ShowDialog();
        }

        private void flightInfo_Click(object sender, EventArgs e)
        {
            FrmSearchFlight f = new FrmSearchFlight();
            f.ShowDialog();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FrmWelcome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.database1DataSet.Employees);

        }

        private void employeesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

    


        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

