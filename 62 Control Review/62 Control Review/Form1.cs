using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Program: Control Review
 * Author: Rick Miller
 * Date: 10-27-18
 * 
 * Purpose: 
 *   This program is intented to provide an INTRODUCTION to many of the controls available within C# window
 *   forms.  This is NOT A COMPREHENSIVE review of the capabilities of each control.
 *   
 * Version:
 *   1.0    10-27-18    Creation
 *   
 * Notes:
 * 
 *   Review each of the controls and what properties where changed.  Many were updated to create a specific
 *   effect on the screen such as ReadOnly, Enabled, Fonts, MultiLine, etc.
 *   
 *   Three picture resources have been added to this project.
 *   
 *     This was done by double clicking the "Properties" in Solution Explorer.  Then click Resources in the 
 *     left pane and selection "Add Resources" at the top.  
 *     
 *     This associates the picture files with the project so they are included with an installation package
 *     that would eventually be created.
 */

namespace _62_Control_Review
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetProgressBar(object sender, EventArgs e)
        {
            /* All Radio Buttons in the progress bar group have been setup to use the SAME event handler method.  
             *   Therefore, we need to create a RadioButton object within the method to "allow" us to get/set 
             *   properties on the appropriate RadioButton that was clicked.
             *   
             * Purpose:
             *   Set the Process Bar control based on the user selected progress.
             *   
             */

            // Recast the "sender" object into the radioClicked variable within the method.  Remember, the
            //   sender object will always be the object that "triggered" the event.  Since the Radio Buttons
            //   are the only controls using this method, we KNOW the sender object has to be a RadioButton object.
            RadioButton radioClicked = (RadioButton)sender;

            // Extract the NAME of the radioButton clicked.
            int nameLength = radioClicked.Name.Length;

            // Extract the very last digit of the name.  As the program, we setup the name to contain
            //   important information for us.  In this case, a 1 indicates the 0% button, a 2 indicates
            //   the 50% button and a 3 indicates the 100% button.
            int whichRadio = int.Parse(radioClicked.Name.Substring(nameLength - 1));

            // Utilize a SWITCH statement to handle the three conditions we are programming for.  A nested
            //   if..then..else statement could also be used.  This is a little cleaner.

            // Switch the case based on the contents of the whichRadio variable (1, 2 or 3)
            switch (whichRadio)
            {
                // 0% RadioButton clicked
                case 1:
                    // Set the Progress Bar Control to a value of 0...or 0%.
                    softwareLoadBar.Value = 0;
                    // Exit the switch statement...we are done.
                    break;

                // 50% RadioButton clicked
                case 2:
                    // Set the Progress Bar Control to a value of 50...or 50%.
                    softwareLoadBar.Value = 50;
                    break;

                // 100% RadioButton clicked
                case 3:
                    // Set the Progress Bar Control to a value of 100...or 1000%.
                    softwareLoadBar.Value = 100;
                    break;
            }
        }

        private void SetPictureBox(object sender, EventArgs e)
        {
            /* All Radio Buttons in the picture box group have been setup to use the SAME event handler method.  
             *   Therefore, we need to create a RadioButton object within the method to "allow" us to get/set 
             *   properties on the appropriate RadioButton that was clicked.
             *   
             * Purpose:
             *   Set the Picture Box to a specific picture (image) based on user selection.
             *   
             */

            // Recast the "sender" object into the radioClicked variable within the method.  Remember, the
            //   sender object will always be the object that "triggered" the event.  Since the Radio Buttons
            //   are the only controls using this method, we KNOW the sender object has to be a RadioButton object.
            RadioButton radioClicked = (RadioButton)sender;

            // Check to see if the .Name property contains a specific color.  Once again, we "hid" information in
            //   control name to be used by our program later.

            // Does it contain black?
            if (radioClicked.Name.Contains("black"))
            {
                // Update the image property in the picture box to be the Black Coin we added to the project.
                imageSelectBox.Image = _62_Control_Review.Properties.Resources.Connect_4_Black_Coin;
            }
            else
            {
                // Does it contain grey?
                if (radioClicked.Name.Contains("grey"))
                {
                    // Update image property to the grey (or empty) coin.
                    imageSelectBox.Image = _62_Control_Review.Properties.Resources.Connect_4_Empty;
                }
                else
                {
                    // Update the image property to the red coin.
                    imageSelectBox.Image = _62_Control_Review.Properties.Resources.Connect_4_Red_Coin;
                }
            }
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Close the active Form.  Since this is the main form, essentially we are closing the program.
            Close();
        }

        private void anyCheckedChanged(object sender, EventArgs e)
        {
            /* All Check Boxes in the dynamic combo box group have been setup to use the SAME event handler method.  
             *   Therefore, we need to create a CheckBox object within the method to "allow" us to get/set 
             *   properties on the appropriate CheckBox that was clicked.
             *   
             * Purpose:
             *   Add an entry to the dropdown list in the dynamicComboBox control.
             *   
             */

            // Recast the "sender" object into the checkboxChanged variable within the method.  Remember, the
            //   sender object will always be the object that "triggered" the event.  Since the Check Boxes
            //   are the only controls using this method, we KNOW the sender object has to be a CheckBox object.
            CheckBox checkboxChanged = (CheckBox)sender;

            // We have two possible actions:
            //   If checked, then add the item.
            //   If unchecked, then remove the item.

            // Is it checked?
            if (checkboxChanged.Checked)
            {
                // Add the Text of the checked box to the dynamicComboBox collection of items.
                dynamicComboBox.Items.Add(checkboxChanged.Text);
            }
            else
            {
                // Remove the Text of the checked box from the dynamicComboBox collection of items.
                dynamicComboBox.Items.Remove(checkboxChanged.Text);
            }
        }

        private void lockedComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             * Purpose:
             *   Based on user selection, add the selected item to the list in the dynamicListBox control
             */

            // Add the SelectedItem to the list of the dynamicListBox
            dynamicListBox.Items.Add(lockedComboBox.SelectedItem);
        }

        private void unlockedComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {            
            /*
             * This difference between the locked and unlocked version of this control is in the control itself.
             * This one will NOT allow the user to free form an entry into the control.  They MUST use one of the
             * selections.
             * 
             *   This is accomplished by setting the DropDownStyle property to DropDownList
             * 
             * Purpose:
             *   Based on user selection, add the selected item to the list in the dynamicListBox control
             */

            // Add the SelectedItem to the list of the dynamicListBox
            dynamicListBox.Items.Add(unlockedComboBox.SelectedItem);
        }

        private void unmaskTextBox_TextChanged(object sender, EventArgs e)
        {
            /*
             * Purpose:
             *   Take the text that user is entered and update a Read Only, MultiLine text box with
             *   scroll bar controls.
             *   
             * To make a multi line, read only text box with scroll bars set the following properties.
             *   MultiLine = true
             *   ReadOnly = true
             *   ScrollBars = Both 
             *   
             * Since the TextChanged event is used the Text Box is updated for EVERY key entry of the
             *   user.  In a real program, this is properly not what we want.  We would wait for the user to
             *   hit enter.
             */

            // Update the .Text property of the multiLineTextBox control with the .Text propery of this control.
            //   To create a new line in the text box, a carriage return (\r) and a new line (\n) must be added.
            multiLineTextBox.Text += unmaskTextBox.Text + "\r\n";
        }

        private void maskedTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            /*
             * Purpose:
             *   Take the text that user is entered and update a Read Only, MultiLine text box with
             *   scroll bar controls.
             *   
             *   Unlike the unmaskedTextBox control this one uses the KeyDown event (aka the user hit a key)
             *     to control when to update the multiLineTextBox control.  In this case, it is updated when
             *     the user hits enter.
             */

            // Has the user hit the ENTER key yet?
            if (e.KeyCode == Keys.Enter)
            {
                // Update the .Text property of the multiLineTextBox control with the .Text propery of this control.
                //   To create a new line in the text box, a carriage return (\r) and a new line (\n) must be added.
                multiLineTextBox.Text += maskedTextBox.Text + "\r\n";
            }
        }

        private void inputCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            /*
             * Purpose: 
             *   Update the outputCalendar with the information selection on the inputCalendar.
             *   
             * The MonthCalendar control allows the user to select a RANGE of dates where the DateTimePicker
             *   control allows the user to selection ONE date.
             */
            
            // Set the date range on the output calendar to the SelectionStart and SelectionEnd of the input 
            outputCalendar.SetSelectionRange(inputCalendar.SelectionStart, inputCalendar.SelectionEnd);
        }

        private void inputDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            /*
             * Purpose: 
             *   Update the outputCalendar with the information selection on the inputCalendar.
             *   
             * The MonthCalendar control allows the user to select a RANGE of dates where the DateTimePicker
             *   control allows the user to selection ONE date.
             */

            // Set the date on the output calendar to the date selected in the DateTimePicker
            outputCalendar.SetDate(inputDateTimePicker.Value);
        }

        private void radioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * Purpose:
             *   Use the Open File Dialog control to allow the user to select a file to open
             *   
             * The dialog directly interacts with the Windows operating system to present a familiar
             *   interface to the user and validate all conditions are meet from an operating system
             *   perspective.
             */

            // Display the dialog box and proceed if the dialog returns an OK status
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Use the MessageBox show object to display what file the user selected to open.
                MessageBox.Show("File to open: " + openFileDialog1.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * Purpose:
             *   Use the Save File Dialog control to allow the user to save to a specific file
             *   
             * The dialog directly interacts with the Windows operating system to present a familiar
             *   interface to the user and validate all conditions are meet from an operating system
             *   perspective.
             */

            // Display the dialog box and proceed if the dialog returns an OK status
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Use the MessageBox show object to display what file the user wants to save to.
                MessageBox.Show("File to save: " + saveFileDialog1.FileName);
            }
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * Purpose:
             *   Demonstrate that a Print Dialog control exists to once again present a familiar
             *     interface to the user.
             *     
             * To actually print a file, there is a bit more setup that must be done first.  That
             * will be left to a later example.
             */
            printDialog1.ShowDialog();
        }

        private void option1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * Purpose:
             *   Present the user with the familiar Font selection dialog.  Once a selection is made
             *   update the fontLabel control with the new font settings.
             *   
             *   Extra coding would be required to set the font to bold, italic, etc.  For now, the
             *   program will only set to a regular style.
             */

            // Display the font dialog and proceed if a result of OK is returned.
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                // Update the Font property in the fontLabel control to the selected font.
                fontLabel.Font = new Font(fontDialog1.Font, FontStyle.Regular);
            }
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * Purpose:
             *   Present the user with the familiar Color Picker dialog.  Once a selection is made
             *   set the background of the active form (aka the main form) to that color.
             */

            // Display the color picker dialog and proceed if a result of OK is returned
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Set the backcolor of the active form to the color selected.
                this.BackColor = colorDialog1.Color;
            }
        }

        private void clickMeButton_Click(object sender, EventArgs e)
        {
            /*
             * Purpose:
             *   Open a second form when the user clicks the button.
             *   
             * New forms are created by add a new item in Solution Explorer and selecting Windows Form.
             *   The form is then setup just like any other form.
             *   
             * The new form is an object called a Form.  Just like any other object, you can create an 
             *   instance of the object and then use.
             *   
             * Notice the form that was created DOES NOT have an X to close the form.  Look at the properties 
             *   of that form to determine what property was set to create this behavior.
             */

            // Create an instance of the SimpleForm object called displayForm
            SimpleForm displayForm = new SimpleForm();

            // Display the form on the screen
            displayForm.Show();
        }

        private void exitToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            // Event is activated because the user moved the mouse over
            //   the Menu2 option in the MenuStrip control.

            // Create a new point (X,Y) to use to relocation the infoLabel control

            //   Adding 15 to the X coordinate and subtracting 10 from the Y coordinate
            //   was determined through trial and error.

            infoLabel.Location = new Point(90, 25);

            // Update the text displayed in the label .TEXT propery.
            infoLabel.Text = "This Menu option does absolutely nothing.";

            // Show the label on the screen.
            infoLabel.Visible = true;
        }

        private void exitToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            // Event is activated because the user moved the mouse away
            //   from the Menu2 option in the MenuStrip control.

            // Hide the label control
            infoLabel.Visible = false;
        }

      private void trackBar1_Scroll(object sender, EventArgs e)
      {
         // Set the Progress Bar control to equal the Value on the Track Bar Slider Control
         softwareLoadBar.Value = trackBar1.Value;
      }

      private void numericUpDown1_ValueChanged(object sender, EventArgs e)
      {
         softwareLoadBar.Value = Convert.ToInt32(numericUpDown1.Value);
      }
   }
}
