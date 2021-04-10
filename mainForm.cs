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
    // NFC Project (2021-04-09)
    // Version : 1.00v

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
                deviceBox1.Text = "Deivce 1 (" + card.readerName + ")";
        }

        private void btnGetUID2_Click(object sender, EventArgs e)
        {
            NFCReader.CardData card = new NFCReader.CardData();
            card = NFC2.readCardUID();

            if (card.cardResult != "")
                lblUID2.Text = "Card UID : " + card.cardResult;
            if (card.readerName != "")
                deviceBox2.Text = "Deivce 2 (" + card.readerName + ")";
        }

        private void btnRead1_Click(object sender, EventArgs e)
        {
            NFCReader.CardData card = new NFCReader.CardData();
            card = NFC1.readCardData(2);

            if (card.cardResult != "")
                lblData1.Text = "Data : " + card.cardResult;
            if (card.readerName != "")
                deviceBox1.Text = "Deivce 1 (" + card.readerName + ")";
        }

        private void btnRead2_Click(object sender, EventArgs e)
        {
            NFCReader.CardData card = new NFCReader.CardData();
            card = NFC2.readCardData(2);

            if (card.cardResult != "")
                lblData2.Text = "Data : " + card.cardResult;
            if (card.readerName != "")
                deviceBox2.Text = "Deivce 2 (" + card.readerName + ")";
        }

        private void btnWrite1_Click(object sender, EventArgs e)
        {
            NFCReader.CardData card = new NFCReader.CardData();
            bool result = NFC1.writeCardData(2, txtInput1.Text);

            if (result)
                MessageBox.Show("Write Success!", "NFC Project");
            else
                MessageBox.Show("Write Fail!", "NFC Project");
        }

        private void btnWrite2_Click(object sender, EventArgs e)
        {
            NFCReader.CardData card = new NFCReader.CardData();
            bool result = NFC2.writeCardData(2, txtInput2.Text);

            if (result)
                MessageBox.Show("Write Success!", "NFC Project");
            else
                MessageBox.Show("Write Fail!", "NFC Project");
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
