using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Volonter.Folder;

namespace Volonter
{
    public partial class FormListOfEvents : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormListOfEvents(User user, bool guest)
        {
            InitializeComponent();

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "Информация";
            colInfo.FillWeight = 100;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvProduct.Columns.AddRange(
            [
                colInfo
            ]);

            CurrentUser = user;
            IsGuest = guest;

            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.Name;

            LoadProduct();
        }

        private void LoadProduct()
        {
            throw new NotImplementedException();
        }
    }
}
