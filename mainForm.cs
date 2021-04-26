using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFC_Project
{
    // NFC Project (2021-04-26)
    // Version : 1.10v

    public partial class mainForm : Form
    {
        NFCReader NFC1 = new NFCReader(0); // Device 1
        NFCReader NFC2 = new NFCReader(1); // Device 2
        
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnGetUID1_Click(object sender, EventArgs e)
        {
            NFCReader.CardData card = new NFCReader.CardData();
            card = NFC1.readCardUID();

            if (card.cardResult != "")
                lblUID1.Text = "Card UID : " + card.cardResult;

            if (card.readerName != "")
                deviceBox1.Text = "Device 1 (" + card.readerName + ")";
        }

        private void btnGetUID2_Click(object sender, EventArgs e)
        {
            NFCReader.CardData card = new NFCReader.CardData();
            card = NFC2.readCardUID();

            if (card.cardResult != "")
                lblUID2.Text = "Card UID : " + card.cardResult;

            if (card.readerName != "")
                deviceBox2.Text = "Device 2 (" + card.readerName + ")";

        }

        private void btnRead1_Click(object sender, EventArgs e)
        {
            NFCReader.CardData card = new NFCReader.CardData();

            try
            {
                card = NFC1.readCardData(2, (int)cmbNFCType1.SelectedIndex);

                if (card.cardResult != "")
                    lblData1.Text = "Data : " + card.cardResult;
                if (card.readerName != "")
                    deviceBox1.Text = "Deivce 1 (" + card.readerName + ")";
            }
            catch(Exception)
            {
                deviceBox1.Text = "Device 1 (Device Not Found)";
            }
        }

        private void btnRead2_Click(object sender, EventArgs e)
        {
            NFCReader.CardData card = new NFCReader.CardData();

            try
            {
                card = NFC2.readCardData(2, (int)cmbNFCType1.SelectedIndex);

                if (card.cardResult != "")
                    lblData2.Text = "Data : " + card.cardResult;
                if (card.readerName != "")
                    deviceBox2.Text = "Deivce 2 (" + card.readerName + ")";
            }
            catch (Exception)
            {
                deviceBox2.Text = "Device 2 (Device Not Found)";
            }
        }

        private void btnWrite1_Click(object sender, EventArgs e)
        {
            NFCReader.CardData card = new NFCReader.CardData();
            int block = 0;

            try
            {
                block = int.Parse(txtBlock1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Block is null", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (block == 0)
            {
                MessageBox.Show("UUID blocks are not accessible", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (block % 3 == 0 || block % 4 == 0)
            {
                MessageBox.Show("Protected block.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool result = NFC1.writeCardData(int.Parse(txtBlock1.Text), txtInput1.Text, (int)cmbNFCType1.SelectedIndex);

            if (result)
                MessageBox.Show("Write Success!", "NFC Project");
            else
                MessageBox.Show("Write Fail!", "NFC Project");
        }

        private void btnWrite2_Click(object sender, EventArgs e)
        {
            NFCReader.CardData card = new NFCReader.CardData();
            int block = 0;

            try
            {
                block = int.Parse(txtBlock2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Block is null", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

                if (block == 0)
            {
                MessageBox.Show("UUID blocks are not accessible", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
             
            if (block % 3 == 0 || block % 4 == 0)
            {
                MessageBox.Show("Protected block.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool result = NFC2.writeCardData(int.Parse(txtBlock2.Text), txtInput2.Text, (int)cmbNFCType1.SelectedIndex);

            if (result)
                MessageBox.Show("Write Success!", "NFC Project");
            else
                MessageBox.Show("Write Fail!", "NFC Project");
        }


        private void txtBlock1_Click(object sender, EventArgs e)
        {
            txtBlock1.Text = "";
            txtBlock1.ForeColor = Color.Black;
            txtBlock1.Font = new Font(txtBlock1.Font, FontStyle.Regular);
        }

        private void txtBlock2_Click(object sender, EventArgs e)
        {
            txtBlock2.Text = "";
            txtBlock2.ForeColor = Color.Black;
            txtBlock2.Font = new Font(txtBlock1.Font, FontStyle.Regular);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            cmbNFCType1.Items.Add("Mifare S50 (ISO/IEC 14443A)");
            cmbNFCType1.Items.Add("Mifare Ultralight (ISO/IEC 14443A)");
            cmbNFCType1.SelectedIndex = 0;

            cmbNFCType2.Items.Add("Mifare S50 (ISO/IEC 14443A)");
            cmbNFCType2.Items.Add("Mifare Ultralight (ISO/IEC 14443A)");
            cmbNFCType2.SelectedIndex = 0;
        }
    }
}
