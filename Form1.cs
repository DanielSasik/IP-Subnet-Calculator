using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siete_U2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonA.Checked = true;
            textBoxIPAddress.Text = "192.168.0.1";
            textBoxFirstOctetRange.Text = "192 - 223";
            functionHexIPAdress();
            for (int i = 0; i < 7; i++)
            {
                functionAddItems(i, 8, 16);
            }

            int counter = 0;
            for (int i = 0; i < 23; i++)
            {
                if (i == 16)
                    counter = 0;

                if (16 <= i && i < 23)
                {
                    int ipIndex4 = (int)(255 - (Math.Pow(2, 8 - counter) - 1));
                    comboBoxSubnetMask.Items.Add("255.255.255." + ipIndex4);
                    counter++;
                }
            }
        }

        private void functionAddItems(int i, int var, int addedVal)
        {

            comboBoxSubnetBits.Items.Add(i);
            comboBoxMaximumSubnets.Items.Add(Math.Pow(2, i));
            comboBoxMaskBits.Items.Add(8 + i + addedVal);
            comboBoxHostsperSubnet.Items.Add(Math.Pow((2), var - i) - 2);

        }

        private void functionRemoveItems(int i, int var)
        {

            comboBoxSubnetBits.Items.Remove(i);
            comboBoxMaximumSubnets.Items.Remove(Math.Pow(2, i));
            comboBoxMaskBits.Items.Remove(8 + i);
            comboBoxHostsperSubnet.Items.Remove(Math.Pow((2), var - i) - 2);

            int counter = 0;
            for (int a = 0; a < 23; a++)
            {
                if (a < 8)
                {
                    int ipIndex2 = (int)(255 - (Math.Pow(2, 8 - counter) - 1));
                    comboBoxSubnetMask.Items.Remove("255." + ipIndex2 + ".0.0");
                    counter++;
                }
                if (a == 8)
                    counter = 0;

                if (8 <= a && a < 16)
                {
                    int ipIndex3 = (int)(255 - (Math.Pow(2, 8 - counter) - 1));
                    comboBoxSubnetMask.Items.Remove("255.255." + ipIndex3 + ".0");
                    counter++;
                }
                if (a == 16)
                    counter = 0;

                if (16 <= a && a < 23)
                {
                    int ipIndex4 = (int)(255 - (Math.Pow(2, 8 - counter) - 1));
                    comboBoxSubnetMask.Items.Remove("255.255.255." + ipIndex4);
                    counter++;
                }
            }

        }

        private void functionHexIPAdress()
        {
            string hex = "";
            textBoxHexIPAddress.Text = "";
            for (int i = 0; i < 4; i++)
            {
                hex = Convert.ToString(Int32.Parse(textBoxIPAddress.Text.Split('.')[i]), 16);

                if (i < 3)
                    textBoxHexIPAddress.Text += hex.ToUpper() + ".";
                else
                    textBoxHexIPAddress.Text += hex.ToUpper(); ;
            }
        }

        private void functionWildcardMask()
        {
        }

        private void functionAddStuffidk()
        {
            textBoxSubnetID.Text = "";
            textBoxBroadcastAddress.Text = "";

            int[] mask = { 0, 0, 0, 0 };
            int[] ip = { 0, 0, 0, 0 };
            int[] subNet = { 0, 0, 0, 0 };
            int[] broadAdd = { 0, 0, 0, 0 };

            for (int i = 0; i < 4; i++)
            {
                mask[i] = Int32.Parse(comboBoxSubnetMask.Text.Split('.')[i]);
                ip[i] = Int32.Parse(textBoxIPAddress.Text.Split('.')[i]);


                if (mask[i] == 255)
                {
                    subNet[i] = ip[i];
                    broadAdd[i] = ip[i];
                }
                if (mask[i] == 0)
                {
                    subNet[i] = 0;
                    broadAdd[i] = 255;
                }
                if (mask[i] != 0 && mask[i] != 255)
                {
                    int magicNum = 256 - mask[i];
                    int resultMagicNum = 0;
                    int backup = 0;
                    for (int counter = 0; resultMagicNum <= ip[i]; counter++)
                    {
                        //resultMagicNum < ip[i]
                        resultMagicNum = magicNum * counter;
                        subNet[i] = resultMagicNum;
                        broadAdd[i] = resultMagicNum - 1;
                        //10.4.77.99
                        //192.168.2.33
                        if (resultMagicNum > ip[i])
                        {
                            backup = magicNum * (counter - 1);
                            subNet[i] = backup;
                        }
                    }
                }

                if (i < 3)
                {
                    textBoxSubnetID.Text += subNet[i] + ".";
                    textBoxBroadcastAddress.Text += broadAdd[i] + ".";
                }
                if (i == 3)
                {
                    textBoxSubnetID.Text += subNet[i];
                    textBoxBroadcastAddress.Text += broadAdd[i];
                }
            }
            textBoxHostAddressRange.Text = subNet[0] + "." + subNet[1] + "." + subNet[2] + "." + (subNet[3] + 1) + " - " + broadAdd[0] + "." + broadAdd[1] + "." + broadAdd[2] + "." + (broadAdd[3] - 1);
            string creativeVal1 = Convert.ToString(mask[1], 2);
            string creativeVal2 = Convert.ToString(mask[2], 2);
            string creativeVal3 = Convert.ToString(mask[3], 2);
            //Int32.Parse(comboBoxSubnetMask.Text),

            string Valc1 = "";
            string Valc2 = "";
            string Valc3 = "";

            if (mask[1] == 0)
            {
                creativeVal1 = "00000000";
            }

            if (mask[2] == 0)
            {
                creativeVal2 = "00000000";
            }
            
            if (mask[3] == 0)
            {
                creativeVal3 = "00000000";
            }

            for(int i = 0; i<8; i++)
            {
                if (creativeVal1[i] == '0')
                {
                    Valc1 += "h";
                }else if(creativeVal1[i] == '1')
                {
                    Valc1 += "s";
                }

                if (creativeVal2[i] == '0')
                {
                    Valc2 += "h";
                }
                else if (creativeVal2[i] == '1')
                {
                    Valc2 += "s";
                }

                if (creativeVal3[i] == '0')
                {
                    Valc3 += "h";
                }
                else if (creativeVal3[i] == '1')
                {
                    Valc3 += "s";
                }
            }

            if (radioButtonA.Checked == true)
            {
                textBoxSubnetBitmap.Text = "0nnnnnnn." + Valc1 + "." + Valc2 + "." + Valc3;
            }

            if (radioButtonB.Checked == true)
            {
                textBoxSubnetBitmap.Text = "10nnnnnn.nnnnnnnn." + Valc2 + "." + Valc3;
            }

            if (radioButtonC.Checked == true)
            {
                textBoxSubnetBitmap.Text = "110nnnnn.nnnnnnnn.nnnnnnnn." + Valc3;
            }

        }

        private void radioButtonA_Click(object sender, EventArgs e)
        {
            if (radioButtonA.Checked == false)
            {
                for (int i = 0; i < 24; i++)
                {
                    functionRemoveItems(i, 24);


                }
            }

            if (radioButtonA.Checked == true)
            {
                textBoxFirstOctetRange.Text = "1 - 126";
                textBoxIPAddress.Text = "10.0.0.1";
                functionHexIPAdress();
                for (int i = 0; i < 23; i++)
                {
                    functionRemoveItems(i, 24);
                    functionAddItems(i, 24, 0);

                }

                
                int counter = 0;
                for (int i = 0; i < 23; i++)
                {
                    if (i < 8)
                    {
                        int ipIndex2 = (int)(255 - (Math.Pow(2, 8 - counter) - 1));
                        comboBoxSubnetMask.Items.Add("255." + ipIndex2 + ".0.0");
                        counter++;
                    }
                    if (i == 8)
                        counter = 0;

                    if (8 <= i && i < 16)
                    {
                        int ipIndex3 = (int)(255 - (Math.Pow(2, 8 - counter) - 1));
                        comboBoxSubnetMask.Items.Add("255.255." + ipIndex3 + ".0");
                        counter++;
                    }
                    if (i == 16)
                        counter = 0;

                    if (16 <= i && i < 23)
                    {
                        int ipIndex4 = (int)(255 - (Math.Pow(2, 8 - counter) - 1));
                        comboBoxSubnetMask.Items.Add("255.255.255." + ipIndex4);
                        counter++;
                    }
                }
                comboBoxSubnetMask.SelectedIndex = 0;
            }

        }

        private void radioButtonB_Click(object sender, EventArgs e)
        {
            if (radioButtonA.Checked == false)
            {
                for (int i = 0; i < 23; i++)
                {
                    functionRemoveItems(i, 24);
                }
            }

            if (radioButtonB.Checked == true)
            {
                textBoxIPAddress.Text = "172.16.0.1";
                textBoxFirstOctetRange.Text = "128 - 191";
                functionHexIPAdress();
                for (int i = 0; i < 15; i++)
                {
                    functionAddItems(i, 16, 8);

                }

                int counter = 0;
                for (int i = 0; i < 23; i++)
                {

                    if (i == 8)
                        counter = 0;

                    if (8 <= i && i < 16)
                    {
                        int ipIndex3 = (int)(255 - (Math.Pow(2, 8 - counter) - 1));
                        comboBoxSubnetMask.Items.Add("255.255." + ipIndex3 + ".0");
                        counter++;
                    }
                    if (i == 16)
                        counter = 0;

                    if (16 <= i && i < 23)
                    {
                        int ipIndex4 = (int)(255 - (Math.Pow(2, 8 - counter) - 1));
                        comboBoxSubnetMask.Items.Add("255.255.255." + ipIndex4);
                        counter++;
                    }
                }
            }
            comboBoxSubnetMask.SelectedIndex = 0;
        }

        private void radioButtonC_Click(object sender, EventArgs e)
        {
            if (radioButtonA.Checked == false)
            {
                for (int i = 0; i < 23; i++)
                {
                    functionRemoveItems(i, 24);

                }
            }

            if (radioButtonC.Checked == true)
            {
                textBoxIPAddress.Text = "192.168.0.1";
                textBoxFirstOctetRange.Text = "192 - 223";
                functionHexIPAdress();
                for (int i = 0; i < 7; i++)
                {
                    functionAddItems(i, 8, 16);
                }

                int counter = 0;
                for (int i = 0; i < 23; i++)
                {
                    if (i == 16)
                        counter = 0;

                    if (16 <= i && i < 23)
                    {
                        int ipIndex4 = (int)(255 - (Math.Pow(2, 8 - counter) - 1));
                        comboBoxSubnetMask.Items.Add("255.255.255." + ipIndex4);
                        counter++;
                    }
                }
            }
            comboBoxSubnetMask.SelectedIndex = 0;
        }

        private void comboBoxSubnetMask_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMaximumSubnets.SelectedIndex = comboBoxSubnetMask.SelectedIndex;
            comboBoxMaskBits.SelectedIndex = comboBoxSubnetMask.SelectedIndex;
            comboBoxHostsperSubnet.SelectedIndex = comboBoxSubnetMask.SelectedIndex;
            comboBoxSubnetBits.SelectedIndex = comboBoxSubnetMask.SelectedIndex;
            
            int[] ipAddressVals = { 255, 255, 255, 255 };
            int[] wildMaskCor = { 0, 0, 0, 0 };
            int[] result = { 0, 0, 0, 0 };
            textBoxWildcardMask.Text = "";

            for (int i = 0; i < 4; i++)
            {
                wildMaskCor[i] = Int32.Parse(comboBoxSubnetMask.Text.Split('.')[i]);
                result[i] = ipAddressVals[i] - wildMaskCor[i];

                if (i < 3)
                {
                    textBoxWildcardMask.Text += result[i] + ".";
                }
                else
                {
                    textBoxWildcardMask.Text += result[i];

                }
            }
            functionAddStuffidk();
        }

        private void comboBoxSubnetBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMaximumSubnets.SelectedIndex = comboBoxSubnetBits.SelectedIndex;
            comboBoxMaskBits.SelectedIndex = comboBoxSubnetBits.SelectedIndex;
            comboBoxHostsperSubnet.SelectedIndex = comboBoxSubnetBits.SelectedIndex;
            comboBoxSubnetMask.SelectedIndex = comboBoxSubnetBits.SelectedIndex;
            functionAddStuffidk();
        }

        private void comboBoxMaximumSubnets_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSubnetBits.SelectedIndex = comboBoxMaximumSubnets.SelectedIndex;
            comboBoxMaskBits.SelectedIndex = comboBoxMaximumSubnets.SelectedIndex;
            comboBoxHostsperSubnet.SelectedIndex = comboBoxMaximumSubnets.SelectedIndex;
            comboBoxSubnetMask.SelectedIndex = comboBoxSubnetBits.SelectedIndex;
            functionAddStuffidk();
        }

        private void comboBoxMaskBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSubnetBits.SelectedIndex = comboBoxMaskBits.SelectedIndex;
            comboBoxMaximumSubnets.SelectedIndex = comboBoxMaskBits.SelectedIndex;
            comboBoxHostsperSubnet.SelectedIndex = comboBoxMaskBits.SelectedIndex;
            comboBoxSubnetMask.SelectedIndex = comboBoxSubnetBits.SelectedIndex;
            functionAddStuffidk();
        }

        private void comboBoxHostsperSubnet_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSubnetBits.SelectedIndex = comboBoxHostsperSubnet.SelectedIndex;
            comboBoxMaximumSubnets.SelectedIndex = comboBoxHostsperSubnet.SelectedIndex;
            comboBoxMaskBits.SelectedIndex = comboBoxHostsperSubnet.SelectedIndex;
            comboBoxSubnetMask.SelectedIndex = comboBoxSubnetBits.SelectedIndex;
            functionAddStuffidk();
        }

        private void textBoxIPAddress_KeyDown(object sender, KeyEventArgs e)
        {
            
            
            //string hex = "";
            string IPAdress = "";
            //textBoxHexIPAddress.Text = hex;
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string hex = "";
                    textBoxHexIPAddress.Text = hex;
                    for (int i = 0; i < 4; i++)
                    {
                        hex = Convert.ToString(Int32.Parse(textBoxIPAddress.Text.Split('.')[i]), 16);
                        IPAdress = textBoxIPAddress.Text.Split('.')[i];

                        if (Int32.Parse(IPAdress)>126 && radioButtonA.Checked== true && i == 0)
                        {
                            MessageBox.Show("Zle rozlysenie IP adresi");
                            return;
                        }

                        if (Int32.Parse(IPAdress) > 255 && radioButtonA.Checked == true)
                        {
                            MessageBox.Show("Zle rozlysenie IP adresi");
                            return;
                        }

                        if (Int32.Parse(IPAdress) > 191 && radioButtonB.Checked == true && i == 0)
                        {
                            MessageBox.Show("Zle rozlysenie IP adresi");
                            return;
                        }

                        if (Int32.Parse(IPAdress) > 255 && radioButtonB.Checked == true)
                        {
                            MessageBox.Show("Zle rozlysenie IP adresi");
                            return;
                        }

                        if (Int32.Parse(IPAdress) > 223 && radioButtonC.Checked == true && i == 0)
                        {
                            MessageBox.Show("Zle rozlysenie IP adresi");
                            return;
                        }

                        if (Int32.Parse(IPAdress) > 255 && radioButtonC.Checked == true)
                        {
                            MessageBox.Show("Zle rozlysenie IP adresi");
                            return;
                        }

                        if (i < 3)
                        {
                            textBoxHexIPAddress.Text += hex.ToUpper() + ".";
                            textBoxSubnetID.Text += IPAdress + ".";
                        }
                        else
                        {
                            textBoxHexIPAddress.Text += hex.ToUpper();

                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Zadajte dobry format ip adresi");
                    return;
                }
                functionAddStuffidk();

                // convert to sshhh stuff and its done 
                // also bugfix
                // also some additional stuff like loading values when B or C is checked and just stuff like this fix it

            }
        }

        private void textBoxIPAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.') //& e.KeyChar != '-'
            {
                e.Handled = true;
            }
        }
    }
}