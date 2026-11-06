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
namespace WindowsFormsApp1

{
    public partial class lucky_cafe_project : Form
    {
        public lucky_cafe_project()
        {
            InitializeComponent();
        }

        private void calBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Please enter customer name");
                    return;
                }

                int quantity;

                if (!int.TryParse(txtQuantity.Text, out quantity))
                {
                    MessageBox.Show("String cannot be entered!");
                    return;
                }
                else if (quantity < 1)
                {
                    MessageBox.Show("Quantity must be at least 1");
                    return;
                }

                double price = 0;
                string Drink = "";

                if (radioButton1.Checked)
                {
                    price = 1;
                    Drink = "Tea";
                }
                else if (radioButton2.Checked)
                {
                    price = 2;
                    Drink = "Coffee";
                }
                else if (radioButton3.Checked)
                {
                    price = 3;
                    Drink = "Juice";
                }
                else
                {
                    MessageBox.Show("Please select a drink");
                    return;
                }

                Random random = new Random();

                OrderList.Items.Clear();

                bool lucky = false;
                int numlucky =0;
      

                for (int i = 1; i <= quantity; i++)
                {
                    int luckyNumber = random.Next(1, 51);



                    if (luckyNumber == 7 )
                    {
                        lucky = true;
                        numlucky = luckyNumber;
                        OrderList.Items.Add(i + ")" + txtName.Text+"-"+Drink+"-lucky"+luckyNumber+"-"+ price.ToString("c2"));


                    }
                    else if (luckyNumber == 17) {
                        lucky = true;
                        numlucky = luckyNumber;
                        OrderList.Items.Add(i + ")" + txtName.Text + "-" + Drink + "-lucky" + luckyNumber + "-" + price.ToString("c2"));

                    }
                    else
                    {
                        OrderList.Items.Add(i + ")" + txtName.Text + "-" + Drink + "-lucky" + luckyNumber + "-" + price.ToString("c2"));

                    }

                }

                double total = price * quantity;

                if (chkStudent.Checked)
                {
                    OrderList.Items.Add("\n \n");
                    OrderList.Items.Add("member discount 10%");
                    OrderList.Items.Add("Total before discount " + total.ToString("c2"));

                    total = total - (total * 0.10);

                    OrderList.Items.Add("Total after discount " + total.ToString("c2"));
                    lbTotal.Text ="total price"+ total.ToString("c2");
                    lbTotal.ForeColor = Color.Blue;


                }
                else {
                    OrderList.Items.Add("total is:" + total.ToString("c2"));
                    lbTotal.Text = "Total Price: " + total.ToString("c2");
                    lbTotal.ForeColor = Color.Blue;
                }
               

                if (lucky)
                {
                    OrderList.Items.Add("lucky message:You got a Free Cookie!"+"LUCKY("+numlucky+")");

                    lblLucky.Text = "lucky message:You got a Free Cookie!";
                    lblLucky.ForeColor = Color.IndianRed;
                }
                else
                {
                    OrderList.Items.Add("No prize this time.");
                    lblLucky.Text = "No prize this time.";
                    lblLucky.ForeColor = Color.IndianRed;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void loadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("orders.txt"))
                {
                    MessageBox.Show("No file found.");
                    return;
                }

                OrderList.Items.Clear();

                StreamReader loadFile = File.OpenText("orders.txt");

                while (!loadFile.EndOfStream)
                {

                    OrderList.Items.Add(loadFile.ReadLine());
                }

                loadFile.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading file: " + ex.Message);
            }
        }

        private void fileBtn_Click(object sender, EventArgs e)
        {
            if (OrderList.Items.Count == 0)
            {
                MessageBox.Show("No order to save.");
                return;
            }

            StreamWriter savingFile = File.AppendText("orders.txt");

            for (int i = 0; i < OrderList.Items.Count; i++)
            {
                savingFile.WriteLine(OrderList.Items[i].ToString());
            }

            savingFile.WriteLine("Total Price: " + lbTotal.Text);
            savingFile.WriteLine("Lucky Message: " + lblLucky.Text);
            savingFile.WriteLine("--------------------------------");

            savingFile.Close();

            MessageBox.Show("Order saved.");
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtName.Clear();

            txtQuantity.Clear();

            OrderList.Items.Clear();

            lbTotal.Text = "";

            lblLucky.Text = "";

            chkStudent.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }
    }
}
