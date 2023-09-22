//github.com/muratcetinkaya
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using RI_OperatorCommands;

namespace WindowsFormsApp4
{

    


    public partial class Form1 : Form
    {
        private Commands commands;

        public Form1()
        {
            InitializeComponent();
            commands = new Commands();

        }





        private void Form1_Load(object sender, EventArgs e)
        {

          
        }
        private void button1_Click(object sender, EventArgs e)
        {
           int myDO = Convert.ToInt16(DOval.Text);

            bool result = commands.SetDO(myDO, 1);

        
        

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool result = commands.ConnectTo(RobotIP.Text, 1, 100); 
            if (result)
            {
                label1.Text = "connected";
            }
            else
            {
                label1.Text = "disconnected";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
          commands.DisconnectRobot();            
          label1.Text = "disconnected";
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] intValues = new int[1];
            float[] sngValues = new float[1];


            int Register=0;
            Register = Convert.ToInt16(textBox2.Text);

            if ((float.Parse(textBox1.Text) % 1) == 0)
            {
                intValues[0] = Convert.ToInt32(textBox1.Text);
                bool res = commands.WriteReg_int(Register, intValues, 1);
                if (res)

                {

                    label2.Text = "REG WRITE SUCCESFUL";

                }
                else
                {
                    label2.Text = "REG WRITE FAULT";


                }
            }
            else
            {
                sngValues[0] = float.Parse(textBox1.Text);
                bool res = commands.WriteReg_float(Register, sngValues, 1);
                if (res)

                {

                    label2.Text = "succesful";

                }
                else
                {
                    label2.Text = "not ssuccesful";


                }
            }



            string commentval = textBox3.Text;
            Register = Convert.ToInt16(textBox2.Text);


            bool sendcomment = commands.WriteReg_Comment(Register, commentval);

            if (sendcomment)
            {
                label6.Text = "REG WRITE SUCCESFUL";

            }
            else
            {
                label6.Text = "REG WRITE FAULT";

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            float[] jointvals = new float[7];
            int PRno = 0;
            short uframeno, utoolno;
            uframeno = short.Parse(textBox12.Text);
            utoolno = short.Parse(textBox11.Text);


            PRno = Convert.ToInt16(textBox10.Text);

            jointvals[0] = float.Parse(textBox4.Text);
            jointvals[1] = float.Parse(textBox5.Text);
            jointvals[2] = float.Parse(textBox6.Text);
            jointvals[3] = float.Parse(textBox7.Text);
            jointvals[4] = float.Parse(textBox8.Text);
            jointvals[5] = float.Parse(textBox9.Text);
            jointvals[6] = float.Parse(textBox13.Text);


            bool result = commands.WriteJointPos(PRno,jointvals,uframeno,utoolno);

            if(result)
            {
                label16.Text = "JPOS WRITE SUCCESFUL";
            }

            else
            {

                label16.Text = "JPOS WRITE FAULT";

            }


        }


        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReadDO_Click(object sender, EventArgs e)
        {
            
            int Count = 100; 
Array result = new short[Count];

for (int DO = 1; DO <= Count; DO++)
{
    if (commands.ReadDO(DO, ref result, 1))
    {
                 
                    txtResult.Text = txtResult.Text + $"DO{DO} val: {result.GetValue(0)}{Environment.NewLine}";
                }
                else
                {
                    txtResult.Text = $"DO{DO}  read fault!";
        
                }
}

        }

        private void ReadReg_Click(object sender, EventArgs e)
        {

              for (int i = 1; i <= 100; i++)
    {
        object result = null;
    
        bool success = commands.ReadReg(i, ref result); 
    
        if (success)
        {
            txtResult.AppendText($"R{i} Val: {result}{Environment.NewLine}");
        }
        else
        {
                    txtResult.AppendText($"R{i} Okuma Başarısız.\n");
        }
    }

        }

        private void ReadDI_Click(object sender, EventArgs e)
        {
            int Count = 100; 
            Array result = new short[Count];
            for (int DI = 1; DI <= Count; DI++)
            {
                if (commands.ReadDI(DI, ref result, 1))
                {
                  
                    txtResult.Text = txtResult.Text + $"DI{DI} val: {result.GetValue(0)}{Environment.NewLine}";
                }
                else
                {
                    txtResult.Text = $"DI{DI} read fault!";
                   

                }


            }
        }

        private void ReadJPOS_Click(object sender, EventArgs e)
        {
            int PRValue = Convert.ToInt16(textBox10.Text); 

            float[] result = new float[9]; 

            bool success = commands.ReadPRJoint(PRValue, ref result);

            if (success)
            {
                txtResult.Text = string.Join(Environment.NewLine, result.Select((value, index) => $"J[{index+1}]: {value}"));
            }
            else
            {
                txtResult.Text = "read fault";
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReadCPOS_Click(object sender, EventArgs e)
        {
            int PRValue = Convert.ToInt16(textBox10.Text);

            float[] result = new float[6]; 

            bool success = commands.ReadPRCart(PRValue, ref result);

            if (success)
            {
                txtResult.Text = $"X: {result[0]}{Environment.NewLine}" +
                                 $"Y: {result[1]}{Environment.NewLine}" +
                                 $"Z: {result[2]}{Environment.NewLine}" +
                                 $"W: {result[3]}{Environment.NewLine}" +
                                 $"P: {result[4]}{Environment.NewLine}" +
                                 $"R: {result[5]}";
            }
            else
            {
                txtResult.Text = "Okuma Başarısız.";
            }




        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
   
        private void ReadActualPos_Click(object sender, EventArgs e)
        {
            Array xyzwpr = new float[6]; 

            bool success = commands.ReadActualPos(ref xyzwpr);

            if (success)
            {
                txtResult.Text = $"X: {xyzwpr.GetValue(0)}{Environment.NewLine}" +
                                 $"Y: {xyzwpr.GetValue(1)}{Environment.NewLine}" +
                                 $"Z: {xyzwpr.GetValue(2)}{Environment.NewLine}" +
                                 $"W: {xyzwpr.GetValue(3)}{Environment.NewLine}" +
                                 $"P: {xyzwpr.GetValue(4)}{Environment.NewLine}" +
                                 $"R: {xyzwpr.GetValue(5)}{Environment.NewLine}";
                               
            }
            else
            {
                txtResult.Text = "read fault.";
            }
        }

        private void WriteCartPos_Click(object sender, EventArgs e)
        {
            int PRValue = Convert.ToInt16(textBox10.Text);

            float XValue = float.Parse(textBox4.Text); 
            float YValue = float.Parse(textBox5.Text); 
            float ZValue = float.Parse(textBox6.Text); 
            float WValue = float.Parse(textBox7.Text); 
            float PValue = float.Parse(textBox8.Text); 
            float RValue = float.Parse(textBox9.Text); 
            float E1Value = float.Parse(textBox13.Text); 
            float E2Value = 0; 
            float E3Value = 0; 
            short C1Value = 0; 
            short C2Value = 0; 
            short C3Value = 2; 
            short C4Value = 2; 
            short C5Value = 5; 
            short C6Value = 5; 
            short C7Value = 5; 
            short UFValue = short.Parse(textBox12.Text); 
            short UTValue = short.Parse(textBox11.Text); 

            bool success = commands.WriteCartPOS(PRValue, XValue, YValue, ZValue, WValue, PValue, RValue, E1Value, E2Value, E3Value,
                C1Value, C2Value, C3Value, C4Value, C5Value, C6Value, C7Value, UFValue, UTValue);

            if (success)
            {
                MessageBox.Show("CartPOS write succesfull.");
            }
            else
            {
                MessageBox.Show("CartPOS write fault.");
            }
        }

        private void RobotIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void DO_OFF_Click(object sender, EventArgs e)
        {
            int myDO = Convert.ToInt16(DOval.Text);

            bool result = commands.SetDO(myDO, 0);
        }
    }







}
