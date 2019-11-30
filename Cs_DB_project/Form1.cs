using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cs_DB_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;
        string id = "", selected_id = "";
        int num = -1;

        private void Form1_Load(object sender, EventArgs e)
        {
            LogOut.Visible = false;
            MyBulletin.Visible = false;
            conn = new MySqlConnection("server=localhost;port=3306;database=hanbitmart;uid=root;pwd=nsw0311");

            dataAdapter = new MySqlDataAdapter("SELECT * FROM 게시글", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "게시글");
            Bulletin.DataSource = dataSet.Tables["게시글"];
        }

        private void Login_success()
        {
            LogOut.Visible = true;
            MyBulletin.Visible = true;

            LID.Visible = false;
            TBID.Visible = false;
            LPW.Visible = false;
            TBPW.Visible = false;
            LogIn.Visible = false;

            login_status.Text = id + " 님 환영합니다!";
        }
        

        private void LogIn_Click(object sender, EventArgs e)
        {
            string query = "select * from 회원 where 아이디='" + TBID.Text + "' and 비밀번호='" + TBPW.Text + "'";
            //dataAdapter.InsertCommand = new MySqlCommand(query, conn);
            

            try
            {
                conn.Open();
                // dataSet.Clear();
                MySqlDataReader reader = new MySqlCommand(query, conn).ExecuteReader();
                if (reader.Read())
                {
                    id = reader["아이디"].ToString();
                    selected_id = id;
                    Login_success();
                }
                else
                    MessageBox.Show("로그인 실패");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LogOut.Visible = false;
            MyBulletin.Visible = false;

            LID.Visible = true;
            TBID.Visible = true;
            LPW.Visible = true;
            TBPW.Visible = true;
            LogIn.Visible = true;

            id = "";
            login_status.Text = "로그인해야 이용할 수 있습니다.";
        }

        private void showall_Click(object sender, EventArgs e)
        {
            dataAdapter = new MySqlDataAdapter("SELECT * FROM 게시글", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "게시글");
            Bulletin.DataSource = dataSet.Tables["게시글"];
        }

        private void MyBulletin_Click(object sender, EventArgs e)
        {
            dataAdapter = new MySqlDataAdapter("SELECT * FROM 게시글 where 아이디=@id", conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@id", id);

            dataSet = new DataSet();

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "게시글") > 0)  // 검색된 데이터의 행 수 반환
                    Bulletin.DataSource = dataSet.Tables["게시글"];
                else
                    MessageBox.Show("아직 아무 글도 쓰지 않았네요!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("로그인해주세요!");
                return;
            }
            if (Title.Text == "")
            {
                MessageBox.Show("제목을 써주세요.");
                return;
            }
            if (Content.Text == "")
            {
                MessageBox.Show("내용을 써주세요.");
                return;
            }
            if (selected_id != id)
            {
                MessageBox.Show("자신의 게시글만 수정할 수 있습니다.");
                return;
            }

            string sql = "insert into 게시글 (아이디, 글제목, 작성일자, 글내용) values(@id, @title, @date, @content);";
            dataAdapter.InsertCommand = new MySqlCommand(sql, conn);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@id", id);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@title", Title.Text);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
            dataAdapter.InsertCommand.Parameters.AddWithValue("@content", Content.Text);

            try
            {
                conn.Open();

                if (dataAdapter.InsertCommand.ExecuteNonQuery() > 0) 
                {
                    dataSet.Clear();
                    dataAdapter.Fill(dataSet, "게시글");
                    Bulletin.DataSource = dataSet.Tables["게시글"];
                }
                else
                    MessageBox.Show("검색된 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("로그인해주세요!");
                return;
            }
            if (num == -1)
            {
                MessageBox.Show("게시글을 선택해주세요.");
                return;
            }


            num = -1;
        }

        private void Bulletin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            num = int.Parse(Bulletin.Rows[e.RowIndex].Cells[0].Value.ToString());
            Title.Text = Bulletin.Rows[e.RowIndex].Cells[2].Value.ToString();
            Content.Text = Bulletin.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
