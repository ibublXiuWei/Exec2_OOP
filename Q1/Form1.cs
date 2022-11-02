using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			guesstextBox.Text = string.Empty;
			resulttextBox.Text = string.Empty;
		}

		private void Confirmbutton_Click(object sender, EventArgs e)
		{
			string guess = guesstextBox.Text;
			string fourA;
			int[] guessanswer = GetAnswer();
			int[] arrayrandom = Getrandom();
			
			
			int A=GetCheck(guess, guessanswer, arrayrandom);
		
			int answer = transfer(arrayrandom);
			Guess(A,answer);
			fourA = Convert.ToString(answer);
			
		}

		private int[] GetAnswer()
		{//回傳輸入的整數陣列
			string tryguess = guesstextBox.Text;
			int.TryParse(tryguess, out int intguess);// to do
			string[] test = tryguess.Split();
			int[] guessAB = test.Select(int.Parse).ToArray();
			return guessAB;
		}

		public int[] Getrandom()
		{
			//int[] putguess=new int[9];
			//要設計一個隨機變數 四位數 的陣列
			int[] RandomArray = new int[4];
			int seed = Guid.NewGuid().GetHashCode();
			Random rdm=new Random(seed);
			for (int i = 0; i < 4; i++)
			{
				RandomArray[i] = rdm.Next(1, 10);
			}
			return RandomArray;
		}
		public static int transfer(int[] RandomArray)
		{
			int answer = transfer(RandomArray);
			String str = "";
			for (int i = 0; i < RandomArray.Length; i++)
			{
				String s;
				int z = RandomArray[i];
				s = Convert.ToString(z);
				str = s;
			}
			int.TryParse(str, out answer);
			return answer;
			
		}
		public string Hint
		{
			get
			{
				return $"{guesstextBox.Text}->{resulttextBox.Text}";
			}
		}

		public int GetCheck(string guess, int[] guessAB, int[] RandomArray)
		{
			//check is string or in the range 
			bool isInt = int.TryParse(guess, out int number);
			if (!isInt)
			{
				MessageBox.Show("請輸入整數");
			}
			int A = new int();//用變數A計算正確的數字與位置
			int B = new int();
			//設定亂數陣列儲存答案
			for (int i = 0; i < 4; i++)
			{
				if (guessAB[i] == RandomArray[i])
				{
					A += 1;
				}
				for (int k = 0; k < 4; k++)
				{
					if (guessAB[i] == RandomArray[k])
					{
						B += 1;
					}
				}
				//resulttextBox.Text = $"{guess}->{A}A{B}B";
			}
			resulttextBox.Text = $"{guess}->{A}A{B}B";
			return A;
		}
		public Getresult Guess(int A,int answer)
		{//判斷對錯
			if (A == 4)
			{
				MessageBox.Show("您答對了!");
				return Getresult.Success();
				resulttextBox.Text = $"{answer}->4A";
			}
			else return Getresult.Failed(Hint);
		}
	}

	public class Getresult
	{
		public static Getresult Success()
		{
			return new Getresult { IsSuccess = true, Hint = string.Empty };
		}
		public static Getresult Failed(string errMessage)
		{
			return new Getresult { IsSuccess = false, Hint = errMessage };
		}
		public bool IsSuccess { get; set; }
		public bool IsFaided => !IsSuccess;
		public string Hint { get; set; }
	}
}
