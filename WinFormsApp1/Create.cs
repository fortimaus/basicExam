using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Create : Form
    {
        Entity entity = null;
        public Create(Entity entity = null)
        {
            InitializeComponent();
            if (entity != null)
                { 
                this.entity = entity;
                textName.Text = entity.name;
                numericAge.Value = entity.age;
                textCountry.Text = entity.country;
                textPhone.Text = entity.phone;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Form1 frm = this.Owner as Form1;
            if (entity != null)
                frm.updateElement(new Entity()
                {
                    id = entity.id,
                    name = textName.Text,
                    age = (int)numericAge.Value,
                    country = textCountry.Text,
                    phone = textPhone.Text
                });
            else
                frm.addEntity(textName.Text,(int)numericAge.Value, textCountry.Text, textPhone.Text);
            this.Close();
        }
    }
}
