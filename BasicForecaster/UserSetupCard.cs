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
        public bool IsNew { get; private set; }

        public UserSetupCard(Form parentForm, bool isNew = false)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            dataContext = dbContext.GetInstance();
            dataUserSetup = new UserSetup();
            errorHandler = new WinFormErrorHandler();
            dataContext.UserSetup.Load();
            IsNew = isNew;

            if (IsNew)
            {
                SaveButton.Visible = true;
                Delete.Visible = false;
                NewButton.Visible = false;
            }
        }

        public UserSetupCard(string userId, Form parentForm)
            :this(parentForm)
        {
            dataUserSetup = dataContext.UserSetup.Where(u => u.UserID.Equals(userId)).FirstOrDefault();
            userIdField.Text = dataUserSetup.UserID;
            firstNameField.Text = dataUserSetup.FirstName;
            middleNameField.Text = dataUserSetup.MiddleName;
            lastNameField.Text = dataUserSetup.LastName;
            passwordField.Text = dataUserSetup.Password;
            permissionField.Text = dataUserSetup.Permission;

            if (!IsNew)
            {
                userIdField.Enabled = false;
                SaveButton.Visible = false;
            }
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

        private void NewButton_Click(object sender, EventArgs e)
        {
            UserSetupCard userSetupCard = new UserSetupCard(parentForm, true);
            userSetupCard.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbContext context = new dbContext())
                {
                    if (string.IsNullOrEmpty(userIdField.Text))
                    {
                        throw new Exception("Field 'User ID' can`t be empty!");
                    }
                    if (context.UserSetup.Where(vs => vs.UserID.Equals(userIdField.Text)).FirstOrDefault() != null)
                    {
                        throw new Exception($"Record with 'User ID' = {userIdField.Text} already exist!");
                    }
                    dataUserSetup.UserID = userIdField.Text;
                    dataUserSetup.FirstName = firstNameField.Text;
                    dataUserSetup.MiddleName = middleNameField.Text;
                    dataUserSetup.LastName = lastNameField.Text;
                    dataUserSetup.Password = passwordField.Text;
                    dataUserSetup.Permission = permissionField.Text;
                    context.UserSetup.Add(dataUserSetup);
                    context.SaveData(errorHandler);
                    UserSetupCard newUserSetupCard = new UserSetupCard(dataUserSetup.UserID, parentForm);
                    newUserSetupCard.Show();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
