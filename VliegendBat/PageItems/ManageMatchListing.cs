using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VliegendBat
{
    public partial class ManageMatchListing : UserControl
    {
        //Variables
        bool expanded = false;

        //Associated Match for this controller
        public Match match = null;

        //Functionpointer for resizing the list in the container
        public Delegate ListFunctionPointer;

        /// <summary>
        /// Make a new match listing for the Manage Match page
        /// </summary>
        /// <param name="match">The match to associate with this controller</param>
        public ManageMatchListing(Match match)
        {
            InitializeComponent();
            this.match = match;
            Height = 75;

            UpdateListing();
        }

        //Update the listing item with current information from the match
        public void UpdateListing()
        {
            //TODO: Manage anything at all in here
        }

        //Button click to expand the item
        private void btnExpand_Click(object sender, EventArgs e)
        {
            if (expanded)
            {
                Height = 75;
                expanded = false;
            }
            else
            {
                Height = 150;
                expanded = true;
            }

            //Rescale the list in the container
            ListFunctionPointer.DynamicInvoke();
        }

        //TODO: All the match functionality
    }
}
