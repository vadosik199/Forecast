using BasicForecaster.Interfaces;
using BasicForecaster.Models;
using BasicForecaster.Models.Setup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicForecaster
{
    public partial class UserSetupCard : Form
    {
        private dbContext dataContext = null;
        private UserSetup dataUserSetup = null;
        private IErrorHandler errorHandler;
        private Form parentForm;

        public UserSetupCard()
        {
            InitializeComponent();
            dataContext = new dbContext();
            errorHandler = new WinFormErrorHandler();
        }

        public UserSetupCard(string userId, Form parentForm)
            :this()
        {
            this.parentForm = parentForm;
            dataContext.UserSetup.Load();
            dataUserSetup = dataContext.UserSetup.Where(u => u.UserID.Equals(userId)).FirstOrDefault();
            userIdField.Text = dataUserSetup.UserID;
            firstNameField.Text = dataUserSetup.FirstName;
            middleNameField.Text = dataUserSetup.MiddleName;
            lastNameField.Text = dataUserSetup.LastName;
            passwordField.Text = dataUserSetup.Password;
            permissionField.Text = dataUserSetup.Permission;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataContext.UserSetup.Remove(dataUserSetup);
                dataContext.SaveChanges();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void userIdField_TextChanged(object sender, EventArgs e)
        {
            dataUserSetup.UserID = userIdField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void firstNameField_TextChanged(object sender, EventArgs e)
        {
            dataUserSetup.FirstName = firstNameField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void middleNameField_TextChanged(object sender, EventArgs e)
        {
            dataUserSetup.MiddleName = middleNameField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void lastNameField_TextChanged(object sender, EventArgs e)
        {
            dataUserSetup.LastName = lastNameField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {
            dataUserSetup.Password = passwordField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void permissionField_TextChanged(object sender, EventArgs e)
        {
            dataUserSetup.Permission = permissionField.Text;
            dataContext.SaveData(errorHandler);
        }

        private void RefreshParentForm()
        {
            parentForm.Refresh();
        }

        private void UserSetupCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataContext.SaveData(errorHandler);
            RefreshParentForm();
        }
    }
}
