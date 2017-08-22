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

namespace Movie_Ticketing.Forms
{
    public partial class FrChooseTicket : Form
    {
        public FrChooseTicket(int Studio, int TicketCount, string Time, string FilmTitle, FrChooseMovie frmovie)
        {
            InitializeComponent();
            this.FilmTitle = FilmTitle;
            this.Time = Time;
            this.Studio = Studio;
            this.frmovie = frmovie;
            this.TicketCount = TicketCount;
        }

        private string FilmTitle;
        private int Studio;
        private int TicketCount;
        private int TotalCount;
        private string Time;
        private FrChooseMovie frmovie;
        private string[] Prefixes = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K" };
        private List<bool> ChairBool = new List<bool>();

        private int GetChairIndex(Button btn)
        {
            return MainPnl.Controls.IndexOf(btn);
        }

        private void GetChair()
        {
            using (SampleDataContext db = new SampleDataContext())
            {
                mstudio studio = db.mstudios.Where(s => s.studiono == Studio)
                    .FirstOrDefault();
                int Col = (int)studio.column;
                int ChairPerRow = (int)(Col * studio.group);
                int Row = (int)studio.row;
                int Total = 0;
                for (int i = 0; i < Row; i++)
                {
                    for (int j = 0; j < ChairPerRow; j++)
                    {
                        Total += 1;
                        Button btn = new Button()
                        {
                            FlatStyle = FlatStyle.Flat,
                            BackColor = Color.White,
                            Text = Prefixes[i] + (j + 1).ToString(),
                            Size = new Size(60, 30),
                            Margin = new Padding(2),
                            Name = "btn" + Total.ToString("D3") 
                        };
                        MainPnl.Controls.Add(btn);
                        if (j == ChairPerRow-1) MainPnl.SetFlowBreak(btn, true);
                        else if ((j != 0) && (j % Col == 0)) btn.Margin = new Padding(20, 2, 2, 2);
                    }
                }
                foreach (Control c in MainPnl.Controls)
                {
                    bool BtnOnOf = false;
                    ChairBool.Add(BtnOnOf);
                    ((Button)c).Click += new EventHandler(Btn_Click);
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if(TicketCount != 0)
            {
                if (ChairBool[GetChairIndex((Button)sender)] == false)
                {
                    ((Button)sender).BackColor = Color.Yellow;
                    TicketCount -= 1;
                    TotalCount += 1;
                    LblTicket.Text = "Remaining Order Ticket: " + TicketCount;
                    ChairBool[GetChairIndex((Button)sender)] = true;
                }
                else if(ChairBool[GetChairIndex((Button)sender)] == true)
                {
                    ((Button)sender).BackColor = Color.White;
                    TicketCount += 1;
                    TotalCount -= 1;
                    LblTicket.Text = "Remaining Order Ticket: " + TicketCount;
                    ChairBool[GetChairIndex((Button)sender)] = false;
                }
            }
        }

        private void InitialState()
        {
            LblStudio.Text = "Studio " + Studio;
            LblTime.Text = Time;
            LblTitle.Text = FilmTitle;
            LblTicket.Text = "Remaining Order Ticket: " + TicketCount;
            GetChair();
        }

        private void FrChooseTicket_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                InitialState();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                frmovie.Show();
            }      
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            frmovie.Show();
            this.Close();
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            if(TicketCount != 0)
            {
                MessageBox.Show("There is remaining order ticket", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else
            {
                MessageBox.Show("Total Price: " + TotalCount * 50000, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
