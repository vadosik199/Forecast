using BasicForecaster.Models;
using BasicForecaster.Models.Setup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicForecaster
{
    public partial class TestForm : FormBasicStructure<ItemSetup>
    {
        public TestForm()
            :base(new WinFormErrorHandler(), new Form(), new ItemSetup(), false)
        {
            InitializeComponent();
            CreateControlls();
        }
    }
}
