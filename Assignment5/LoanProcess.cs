using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{ 
 class LoanProcess
 {
    string Err;
    int LoanNumber;
    string CustomerName;
    internal int LoanAmount;
    float EMI_Amount;
    internal int AccountBalance;
    internal LoanProcess(int LoanNumber, string CustomerName, int LoanAmount, int AccountBalance)
    {
        this.LoanNumber = LoanNumber;
        this.LoanAmount = LoanAmount;
        this.CustomerName = CustomerName;
        this.AccountBalance = AccountBalance;
    }
    internal float Calculate_EMI(int LoanAmount, float ROI, int time)
    {
        float r = (ROI / (12 * 100));
        int t = time * 12;
        EMI_Amount = (LoanAmount * r * (float)Math.Pow(1 + r, t)) / (float)(Math.Pow(1 + r, t) - 1);
        return EMI_Amount;
    }
    public void CheckBalance(int AccountBalance, float EMI_Amount)
    {
        try
        {
            if (AccountBalance < EMI_Amount)
            {
                    Console.WriteLine ("Not Sufficient Balance to Repay the Loan");
            }
             else
             {
                    throw new Exception("EMI Paid");
             }

        }
        catch (Exception ex)
        {
                Err = ex.Message;
            Console.WriteLine(ex.Message);
        }
        finally
        {
                if(Err !=null)
                {
                    Console.WriteLine("Not Sufficient Balance to Repay the Loan");
                }
                else
                {
                    Console.WriteLine("Sufficient Balance");
                }
        }
    }
 }
  class Loan
  {
    static void Main()
    {
        LoanProcess loanProcess = new LoanProcess(123456, "Harika", 45000, 7570);
        float EMI = loanProcess.Calculate_EMI(loanProcess.LoanAmount, 13, 3);
        loanProcess.CheckBalance(loanProcess.AccountBalance, EMI);
        Console.Read();
    }
  }
}
