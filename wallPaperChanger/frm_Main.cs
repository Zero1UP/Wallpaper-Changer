using System;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;

namespace wallPaperChanger
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        ArrayList imageList;
        int totalSeconds = 0;
        int inputHours = 0;
        int inputMinutes = 0;
        int inputSeconds = 0;
        

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(UInt32 uiAction, UInt32 uiParam, String pvParam, UInt32 fWinIni);
        private static UInt32 SPI_SETDESKWALLPAPER = 20;
        private static UInt32 SPIF_UPDATEINIFILE = 0x1;

        private void btn_FolderBrowser_Click(object sender, EventArgs e)
        {
            //Create a folder dialog and open it
            FolderBrowserDialog fdrBrowser = new FolderBrowserDialog();

            try
            {
                fdrBrowser.ShowDialog();

                //For display purpose only
                txt_WallPaperLocation.Text = fdrBrowser.SelectedPath;

                //Save the folder location to a setting that can be found in the projects settings
                Properties.Settings.Default.folderPath =fdrBrowser.SelectedPath;
                Properties.Settings.Default.Save();

            }
            catch (Exception folderMessage)
            {
                MessageBox.Show("An error has occured: '{0}'", folderMessage.Message);
            }


        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            try
            {

                DirectoryInfo dirInfo = new DirectoryInfo(Properties.Settings.Default.folderPath);

                //Grabs all images (currently just jpgs)
                FileInfo[] images = dirInfo.GetFiles("*.jpg ");

                //This is just a visual for the user to tell them what folder they had selected
                txt_WallPaperLocation.Text = Properties.Settings.Default.folderPath;

                imageList = new ArrayList();

                //Put all images(full paths) into the array list
                foreach (FileInfo files in images)
                {
                    imageList.Add(files.FullName);

                }

            }
            catch (Exception mainError)
            {
                MessageBox.Show(mainError.Message);
            }
        }


        int imageCounter = 0;

        private void tmr_RotateImages_Tick(object sender, EventArgs e)
        {
            //if we go over the count limit, just reset it
            if (imageCounter > imageList.Count - 1)
                imageCounter = 0;

            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, imageList[imageCounter].ToString(), SPIF_UPDATEINIFILE);
            imageCounter++;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            //debug code
            //Set the timer to 5 seconds
            //This will be able to be set by the user later on

            // Convert hours, minutes 
            totalSeconds = (inputHours * 3600) + (inputMinutes * 60) + inputSeconds;
           

            tmr_RotateImages.Interval= totalSeconds;

            //Activate the timer
            //tmr_RotateImages.Enabled = true;
        }

        private void txtMasked_Hour_TextChanged(object sender, EventArgs e)
        {
            //Validate user input
            if (!int.TryParse(txtMasked_Hour.Text, out inputHours))
            {
                MessageBox.Show("Please enter a valid number for Hours!");
            }
                        
        }

        private void txtMasked_Minute_TextChanged(object sender, EventArgs e)
        {
            //Validate user input
            if (!int.TryParse(txtMasked_Minute.Text, out inputMinutes))
            {
                MessageBox.Show("Please enter a valid number for Minutes!");
            }
        }

        private void txtMasked_Seconds_TextChanged(object sender, EventArgs e)
        {
            //Validate user input
            if (!int.TryParse(txtMasked_Seconds.Text, out inputSeconds))
            {
                MessageBox.Show("Please enter a valid number for Seconds!");
            }
        }
    }
}
