using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//THE FOLLOWING IS THE START OF THE MULTITHREADING PROGRAM
//*           AUTHOR: SWETHA RAMASWAMY
//*           NET ID: sxr178830   
namespace Asg5_sxr178830
{
    public partial class Form1 : Form
    {
        //****INITIALIZING MANY GLOBAL VARIABLES****//
        public string srch;
        public string filename;
        public string[] file;
        public int count = 0;
        public Boolean interruptedsearch = false;
        public Boolean casesensitive = false;
        public ListViewItem li = new ListViewItem();
        //****THE FOLLOWING METHOD IS CALLED WHEN WE LAUNCH THE PROGRAM****//
        //*IT INITIALIZES MANY COMPONENTS OF THE FORM*//

        public Form1()
        {
            InitializeComponent();
            occurances.AppendText("Line_Num"+"  "+"Line_Details");
        }
        //***THE FOLLOWING METHOD EXPLAINS ALL THE HAPPENINGS WHEN THE BROWSE BUTTON IS CLICKED***// 
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            string abcd;
            bool isDataLoaded = true;
            Status.Text = "Choosing a file";// outputting results on the status bar
            if (result == DialogResult.OK) // Test result.
            {
                Status.Text = "File Selected";// comments in the status bar allwoing the user to know what is going on in the background


                one.Text = openFileDialog1.FileName;
                filename = openFileDialog1.FileName;

            }
            
            

            }
        //****THE FOLLOWING METHOD IS FOR COMPARISON OF THE USER ENTERED WORD AND THE WORDS IN TEXT FILES*****/
        public  bool contain(string source, string toCheck, StringComparison comp)
        {
            return source != null && toCheck != null && source.IndexOf(toCheck, comp) >= 0;
          }


        //*****THE FOLLOWING WORD IS THE EVENT WHEN THE SEARCH BUTTON IS CLICKED********
            private async void searchbtn_Click(object sender, EventArgs e)
        {
            
            Status.Text = "Searching the file";
            clear();
            srch = two.Text;                         
            int lineNumber = 0;
            //*****THE FOLLOWING IS FOR CASE INSENSITIVE COMPARISON****//
            if (casesensitive == false)
            {

                foreach (String line in File.ReadLines(filename))
                {
                    if (interruptedsearch == false)
                    {

                        await Task.Run(() => System.Threading.Thread.Sleep(2));
                        String[] check = line.Split();
                        for (int i = 0; i < check.Length; i++)
                        {
                            
                            if ((contain(check[i], srch, StringComparison.OrdinalIgnoreCase)) == true)
                            {
                                count++;
                                AppendTextBox(line, lineNumber);


                            }
                            lineNumber++;


                        }
                    }
                    else
                    {
                        Status.Text = "Search terminated with " + count.ToString() + " occurances";
                        interruptedsearch = false;
                        lineNumber = 0;
                        break;

                    }
                }


                Status.Text = "Search done with " + count.ToString() + " occurances";
                count = 0;

            }
            //*****THE FOLLOWING IS FOR CASE SENSITIVE COMPARISON****//
            else
            {

                foreach (String line in File.ReadLines(filename))
                {
                    if (interruptedsearch == false)
                    {

                        await Task.Run(() => System.Threading.Thread.Sleep(2));
                        String[] check = line.Split();
                        for (int i = 0; i < check.Length; i++)
                        {
                            
                            if ((contain(check[i], srch, StringComparison.Ordinal)) == true)
                            {
                                count++;
                                AppendTextBox(line, lineNumber);


                            }
                            lineNumber++;


                        }
                    }
                    else
                    {
                        Status.Text = "Search terminated with " + count.ToString() + " occurances";
                        interruptedsearch = false;
                        lineNumber = 0;
                        break;

                    }
                }


                Status.Text = "Search done with " + count.ToString() + " occurances";// displaying the progress on the status bar
                count = 0;

            }
        }
        //*****THE FOLLOWING METHOD IS CALLED TO CLEAR THE PREVIOUS SEARCH RESULTS*********//
        public async void clear()
        {

           
                this.datadisplay.Items.Clear();
                this.datadisplay.Update(); // In case there is databinding
                this.datadisplay.Refresh(); // Redraw items
            
        }
        //******THE FOLLOWING THREAD IS CALLED TO DISPLAY THE SEARCH RESULTS ON THE SCREEN*******//
        public async void AppendTextBox(string value,long line)
        {
            

            this.Invoke((MethodInvoker)delegate ()
            {
                string[] row = { line.ToString(),value};
                

                var listViewItem = new ListViewItem(row);// entering the values in the listview frm the file selected
                datadisplay.Items.Add(listViewItem);
                //******THE FOLLOWING IS USED TO HIGHLIGHT THE SENTENCES WHICH MATCH THE CASE EXACTLY EVEN WHILE SEARCHING WITH CASE INSENSITIVE****//
                    foreach (ColumnHeader line_text in datadisplay.Columns)
                    {
                        foreach (ListViewItem items in datadisplay.Items)
                        {
                            if (items.SubItems[line_text.Index].Text.Contains(srch) == true)
                            {
                                datadisplay.Items[items.Index].UseItemStyleForSubItems = false;
                                datadisplay.Items[items.Index].SubItems[line_text.Index]
                                                            .BackColor = Color.LightBlue;
                            }
                        }
                    }
                

                datadisplay.EnsureVisible(datadisplay.Items.Count - 1);


            });



        }
        //*******THE FOLLOWING IS THE METHOD FOR INTERRUPTION OF THE SEARCH********//
        private void stop_Click(object sender, EventArgs e)
        {

            interruptedsearch = true;
        }
        //***THE FOLLOWING IS THE EVENT FOR VALIDATING THE USER'S CHOICES*******//
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                casesensitive = true;
            }
            else
            {
                casesensitive = false;
            }
            
        }
    }

}
