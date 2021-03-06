﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Scoreboard
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Up_Left_One_Click(object sender, EventArgs e)
    {
      int a = Convert.ToInt32(Score_Left.Text);
      a = a + 1;
      Score_Left.Text = a.ToString();
    }

    private void Dn_Left_One_Click(object sender, EventArgs e)
    {
      int a = Convert.ToInt32(Score_Left.Text);
      if (a < 1)
        MessageBox.Show("점수는 0보다 작을수 없습니다.");
      else
      {
        a = a - 1;
        Score_Left.Text = a.ToString();
      }
    }

    private void Up_Left_Three_Click(object sender, EventArgs e)
    {
      int a = Convert.ToInt32(Score_Left.Text);
      a = a + 3;
      Score_Left.Text = a.ToString();
    }

    private void Dn_Left_Three_Click(object sender, EventArgs e)
    {
      int a = Convert.ToInt32(Score_Left.Text);
      if (a < 3)
        MessageBox.Show("점수는 0보다 작을수 없습니다.");
      else
      {
        a = a - 3;
        Score_Left.Text = a.ToString();
      }
    }

    private void Up_Right_One_Click(object sender, EventArgs e)
    {
      int a = Convert.ToInt32(Score_Right.Text);
      a = a + 1;
      Score_Right.Text = a.ToString();
    }

    private void Dn_Right_One_Click(object sender, EventArgs e)
    {
      int a = Convert.ToInt32(Score_Right.Text);
      if (a < 1)
        MessageBox.Show("점수는 0보다 작을수 없습니다.");
      else
      {
        a = a - 1;
        Score_Right.Text = a.ToString();
      }
    }

    private void Up_Right_Three_Click(object sender, EventArgs e)
    {
      int a = Convert.ToInt32(Score_Right.Text);
      a = a + 3;
      Score_Right.Text = a.ToString();
    }

    private void Dn_Right_Three_Click(object sender, EventArgs e)
    {
      int a = Convert.ToInt32(Score_Right.Text);
      if (a < 3)
        MessageBox.Show("점수는 0보다 작을수 없습니다.");
      else
      {
        a = a - 3;
        Score_Right.Text = a.ToString();
      }
    }

    private void Reset_Left_Click(object sender, EventArgs e)
    {
      int a = Convert.ToInt32(Score_Left.Text);
      a = 0;
      Score_Left.Text = a.ToString();
    }

    private void Reset_Right_Click(object sender, EventArgs e)
    {
      int a = Convert.ToInt32(Score_Right.Text);
      a = 0;
      Score_Right.Text = a.ToString();
    }
  }
}
