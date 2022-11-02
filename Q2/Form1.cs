using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			countlabel.Text=String.Empty;
			dicetextBox.Text=String.Empty;
		}
		public void Confirmbutton_Click_1(object sender, EventArgs e)
		{
			int[] dim=GetDim();//隨機數字陣列
			int sum = new int();
			if (GetSame(dim) == true)
			{
				sum = GetOperation(dim);
				countlabel.Text=$"{sum}";
			}
			else
			{
				countlabel.Text = null;
			}
		}
		public int GetOperation(int[] dim)
		{
			int sum = new int();
			//若兩顆點數相同，取另外兩值相加2256-->11
			int same1 = 0;
			for (int i = 1; i < dim.Length; i++)
			{
				if (dim[0] == dim[i])
				{
					dim[0] = same1;
					dim[i] = same1;
					for (int k = 0; k < dim.Length; k++)
					{
						sum += dim[k];
					}
				}
			}
			for (int j = 2; j < dim.Length; j++)
			{
				if (dim[1] == dim[j])
				{
					dim[1] = same1;
					dim[j] = same1;
					for (int k = 0; k < dim.Length; k++)
					{
						sum += dim[k];

					}
				}
			}
			if (dim[2] == dim[3])
			{
				dim[2] = same1;
				dim[3] = same1;
				sum = dim[1] + dim[0];
			}
			return sum;
			//若三顆點數相同，加總same+other 2226->8
			int count = 0;
			//int[] temp = new int[4];
			for (int i = 1; i < dim.Length; i++)
			{
				if (dim[0] == dim[i])
				{
					count++;
					if (count == 2)
					{
						if (dim[0] != dim[i])
						{
							sum = dim[0] + dim[3];

							break;
						}
					}
				}
			}
			return sum;
			if (dim[1] == dim[2] || dim[1] == dim[3])
			{
				count++;
				if (count == 2)
				{
					sum = dim[0] + dim[2];

				}
			}
			return sum;
			if (dim[2] == dim[3])
			{
				count++;
				if (count == 3)
				{
					sum = dim[0] + dim[1];
					return sum;
				}
			}
			return sum;
			//若2244回傳較大的值相加-- > 8
			if (dim[0] == dim[1] && dim[2] == dim[3])
			{
				if (dim[0] > dim[2])
				{
					sum = dim[0] * 2;
				}
				else
				{
					sum = dim[2] * 2;
				}
			}
			if (dim[0] == dim[3] && dim[2] == dim[1])
			{
				if (dim[0] > dim[2])
				{
					sum = dim[0] * 2;
				}
				else
				{
					sum = dim[2] * 2;
				}
			}
			if (dim[0] == dim[2] && dim[3] == dim[1])
			{
				if (dim[0] > dim[3])
				{
					sum = dim[0] * 2;
				}
				else
				{
					sum = dim[3] * 2;
				}
			}
			return sum;

			//若四點相同回傳same+same 2222-->4
			if (dim[1] == dim[2] && dim[2] == dim[3] && dim[3] == dim[0] && dim[0] == dim[1])
			{
				sum = dim[0] * 2;
			}
			return sum;
		}

		public bool GetSame(int [] dim)
		{// 四顆點數要出現相同才可以運算
			bool istrue = true;
			for (int i = 1; i < dim.Length; i++)
			{
				if (dim[0] == dim[i])
				{
					dicetextBox.Text = $"{dim[0]},{dim[1]},{dim[2]},{dim[3]}";
					istrue = true;
					return istrue;
				}
			}
			for (int i = 2; i < dim.Length; i++)
			{
				if (dim[1] == dim[i] || dim[0] == dim[1])
				{
					dicetextBox.Text = $"{dim[0]},{dim[1]},{dim[2]},{dim[3]}";
					istrue = true;
					return istrue;
				}
			}
			if (dim[2] == dim[3])
			{
				dicetextBox.Text = $"{dim[0]},{dim[1]},{dim[2]},{dim[3]}";
				istrue = true;
			}
			else
			{
				MessageBox.Show("請重新擲骰子");
				istrue = false;
			}
			return istrue;
		}
		public static int[] GetDim()
		{
			int[] dim=new int[4];
			int[] getdim= new int[4];
			int seed = Guid.NewGuid().GetHashCode();
			Random random = new Random(seed);
			for (int i = 0; i < 4; i++)
			{
				getdim[i]=dim[i]= random.Next(1, 7);
			}
			return getdim;
		}

		private void resetbutton(object sender, EventArgs e)
		{
			dicetextBox.Text = null;
			countlabel.Text = null;

		}
	}
}