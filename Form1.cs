/* 
Name: Channel Caldwell
Program 1
Due Date: 02/13/2025
CIS 199 50
This prgram allows a user to input to see the final estimated cost of a cable instalation. There is also an option for a student discount that can be applied to the final cost.
 
 */

/*Answer to questions:
 * 1) A boolean could be used for the student discount by saying: bool doesStudentDiscountApply = studentDis == 1. If the value is true (the input number for student discount is 1) then the student discount will be applied and if it is not equal to 1 then there will be no student discount applied.
 * 2) The = sign is used to assign values while the == is used as a comparison operator to see if the two things eqaul each other.
 * 3) A char data type can only hold one character and must use single quotation marks. A string data type can hold a series of characters and the value is expressed within double quotation marks.
 * 4) Magic numbers make programs harder to read, understand, and maintain. If a magic number is used in the beginning it is hard to keep track of what it means or is later on.
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1Spring2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, welcome to my price quote calculator!");//message box that first appears
        }

        private void ClientNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalcBttn_Click(object sender, EventArgs e)
        {
            const int INSTALLATION_FEE = 100;//base installation fee
            const int HOURLY_RATE = 20;//hourly rate to install per employee
            const int RECEIVER_COST = 40;//how much each receiver cost
            const double DISCOUNT_RATE = .10;//discount rate for students is 10% off
            double hoursWorked;//how many hours it took to install
            int staffAssigned;//how many employees were assigned to install the receivers
            string clientName;//the client name input
            string location;//the city input
            double totalCost;//total cost either with discount or without
            int numReceiver;//how many receivers were needed
            double preDisCost;//total cost before possible discount 
            int studentDis;//user inputs 0 or 1
            


            hoursWorked = double.Parse(HoursWrkTxt.Text);//changes hours worked input to double
            staffAssigned = int.Parse(StaffAssignedTxt.Text);//changes staff input to int
            clientName = (ClientNameTxt.Text);
            location = (LocationTxt.Text);
            numReceiver = int.Parse(ReceiverTxt.Text);//changes number of receivers input to int
            studentDis = int.Parse(StuDiscountTxt.Text);//changes student discount input to int

            preDisCost= INSTALLATION_FEE + (HOURLY_RATE * hoursWorked * staffAssigned) + (numReceiver * RECEIVER_COST);//total cost without any discount

            totalCost = preDisCost - (DISCOUNT_RATE * preDisCost * studentDis);//total cost with possible discount
            OutputClientNameLbl.Text = clientName;
            OutputLocationLbl.Text = location;
            OutputTotalCostLbl.Text = $"{totalCost:C}";
                
            }

        private void ClearBttn_Click(object sender, EventArgs e)//used to clear the information to see a differnt total cost
        {
            ClientNameTxt.Clear();
            LocationTxt.Clear();
            HoursWrkTxt.Clear();
            StaffAssignedTxt.Clear();
            ReceiverTxt.Clear(); 
            StuDiscountTxt.Clear();

            OutputClientNameLbl.Text = "";
            OutputLocationLbl.Text = "";
            OutputTotalCostLbl.Text = "";


            ClientNameTxt.Focus();//allows curser to be put in the client name textbox

       }

       
    }
}
