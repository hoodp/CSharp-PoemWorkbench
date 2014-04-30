using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*
 * Paul Hood
 * Resubmitted -- 5/1/2013
 * Lesson 1
 * No Questions asked policy
*/
namespace PoemWorkbench
{
    public partial class PoemWorkbench : Form
    {
        public PoemWorkbench()
        {
            InitializeComponent();
        }

        #region Events
        
        // event to add line
        private void btnAddLine_Click(object sender, EventArgs e)
        {
            AddLine();
        }

        // font button used for changing fonts
        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = listBoxPoem.Font; // set fontdialog to listbox font
            fontDialog1.Color = listBoxPoem.ForeColor; // set font to listbox color

            // if font dialog is changed and OK
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                listBoxPoem.Font = fontDialog1.Font; // change font
                listBoxPoem.ForeColor = fontDialog1.Color; // change color
            }
        }

        // EDITED -- text is changed inside textbox
        private void txtPoem_TextChanged(object sender, EventArgs e)
        {
            if (!(CheckLength())) // if CheckLength is not true
            {
                AddLine(); // add the line 
            }
            else
            {
                progressText.Value = line(txtPoem).Length; // for progress bar
            }
        }

        // click event for red
        private void radRed_Click(object sender, EventArgs e)
        {
            changeColor(Color.Red);
        }

        // click event for blue
        private void radBlue_Click(object sender, EventArgs e)
        {
            changeColor(Color.Blue);
        }

        // click event for green
        private void radGreen_Click(object sender, EventArgs e)
        {
            changeColor(Color.Green);
        }

        // button click for clearing all text
        private void btnClear_Click(object sender, EventArgs e)
        {
            // confirmation
            if (MessageBox.Show("This will clear all current data! Are you sure you wish to continue?", 
                    "Alert",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                txtPoem.Clear(); // clear textbox
                listBoxPoem.Items.Clear(); // clear all items in listbox             
            }
            txtPoem.Focus(); // send focus
        }

        // events for clearing last item
        private void btnClearLast_Click(object sender, EventArgs e)
        {
            // if count is greater than 0 - prevents error
            if (listBoxPoem.Items.Count > 0)
            {
                // remove at couunt - 1
                listBoxPoem.Items.RemoveAt(listBoxPoem.Items.Count - 1);
            }
            else // message box cleared
            {
                MessageBox.Show("You currently have no lines in your poem.", "Poem Clear", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtPoem.Focus(); // send focus
        }

        // button click for exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // exit application
        }
        #endregion

        #region Methods
        // CHANGED -- added method for changed backcolor of listbox
        private void changeColor(Color color)
        {
            // check to see if color matches any from radiobox
            if (color == Color.Red || color == Color.Blue
                    || color == Color.Green)
            {
                // if color is green change font color to white for better visibility
                if (color == Color.Green)
                {
                    listBoxPoem.ForeColor = Color.White;
                }
                else // change color to black
                {
                    listBoxPoem.ForeColor = Color.Black;
                }
                listBoxPoem.BackColor = color; // set backcolor to radio button
            }
            else // set back to white if there is some sort of error
            {
                listBoxPoem.BackColor = Color.White;
            }
        }

        // ADDED return string of text in the box
        public string line(TextBox box)
        {
            return box.Text.Trim(); // return trimmed textbox info
        }

        // ADDED check to see if data is valid
        public bool CheckTextBox()
        {
            // if textbox length is greater than 0
            if (line(txtPoem).Length > 0)
            {
                return true;
            }
            else // error message
            {
                MessageBox.Show("Please enter valid line into textbox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPoem.Clear(); // clear to check to blank space
                txtPoem.Focus(); // send focus
            }
            return false;
        }

        // ADDED method for adding line and updating info
        public void AddLine()
        {
            // check to see if valid
            if (CheckTextBox())
            {
                listBoxPoem.Items.Add(line(txtPoem)); // add line
                progressText.Value = 0; // reset progress value
                txtPoem.Clear(); // clear textbox
                txtPoem.Focus(); // send focus to textbox
            }
        }

        // EDITED -- method for checking length
        public bool CheckLength()
        {
            if (line(txtPoem).Length < 50) // if length is less than 50
            {
                return true;
            }
            else // more than 50
            {
                return false;
            }
        }  
        #endregion   
    }
}
