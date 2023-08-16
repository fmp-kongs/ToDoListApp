using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ToDoListApp
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        public int generateId()     // Generating Random IDs
        {
            Random rnd = new Random();
            return rnd.Next(10000);//returns random integers < 1000
        }

        DataTable todoList = new DataTable();      // creation of data-table

        


        // Filtering Starts **********************************************************************

        string filterField = "";
        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            ToDoListView.DataSource = todoList;

            todoList.DefaultView.RowFilter = string.Format("[Status] LIKE '%{1}%'", filterField, FilterTextBox.Text);

        }
        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            ToDoListView.DataSource = todoList;

            todoList.DefaultView.RowFilter = string.Format("[Prioritized Task] LIKE '%{1}%'", filterField, FilterTextBox2.Text);

        }

        private void IdFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            ToDoListView.DataSource = todoList;

            todoList.DefaultView.RowFilter = string.Format("[ID] LIKE '%{1}%'", filterField, IdFilterTextBox.Text);

        }

        // Filtering ends ******************************************************************************

        // SORTING Starts ******************************************************************************
        private void button3_Click(object sender, EventArgs e)
        {
            ToDoListView.DataSource = todoList;

            todoList.DefaultView.Sort = "Title ASC";
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            //todoList.DefaultView.Sort = "Due Date ASC";

            var orderedRows = from row in todoList.AsEnumerable()
                              orderby row.Field<DateTime>("Due Date")
                              select row;
            DataTable tblOrdered = orderedRows.CopyToDataTable();
            ToDoListView.DataSource = tblOrdered;

        }
        // SORTING Ends ******************************************************************************



        bool isEditing = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Add Columns
            todoList.Columns.Add("ID"); // col 0
            todoList.Columns.Add("Title"); // col 1
            todoList.Columns.Add("Description"); // col2
            todoList.Columns.Add("Status"); // col3
            todoList.Columns.Add("Due Date",typeof(DateTime)); // col4   
            todoList.Columns.Add("Prioritized Task"); //col5

            //point our datagridView to data source
            ToDoListView.DataSource = todoList;
        }

        

        // ADD Button ***********************************************
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ToDoListView.DataSource = todoList;

            TitleTextbox.Text = "";
            descriptionTextbox.Text = "";
            StatusComboBox.SelectedIndex = 1;
            PriorityComboBox.SelectedIndex = 1;
        }

        // EDIT Button **************************************************
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ToDoListView.DataSource = todoList;

            isEditing = true;
            // fill text fields with data from table

            try
            {
                TitleTextbox.Text = todoList.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
                descriptionTextbox.Text = todoList.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[2].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Select a valid task for editing!!");
            }

        }

        // EDIT Button **************************************************


        //DELETE Button ***************************************************
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ToDoListView.DataSource = todoList;

            try
            {
                todoList.Rows[ToDoListView.CurrentCell.RowIndex].Delete();

            }
            catch(Exception ex) 
            {
                MessageBox.Show("Select a valid task for deletion!!");
                //MessageBox.Show("Error: "+ex);
            }
        }
        //DELETE Button ***************************************************




        // SAVE Button *******************************************
        private void buttonSave_Click(object sender, EventArgs e)
        {
            ToDoListView.DataSource = todoList;

            if (isEditing)
            {
                if (TitleTextbox.Text == "" | descriptionTextbox.Text == "")      // checking if the title and description fields are empty
                {
                    MessageBox.Show("Enter the necessary fields before saving the task!!");
                }
                else
                {
                    todoList.Rows[ToDoListView.CurrentCell.RowIndex]["Title"] = TitleTextbox.Text;
                    todoList.Rows[ToDoListView.CurrentCell.RowIndex]["Description"] = descriptionTextbox.Text;
                    todoList.Rows[ToDoListView.CurrentCell.RowIndex]["Due Date"] = DuedateMonthCalendar.SelectionRange.Start;
                    todoList.Rows[ToDoListView.CurrentCell.RowIndex]["Status"] = StatusComboBox.SelectedItem.ToString();
                    todoList.Rows[ToDoListView.CurrentCell.RowIndex]["Prioritized Task"] = PriorityComboBox.SelectedItem.ToString();
                }
                

            }
            else
            {
                var id = generateId();

                try
                {
                    if(TitleTextbox.Text == "" | descriptionTextbox.Text == "")
                    {
                        MessageBox.Show("Enter the necessary fields before saving the task!!");
                    }
                    else
                    {
                        todoList.Rows.Add(id, TitleTextbox.Text, descriptionTextbox.Text, StatusComboBox.SelectedItem.ToString(), DuedateMonthCalendar.SelectionRange.Start.ToShortDateString(), PriorityComboBox.SelectedItem.ToString());

                    }
                    
                   
                }
                catch(Exception ex) 
                {
                    //
                    MessageBox.Show("Enter the fields before adding the task!");
                }

            }
            // clear fields
            TitleTextbox.Text = "";
            descriptionTextbox.Text = "";
            StatusComboBox.SelectedIndex = 1;
            PriorityComboBox.SelectedIndex = 1;

            isEditing = false;
        }
        // SAVE Button *****************************************************




        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Description_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)     // Exiting from Application
        {
           
            this.Close();
            //System.Windows.Forms.Application.ExitThread();


        }

        private void button1_Click(object sender, EventArgs e)      // save listed taks to a file 
        {
            ToDoListView.DataSource = todoList;

            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(todoList);
            string path = @"C:\Users\FakirMohanPatra\OneDrive - Kongsberg Digital AS\Desktop\Kongs_Training\dotNET\ToDoListApp\tasksFile2.json";
            using (var tw = new StreamWriter(path))
            {
                tw.WriteLine(JSONString.ToString());
                tw.Close();
            }
        }
        

        private void button2_Click(object sender, EventArgs e)    // loading tasks data from  a file
        {
            try
            {
                string json = File.ReadAllText(@"C:\Users\FakirMohanPatra\OneDrive - Kongsberg Digital AS\Desktop\Kongs_Training\dotNET\ToDoListApp\tasksFile1.json");
                DataTable todolist1 = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
                var rows = todolist1.Rows.Count;
                //var cols = todolist1.Columns.Count; 


                for (int i = 0; i < rows; i++)     // printing the data in form UI
                {
                    todoList.Rows.Add(todolist1.Rows[i][0], todolist1.Rows[i][1], todolist1.Rows[i][2], todolist1.Rows[i][3], todolist1.Rows[i][4], todolist1.Rows[i][5]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("File not Found !!");
            }
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }


    

}
