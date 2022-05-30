using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AssignmentWeek14
{
    public partial class FormTeam : Form
    {
        public FormTeam()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;

        DataTable dtTeam = new DataTable();
        DataTable dtTopScorer = new DataTable();
        DataTable dtWorstDiscipline = new DataTable();
        DataTable dtPertandingan = new DataTable();
        
        int posisiSekarang = 0;

        private void FormTeam_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT t.team_name, concat(m.manager_name, ' (', n.nation, ')') AS 'Manager', concat(t.home_stadium, ', ', t.city, ', ', t.capacity) AS 'Stadium' FROM manager m, team t, nationality n WHERE m.manager_id = t.manager_id AND m.nationality_id = n.nationality_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);

            sqlQuery = "SELECT concat(p.player_name, ' ', dt.jumlah_goal, ' ,', dt.jumlah_goal_penalty) AS 'Top Scorer' FROM player p, dt_type dt, team t WHERE t.team_name = '" + lblHasilTeamName.Text + "' AND p.player_id = dt.player_id AND t.team_id = p.team_id GROUP BY dt.jumlah_goal desc LIMIT 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTopScorer);

            sqlQuery = "SELECT concat(p.player_name, ' ,', dt.jumlah_kartu_kuning, ' Yellow Card',' and ', dt.jumlah_kartu_merah, ' Red Card') AS 'Worst Discipline' FROM player p, dt_type dt, team t WHERE t.team_name = '" + lblHasilTeamName.Text + "' AND p.player_id = dt.player_id AND t.team_id = p.team_id GROUP BY concat(dt.jumlah_kartu_kuning + dt.jumlah_kartu_merah) desc LIMIT 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtWorstDiscipline);

            sqlQuery = "SELECT match_date, team_home = 'B001' AS 'Home', team_away = 'B001' AS 'Away', concat(goal_home, ' - ', goal_away) AS 'Score' FROM `match` m GROUP BY match_date desc LIMIT 5;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPertandingan);

            TampilkanData(posisiSekarang);

        }

        private void TampilkanData(int posisi)
        {
            lblHasilTeamName.Text = dtTeam.Rows[posisi][0].ToString();
            lblHasilManager.Text = dtTeam.Rows[posisi][1].ToString();
            lblHasilStadium.Text = dtTeam.Rows[posisi][2].ToString();

            lblHasilTopScorer.Text = dtTopScorer.Rows[posisi][0].ToString();

            lblHasilWorstDiscipline.Text = dtWorstDiscipline.Rows[posisi][0].ToString();   

            //dgvPertandingan.Rows.Clear();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            TampilkanData(0);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (posisiSekarang > 0)
            {
                posisiSekarang--;
                TampilkanData(posisiSekarang);
            }
            else
            {
                MessageBox.Show("Data sudah data yang pertama!");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (posisiSekarang < dtTeam.Rows.Count - 1)
            {
                posisiSekarang++;
                TampilkanData(posisiSekarang);
            }
            else
            {
                MessageBox.Show("Data sudah data yang terakhir!");
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            TampilkanData(dtTeam.Rows.Count - 1);
        }

        private void dgvPertandingan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
