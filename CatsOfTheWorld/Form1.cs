/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CatsOfTheWorld
{
    public partial class frmCatsOfTheWorld : Form
    {
        List<Cat> cats;
        public frmCatsOfTheWorld()
        {
            InitializeComponent();
            cats = new List<Cat>();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // ToDo 2. Get rid of this method, it's annoying
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            // ToDo  1. Add a new cat to cats List using the contents of txtCat as the name.
        }

        private void btnCopyCats_Click(object sender, EventArgs e)
        {
            //  ToDo 3. Copy the contents of the cats List to the list box: 
            //          one element in the list becomes one item in the ListBox
        }

        // ToDo 5: Add a button on the form and associated logic to clear lbCatsOnFile when clicked
    }
}
