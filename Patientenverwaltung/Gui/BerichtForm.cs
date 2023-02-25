using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patientenverwaltung;
using System.Windows.Forms;
using Patientenverwaltung.Model;
using Patientenverwaltung.Datenbank;

namespace Patientenverwaltung.Gui
{
    public partial class BerichtOverviewForm : Form
    {
        private Controller controller;
        private List<Bericht> berichte;
        private static int rowCount = 0;
        private int selectedBerichtIndex;
        private int pageIndex = 0;
        private const int ROW_AMOUNT = 9;

        public BerichtOverviewForm(Controller controller)
        {
            InitializeComponent();
            this.controller= controller;
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                berichte = controller.getBerichteOfPatient();
                selectedBerichtIndex = -1;
                refreshBerichtTable();
            }
        }

        private void btn_BerichtHinzufuegen_Click(object sender, EventArgs e)
        {
            controller.berichtAddBericht();
        }

        private void btn_BerichtSuchen_Click(object sender, EventArgs e)
        {
            if (txt_BerichtSuche.Text == "")
            {
                displayBerichteOfList(berichte);
            }
            else
            {
                DateTime berichtDatum = Convert.ToDateTime(txt_BerichtSuche.Text);

                List<Bericht> matchingBerichte = berichte.FindAll
                    (bericht => bericht.zeitpunkt.Date.Equals(berichtDatum));
                displayBerichteOfList(matchingBerichte);
            }
        }

        private void btn_ToPatientenDaten_Click(object sender, EventArgs e)
        {
            controller.navBerichtOverviewToPatientenDaten();
        }

        private void displayBerichteOfList(List<Bericht> berichteToShow)
        {
            rowCount = 0;
            clearPatientTable();
            for (int i = 0; i < berichteToShow.Count; i++)
            {
                addBerichtToFrontend(berichteToShow[i]);
            }
        }

        private void addBerichtToFrontend(Bericht bericht)
        {
            Label datumLabel = new Label();
            datumLabel.Click += onBerichtSelected;
            datumLabel.Text = bericht.zeitpunkt.Date.ToString();

            Label uhrzeitLabel = new Label();
            uhrzeitLabel.Click += onBerichtSelected;
            uhrzeitLabel.Text = bericht.zeitpunkt.TimeOfDay.ToString();

            Label beschwerdenLabel = new Label();
            beschwerdenLabel.Click += onBerichtSelected;
            beschwerdenLabel.Text = bericht.beschwerden;

            Label diagnoseLabel = new Label();
            diagnoseLabel.Click += onBerichtSelected;
            diagnoseLabel.Text = bericht.diagnose.bezeichnung;

            Label bemerkungLabel = new Label();
            bemerkungLabel.Click += onBerichtSelected;
            bemerkungLabel.Text = bericht.bemerkung;

            tbl_Berichte.Controls.Add(datumLabel, 0, rowCount); ;
            tbl_Berichte.Controls.Add(uhrzeitLabel, 1, rowCount);
            tbl_Berichte.Controls.Add(beschwerdenLabel, 2, rowCount);
            tbl_Berichte.Controls.Add(diagnoseLabel, 3, rowCount);
            tbl_Berichte.Controls.Add(bemerkungLabel, 4, rowCount);
            rowCount++;
        }

        private void onBerichtSelected(object sender, EventArgs e)
        {

        }

        private void clearPatientTable()
        {
            tbl_Berichte.Controls.Clear();
        }

        private void refreshBerichtTable()
        {
            int firstBerichtIndexOfPage = pageIndex * ROW_AMOUNT;
            int lastBerichtIndexOfPage = ROW_AMOUNT;
            if (firstBerichtIndexOfPage + ROW_AMOUNT >= berichte.Count)
            {
                lastBerichtIndexOfPage = berichte.Count - firstBerichtIndexOfPage;
            }
            displayBerichteOfList(berichte.GetRange(firstBerichtIndexOfPage, lastBerichtIndexOfPage));
            setVisibilityOfPageButtons();
        }

        private void setVisibilityOfPageButtons()
        {
            if (pageIndex == 0)
            {
                btn_Zurueck.Enabled = false;
            }
            else
            {
                btn_Zurueck.Enabled = true;
            }
            if (!validateNextPage())
            {
                btn_Weiter.Enabled = false;
            }
            else
            {
                btn_Weiter.Enabled = true;
            }
        }

        private bool validateNextPage()
        {
            return (pageIndex + 1) * ROW_AMOUNT < berichte.Count;
        }

        private void btn_Weiter_Click(object sender, EventArgs e)
        {
            if (validateNextPage())
            {
                pageIndex++;
                lblPage.Text = (pageIndex + 1).ToString();
                setVisibilityOfPageButtons();
                refreshBerichtTable();
            }
        }

        private void btn_Zurueck_Click(object sender, EventArgs e)
        {
            if (pageIndex != 0)
            {
                pageIndex--;
                lblPage.Text = (pageIndex + 1).ToString();
                setVisibilityOfPageButtons();
                refreshBerichtTable();
            }
        }
    }
}
