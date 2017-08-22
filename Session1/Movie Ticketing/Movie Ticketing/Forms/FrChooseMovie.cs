using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Movie_Ticketing.Database;
using Movie_Ticketing.Classes;
using System.Text.RegularExpressions;

namespace Movie_Ticketing.Forms
{
    public partial class FrChooseMovie : Form
    {
        public FrChooseMovie()
        {
            InitializeComponent();
        }

        #region Declaration
        private List<Schedule> Schedules;
        private string time = "";
        private string title = "";
        private int studio;
        #endregion

        #region Methods
        private List<Schedule> GetSchedules()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                List<Schedule> Schedules = new List<Schedule>();
                var List = from h in db.headerschedules
                           join m in db.mappings
                           on h.mappingid equals m.mappingid
                           join f in db.msfilms
                           on m.filmid equals f.filmid
                           select new
                           {
                               Studio = m.studiono,
                               Film = f.title,
                               Time = h.time
                           };
                foreach (var l in List)
                {
                    if(((DateTime)l.Time).Date <= DateTime.Now.Date)
                    {
                        Schedule schedule = Schedules.Where(s => s.StudioNo.Equals(l.Studio))
                            .FirstOrDefault();
                        if(schedule == null)
                        {
                            Schedules.Add(new Schedule()
                            {
                                StudioNo = (int)l.Studio,
                                FilmTitle = l.Film
                            });
                        }                
                    }
                }return Schedules;
            }
        }

        private void GetScheduleId()
        {

        }

        private void RefreshDGV()
        {
            DGVSchedule.Rows.Clear();
            Schedules = GetSchedules();
            foreach (Schedule s in Schedules)
            {
                DGVSchedule.Rows.Add(
                    s.StudioNo,
                    s.FilmTitle,
                    s.Times[0],
                    s.Times[1],
                    s.Times[2],
                    s.Times[3],
                    s.Times[4]);
            }
        }
        #endregion

        #region Events
        private void FrChooseMovie_Load(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void DGVSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVSchedule.Rows[e.RowIndex];
                Regex reg = new Regex("[\\d{2,2}:\\d{2,2}\\.]");
                string value = row.Cells[e.ColumnIndex].Value.ToString();
                if (reg.IsMatch(value))
                {
                    time = value;
                    title = row.Cells["Title"].Value.ToString();
                    studio = int.Parse(row.Cells["Studio"].Value.ToString());
                }
                else MessageBox.Show("Please Choose the time!");

            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            try
            {
                FrChooseTicket frticket = new FrChooseTicket(this.studio, int.Parse(TbxTicket.Text), this.time, this.title, this);
                frticket.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
