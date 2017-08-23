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
        private string time = "", title = "";
        private int studio, scheduleid;
        private ErrorProvider Eprov = new ErrorProvider();
        #endregion

        #region Methods
        private void GetScheduleID(int Studio, string time)
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                var schedule = from hs in db.headerschedules
                               join m in db.mappings
                               on hs.mappingid equals m.mappingid
                               select new { studio = m.studiono, scheduleid = hs.scheduleid, time = hs.time };
                foreach (var l in schedule)
                {
                    if (l.studio == Studio && ((DateTime)l.time).ToString("hh:mm tt") == time) scheduleid = l.scheduleid;
                }
            }
        }
        
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

        private void RefreshDGV()
        {
            DGVSchedule.Rows.Clear();
            Schedules = GetSchedules();
            foreach (Schedule s in Schedules)
            {
                DGVSchedule.Rows.Add(
                    s.StudioNo,
                    s.FilmTitle,
                    s.ScheduleList[0].Time,
                    s.ScheduleList[1].Time,
                    s.ScheduleList[2].Time,
                    s.ScheduleList[3].Time,
                    s.ScheduleList[4].Time);
            };
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
                    GetScheduleID(studio, time);
                }
                else MessageBox.Show("Please Choose the time!");

            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(time))
                {
                    MessageBox.Show("Please Choose Time!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(TbxTicket.Text) || TbxTicket.Text == "0")
                {
                    MessageBox.Show("Wrong Input!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Eprov.SetError(TbxTicket, "Can't be null or Zero!");
                    return;
                }
                FrChooseTicket frticket = new FrChooseTicket(this.studio, this.scheduleid, int.Parse(TbxTicket.Text), this.time, this.title, this);
                frticket.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void TbxTicket_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[1-9][0-9]*");
            if (!(reg.IsMatch(TbxTicket.Text))) Eprov.SetError(TbxTicket, "Must be number and greater than zero!");
            else Eprov.SetError(TbxTicket, "");
        }
    }
}
