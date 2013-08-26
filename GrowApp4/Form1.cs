using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrowOP
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            this.Text = "GrowOP Helper V1.0";
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'growAppDataSet.calendarHarvestDate' table. You can move, or remove it, as needed.
            this.calendarHarvestDateTableAdapter.Fill(this.growAppDataSet.calendarHarvestDate);
            // TODO: This line of code loads data into the 'growAppDataSet.calendarFlowerDate' table. You can move, or remove it, as needed.
            this.calendarFlowerDateTable.Fill(this.growAppDataSet.calendarFlowerDate);
            // TODO: This line of code loads data into the 'growAppDataSet.Plants' table. You can move, or remove it, as needed.
            this.plantsTableAdapter.Fill(this.growAppDataSet.Plants);
            this.Update_Calendar();
        }

        private void Update_Calendar()
        {
            
            foreach (DataRow dr in calendarHarvestDateTableAdapter.GetData())
            {
                DateTime dt = (DateTime) dr[2];
                this.calendar1.AddBoldedDate((DateTime) dr[2]);
              
            }
            foreach (DataRow dr in calendarFlowerDateTable.GetData())
            {
                DateTime dt = (DateTime)dr[2];
                this.calendar1.AddBoldedDate((DateTime)dr[2]);
                //this.txtEvents.Text = txtEvents.Text + dt.Month + "-" + dt.Day + "-" + dt.Year + " - Move to Flowering " + dr[1].ToString() + "\n\n";
            }
            this.calendar1.UpdateBoldedDates();

            
        }


        private void calendarFlowerDateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            ValidateAndSave();


        }

        private void ValidateAndSave()
        {
            this.Validate();
            this.plantsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.growAppDataSet);
            this.Update_Calendar();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

          
            //need to get the last number in the database, count() is unreliable at this.
            try
            {
                int i = (int)plantsTableAdapter.Count();
                uIDLabel1.Text = Convert.ToString(i + 1);
            }
            catch
            {
                uIDLabel1.Text = "1";
            }

            initialDateDateTimePicker.Value = Convert.ToDateTime("1/1/1999");
            flowerDateDateTimePicker.Value = Convert.ToDateTime("1/1/1999");
            harvestDateDateTimePicker.Value = Convert.ToDateTime("1/1/1999");
            wetWeightTextBox.Text = "0";
            dryWeightTextBox.Text = "0";
            notesRichTextBox.Text = "";

            try
            {
                this.Validate();
                this.plantsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.growAppDataSet);
                this.Update_Calendar();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }

            
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Update_Calendar();
            ValidateAndSave();
            //this.plantsTableAdapter.Fill(this.growAppDataSet.Plants);

        }

        private void calendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.Update_Calendar();
            this.txtEvents.Text = "";
            //MessageBox.Show(e.End.Year.ToString());
            foreach (DataRow dr in calendarFlowerDateTable.SingleDate(e.End.Date))
            {
                DateTime dt = (DateTime) dr[2];
                string name = (string) dr[1];
                string id = Convert.ToString(dr[0]);
                this.txtEvents.Text = "Move "+id+": "+name+" to Flowering.\n\n";
            }
            
            foreach(DataRow dr in calendarHarvestDateTableAdapter.SingleDate(e.End.Date))
            {
                DateTime dt = (DateTime)dr[2];
                string name = (string)dr[1];
                string id = Convert.ToString(dr[0]);
                this.txtEvents.Text = "Harvest "+id+": "+name+"\n\n";
            }
        }


    }
}
