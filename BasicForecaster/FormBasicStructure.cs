using BasicForecaster.Interfaces;
using BasicForecaster.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicForecaster
{
    public class FormBasicStructure <TEntity> : Form
        where TEntity : class
    {
        protected dbContext dataContext = null;
        protected TEntity entity = null;
        protected IErrorHandler errorHandler;
        protected Form parentForm;
        public bool IsNew { get; protected set; }
        protected Button SaveButton;
        protected Button DeleteButton;
        protected Button NewButton;


        public FormBasicStructure(IErrorHandler errorHandler, Form parentForm, TEntity entity, bool isNew)
        {
            dataContext = dbContext.GetInstance();
            this.errorHandler = errorHandler;
            this.parentForm = parentForm;
            this.entity = entity;
            dataContext.Set<TEntity>().Load();
            IsNew = isNew;
        }

        protected void CreateControlls()
        {
            int pointX = 210;
            int pointY = 8;
            int lPointX = 12;
            int lPointY = 8;
            foreach (var field in typeof(TEntity).GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Size = new System.Drawing.Size(200, 20);
                label.Location = new System.Drawing.Point(lPointX, lPointY);
                label.Text = field.Name.Split('<')[1].Split('>')[0];
                Control text = null;
                var a = field.FieldType;
                if (field.FieldType == typeof(string) || field.FieldType == typeof(double?) || field.FieldType == typeof(int?))
                {
                    text = new TextBox();
                    text.Name = field.Name;
                    text.Size = new System.Drawing.Size(257, 20);
                    text.Location = new System.Drawing.Point(pointX, pointY);
                }
                else if(field.FieldType == typeof(bool?))
                {
                    text = new CheckBox();
                    text.Name = field.Name;
                    text.Size = new System.Drawing.Size(257, 20);
                    text.Location = new System.Drawing.Point(pointX, pointY);
                }
                
                this.Controls.Add(text);
                this.Controls.Add(label);
                pointY += 26;
                lPointY += 26;
            }
        }
    }
}
