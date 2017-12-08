using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CourseSelect
{
    public partial class FormCourse : Form
    {
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\晓枫\Documents\c#项目3\c#项目\CourseSelect.mdb";
        public FormCourse()
        {
            InitializeComponent();
        }

        private void FormCourse_Load(object sender, EventArgs e)
        {
            /*Query("select * from course");*/
            string strSql = "select * from Course";
            DataTable dt = DBHelper.GetTable(strSql);
            dataGridViewCourse.DataSource = dt;
        }

     

        private void Query(string strSql)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = connectionString;
            OleDbDataAdapter ad = new OleDbDataAdapter(strSql, conn);
            DataTable tb = new DataTable();
            conn.Open();
            ad.Fill(tb);
            conn.Close();
            dataGridViewCourse.DataSource = tb;
        }

        private void dataGridViewCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            if (textBoxIdQ.Text.Trim() == string.Empty)
            {
                MessageBox.Show("您尚未输入课程号，请先输入课程号！", "提醒", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxIdQ.Focus();
                textBoxIdQ.Clear();
                return;
            }
            string strSql = string.Format(
                "select * from course where courseId = '{0}'", textBoxIdQ.Text);
            MessageBox.Show(strSql);
            Query(strSql);
        }

        private void buttonBrow_Click(object sender, EventArgs e)
        {
            Query("select * from course");
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\晓枫\Documents\c#项目3\c#项目\CourseSelect.mdb";
            OleDbConnection conn = new OleDbConnection(connectionString);
            conn.Open();
            //
            if (textBoxId.Text == string.Empty)
            {
                MessageBox.Show("请输入课程号");
                textBoxId.Focus();
                return;
            }
            //
            string courseId = textBoxId.Text.Trim();
            string courseName = textBoxName.Text.Trim();
            int courseCredit = Convert.ToInt32(textBoxCredit.Text.Trim());
            //
            string strSql2 = string.Format("select * from course where courseId='{0}'", courseId);
            OleDbCommand cmd2 = new OleDbCommand(strSql2, conn);
            OleDbDataReader dr = cmd2.ExecuteReader();
            if (dr.HasRows)
            {
                MessageBox.Show("此课程号已存在，请重新输入课程号 ！");
                textBoxId.Clear();
                textBoxId.Focus();
                return;

            }
            //
            string strSql = string.Format("insert into course values('{0}','{1}','{2}')", courseId, courseName, courseCredit);
            OleDbCommand cmd = new OleDbCommand(strSql, conn);
            if (cmd.ExecuteNonQuery()>0)
            {
                MessageBox.Show("课程添加成功 ！");
                //
                string strSql3 = "select *from course";
                OleDbDataAdapter da = new OleDbDataAdapter(strSql3, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewCourse.DataSource = ds.Tables[0];
            }
            else MessageBox.Show("课程添加失败 ！");
            conn.Close();

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxId.Clear();
            textBoxName.Clear();
            textBoxCredit.Clear();
            textBoxId.Focus();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\晓枫\Documents\c#项目3\c#项目\CourseSelect.mdb";
            OleDbConnection conn = new OleDbConnection(connectionString);
            conn.Open();
            //
            if (TextBoxIdD.Text == string.Empty)
            {
                MessageBox.Show("请输入课程号 ！");
                TextBoxIdD.Focus();
                return;
            }
            //
            string courseId = TextBoxIdD.Text.Trim();
            //
            string strSql2 = string.Format("select * from course where courseId='{0}'", courseId);
            OleDbCommand cmd2 = new OleDbCommand(strSql2, conn);
            OleDbDataReader dr = cmd2.ExecuteReader();
            if (dr.HasRows)
            {
                string strSql3 = string.Format("delete from Course where courseId ='{0}'", courseId);
                OleDbCommand cmd3 = new OleDbCommand(strSql3, conn);
                if (cmd3.ExecuteNonQuery()>0) {
                    MessageBox.Show("课程删除成功 ！");
                string strSql4 ="select * from  course";
                    OleDbDataAdapter da1=new OleDbDataAdapter(strSql4,conn);
                    DataSet ds1=new DataSet();
                    da1.Fill(ds1);
                    dataGridViewCourse.DataSource=ds1.Tables[0];
                }


                /*MessageBox.Show("此课程号已存在，请重新输入课程号 ！");
                textBoxId.Clear();
                textBoxId.Focus();
                return;*/

            }
            else {
                MessageBox.Show("此课程号不存在，请重新输入课程号 ！");
            }
        }
    }
}
